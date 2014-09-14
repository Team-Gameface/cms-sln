using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Utilities.View
{
    public partial class TimeDepositCalculator : Form
    {
        public TimeDepositCalculator()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            numDuration.Value = 0;
            comboDuration.SelectedIndex = -1;
            txtDepAmt.Text = "0.00";
            txtInterest.Text = "0.00";
            txtTotal.Text = "0.00";
        }

        public void setBtnComputeEventHandler(EventHandler e)
        {
            this.btnCompute.Click += e;
        }

        public void setPrincipal(String s)
        {
            txtDepAmt.Text = s;
        }

        public void setInterest(String s)
        {
            txtInterest.Text = s;
        }

        public void setTotal(String s)
        {
            txtTotal.Text = s;
        }

        public double getPrincipal()
        {
            double d = 0;
            try
            {
                d = double.Parse(txtAmount.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Amount!", "Time Deposit Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return d;
        }

        public int getDuration()
        {
            if (comboDuration.SelectedIndex == 0)
            {
                return int.Parse(numDuration.Value.ToString());
            }
            else if (comboDuration.SelectedIndex == 1)
            {
                int totalDays = Convert.ToInt32((DateTime.Today.AddMonths(int.Parse(numDuration.Value.ToString())) - DateTime.Today).TotalDays);
                return totalDays;
            }
            else if (comboDuration.SelectedIndex == 2)
            {
                int totalDays = Convert.ToInt32((DateTime.Today.AddYears(int.Parse(numDuration.Value.ToString())) - DateTime.Today).TotalDays);
                return totalDays;
            }
            else
            {
                return 0;
            }
        }

        public void setFormClosing(FormClosingEventHandler e)
        {
            this.FormClosing += e;
        }
    }
}
