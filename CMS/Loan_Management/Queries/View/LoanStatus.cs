using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CMS.Loan_Management.Queries.View
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
            dataGridLoan.Columns[1].Visible = false;
        }

        public DataGridViewRow getSelected()
        {
            return this.dataGridLoan.SelectedRows[0];
        }

        public void paymentGrid(DataSet ds)
        {
            this.dataGridPayment.DataSource = ds.Tables[0];
            this.dataGridPayment.Columns[2].DefaultCellStyle.Format = "c";
            this.dataGridPayment.Columns[3].DefaultCellStyle.Format = "c";
            this.dataGridPayment.Columns[4].DefaultCellStyle.Format = "c";
            this.dataGridPayment.Columns[5].DefaultCellStyle.Format = "c";
            this.dataGridPayment.Columns[6].DefaultCellStyle.Format = "c";
            this.dataGridPayment.Columns[7].DefaultCellStyle.Format = "c";
            CultureInfo ph = new CultureInfo("en-PH");
            this.dataGridPayment.Columns[2].DefaultCellStyle.FormatProvider = ph;
            this.dataGridPayment.Columns[3].DefaultCellStyle.FormatProvider = ph;
            this.dataGridPayment.Columns[4].DefaultCellStyle.FormatProvider = ph;
            this.dataGridPayment.Columns[5].DefaultCellStyle.FormatProvider = ph;
            this.dataGridPayment.Columns[6].DefaultCellStyle.FormatProvider = ph;
            this.dataGridPayment.Columns[7].DefaultCellStyle.FormatProvider = ph;
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

        public void setLoanAmount(double d)
        {
            CultureInfo ph = new CultureInfo("en-PH");
            lblAmt.Text = d.ToString("c",ph);
        }

        public void setAmortizations(String s)
        {


            lblAmort.Text = s;
        }

        public void setStatus(String s)
        {


            lblStatus.Text = s;
        }

        public void setBalance(double d)
        {
            CultureInfo ph = new CultureInfo("en-PH");
            lblBalance.Text = d.ToString("c", ph);
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
