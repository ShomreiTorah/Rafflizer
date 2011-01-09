using System;
using System.Collections.Generic;
using System.Linq;
using ShomreiTorah.Singularity;
using ShomreiTorah.Singularity.Sql;

namespace ShomreiTorah.Rafflizer {
	static class DBManager {
		///<summary>Creates the tables needed in a database.</summary>
		public static void SetupDatabase(DataSyncContext context) {
			using (var connection = context.SqlProvider.OpenConnection())
				foreach (var table in context.Tables.SortDependencies(ts => ts.Mapping.Schema))
					context.SqlProvider.CreateTable(connection, table.Mapping, context.Tables.Select(ts => ts.Mapping));
		}

		class RowValueComparer : IEqualityComparer<Row> {
			public bool Equals(Row x, Row y) {
				if (x == y) return true;
				if (x == null || y == null) return false;
				if (x.Schema != y.Schema) return false;

				foreach (var col in x.Schema.Columns) {
					var a = x[col];
					var b = y[col];

					var foreignKey = col as ForeignKeyColumn;
					if (foreignKey != null) {//If we're looking at a foreign key, compare its table's primary keys
						var primary = foreignKey.ForeignSchema.GetPrimaryKey();
						a = ((Row)a)[primary];
						b = ((Row)b)[primary];
					}

					if (!Equals(a, b)) return false;
				}
				return true;
			}

			public int GetHashCode(Row obj) {
				if (obj == null) return -1;
				unchecked {
					int hash = 17;
					foreach (var col in obj.Schema.Columns) {
						object value = obj[col];
						if (value == null)
							hash = hash * 23 - 1;
						else {
							var foreignKey = col as ForeignKeyColumn;
							if (foreignKey != null)	//If we're looking at a foreign key, get the hash of its table's primary key
								value = ((Row)value)[foreignKey.ForeignSchema.GetPrimaryKey()];
							hash = hash * 23 + value.GetHashCode();
						}
					}
					return hash;
				}
			}
		}
		static Column GetPrimaryKey(this TableSchema schema) { return SchemaMapping.GetPrimaryMapping(schema).PrimaryKey.Column; }
		static Lazy<T> Lazify<T>(Func<T> func) { return new Lazy<T>(func); }
		public static void PushData(DataContext from, DataContext to) {
			if (from == null) throw new ArgumentNullException("from");
			if (to == null) throw new ArgumentNullException("to");

			//Create a lazy primary key mapping for
			//each table. We use this dictionary to
			//get the corresponding row in the `to`
			//DataContext when copying foreign keys
			//Since it's lazy, it will also pick up
			//parent rows that were just added from
			//the source database.
			Dictionary<TableSchema, Lazy<Dictionary<object, Row>>> targetKeyMap = Program.Current.DataContext.Tables
				.Select(t => new { Table = to.Tables[t.Schema], Key = t.Schema.GetPrimaryKey() })
				.ToDictionary(
					o => o.Table.Schema,
					o => Lazify(() => o.Table.Rows.ToDictionary(row => row[o.Key]))
				);


			//We only synchronize the data we're interested in, 
			//even if we're pulling from a DataContext with more
			//tables.
			foreach (var schema in Program.Current.DataContext.Tables.Select(t => t.Schema).SortDependencies()) {
				var sourceTable = from.Tables[schema];
				var targetTable = to.Tables[schema];

				var key = SchemaMapping.GetPrimaryMapping(schema).PrimaryKey.Column;

				var modified = sourceTable.Rows.Except(targetTable.Rows, new RowValueComparer());
				var pairs = modified.GroupJoin(targetTable.Rows, r => r[key], r => r[key], (s, ts) => new { Source = s, Target = ts.SingleOrDefault() });
				foreach (var pair in pairs) {
					var destRow = pair.Target ?? targetTable.CreateRow();

					foreach (var column in schema.Columns) {
						var foreignKey = column as ForeignKeyColumn;
						if (foreignKey == null)
							destRow[column] = pair.Source[column];
						else {
							var sourceKey = ((Row)pair.Source[column])[foreignKey.ForeignSchema.GetPrimaryKey()];
							destRow[column] = targetKeyMap[foreignKey.ForeignSchema].Value[sourceKey];
						}
					}
					if (pair.Target == null)	//If we aren't updating an existing row,
						targetTable.Rows.Add(destRow);
				}
			}
		}
	}
}
