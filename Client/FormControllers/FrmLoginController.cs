using Client.Exceptions;
using Client.FormHelpers;
using Communication;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormControllers
{
    public class FrmLoginController
    {
        internal bool Connect()
        {
            try
            {
                ServerCommunication.Communication.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Server nije pokrenut!");
                return false;
            }

        }

        internal void Login(TextBox txtKorisnickoIme, TextBox txtLozinka, FrmLogin frmLogin)
        {

            if (!ValidationHelper.EmptyFieldValidation(txtKorisnickoIme) | !ValidationHelper.EmptyFieldValidation(txtLozinka))
            {
                return;

            }

            Korisnik korisnik = new Korisnik
            {
                KorisnickoIme = txtKorisnickoIme.Text,
                Lozinka = txtLozinka.Text
            };

            try
            {

                korisnik = ServerCommunication.Communication.Instance.SendRequestGetResult<Korisnik>(Operation.Login, korisnik);

                if (korisnik != null)
                {
                    korisnik = ServerCommunication.Communication.Instance.SendRequestGetResult<Korisnik>(Operation.ProveriUlogovan, korisnik);

                    if (korisnik != null)
                    {
                        ClientManager.Instance.PrijavljeniKorisnik = korisnik;
                        MessageBox.Show("Uspešna prijava!");
                        ClientManager.Instance.OpenMainForm();
                        frmLogin.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Vec ste ulogovani na sistem!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Niste uneli ispravne kredencijale!");
                    return;
                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        internal void Disconnect()
        {
            try
            {
                ServerCommunication.Communication.Instance.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
