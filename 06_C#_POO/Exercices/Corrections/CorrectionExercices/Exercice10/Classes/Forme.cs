using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10.Classes
{
    internal abstract class Forme
    {
        private string _nom;

        public string Nom { get { return _nom; } set { _nom = value; } } 

        public Forme(string nom) 
        {
            Nom = nom;    
        }

        public abstract double CalculerAire();
        public abstract double CalculerPerimetre(); 

        public virtual void Infos()
        {
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Perimetre : " + CalculerPerimetre());
            Console.WriteLine("Aire : " + CalculerAire());
        }

    }
}
