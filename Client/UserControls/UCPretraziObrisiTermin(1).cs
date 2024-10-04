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
    public partial class UCPretraziObrisiTermin : UserControl
    {
        private UCPretraziObrisiTerminController pretraziObrisiTerminController;

        public UCPretraziObrisiTermin()
        {
            InitializeComponent();
            
        }

        public UCPretraziObrisiTermin(UCPretraziObrisiTerminController uCPretraziObrisiTerminController)
        {
            InitializeComponent();
            this.pretraziObrisiTerminController = uCPretraziObrisiTerminController;
            pretraziObrisiTerminController.PripremiFormu(dgvTermini, cbKlijentKriterijum);

        }

        private void dgvTermini_SelectionChanged(object sender, EventArgs e)
        {
            pretraziObrisiTerminController.PopuniDetalje(dgvTermini, cbKlijent, cbUsluga, dtpDatum, txtSati, txtMinuti, rtbNapomena, cbVaucer);
        }
        private void btnPretrazi_Click_1(object sender, EventArgs e)
        {
            pretraziObrisiTerminController.PretraziTermine(dgvTermini, chbKlijentKriterijum, chbDatumVremeKriterijum, cbKlijentKriterijum, dtpDatumKriterijum, txtSatiKriterijum, txtMinutiKriterijum);
        }

        private void btnObrisiTermin_Click(object sender, EventArgs e)
        {
            pretraziObrisiTerminController.ObrisiTermin(dgvTermini);
        }

        
    }
}
