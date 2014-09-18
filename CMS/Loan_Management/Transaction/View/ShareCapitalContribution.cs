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
    public partial class ShareCapitalContribution : Form
    {
        public double amount = 0.00;
        public ShareCapitalContribution()
        {
            InitializeComponent();
            dataGridShare.ReadOnly = true;
            tbNewBal.ReadOnly = true;
        }

        public void clearAllFields() {

            rbAcctNo.Checked = false;
            tbAccountNo.Clear();
            tbAccountNo.Enabled = false;
            rbAcctName.Checked = false;
            tbAccountName.Clear();
            tbAccountName.Enabled = false;
            tbDepAmt.Clear();
            tbNewBal.Clear();
            btnSave.Enabled = false;
     
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
        
        public void setBtnSaveEventHandler(EventHandler e) {

            btnSave.Click += e;
        }

        public void setBtnClearEventHandler(EventHandler e)
        {

            btnClear.Click += e;
        }

        public void setTbAcctNoEventHandler(EventHandler e) {

            tbAccountNo.TextChanged += e;
        
        }

        public void setTbAcctNameEventHandler(EventHandler e)
        {

            tbAccountName.TextChanged += e;
        }

        public void setTbDepAmtEventHandler(EventHandler e) {

            tbDepAmt.TextChanged += e;
        }


        private void txtCopyPaste(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void shareGrid(DataSet ds)
        {
            CultureInfo ph = new CultureInfo("en-PH");
            this.dataGridShare.DataSource = ds.Tables[0];
            this.dataGridShare.Columns["Balance"].DefaultCellStyle.NullValue = "Php 0.00";
            this.dataGridShare.Columns["Balance"].DefaultCellStyle.Format = "c";
            this.dataGridShare.Columns["Balance"].DefaultCellStyle.FormatProvider = ph;
        }

        public DataGridViewRow getSelected()
        {
            return this.dataGridShare.SelectedRows[0];
        }

        public String getSearch(){
        
            String search = String.Empty;
            if (rbAcctNo.Checked)
                search = tbAccountNo.Text;
            if (rbAcctName.Checked)
                search = tbAccountName.Text;

            return search;
        }

        public bool getSearchType()
        {
            bool check = false;

            if (rbAcctNo.Checked) check = false;
            if (rbAcctName.Checked) check = true;

            return check;

        }

        public double getAmount()
        {
            try
            {
                return double.Parse(this.tbDepAmt.Text);
            }
            catch { return 0.00;  }
        }

        public void setBalance(double balance) {

                CultureInfo ph = new CultureInfo("en-PH");
                this.tbNewBal.Text = balance.ToString("c", ph);
        }

        public void isZeroAmount(bool check) {

            if (check)
            {
                btnSave.Enabled = false;
                tbNewBal.Clear();
            }
            else
                btnSave.Enabled = true;
        }

        private void tbDepAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int length = this.tbDepAmt.Text.Length;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\b' && tbDepAmt.SelectionStart == this.tbDepAmt.Text.Length - 2)
            {
                this.tbDepAmt.SelectionStart = this.tbDepAmt.Text.Length - 3;
            }

            //if (e.KeyChar == '\b' && length % 4 == 0) 
            //{
            //  MessageBox.Show("hi");
            //this.txtMaxWith.SelectionStart = this.txtMaxWith.Text.Length-2;
            //} 

            if (Char.IsDigit(e.KeyChar) && tbDepAmt.Text.Length == 4)
            {
                this.tbDepAmt.SelectionStart = this.tbDepAmt.Text.Length - 3;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                this.tbDepAmt.Text = this.getAmount().ToString();
                this.tbDepAmt.SelectionStart = this.tbDepAmt.Text.Length - 2;
            }
        }

        private void dataGridShare_SelectionChanged(object sender, EventArgs e)
        {
            tbDepAmt.Clear();
            tbNewBal.Clear();
        }

        private void tbDepAmt_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.tbDepAmt.SelectionStart;
            this.tbDepAmt.Text = this.getAmount().ToString("N2", CultureInfo.InvariantCulture);
            if (selectionStart == tbDepAmt.Text.Length - 2)
            {
                this.tbDepAmt.SelectionStart = tbDepAmt.Text.Length - 2;
            }
            else if (selectionStart == tbDepAmt.Text.Length - 1)
            {
                this.tbDepAmt.SelectionStart = tbDepAmt.Text.Length - 1;
            }
            else this.tbDepAmt.SelectionStart = tbDepAmt.Text.Length - 3;
        }
    }
}
