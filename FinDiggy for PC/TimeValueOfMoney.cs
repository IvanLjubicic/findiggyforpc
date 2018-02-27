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
    public partial class frmTimeValue : Form
    {
        public frmTimeValue()
        {
            InitializeComponent();
        }

        private void btnTimeValue_Click(object sender, EventArgs e)
        {
            frmSimInt frmSI = new frmSimInt();
            frmSI.ShowDialog();
        }

        private void btnPerComp_Click(object sender, EventArgs e)
        {
            frmPerComp frmPC = new frmPerComp();
            frmPC.ShowDialog();
        }

        private void btnContComp_Click(object sender, EventArgs e)
        {
            frmContComp frmCC = new frmContComp();
            frmCC.ShowDialog();
        }

        private void btnStreams_Click(object sender, EventArgs e)
        {
            frmStreams frmS = new frmStreams();
            frmS.ShowDialog();
        }
    }
}
