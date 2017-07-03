using System;
using IMusic.Models;
using IMusic.Services;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Prism.Commands;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Plugin.FilePicker.Abstractions;
using Plugin.FilePicker;

namespace IMusic.ViewModels
{
	public class MusicViewModel : INotifyPropertyChanged
	{

		private List<Musique> itemsMusic;

		public List<Musique> ItemMusic
		{
			get
			{
				return itemsMusic;
			}
			set
			{
				itemsMusic = value;
				OnPropertyChanged("ItemMusic");
			}
		}

		public ICommand AddMusique
		{
			get;
			private set;
		}


		public MusicViewModel()
		{
			ItemMusic = new List<Musique>();
			GetItem();

			AddMusique = new DelegateCommand(
				async () =>
				{
					FileData fileData = new FileData();
					fileData = await CrossFilePicker.Current.PickFile();
					byte[] data = fileData.DataArray;
					string name = " " + fileData.FileName;
				});
		}

		async Task<List<Musique>> GetItem()
		{
			List<Musique> lstmusic = await MusiqueService.GellAllMusic();
			ItemMusic = lstmusic;
			return ItemMusic;
		}



		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}



	}
}
