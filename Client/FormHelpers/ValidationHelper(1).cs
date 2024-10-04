using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormHelpers
{
    public static class ValidationHelper
    {
        public static bool EmptyFieldValidation(TextBoxBase txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text) || string.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool ComboBoxValidation(ComboBox cmb)
        {
            if (cmb.SelectedIndex == -1)
            {
                cmb.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                cmb.BackColor = Color.White;
                return true;
            }
        }

        public static bool AgeValidation(TextBox txt)
        {
            if (!int.TryParse(txt.Text, out int godine))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            txt.BackColor = Color.White;
            return true;
        }

        internal static bool NameAndLastNameValidation(TextBox txt)
        {
            try
            {
                var r = new Regex("^[A-Z][a-z][a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
                if (r.IsMatch(txt.Text))
                {
                    txt.BackColor = Color.White;
                    return true;
                }
                txt.BackColor = Color.LightCoral;
                return false;

            }
            catch (Exception)
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
        }

        internal static bool PhoneNumberValidation(TextBox txt)
        {
            try
            {
                var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{3,4})$");
                if (r.IsMatch(txt.Text))
                {
                    txt.BackColor = Color.White;
                    return true;
                }
                txt.BackColor = Color.LightCoral;
                return false;

            }
            catch (Exception)
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
        }

        internal static bool EmailValidation(TextBox txt)
        {
            try
            {
                var r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (r.IsMatch(txt.Text))
                {
                    txt.BackColor = Color.White;
                    return true;
                }
                txt.BackColor = Color.LightCoral;
                return false;

            }
            catch (Exception)
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
        }

        internal static bool PriceValidation(TextBox txt)
        {
            if (!double.TryParse(txt.Text, out double cena))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                if (cena > 50000 || cena < 100)
                {
                    txt.BackColor = Color.LightCoral;
                    return false;
                }
                else
                {
                    txt.BackColor = Color.White;
                    return true;
                }
            }
        }

        internal static bool DurationValidation(TextBox txt)
        {
            if (!int.TryParse(txt.Text, out int trajanje))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                if (trajanje > 120 || trajanje < 5)
                {
                    txt.BackColor = Color.LightCoral;
                    return false;
                }
                else
                {
                    txt.BackColor = Color.White;
                    return true;
                }
            }
        }

        internal static bool AppointmentDateValidation(DateTimePicker dtp)
        {
            if (dtp.Value.Date < DateTime.Today)
            {
                dtp.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                dtp.BackColor = Color.White;
                return true;
            }
        }

        internal static bool AppointmentTimeValidation(TextBox txtSati, TextBox txtMinuti)
        {

            int sati;
            int minuti;

            if (!int.TryParse(txtSati.Text, out sati) | !int.TryParse(txtMinuti.Text, out minuti))
            {
                txtSati.BackColor = Color.LightCoral;
                txtMinuti.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                if (sati > 22 | sati < 8 | minuti > 59 | minuti < 0)
                {
                    txtSati.BackColor = Color.LightCoral;
                    txtMinuti.BackColor = Color.LightCoral;
                    return false;
                }
                else
                {
                    txtSati.BackColor = Color.White;
                    txtMinuti.BackColor = Color.White;
                    return true;
                }
            }
        }
    }
}
