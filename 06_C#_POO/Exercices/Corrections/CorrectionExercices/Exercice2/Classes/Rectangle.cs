using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2.Classes
{
    internal class Rectangle
    {
        private int _largeur;
        private int _longueur;
        
        public int Largeur { get { return _largeur; } set { _largeur = value; } }
        public int Longueur { get { return _longueur; } set { _longueur = value; } }


        public Rectangle(int largeur, int longueur)
        {
            Largeur = largeur;
            Longueur = longueur;
        }

        public int Perimetre()
        {
            return (Largeur + Longueur) * 2;
        }

        public int Surface()
        {
            return Largeur * Longueur;
        }

    }
}
