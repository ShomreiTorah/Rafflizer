using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ShomreiTorah.Data;
using ShomreiTorah.Data.UI;
using ShomreiTorah.Singularity;
using ShomreiTorah.Singularity.Sql;
using ShomreiTorah.WinForms;
using ShomreiTorah.WinForms.Forms;

namespace ShomreiTorah.Rafflizer {
	partial class MainForm : XtraForm {
		readonly DBGallery databases;
		public MainForm() {
			InitializeComponent();

			showTickets.SetupYearlyButton<RaffleTicket>(
				t => t.Year,
				year => new TicketsForm(year) { MdiParent = this }.Show(),
				defaultYear: DateTime.Now.AddMonths(5).Year	//We start using this in December of the previous year
			);
			databases = new DBGallery(dbGallery.Gallery);
		}

		private void saveDB_ItemClick(object sender, ItemClickEventArgs e) { Program.Current.SaveDatabase(); }
		protected override void OnClosing(CancelEventArgs e) {
			if (Program.Current.HasDataChanged) {
				switch (Dialog.Show("You have not saved your changes to the database.\r\nWould you like to save before exiting?",
									MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)) {
					case DialogResult.Yes:
						Program.Current.SaveDatabase();
						break;
					case DialogResult.No:
						break;
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
				}
			}
			base.OnClosing(e);
		}

		private void pullData_ItemClick(object sender, ItemClickEventArgs e) {
			var syncContext = CreateServerContext();
			DBManager.PushData(syncContext.DataContext, Program.Current.DataContext);
		}

		private void pushData_ItemClick(object sender, ItemClickEventArgs e) {
			var syncContext = CreateServerContext();
			DBManager.PushData(Program.Current.DataContext, syncContext.DataContext);

			if (syncContext.Tables.Any(t => t.Changes.Any()))
				ProgressWorker.Execute(syncContext.WriteData, cancellable: false);
		}

		DataSyncContext CreateServerContext() {
			var context = new DataContext();
			var syncContext = new DataSyncContext(context, new SqlServerSqlProvider(databases.SelectedConnector));

			//Add all of the tables that we actually use.
			foreach (var ts in Program.Current.SyncContext.Tables.SortDependencies(ts => ts.Table.Schema)) {
				var table = ts.Table.Schema.CreateTable();
				context.Tables.AddTable(table);
				syncContext.Tables.AddMapping(ts.Mapping);
			}
			ProgressWorker.Execute(ui => {
				ui.Caption = "Reading " + databases.SelectedItem.Caption;
				syncContext.ReadData();
			}, cancellable: false);
			return syncContext;
		}
	}
}
