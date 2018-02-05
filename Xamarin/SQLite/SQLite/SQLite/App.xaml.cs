using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace SQLite
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
  

		    var conn = new SQLiteAsyncConnection(DependencyService.Get<IFileHelper>().GetLocalFilePath("db.sqlite"));
		    conn.CreateTableAsync<Start>().GetAwaiter().GetResult();

            conn.InsertAsync(new Start {Time = DateTime.Now});
            
            MainPage = new SQLite.MainPage(conn);
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
