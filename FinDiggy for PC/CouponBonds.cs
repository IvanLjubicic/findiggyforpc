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
    public partial class frmCoupBon : Form
    {
        public frmCoupBon()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            float temp1, temp2, temp3, temp4;
            int temp5;
            if (!float.TryParse(tbFacVal.Text, out temp1) || !float.TryParse(tbCoupVal.Text, out temp2) || !float.TryParse(tbIntRate.Text, out temp2) || !float.TryParse(tbMatDate.Text, out temp2) || !Int32.TryParse(tbCoupAnn.Text, out temp5))
                MessageBox.Show("Please check entered/missing values!");
            else {
                float f, cv, t, intrate;
                double solut = 0;
                int cpa;
                f = float.Parse(tbFacVal.Text);
                cv = float.Parse(tbCoupVal.Text);
                t = float.Parse(tbMatDate.Text);
                intrate = float.Parse(tbIntRate.Text);
                cpa = Int32.Parse(tbCoupAnn.Text);
                for (int i = 1; i <= t; i++)
                {
                    if (i == t)
                    {
                        solut += f / (Math.Pow(Math.E, i * cpa * intrate / 100));
                    }
                    solut += cv / (Math.Pow(Math.E, i * cpa * intrate / 100));
                }
                lblIntRate.Text = float.Parse(tbIntRate.Text) + "%";
                lblSolut.Text = "Bond value is\n" + solut + " of a currency you used.";
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A debt obligation with coupons attached that represent semiannual interest payments. Also known as a bearer bond.");
        }
    }
}
