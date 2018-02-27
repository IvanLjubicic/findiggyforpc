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
    public partial class frmMonMark : Form
    {
        public frmMonMark()
        {
            InitializeComponent();
        }

        private void btnZeroCoupon_Click(object sender, EventArgs e)
        {
            frmZeroCoup frmZC = new frmZeroCoup();
            frmZC.ShowDialog();
        }

        private void btnCoupBonds_Click(object sender, EventArgs e)
        {
            frmCoupBon frmCB = new frmCoupBon();
            frmCB.ShowDialog();
        }
    }
}
