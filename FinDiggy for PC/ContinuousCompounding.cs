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
    public partial class frmContComp : Form
    {
        public frmContComp()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            float vt, intrate, t;
            if (!float.TryParse(tbPrincipal.Text, out vt) || !float.TryParse(tbIntRate.Text, out intrate) || !float.TryParse(tbTime.Text, out t))
                MessageBox.Show("Please check entered/missing values!");
            else
            {
                double solut;
                solut = vt / Math.Pow(Math.E, t * intrate / 100);
                lblSolution.Text = "Present or discounted value of V(t) is\n" + solut + " of a currency you used.";
                lblIntRate.Text = intrate + "%";
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The process of earning interest on top of interest. The interest is earned constantly, and immediately begins earning interest on itself.");
        }

        private void btnSolveFut_Click(object sender, EventArgs e)
        {
            float p, intrate, t;
            if (!float.TryParse(tbPrincFut.Text, out p) || !float.TryParse(tbIntRatFut.Text, out intrate) || !float.TryParse(tbTimeFut.Text, out t))
                MessageBox.Show("Please check entered/missing values!");
            else
            {
                double solut;
                solut = Math.Pow(Math.E, t * intrate / 100) * p;
                lblSolutFut.Text = "Present or discounted value of V(t) is\n" + solut + " of a currency you used.";
                lblIntRateFut.Text = intrate + "%";
            }
        }

        private void btnInfoFut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The process of earning interest on top of interest. The interest is earned constantly, and immediately begins earning interest on itself.");
        }
    }
}
