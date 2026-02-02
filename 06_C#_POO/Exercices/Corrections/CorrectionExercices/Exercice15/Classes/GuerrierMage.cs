using Exercice15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice15.Classes
{
    internal class GuerrierMage : Personnage, IMagie, IAttaqueSpécial
    {
        public GuerrierMage(string nom, string prenom, int pv, int degat, Arme arme) 
            : base(nom, prenom, pv, degat, arme)
        {
        }

        public override void Attaquer(Personnage cible)
        {
            Console.WriteLine(this.Prenom + " frappe " + cible.Nom + " : VLAMM !! ");
            cible.PointDeVie -= Arme.Durabilite > 0 ? Degat + Arme.DegatSupplementaire : Degat;
            Arme.Utiliser();
        }

        public void AttaqueSpecial(Personnage cible)
        {
            Console.WriteLine(this.Prenom + " frappe violamment avec un salto retourné " + cible.Nom + " : BAAAAAAMMMMM !! ");
            cible.PointDeVie -= Arme.Durabilite > 0 ? (Degat + Arme.DegatSupplementaire) * 2 : (Degat * 2);
            Arme.Utiliser();
        }

        public void LancerSort(Personnage cible)
        {
            Console.WriteLine(this.Nom + " lance une boule de feu sur " + cible.Nom + " : BOOOOOMMMMM !! ");
            cible.PointDeVie -= Arme.Durabilite > 0 ? (Degat + Arme.DegatSupplementaire) * 3 : (Degat * 3);
            Arme.Utiliser();
        }

    }
}
