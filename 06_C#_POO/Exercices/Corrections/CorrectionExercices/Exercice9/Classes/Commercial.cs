using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice9.Classes
{
    internal class Commercial : Salarie
    {
        private double _chiffreAffaire;
        private float _commission;

        public double ChiffreAffaire { get => _chiffreAffaire; set => _chiffreAffaire = value; }
        public float Commission { get { return _commission; } set { _commission = value; } }


        public Commercial (): base () { }
        public Commercial(string nom, string service, double salaire, double chiffreAffaire, float commission)
            : base(nom, service, salaire)
        {
            ChiffreAffaire = chiffreAffaire;
            Commission = commission;
        }


        //- Surcharger la méthode **AfficherSalaire**() pour calculer le salaire réel (**fixe + commission**).
        public override void AfficherSalaire()
        {
            base.AfficherSalaire();
        }

        //- Ajoutez des méthodes **ToString** pour l'affichage des salariés et comMerciaux.


    }
}
