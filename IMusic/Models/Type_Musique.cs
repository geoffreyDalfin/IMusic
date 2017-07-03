using System;
namespace IMusic.Models
{
	public class Type_Musique
	{
		private int Id;
		private String Genre;

		public Type_Musique() { }

		public Type_Musique(int id, String genre)
		{
			this.Id = id;
			this.Genre = genre;
		}
	}
}
