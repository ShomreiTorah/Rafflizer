using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShomreiTorah.Common;
using ShomreiTorah.Singularity;
using ShomreiTorah.Singularity.Sql;
namespace ShomreiTorah.Rafflizer {
	class DBManager {
		///<summary>Creates the tables needed in a database.</summary>
		public static void SetupDatabase(DataSyncContext context) {
			using (var connection = context.SqlProvider.OpenConnection())
				foreach (var table in context.Tables.SortDependencies(ts => ts.Mapping.Schema))
					context.SqlProvider.CreateTable(connection, table.Mapping, context.Tables.Select(ts => ts.Mapping));
		}
	}
}
