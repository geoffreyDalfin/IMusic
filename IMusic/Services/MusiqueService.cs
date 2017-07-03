using IMusic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace IMusic.Services
{
	public class MusiqueService
	{
		public MusiqueService()
		{
		}

		public static async Task<List<Musique>> GellAllMusic()
		{
			var musiqueList = new List<Musique>();
			try
			{
				using (var httpClient = new HttpClient())
				{
					var result = await httpClient.GetAsync("http://localhost:1337/allMusic/");
					var responseText = await result.Content.ReadAsStringAsync();
					//Serialize the json object to our c# classes
					var Object = JsonConvert.DeserializeObject<IEnumerable<Musique>>(responseText);

					foreach (var musique in Object)
					{
						musiqueList.Add(new Musique
						{
							Id = musique.Id,
							Titre = musique.Titre,
							PathMusique = musique.PathMusique
						});
					}
				}
			}
			catch (Exception ex)
			{
				//In case we have a problem...
				Debug.WriteLine("Un probleme pour récupérer les musiques " + ex.Message);
			}
			return musiqueList;
		}

		public static async void SaveMusic(Musique music)
		{
			try
			{
				using (var httpClient = new HttpClient())
				{
					var data = JsonConvert.SerializeObject(music);
					var content = new StringContent(data, Encoding.UTF8, "application/json");
					var response = await httpClient.PostAsync("http://localhost:1337/upload/", content);
				}
			}
			catch (Exception ex)
			{ 
				Debug.WriteLine("Un probleme pour poster les musiques " + ex.Message);
			}
		}

		/*public static async void DeleteMusic(Musique music)
		{
			try
			{

			}
			catch (Exception ex)
			{ 
				
			}
		}*/
	}
}
