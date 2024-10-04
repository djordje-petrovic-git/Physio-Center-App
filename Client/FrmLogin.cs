using Client.FormControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private FrmLoginController loginController;

        public FrmLogin(FrmLoginController loginController)
        {
            InitializeComponent();
            this.loginController = loginController;
        }


        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (loginController.Connect())
            {
                loginController.Login(txtKorisnickoIme, txtLozinka, this);
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginController.Disconnect();
            Environment.Exit(0);
        }
    }
}
