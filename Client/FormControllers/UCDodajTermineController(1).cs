using Client.Exceptions;
using Client.FormHelpers;
using Communication;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Client.UserControls;
using Client.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Client.FormControllers
{
    public class UCDodajTermineController
    {
        private BindingList<Termin> termini = new BindingList<Termin>();
        private List<Klijent> klijenti = new List<Klijent>();
        private readonly string senderEmail = "petrovic.fiziocentar@gmail.com";
        private readonly string senderPassword = "eaxrdeaxhstcwfye";

        internal void PripremiFormu(ComboBox cbKlijent, ComboBox cbUsluga, ComboBox cbVaucer, DataGridView dgvTermini)
        {
            try
            {
                UcitajKlijente(cbKlijent);
                UcitajUsluge(cbUsluga);
                UcitajVaucere(cbVaucer);
                InicijalizujTermine(dgvTermini);
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce pokrenuti izabranu formu. Pokusajte kasnije.");
                throw;
            }

        }
        internal void UcitajKlijente(ComboBox cbKlijent)
        {
            klijenti = ServerCommunication.Communication.Instance.SendRequestGetResult<List<Klijent>>(Communication.Operation.VratiListuKlijenata, null);
            cbKlijent.DataSource = klijenti;
            cbKlijent.SelectedIndex = -1;
            cbKlijent.Text = "Odaberite klijenta";
            cbKlijent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbKlijent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbKlijent.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        internal void UcitajUsluge(ComboBox cbUsluga)
        {
            cbUsluga.DataSource = ServerCommunication.Communication.Instance.SendRequestGetResult<List<Usluga>>(Communication.Operation.VratiListuUsluga, null);
            cbUsluga.SelectedIndex = -1;
            cbUsluga.Text = "Odaberite uslugu";
            cbUsluga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbUsluga.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUsluga.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        internal void UcitajVaucere(ComboBox cbVaucer)
        {
            cbVaucer.DataSource = Enum.GetValues(typeof(Vaucer));
            cbVaucer.SelectedIndex = -1;
            cbVaucer.Text = "Odaberite vaucer";
        }

        internal void InicijalizujTermine(DataGridView dgvTermini)
        {
            dgvTermini.DataSource = null;
            dgvTermini.DataSource = termini;
            dgvTermini.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTermini.Columns["SifraKlijenta"].HeaderText = "Klijent";
            dgvTermini.Columns["SifraUsluge"].HeaderText = "Usluga";
            dgvTermini.Columns["DatumVremeTermina"].HeaderText = "Datum i vreme termina";
            dgvTermini.Columns["KonacnaCena"].HeaderText = "Konacna cena";
        }
        private void IsprazniPolja(ComboBox cbKlijent, ComboBox cbUsluga, ComboBox cbVaucer, DateTimePicker dtpDatum, TextBox txtSati, TextBox txtMinuti, RichTextBox rtbNapomena)
        {
            cbKlijent.SelectedIndex = -1;
            cbKlijent.Text = "Odaberite klijenta";
            cbUsluga.SelectedIndex = -1;
            cbUsluga.Text = "Odaberite uslugu";
            dtpDatum.Text = "";
            txtSati.Text = "";
            txtMinuti.Text = "";
            rtbNapomena.Text = "";
            cbVaucer.SelectedIndex = -1;
            cbVaucer.Text = "Odaberite vaucer";
        }

        internal void ObrisiTermin(DataGridView dgvTermini)
        {
            if (dgvTermini.SelectedRows == null || dgvTermini.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali termin za brisanje!");
                return;
            }

            DataGridViewRow red = dgvTermini.SelectedRows[0];
            Termin termin = (Termin)red.DataBoundItem;

            MessageBox.Show("Termin je obrisan!");
            termini.Remove(termin);
            InicijalizujTermine(dgvTermini);
        }

        internal void SacuvajTermine(DataGridView dgvTermini, ComboBox cbKlijent, ComboBox cbUsluga, DateTimePicker dtpDatum, TextBox txtSati, TextBox txtMinuti, RichTextBox rtbNapomena, ComboBox cbVaucer)
        {
            try
            {
                if (termini == null || termini.Count == 0)
                {
                    MessageBox.Show("Nema termina za cuvanje!");
                    return;
                }

                ServerCommunication.Communication.Instance.SendRequestNoResult(Operation.ZapamtiTermine, termini.ToList());
                MessageBox.Show("Sistem je uspešno zapamtio termine!");
                termini?.Clear();
                InicijalizujTermine(dgvTermini);
                IsprazniPolja(cbKlijent, cbUsluga, cbVaucer, dtpDatum, txtSati, txtMinuti, rtbNapomena);

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void DodajTermin(DataGridView dgvTermini, ComboBox cbKlijent, ComboBox cbUsluga, DateTimePicker dtpDatum, TextBox txtSati, TextBox txtMinuti, RichTextBox rtbNapomena, ComboBox cbVaucer)
        { 

            if (!ValidationHelper.ComboBoxValidation(cbKlijent) | !ValidationHelper.ComboBoxValidation(cbUsluga) |
                !ValidationHelper.ComboBoxValidation(cbVaucer) | !ValidationHelper.EmptyFieldValidation(txtSati) |
                !ValidationHelper.EmptyFieldValidation(txtMinuti))
            {
                return;
            }

            if (!ValidationHelper.AppointmentDateValidation(dtpDatum))
            {
                MessageBox.Show("Datum termina ne moze biti u proslosti!");
                return;
            }

            if (!ValidationHelper.AppointmentTimeValidation(txtSati, txtMinuti))
            {
                MessageBox.Show("Vreme morate uneti u 24-casovnom formatu! Radno vreme centra je od 8-22h.");
                return;
            }


            int sati = int.Parse(txtSati.Text);
            int minuti = int.Parse(txtMinuti.Text);
            DateTime datum = new DateTime(dtpDatum.Value.Year, dtpDatum.Value.Month, dtpDatum.Value.Day, sati, minuti, 0);

            Termin termin = new Termin
            {
                SifraKlijenta = (Klijent)cbKlijent.SelectedItem,
                SifraUsluge = (Usluga)cbUsluga.SelectedItem,
                DatumVremeTermina = datum,
                Napomena = rtbNapomena.Text,
                Vaucer = (Vaucer)cbVaucer.SelectedItem
            };

            try
            {
                // Novi termin moze da pocne jedino 15 min nakon zavrsetka ili novi termin ne sme da se zavrsi manje od 15 min pre pocetka drugog termina IZ DGV-a
                if (termini.Any(x => 
                    ((x.DatumVremeTermina.AddMinutes(x.SifraUsluge.TrajanjeUsluge + 15) > termin.DatumVremeTermina &&
                    x.DatumVremeTermina < termin.DatumVremeTermina) ||
                    (termin.DatumVremeTermina.AddMinutes(termin.SifraUsluge.TrajanjeUsluge + 15) > x.DatumVremeTermina &&
                    x.DatumVremeTermina > termin.DatumVremeTermina) ||
                    DateTime.Compare(x.DatumVremeTermina, termin.DatumVremeTermina) == 0)
                    ))
                {
                    MessageBox.Show("Period izmedju dva termina mora biti barem 15 minuta!");
                    return;
                }
                // Novi termin moze da pocne jedino 15 min nakon zavrsetka ili novi termin ne sme da se zavrsi manje od 15 min pre pocetka drugog termina iz BAZE
                if (ServerCommunication.Communication.Instance.SendRequestGetResult<List<Termin>>
                    (Operation.VratiListuTermina, null).Any(x => 
                    ((x.DatumVremeTermina.AddMinutes(x.SifraUsluge.TrajanjeUsluge + 15) > termin.DatumVremeTermina &&
                    x.DatumVremeTermina < termin.DatumVremeTermina) ||
                    (termin.DatumVremeTermina.AddMinutes(termin.SifraUsluge.TrajanjeUsluge + 15) > x.DatumVremeTermina &&
                    x.DatumVremeTermina > termin.DatumVremeTermina) ||
                    DateTime.Compare(x.DatumVremeTermina, termin.DatumVremeTermina) == 0)))
                {
                    MessageBox.Show("Period izmedju dva termina mora biti barem 15 minuta!");
                    return;
                }
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce izvrsiti validaciju za unos termina. Pokusajte kasnije.");
                return;
            }

            IzracunajKonacnuCenu(termin);
            termini.Add(termin);
            InicijalizujTermine(dgvTermini);
            IsprazniPolja(cbKlijent, cbUsluga, cbVaucer, dtpDatum, txtSati, txtMinuti, rtbNapomena);

        }

        private void IzracunajKonacnuCenu(Termin termin)
        {
            switch (termin.Vaucer)
            {
                case Vaucer.BezVaucera:
                    termin.KonacnaCena = termin.SifraUsluge.CenaUsluge;
                    break;
                case Vaucer.UputLekara:
                    termin.KonacnaCena = termin.SifraUsluge.CenaUsluge - 1 * termin.SifraUsluge.CenaUsluge;
                    break;
                case Vaucer.Popust10:
                    termin.KonacnaCena = termin.SifraUsluge.CenaUsluge - 0.1 * termin.SifraUsluge.CenaUsluge;
                    break;
                case Vaucer.Popust20:
                    termin.KonacnaCena = termin.SifraUsluge.CenaUsluge - 0.2 * termin.SifraUsluge.CenaUsluge;
                    break;
                default:
                    termin.KonacnaCena = termin.SifraUsluge.CenaUsluge;
                    break;
            }
        }

        internal void ObavestiKlijenta(DataGridView dgvTermini)
        {
            if (dgvTermini.Rows.Count == 0)
            {
                MessageBox.Show("Nema dostupnih termina za obaveštenje klijenata!");
                return;
            }

            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true,
                };

                foreach (DataGridViewRow red in dgvTermini.Rows)
                {
                    Termin termin = (Termin)red.DataBoundItem;

                    // Generisanje priloženog .ics fajla za trenutni termin
                    string klijentFajl = GenerisiICalFajl(termin);

                    // Sačekajte dok se fajl generiše pre slanja e-maila
                    Thread.Sleep(1000); // Sačekajte 1 sekundu, možete promeniti vreme ako je potrebno

                    // Slanje e-maila sa priloženim .ics fajlom za trenutni termin
                    PosaljiEmail(termin.SifraKlijenta.Email, klijentFajl, smtpClient);
                }

                MessageBox.Show("Klijenti su uspešno obavešteni o terminima!");
            }
            catch (Exception)
            {
                MessageBox.Show("Trenutno nije moguće poslati obaveštenje klijentima. Pokušajte kasnije.");
            }
        }

        private void PosaljiEmail(string klijentEmail, string klijentFajl, SmtpClient smtpClient)
        {
            try
            {
                // Kreiranje i slanje e-maila sa priloženim .ics fajlom
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(senderEmail),
                    Subject = "Obaveštenje o zakazanom terminu u fizio centru Petrović",
                    Body = "Poštovani/a, podsećamo Vas na zakazani termin.",
                    IsBodyHtml = true,
                };


                mailMessage.Attachments.Add(new Attachment(klijentFajl));

                mailMessage.To.Add(klijentEmail);
                smtpClient.Send(mailMessage);
            }
            catch (Exception)
            {
                throw new Exception("Greška prilikom slanja e-maila.");
            }
        }

        private string GenerisiICalFajl(Termin termin)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN:VCALENDAR");
            sb.AppendLine("VERSION:2.0");
            sb.AppendLine("PRODID:-//hacksw/handcal//NONSGML v1.0//EN");

            sb.AppendLine("BEGIN:VEVENT");
            sb.AppendLine($"SUMMARY:{termin.SifraUsluge.NazivUsluge}");
            sb.AppendLine($"DTSTART:{termin.DatumVremeTermina.ToUniversalTime().ToString("yyyyMMddTHHmmssZ")}");
            sb.AppendLine($"DTEND:{termin.DatumVremeTermina.AddMinutes(termin.SifraUsluge.TrajanjeUsluge).ToUniversalTime().ToString("yyyyMMddTHHmmssZ")}");
            sb.AppendLine("END:VEVENT");

            sb.AppendLine("END:VCALENDAR");

            string folderPath = @"C:\Users\Djole\OneDrive\Desktop\Softverski sistem za pracenje rada centra za fizioterapiju\Fajlovi .ICS\";
            string fileName = $"dogadjaj_{DateTime.Now.ToString("yyyyMMddHHmmss")}.ics"; // Ime fajla koje uključuje trenutni datum i vreme
            string filePath = Path.Combine(folderPath, fileName);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(sb.ToString());
            }

            return filePath;
        }
    }  
}
