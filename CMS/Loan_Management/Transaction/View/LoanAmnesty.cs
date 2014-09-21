using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Transaction.View
{
    public partial class LoanAmnesty : Form
    {
        public LoanAmnesty()
        {
            InitializeComponent();
        }
        public void disableFunction()
        {
            this.tabLoanAmnesty.SelectTab(tabMemberInfo);
            btnCancelAmnesty.Enabled = false;
            btnApplyAmnesty.Enabled = false;

            this.tabAmnestyApplication.Enabled = false;
            this.tabAmnestyApproval.Enabled = false;

            //tabMemberInformation
            dataActiveMember.Enabled = true;
            rbAccountNo.Checked = false;
            rbMemberName.Checked = false;
            txtAccountNo.Clear();
            txtMemberName.Clear();
            rbAccountNo.Enabled = true;
            rbMemberName.Enabled = true;
            txtAccountNo.Enabled = false;
            txtMemberName.Enabled = false;

            txtUnpaidLoan.Clear();
            txtTotalLoanBalance.Clear();
            txtLastPaymentDate.Clear();
            txtClassification.Clear();

            //tabApplication
            dataSelectLoan.DataSource = null;
            txtLoanDetails.ReadOnly = true;
            txtLoanDetails.Clear();
            txtPurpose.Clear();

            //tabApproval
            dateApproved.Value = DateTime.Now;
            txtPWaived.Clear();
            txtIWaived.Clear();
            txtIWaived.Enabled = false;
            txtPWaived.Enabled = false;
            dateApproved.Value = DateTime.Now;
        }

        public void disableDataActiveMember()
        {
            dataActiveMember.Enabled = false;
        }

        public void clearMemberInfoData()
        {
            this.txtUnpaidLoan.Clear();
            this.txtClassification.Clear();
            this.txtTotalLoanBalance.Clear();
            this.txtLastPaymentDate.Clear();
        }

        public void btnProceedFunction()
        {
            tabLoanAmnesty.SelectTab(tabAmnestyApplication);
            tabAmnestyApplication.Enabled = true;
            rbAccountNo.Enabled = false;
            rbMemberName.Enabled = false;
            txtAccountNo.Enabled = false;
            txtMemberName.Enabled = false;
        }

        public void btnDetailsPreviousFunction()
        {
            tabLoanAmnesty.SelectTab(tabMemberInfo);
        }

        public void btnDetailsNextFunction()
        {
            tabLoanAmnesty.SelectTab(tabAmnestyApproval);
            tabAmnestyApproval.Enabled = true;
            btnApplyAmnesty.Enabled = true;
            btnCancelAmnesty.Enabled = true;
        }

        public void btnApprovalPreviousFunction()
        {
            tabLoanAmnesty.SelectTab(tabAmnestyApplication);
        }

        public void enablePWaive()
        {
            this.txtPWaived.Enabled = true;
        }

        public void enableIWaive()
        {
            this.txtIWaived.Enabled = true;
        }

        //ENABLE DISABLE END


        //buttons

        public void setBtnProceedEventHandler(EventHandler e)
        {
            this.btnProceed.Click += e;
        }

        public void setBtnApplyAmnestyEventHandler(EventHandler e)
        {
            this.btnApplyAmnesty.Click += e;
        }

        public void setBtnApprovalPreviousEventHandler(EventHandler e)
        {
            this.btnApprovalPrevious.Click += e;
        }

        public void setBtnCancelAmnestyEventHandler(EventHandler e)
        {
            this.btnCancelAmnesty.Click += e;
        }

        public void setBtnDetailsNextEventHandler(EventHandler e)
        {
            this.btnDetailsNext.Click += e;
        }

        public void setBtnDetailsPreviousEventHandler(EventHandler e)
        {
            this.btnDetailsPrevious.Click += e;
        }



        //buttons end



        //txtBox

        public void setUnpaidLoan(int i)
        {
            this.txtUnpaidLoan.Text = i.ToString();
        }

        public void setTotalLoanBalance(double d)
        {
            this.txtTotalLoanBalance.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public void setLoanAmount(double d)
        {
            this.txtLoanAmount.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public void setLastPaymentDate(String s)
        {
            this.txtLastPaymentDate.Text = s;
        }

        public void setClassification(String s)
        {
            this.txtClassification.Text = s;
        }

        public void setLoanDetails(String s)
        {
            this.txtLoanDetails.AppendText(s);
            this.txtLoanDetails.AppendText(Environment.NewLine);
        }

        public void clearLoanDetails() {

            txtLoanDetails.Clear();
        
        }

        public String getPurpose()
        {
            return this.txtPurpose.Text;
        }

        public double getInterestWaivePercentage()
        {
            try
            {
                return double.Parse(this.txtIWaived.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getPenaltyWaivePercentage()
        {
            try
            {
                return double.Parse(this.txtPWaived.Text);
            }
            catch (Exception) { return 0; }
        }

        public void setUnpaidLoanAmount(double d)
        {
            this.txtUnpaidLoan.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public void setInterestWaivePercentage(double d)
        {
            this.txtIWaived.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public void setPenaltyWaivePercentage(double d)
        {
            this.txtPWaived.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }
        public double getUnpaidLoanAmount()
        {
            return double.Parse(this.txtLoanAmount.Text);
        }

        public void setInterest(double d)
        {
            this.txtInterest.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public double getInterest()
        {
            return double.Parse(this.txtInterest.Text);
        }

        public void setPenalty(double d)
        {
            this.txtPenalty.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public double getPenalty()
        {
            return double.Parse(this.txtPenalty.Text);
        }

        public void setLoanBalance(double d)
        {
            this.txtLoanBalance.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public double getLoanBalance()
        {
            return double.Parse(this.txtLoanBalance.Text);
        }

        public void setGrossLoanBalance(double d)
        {
            this.txtGrossLoanBalance.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public double getGrossLoanBalance()
        {
            return double.Parse(this.txtGrossLoanBalance.Text);
        }

        public void setWaivedInterest(double d)
        {
            this.txtWaiveInterest.Text = d.ToString("N2", CultureInfo.InvariantCulture);
        }

        public double getWaiveInterest()
        {
            return double.Parse(this.txtWaiveInterest.Text);
        }

        public void setWaivePenalty(double d)
        {
            this.txtWaivedPenalty.Text = d.ToString("N2", CultureInfo.InvariantCulture);
        }

        public double getWaivePenalty()
        {
            return double.Parse(this.txtWaivedPenalty.Text);
        }

        public void setNewLoanBalance(double d)
        {
            this.txtNewLoanBalance.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public double getNewLoanBalance()
        {
            return double.Parse(this.txtNewLoanBalance.Text);
        }

        public String getActiveAccountNo()
        {
            return this.txtAccountNo.Text.ToString();
        }

        public String getActiveMemberName()
        {
            return this.txtMemberName.Text.ToString();
        }


        //txtBox End



        //date

        public String getDateOfApproval()
        {
            return this.dateApproved.Value.ToString();
        }

        //date

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        //datagridview

        public void activeMemberGrid(DataSet ds)
        {
            this.dataActiveMember.DataSource = ds.Tables[0];
        }

        public void selectLoanGrid(DataSet ds)
        {
            this.dataSelectLoan.DataSource = ds.Tables[0];
            this.dataSelectLoan.Columns[0].Visible = false;
            this.dataSelectLoan.Columns[1].Visible = false;
        }

        public void classGridAmortization(DataSet ds)
        {
            this.dataAmortization.DataSource = ds.Tables[0];
        }

        public void dataActiveMember_CellClick(DataGridViewCellEventHandler e)
        {
            this.dataActiveMember.CellClick += e;
        }

        public void dataSelectLoan_CellClick(DataGridViewCellEventHandler e)
        {
            this.dataSelectLoan.CellClick += e;
        }

        public int getLoanTypeId()
        {
            DataGridViewRow selectedData = this.getSelectedApplicationId();
            return int.Parse(selectedData.Cells["LoanTypeId"].Value.ToString());
        }

        public String getAccountNo()
        {
            DataGridViewRow selectedData = this.getSelectedActiveMember();
            return selectedData.Cells["Account No."].Value.ToString();
        }

        public DataGridViewRow getSelectedActiveMember()
        {
            return this.dataActiveMember.SelectedRows[0];
        }

        public int getApplicationId()
        {
            DataGridViewRow selectedData = this.getSelectedApplicationId();
            return int.Parse(selectedData.Cells["LoanApplicationId"].Value.ToString());
        }

        public DataGridViewRow getSelectedApplicationId()
        {
            return this.dataSelectLoan.SelectedRows[0];
        }

        public void clearSelectionActiveMember()
        {
            this.dataActiveMember.ClearSelection();
        }

        public void clearSelectionLoan()
        {
            this.dataSelectLoan.ClearSelection();
        }

        //datagridview

        private void txtPercent_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void loanBalanceBreakdown_TextChanged(object sender, EventArgs e)
        {
            double unpaidLoanAmount = this.getUnpaidLoanAmount();
            double interest = this.getInterest();
            double penalty = this.getPenalty();

            this.setLoanBalance(unpaidLoanAmount + interest + penalty);

            this.setGrossLoanBalance(unpaidLoanAmount + interest + penalty);
        }

        private void PenaltyCondoned_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWaived_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtPenaltyWaive_TextChanged(EventHandler e)
        {
            this.txtPWaived.TextChanged += e;
        }


        public void txtInterestWaive_TextChanged(EventHandler e)
        {
            this.txtIWaived.TextChanged += e;
        }

        public void txtMemberName_TextChanged(EventHandler e)
        {
            this.txtMemberName.TextChanged += e;
        }

        public void txtAccountNo_TextChanged(EventHandler e)
        {
            this.txtAccountNo.TextChanged += e;
        }

        private void rbAccountNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAccountNo.Checked == true)
            {
                this.txtAccountNo.Enabled = true;
                this.txtMemberName.Clear();
                this.txtMemberName.Enabled = false;
            }
            else 
            {
                this.txtAccountNo.Clear();
            }
        }

        private void rbMemberName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMemberName.Checked == true)
            {
                this.txtMemberName.Enabled = true;
                this.txtAccountNo.Clear();
                this.txtAccountNo.Enabled = false;
            }
            else
            {
                this.txtMemberName.Clear();
            }
        }

        private void txtPWaived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split('.');
                if (parts.Length > 1 || tb.TextLength > 4)
                {
                    try
                    {
                        if (parts[0].Length > 3 || parts[1].Length > 4 || parts.Length > 2)
                        {
                            e.Handled = true;
                        }
                    }
                    catch (Exception) { tb.Text = "0"; }
                }

            }
        }

        private void txtIWaived_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

    }
}
