using ApplicationLogic;
using Communication;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private CommunicationHelper helper;
        private List<ClientHandler> clients; // lista trenutno prijavljenih klijenata
        private bool ulogovan = false;
        private Korisnik korisnik = null;
        private bool kraj = false;

        public EventHandler OdjavljenKlijent;

        public ClientHandler(Socket socket, List<ClientHandler> clients)
        {
            this.socket = socket;
            this.clients = clients;
            helper = new CommunicationHelper(socket);
        }


        public void HandleRequests()
        {
            try
            {
                while (!kraj)
                {
                    Request request = helper.Receive<Request>();
                    Response response = CreateResponse(request);
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                CloseSocket();
            }
        }


        public Response CreateResponse(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        response.Result = Controller.Instance.PrijaviAdministratora((Korisnik)request.RequestObject);
                        if (response.Result != null)
                        {
                            korisnik = (Korisnik)response.Result;
                        }
                        break;
                    case Operation.ProveriUlogovan:
                        if (!clients.Any(x => x.korisnik != null
                            && x.korisnik.Equals(korisnik) && x.ulogovan))
                        {
                            response.Result = korisnik;
                            ulogovan = true;
                        }
                        break;
                    case Operation.IzmeniKlijenta:
                        Controller.Instance.IzmeniKlijenta((Klijent)request.RequestObject);
                        break;
                    case Operation.ObrisiKlijenta:
                        Controller.Instance.ObrisiKlijenta((Klijent)request.RequestObject);
                        break;
                    case Operation.ObrisiTermin:
                        Controller.Instance.ObrisiTermin((Termin)request.RequestObject);
                        break;
                    case Operation.ObrisiUslugu:
                        Controller.Instance.ObrisiUslugu((Usluga)request.RequestObject);
                        break;
                    case Operation.PretraziKlijente:
                        response.Result = Controller.Instance.PretraziKlijente((Klijent)request.RequestObject);
                        break;
                    case Operation.PretraziTermine:
                        response.Result = Controller.Instance.PretraziTermine((Termin)request.RequestObject);
                        break;
                    case Operation.PretraziUsluge:
                        response.Result = Controller.Instance.PretraziUsluge((Usluga)request.RequestObject);
                        break;
                    case Operation.UcitajKlijenta:
                        response.Result = Controller.Instance.UcitajKlijenta((Klijent)request.RequestObject);
                        break;
                    case Operation.UcitajTermin:
                        response.Result = Controller.Instance.UcitajTermin((Termin)request.RequestObject);
                        break;
                    case Operation.UcitajUslugu:
                        response.Result = Controller.Instance.UcitajUslugu((Usluga)request.RequestObject);
                        break;
                    case Operation.VratiListuKlijenata:
                        response.Result = Controller.Instance.VratiListuKlijenata();
                        break;
                    case Operation.VratiListuTermina:
                        response.Result = Controller.Instance.VratiListuTermina();
                        break;
                    case Operation.VratiListuTipovaKlijenata:
                        response.Result = Controller.Instance.VratiListuTipovaKlijenata();
                        break;
                    case Operation.VratiListuTipovaNapomenaZaUslugu:
                        response.Result = Controller.Instance.VratiListuTipovaNapomenaZaUslugu();
                        break;
                    case Operation.VratiListuUsluga:
                        response.Result = Controller.Instance.VratiListuUsluga();
                        break;
                    case Operation.VratiListuVrstaUsluga:
                        response.Result = Controller.Instance.VratiListuVrstaUsluga();
                        break;
                    case Operation.ZapamtiKlijenta:
                        response.Result = Controller.Instance.ZapamtiKlijenta((Klijent)request.RequestObject);
                        break;
                    case Operation.ZapamtiTermine:
                        response.Result = Controller.Instance.ZapamtiTermine((List<Termin>)request.RequestObject);
                        break;
                    case Operation.ZapamtiUslugu:
                        response.Result = Controller.Instance.ZapamtiUslugu((Usluga)request.RequestObject);
                        break;
                    case Operation.Logout:
                        if (korisnik != null && ulogovan)
                        {
                            ulogovan = false;
                        }
                        break;
                    case Operation.End:
                        kraj = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                response.IsSuccessful = false;
                response.Message = ex.Message;
            }
            return response;
        }

        private object lockobject = new object(); // koristimo za sinhronizaciju pristupa: da bi se sprecilo istovremeno izvrsavanje vise niti
        internal void CloseSocket()
        {
            lock (lockobject) // blok koda koji je izvršen samo jednom u određenom trenutku
            {
                if (socket != null)
                {
                    kraj = true;
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                    OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
