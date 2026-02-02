using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice14.Classes
{
    internal class User
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public Adresse Adresse { get; set; }

        public User(string nom, string prenom, Adresse adresse)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom} résidant au {Adresse}.";
        }
    }
}
