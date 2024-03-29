using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ShomreiTorah.Common;
using ShomreiTorah.Data;
using ShomreiTorah.Singularity;
using ShomreiTorah.WinForms;
using ShomreiTorah.WinForms.Forms;

namespace ShomreiTorah.Rafflizer {
	partial class AddPanel : DevExpress.XtraEditors.XtraUserControl {
		int year;
		FilteredTable<RaffleTicket> tickets;

		public AddPanel() {
			InitializeComponent();
			SetState();
			ticketId.KeyDown += TicketId_KeyDown;
		}

		public void SetData(int newYear, FilteredTable<RaffleTicket> datasource) {
			if (datasource == null) throw new ArgumentNullException("datasource");
			if (datasource.Rows.Any(t => t.Year != newYear))
				throw new ArgumentException("Wrong year", "datasource");

			this.year = newYear;
			this.tickets = datasource;
		}

		private void personSelector_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape)
				personSelector.SelectedPerson = null;
		}
		private void Controls_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == '+' || e.KeyChar == '=') {
				e.Handled = true;
				SetLastTicket();
			}
		}
		void TicketId_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.P) {
				e.Handled = true;
				isPaid.Checked = !isPaid.Checked;
			}
		}

		private void Controls_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter)
				AddTicket();
			else if (e.KeyCode == Keys.Escape) {
				personSelector.SelectedPerson = null;
				personSelector.Focus();
			}
		}

		void SetLastTicket() {
			if (lastTicket == null) {
				Dialog.Inform("No tickets have been added.");
				return;
			}
			personSelector.SelectedPerson = lastTicket.Person;
			//TicketID is set by personSelector_EditValueChanged
			isPaid.Checked = lastTicket.Paid;
			comments.Text = lastTicket.Comments;
		}

		private void comments_ButtonClick(object sender, ButtonPressedEventArgs e) { AddTicket(); }

		RaffleTicket lastTicket;
		void AddTicket() {
			var idDup = tickets.Rows.FirstOrDefault(t => t.TicketId == ticketId.Value);
			if (idDup != null) {
				if (DialogResult.No == XtraMessageBox.Show(
						"Ticket #" + ticketId.Value + " was already given to " + idDup.Person.VeryFullName + ".\r\nAre you sure you want to add a duplicate ticket?",
						Dialog.DefaultTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2
				))
					return;
			}

			if (personSelector.SelectedPerson == null) return;

			Program.Table<RaffleTicket>().Rows.Add(lastTicket = new RaffleTicket {
				Year = year,
				Person = personSelector.SelectedPerson,
				TicketId = (int)ticketId.Value,
				Paid = isPaid.Checked,
				Comments = String.IsNullOrWhiteSpace(comments.Text) ? null : comments.Text,
				DateAdded = DateTime.Now
			});
			InfoMessage.Show("Ticket #" + ticketId.Value + " was registered for " + personSelector.SelectedPerson.VeryFullName 
						   + ", " + (isPaid.Checked ? "paid" : "unpaid"));

			if (ModifierKeys == Keys.Shift) {
				ticketId.Value = NextID;
				ticketId.Focus();
			} else {
				personSelector.SelectedPerson = null;	//The EditValueChanged handler will reset other fields
				personSelector.Focus();
			}
		}

		private void personSelector_EditValueChanged(object sender, EventArgs e) {
			SetState();
			if (personSelector.SelectedPerson != null) {
				isPaid.Checked = false;
				comments.Text = null;
				ticketId.Value = NextID;
				ticketId.Focus();
			}
		}
		void SetState() {
			comments.Visible = ticketId.Visible = isPaid.Visible = (personSelector.SelectedPerson != null);
		}

		int NextID {
			get {
				if (tickets.Rows.Count == 0)
					return 1;

				int retVal = tickets.Rows.FindMax(t => t.DateAdded.Ticks).TicketId;
				while (tickets.Rows.Any(t => t.TicketId == retVal))
					retVal++;

				return retVal;
			}
		}
	}
}
