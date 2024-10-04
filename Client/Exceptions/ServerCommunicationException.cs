using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Exceptions
{
    public class ServerCommunicationException : Exception
    {
        public ServerCommunicationException() : base("Doslo je do greske u komunikaciji sa serverom, bicete odjavljeni. Pokusajte da se prijavite opet.")
        {
        }

        public ServerCommunicationException(string message) : base(message)
        {

        }
    }
}
