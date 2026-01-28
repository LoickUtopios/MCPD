using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8.Classes
{
    internal class CompteBancaire
    {
        private string _titulaire;
        private double _solde;
        private string _devise;

        public string Titulaire { get { return _titulaire; } private set { _titulaire = value; } }
        public double Solde { get { return _solde; } protected set { _solde = value; } }
        public string Devise { get { return _devise; } private set { _devise = value; } }


        public CompteBancaire(string titulaire, double solde, string devise)
        {
            Titulaire = titulaire;
            Solde = solde;
            Devise = devise;
        }

        public void Deposer(double montant)
        {   
            if(montant > 0)
                Solde += montant;
        }

        public void Retirer(double montant)
        {
            if (montant > 0 && montant <= Solde)
            {
                Solde -= montant;
            }
            else
                Console.WriteLine("Solde insuffisant !"); 
        }

        public void AfficherSolde()
        {
            Console.WriteLine($"Le compte de {Titulaire} a un solde de {Solde} {Devise}.");
        }

    }
}
