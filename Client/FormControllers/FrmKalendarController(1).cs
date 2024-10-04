using Client.Exceptions;
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
    public class FrmKalendarController
    {


        private BindingList<Termin> termini = new BindingList<Termin>();

        internal void PripremiFormu(DataGridView dgvTermini)
        {

            try
            {
                UcitajTermine();
                InicijalizujTermine(dgvTermini);
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce pokrenuti izabranu formu. Pokusajte kasnije.");
                throw;
            }
        }

        internal void UcitajTermine()
        {
            var listaTerminaSaServera = ServerCommunication.Communication.Instance
                 .SendRequestGetResult<List<Termin>>(Operation.VratiListuTermina, null);
            termini = new BindingList<Termin>(listaTerminaSaServera);
        }

        internal void InicijalizujTermine(DataGridView dgvTermini)
        {
            if (termini == null || termini.Count == 0)
            {
                dgvTermini.DataSource = new BindingList<Usluga>();
            }
            else 
            {
                var filtriraniTermini = termini.Where(t => t.DatumVremeTermina > DateTime.Now).ToList();
                dgvTermini.DataSource = filtriraniTermini;
                dgvTermini.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTermini.Columns["SifraKlijenta"].HeaderText = "Klijent";
                dgvTermini.Columns["SifraUsluge"].HeaderText = "Usluga";
                dgvTermini.Columns["DatumVremeTermina"].HeaderText = "Datum i vreme termina";
            }
        }

        internal void SortirajPoDatumu(DataGridView dgvTermini, Button btnSortirajPoDatumu, Button btnSortirajPoImenu)
        {
            termini = new BindingList<Termin>(termini.OrderBy(t => t.DatumVremeTermina).ToList());
            dgvTermini.DataSource = termini;
            btnSortirajPoDatumu.Enabled = false;
            btnSortirajPoImenu.Enabled = true;
        }

        internal void SortirajPoImenu(DataGridView dgvTermini, Button btnSortirajPoImenu, Button btnSortirajPoDatumu)
        {
            termini = new BindingList<Termin>(termini.OrderBy(t => t.SifraKlijenta.Ime).ToList());
            dgvTermini.DataSource = termini;
            btnSortirajPoDatumu.Enabled = true;
            btnSortirajPoImenu.Enabled = false;
        }
    }
}
