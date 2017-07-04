using Xamarin.Forms;
using Plugin.MediaManager.Forms;

namespace IMusic
{
	public partial class App : Application
	{
		public App()
		{
			var workaround = typeof(VideoView);
			InitializeComponent();
			/*
			MainPage = new Views.RootPage()
			{
				//BarBackgroundColor = Color.FromHex("#03A9F4")
			};*/
			MainPage = new NavigationPage(new IMusic.Views.HomePage(new ViewModels.MusicViewModel()));
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
