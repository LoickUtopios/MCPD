using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice12.Classes
{
    internal abstract class Vehicule
    {
        private string _nom;
        private string _marque;

        public string Nom { get { return _nom; } set { _nom = value; } }
        public string Marque { get { return _marque; } set { _marque = value; } }

        public Vehicule(string nom, string marque) 
        { 
            Nom = nom;
            Marque = marque;
        }

        public override string ToString()
        {
            return $"Je suis {Nom} de marque {Marque}.";
        }
    }
}
