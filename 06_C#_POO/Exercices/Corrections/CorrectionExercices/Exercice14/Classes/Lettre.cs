using Exercice14.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice14.Classes
{
    internal class Lettre
    {
        public User Expediteur {  get; set; }
        public User Destinataire { get; set; }
        public string Contenue { get; set; }
        public StatutLettreEnum Statut { get; set; }


        public Lettre(User expediteur, User destinataire, 
            string contenue, StatutLettreEnum status = StatutLettreEnum.EN_ATTENTE)
        {
            Expediteur = expediteur;
            Destinataire = destinataire;
            Contenue = contenue;
            Statut = status;
        }

        public void Envoyer()
        {
            Statut = StatutLettreEnum.ENVOYEE;
        }

        public void Lire()
        {
            Statut = StatutLettreEnum.LUE;
        }

        public override string ToString()
        {
            return $"L'expéditeur est {Expediteur}.\n" +
                $"Le destinataire est {Destinataire}.\n" +
                $"La lettre est {Statut} et le contenue est {Contenue}.";
        }
    }
}
