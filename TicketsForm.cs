using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ShomreiTorah.Rafflizer {
	public partial class TicketsForm : XtraForm {
		readonly int year;
		public TicketsForm(int year) {
			InitializeComponent();
			this.year = year;
			Text = year + " Tickets";
		}
	}
}