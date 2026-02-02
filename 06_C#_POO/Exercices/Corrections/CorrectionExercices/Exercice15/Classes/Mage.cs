using Exercice15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice15.Classes
{
    internal class Mage : Personnage, IMagie
    {
        public Mage(string nom, string prenom, int pv, int degat, Arme arme) : base(nom, prenom, pv, degat, arme)
        {
        }

        public override void Attaquer(Personnage cible)
        {
            Console.WriteLine(this.Prenom + " frappe " + cible.Nom + " : pouf ?! ");
            cible.PointDeVie -= Arme.Durabilite > 0 ? (Degat + Arme.DegatSupplementaire)/2 : Degat / 2;
            Arme.Utiliser();
        }

        public void LancerSort(Personnage cible)
        {
            Console.WriteLine(this.Prenom + " lance une boule de feu sur " + cible.Nom + " : BOOOOOMMMMM !! ");
            cible.PointDeVie -= Arme.Durabilite > 0 ? (Degat + Arme.DegatSupplementaire) * 4 : (Degat * 4);
            Arme.Utiliser();
        }

    }
}
