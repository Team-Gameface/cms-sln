using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Maintenance.View
{
    public partial class SavingsAccountType : Form
    {
        public SavingsAccountType()
        {
            InitializeComponent();
        }

        public void disableFunction()
        {
            txtName.Clear();
            txtInitDeposit.Clear();
            txtMaxWith.Clear();
            numAccountHolder.Value = 0;
            checkMaintainingBalance.CheckState = CheckState.Unchecked;
            checkInterestRates.CheckState = CheckState.Unchecked;
            checkDormancy.CheckState = CheckState.Unchecked;
            checkTimeDeposit.CheckState = CheckState.Unchecked;
            checkStatus.CheckState = CheckState.Unchecked;

            txtName.Enabled = false;
            txtInitDeposit.Enabled = false;
            txtMaxWith.Enabled = false;
            numAccountHolder.Enabled = false;
            checkMaintainingBalance.Enabled = false;
            checkInterestRates.Enabled = false;
            checkDormancy.Enabled = false;
            checkTimeDeposit.Enabled = false;
            checkStatus.Enabled = false;
            checkedMemberTypes.Items.Clear();

            disableDormancy();
            disableMaintainingBalance();

            btnRetrieve.Visible = false;
            this.btnSave.Enabled = false;
            this.btnSave.BackColor = Color.Gray;
            this.btnCancel.Enabled = false;
            this.btnCancel.BackColor = Color.Gray;

            this.btnAdd.Enabled = true;
            this.btnAdd.BackColor = Color.Green;
            this.btnEdit.Enabled = true;
            this.btnEdit.BackColor = Color.RoyalBlue;
            this.btnDelete.Enabled = true;
            this.btnDelete.BackColor = Color.Firebrick;
        }

        public void enableFunction()
        {
            txtName.Clear();
            txtInitDeposit.Clear();
            numAccountHolder.Value = 0;
            checkMaintainingBalance.CheckState = CheckState.Unchecked;
            checkInterestRates.CheckState = CheckState.Unchecked;
            checkDormancy.CheckState = CheckState.Unchecked;
            checkTimeDeposit.CheckState = CheckState.Unchecked;
            checkStatus.CheckState = CheckState.Unchecked;

            txtName.Enabled = true;
            txtInitDeposit.Enabled = true;
            txtMaxWith.Enabled = true;
            numAccountHolder.Enabled = true;
            checkMaintainingBalance.Enabled = true;
            checkInterestRates.Enabled = true;
            checkDormancy.Enabled = true;
            checkTimeDeposit.Enabled = true;
            checkStatus.Enabled = true;
            
            disableDormancy();
            disableMaintainingBalance();

            this.btnSave.Enabled = true;
            this.btnSave.BackColor = Color.Green;
            this.btnCancel.Enabled = true;
            this.btnCancel.BackColor = Color.WhiteSmoke;

            this.btnAdd.Enabled = false;
            this.btnAdd.BackColor = Color.Gray;
            this.btnEdit.Enabled = false;
            this.btnEdit.BackColor = Color.Gray;
            this.btnDelete.Enabled = false;
            this.btnDelete.BackColor = Color.Gray;
        }

        public void enableMaintainingBalance()
        {
            txtMaintaningBalance.Clear();
            txtMBalCharge.Clear();
            comboMBalCharge.SelectedIndex = 0;
            numMBalChargeDuration.Value = 0;
            comboMBalChargeDuration.SelectedIndex = 0;

            txtMaintaningBalance.Enabled = true;
            txtMBalCharge.Enabled = true;
            comboMBalCharge.Enabled = true;
            numMBalChargeDuration.Enabled = true;
            comboMBalChargeDuration.Enabled = true;
        }

        public void disableMaintainingBalance()
        {
            txtMaintaningBalance.Clear();
            txtMBalCharge.Clear();
            comboMBalCharge.SelectedIndex = -1;
            numMBalChargeDuration.Value = 0;
            comboMBalChargeDuration.SelectedIndex = -1;

            txtMaintaningBalance.Enabled = false;
            txtMBalCharge.Enabled = false;
            comboMBalCharge.Enabled = false;
            numMBalChargeDuration.Enabled = false;
            comboMBalChargeDuration.Enabled = false;
        }

        public void enableDormancy()
        {
            numDormancy.Value = 0;
            comboDormancy.SelectedIndex = 0;
            txtDormancyPenalty.Clear();
            comboDormancyPenalty.SelectedIndex = 0;
            numDormancyChargeDuration.Value = 0;
            comboDormancyChargeDuration.SelectedIndex = 0;

            numDormancy.Enabled = true;
            comboDormancy.Enabled = true;
            txtDormancyPenalty.Enabled = true;
            comboDormancyPenalty.Enabled = true;
            numDormancyChargeDuration.Enabled = true;
            comboDormancyChargeDuration.Enabled = true;
        }

        public void disableDormancy()
        {
            numDormancy.Value = 0;
            comboDormancy.SelectedIndex = -1;
            txtDormancyPenalty.Clear();
            comboDormancyPenalty.SelectedIndex = -1;
            numDormancyChargeDuration.Value = 0;
            comboDormancyChargeDuration.SelectedIndex = -1;

            numDormancy.Enabled = false;
            comboDormancy.Enabled = false;
            txtDormancyPenalty.Enabled = false;
            comboDormancyPenalty.Enabled = false;
            numDormancyChargeDuration.Enabled = false;
            comboDormancyChargeDuration.Enabled = false;
        }

        public void setTextName(String s)
        {
            this.txtName.Text = s;
        }

        public String getTextName()
        {
            return this.txtName.Text.Trim();
        }

        public void setTextInitDeposit(String s)
        {
            this.txtInitDeposit.Text = s;
        }

        public double getTextInitDeposit()
        {
            try
            {
                return double.Parse(this.txtInitDeposit.Text);
            }
            catch (Exception) { return 0.00; }
        }

        public void setAccountHolder(int i)
        {
            this.numAccountHolder.Value = i;
        }

        public int getAccountHolder()
        {
            return int.Parse(this.numAccountHolder.Value.ToString());
        }

        public void setMaintainingBalance()
        {
            this.checkMaintainingBalance.CheckState = CheckState.Checked;
        }

        public Boolean getMaintainingBalance()
        {
            if (this.checkMaintainingBalance.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setMaximumWithdrawal(String s)
        {
            this.txtMaxWith.Text = s;
        }

        public double getMaximumWithdrawal()
        {
            try
            {
                return double.Parse(this.txtMaxWith.Text);
            }
            catch (Exception) {
                return 0.00;
            }
        }

        public void setDormancy()
        {
            this.checkDormancy.CheckState = CheckState.Checked;
        }

        public Boolean getDormancy()
        {
            if (this.checkDormancy.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setInterestRates()
        {
            this.checkInterestRates.CheckState = CheckState.Checked;
        }

        public Boolean getInterestRates()
        {
            if (this.checkInterestRates.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setTimeDeposit()
        {
            this.checkTimeDeposit.CheckState = CheckState.Checked;
        }

        public Boolean getTimeDeposit()
        {
            if (this.checkTimeDeposit.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setStatus()
        {
            this.checkStatus.CheckState = CheckState.Checked;
        }

        public Boolean getStatus()
        {
            if (this.checkStatus.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //MAINTAINING BALANCE FIELDS

        public void setMaintainingBalanceAmount(String s)
        {
            this.txtMaintaningBalance.Text = s;
        }

        public double getMaintainingBalanceAmount()
        {
            try
            {
                return double.Parse(this.txtMaintaningBalance.Text);
            }
            catch(Exception)
            {
                return 0;
            }
        }

        public void setMaintainingBalancePenaltyAmount(String s)
        {
            this.txtMBalCharge.Text = s;
        }

        public double getMaintainingBalancePenaltyAmount()
        {
            try
            {
                return double.Parse(this.txtMBalCharge.Text);
            }
            catch (Exception) { return 0.00; }
        }

        public void setComboMaintainingBalanceCharge(String s)
        {
            this.comboMBalCharge.SelectedItem = s;
        }

        public String getComboMaintainingBalancePenalty()
        {
            if (this.comboMBalCharge.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return this.comboMBalCharge.SelectedItem.ToString();
            }
        }

        public void setNumMaintainingBalanceDuration(int i)
        {
            this.numMBalChargeDuration.Value = i;
        }

        public int getNumMaintainingBalanceDuration()
        {
            return int.Parse(this.numMBalChargeDuration.Value.ToString());
        }

        public void setComboMaintainingBalanceDuration(String s)
        {
            this.comboMBalChargeDuration.SelectedItem = s;
        }

        public String getComboMaintainingBalanceDuration()
        {
            if (this.comboMBalChargeDuration.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return comboMBalChargeDuration.SelectedItem.ToString();
            }
        }

        //DORMANCY FIELDS
        public void setNumDormancy(int i)
        {
            this.numDormancy.Value = i;
        }

        public int getNumDormancy()
        {
            return int.Parse(this.numDormancy.Value.ToString());
        }

        public void setComboDormancy(String s)
        {
            this.comboDormancy.SelectedItem = s;
        }

        public String getComboDormancy()
        {
            if (this.comboDormancy.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return this.comboDormancy.SelectedItem.ToString();
            }
        }

        public void setDormancyPenalty(String s)
        {
            this.txtDormancyPenalty.Text = s;
        }

        public double getDormancyPenalty()
        {
            try
            {
                return double.Parse(this.txtDormancyPenalty.Text);
            }
            catch (Exception) { return 0.00; }
        }

        public void setComboDormancyPenalty(String s)
        {
            this.comboDormancyPenalty.SelectedItem = s;
        }

        public String getComboDormancyPenalty()
        {
            if (this.comboDormancyPenalty.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return this.comboDormancyPenalty.SelectedItem.ToString();
            }
        }

        public void setNumDormancyChargeDuration(int i)
        {
            this.numDormancyChargeDuration.Value = i;
        }

        public int getNumDormancyChargeDuration()
        {
            return int.Parse(this.numDormancyChargeDuration.Value.ToString());
        }

        public void setComboDormancyChargeDuration(String s)
        {
            this.comboDormancyChargeDuration.SelectedItem = s;
        }

        public String getComboDormancyChargeDuration()
        {
            if (this.comboDormancyChargeDuration.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return this.comboDormancyChargeDuration.SelectedItem.ToString();
            }
        }

        //MEMBER TYPES CHECKLIST
        public void populateMemberTypes(Dictionary<int, string> memberTypes)
        {
            foreach (String s in memberTypes.Values)
            {
                checkedMemberTypes.Items.Add(s);
            }
        }

        public void toggleCheckedTypes(ArrayList activeTypes)
        {

            foreach (String s in activeTypes)
            {
                if (checkedMemberTypes.Items.Contains(s))
                {
                    int i = checkedMemberTypes.Items.IndexOf(s);
                    checkedMemberTypes.SetItemChecked(i, true);
                }
            }
        }

        public CheckedListBox.CheckedItemCollection getCheckedTypes()
        {
            return checkedMemberTypes.CheckedItems;
        }

        public void accountTypeGrid(DataSet ds)
        {
            this.dataAccountType.DataSource = ds.Tables[0];
        }

        public DataGridViewRow getSelected()
        {
            try
            {
                return this.dataAccountType.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void btnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void btnCancelEventHandler(EventHandler e)
        {
            this.btnCancel.Click += e;
        }

        public void btnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }

        public void btnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
        }

        public void btnDeleteEventHandler(EventHandler e)
        {
            this.btnDelete.Click += e;
        }

        public void btnRetrieveEventHandler(EventHandler e)
        {
            this.btnRetrieve.Click += e;
        }

        private void txtInitDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            int length = this.txtInitDeposit.Text.Length;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\b' && txtInitDeposit.SelectionStart == this.txtInitDeposit.Text.Length - 2)
            {
                this.txtInitDeposit.SelectionStart = this.txtInitDeposit.Text.Length - 3;
            }

            //if (e.KeyChar == '\b' && length % 4 == 0) 
            //{
            //  MessageBox.Show("hi");
            //this.txtInitDeposit.SelectionStart = this.txtInitDeposit.Text.Length-2;
            //} 

            if (Char.IsDigit(e.KeyChar) && txtInitDeposit.Text.Length == 4)
            {
                this.txtInitDeposit.SelectionStart = this.txtInitDeposit.Text.Length - 3;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                this.txtInitDeposit.Text = this.getTextInitDeposit().ToString();
                this.txtInitDeposit.SelectionStart = this.txtInitDeposit.Text.Length - 2;
            }
            
        }

        private void txtInitDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void setErrorName()
        {
            lblName.ForeColor = Color.Red;
        }

        public void setErrorInitDeposit()
        {
            lblInitDeposit.ForeColor = Color.Red;
        }

        public void setErrorMaxWith()
        {
            lblMaxWith.ForeColor = Color.Red;
        }

        public void setErrorAccountHolder()
        {
            lblAccountHolder.ForeColor = Color.Red;
        }

        public void setErrorMainBalAmount()
        {
            lblMaintainingBalance.ForeColor = Color.Red;
        }

        public void setErrorPenaltyMainBal()
        {
            lblPenalty.ForeColor = Color.Red;
        }

        public void setErrorScheduleMainBal()
        {
            lblCharge.ForeColor = Color.Red;
        }

        public void setErrorDormancy()
        {
            lblDormancy.ForeColor = Color.Red;
        }

        public void setErrorPenaltyDormancy()
        {
            lblPenaltyDormancy.ForeColor = Color.Red;
        }

        public void setErrorScheduleDormancy()
        {
            lblEvery.ForeColor = Color.Red;
        }

        public void clearError()
        {
            lblName.ForeColor = SystemColors.ControlText;
            lblInitDeposit.ForeColor = SystemColors.ControlText;
            lblAccountHolder.ForeColor = SystemColors.ControlText;
            lblMaxWith.ForeColor = SystemColors.ControlText;
            lblMaintainingBalance.ForeColor = SystemColors.ControlText;
            lblPenalty.ForeColor = SystemColors.ControlText;
            lblCharge.ForeColor = SystemColors.ControlText;
            lblDormancy.ForeColor = SystemColors.ControlText;
            lblPenaltyDormancy.ForeColor = SystemColors.ControlText;
            lblEvery.ForeColor = SystemColors.ControlText;
        }

        public void removeColumns()
        {
            dataAccountType.Columns[0].Visible = false;
            dataAccountType.Columns[5].Visible = false;
            dataAccountType.Columns[6].Visible = false;
            dataAccountType.Columns[7].Visible = false;
            dataAccountType.Columns[8].Visible = false;
            dataAccountType.Columns[9].Visible = false;
            dataAccountType.Columns[10].Visible = false;
            dataAccountType.Columns[11].Visible = false;
        }

        public DataGridViewRowCollection getAllRows()
        {
            return this.dataAccountType.Rows;
        }

        public void setArchivedColor(int i)
        {
            dataAccountType.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            dataAccountType.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataAccountType.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        public void showRetrieve()
        {
            this.btnRetrieve.Visible = true;
        }

        public void hideRetrieve()
        {
            this.btnRetrieve.Visible = false;
        }
        
        private void numAccountHolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (numAccountHolder.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void numAccountHolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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

        private void dataAccountType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataAccountType.Rows;
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

        private void checkTimeDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTimeDeposit.Checked)
            {
                this.numAccountHolder.Value = 1;
                this.txtMaxWith.Text = "0";
                this.numAccountHolder.Enabled = false;
                this.txtMaxWith.Enabled = false;
                this.checkMaintainingBalance.CheckState = CheckState.Unchecked;
                this.checkMaintainingBalance.Enabled = false;
                this.checkDormancy.CheckState = CheckState.Unchecked;
                this.checkDormancy.Enabled = false;
            }
            else
            {
                this.numAccountHolder.Value = 0;
                this.txtMaxWith.Text = "0";
                this.numAccountHolder.Enabled = true;
                this.txtMaxWith.Enabled = true;
                this.checkMaintainingBalance.CheckState = CheckState.Unchecked;
                this.checkMaintainingBalance.Enabled = true;
                this.checkDormancy.CheckState = CheckState.Unchecked;
                this.checkDormancy.Enabled = true;
            }
        }

        private void checkMaintainingBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMaintainingBalance.CheckState == CheckState.Checked)
            {
                enableMaintainingBalance();
            }
            else
            {
                disableMaintainingBalance();
            }
        }

        private void checkDormancy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDormancy.CheckState == CheckState.Checked)
            {
                enableDormancy();
            }
            else
            {
                disableDormancy();
            }
        }

        private void txtInitDeposit_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtInitDeposit.SelectionStart;
            this.txtInitDeposit.Text = this.getTextInitDeposit().ToString("N2", CultureInfo.InvariantCulture);
            if (selectionStart == txtInitDeposit.Text.Length - 2)
            {
                this.txtInitDeposit.SelectionStart = txtInitDeposit.Text.Length - 2;
            }
            else if (selectionStart == txtInitDeposit.Text.Length - 1)
            {
                this.txtInitDeposit.SelectionStart = txtInitDeposit.Text.Length - 1;
            }
            else this.txtInitDeposit.SelectionStart = txtInitDeposit.Text.Length - 3;
        }

        private void txtMaxWith_KeyPress(object sender, KeyPressEventArgs e)
        {
            int length = this.txtMaxWith.Text.Length;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\b' && txtMaxWith.SelectionStart == this.txtMaxWith.Text.Length - 2)
            {
                this.txtMaxWith.SelectionStart = this.txtMaxWith.Text.Length - 3;
            }

            //if (e.KeyChar == '\b' && length % 4 == 0) 
            //{
            //  MessageBox.Show("hi");
            //this.txtMaxWith.SelectionStart = this.txtMaxWith.Text.Length-2;
            //} 

            if (Char.IsDigit(e.KeyChar) && txtMaxWith.Text.Length == 4)
            {
                this.txtMaxWith.SelectionStart = this.txtMaxWith.Text.Length - 3;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                this.txtMaxWith.Text = this.getMaximumWithdrawal().ToString();
                this.txtMaxWith.SelectionStart = this.txtMaxWith.Text.Length - 2;
            }
        }

        private void txtMaxWith_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtMaxWith.SelectionStart;
            this.txtMaxWith.Text = this.getMaximumWithdrawal().ToString("N2", CultureInfo.InvariantCulture);
            if (selectionStart == txtMaxWith.Text.Length - 2)
            {
                this.txtMaxWith.SelectionStart = txtMaxWith.Text.Length - 2;
            }
            else if (selectionStart == txtMaxWith.Text.Length - 1)
            {
                this.txtMaxWith.SelectionStart = txtMaxWith.Text.Length - 1;
            }
            else this.txtMaxWith.SelectionStart = txtMaxWith.Text.Length - 3;
        }

        private void txtMaintaningBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            int length = this.txtMaintaningBalance.Text.Length;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\b' && txtMaintaningBalance.SelectionStart == this.txtMaintaningBalance.Text.Length - 2)
            {
                this.txtMaintaningBalance.SelectionStart = this.txtMaintaningBalance.Text.Length - 3;
            }

            //if (e.KeyChar == '\b' && length % 4 == 0) 
            //{
            //  MessageBox.Show("hi");
            //this.txtMaintaningBalance.SelectionStart = this.txtMaintaningBalance.Text.Length-2;
            //} 

            if (Char.IsDigit(e.KeyChar) && txtMaintaningBalance.Text.Length == 4)
            {
                this.txtMaintaningBalance.SelectionStart = this.txtMaintaningBalance.Text.Length - 3;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                this.txtMaintaningBalance.Text = this.getMaintainingBalanceAmount().ToString();
                this.txtMaintaningBalance.SelectionStart = this.txtMaxWith.Text.Length - 2;
            }
        }

        private void txtMaintaningBalance_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtMaintaningBalance.SelectionStart;
            this.txtMaintaningBalance.Text = this.getMaintainingBalanceAmount().ToString("N2", CultureInfo.InvariantCulture);
            if (selectionStart == txtMaintaningBalance.Text.Length - 2)
            {
                this.txtMaintaningBalance.SelectionStart = txtMaintaningBalance.Text.Length - 2;
            }
            else if (selectionStart == txtMaintaningBalance.Text.Length - 1)
            {
                this.txtMaintaningBalance.SelectionStart = txtMaintaningBalance.Text.Length - 1;
            }
            else this.txtMaintaningBalance.SelectionStart = txtMaintaningBalance.Text.Length - 3;
        }


    }
}
