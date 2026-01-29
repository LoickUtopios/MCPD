using Exercice12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice12.Classes
{
    internal class VoitureHybride : Vehicule, IMotorise, IElectrique
    {
        public VoitureHybride(string nom, string marque) : base(nom, marque)
        {
        }

        public void Demarrer()
        {
            Console.WriteLine("La voiture hybride démarre !"); 
        }

        public void Recharger()
        {
            Console.WriteLine("La voiture hybride est en train de se recharger !");
        }
    }
}
