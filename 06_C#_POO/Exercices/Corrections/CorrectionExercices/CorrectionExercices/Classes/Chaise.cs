using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1.Classes
{
    internal class Chaise
    {
        // Attributs
        private int _nbPied;
        private string _materiaux;
        private string _couleur;

        // Propriétés
        public int NbPied { get => _nbPied; set => _nbPied = value; }
        public string Materiaux { get => _materiaux; set => _materiaux = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }

        // Constructeur par défaut
        public Chaise() {
            NbPied = 4;
            Materiaux = "Bois";
            Couleur = "Pin";
        }

        // Constructeur avec parametre
        public Chaise(int nbPied, string materiaux, string couleur)
        {
            NbPied = nbPied;
            Materiaux = materiaux;
            Couleur = couleur;
        }

        public override string ToString()
        {
            return $"Cette chaise a {NbPied} pieds, et faite en {Materiaux} et de couleur {Couleur}."; 
        }

    }
}
