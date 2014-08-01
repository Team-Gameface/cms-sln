using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.View
{
    public partial class TimeDepositApplication : Form
    {
        public TimeDepositApplication()
        {
            InitializeComponent();
            this.comboDuration.SelectedIndex = 0;
            this.radioAccountNo.Checked = true;
        }

        public void initAccountType(DataSet ds)
        {
            this.comboAccountType.DataSource = ds.Tables[0];
            this.comboAccountType.DisplayMember = "SavingsTypeName";
            this.comboAccountType.ValueMember = "AccountTypeId";
        }

        private void radioAccountNo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioAccountNo.Checked)
            {
                this.txtAccountNo.Clear();
                this.txtMemberName.Clear();
                this.txtAccountNo.Enabled = true;
                this.txtMemberName.Enabled = false;
            }
        }

        private void radioMemberName_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioMemberName.Checked)
            {
                this.txtAccountNo.Clear();
                this.txtMemberName.Clear();
                this.txtAccountNo.Enabled = false;
                this.txtMemberName.Enabled = true;
            }
        }

        public void setDataMember(DataSet ds)
        {
            this.dataMember.DataSource = ds.Tables[0];
        }

        public int getComboAccountType()
        {
            if (this.comboAccountType.SelectedIndex == -1)
            {
                return 0;
            }
            else
            {
                return int.Parse(this.comboAccountType.SelectedValue.ToString());
            }
        }

        public DataGridViewRow getSelected()
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
            return double.Parse(this.txtDeposit.Text);
        }

        public int getNumDuration()
        {
            return int.Parse(this.numDuration.Value.ToString());
        }

        public String getComboDuration()
        {
            return this.comboDuration.SelectedItem.ToString();
        }

        public String getMaturityDate()
        {
            return this.dateMaturity.Value.ToShortDateString();
        }

        public void setMaturityDate(DateTime date)
        {
            this.dateMaturity.Value = date;
        }

        public String getTextAccountNo()
        {
            return this.txtAccountNo.Text;
        }

        public String getTextMemberName()
        {
            return this.txtMemberName.Text;
        }

        public void txtAccountNo_TextChanged(EventHandler e)
        {
            this.txtAccountNo.TextChanged += e;
        }

        public void txtMemberName_TextChanged(EventHandler e)
        {
            this.txtMemberName.TextChanged += e;
        }

        public void numDuration_ValueChanged(EventHandler e)
        {
            this.numDuration.ValueChanged += e;
        }

        public void comboAccountType_SelectedIndexChanged(EventHandler e)
        {
            this.comboAccountType.SelectedIndexChanged += e;
        }

        public void comboDuration_SelectedIndexChanged(EventHandler e)
        {
            this.comboDuration.SelectedIndexChanged += e;
        }

        public void setBtnClearEventHandler(EventHandler e)
        {
            this.btnClear.Click += e;
        }

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        private void txtDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
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
                if (parts.Length > 1 || tb.TextLength > 5)
                {
                    if (parts[0].Length > 6 || parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void numDuration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (numDuration.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void numDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void setErrorAccountType()
        {
            this.lblAccountType.ForeColor = Color.Red;
        }

        public void setErrorAmount()
        {
            this.lblDeposit.ForeColor = Color.Red;
        }

        public void setErrorDuration()
        {
            this.lblDuration.ForeColor = Color.Red;
        }

        public void clearErrors()
        {
            this.lblAccountType.ForeColor = SystemColors.ControlText;
            this.lblDeposit.ForeColor = SystemColors.ControlText;
            this.lblDuration.ForeColor = SystemColors.ControlText;
        }

        public void reset()
        {
            this.radioAccountNo.Checked = true;
            this.txtAccountNo.Clear();
            this.txtMemberName.Clear();
            this.txtDeposit.Clear();
            this.numDuration.Value = 0;
            this.comboDuration.SelectedIndex = 0;
            this.comboAccountType.SelectedIndex = 0;
            this.dateMaturity.Value = DateTime.Today;
        }
    }
}
