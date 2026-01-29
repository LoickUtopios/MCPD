using Exercice12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice12.Classes
{
    internal class Hydravion : Vehicule, IMotorise, IVolant, IFlottant
    {
        public Hydravion(string nom, string marque) : base(nom, marque)
        {
        }

        public void Atterir()
        {
            Console.WriteLine("L'hydravion atterit !");
        }

        public void Decoller()
        { 
            Console.WriteLine("L'hydravion décolle  !");
        }

        public void Demarrer()
        {
            Console.WriteLine("L'hydravion démarre !");
        }

        public void Naviguer()
        {
            Console.WriteLine("L'hydravion navigue !");
        }
    }
}
