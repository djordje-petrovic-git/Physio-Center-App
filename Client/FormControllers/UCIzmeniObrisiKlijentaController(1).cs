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
    public class UCIzmeniObrisiKlijentaController
    {
        private BindingList<Klijent> klijenti = new BindingList<Klijent>();
        private Klijent klijent = new Klijent();
        internal void PripremiFormu(ComboBox cbTipKlijenta, DataGridView dgvKlijenti)
        {
            try
            {
                UcitajTipoveKlijenata(cbTipKlijenta);
                UcitajKlijente();
                InicijalizujKlijente(dgvKlijenti);
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce pokrenuti izabranu formu. Pokusajte kasnije.");
                throw;
            }
        }

        internal void UcitajTipoveKlijenata(ComboBox cbTipKlijenta)
        {
            cbTipKlijenta.DataSource = ServerCommunication.Communication.Instance.SendRequestGetResult<List<TipKlijenta>>(Communication.Operation.VratiListuTipovaKlijenata, null);
            cbTipKlijenta.SelectedIndex = -1;
            cbTipKlijenta.Text = "Odaberite tip klijenta";
        }

        internal void UcitajKlijente()
        {
            klijenti = new BindingList<Klijent>(ServerCommunication.Communication.Instance.
                    SendRequestGetResult<List<Klijent>>(Operation.VratiListuKlijenata, null));
        }

        internal void InicijalizujKlijente(DataGridView dgvKlijenti)
        {
            if (klijenti == null || klijenti.Count == 0)
            {
                dgvKlijenti.DataSource = new BindingList<Klijent>();
            }
            else
            {
                dgvKlijenti.DataSource = null;
                dgvKlijenti.DataSource = klijenti;
                dgvKlijenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvKlijenti.Columns["Ime"].HeaderText = "Ime";
                dgvKlijenti.Columns["Prezime"].HeaderText = "Prezime";
            }
        }



        internal void ObrisiKlijenta(DataGridView dgvKlijenti, TextBox txtBrojTermina)
        {
            if (dgvKlijenti.SelectedRows == null || dgvKlijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali klijenta za brisanje!");
                return;
            }

            if (!int.TryParse(txtBrojTermina.Text, out int broj))
            {
                return;
            }

            if (broj > 0)
            {
                MessageBox.Show("Ne mozete obrisati klijenta koji ima zakazane termine!");
                return;
            }

            DataGridViewRow red = dgvKlijenti.SelectedRows[0];
            Klijent klijent = (Klijent)red.DataBoundItem;


            try
            {
                ServerCommunication.Communication.Instance.SendRequestNoResult(Operation.ObrisiKlijenta, klijent);
                MessageBox.Show("Sistem je uspešno obrisao klijenta.");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            klijenti.Remove(klijent);
            InicijalizujKlijente(dgvKlijenti);
        }

        internal void IzmeniKlijenta(DataGridView dgvKlijenti, TextBox txtIme, TextBox txtPrezime, TextBox txtStarost, TextBox txtBrojTelefona, TextBox txtEmail, ComboBox cbTipKlijenta, CheckBox chbImePrezimeKriterijum, TextBox txtImePrezimeKriterijum)
        {
            if (dgvKlijenti.SelectedRows == null || dgvKlijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati klijenta da biste ga izmenili!");
                return;
            }

            if (!ValidationHelper.EmptyFieldValidation(txtIme) | !ValidationHelper.EmptyFieldValidation(txtPrezime) |
                   !ValidationHelper.EmptyFieldValidation(txtStarost) | !ValidationHelper.EmptyFieldValidation(txtBrojTelefona) |
                   !ValidationHelper.EmptyFieldValidation(txtEmail) | !ValidationHelper.ComboBoxValidation(cbTipKlijenta))
            {
                return;
            }

            if (!ValidationHelper.NameAndLastNameValidation(txtIme))
            {
                MessageBox.Show("Ime nije u dobrom formatu!");
                return;
            }

            if (!ValidationHelper.NameAndLastNameValidation(txtPrezime))
            {
                MessageBox.Show("Prezime nije u dobrom formatu!");
                return;
            }

            if (!ValidationHelper.AgeValidation(txtStarost))
            {
                MessageBox.Show("Klijent mora imati 18 ili vise godina!");
                return;
            }

            if (!ValidationHelper.PhoneNumberValidation(txtBrojTelefona))
            {
                MessageBox.Show("Broj telefona mora biti u formatu xxx-xxx-xxxx ili xxx-xxx-xxx (sa ili bez -)!");
                return;
            }

            if (!ValidationHelper.EmailValidation(txtEmail))
            {
                MessageBox.Show("Email nije u dobrom formatu!");
                return;
            }

            Klijent k = new Klijent
            {
                SifraKlijenta = klijent.SifraKlijenta,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                BrojTelefona = txtBrojTelefona.Text,
                Email = txtEmail.Text,
                Starost = int.Parse(txtStarost.Text),
                SifraTipaKlijenta = (TipKlijenta)cbTipKlijenta.SelectedItem
            };

            try
            {
                if (ServerCommunication.Communication.Instance.SendRequestGetResult<List<Klijent>>
                    (Operation.VratiListuKlijenata, null).Any(x => x.BrojTelefona.Equals(txtBrojTelefona.Text) &&
                    x.SifraKlijenta != k.SifraKlijenta))
                {
                    MessageBox.Show("Vec postoji klijent sa unetim brojem telefona!");
                    return;
                }

                if (ServerCommunication.Communication.Instance.SendRequestGetResult<List<Klijent>>
                    (Operation.VratiListuKlijenata, null).Any(x => x.Email.Equals(txtEmail.Text) && x.SifraKlijenta != k.SifraKlijenta))
                {
                    MessageBox.Show("Vec postoji klijent sa unetim email-om!");
                    return;
                }

                ServerCommunication.Communication.Instance.SendRequestNoResult(Operation.IzmeniKlijenta, k);
                MessageBox.Show("Sistem je uspešno izmenio klijenta.");

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                PretraziKlijenta(dgvKlijenti, chbImePrezimeKriterijum, txtImePrezimeKriterijum);
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce ucitati listu klijenata. Pokusajte kasnije.");
                klijenti.Clear();
                InicijalizujKlijente(dgvKlijenti);
            }

        }

        internal void PretraziKlijenta(DataGridView dgvKlijenti, CheckBox chbImePrezimeKriterijum, TextBox txtImePrezimeKriterijum)
        {
            try
            {
                Klijent klijentZaPretragu = new Klijent();
                txtImePrezimeKriterijum.BackColor = Color.White;


                if (chbImePrezimeKriterijum.Checked)
                {
                    if (!ValidationHelper.EmptyFieldValidation(txtImePrezimeKriterijum))
                    {
                        return;
                    }

                    string[] imePrezime = txtImePrezimeKriterijum.Text.Split(' ');

                    string pretraga1 = "";
                    string pretraga2 = "";

                    if (imePrezime.Length == 1)
                    {
                        pretraga1 = imePrezime[0];
                        klijentZaPretragu.SearchCondition = $"kl.Ime like '%{pretraga1}%' or kl.Prezime like '%{pretraga1}%'";
                    }
                    else
                    {
                        pretraga1 = imePrezime[0];
                        pretraga2 = imePrezime[1];
                        klijentZaPretragu.SearchCondition = $"(kl.Ime like '%{pretraga1}%' and kl.Prezime like '%{pretraga2}%') or " +
                        $"(kl.Ime like '%{pretraga2}%' and kl.Prezime like '%{pretraga1}%')";

                    }
                }
                else
                {
                    UcitajKlijente();
                    InicijalizujKlijente(dgvKlijenti);
                    return;
                }

                klijenti = new BindingList<Klijent>(ServerCommunication.Communication.Instance.
                    SendRequestGetResult<List<Klijent>>(Operation.PretraziKlijente, klijentZaPretragu));

                InicijalizujKlijente(dgvKlijenti);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // popunjvanje 
        internal void PopuniDetalje(DataGridView dgvKlijenti, TextBox txtIme, TextBox txtPrezime, TextBox txtStarost, TextBox txtBrojTelefona, TextBox txtEmail, ComboBox cbTipKlijenta, TextBox txtBrojTermina)
        {
            if (dgvKlijenti.SelectedRows == null || dgvKlijenti.SelectedRows.Count == 0 || klijenti.Count == 0)
            {
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtStarost.Text = "";
                txtBrojTelefona.Text = "";
                txtEmail.Text = "";
                cbTipKlijenta.SelectedIndex = -1;
                cbTipKlijenta.Text = "Odaberite tip klijenta";
                return;
            }

            DataGridViewRow red = dgvKlijenti.SelectedRows[0];
            Klijent kl = (Klijent)red.DataBoundItem;
            klijent.SifraKlijenta = kl.SifraKlijenta;

            txtIme.Text = kl.Ime;
            txtPrezime.Text = kl.Prezime;
            txtStarost.Text = kl.Starost.ToString();
            txtBrojTelefona.Text = kl.BrojTelefona;
            txtEmail.Text = kl.Email;
            cbTipKlijenta.Text = kl.SifraTipaKlijenta.ToString();

            try
            {
                txtBrojTermina.Text = ServerCommunication.Communication.Instance.
                SendRequestGetResult<List<Termin>>(Operation.VratiListuTermina, null).Count
                (x => x.SifraKlijenta.SifraKlijenta == kl.SifraKlijenta).ToString();
            }
            catch (SystemOperationException)
            {
                txtBrojTermina.Text = "Greska!";
                return;
            }
        }
    }
}
