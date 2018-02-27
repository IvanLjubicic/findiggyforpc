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
    public partial class frmStreams : Form
    {
        public frmStreams()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void frmStreams_Load(object sender, EventArgs e)
        {

        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            float a, intrate, t;
            if (!float.TryParse(tbAnnAmo.Text, out a) || !float.TryParse(tbIntRate.Text, out intrate) || !float.TryParse(tbTime.Text, out t))
                MessageBox.Show("Please check entered/missing values!");
            else
            {
                double solut;
                solut = a / Math.Pow(1 + intrate / 100, t) * (Math.Pow(1 + intrate / 100, t) - 1) / (intrate / 100);
                lblSolution.Text = "Present or discounted value of V(t) is\n" + solut + " of a currency you used.";
                lblIntRate.Text = intrate + "%";
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check on http://en.wikipedia.org/wiki/Time_value_of_money");
        }

        private void btnSolveFut_Click(object sender, EventArgs e)
        {
            float a, intrate, t;
            if (!float.TryParse(tbAnnAmoFut.Text, out a) || !float.TryParse(tbIntRateFut.Text, out intrate) || !float.TryParse(tbTimeFut.Text, out t))
                MessageBox.Show("Please check entered/missing values!");
            else
            {
                double solut;
                solut = a * (1 + intrate / 100) * (Math.Pow(1 + intrate / 100, t) - 1) / (intrate / 100);
                lblSolutFut.Text = "Final value of streams of payments is\n" + solut + " of a currency you used.";
                lblIntRateFut.Text = intrate + "%";
            }
        }

        private void btnInfoFut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check on http://en.wikipedia.org/wiki/Time_value_of_money");
        }
    }
}
