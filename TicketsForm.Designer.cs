namespace ShomreiTorah.Rafflizer {
	partial class TicketsForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.exportExcel = new DevExpress.XtraBars.BarButtonItem();
			this.holeMessage = new DevExpress.XtraBars.BarStaticItem();
			this.ticketCount = new DevExpress.XtraBars.BarStaticItem();
			this.totalValue = new DevExpress.XtraBars.BarStaticItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.grid = new ShomreiTorah.Data.UI.Grid.SmartGrid(this.components);
			this.gridView = new ShomreiTorah.Data.UI.Grid.SmartGridView();
			this.colPerson = new ShomreiTorah.Data.UI.Grid.SmartGridColumn();
			this.colDateAdded = new ShomreiTorah.Data.UI.Grid.SmartGridColumn();
			this.colTicketId = new ShomreiTorah.Data.UI.Grid.SmartGridColumn();
			this.colPaid = new ShomreiTorah.Data.UI.Grid.SmartGridColumn();
			this.colComments = new ShomreiTorah.Data.UI.Grid.SmartGridColumn();
			this.colRowId = new ShomreiTorah.Data.UI.Grid.SmartGridColumn();
			this.addPanel = new ShomreiTorah.Rafflizer.AddPanel();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ApplicationButtonText = null;
			// 
			// 
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.ExpandCollapseItem.Name = "";
			this.ribbonControl1.ExpandCollapseItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.exportExcel,
            this.holeMessage,
            this.ticketCount,
            this.totalValue});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 5;
			this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.SelectedPage = this.ribbonPage1;
			this.ribbonControl1.Size = new System.Drawing.Size(658, 114);
			this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
			this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			// 
			// exportExcel
			// 
			this.exportExcel.Caption = "Export to Excel";
			this.exportExcel.Id = 1;
			this.exportExcel.LargeGlyph = global::ShomreiTorah.Rafflizer.Properties.Resources.ExportExcel32;
			this.exportExcel.Name = "exportExcel";
			// 
			// holeMessage
			// 
			this.holeMessage.Appearance.ForeColor = System.Drawing.Color.Green;
			this.holeMessage.Appearance.Options.UseForeColor = true;
			this.holeMessage.Caption = "No holes";
			this.holeMessage.Id = 2;
			this.holeMessage.Name = "holeMessage";
			this.holeMessage.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// ticketCount
			// 
			this.ticketCount.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.ticketCount.Caption = "n Tickets";
			this.ticketCount.Id = 3;
			this.ticketCount.Name = "ticketCount";
			this.ticketCount.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// totalValue
			// 
			this.totalValue.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.totalValue.Caption = "Total: $n";
			this.totalValue.Id = 4;
			this.totalValue.Name = "totalValue";
			this.totalValue.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Data";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.exportExcel);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.ShowCaptionButton = false;
			this.ribbonPageGroup1.Text = "Raffle";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.ItemLinks.Add(this.holeMessage);
			this.ribbonStatusBar1.ItemLinks.Add(this.ticketCount);
			this.ribbonStatusBar1.ItemLinks.Add(this.totalValue);
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 411);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(658, 25);
			// 
			// grid
			// 
			this.grid.DataMember = "RaffleTickets";
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(0, 158);
			this.grid.MainView = this.gridView;
			this.grid.MenuManager = this.ribbonControl1;
			this.grid.Name = "grid";
			this.grid.RegistrationCount = 48;
			this.grid.Size = new System.Drawing.Size(658, 253);
			this.grid.TabIndex = 1;
			this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// gridView
			// 
			this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPerson,
            this.colDateAdded,
            this.colTicketId,
            this.colPaid,
            this.colComments});
			this.gridView.GridControl = this.grid;
			this.gridView.Name = "gridView";
			this.gridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
			this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTicketId, DevExpress.Data.ColumnSortOrder.Descending)});
			// 
			// colPerson
			// 
			this.colPerson.AllowKeyboardActivation = false;
			this.colPerson.FieldName = "Person";
			this.colPerson.Name = "colPerson";
			this.colPerson.OptionsColumn.AllowEdit = false;
			this.colPerson.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
			this.colPerson.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
			this.colPerson.OptionsColumn.ReadOnly = true;
			this.colPerson.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
			this.colPerson.ShowEditorOnMouseDown = true;
			this.colPerson.Visible = true;
			this.colPerson.VisibleIndex = 0;
			this.colPerson.Width = 52;
			// 
			// colDateAdded
			// 
			this.colDateAdded.DisplayFormat.FormatString = "G";
			this.colDateAdded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colDateAdded.FieldName = "DateAdded";
			this.colDateAdded.Name = "colDateAdded";
			this.colDateAdded.OptionsColumn.AllowEdit = false;
			this.colDateAdded.OptionsColumn.ReadOnly = true;
			this.colDateAdded.Visible = true;
			this.colDateAdded.VisibleIndex = 1;
			this.colDateAdded.Width = 76;
			// 
			// colTicketId
			// 
			this.colTicketId.FieldName = "TicketId";
			this.colTicketId.Name = "colTicketId";
			this.colTicketId.Visible = true;
			this.colTicketId.VisibleIndex = 2;
			this.colTicketId.Width = 73;
			// 
			// colPaid
			// 
			this.colPaid.FieldName = "Paid";
			this.colPaid.Name = "colPaid";
			this.colPaid.OptionsColumn.FixedWidth = true;
			this.colPaid.ShowEditorOnMouseDown = true;
			this.colPaid.Visible = true;
			this.colPaid.VisibleIndex = 3;
			this.colPaid.Width = 50;
			// 
			// colComments
			// 
			this.colComments.FieldName = "Comments";
			this.colComments.Name = "colComments";
			this.colComments.ShowEditorOnMouseDown = true;
			this.colComments.Visible = true;
			this.colComments.VisibleIndex = 4;
			this.colComments.Width = 69;
			// 
			// colRowId
			// 
			this.colRowId.FieldName = "RowId";
			this.colRowId.Name = "colRowId";
			this.colRowId.Visible = true;
			this.colRowId.VisibleIndex = 0;
			// 
			// addPanel
			// 
			this.addPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.addPanel.Location = new System.Drawing.Point(0, 114);
			this.addPanel.Name = "addPanel";
			this.addPanel.Size = new System.Drawing.Size(658, 44);
			this.addPanel.TabIndex = 3;
			// 
			// TicketsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 436);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.addPanel);
			this.Controls.Add(this.ribbonControl1);
			this.KeyPreview = true;
			this.Name = "TicketsForm";
			this.Text = "TicketsForm";
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarButtonItem exportExcel;
		private Data.UI.Grid.SmartGrid grid;
		private Data.UI.Grid.SmartGridView gridView;
		private Data.UI.Grid.SmartGridColumn colPerson;
		private Data.UI.Grid.SmartGridColumn colDateAdded;
		private Data.UI.Grid.SmartGridColumn colTicketId;
		private Data.UI.Grid.SmartGridColumn colPaid;
		private Data.UI.Grid.SmartGridColumn colComments;
		private Data.UI.Grid.SmartGridColumn colRowId;
		private AddPanel addPanel;
		private DevExpress.XtraBars.BarStaticItem holeMessage;
		private DevExpress.XtraBars.BarStaticItem ticketCount;
		private DevExpress.XtraBars.BarStaticItem totalValue;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
	}
}