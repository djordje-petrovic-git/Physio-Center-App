using Client.Exceptions;
using Client.FormHelpers;
using Communication;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormControllers
{
    public class UCDodajUsluguController
    {
        private BindingList<NapomenaZaUslugu> napomene = new BindingList<NapomenaZaUslugu>();
        public BindingList<NapomenaZaUslugu> Napomene { get { return napomene; } }

        internal void PripremiFormu(ComboBox cbVrstaUsluge, DataGridView dgvNapomene)
        {
            try
            {
                UcitajVrsteUsluga(cbVrstaUsluge);
                InicijalizujNapomene(dgvNapomene);
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce pokrenuti izabranu formu. Pokusajte kasnije.");
                throw;
            }

        }

        internal void UcitajVrsteUsluga(ComboBox cbVrstaUsluge)
        {
            cbVrstaUsluge.DataSource = ServerCommunication.Communication.Instance.SendRequestGetResult<List<VrstaUsluge>>(Communication.Operation.VratiListuVrstaUsluga, null);
            cbVrstaUsluge.SelectedIndex = -1;
            cbVrstaUsluge.Text = "Odaberite vrstu usluge";
        }

        internal void InicijalizujNapomene(DataGridView dgvNapomene)
        {
            dgvNapomene.DataSource = new BindingList<NapomenaZaUslugu>();
            PripremiDgv(dgvNapomene);
        }

        internal void OsveziNapomene(DataGridView dgvNapomene)
        {
            dgvNapomene.DataSource = napomene;
            PripremiDgv(dgvNapomene);
        }

        internal void PripremiDgv(DataGridView dgvNapomene)
        {
            dgvNapomene.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNapomene.Columns["OpisNapomene"].HeaderText = "Opis napomene";
            dgvNapomene.Columns["SifraTipaNapomene"].HeaderText = "Tip napomene";
        
            

        }


        internal void SacuvajUslugu(TextBox txtNaziv, TextBox txtCena, TextBox txtTrajanje, ComboBox cbVrstaUsluge, DataGridView dgvNapomene)
        {
            if (!ValidationHelper.EmptyFieldValidation(txtNaziv) | !ValidationHelper.EmptyFieldValidation(txtCena) |
                !ValidationHelper.EmptyFieldValidation(txtTrajanje) | !ValidationHelper.ComboBoxValidation(cbVrstaUsluge) |
                !ValidationHelper.EmptyFieldValidation(txtCena) | !ValidationHelper.EmptyFieldValidation(txtTrajanje))
            {
                return;
            }

            if (!ValidationHelper.NameAndLastNameValidation(txtNaziv))
            {
                MessageBox.Show("Naziv usluge nije u dobrom formatu!");
                return;
            }

            if (!ValidationHelper.PriceValidation(txtCena))
            {
                MessageBox.Show("Cena usluge mora biti u opsegu 100-50000 RSD!");
                return;
            }

            if (!ValidationHelper.DurationValidation(txtTrajanje))
            {
                MessageBox.Show("Trajanje usluge morа biti u opsegu 5-120 minuta!");
                return;
            }

            try
            {

                if (ServerCommunication.Communication.Instance.SendRequestGetResult<List<Usluga>>
                    (Operation.VratiListuUsluga, null).Any(x => x.NazivUsluge.Equals(txtNaziv.Text)))
                {
                    MessageBox.Show("Vec postoji usluga sa unetim nazivom!");
                    return;
                }

                Usluga u = new Usluga
                {
                    NazivUsluge = txtNaziv.Text,
                    CenaUsluge = double.Parse(txtCena.Text),
                    TrajanjeUsluge = int.Parse(txtTrajanje.Text),
                    SifraVrsteUsluge = (VrstaUsluge)cbVrstaUsluge.SelectedItem,
                    NapomeneZaUslugu = napomene.ToList()
                };

                foreach (NapomenaZaUslugu n in napomene)
                {
                    n.SifraUsluge = u;
                }


                ServerCommunication.Communication.Instance.SendRequestNoResult(Operation.ZapamtiUslugu, u);
                MessageBox.Show("Sistem je uspešno zapamtio uslugu!");

                txtNaziv.Text = "";
                txtCena.Text = "";
                txtTrajanje.Text = "";
                cbVrstaUsluge.SelectedIndex = -1;
                cbVrstaUsluge.Text = "Odaberite vrstu usluge";
                napomene?.Clear();
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            InicijalizujNapomene(dgvNapomene);

        }

        internal void ObrisiNapomenu(DataGridView dgvNapomene)
        {
            if (dgvNapomene.SelectedRows == null || dgvNapomene.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali napomenu za brisanje!");
                return;
            }

            DataGridViewRow red = dgvNapomene.SelectedRows[0];
            NapomenaZaUslugu napomena = (NapomenaZaUslugu)red.DataBoundItem;

            napomene.Remove(napomena);

            int i = 1;

            foreach (NapomenaZaUslugu n in napomene)
            {
                n.RedniBroj = i;
                i++;
            }

            MessageBox.Show("Napomena je obrisana!");

            dgvNapomene.DataSource = null;
            OsveziNapomene(dgvNapomene);

        }

    }
}
