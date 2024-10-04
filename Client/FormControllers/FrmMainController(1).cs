using Client.Exceptions;
using Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.FormControllers
{
    public class FrmMainController
    {
        internal void OpenUCDodajKlijenta(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCDodajKlijenta(new UCDodajKlijentaController()));
        }

        internal void OpenUCDodajUslugu(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCDodajUslugu(new UCDodajUsluguController()));
        }

        internal void OpenUCObrisiUslugu(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCObrisiUslugu(new UCObrisiUsluguController()));
        }

        internal void OpenUCIzmeniObrisiKlijenta(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCIzmeniObrisiKlijenta(new UCIzmeniObrisiKlijentaController()));
        }

        internal void OpenUCDodajTermine(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCDodajTermine(new UCDodajTermineController()));
        }

        internal void OpenUCPretraziObrisiTermin(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCPretraziObrisiTermin(new UCPretraziObrisiTerminController()));
        }

        internal void Logout()
        {
            try
            {
                ServerCommunication.Communication.Instance.SendRequestNoResult(Communication.Operation.Logout, null);
            }
            catch (ServerCommunicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
