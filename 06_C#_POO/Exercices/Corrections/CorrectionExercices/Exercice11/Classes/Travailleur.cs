using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice11.Classes
{
    internal class Travailleur: Personne
    {
        public string EntrepriseNom {  get; set; }
        public string EntrepriseAdresse { get; set; }
        public string TelephonePro {  get; set; }

        public Travailleur(string nom, string prenom, string telephone, string email, string entrepriseNom, string entrepriseAdresse, string telephonePro)
            : base (nom, prenom, telephone, email)
        {
            EntrepriseNom = entrepriseNom;
            EntrepriseAdresse = entrepriseAdresse;
            TelephonePro = telephonePro;
        }

        public override string ToString()
        {
            return base.ToString() + $"Je travail également pour  {EntrepriseNom}. \n" +
                $"Elle est situé à {EntrepriseAdresse} et mon numéro pro est {TelephonePro}.\n";
        }
    }
}
