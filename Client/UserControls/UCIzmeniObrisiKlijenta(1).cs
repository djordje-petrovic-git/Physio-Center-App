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
    public partial class UCIzmeniObrisiKlijenta : UserControl
    {
        private UCIzmeniObrisiKlijentaController izmeniObrisiKlijentaController;
        public UCIzmeniObrisiKlijenta()
        {
            
        }
        public UCIzmeniObrisiKlijenta(UCIzmeniObrisiKlijentaController uCIzmeniObrisiKlijentaController)
        {
            InitializeComponent();
            this.izmeniObrisiKlijentaController = uCIzmeniObrisiKlijentaController;
            izmeniObrisiKlijentaController.PripremiFormu(cbTipKlijenta, dgvKlijenti);

        }

        private void dgvKlijenti_SelectionChanged(object sender, EventArgs e)
        {
            izmeniObrisiKlijentaController.PopuniDetalje(dgvKlijenti, txtIme, txtPrezime, txtStarost, txtBrojTelefona, txtEmail, cbTipKlijenta, txtBrojTermina);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            izmeniObrisiKlijentaController.PretraziKlijenta(dgvKlijenti, chbImePrezimeKriterijum, txtImePrezimeKriterijum);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            izmeniObrisiKlijentaController.IzmeniKlijenta(dgvKlijenti, txtIme, txtPrezime, txtStarost, txtBrojTelefona, txtEmail, cbTipKlijenta, chbImePrezimeKriterijum, txtImePrezimeKriterijum);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            izmeniObrisiKlijentaController.ObrisiKlijenta(dgvKlijenti, txtBrojTermina);
        }

    }
}
