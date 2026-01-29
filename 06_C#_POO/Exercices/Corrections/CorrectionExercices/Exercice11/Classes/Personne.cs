using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice11.Classes
{
    internal abstract class Personne
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }


        public Personne(string nom, string prenom, string telephone, string email)
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Email = email;
        }

        public override string ToString()
        {
            return $"Je suis une personne qui s'appelle {Prenom} {Nom}.\n" +
                $"Mon email est {Email} et mon numéro est le {Telephone}.\n";
        }

    }
}
