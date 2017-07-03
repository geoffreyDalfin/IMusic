using Xamarin.Forms;
using IMusic.Views;
using IMusic.ViewModels;

namespace IMusic.Views
{
	public partial class MusicPage : ContentPage
	{
		public MusicPage(MusicViewModel sourceMusical)
		{
			InitializeComponent();
			this.BindingContext = sourceMusical;
		}
	}
}
