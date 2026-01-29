using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6.Classes
{
    internal class Pendu
    {
        public string Mask { get; set; }
        public int NbEssai { get; set; }
        public string MotATrouver { get; set; }

        public Pendu(string motATrouver, int nbEssai = 10)
        {
            NbEssai = nbEssai;
            MotATrouver = motATrouver.ToUpper();
            Mask = GenereMasque();
        }

        public bool TestChar(char lettre)
        {
            if (MotATrouver.Contains(char.ToUpper(lettre))){
                return true;
            }

            NbEssai--;
            return false;
        }

        public bool TestWin()
        {
            return !Mask.Contains("*");
        }

        public string GenereMasque(char lettre = '0')
        {
            if (lettre == '0')
                return new string('*', MotATrouver.Length);


            lettre = char.ToUpper(lettre);

            string newMask = "";
            for (int i = 0; i < MotATrouver.Length; i++)
            {
                if (MotATrouver[i] == lettre || Mask[i] != '*')
                {
                    newMask += MotATrouver[i];
                }
                else
                    newMask += "*";
            }

            return newMask;
        }
    }
}
