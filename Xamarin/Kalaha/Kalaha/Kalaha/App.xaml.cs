using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Akavache;
using Xamarin.Forms;

namespace Kalaha
{
	public partial class App : Application
	{
		public App ()
		{
		    BlobCache.ApplicationName = nameof(Kalaha);
            InitializeComponent();

		    var bootstrapper = new AppBootstrapper();
		    MainPage = bootstrapper.CreateMainPage();
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
