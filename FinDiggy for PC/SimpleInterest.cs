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
    public partial class frmSimInt : Form
    {
        public frmSimInt()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            float temp1, temp2, temp3;
            if (!float.TryParse(tbPrincipal.Text, out temp1) || !float.TryParse(tbIntRate.Text, out temp2) || !float.TryParse(tbTime.Text, out temp3))
                MessageBox.Show("Please check entered/missing values!");
            else
            {
                float solut;
                solut = float.Parse(tbPrincipal.Text) / (1 + float.Parse(tbIntRate.Text) / 100 * float.Parse(tbTime.Text));
                lblSolution.Text = "Present or discounted value of V(t) is\n" + solut + " of a currency you used.";
                lblIntRate.Text = float.Parse(tbIntRate.Text) + "%";
            }
        }

        private void btnSolveFut_Click(object sender, EventArgs e)
        {
            float temp1, temp2, temp3;
            if (!float.TryParse(tbPrincFut.Text, out temp1) || !float.TryParse(tbIntRatFut.Text, out temp2) || !float.TryParse(tbTimeFut.Text, out temp3))
                MessageBox.Show("Please check entered/missing values!");
            else
            {
                float solut;
                solut = (1 + float.Parse(tbTimeFut.Text) * float.Parse(tbIntRatFut.Text)/ 100) * float.Parse(tbPrincFut.Text);
                lblSolutFut.Text = "Value of investment at time t is\n" + solut + " of a currency you used.";
                lblIntRateFut.Text = float.Parse(tbIntRatFut.Text) + "%";
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A quick method of calculating the interest charge on a loan. Simple interest is determined by multiplying the interest rate by the principal by the number of periods.");
        }

        private void labIntRate_Click(object sender, EventArgs e)
        {
   
        }

        private void btnInfoFut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A quick method of calculating the interest charge on a loan. Simple interest is determined by multiplying the interest rate by the principal by the number of periods.");
        }
    }
}
