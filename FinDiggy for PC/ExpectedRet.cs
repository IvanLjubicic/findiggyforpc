using System;
using System.Collections;
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
    public partial class frmExcRet : Form
    {

        ArrayList inputs = new ArrayList();
        int flag = 1;

        public frmExcRet()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            float temp1;
            if (!float.TryParse(tbInput.Text, out temp1))
            {
                MessageBox.Show("Please enter the value");
                
            }
            else if (flag == 1)
            {
                ToolTip1.SetToolTip(this.tbInput, "...and it's probability");
                flag = 0;
                inputs.Add(float.Parse(tbInput.Text));
                tbInput.Text = "";
            }
            else if (flag == 0)
            {
                ToolTip1.SetToolTip(this.tbInput, "Enter possible return");
                flag = 1;
                inputs.Add(float.Parse(tbInput.Text));
                tbInput.Text = "";
            }
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (inputs.Count % 2 != 0)
            {
                MessageBox.Show("Please enter the possibility");
            }
            else if (inputs.Count == 0)
            {
                MessageBox.Show("There are no entered inputs");
            }
            else
            {
                String print = "";
                int j = 0;
                for (int i = 0; i < inputs.Count - 1; i = i + 2)
                {
                    j++;
                    print = print + "Possible return in year " + j
                            + " is " + inputs[i]
                            + "% " + " with probability of "
                            + inputs[i + 1] + "%. ";
                }

                MessageBox.Show(print);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (inputs.Count == 0)
                MessageBox.Show("There are no entered inputs");
            else
                inputs.RemoveAt((inputs.Count) - 1);
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (inputs.Count % 2 != 0)
                MessageBox.Show("Please enter the possibility");
            else if (inputs.Count == 0)
                MessageBox.Show("You did not enter any values");
            else
                calculate();
        }

        private void calculate()
        {
            // TODO Auto-generated method stub
            float sum = 0.0f;
            double variance = 0.0f;
            double stdev, coefvar;
            for (int i = 0; i < inputs.Count; i = i + 2)
            {
                sum = sum + ((float) inputs[i] * (float) inputs[i+1]);
            }
            for (int i = 0; i < inputs.Count; i = i + 2)
            {
                variance = variance + ((float) inputs[i+1] / 100.0) * Math.Pow(((float) inputs[i] / 100.0 - sum / 10000.0), 2.0f);
            }
            //sum = (float) inputs[1];
            stdev = Math.Sqrt(variance);
            coefvar = stdev / (sum / 10000.0);
            lblSolut.Text = "Expected return is " + (sum / 100) +
                    "%.\nVariance is " + variance +
                    ".\nStandard deviation is " + (stdev * 100) +
                    "%.\nCoefficient of variation is " + coefvar;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The average of a probability distribution of possible returns.");
        }
    }
}
