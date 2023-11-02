using november2nd.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november2nd.Utils
{
    public class InvalidPhoneFormat : Exception
    {
        public InvalidPhoneFormat() { }
        public InvalidPhoneFormat(string message) : base(message) { }
    }
}
 