using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november2nd.Utils
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() 
        {

        }
        public InvalidAgeException(string message) : base(message) { }

    }
}
