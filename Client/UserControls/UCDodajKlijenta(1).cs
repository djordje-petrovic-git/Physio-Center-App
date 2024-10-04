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

namespace Client.UserControls
{
    public partial class UCDodajKlijenta : UserControl       
    {
        private UCDodajKlijentaController dodajKlijentaController;

        public UCDodajKlijenta()
        {

        }

        public UCDodajKlijenta(UCDodajKlijentaController UCDodajKlijentaController)
        {
            InitializeComponent();
            this.dodajKlijentaController = UCDodajKlijentaController;
            dodajKlijentaController.PripremiFormu(cbTipKlijenta);

        }

        private void btnSacuvajKlijenta_Click(object sender, EventArgs e)
        {
            dodajKlijentaController.SacuvajKlijenta(txtIme, txtPrezime, txtStarost, txtBrojTelefona, txtEmail, cbTipKlijenta);
        }
    }
}
