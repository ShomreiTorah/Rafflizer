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
	}
}
