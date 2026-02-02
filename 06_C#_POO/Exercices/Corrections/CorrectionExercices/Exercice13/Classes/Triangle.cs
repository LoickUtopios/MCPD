using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice13.Classes
{
    internal class Triangle : Figure
    {
        private double _base;
        private double _hauteur;

        public double Base { get { return _base; } set { _base = value; } }
        public double Hauteur { get { return _hauteur; } set { _hauteur = value; } }
        public Triangle(string name, Point origine, double @base, double hauteur) : base(name, origine)
        {
            Base = @base;
            Hauteur = hauteur;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nEt a pour base {Base} et hauteur {Hauteur}.";
        }

    }
}
