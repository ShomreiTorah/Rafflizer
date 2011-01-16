using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using DevExpress.Data;
using DevExpress.XtraEditors;
using ShomreiTorah.Data;
using ShomreiTorah.Singularity;

namespace ShomreiTorah.Rafflizer {
	partial class TicketsForm : XtraForm {
		FilteredTable<RaffleTicket> tickets;
		public TicketsForm(int year) {
			InitializeComponent();
			Text = year + " Tickets";

			tickets = Program.Table<RaffleTicket>().Filter(t => t.Year == year);
			grid.DataMember = null;
			grid.DataSource = tickets;
			addPanel.SetData(year, tickets);

			tickets.RowAdded += Tickets_RowAdded;
			tickets.ValueChanged += Tickets_ValueChanged;
			tickets.RowRemoved += Tickets_RowRemoved;
			UpdateStats();
		}

		void Tickets_RowAdded(object sender, RowListEventArgs<RaffleTicket> e) {
			if (tickets.Rows.Count < 3)
				gridView.BestFitColumns();
			UpdateStats();
		}
		void Tickets_ValueChanged(object sender, ValueChangedEventArgs<RaffleTicket> e) { UpdateStats(); }
		void Tickets_RowRemoved(object sender, RowListEventArgs<RaffleTicket> e) { UpdateStats(); }

		void UpdateStats() {
			ticketCount.Caption = tickets.Rows.Count + " Tickets";
			totalValue.Caption = "Total value: " +
				tickets.Rows.GroupBy(t => t.Person, (person, set) => set.Count())
							.Sum(c => RaffleTicket.CalcPrice(c))
							.ToString("c0", CultureInfo.CurrentCulture)

			   + "; paid: "
			   + tickets.Rows.Where(t => t.Paid)
							 .GroupBy(t => t.Person, (person, set) => set.Count())
							 .Sum(c => RaffleTicket.CalcPrice(c))
							 .ToString("c0", CultureInfo.CurrentCulture);

			IList<int> idHoles;
			if (tickets.Rows.Count == 0)
				idHoles = new int[0];
			else
				idHoles = Enumerable.Range(1, tickets.Rows.Max(t => t.TicketId))
									.Except(tickets.Rows.Select(t => t.TicketId))
									.ToList();

			if (idHoles.Count == 0) {
				holeMessage.Caption = "No Holes";
				holeMessage.Appearance.ForeColor = Color.Green;
			} else if (idHoles.Count == 1) {
				holeMessage.Appearance.ForeColor = Color.Red;
				holeMessage.Caption = "Ticket #" + idHoles.First().ToString(CultureInfo.CurrentCulture) + " is missing";
			} else {
				holeMessage.Appearance.ForeColor = Color.Red;
				var message = new StringBuilder();

				for (int i = 0; i < idHoles.Count; ) {
					var start = idHoles[i];
					int size = 1;
					while (++i < idHoles.Count && idHoles[i] == start + size)
						size++;

					message.Append(message.Length == 0 ? "Holes: " : ", ");

					message.Append(start);
					if (size == 2)
						message.Append(", ").Append(start + 1);
					else if (size > 2)
						message.Append(" - ").Append(start + size - 1);
				}

				holeMessage.Caption = message.ToString();
			}
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

		private void gridView_CustomSummaryExists(object sender, CustomSummaryExistEventArgs e) {
			e.Exists = true;
		}
		private void gridView_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e) {
			switch (e.SummaryProcess) {
				case CustomSummaryProcess.Start:
					e.TotalValue = 0;
					break;
				case CustomSummaryProcess.Calculate:
					e.TotalValue = (int)e.TotalValue + 1;
					break;
				case CustomSummaryProcess.Finalize:
					e.TotalValue = RaffleTicket.CalcPrice((int)e.TotalValue);
					e.TotalValueReady = true;
					break;
			}
		}
	}
}