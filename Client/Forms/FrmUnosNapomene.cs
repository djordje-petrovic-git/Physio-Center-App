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

namespace Client.Forms
{
    public partial class FrmUnosNapomene : Form
    {
        private FrmUnosNapomeneController FrmUnosNapomeneController;
        public FrmUnosNapomene()
        {
            
        }

        public FrmUnosNapomene(FrmUnosNapomeneController FrmUnosNapomeneController)
        {
            InitializeComponent();
            this.FrmUnosNapomeneController = FrmUnosNapomeneController;
            FrmUnosNapomeneController.PripremiFormu(cbTipNapomene);
        }


        private void btnDodajNapomenu_Click(object sender, EventArgs e)
        {
            FrmUnosNapomeneController.DodajNapomenu(rtbOpis, cbTipNapomene, this);
        }
    }
}
