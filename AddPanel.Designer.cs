namespace ShomreiTorah.Rafflizer {
	partial class AddPanel {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPanel));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.personSelector = new ShomreiTorah.Data.UI.Controls.PersonSelector();
			this.ticketId = new DevExpress.XtraEditors.SpinEdit();
			this.isPaid = new DevExpress.XtraEditors.CheckEdit();
			this.comments = new DevExpress.XtraEditors.ButtonEdit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.personSelector.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ticketId.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.isPaid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.comments.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.personSelector);
			this.groupControl1.Controls.Add(this.ticketId);
			this.groupControl1.Controls.Add(this.isPaid);
			this.groupControl1.Controls.Add(this.comments);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(687, 44);
			this.groupControl1.TabIndex = 4;
			this.groupControl1.Text = "Add Ticket";
			// 
			// personSelector
			// 
			this.personSelector.Dock = System.Windows.Forms.DockStyle.Fill;
			this.personSelector.Location = new System.Drawing.Point(2, 22);
			this.personSelector.Name = "personSelector";
			toolTipItem1.Text = "Click to select a person";
			superToolTip1.Items.Add(toolTipItem1);
			toolTipTitleItem1.Text = "New Person...";
			toolTipItem2.Text = "Adds a new person to the master directory";
			superToolTip2.Items.Add(toolTipTitleItem1);
			superToolTip2.Items.Add(toolTipItem2);
			this.personSelector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, superToolTip1, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "New person...", 90, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("personSelector.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, superToolTip2, true)});
			this.personSelector.Properties.NullValuePrompt = "Click here to add a ticket";
			this.personSelector.Size = new System.Drawing.Size(409, 20);
			this.personSelector.TabIndex = 0;
			this.personSelector.EditValueChanged += new System.EventHandler(this.personSelector_EditValueChanged);
			this.personSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.personSelector_KeyDown);
			// 
			// ticketId
			// 
			this.ticketId.Dock = System.Windows.Forms.DockStyle.Right;
			this.ticketId.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ticketId.Location = new System.Drawing.Point(411, 22);
			this.ticketId.Name = "ticketId";
			this.ticketId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.ticketId.Properties.DisplayFormat.FormatString = "ID: {0:n0}";
			this.ticketId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.ticketId.Properties.EditFormat.FormatString = "ID: {0:n0}";
			this.ticketId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.ticketId.Properties.IsFloatValue = false;
			this.ticketId.Properties.Mask.EditMask = "ID: ###,###,##0";
			this.ticketId.Properties.MaxValue = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
			this.ticketId.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ticketId.Size = new System.Drawing.Size(73, 20);
			this.ticketId.TabIndex = 1;
			this.ticketId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
			// 
			// isPaid
			// 
			this.isPaid.Dock = System.Windows.Forms.DockStyle.Right;
			this.isPaid.Location = new System.Drawing.Point(484, 22);
			this.isPaid.Name = "isPaid";
			this.isPaid.Properties.AutoWidth = true;
			this.isPaid.Properties.Caption = "Paid?";
			this.isPaid.Size = new System.Drawing.Size(46, 18);
			this.isPaid.TabIndex = 2;
			this.isPaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
			// 
			// comments
			// 
			this.comments.Dock = System.Windows.Forms.DockStyle.Right;
			this.comments.Location = new System.Drawing.Point(530, 22);
			this.comments.Name = "comments";
			this.comments.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Add", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("comments.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
			this.comments.Properties.NullValuePrompt = "Comments";
			this.comments.Properties.NullValuePromptShowForEmptyValue = true;
			this.comments.Size = new System.Drawing.Size(155, 20);
			this.comments.TabIndex = 3;
			this.comments.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.comments_ButtonClick);
			this.comments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
			// 
			// AddPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupControl1);
			this.Name = "AddPanel";
			this.Size = new System.Drawing.Size(687, 44);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.personSelector.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ticketId.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.isPaid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.comments.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private Data.UI.Controls.PersonSelector personSelector;
		private DevExpress.XtraEditors.SpinEdit ticketId;
		private DevExpress.XtraEditors.CheckEdit isPaid;
		private DevExpress.XtraEditors.ButtonEdit comments;
	}
}
