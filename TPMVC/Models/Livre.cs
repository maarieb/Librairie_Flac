using System.Collections.Generic;

namespace TPMVC.Models
{
    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NbPages { get; set; }

        public Livre(string titre, string auteur, int nbPages)
        {
            Titre = titre;
            Auteur = auteur;
            NbPages = nbPages;
        }

        public override string ToString()
        {
            return Titre;
        }
    }
}
