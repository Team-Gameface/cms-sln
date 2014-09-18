using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Reports.View
{
    public partial class LoanStatus : Form
    {
        public LoanStatus()
        {
            InitializeComponent();
            tbAccountName.Enabled = false;
            btnCollaterals.Enabled = false;
        }

        public void setDataGridLoanCellClickEventHandler(DataGridViewCellEventHandler e)
        {

            dataGridLoan.CellClick += e;
        
        }

        public void enableCollaterals() {

            btnCollaterals.Enabled = true;

        
        }

        public void setTxtAccountNoTextChangedEventHandler(EventHandler e) {

            tbAccountNo.TextChanged += e;
        
        }


        public void setTxtAccountNameTextChangedEventHandler(EventHandler e)
        {
            tbAccountName.TextChanged += e;
        }

        public void setBtnCollateralEventHandler(EventHandler e)
        {

            btnCollaterals.Click += e;

        }

        public void loanGrid(DataSet ds)
        {
            this.dataGridLoan.DataSource = ds.Tables[0];
            dataGridLoan.Columns[0].Visible = false;
        }

        public DataGridViewRow getSelected()
        {
            return this.dataGridLoan.SelectedRows[0];
        }

        public void paymentGrid(DataSet ds)
        {
            this.dataGridPayment.DataSource = ds.Tables[0];
        }

        public String getAccountNo() {

            return tbAccountNo.Text;
        
        }

        public String getAccountName()
        {

            return tbAccountName.Text;

        }



        public void setDateGranted(String s) {


            lblGranted.Text = s;
        }

        public void setMaturity(String s)
        {


            lblMaturity.Text = s;
        }

        public void setLoanAmount(String s)
        {


            lblAmt.Text = s;
        }

        public void setAmortizations(String s)
        {


            lblAmort.Text = s;
        }

        public void setStatus(String s)
        {


            lblStatus.Text = s;
        }

        public void setBalance(String s)
        {
            lblBalance.Text = s;
        }

        private void rbAcctNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAcctNo.Checked)
                tbAccountNo.Enabled = true;
            else
            {
                tbAccountNo.Clear();
                tbAccountNo.Enabled = false;
            
            }
        }

        private void rbAcctName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAcctName.Checked)
                tbAccountName.Enabled = true;
            else
            {
                tbAccountName.Clear();
                tbAccountName.Enabled = false;

            }
        }


        
    }
}
