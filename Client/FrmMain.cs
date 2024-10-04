using Client.Exceptions;
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
   
    public partial class FrmMain : Form
    {
        private FrmMainController mainController;
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(FrmMainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
            lblPrijavljeniKorisnik.Text = $"Trenutno prijavljeni korisnik: {ClientManager.Instance.PrijavljeniKorisnik.KorisnickoIme}";
            lblPrijavljeniKorisnik.Font = new Font("Georgia", 10);
        }

        internal void SetPanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainController.Logout();
            Application.Exit();
        }

        private void unosKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainController.OpenUCDodajKlijenta(this);
            }
            catch (SystemOperationException)
            {
                pnlMain.Controls.Clear();
            }

        }

        private void unosUslugeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                mainController.OpenUCDodajUslugu(this);
            }
            catch (SystemOperationException)
            {
                pnlMain.Controls.Clear();
            }

        }

        private void brisanjeUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainController.OpenUCObrisiUslugu(this);
            }
            catch (SystemOperationException)
            {
                pnlMain.Controls.Clear();
            }
        }

        private void izmenaBrisanjeKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainController.OpenUCIzmeniObrisiKlijenta(this);
            }
            catch (SystemOperationException)
            {
                pnlMain.Controls.Clear();
            }
        }

        private void unosTerminaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                mainController.OpenUCDodajTermine(this);
            }
            catch (SystemOperationException)
            {
                pnlMain.Controls.Clear();
            }
        }

        private void pretragaBrisanjeTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainController.OpenUCPretraziObrisiTermin(this);
                
            }
            catch (SystemOperationException)
            {
                pnlMain.Controls.Clear();
            }
        }

        private void terminiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
