using Client.Exceptions;
using Client.FormHelpers;
using Communication;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormControllers
{
    public class UCPretraziObrisiTerminController
    {
        private BindingList<Termin> termini = new BindingList<Termin>();
       

        internal void PripremiFormu(DataGridView dgvTermini, ComboBox cbKlijentKriterijum)
        {
            try
            {
                UcitajKlijente(cbKlijentKriterijum);
                UcitajTermine(dgvTermini);
                InicijalizujTermine(dgvTermini);
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce pokrenuti izabranu formu. Pokusajte kasnije.");
                throw;
            }
        }

        internal void UcitajKlijente(ComboBox cbKlijentKriterijum)
        {
            cbKlijentKriterijum.DataSource = ServerCommunication.Communication.Instance.SendRequestGetResult<List<Klijent>>(Communication.Operation.VratiListuKlijenata, null);
            cbKlijentKriterijum.SelectedIndex = -1;
            cbKlijentKriterijum.Text = "Odaberite klijenta";
            cbKlijentKriterijum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbKlijentKriterijum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbKlijentKriterijum.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        internal void UcitajTermine(DataGridView dgvTermini)
        {
            termini = new BindingList<Termin>(ServerCommunication.Communication.Instance.
                     SendRequestGetResult<List<Termin>>(Operation.VratiListuTermina, null));
        }

        internal void InicijalizujTermine(DataGridView dgvTermini)
        {
            if (termini == null || termini.Count == 0)
            {
                dgvTermini.DataSource = new BindingList<Usluga>();
            }
            else
            {
                
                dgvTermini.DataSource = null;
                dgvTermini.DataSource = termini;
                dgvTermini.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTermini.Columns["SifraKlijenta"].HeaderText = "Klijent";
                dgvTermini.Columns["SifraUsluge"].HeaderText = "Usluga";
                dgvTermini.Columns["DatumVremeTermina"].HeaderText = "Datum i vreme termina";
                dgvTermini.Columns["KonacnaCena"].HeaderText = "Konacna cena";
            }
        }

        private void IsprazniPolja(ComboBox cbKlijent, ComboBox cbUsluga, ComboBox cbVaucer, DateTimePicker dtpDatum, TextBox txtSati, TextBox txtMinuti, RichTextBox rtbNapomena)
        {
            cbKlijent.SelectedIndex = -1;
            cbKlijent.Text = "";
            cbUsluga.SelectedIndex = -1;
            cbUsluga.Text = "";
            dtpDatum.Text = "";
            txtSati.Text = "";
            txtMinuti.Text = "";
            rtbNapomena.Text = "";
            cbVaucer.SelectedIndex = -1;
            cbVaucer.Text = "";
        }

        internal void PopuniDetalje(DataGridView dgvTermini, ComboBox cbKlijent, ComboBox cbUsluga, DateTimePicker dtpDatum, TextBox txtSati, TextBox txtMinuti, RichTextBox rtbNapomena, ComboBox cbVaucer)
        {
            if (dgvTermini.SelectedRows == null || dgvTermini.SelectedRows.Count == 0 || termini.Count == 0)
            {
                IsprazniPolja(cbKlijent, cbUsluga, cbVaucer, dtpDatum, txtSati, txtMinuti, rtbNapomena);
                return;
            }

            DataGridViewRow red = dgvTermini.SelectedRows[0];
            Termin termin = (Termin)red.DataBoundItem;

            cbKlijent.Text = termin.SifraKlijenta.ToString();
            cbUsluga.Text = termin.SifraUsluge.ToString();
            DateTime datum = termin.DatumVremeTermina;
            dtpDatum.Value = datum.Date;
            txtSati.Text = datum.Hour.ToString();
            txtMinuti.Text = datum.Minute.ToString().Length == 1 ? "0" + datum.Minute.ToString() : datum.Minute.ToString();
            rtbNapomena.Text = termin.Napomena;
            cbVaucer.DataSource = Enum.GetValues(typeof(Vaucer));
            cbVaucer.SelectedItem = termin.Vaucer;
        }

        

        internal void PretraziTermine(DataGridView dgvTermini, CheckBox chbKlijentKriterijum, CheckBox chbDatumVremeKriterijum, ComboBox cbKlijentKriterijum, DateTimePicker dtpDatumKriterijum, TextBox txtSatiKriterijum, TextBox txtMinutiKriterijum)
        {
            string uslov = "";
            cbKlijentKriterijum.BackColor = Color.White;
            txtSatiKriterijum.BackColor = Color.White;
            txtMinutiKriterijum.BackColor = Color.White;

            if (chbKlijentKriterijum.Checked && ValidationHelper.ComboBoxValidation(cbKlijentKriterijum))
            {
                uslov += $"t.SifraKlijenta={((Klijent)cbKlijentKriterijum.SelectedItem).SifraKlijenta} and ";
            }
            if (chbDatumVremeKriterijum.Checked && ValidationHelper.AppointmentTimeValidation(txtSatiKriterijum, txtMinutiKriterijum))
            {
                int sati = int.Parse(txtSatiKriterijum.Text);
                int minuti = int.Parse(txtMinutiKriterijum.Text);
                int godina = dtpDatumKriterijum.Value.Year;
                int mesec = dtpDatumKriterijum.Value.Month;
                int dan = dtpDatumKriterijum.Value.Day;
                
                uslov += $"t.DatumVremeTermina='{mesec + "." + dan + "." + godina + " " + sati + ":" + minuti}' and ";
            }
           

            if (String.IsNullOrEmpty(uslov))
            {
                UcitajTermine(dgvTermini);
                InicijalizujTermine(dgvTermini);
            }
            else
            {
                uslov = uslov.Substring(0, (uslov.Length - 5));

                try
                {
                    Termin termin = new Termin
                    {
                        SearchCondition = uslov
                    };

                    termini = new BindingList<Termin>(ServerCommunication.Communication.Instance.
                        SendRequestGetResult<List<Termin>>(Operation.PretraziTermine, termin));

                    InicijalizujTermine(dgvTermini);
                }
                catch (SystemOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        internal void ObrisiTermin(DataGridView dgvTermini)
        {
            if (dgvTermini.SelectedRows == null || dgvTermini.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali termin za brisanje!");
                return;
            }
            Termin termin = (Termin)dgvTermini.SelectedRows[0].DataBoundItem;
            try
            {
             
                ServerCommunication.Communication.Instance.SendRequestNoResult(Operation.ObrisiTermin, termin);
                MessageBox.Show("Sistem je uspešno obrisao termin!");
                termini.Remove(termin);
                InicijalizujTermine(dgvTermini);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        
    }
}
