using Client.Exceptions;
using Communication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client.ServerCommunication
{
    public class Communication
    {
        private Socket socket;
        private CommunicationHelper helper;

        #region Singleton
        private static Communication instance;
        private Communication() { }

        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }
        #endregion

        public Output SendRequestGetResult<Output>(Operation op, object i = null) where Output : class
        {
            SendRequest(op, i);
            return GetResult<Output>();
        }

        public void SendRequestNoResult(Operation op, object i)
        {
            SendRequest(op, i);
            GetResult();
        }

        private T GetResult<T>() where T : class
        {
            Response response = helper.Receive<Response>();
            if (response.IsSuccessful)
            {
                return (T)response.Result;
            }
            else
            {
                Console.WriteLine(">>>" + response.Message);
                throw new SystemOperationException();
            }
        }

        private void GetResult()
        {
            Response response = helper.Receive<Response>();
            if (!response.IsSuccessful)
            {
                Console.WriteLine(">>>" + response.Message);
                throw new SystemOperationException();
            }
        }

        private void SendRequest(Operation operation, object requestObject = null)
        {
            try
            {
                Request r = new Request
                {
                    Operation = operation,
                    RequestObject = requestObject
                };
                helper.Send(r);
            }
            catch (IOException)
            {
                throw new ServerCommunicationException();
            }
        }

        public void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999); 
                helper = new CommunicationHelper(socket);
            }
        }
        public void Close()
        {
            if (socket != null && socket.Connected)
            {
                Request request = new Request
                {
                    Operation = Operation.End,
                };

                helper.Send(request);

                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                socket = null;
            }
        }
    }
}
