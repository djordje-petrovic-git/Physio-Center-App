using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Exceptions
{
    public class SystemOperationException : Exception
    {
        public SystemOperationException() : base("Sistem nije mogao da izvrsi zahtevanu operaciju.")
        {

        }
        public SystemOperationException(string message) : base(message)
        {
        }
    }
}
