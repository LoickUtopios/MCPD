using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6.Classes
{
    internal class Generateur
    {
        public static string[] Mot { get; set; } = [
                "chat", "voiture", "montagne", "ordinateur", "soleil",
                "pluie", "fromage", "musique", "avion", "livre",
                "riviere", "foret", "bouteille", "horloge", "chaussure",
                "fenetre", "nuage", "bureau", "clavier", "lampe",
                "route", "chateau", "ecran", "stylo", "sac",
                "arbre", "telephone", "ocean", "papier", "chaise",
                "mur", "cafe", "train", "pont", "ville",
                "jardin", "neige", "bureaucratie", "etoile", "crayon",
                "miroir", "vague", "porte", "valise", "ballon",
                "chemise", "ciel", "pizza", "velo"
            ];

        public static string GenereMot()
        {
            Random random = new Random();
            return Mot[random.Next(Mot.Length-1)];
        }
    }
}
