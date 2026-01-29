using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7.Classes
{
    internal class Citerne
    {
        private int _poidAVide;
        private double _capaciteTotale;
        private double _niveau;
        private static double _totalVolume; 

        public int PoidsAVide { get { return _poidAVide; } private set { _poidAVide = value; } }
        public double CapaciteTotale { get { return _capaciteTotale; } private set { _capaciteTotale = value; } }
        public double Niveau { get { return _niveau; } set { _niveau = value; } }
        public static double TotalVolume { get { return _totalVolume; } set { _totalVolume = value; } }


        public Citerne(int poidAVide, double capaciteTotale)
        {
            PoidsAVide = poidAVide;
            CapaciteTotale = capaciteTotale;
        }

        public double PoidTotal()
        {
            return PoidsAVide + Niveau;
        }

        public double Remplir(double litre)
        {
            TotalVolume += litre;
            Niveau += litre; 

            double exces = 0;

            if(Niveau > CapaciteTotale)
            {
                exces = Niveau - CapaciteTotale; 
                Niveau = CapaciteTotale;
            }

            Console.WriteLine($"Vous avez rempli la citerne de {litre} L ({exces} L en excès)");
            Console.WriteLine($"La citerne est à {(Niveau * 100) / CapaciteTotale }%");
            return exces; 
        }

        public double Vider(double litre)
        {

            if (Niveau >= litre)
            {
                TotalVolume -= litre;
                Niveau -= litre;
                Console.WriteLine($"Vous avez retiré {litre} L");
                Console.WriteLine($"La citerne est à {(Niveau * 100) / CapaciteTotale}%");
                return litre; 
            }

            double litreRetirable = Niveau;
            
            TotalVolume -= Niveau;
            Niveau = 0;
            Console.WriteLine($"Vous avez seulement retiré {litreRetirable} L");
            Console.WriteLine($"La citerne est à 0 %");
            return litreRetirable;
        }
    }
}
