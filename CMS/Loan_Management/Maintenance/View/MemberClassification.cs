using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Maintenance.View
{
    public partial class MemberClassification : Form
    {
        public MemberClassification()
        {
            InitializeComponent();
            dataMemberClass.ReadOnly = false;
            rbNone.Checked = true;
        }

        public void setBtnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }

        
        public void setBtnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
        }

        public void setBtnDeleteEventHandler(EventHandler e)
        {
            this.btnDelete.Click += e;
        }

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void setBtnCancelEventHandler(EventHandler e)
        {
            this.btnCancel.Click += e;
        }


        public void setBtnRetrieveEventHandler(EventHandler e)
        {
            this.btnRetrieve.Click += e;
        }

        public void populateMemberTypes(Dictionary<int, string> memberTypes)
        {
            foreach (String s in memberTypes.Values)
            {
                checkedMemberType.Items.Add(s);
            }
        }

        public void toggleCheckedTypes(ArrayList activeTypes)
        {

            foreach (String s in activeTypes)
            {
                if (checkedMemberType.Items.Contains(s))
                {
                    int i = checkedMemberType.Items.IndexOf(s);
                    checkedMemberType.SetItemChecked(i, true);
                }
            }
        }

        public void classGrid(DataSet ds)
        {
            this.dataMemberClass.DataSource = ds.Tables[0];
            this.dataMemberClass.Columns[0].Visible = false;
            this.dataMemberClass.Columns[6].Visible = false;
            this.dataMemberClass.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public string getStatusDesc()
        {
            return this.txtStatusDesc.Text.Trim();
        }

        public int getDelValue() {

            return Convert.ToInt32(numDelValue.Value);
        }

        public String getDelUnit() {
            try
            {
                return cbDelUnits.SelectedItem.ToString();
            }
            catch (NullReferenceException) {
                return String.Empty;
            }
        }

        public String getDelBasis() {
            try{
            return cbBasis.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                return String.Empty;
            }
        
        }

        public bool getDelinquency() {

            bool check = false;
            if (rbNone.Checked)
                check = false;
            if (rbDelinquent.Checked)
                check = true;

            return check;

        }

        public bool getStatus()
        {
            return this.checkStatus.Checked;
        }

        public void disableFunction()
        {
            this.txtStatusDesc.Clear();
            this.checkStatus.CheckState = CheckState.Unchecked;
            this.checkedMemberType.Items.Clear();
            this.numDelValue.Value = 0;
            this.cbDelUnits.SelectedIndex = -1;
            this.cbBasis.SelectedIndex = -1;
            this.btnRetrieve.Visible = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            this.checkedMemberType.Enabled = false;
            this.txtStatusDesc.Enabled = false;
            this.checkStatus.Enabled = false;
            this.checkedMemberType.Enabled = false;
            this.rbNone.Enabled = false;
            this.rbNone.Checked = true;
            this.rbDelinquent.Enabled = false;

            this.numDelValue.Enabled = false;
            this.cbDelUnits.Enabled = false;
            this.cbBasis.Enabled = false;
            this.resetLabels();
        }


        public void enableFunction()
        {
            this.txtStatusDesc.Clear();
            this.checkStatus.CheckState = CheckState.Unchecked;
            this.checkedMemberType.Items.Clear();
            this.numDelValue.Value = 0;
            this.cbDelUnits.SelectedIndex = -1;
            this.cbBasis.SelectedIndex = -1;

            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            this.checkedMemberType.Enabled = true;
            this.txtStatusDesc.Enabled = true;
            this.checkStatus.Enabled = true;
            this.checkedMemberType.Enabled = true;
            this.rbNone.Enabled = true;
            this.rbDelinquent.Enabled = true;
            this.numDelValue.Enabled = false;
            this.cbDelUnits.Enabled = false;
            this.cbBasis.Enabled = false;
            this.resetLabels();
        }

        public DataGridViewRow getSelected()
        {
            return this.dataMemberClass.SelectedRows[0];
        }


        public void setStatusDesc(string s)
        {
            txtStatusDesc.Text = s;
        }

        public void setStatus()
        {
            checkStatus.CheckState = CheckState.Checked;
        }

        public CheckedListBox.CheckedItemCollection getCheckedTypes()
        {

            return checkedMemberType.CheckedItems;
        }

        public void setMemberType(ArrayList memberTypes)
        {
            checkedMemberType.Items.Add(memberTypes);
        }

        public void setDelinquency(int delinquencyValue, String delinquencyUnits, String delinquencyBasis) {

            if (delinquencyValue > 0)
            {
                rbDelinquent.Checked = true;
                this.numDelValue.Enabled = true;
                this.cbBasis.Enabled = true;
                this.cbDelUnits.Enabled = true;
                numDelValue.Value = delinquencyValue;
                cbDelUnits.SelectedItem = delinquencyUnits;
                cbBasis.SelectedItem = delinquencyBasis;

            }
            else
                rbNone.Checked = true;
        
        }

        public DataGridViewRowCollection getAllRows()
        {
            return this.dataMemberClass.Rows;
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

        public void setArchivedColor(int i)
        {
            dataMemberClass.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            dataMemberClass.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataMemberClass.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        public void showRetrieve()
        {
            this.btnRetrieve.Visible = true;
        }

        public void hideRetrieve()
        {
            this.btnRetrieve.Visible = false;
        }

        private void rbDelinquent_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbDelinquent.Checked)
            {
                this.numDelValue.Enabled = true;
                this.numDelValue.Value = 1;
                this.cbBasis.Enabled = true;
                this.cbDelUnits.Enabled = true;
            }
            else
            {
                this.numDelValue.Value = 0;
                this.cbBasis.SelectedIndex = -1;
                this.cbDelUnits.SelectedIndex = -1;

                this.numDelValue.Enabled = false;
                this.cbBasis.Enabled = false;
                this.cbDelUnits.Enabled = false;
            }
        }

        public void errorClassName()
        {
           lblName.ForeColor = Color.Red;
        }

        public void errorApplied()
        {
            lblApplied.ForeColor = Color.Red;
        }

        public void errorDeliqStatus()
        {
            groupDeliqStatus.ForeColor = Color.Red;
            rbNone.ForeColor = SystemColors.ControlText;
            rbDelinquent.ForeColor = SystemColors.ControlText;
            numDelValue.ForeColor = SystemColors.ControlText;
            cbDelUnits.ForeColor = SystemColors.ControlText;
            label4.ForeColor = SystemColors.ControlText;
            cbBasis.ForeColor = SystemColors.ControlText;
        }
        
        public void resetLabels()
        {
            lblName.ForeColor = SystemColors.ControlText;
            lblApplied.ForeColor = Color.MediumBlue;
            rbNone.ForeColor = SystemColors.ControlText;
            rbDelinquent.ForeColor = SystemColors.ControlText;
            groupDeliqStatus.ForeColor = Color.MediumBlue;
        }

        private void txtCopyPaste(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtWholeNum(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtDecimal(object sender, KeyPressEventArgs e)
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

        private void dataMemberClass_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataMemberClass.Rows;
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

    }
}
