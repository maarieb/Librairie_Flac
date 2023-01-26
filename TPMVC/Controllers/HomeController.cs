using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using TPMVC.Models;
using TPMVC.ViewModel;

namespace TPMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        { 
            return View("Index");
        }

        public IActionResult VoirLivre()
        {
            List<string> lesTitres = new List<string>();

            foreach(Livre l in Librairie.LesLivres)
            {
                lesTitres.Add(l.Titre);
            }

            HomeViewModel hvm = new HomeViewModel()
            {
                Livres = Librairie.ObtenirLivres(),
                Titres = lesTitres
            };

            return View(hvm);
        }

        public IActionResult VoirEmploye() 
        {
            HomeViewModel hvm = new HomeViewModel()
            {
                Employes = Librairie.ObtenirEmployes(),
            };

            return View(hvm);
        }

        public IActionResult Ajout(string titre, string auteur, int nbPages)
        {
            Livre livre = new Livre(titre, auteur, nbPages);

            if (titre != null && auteur != null)
            {
                HomeViewModel hvm = new HomeViewModel()
                {
                    Titre = titre,
                    Auteur = auteur,
                    NbPages = nbPages
                };
                Librairie.AjouterLivre(livre);
                return View(hvm);
            }
            return View("Erreur");
        }

        public ViewResult Supp(string titre)
        {
            Livre livre = Librairie.ObtenirLivres().FirstOrDefault(livre => livre.Titre == titre);
            
            if (livre != null)
            {
                HomeViewModel hvm = new HomeViewModel()
                {
                    Titre = titre,
                };
                Librairie.SupprimerLivre(livre);
                return View(hvm);
            }
            return View("Erreur");
        }

        public IActionResult FormulaireAjout(string titre, string auteur, int nbPages)
        {
           return View("FormulaireAjout");

        }

    }
}
