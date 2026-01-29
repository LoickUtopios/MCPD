using Exercice12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice12.Classes
{
    internal class Voiture : Vehicule, IMotorise
    {
        public Voiture(string nom, string marque) : base(nom, marque)
        {
        }

        public void Demarrer()
        {
            Console.WriteLine("Le voiture démarre !"); 
        }
    }
}
