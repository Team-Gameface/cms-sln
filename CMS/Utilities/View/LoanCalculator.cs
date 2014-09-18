using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace CMS.Utilities.View
{
    public partial class LoanCalculator : Form
    {

        public LoanCalculator()
        {
            InitializeComponent();
        }

        public void setLabelsToBlack() 
        {
            this.lblLoanType.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblDuration.ForeColor = System.Drawing.Color.Black;
            this.lblTerms.ForeColor = System.Drawing.Color.Black;
        }

        public void clearFields() 
        {
            this.cbLoanType.SelectedIndex = -1;
            this.txtLoanAmount.Clear();
            this.udPaymentDuration.Value = 0;
            this.cbTerms.Items.Clear();
            this.cbDurationStatus.SelectedIndex = -1;
            this.lblStatePaymentDuration.Text = "";
            this.setStatePaymentDurationFalse();
            this.lblNoOfAmortizations.Text = "";
            this.lblMaturityDate.Text = "";
            this.setAmortizationAmount(0);
            this.setLoanReceivable(0);
            this.setCharge(0);
            this.setInterest(0);
        }

        public void setFormClosing(FormClosingEventHandler e)
        {
            this.FormClosing += e;
        }

        public void setBtnCompute(EventHandler e) 
        {
            this.btnCompute.Click += e;
        }

        public void setBtnClear(EventHandler e)
        {
            this.btnClear.Click += e;
        }

        public void addItemsAtTypeOfLoan(DataSet ds)
        {
            this.cbLoanType.DataSource = ds.Tables[0];
            this.cbLoanType.ValueMember = "LoanTypeId";
            this.cbLoanType.DisplayMember = "LoanTypeName";
        }

        public void cbLoanTypeSelectedIndexChanged(EventHandler e) 
        {
            this.cbLoanType.SelectedIndexChanged += e;
        }

        public DateTime getDateOfApproval()
        {
            return this.dateApproved.Value;
        }

        public double getLoanAmount()
        {
            try
            {
                return Double.Parse(this.txtLoanAmount.Text);
            }
            catch (Exception) { return 0; }
        }

        public int getPaymentDurationValue()
        {

            return int.Parse(this.udPaymentDuration.Value.ToString());
        }

        public void setNoOfAmortizations(int i) 
        {
            this.lblNoOfAmortizations.Text = i.ToString();
        }

        public void setAmortizationAmount(double d) 
        {
            CultureInfo ph = new CultureInfo("en-PH");
            this.txtAmortizationAmount.Text = d.ToString("c", ph);
        }

        public void setLoanReceivable(double d)
        {
            this.txtLoanReceivable.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public void setCharge(double d)
        {
            this.txtCharges.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public void setInterest(double d)
        {
            this.txtInterestRate.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public void setMaturityDate(String s) 
        {
            this.lblMaturityDate.Text = s;
        }

        public void editTerms()
        {
            try
            {
                cbTerms.Items.Clear();

                if (cbDurationStatus.SelectedItem.ToString() == "week/s")
                {
                    cbTerms.Items.Add("weekly");
                }

                else if (cbDurationStatus.SelectedItem.ToString() == "month/s")
                {
                    cbTerms.Items.Add("weekly");
                    cbTerms.Items.Add("monthly");
                }

                else if (cbDurationStatus.SelectedItem.ToString() == "year/s")
                {
                    cbTerms.Items.Add("weekly");
                    cbTerms.Items.Add("monthly");
                    cbTerms.Items.Add("quarterly");
                    cbTerms.Items.Add("semi-annually");
                    cbTerms.Items.Add("annually");
                }
            }
            catch (Exception) { }

        }

        public int getCBLoanTypeIndex()
        {
            return this.cbLoanType.SelectedIndex;
        }

        public int getTypeOfLoan()
        {
            try
            {
                DataRowView drv = (DataRowView)this.cbLoanType.SelectedItem;
                int valueOfItem = int.Parse(drv["LoanTypeId"].ToString());
                return valueOfItem;
            }
            catch (Exception) { return -1; }
        }

        public String getDurationStatus()
        {
            try
            {
                return this.cbDurationStatus.SelectedItem.ToString();
            }
            catch (Exception) { return ""; }
        }

        public String getTermsOfPayment()
        {
            try
            {
                return this.cbTerms.SelectedItem.ToString();
            }
            catch (Exception) { return ""; }
        }

        public void setLblPaymentDuration(String s)
        {
            this.lblStatePaymentDuration.Text = "Duration must be from " + s;
            this.setStatePaymentDurationTrue();
        }

        public String getLblPaymentDuration()
        {
            if (this.lblStatePaymentDuration.Text.Contains("infinity"))
            {
                String[] s = this.lblStatePaymentDuration.Text.Split(' ');
                int from = int.Parse(s[4]);
                String sFrom = s[5];
                if (sFrom == "month/s") { from *= 4; }
                else if (sFrom == "year/s") { from *= 48; }
                return from + "";
            }
            else
            {
                String[] s = this.lblStatePaymentDuration.Text.Split(' ');
                int from = int.Parse(s[4]);
                int to = int.Parse(s[7]);
                String sFrom = s[5];
                String sTo = s[8];

                if (sFrom == "month/s") { from *= 4; }
                else if (sFrom == "year/s") { from *= 48; }
                if (sTo == "month/s") { to *= 4; }
                else if (sTo == "year/s") { to *= 48; }

                return from + " " + to;
            }

        }

        public void setStatePaymentDurationTrue()
        {
            this.lblStatePaymentDuration.Visible = true;
        }

        public void setStatePaymentDurationFalse()
        {
            this.lblStatePaymentDuration.Visible = false;
        }

        private void txtLoanAmount_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtLoanAmount.SelectionStart;
            this.txtLoanAmount.Text = this.getLoanAmount().ToString("N2", CultureInfo.InvariantCulture);
            if (selectionStart == txtLoanAmount.Text.Length - 2)
            {
                this.txtLoanAmount.SelectionStart = txtLoanAmount.Text.Length - 2;
            }
            else if (selectionStart == txtLoanAmount.Text.Length - 1)
            {
                this.txtLoanAmount.SelectionStart = txtLoanAmount.Text.Length - 1;
            }
            else this.txtLoanAmount.SelectionStart = txtLoanAmount.Text.Length - 3;
        }

        private void txtLoanAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            int length = this.txtLoanAmount.Text.Length;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\b' && txtLoanAmount.SelectionStart == this.txtLoanAmount.Text.Length - 2)
            {
                this.txtLoanAmount.SelectionStart = this.txtLoanAmount.Text.Length - 3;
            }

            //if (e.KeyChar == '\b' && length % 4 == 0) 
            //{
            //  MessageBox.Show("hi");
            //this.txtLoanAmount.SelectionStart = this.txtLoanAmount.Text.Length-2;
            //} 

            if (Char.IsDigit(e.KeyChar) && txtLoanAmount.Text.Length == 4)
            {
                this.txtLoanAmount.SelectionStart = this.txtLoanAmount.Text.Length - 3;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                this.txtLoanAmount.Text = this.getLoanAmount().ToString();
                this.txtLoanAmount.SelectionStart = this.txtLoanAmount.Text.Length - 2;
            }
        }

        private void udPaymentDuration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cbDurationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.editTerms();
        }

        private void txtLoanReceivable_TextChanged(object sender, EventArgs e)
        {
            double loanReceivable = double.Parse(this.txtLoanReceivable.Text);
            double charge = double.Parse(this.txtCharges.Text);
            double interest = double.Parse(this.txtInterestRate.Text);

            double netLoan = loanReceivable - charge - interest;
            CultureInfo ph = new CultureInfo("en-PH");
            this.txtNetLoan.Text = netLoan.ToString("c", ph);
        }
    }
}
