using Client.Exceptions;
using Client.FormHelpers;
using Client.Forms;
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
    public class FrmUnosNapomeneController
    {
        private BindingList<NapomenaZaUslugu> napomene;

        public FrmUnosNapomeneController(BindingList<NapomenaZaUslugu> napomene)
        {
            this.napomene = napomene;
        }

        internal void PripremiFormu(ComboBox cbTipNapomene)
        {
            try
            {
                UcitajTipoveNapomena(cbTipNapomene);
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce pokrenuti izabranu formu. Pokusajte kasnije.");
                throw;
            }

        }

        internal void UcitajTipoveNapomena(ComboBox cbTipNapomene)
        {
            cbTipNapomene.DataSource = ServerCommunication.Communication.Instance.SendRequestGetResult<List<TipNapomeneZaUslugu>>(Communication.Operation.VratiListuTipovaNapomenaZaUslugu, null);
            cbTipNapomene.SelectedIndex = -1;
            cbTipNapomene.Text = "Odaberite tip napomene";

        }

        internal void DodajNapomenu(RichTextBox rtbOpis, ComboBox cbTipNapomene, FrmUnosNapomene FrmUnosNapomene)
        {

            if (!ValidationHelper.EmptyFieldValidation(rtbOpis) | !ValidationHelper.ComboBoxValidation(cbTipNapomene))
            {
                return;
            }


            NapomenaZaUslugu napomena = new NapomenaZaUslugu
            {
                RedniBroj = napomene.Count + 1,
                OpisNapomene = rtbOpis.Text,
                SifraTipaNapomene = (TipNapomeneZaUslugu)cbTipNapomene.SelectedItem
            };

            foreach (NapomenaZaUslugu n in napomene)
            {
                if (n.OpisNapomene.ToLower().Split(' ').Any(x => napomena.OpisNapomene.ToLower().Split(' ').Contains(x)))
                {
                    DialogResult result = MessageBox.Show("Vec ste uneli slican opis napomene, da li ste sigurni da " +
                      "zelite da unesete dati opis?", "Postoji slican opis!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        napomene.Add(napomena);
                        FrmUnosNapomene.DialogResult = DialogResult.OK;
                        return;
                    }
                    else if (result == DialogResult.No)
                    {
                        FrmUnosNapomene.DialogResult = DialogResult.Abort;
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            napomene.Add(napomena);
            FrmUnosNapomene.DialogResult = DialogResult.OK;

        }
    }
}
