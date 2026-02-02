using Exercice13.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice13.Classes
{
    internal abstract class Figure : IDeplacable
    {
        private string _name;
        private Point _origine;

        public string Name { get { return _name; } 
            
            set {
                if (value.Length > 20 || value.Length < 3)
                    _name = "Toto";
                else
                    _name = value;
            } 
        }
        public Point Origine { get { return _origine; } set { _origine = value; } }


        public Figure(string name, Point origine) 
        { 
            Name = name;
            Origine = origine;
        }

        public void Deplacement(double x, double y)
        {
            Origine.PosX += x; 
            Origine.PosY += y;
        }

        public override string ToString()
        {
            return $"{Name} a pour origine {Origine}";
        }
    }
}
