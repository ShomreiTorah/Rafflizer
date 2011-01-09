using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using ShomreiTorah.Common;
using ShomreiTorah.Data;
using ShomreiTorah.Data.UI;
using ShomreiTorah.Data.UI.Forms;
using ShomreiTorah.Singularity;
using ShomreiTorah.Singularity.Sql;
using ShomreiTorah.WinForms;
using DevExpress.UserSkins;

namespace ShomreiTorah.Rafflizer {
	class Program : AppFramework {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() { new Program().Run(); }

		///<summary>Gets the path to the application's SQL CE database.  This property is also available at design-time.</summary>
		public string FilePath {
			get {
				//TODO: Design-time
				if (IsDesignTime)
					return @"C:\Users\SSL\Development\Source\Shul\Applications\ShomreiTorah.Rafflizer\Bin\Debug\RaffleData.sdf";
				return "RaffleData.sdf";
			}
		}

		//TODO: Create splash image
		protected override ISplashScreen CreateSplash() { return null; }

		protected override void RegisterSettings() {
			Dialog.DefaultTitle = "Shomrei Torah Rafflizer";
			OfficeSkins.Register();
			SkinManager.EnableFormSkins();
			UserLookAndFeel.Default.SkinName = "Office 2010 Blue";
			RegisterRowDetail<Person>(p => new SimplePersonDetails(p).Show(MainForm));
		}

		protected override Form CreateMainForm() { return new MainForm(); }

		protected override DataSyncContext CreateDataContext() {
			var dc = new DataContext();
			dc.Tables.AddTable(Person.CreateTable());
			dc.Tables.AddTable(RaffleTicket.CreateTable());

			var dsc = new DataSyncContext(dc, new SqlCeSqlProvider(FilePath));

			dsc.Tables.AddPrimaryMappings();

			if (!File.Exists(FilePath)) {
				DB.CreateFile(FilePath, DatabaseFile.SqlCe);
				try {
					DBManager.SetupDatabase(dsc);
				} catch { File.Delete(FilePath); }
			}

			return dsc;
		}
	}
}
