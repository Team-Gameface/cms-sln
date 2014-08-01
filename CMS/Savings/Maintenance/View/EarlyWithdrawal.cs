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

namespace CMS.Savings.Maintenance.View
{
    public partial class EarlyWithdrawal : Form
    {
        public EarlyWithdrawal()
        {
            InitializeComponent();
        }

        public void disableFunction()
        {
            comboAccountType.SelectedIndex = -1;
            comboAccountType.Enabled = false;
            txtPenalty.Clear();
            comboPenalty.SelectedIndex = -1;
            numDuration.Value = 0;
            txtMinBal.Clear();
            checkMaximum.CheckState = CheckState.Unchecked;
            txtMaxBal.Clear();
            Status.CheckState = CheckState.Unchecked;

            txtPenalty.Enabled = false;
            comboPenalty.Enabled = false;
            numDuration.Enabled = false;
            txtMinBal.Enabled = false;
            checkMaximum.Enabled = false;
            txtMaxBal.Enabled = false;

            Status.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnSave.BackColor = Color.Gray;
            this.btnCancel.Enabled = false;
            this.btnCancel.BackColor = Color.Gray;

            this.btnAdd.Enabled = true;
            this.btnAdd.BackColor = Color.Green;
            this.btnEdit.Enabled = true;
            this.btnEdit.BackColor = Color.RoyalBlue;
        }

        public void enableFunction()
        {
            comboAccountType.SelectedIndex = -1;
            comboAccountType.Enabled = true;
            txtPenalty.Clear();
            comboPenalty.SelectedIndex = -1;
            numDuration.Value = 0;
            txtMinBal.Clear();
            checkMaximum.CheckState = CheckState.Unchecked;
            txtMaxBal.Clear();
            Status.CheckState = CheckState.Unchecked;

            txtPenalty.Enabled = true;
            comboPenalty.Enabled = true;
            numDuration.Enabled = true;
            txtMinBal.Enabled = true;
            checkMaximum.Enabled = true;

            Status.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnSave.BackColor = Color.Green;
            this.btnCancel.Enabled = true;
            this.btnCancel.BackColor = Color.WhiteSmoke;

            this.btnAdd.Enabled = false;
            this.btnAdd.BackColor = Color.Gray;
            this.btnEdit.Enabled = false;
            this.btnEdit.BackColor = Color.Gray;
        }

        public void disableType()
        {
            this.comboAccountType.Enabled = false;
        }

        public void initAccountType(DataSet ds)
        {
            this.comboAccountType.DataSource = ds.Tables[0];
            this.comboAccountType.ValueMember = "AccountTypeId";
            this.comboAccountType.DisplayMember = "SavingsTypeName";
        }

        public void setAccountType(String s)
        {
            this.comboAccountType.DataSource = null;
            this.comboAccountType.Items.Add(s);
            this.comboAccountType.SelectedItem = s;
        }

        public int getAccountType()
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

        public void setTextPenalty(String s)
        {
            this.txtPenalty.Text = s;
        }

        public double getTextPenalty()
        {
            return double.Parse(this.txtPenalty.Text.ToString());
        }

        public void setComboPenalty(String s)
        {
            this.comboPenalty.SelectedItem = s;
        }

        public String getComboPenalty()
        {
            if (this.comboPenalty.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return this.comboPenalty.SelectedItem.ToString();
            }
        }

        public void setNumDuration(int i)
        {
            this.numDuration.Value = i;
        }

        public int getNumDuration()
        {
            return int.Parse(this.numDuration.Value.ToString());
        }

        

        public String getComboDuration()
        {
            return "% of terms duration";
        }

        public void setMinimumBalance(String s)
        {
            this.txtMinBal.Text = s;
        }

        public double getMinimumBalance()
        {
           try
            {
            return double.Parse(this.txtMinBal.Text.ToString());
            }
              catch (Exception) { return 0.00; }
        }

        public void setCheckMaxBal(String s)
        {
            this.checkMaximum.CheckState = CheckState.Checked;
            this.txtMaxBal.Text = s;
        }

        public Boolean getCheckMaximumBalance()
        {
            if (this.checkMaximum.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double getMaximumBalance()
        {
            try
            {
                return double.Parse(this.txtMaxBal.Text.ToString());
            }
            catch (Exception) { return 0.00; }
        }

        public void setStatus()
        {
            this.Status.CheckState = CheckState.Checked;
        }

        public Boolean getStatus()
        {
            if (this.Status.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void setBtnCancelEventHandler(EventHandler e)
        {
            this.btnCancel.Click += e;
        }

        public void timeDepositGrid(DataSet ds)
        {
            this.dataTimeDeposit.DataSource = ds.Tables[0];
        }

        public DataGridViewRow getSelected()
        {
            try
            {
                return this.dataTimeDeposit.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void setBtnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }

        public void setBtnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
        }

        private void checkMaximum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMaximum.CheckState == CheckState.Checked)
            {
                txtMaxBal.Enabled = true;
            }
            else
            {
                txtMaxBal.Enabled = false;
            }
        }

        public void setErrorAccountType()
        {
            lblAccountType.ForeColor = Color.Red;
        }

        public void setErrorBalDuration()
        {
            lblBalDuration.ForeColor = Color.Red;
        }

        public void setErrorPenalty()
        {
            lblPenalty.ForeColor = Color.Red;
        }

        public void setErrorMinimum()
        {
            lblMinimum.ForeColor = Color.Red;
        }

        public void setErrorMaximum()
        {
            checkMaximum.ForeColor = Color.Red;
        }

        public void clearError()
        {
            lblAccountType.ForeColor = SystemColors.ControlText;
            lblBalDuration.ForeColor = SystemColors.ControlText;
            lblPenalty.ForeColor = SystemColors.ControlText;
            lblMinimum.ForeColor = SystemColors.ControlText;
            checkMaximum.ForeColor = SystemColors.ControlText;
        }

        public void removeColumns()
        {
            dataTimeDeposit.Columns[0].Visible = false;
            dataTimeDeposit.Columns[1].Visible = false;
            dataTimeDeposit.Columns[7].Visible = false;
            dataTimeDeposit.Columns[8].Visible = false;
            dataTimeDeposit.Columns[9].Visible = false;
        }

        private void txtPenalty_KeyPress(object sender, KeyPressEventArgs e)
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
                    try
                    {
                        if (parts[0].Length > 6 || parts[1].Length > 2 || parts.Length > 2)
                        {
                            e.Handled = true;
                        }
                    }
                    catch (Exception) { tb.Text = "0"; }
                }
            }
        }

