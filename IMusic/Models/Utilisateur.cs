using System;
namespace IMusic.Models
{
	public class Utilisateur
	{
		private int Id;
		private String AdresseMail;
		private String Nom;
		private String Prenom;
		private int Age;
		private String Pseudonyme;
		private int NumeroTelephone;
		private int CodePostal;
		private String Adresse;
		private String Ville;
		private String MotDePasse;
		public Utilisateur()
		{ }
		public Utilisateur(int id, String adressMail, String nom, String prenom, int age, String pseudo, int num, int cp, String addresse, String ville, String mdp)
		{
			this.Id = id;
			this.AdresseMail = adressMail;
			this.Nom = nom;
			this.Prenom = prenom;
			this.Age = age;
			this.Pseudonyme = pseudo;
			this.NumeroTelephone = num;
			this.CodePostal = cp;
			this.Adresse = addresse;
			this.Ville = ville;
			this.MotDePasse = mdp;

		}
	}
}
