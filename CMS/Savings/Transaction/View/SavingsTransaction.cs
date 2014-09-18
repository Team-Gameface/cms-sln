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

namespace CMS.Savings.Transaction.View
{
    public partial class SavingsTransaction : Form
    {
        public SavingsTransaction()
        {
            InitializeComponent();
            comboTransaction.SelectedIndex = 0;
        }

        private void comboTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboTransaction.SelectedItem.ToString() == "Deposit")
            {
                this.txtAmount.Clear();
                this.txtRepresentative.Clear();
                this.checkRepresentative.Enabled = false;
                this.checkRepresentative.CheckState = CheckState.Unchecked;
                this.txtRepresentative.Enabled = false;
            }
            else if (this.comboTransaction.SelectedItem.ToString() == "Withdraw")
            {

                this.txtAmount.Clear();
                this.txtRepresentative.Clear();
                this.checkRepresentative.CheckState = CheckState.Unchecked;
                this.checkRepresentative.Enabled = true;
                this.txtRepresentative.Enabled = false;
            }
        }

        private void checkRepresentative_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkRepresentative.CheckState == CheckState.Checked)
            {
                this.txtRepresentative.Clear();
                this.txtRepresentative.Enabled = true;
            }
            else if (this.checkRepresentative.CheckState == CheckState.Unchecked)
            {
                this.txtRepresentative.Clear();
                this.txtRepresentative.Enabled = false;
            }
        }

        public String getComboTransaction()
        {
            if (this.comboTransaction.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return this.comboTransaction.SelectedItem.ToString();
            }

        }
        public String getAccountNo()
        {
            return this.txtAccountNo.Text;
        }

        public void setDataMember(DataSet ds)
        {
            this.dataMember.DataSource = ds.Tables[0];
            dataMember.Columns[3].Visible = false;
            dataMember.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataMember.Columns[4].DefaultCellStyle.Format = "c";
            CultureInfo ph = new CultureInfo("en-PH");
            dataMember.Columns[4].DefaultCellStyle.FormatProvider = ph;
        }

        public DataGridViewRow getSelectedMember()
        {
            try
            {
                return this.dataMember.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public double getAmount()
        {
            try
            {
                return double.Parse(this.txtAmount.Text);
            }
            catch (Exception) { return 0.00; }
        }

        public Boolean getCheckRepresentative()
        {
            if (this.checkRepresentative.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String getTextRepresentative()
        {
            return this.txtRepresentative.Text.Trim();
        }

        public void txtAccountNo_TextChanged(EventHandler e)
        {
            this.txtAccountNo.TextChanged += e;
        }
        
        public void setSavingsAccountNo(String s)
        {
            this.txtSavingsAccountNo.Text = s;
        }

        public String getSavingsAccountNo()
        {
            return this.txtSavingsAccountNo.Text;
        }

        public void setAccountBalance(String s)
        {
            double amount = 0;
            try
            {
                amount = double.Parse(s);
            }
            catch (Exception) { }
            CultureInfo ph = new CultureInfo("en-PH");
            this.txtAccountBalance.Text = amount.ToString("c", ph);
        }

        public double getAccountBalance()
        {
            return double.Parse(this.txtAccountBalance.Text.ToString());
        }

        public void setDataAccountHolder(DataSet ds)
        {
            this.dataAccountHolder.DataSource = ds.Tables[0];
        }

        public DataGridViewRow getSelectedAccountHolder()
        {
            try
            {
                return this.dataAccountHolder.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void setBtnViewEventHandler(EventHandler e)
        {
            this.btnView.Click += e;
        }

        public void setBtnPassbookEventHandler(EventHandler e)
        {
            this.btnPassbook.Click += e;
        }

        public void setBtnClearEventHandler(EventHandler e)
        {
            this.btnClear.Click += e;
        }

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void dataMember_CellContentClick(DataGridViewCellEventHandler e)
        {
            this.dataMember.CellClick += e;
        }

        public void enableDetails()
        {
            this.dataAccountHolder.Enabled = true;
            this.btnView.Enabled = true;
            this.btnPassbook.Enabled = true;
            this.btnSave.Enabled = true;
            this.txtAmount.Enabled = true;
        }

        public void disableDetails()
        {
            this.dataAccountHolder.Enabled = false;
            this.btnView.Enabled = false;
            this.btnPassbook.Enabled = false;
            this.btnSave.Enabled = false;
            this.txtAmount.Enabled = false;
        }

        public void clearDetails()
        {
            this.dataAccountHolder.DataSource = null;
            this.txtSavingsAccountNo.Clear();
            this.txtAmount.Clear();
        }

        public void clearAll()
        {
            clearDetails();
            disableDetails();
            this.txtAccountNo.Clear();
            this.comboTransaction.SelectedIndex = 0;
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            int length = this.txtAmount.Text.Length;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\b' && txtAmount.SelectionStart == this.txtAmount.Text.Length - 2)
            {
                this.txtAmount.SelectionStart = this.txtAmount.Text.Length - 3;
            }

            //if (e.KeyChar == '\b' && length % 4 == 0) 
            //{
            //  MessageBox.Show("hi");
            //this.txtMaxWith.SelectionStart = this.txtMaxWith.Text.Length-2;
            //} 

            if (Char.IsDigit(e.KeyChar) && txtAmount.Text.Length == 4)
            {
                this.txtAmount.SelectionStart = this.txtAmount.Text.Length - 3;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                this.txtAmount.Text = this.getAmount().ToString();
                this.txtAmount.SelectionStart = this.txtAmount.Text.Length - 2;
            }
        }

        public void setErrorMode()
        {
            this.lblTransaction.ForeColor = Color.Red;
        }

        public void setErrorAmount()
        {
            this.lblAmount.ForeColor = Color.Red;
        }

        public void setErrorRepresentative()
        {
            this.checkRepresentative.ForeColor = Color.Red;
        }

        public void clearErrors()
        {
            this.lblAmount.ForeColor = SystemColors.ControlText;
            this.checkRepresentative.ForeColor = SystemColors.ControlText;
            this.lblTransaction.ForeColor = SystemColors.ControlText;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtAmount.SelectionStart;
            this.txtAmount.Text = this.getAmount().ToString("N2", CultureInfo.InvariantCulture);
            if (selectionStart == txtAmount.Text.Length - 2)
            {
                this.txtAmount.SelectionStart = txtAmount.Text.Length - 2;
            }
            else if (selectionStart == txtAmount.Text.Length - 1)
            {
                this.txtAmount.SelectionStart = txtAmount.Text.Length - 1;
            }
            else this.txtAmount.SelectionStart = txtAmount.Text.Length - 3;
        }
    }
}
