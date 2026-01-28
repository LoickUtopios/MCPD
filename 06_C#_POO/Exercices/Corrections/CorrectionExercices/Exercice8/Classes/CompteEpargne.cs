using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8.Classes
{
    internal class CompteEpargne : CompteBancaire
    {
        private float _tauxInteret;

        public float TauxInteret { get { return _tauxInteret; } private set { _tauxInteret = value; } }

        public CompteEpargne(string titulaire, double solde, string devise, float taux) 
            : base(titulaire, solde, devise)
        {
            this.TauxInteret = taux;
        }

        public double CalculerInteret()
        {
            return Solde * (TauxInteret / 100);
        }

    }
}
