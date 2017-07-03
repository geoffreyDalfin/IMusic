using System;
namespace IMusic.Models
{
	public class Auteur
	{
		private int Id;
		private String Nom;
		private String Prenom;
		private String NomScene;

		public Auteur() { }

		public Auteur(int id, String nom, String prenom, String nomScene)
		{
			this.Id = id;
			this.Nom = nom;
			this.Prenom = prenom;
			this.NomScene = nomScene;
		}
	}
}
