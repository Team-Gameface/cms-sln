using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Maintenance.View
{
    public partial class ScheduleOfFees : Form
    {
        public ScheduleOfFees()
        {
            InitializeComponent();
            dataSchedFees.ReadOnly = true;
        }

        public void setBtnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }
        
        public void setBtnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
        }

        public void setTxtSearchEventHandler(EventHandler e)
        {
            this.txtSearch.TextChanged += e;
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

        public void feeGrid(DataSet ds)
        {
            this.dataSchedFees.DataSource = ds.Tables[0];
            this.dataSchedFees.Columns[0].Visible = false;
            this.dataSchedFees.Columns[4].Visible = false;
            this.dataSchedFees.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataSchedFees.Columns["Amount"].DefaultCellStyle.Format = "c";
            CultureInfo ph = new CultureInfo("en-PH");
            this.dataSchedFees.Columns["Amount"].DefaultCellStyle.FormatProvider = ph;
        }

        public string getFeeDesc()
        {
            return this.txtFeeDesc.Text.Trim();
        }

        public Double getFeeAmount()
        {
            try
            {
                return Double.Parse(this.txtAmount.Text);
            }
            catch (FormatException) {
                return 0.00;
            }
        }

        public bool getStatus()
        {
            return this.checkStatus.Checked;
        }

        public string getSearch()
        {
            return this.txtSearch.Text;
        }

        public void disableFunction()
        {
            this.resetLabels();
            this.txtFeeDesc.Clear();
            this.txtAmount.Clear();
            this.checkStatus.CheckState = CheckState.Unchecked;
            this.checkedMemberType.Items.Clear();
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            this.txtSearch.Enabled = true;
            this.btnRetrieve.Visible = false;
            this.checkedMemberType.Enabled = false;
            this.txtFeeDesc.Enabled = false;
            this.txtAmount.Enabled = false;
            this.checkStatus.Enabled = false;
            this.checkedMemberType.Enabled = false;
        }


        public void enableFunction()
        {
            this.resetLabels();
            this.txtFeeDesc.Clear();
            this.checkStatus.CheckState = CheckState.Unchecked;
            this.checkedMemberType.Items.Clear();
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.checkedMemberType.Enabled = true;
            this.txtFeeDesc.Enabled = true;
            this.txtAmount.Enabled = true; 
            this.checkStatus.Enabled = true;
            this.checkedMemberType.Enabled = true;

        }

        public DataGridViewRow getSelected()
        {
            return this.dataSchedFees.SelectedRows[0];
        }
        

        public void setFeeName(string s)
        {
            txtFeeDesc.Text = s;
        }

        public void setFeeAmount(Double d)
        {
            txtAmount.Text = d.ToString("F2");
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
                this.txtAmount.Text = this.getFeeAmount().ToString();
                this.txtAmount.SelectionStart = this.txtAmount.Text.Length - 2;
            }
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

        public DataGridViewRowCollection getAllRows()
        {
            return this.dataSchedFees.Rows;
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
            dataSchedFees.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            dataSchedFees.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataSchedFees.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        public void showRetrieve()
        {
            this.btnRetrieve.Visible = true;
        }

        public void hideRetrieve()
        {
            this.btnRetrieve.Visible = false;
        }

        public void errorName()
        {
            lblFeeName.ForeColor = Color.Red;
        }

        public void errorApplied()
        {
           lblApplied.ForeColor = Color.Red;
        }

        public void errorAmt()
        {
            lblAmt.ForeColor = Color.Red;
        }
        public void resetLabels()
        {
            lblFeeName.ForeColor = Color.Black;
            lblApplied.ForeColor = Color.MediumBlue;
            lblAmt.ForeColor = Color.Black;
        }

        private void dataSchedFees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataSchedFees.Rows;
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

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtAmount.SelectionStart;
            this.txtAmount.Text = this.getFeeAmount().ToString("N2", CultureInfo.InvariantCulture);
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
