using Client.FormControllers;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientManager
    {
        private FrmMainController mainController = new FrmMainController();
        private FrmLoginController loginController = new FrmLoginController();

        private FrmLogin frmLogin;
        private FrmMain frmMain;

        #region Singleton
        private static ClientManager instance;
        private ClientManager()
        {

        }
        public static ClientManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClientManager();
                }
                return instance;
            }
        }
        #endregion

        public Korisnik PrijavljeniKorisnik { get; internal set; }

        public void OpenLoginForm()
        {
            frmLogin = new FrmLogin(loginController);
            frmLogin.Show();
        }

        public void OpenMainForm()
        {
            frmMain = new FrmMain(mainController);
            frmMain.Show();
        }
    }
}
