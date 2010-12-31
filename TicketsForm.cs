using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShomreiTorah.Singularity;
using ShomreiTorah.Data;

namespace ShomreiTorah.Rafflizer {
	partial class TicketsForm : XtraForm {
		readonly int year;
		FilteredTable<RaffleTicket> tickets;
		public TicketsForm(int year) {
			InitializeComponent();
			this.year = year;
			Text = year + " Tickets";

			tickets = Program.Table<RaffleTicket>().Filter(t => t.Year == year);
			grid.DataMember = null;
			grid.DataSource = tickets;
			addPanel.SetData(year, tickets);

			tickets.RowAdded += Tickets_RowAdded;
		}

		void Tickets_RowAdded(object sender, RowListEventArgs<RaffleTicket> e) {
			if (tickets.Rows.Count < 3)
				gridView.BestFitColumns();
		}

		///<summary>Releases the unmanaged resources used by the TicketsForm and optionally releases the managed resources.</summary>
		///<param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				tickets.Dispose();			
				if (components != null) components.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}