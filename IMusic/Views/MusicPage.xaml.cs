using Xamarin.Forms;
using IMusic.Views;
using IMusic.ViewModels;
using IMusic.Models;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;

namespace IMusic.Views
{
	public partial class MusicPage : ContentPage
	{
		private IPlaybackController PlaybackController => CrossMediaManager.Current.PlaybackController;

		public MusicPage(Musique sourceMusical)
		{
			InitializeComponent();
			this.BindingContext = sourceMusical;
			labelmusic.Text = sourceMusical.Titre;
			CrossMediaManager.Current.PlayingChanged += (sender, e) =>
			{
				ProgressBar.Progress = e.Progress;
				Duration.Text = e.Position.Minutes.ToString()+ ":" + e.Position.Seconds.ToString() + "/" + e.Duration.Minutes.ToString()+":"+ e.Duration.Seconds.ToString();
			};
		}

		void PlayClicked(object sender, System.EventArgs e)
		{
			PlaybackController.Play();
		}

		void PauseClicked(object sender, System.EventArgs e)
		{
			 PlaybackController.Pause();
		}

		void StopClicked(object sender, System.EventArgs e)
		{
			PlaybackController.Stop();
		}
	}
}
