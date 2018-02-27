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
    public partial class frmPerComp : Form
    {
        public frmPerComp()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check on http://en.wikipedia.org/wiki/Compound_interest#Periodic_compounding");

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tbPrincipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            float vt, intrate, t;
            int m;
            if (!float.TryParse(tbPrincipal.Text, out vt) || !float.TryParse(tbIntRate.Text, out intrate) || !Int32.TryParse(tbIntPayment.Text, out m) || !float.TryParse(tbTime.Text, out t))
                MessageBox.Show("Please check entered/missing values!");
            else {
                double solut;
                solut = vt / Math.Pow((1 + (intrate / 100) / m), t * m);
                lblSolution.Text = "Present or discounted value of V(t) is\n" + solut
                + " of a currency you used.";
                lblIntRate.Text = intrate + "%";
            }
        }

        private void btnSolveFut_Click(object sender, EventArgs e)
        {
            float p, intrate, t;
            int m;
            if (!float.TryParse(tbPrincFut.Text, out p) || !float.TryParse(tbIntRateFut.Text, out intrate) || !Int32.TryParse(tbIntPayFut.Text, out m) || !float.TryParse(tbTimeFut.Text, out t))
                MessageBox.Show("Please check entered/missing values!");
            else {
                double solut;
                solut = Math.Pow((1 + (intrate / 100) / m), t * m) * p;
                lblSolutFut.Text = "Value of investment at time t is\n" + solut + " of a currency you used.";
                lblIntRateFut.Text = intrate + "%";
            }
        }

        private void btnInfoFut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check on http://en.wikipedia.org/wiki/Compound_interest#Periodic_compounding");
        }
    }
}
