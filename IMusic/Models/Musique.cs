using System;
using Newtonsoft.Json;
namespace IMusic.Models
{
	public class Musique
	{
		[JsonProperty(PropertyName = "IdMusique")]
		public int Id { get; set; }
		[JsonProperty(PropertyName = "IdUser")]
		public int IdUser { get; set; }
		[JsonProperty(PropertyName = "Titre")]
		public String Titre { get; set; }

		[JsonProperty(PropertyName = "Path")]
		public String PathMusique { get; set; }

		public Musique() { }

		public Musique(String titre, String pathMusique)
		{
			this.Titre = titre;
			this.PathMusique = pathMusique;
		}
	}
}
