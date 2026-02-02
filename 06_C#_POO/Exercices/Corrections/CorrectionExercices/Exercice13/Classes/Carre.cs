using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice13.Classes
{
    internal class Carre : Figure
    {
        private double _cote; 

        public double Cote { get { return _cote; } set { _cote = value; } }

        public Carre(string name, Point origine, double cote) : base(name, origine)
        {
            Cote = cote;
        }

        public override string ToString()
        {
            return base.ToString() + 
                $"\nEt a pour coté {Cote}.";
        }
    }
}
