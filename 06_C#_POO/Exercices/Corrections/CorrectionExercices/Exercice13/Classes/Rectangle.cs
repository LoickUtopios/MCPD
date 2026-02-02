using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice13.Classes
{
    internal class Rectangle : Figure
    {
        private double _largeur; 
        private double _longueur;

        public double Largeur { get => _largeur; set => _largeur = value; }
        public double Longueur { get => _longueur; set => _longueur = value; }

        public Rectangle(string name, Point origine, double largeur, double longueur) : base(name, origine)
        {
            Largeur = largeur;
            Longueur = longueur;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nEt a pour largeur {Largeur} et Longueur {Longueur}.";
        }
    }
}
