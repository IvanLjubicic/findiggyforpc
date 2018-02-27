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
    public partial class frmZeroCoup : Form
    {
        public frmZeroCoup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f, intrate, solut;
            if (!float.TryParse(tbFacValPre.Text, out f) || !float.TryParse(tbIntRatePre.Text, out intrate))
                MessageBox.Show("Please check entered/missing values!");
            else {
                solut = f / (1 + intrate / 100);
                lblIntRatePre.Text = intrate + "%";
                lblSolutPre.Text = "Present value of the bond is " + solut;
            }
        }

        private void btnSolveInt_Click(object sender, EventArgs e)
        {
            float temp1, temp2;
            if (!float.TryParse(tbFacValInt.Text, out temp1) || !float.TryParse(tbPresValInt.Text, out temp2))
                MessageBox.Show("Please check entered/missing values!");
            else {
                float f, p, solut;
                f = float.Parse(tbFacValInt.Text);
                p = float.Parse(tbPresValInt.Text);
                solut = (f / p - 1) / 100;
                lblSolutInt.Text = "Interest rate of the bond is " + solut + " %";
            }
        }

        private void btnInfoInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check on http://en.wikipedia.org/wiki/Zero-coupon_bond");
        }

        private void btnSolveFac_Click(object sender, EventArgs e)
        {
            float p, intrate, solut;
            if (!float.TryParse(tbPreValFac.Text, out p) || !float.TryParse(tbIntRateFac.Text, out intrate))
                MessageBox.Show("Please check entered/missing values!");
            else {
                solut = p * (1 + intrate / 100);
                lblIntRateFac.Text = intrate + "%";
                lblSolutFac.Text = "Face value of the bond is " + solut;
            }
        }

        private void btnInfoPre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check on http://en.wikipedia.org/wiki/Zero-coupon_bond");
        }

        private void btnInfoFac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check on http://en.wikipedia.org/wiki/Zero-coupon_bond");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
