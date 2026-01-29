using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10.Classes
{
    internal class Rectangle : Forme
    {
        private double _longueur;
        private double _largeur;

        public double Longueur {  get { return _longueur; } set { _longueur = value; }}
        public double Largeur { get { return _largeur; } set { _largeur = value; }}

        public Rectangle(string name, double longueur , double largeur)
            : base(name)
        {
            this.Longueur = longueur;
            this.Largeur = largeur;
        }

        public override double CalculerAire()
        {
            return Longueur * Largeur;
        }

        public override double CalculerPerimetre()
        {
            return 2 * (Longueur + Largeur); 
        }

        public override void Infos()
        {
            base.Infos();
            Console.WriteLine("Largeur : " + Largeur);
            Console.WriteLine("Longueur : " + Longueur);
        }
    }
}
