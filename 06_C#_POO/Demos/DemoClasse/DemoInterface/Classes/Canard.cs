using DemoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Classes
{
    internal class Canard : IEtreVivant, IOvipare, IVolant
    {
        public void Atterir()
        {
            Console.WriteLine("Le canard atterit");
        }

        public void Decoller()
        {
            Console.WriteLine("Le canard décolle");
        }

        public void Dormir()
        {
            Console.WriteLine("Le canard dort");
        }

        public void Manger()
        {
            Console.WriteLine("Le canard mange");
        }

        public void Pondre()
        {
            Console.WriteLine("Le canard pond");
        }
    }
}
