using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8.Classes
{
    internal class CompteCourant : CompteBancaire
    {
        private double _decouvertAutorise;

        public double DecouvertAutorise { get  => _decouvertAutorise; private set => _decouvertAutorise = value; }


        public CompteCourant(string titulaire, double solde, string devise, double decouvert) 
            : base(titulaire, solde, devise)  
        {
            if (decouvert > 0)
                DecouvertAutorise = decouvert;
            else
                DecouvertAutorise = 100;
        }

        public void RetirerAvecDecouvert(double montant)
        {
            if (montant > 0 && montant < (Solde + DecouvertAutorise))
            {
                Solde -= montant;
            }
            else
                Console.WriteLine("Solde inssuffisant, même avec le découvert autorisé.");
        }
    }
}
