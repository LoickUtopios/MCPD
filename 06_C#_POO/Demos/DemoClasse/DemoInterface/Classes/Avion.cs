using DemoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Classes
{
    internal class Avion : IVolant
    {
        public void Atterir()
        {
            Console.WriteLine("L'avion atterit !"); 
        }

        public void Decoller()
        {
            Console.WriteLine("L'avion décolle !"); 
        }
    }
}
