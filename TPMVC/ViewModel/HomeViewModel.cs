using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using TPMVC.Models;

namespace TPMVC.ViewModel
{
    public class HomeViewModel
    {
        public List<Employe> Employes { get; set; }
        public List<Livre> Livres { get; set; }
        public List<string> Titres { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NbPages { get; set; }

    }
}
