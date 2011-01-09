using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraBars.Ribbon;
using ShomreiTorah.Common;
using ShomreiTorah.WinForms;

namespace ShomreiTorah.Rafflizer {
	class DBGallery {
		public DBGallery(BaseGallery gallery) {
			Gallery = gallery;
			Gallery.ItemClick += Gallery_ItemClick;
			Populate();
		}

		GalleryItem selectedItem;
		public BaseGallery Gallery { get; private set; }
		public GalleryItem SelectedItem {
			get { return selectedItem; }
			set {
				if (SelectedItem != null) SelectedItem.Checked = false;
				selectedItem = value;
				if (SelectedItem != null) SelectedItem.Checked = true;
			}
		}
		public DBConnector SelectedConnector {
			get { return SelectedItem == null ? null : (DBConnector)SelectedItem.Tag; }
		}

		void Gallery_ItemClick(object sender, GalleryItemClickEventArgs e) {
			SelectedItem = e.Item;
		}
		void Populate() {
			Gallery.Groups.Clear();
			var group = new GalleryItemGroup { Caption = "ShomreiTorahConfig" };

			foreach (var element in Config.GetElement("Databases").Elements()) {
				var connector = new DBConnector(element);
				var item = new GalleryItem {
					Image = Properties.Resources.SmallDB,
					Caption = element.Name.LocalName,
					SuperTip = Utilities.CreateSuperTip(title: connector.Factory.GetType().ToString(), body: connector.ConnectionString),
					Tag = connector
				};
				group.Items.Add(item);
			}
			Gallery.Groups.Add(group);
			SelectedItem = group.Items[0];
		}

	}
}
