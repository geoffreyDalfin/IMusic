using System;
using IMusic.Models;
using IMusic.Services;
using IMusic.Views;
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
using System.Diagnostics;

namespace IMusic.ViewModels
{
	public class MusicViewModel : INotifyPropertyChanged
	{

		public Musique Item
		{
			get;
			set;

		}

		public int Id
		{
			get { return this.Item.Id; }
		}

		public String Titre
		{
			get
			{
				return this.Item.Titre;
			}
			set
			{
				this.Item.Titre = value;
				OnPropertyChanged("Titre");
			}
		}

		public String PathMusique
		{
			get
			{
				return this.Item.PathMusique;
			}
			set
			{
				this.Item.PathMusique = value;
				OnPropertyChanged("PathMusique");
			}
		}

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

		public ICommand Refresh
		{
			get;
			private set;
		}

		public ICommand GoToMusique
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
					try
					{
						FileData fileData = new FileData();
						fileData = await CrossFilePicker.Current.PickFile();
						byte[] data = fileData.DataArray;
						string name = fileData.FileName;
						string filePath = fileData.FileName;
					}
					catch (Exception ex)
					{

						Debug.WriteLine("Command poste marche" + ex);
					}
					/*FileData fileData = new FileData();
					fileData = await CrossFilePicker.Current.PickFile();
					byte[] data = fileData.DataArray;
					string name = " " + fileData.FileName;*/
				});

			Refresh = new DelegateCommand(
				async () =>
			{
				IsBusy = true;
				var att = await GetItem();
				IsBusy = false;
			});

			GoToMusique = new DelegateCommand(
				async () =>
			{
				var musiquePage = new MusicPage(new MusicViewModel());
				await Application.Current.MainPage.Navigation.PushAsync(musiquePage);
			});
		}

		bool isBusy;

		public bool IsBusy
		{
			get { return isBusy; }
			set
			{
				if (isBusy == value)
					return;

				isBusy = value;
				OnPropertyChanged("IsBusy");
			}

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
