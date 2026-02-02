using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice15.Classes
{
    internal class Arme
    {
        public string Nom { get; set; }
        public int DegatSupplementaire{ get; set; }
        public int Durabilite { get; set; }

        public Arme (string nom, int degatSupplementaire, int durabilite)
        {
            Nom = nom;
            DegatSupplementaire = degatSupplementaire;
            Durabilite = durabilite;
        }

        public void Utiliser()
        {
            Durabilite = Durabilite > 0 ? Durabilite-1 : 0;
        }

        public override string ToString()
        {
            return $"{Nom} inflige {DegatSupplementaire} dégâts supplémentaire avec une durabilité de {Durabilite}.";
        }
    }
}
