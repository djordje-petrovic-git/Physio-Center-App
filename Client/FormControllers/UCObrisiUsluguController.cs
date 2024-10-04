using Client.Exceptions;
using Client.FormHelpers;
using Communication;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormControllers
{
    public class UCObrisiUsluguController
    {
        private BindingList<Usluga> usluge = new BindingList<Usluga>();
        private BindingList<NapomenaZaUslugu> napomene = new BindingList<NapomenaZaUslugu>();

        internal void PripremiFormu(ComboBox cbVrstaKriterijum, DataGridView dgvUsluge)
        {
            try
            {
                UcitajVrsteUsluga(cbVrstaKriterijum);
                UcitajUsluge();
                InicijalizujUsluge(dgvUsluge);
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce pokrenuti izabranu formu. Pokusajte kasnije.");
                throw;
            }

        }

        internal void UcitajVrsteUsluga(ComboBox cbVrstaKriterijum)
        {
            cbVrstaKriterijum.DataSource = ServerCommunication.Communication.Instance.SendRequestGetResult<List<VrstaUsluge>>(Communication.Operation.VratiListuVrstaUsluga, null);
            cbVrstaKriterijum.SelectedIndex = -1;
            cbVrstaKriterijum.Text = "Odaberite vrstu usluge";
        }

        internal void UcitajUsluge()
        {
            usluge = new BindingList<Usluga>(ServerCommunication.Communication.Instance.
                    SendRequestGetResult<List<Usluga>>(Operation.VratiListuUsluga, null));
        }

        internal void InicijalizujUsluge(DataGridView dgvUsluge)
        {
            if (usluge == null || usluge.Count == 0)
            {
                dgvUsluge.DataSource = new BindingList<Usluga>();
            }
            else
            {
                dgvUsluge.DataSource = null;
                dgvUsluge.DataSource = usluge;
                dgvUsluge.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUsluge.Columns["NazivUsluge"].HeaderText = "Naziv usluge";
                dgvUsluge.Columns["CenaUsluge"].HeaderText = "Cena usluge";
                dgvUsluge.Columns["TrajanjeUsluge"].HeaderText = "Trajanje usluge";
                dgvUsluge.Columns["SifraVrsteUsluge"].HeaderText = "Vrsta usluge";

            }

        }

        private void InicijalizujNapomene(DataGridView dgvNapomene, Usluga usluga)
        {
            if (usluga.NapomeneZaUslugu == null || usluga.NapomeneZaUslugu.Count == 0)
            {
                dgvNapomene.DataSource = new BindingList<NapomenaZaUslugu>();
            }
            else
            {
                dgvNapomene.DataSource = usluga.NapomeneZaUslugu;
                dgvNapomene.Columns["OpisNapomene"].HeaderText = "Opis napomene";
                dgvNapomene.Columns["OpisNapomene"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvNapomene.Columns["SifraTipaNapomene"].HeaderText = "Tip napomene";
                dgvNapomene.Columns["SifraTipaNapomene"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        internal void PretraziUslugu(DataGridView dgvUsluge, CheckBox chbNaziv, CheckBox chbVrsta, TextBox txtNazivKriterijum, ComboBox cbVrstaKriterijum)
        {
            Usluga uslugaZaPretragu = new Usluga();
            txtNazivKriterijum.BackColor = Color.White;
            cbVrstaKriterijum.BackColor = Color.White;

            try
            {
                if (chbNaziv.Checked && !chbVrsta.Checked)
                {
                    if (!ValidationHelper.EmptyFieldValidation(txtNazivKriterijum))
                    {
                        return;
                    }

                    uslugaZaPretragu.SearchCondition = $"u.NazivUsluge like '%{txtNazivKriterijum.Text}%'";
                }

                if (!chbNaziv.Checked && chbVrsta.Checked)
                {
                    if (!ValidationHelper.ComboBoxValidation(cbVrstaKriterijum))
                    {
                        return;
                    }

                    uslugaZaPretragu.SearchCondition = $"vu.NazivVrsteUsluge like '%{((VrstaUsluge)cbVrstaKriterijum.SelectedItem).NazivVrsteUsluge}%'";
                }

                if (chbNaziv.Checked && chbVrsta.Checked)
                {
                    if (!ValidationHelper.EmptyFieldValidation(txtNazivKriterijum) | !ValidationHelper.ComboBoxValidation(cbVrstaKriterijum))
                    {
                        return;
                    }

                    uslugaZaPretragu.SearchCondition = $"u.NazivUsluge like '%{txtNazivKriterijum.Text}%' and vu.NazivVrsteUsluge like '%{((VrstaUsluge)cbVrstaKriterijum.SelectedItem).NazivVrsteUsluge}%'";
                }

                if (!chbNaziv.Checked && !chbVrsta.Checked)
                {

                    UcitajUsluge();
                    InicijalizujUsluge(dgvUsluge);
                    return;
                }

                usluge = new BindingList<Usluga>(ServerCommunication.Communication.Instance.
                    SendRequestGetResult<List<Usluga>>(Operation.PretraziUsluge, uslugaZaPretragu));

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            InicijalizujUsluge(dgvUsluge);

        }


        internal void ObrisiUslugu(DataGridView dgvUsluge, TextBox txtUkupnoTermina)
        {
            if (dgvUsluge.SelectedRows == null || dgvUsluge.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali uslugu za brisanje!");
                return;
            }

            if (!int.TryParse(txtUkupnoTermina.Text, out int broj))
            {
                return;
            }

            if (broj > 0)
            {
                MessageBox.Show("Ne mozete obrisati uslugu koja ima zakazane termine!");
                return;
            }

            DataGridViewRow red = dgvUsluge.SelectedRows[0];
            Usluga usluga = (Usluga)red.DataBoundItem;

            if (usluga.NapomeneZaUslugu != null && usluga.NapomeneZaUslugu.Count != 0)
            {
                DialogResult result = MessageBox.Show("Ako obrisete uslugu, bice obrisane i sve njene napomene. " +
                    "Da li ste sigurni da zelite da obrisete uslugu?", "Brisanje napomena", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }

            }

            try
            {
                ServerCommunication.Communication.Instance.SendRequestNoResult(Operation.ObrisiUslugu, usluga);
                MessageBox.Show("Sistem je uspešno obrisao uslugu!");
                usluge.Remove(usluga);
                InicijalizujUsluge(dgvUsluge);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        internal void PopuniDetalje(DataGridView dgvUsluge, DataGridView dgvNapomene, TextBox txtNaziv, TextBox txtCena, TextBox txtTrajanje, TextBox txtVrsta, TextBox txtUkupnoTermina)
        {
            if (dgvUsluge.SelectedRows == null || dgvUsluge.SelectedRows.Count == 0 || usluge.Count == 0)
            {
                txtNaziv.Text = "";
                txtCena.Text = "";
                txtTrajanje.Text = "";
                txtVrsta.Text = "";
                txtUkupnoTermina.Text = "";
                dgvNapomene.DataSource = new BindingList<NapomenaZaUslugu>();
                return;
            }

            DataGridViewRow red = dgvUsluge.SelectedRows[0];
            Usluga usluga = (Usluga)red.DataBoundItem;

            txtNaziv.Text = usluga.NazivUsluge;
            txtCena.Text = usluga.CenaUsluge.ToString();
            txtTrajanje.Text = usluga.TrajanjeUsluge.ToString();
            txtVrsta.Text = usluga.SifraVrsteUsluge.ToString();

            try
            {
                txtUkupnoTermina.Text = ServerCommunication.Communication.Instance.
                SendRequestGetResult<List<Termin>>(Operation.VratiListuTermina, null).Count
                (x => x.SifraUsluge.SifraUsluge == usluga.SifraUsluge).ToString();
            }
            catch (SystemOperationException)
            {
                txtUkupnoTermina.Text = "Greska!";
                return;
            }

            InicijalizujNapomene(dgvNapomene, usluga);

        }
    }
}