        private void txtMinBal_KeyPress(object sender, KeyPressEventArgs e)
        {
            int length = this.txtMinBal.Text.Length;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\b' && txtMinBal.SelectionStart == this.txtMinBal.Text.Length - 2)
            {
                this.txtMinBal.SelectionStart = this.txtMinBal.Text.Length - 3;
            }

            //if (e.KeyChar == '\b' && length % 4 == 0) 
            //{
            //  MessageBox.Show("hi");
            //this.txtMaintaningBalance.SelectionStart = this.txtMaintaningBalance.Text.Length-2;
            //} 

            if (Char.IsDigit(e.KeyChar) && txtMinBal.Text.Length == 4)
            {
                this.txtMinBal.SelectionStart = this.txtMinBal.Text.Length - 3;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                this.txtMinBal.Text = this.getMinimumBalance().ToString();
                this.txtMinBal.SelectionStart = this.txtMinBal.Text.Length - 2;
            }
        }

        private void txtMaxBal_KeyPress(object sender, KeyPressEventArgs e)
        {
            int length = this.txtMaxBal.Text.Length;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\b' && txtMaxBal.SelectionStart == this.txtMaxBal.Text.Length - 2)
            {
                this.txtMaxBal.SelectionStart = this.txtMaxBal.Text.Length - 3;
            }

            //if (e.KeyChar == '\b' && length % 4 == 0) 
            //{
            //  MessageBox.Show("hi");
            //this.txtMaintaningBalance.SelectionStart = this.txtMaintaningBalance.Text.Length-2;
            //} 

            if (Char.IsDigit(e.KeyChar) && txtMaxBal.Text.Length == 4)
            {
                this.txtMaxBal.SelectionStart = this.txtMaxBal.Text.Length - 3;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                this.txtMaxBal.Text = this.getMaximumBalance().ToString();
                this.txtMaxBal.SelectionStart = this.txtMaxBal.Text.Length - 2;
            }
        }


        private void txtPenalty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtMinBal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtMaxBal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
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

        private void dataTimeDeposit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataTimeDeposit.Rows;
            foreach (DataGridViewRow row in rowCollection)
            {
                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
                    row.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
                }
                else
                {
                    row.DefaultCellStyle = null;
                }
            }
        }

        public void checkArchived_CheckStateChanged(EventHandler e)
        {
            this.checkArchived.Click += e;
        }

        public bool checkArchivedState()
        {
            if (this.checkArchived.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataGridViewRowCollection getAllRows()
        {
            return this.dataTimeDeposit.Rows;
        }

        public void setArchivedColor(int i)
        {
            dataTimeDeposit.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            dataTimeDeposit.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataTimeDeposit.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        public void txtSearch_TextChanged(EventHandler e)
        {
            this.txtSearch.TextChanged += e;
        }

        public String getSearch()
        {
            return this.txtSearch.Text;
        }

        private void txtMinBal_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtMinBal.SelectionStart;
            this.txtMinBal.Text = this.getMinimumBalance().ToString("N2", CultureInfo.InvariantCulture);
            if (selectionStart == txtMinBal.Text.Length - 2)
            {
                this.txtMinBal.SelectionStart = txtMinBal.Text.Length - 2;
            }
            else if (selectionStart == txtMinBal.Text.Length - 1)
            {
                this.txtMinBal.SelectionStart = txtMinBal.Text.Length - 1;
            }
            else this.txtMinBal.SelectionStart = txtMinBal.Text.Length - 3;
        }

        private void txtMaxBal_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtMaxBal.SelectionStart;
            this.txtMaxBal.Text = this.getMaximumBalance().ToString("N2", CultureInfo.InvariantCulture);
            if (selectionStart == txtMaxBal.Text.Length - 2)
            {
                this.txtMaxBal.SelectionStart = txtMaxBal.Text.Length - 2;
            }
            else if (selectionStart == txtMaxBal.Text.Length - 1)
            {
                this.txtMaxBal.SelectionStart = txtMaxBal.Text.Length - 1;
            }
            else this.txtMaxBal.SelectionStart = txtMaxBal.Text.Length - 3;
        }
    }
}
