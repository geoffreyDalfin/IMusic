using Xamarin.Forms;

namespace IMusic
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new Views.HomePage(new ViewModels.MusicViewModel()))
			{
				BarBackgroundColor = Color.FromHex("#03A9F4")
			};
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
