using Client.Exceptions;
using Client.FormControllers;
using Client.Forms;
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
    public partial class UCDodajUslugu : UserControl
    {
        private UCDodajUsluguController dodajUsluguController;
        public UCDodajUslugu()
        {
           
        }
        public UCDodajUslugu(UCDodajUsluguController UCDodajUsluguController)
        {
            InitializeComponent();
            this.dodajUsluguController = UCDodajUsluguController;
            dodajUsluguController.PripremiFormu(cbVrstaUsluge, dgvNapomene);

        }

        private void btnDodajNapomenu_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUnosNapomene forma = new FrmUnosNapomene(new FrmUnosNapomeneController(dodajUsluguController.Napomene));
                DialogResult result = forma.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Uspesno ste dodali napomenu!");
                    dgvNapomene.DataSource = null;
                    dodajUsluguController.OsveziNapomene(dgvNapomene);
                }
            }
            catch (SystemOperationException)
            {
                return;
            }
        }

        private void btnObrisiNapomenu_Click(object sender, EventArgs e)
        {
            dodajUsluguController.ObrisiNapomenu(dgvNapomene);

        }

        private void btnSacuvajUslugu_Click(object sender, EventArgs e)
        {
            dodajUsluguController.SacuvajUslugu(txtNaziv, txtCena, txtTrajanje, cbVrstaUsluge, dgvNapomene);
        }
    }
}
