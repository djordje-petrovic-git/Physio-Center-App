using Client.Exceptions;
using Client.FormHelpers;
using Communication;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormControllers
{
    public class UCDodajKlijentaController
    {
        internal void PripremiFormu(ComboBox cbTipKlijenta)
        {
            try
            {
                UcitajTipoveKlijenata(cbTipKlijenta);
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


        internal void SacuvajKlijenta(TextBox txtIme, TextBox txtPrezime, TextBox txtStarost, TextBox txtBrojTelefona, TextBox txtEmail, ComboBox cbTipKlijenta)
        {


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
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Starost = int.Parse(txtStarost.Text),
                BrojTelefona = txtBrojTelefona.Text,
                Email = txtEmail.Text,
                SifraTipaKlijenta = (TipKlijenta)cbTipKlijenta.SelectedItem
            };

            try
            {
                if (ServerCommunication.Communication.Instance.SendRequestGetResult<List<Klijent>>
                (Operation.VratiListuKlijenata, null).Any(x => x.BrojTelefona.Equals(txtBrojTelefona.Text)))
                {
                    MessageBox.Show("Vec postoji klijent sa unetim brojem telefona!");
                    return;
                }

                if (ServerCommunication.Communication.Instance.SendRequestGetResult<List<Klijent>>
                (Operation.VratiListuKlijenata, null).Any(x => x.Email.Equals(txtEmail.Text)))
                {
                    MessageBox.Show("Vec postoji klijent sa unetim email-om!");
                    return;
                }

                ServerCommunication.Communication.Instance.SendRequestNoResult(Operation.ZapamtiKlijenta, k);
                MessageBox.Show("Sistem je uspešno zapamtio klijenta!");

                txtIme.Text = "";
                txtPrezime.Text = "";
                txtStarost.Text = "";
                txtBrojTelefona.Text = "";
                txtEmail.Text = "";
                cbTipKlijenta.SelectedIndex = -1;
                cbTipKlijenta.Text = "Odaberite tip klijenta";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
