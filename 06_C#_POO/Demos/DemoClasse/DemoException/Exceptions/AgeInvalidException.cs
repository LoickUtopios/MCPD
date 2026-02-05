using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoException.Exceptions
{
    // Pour créer une exception personnalisé, elle doit hériter d'Exception
    internal class AgeInvalidException : Exception
    {
        // Nous pouvons également ajouter de nouvelles données à notre exception.
        public DateTime DateTime { get; set; } = DateTime.Now;

        public AgeInvalidException(string message) :base(message) 
        {}

        public override string ToString()
        {
            return Message + ", Date : " + DateTime.ToString();
        }
    }
}
