using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExercices1.Class.Exceptions
{
    internal class InvalidDateException : Exception
    {
        public InvalidDateException(string message) : base (message) { }
    }
}
