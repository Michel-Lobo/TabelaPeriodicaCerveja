using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TabelaCervejaMobi.ViewModel;
using Xamarin.Forms;

namespace TabelaCervejaMobi
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new TabelaCervejaMobi.MainPage();
            BindingContext = new EstiloCervejaViewModel();
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
