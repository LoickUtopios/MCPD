using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice21.Exceptions
{
    internal class InvalidArrayException : Exception
    {
        public InvalidArrayException(string message = "Le tableau de notes ne peut pas être vide")
            : base(message) { }
    }
}
