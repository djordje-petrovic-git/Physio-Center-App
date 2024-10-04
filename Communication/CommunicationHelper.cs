using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public class CommunicationHelper
    {
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public CommunicationHelper(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        // na ovaj nacin omogućeno slanje zahteva i primanje odgovora bez obzira na tip
        public void Send<T>(T obj) where T : class   // kada saljes, salji objekat nekog tipa gde je taj tip T zapravo klasa i serializuj
        {
            formatter.Serialize(stream, obj);
        }

        public T Receive<T>() where T : class // prihvati tip T i vrati tip T a to sto deserializujes kastuj u T
        {
            return (T)formatter.Deserialize(stream);
        }
    }
}
