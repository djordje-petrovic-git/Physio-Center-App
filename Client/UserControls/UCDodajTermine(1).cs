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
    public partial class UCDodajTermine : UserControl
    {
        private UCDodajTermineController dodajTermineController;
        public UCDodajTermine()
        {
            InitializeComponent();
        }
        public UCDodajTermine(UCDodajTermineController uCDodajTermineController)
        {
            InitializeComponent();
            this.dodajTermineController = uCDodajTermineController;
            dodajTermineController.PripremiFormu(cbKlijent, cbUsluga, cbVaucer, dgvTermini);
        }

        private void btnDodajTermin_Click(object sender, EventArgs e)
        {
            dodajTermineController.DodajTermin(dgvTermini, cbKlijent, cbUsluga, dtpDatum, txtSati, txtMinuti, rtbNapomena, cbVaucer);
        }

        private void btnObrisiTermin_Click(object sender, EventArgs e)
        {
            dodajTermineController.ObrisiTermin(dgvTermini);
        }

        private void btnSacuvajTermine_Click(object sender, EventArgs e)
        {
            dodajTermineController.SacuvajTermine(dgvTermini, cbKlijent, cbUsluga, dtpDatum, txtSati, txtMinuti, rtbNapomena, cbVaucer);
        }

        private void btnObavestiKlijenta_Click(object sender, EventArgs e)
        {
           dodajTermineController.ObavestiKlijenta(dgvTermini);
        }

        private void btnKalendar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmKalendar forma = new FrmKalendar(new FrmKalendarController());
                DialogResult result = forma.ShowDialog();
            }
            catch (SystemOperationException)
            {
                return;
            }
        }
    }
}
