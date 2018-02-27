using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinDiggy_for_PC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMoneyMarket_Click(object sender, EventArgs e)
        {
            frmMonMark frmMM = new frmMonMark();
            frmMM.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAB = new frmAbout();
            frmAB.ShowDialog();
        }

        private void btnMeasuresFEI_Click(object sender, EventArgs e)
        {
            frmMeasFEI frmMeas = new frmMeasFEI();
            frmMeas.ShowDialog();
        }

        private void btnTimeValue_Click(object sender, EventArgs e)
        {
            frmTimeValue frmTV = new frmTimeValue();
            frmTV.ShowDialog();
        }
    }
}
