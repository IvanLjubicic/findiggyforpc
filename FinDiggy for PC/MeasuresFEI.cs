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
    public partial class frmMeasFEI : Form
    {
        public frmMeasFEI()
        {
            InitializeComponent();
        }

        private void btnNpv_Click(object sender, EventArgs e)
        {
            frmNpv frmNetPre = new frmNpv();
            frmNetPre.ShowDialog();
        }

        private void btnAritRet_Click(object sender, EventArgs e)
        {
            frmAritRet frmAR = new frmAritRet();
            frmAR.ShowDialog();
        }

        private void bnExpRet_Click(object sender, EventArgs e)
        {
            frmExcRet frmER = new frmExcRet();
            frmER.ShowDialog();
        }
    }
}
