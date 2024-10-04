using Client.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                try
                {
                    ClientManager.Instance.OpenLoginForm();
                    Application.Run();
                }
                catch (ServerCommunicationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    try
                    {
                        ServerCommunication.Communication.Instance.SendRequestNoResult(Communication.Operation.Logout, null);
                        MessageBox.Show(ex.Message);
                    }
                    catch (ServerCommunicationException)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
