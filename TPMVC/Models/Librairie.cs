using Microsoft.AspNetCore.Server.HttpSys;
using System;
using System.Collections.Generic;

namespace TPMVC.Models
{
    public static class Librairie
    {
        public static List<Livre> LesLivres = new List<Livre>();
        public static List<Employe> LesEmployes = new List<Employe>();

        public static List<Livre> CreerListe()
        {
            Livre livre1 = new Livre("Le Meilleur des Mondes", "Aldous Huxley", 319);
            Livre livre2 = new Livre("L'Attrape Coeur", "J-D. Salinger", 256);
            Livre livre3 = new Livre("Le Chuchoteur", "Donato Carrisi", 340);
            Livre livre4 = new Livre("Blackwater", "Michael McDowell", 259);
            Livre livre5 = new Livre("Un long chemin vers la liberté", "Nelson Mandela", 768);
            LesLivres.Add(livre1);
            LesLivres.Add(livre2);
            LesLivres.Add(livre3);
            LesLivres.Add(livre4);
            LesLivres.Add(livre5);

            return LesLivres;
        }

        public static List<Employe> CreerListeEmploye()
        {
            Employe jim = new Employe() { Nom = "Halpert", Prenom = "Jim", Age = 32, Rayon = "BD_Comics"};
            Employe pam = new Employe() { Nom = "Beesly", Prenom = "Pam", Age = 30, Rayon = "Littérature" };
            Employe michael = new Employe() { Nom = "Scott", Prenom = "Michael", Age = 43, Rayon = "Enfants" };
            Employe dwight = new Employe() { Nom = "Schrute", Prenom = "Dwight", Age = 41, Rayon = "Histoire" };
            Employe kelly = new Employe() { Nom = "Kapoor", Prenom = "Kelly", Age = 28, Rayon = "Sciences sociales" };

            LesEmployes.Add(jim);
            LesEmployes.Add(pam);
            LesEmployes.Add(michael);
            LesEmployes.Add(dwight);
            LesEmployes.Add(kelly);

            return LesEmployes;
        }

        public static List<Livre> ObtenirLivres()
        {
            return LesLivres;
        }

        public static List<Employe> ObtenirEmployes()
        {
            return LesEmployes;
        }

        public static void AjouterLivre(Livre livre)
        {
            ObtenirLivres().Add(livre);
        }

        public static void SupprimerLivre(Livre livre)
        {
            ObtenirLivres().Remove(livre);
        }

    }
}

