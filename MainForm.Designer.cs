namespace ShomreiTorah.Rafflizer {
	partial class MainForm {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges1 = new DevExpress.Skins.SkinPaddingEdges();
			this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.showTickets = new DevExpress.XtraBars.BarButtonItem();
			this.saveDB = new DevExpress.XtraBars.BarButtonItem();
			this.dbGallery = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.pushData = new DevExpress.XtraBars.BarButtonItem();
			this.pullData = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// xtraTabbedMdiManager1
			// 
			this.xtraTabbedMdiManager1.MdiParent = this;
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
            this.showTickets,
            this.saveDB,
            this.dbGallery,
            this.pushData,
            this.pullData});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 6;
			this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.SelectedPage = this.ribbonPage1;
			this.ribbonControl1.Size = new System.Drawing.Size(706, 114);
			this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			// 
			// showTickets
			// 
			this.showTickets.Caption = "Show Tickets";
			this.showTickets.Id = 1;
			this.showTickets.LargeGlyph = global::ShomreiTorah.Rafflizer.Properties.Resources.Grid32;
			this.showTickets.Name = "showTickets";
			// 
			// saveDB
			// 
			this.saveDB.Caption = "Save";
			this.saveDB.Glyph = global::ShomreiTorah.Rafflizer.Properties.Resources.Save16;
			this.saveDB.Id = 2;
			this.saveDB.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
			this.saveDB.LargeGlyph = global::ShomreiTorah.Rafflizer.Properties.Resources.Save32;
			this.saveDB.Name = "saveDB";
			this.saveDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveDB_ItemClick);
			// 
			// dbGallery
			// 
			this.dbGallery.Caption = "Databases";
			// 
			// 
			// 
			this.dbGallery.Gallery.ColumnCount = 2;
			galleryItemGroup1.Caption = "ShomreiTorahConfig";
			galleryItem1.Caption = "LFC";
			galleryItem1.Checked = true;
			galleryItem1.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem1.Image")));
			galleryItem2.Caption = "Item2";
			galleryItem2.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem2.Image")));
			galleryItem3.Caption = "Item3";
			galleryItem3.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem3.Image")));
			galleryItem4.Caption = "Item4";
			galleryItem4.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem4.Image")));
			galleryItem5.Caption = "Item5";
			galleryItem5.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem5.Image")));
			galleryItem6.Caption = "Item6";
			galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6});
			this.dbGallery.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
			this.dbGallery.Gallery.ImageSize = new System.Drawing.Size(12, 16);
			this.dbGallery.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
			skinPaddingEdges1.Top = 3;
			this.dbGallery.Gallery.ItemTextPadding = skinPaddingEdges1;
			this.dbGallery.Gallery.ShowItemText = true;
			this.dbGallery.Id = 3;
			this.dbGallery.Name = "dbGallery";
			// 
			// pushData
			// 
			this.pushData.Caption = "Push";
			this.pushData.Glyph = global::ShomreiTorah.Rafflizer.Properties.Resources.ServerPush16;
			this.pushData.Id = 4;
			this.pushData.Name = "pushData";
			this.pushData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.pushData_ItemClick);
			// 
			// pullData
			// 
			this.pullData.Caption = "Pull";
			this.pullData.Glyph = global::ShomreiTorah.Rafflizer.Properties.Resources.ServerPull16;
			this.pullData.Id = 5;
			this.pullData.Name = "pullData";
			this.pullData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.pullData_ItemClick);
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Data";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.showTickets);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.ShowCaptionButton = false;
			this.ribbonPageGroup1.Text = "Raffle";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.saveDB);
			this.ribbonPageGroup2.ItemLinks.Add(this.dbGallery, true);
			this.ribbonPageGroup2.ItemLinks.Add(this.pullData);
			this.ribbonPageGroup2.ItemLinks.Add(this.pushData);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.ShowCaptionButton = false;
			this.ribbonPageGroup2.Text = "Database";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(706, 486);
			this.Controls.Add(this.ribbonControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "MainForm";
			this.Text = "Shomrei Torah Rafflizer";
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarButtonItem showTickets;
		private DevExpress.XtraBars.BarButtonItem saveDB;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.RibbonGalleryBarItem dbGallery;
		private DevExpress.XtraBars.BarButtonItem pushData;
		private DevExpress.XtraBars.BarButtonItem pullData;


	}
}

