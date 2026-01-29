using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10.Classes
{
    internal class Cercle : Forme
    {
        private double _rayon;
        public double Rayon { get { return _rayon; } set { _rayon = value; } }

        public Cercle(string name, double rayon)
            : base(name)
        {
            this.Rayon = rayon;
        }

        public override double CalculerAire()
        {
            return Math.Pow(Rayon,2) * Math.PI;
        }

        public override double CalculerPerimetre()
        {
            return 2 * Math.PI * Rayon;
        }

        public override void Infos()
        {
            base.Infos();
            Console.WriteLine("Rayon : " + Rayon);
        }
    }
}
