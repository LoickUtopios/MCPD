using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice14.Classes
{
    internal class Adresse
    {
        public int NumRue { get; set; }
        public string NomRue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }

        public Adresse(int num, string nom, string ville, string cp) 
        { 
            NumRue = num;
            NomRue = nom;
            Ville = ville;
            CodePostal = cp;
        }

        public override string ToString()
        {
            return $"{NumRue} {NomRue}, {Ville} ({CodePostal})";
        }
    }
}
