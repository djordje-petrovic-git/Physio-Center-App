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
    public partial class FrmKalendar : Form
    {
        private FrmKalendarController FrmKalendarController;
        public FrmKalendar()
        {

        }

        public FrmKalendar(FrmKalendarController FrmKalendarController)
        {
            InitializeComponent();
            this.FrmKalendarController = FrmKalendarController;
            FrmKalendarController.PripremiFormu(dgvTermini);
        }

        private void btnSortirajPoDatumu_Click(object sender, EventArgs e)
        {
            FrmKalendarController.SortirajPoDatumu(dgvTermini, btnSortirajPoDatumu, btnSortirajPoImenu);
        }

        private void btnSortirajPoImenu_Click(object sender, EventArgs e)
        {
            FrmKalendarController.SortirajPoImenu(dgvTermini,btnSortirajPoImenu, btnSortirajPoDatumu);
        }
    }
}
