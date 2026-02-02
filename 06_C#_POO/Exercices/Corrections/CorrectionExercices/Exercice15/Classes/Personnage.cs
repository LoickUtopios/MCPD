using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice15.Classes
{
    internal abstract class Personnage
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public int PointDeVie { get; set; }
        public int Degat {  get; set; } 

        public Arme Arme { get; set; }

        public Personnage(string nom, string prenom, int pv, int degat, Arme arme) 
        { 
            Nom = nom;
            Prenom = prenom;
            PointDeVie = pv;
            Degat = degat;
            Arme = arme;
        }

        public abstract void Attaquer(Personnage cible);

        public override string ToString()
        {
            return $"{Nom} {Prenom} a {PointDeVie} pv et inflige {Degat} dégâts de base.";
        }

    }
}
