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
    public partial class frmNpv : Form
    {
        ArrayList incomes = new ArrayList();
        ArrayList outcomes = new ArrayList();


        public frmNpv()
        {
            InitializeComponent();
        }

        private void Npv_Load(object sender, EventArgs e)
        {

        }

        private void btnAddIn_Click(object sender, EventArgs e)
        {
            float temp1;
            if (!float.TryParse(tbIncomes.Text, out temp1))
                MessageBox.Show("Please check entered/missing value");
            else
            {
                incomes.Add(float.Parse(tbIncomes.Text));
                tbIncomes.Text = "";
            }
        }

        private void tbIncomes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheIn_Click(object sender, EventArgs e)
        {
            String print1 = "Incomes:";
            for (int i = 0; i < incomes.Count; i++)
            {
                if (i != incomes.Count - 1)
                    print1 = print1 + " " + incomes[i] + " in year " + i + ",";
                else
                    print1 = print1 + " " + incomes[i] + " in year " + i + ".";
            }
            MessageBox.Show(print1);
        }

        private void btnDelIn_Click(object sender, EventArgs e)
        {
            if (incomes.Count == 0)
                MessageBox.Show("There are no entered incomes.");
            else
                incomes.RemoveAt((incomes.Count) - 1);
        }

        private void btnAddOu_Click(object sender, EventArgs e)
        {
            float temp1;
            if (!float.TryParse(tbOutcomes.Text, out temp1))
                MessageBox.Show("Please check entered/missing value");
            else
            {
                outcomes.Add(float.Parse(tbOutcomes.Text));
                tbOutcomes.Text = "";
            }
        }

        private void btnCheOu_Click(object sender, EventArgs e)
        {
            String print1 = "Outcomes:";
            for (int i = 0; i < outcomes.Count; i++)
            {
                if (i != outcomes.Count - 1)
                    print1 = print1 + " " + outcomes[i] + " in year " + i + ",";
                else
                    print1 = print1 + " " + outcomes[i] + " in year " + i + ".";
            }
            MessageBox.Show(print1);
        }

        private void btnDelOu_Click(object sender, EventArgs e)
        {
            if (incomes.Count == 0)
                MessageBox.Show("There are no entered incomes.");
            else
                outcomes.RemoveAt((incomes.Count) - 1);
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            float temp1;
            if (!float.TryParse(tbDisRate.Text, out temp1))
                MessageBox.Show("Please enter the discount.");
            else
            {
                lblDisRate.Text = float.Parse(tbDisRate.Text) + "%";
                int t = 0;
                double sumP = 0.0f;
                double sumN = 0.0f;
                double sum = 0.0f;
                float discrate = float.Parse(tbDisRate.Text);
                if (incomes.Count == 0)
                {
                    sumP = 0;
                }
                else
                {
                    foreach (float f in incomes)
                    {
                        sumP += f / (Math.Pow(1 + discrate / 100, t));
                        t++;
                    }
                }
                t = 0;
                if (outcomes.Count == 0)
                {
                    sumN = 0;
                }
                else
                {
                    foreach (float f in outcomes)
                    {
                        sumN += f / (Math.Pow(1 + discrate / 100, t));
                        t++;
                    }
                }
                sum = sumP - sumN;
                lblSolut.Text = ("Net Present Value is " + sum);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The difference between the present value of cash inflows and the present value of cash outflows. NPV is used in capital budgeting to analyze the profitability of an investment or project.");
        }
    }
}
