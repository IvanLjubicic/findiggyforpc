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
    public partial class frmAritRet : Form
    {

        ArrayList inputs = new ArrayList();


        public frmAritRet()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float temp1;
            if (!float.TryParse(tbInput.Text, out temp1))
                MessageBox.Show("Please check entered/missing value");
            else
            {
                inputs.Add(float.Parse(tbInput.Text));
                tbInput.Text = "";
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            String print = "";
            int j = 0;
            if (inputs.Count % 2 != 0)
                MessageBox.Show("Please enter the final value of investment.");
            else if (inputs.Count == 0)
                MessageBox.Show("There are no entered inputs.");
            else
            {
                for (int i = 0; i < inputs.Count - 1; i = i + 2)
                {
                    j++;
                    print = print + "Initial value in year " + j
                            + " is " + inputs[i]
                            + ", final value in year " + j + " is "
                            + inputs[i + 1] + ". ";
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
                MessageBox.Show("Please enter the final value of investment");
            else if (inputs.Count == 0)
                MessageBox.Show("You did not enter any values");
            else
                calculate();
        }

        private void calculate()
        {
            // TODO Auto-generated method stub
            float aritret = 0.0f;
            double geomret = 1.0f;
            //float inputiplus, inputi;
            for (int i = 0; i < inputs.Count; i = i + 2)
            {
                //inputiplus = (float) inputs[i + 1];
                aritret = aritret + ((float) inputs[i + 1] / (float) inputs[i] - 1);
            }
            aritret = aritret / (inputs.Count / 2);
            aritret = aritret * 100;
            for (int i = 0; i < inputs.Count; i = i + 2)
            {
                geomret = geomret * (1 + ((float) inputs[i + 1] / (float) inputs[i] - 1));

            }
            geomret = (Math.Pow(geomret, 1.0 / (inputs.Count / 2)) - 1) * 100;
            lblSolut.Text = "Arithmetic average rate of return is "
                            + aritret + "%.\nGeometric average rate of return is "
                            + geomret + "%.";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The rate of return on an investment that is calculated by taking the total cash inflow over the life of the investment and dividing it by the number of years in the life of the investment. The average rate of return does not guarantee that the cash inflows are the same in a given year; it simply guarantees that the return averages out to the average rate.");
        }
    }
}
