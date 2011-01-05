using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShomreiTorah.Common;
using ShomreiTorah.Data;
using ShomreiTorah.Data.UI;
using DevExpress.XtraBars;
using ShomreiTorah.WinForms;

namespace ShomreiTorah.Rafflizer {
	partial class MainForm : XtraForm {
		public MainForm() {
			InitializeComponent();

			showTickets.SetupYearlyButton<RaffleTicket>(
				t => t.Year,
				year => new TicketsForm(year) { MdiParent = this }.Show(),
				defaultYear: DateTime.Now.AddMonths(5).Year	//We start using this in December of the previous year
			);
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
	}
}
