using System;
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
    public partial class MemberTypes : Form
    {
        public MemberTypes()
        {
            InitializeComponent();
            dataMemberType.ReadOnly = true;
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

        public void setBtnRetrieveEventHandler(EventHandler e)
        {
            this.btnRetrieve.Click += e;
        }

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void setBtnCancelEventHandler(EventHandler e)
        {
            this.btnCancel.Click += e;
        }

        public void memberTypeGrid(DataSet ds)
        {
            this.dataMemberType.DataSource = ds.Tables[0];
            dataMemberType.Columns[0].Visible = false;
            dataMemberType.Columns[8].Visible = false;
        }

        public String getTypeName()
        {
            return this.txtTypeName.Text.Trim();
        }

        public Boolean getLoan()
        {
            if (checkLoan.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean getSavings()
        {
            if (checkSavings.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean getShareCapital()
        {
            if (checkShareCapital.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getMinAge()
        {
            return int.Parse(this.numMinAge.Value.ToString());
        }

        public int getMaxAge()
        {
            return int.Parse(this.numMaxAge.Value.ToString());
        }


        public bool getMinAgeChecked()
        {
            return this.checkMinAge.Checked;
        }

        public bool getMaxAgeChecked()
        {
            return this.checkMaxAge.Checked;
        }

        public bool checkStatusChecked()
        {
            return this.checkStatus.Checked;
        }

        public void disableFunction()
        {
            this.resetServices();
            this.resetTypeName();
            this.txtTypeName.Clear();
            this.checkLoan.CheckState = CheckState.Unchecked;
            this.checkLoan.Enabled = false;
            this.checkSavings.CheckState = CheckState.Unchecked;
            this.checkShareCapital.CheckState = CheckState.Unchecked;
            this.checkMinAge.CheckState = CheckState.Unchecked;
            this.checkMaxAge.CheckState = CheckState.Unchecked;
            this.numMinAge.Value = 0;
            this.numMaxAge.Enabled = false;
            this.numMinAge.Enabled = false;
            this.numMaxAge.Value = 0;
            this.checkStatus.CheckState = CheckState.Unchecked;

            this.txtTypeName.Enabled = false;
            this.groupAvailability.Enabled = false;
            this.groupAge.Enabled = false;
            this.checkStatus.Enabled = false;

            this.btnRetrieve.Visible = false;
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
            this.resetTypeName();
            this.txtTypeName.Clear();
            this.resetServices();
            this.resetAge();
            this.checkLoan.CheckState = CheckState.Unchecked;
            this.checkSavings.CheckState = CheckState.Unchecked;
            this.checkShareCapital.CheckState = CheckState.Unchecked;
            this.checkMinAge.CheckState = CheckState.Unchecked;
            this.checkMaxAge.CheckState = CheckState.Unchecked;
            this.numMinAge.Value = 0;
            this.numMaxAge.Value = 0;
            this.checkStatus.CheckState = CheckState.Unchecked;

            this.btnAdd.Enabled = false;
            this.btnAdd.BackColor = Color.Gray;
            this.btnEdit.Enabled = false;
            this.btnEdit.BackColor = Color.Gray;
            this.btnDelete.Enabled = false;
            this.btnDelete.BackColor = Color.Gray;

            this.txtTypeName.Enabled = true;
            this.groupAge.Enabled = true;
            this.groupAvailability.Enabled = true;
            this.checkStatus.Enabled = true;

            this.btnSave.Enabled = true;
            this.btnSave.BackColor = Color.Green;
            this.btnCancel.Enabled = true;
            this.btnCancel.BackColor = Color.WhiteSmoke;
        }

        public DataGridViewRow getSelected()
        {
            return this.dataMemberType.SelectedRows[0];
        }

        private void checkMinAge_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMinAge.CheckState == CheckState.Checked)
            {
                numMinAge.Enabled = true;
            }
            else
            {
                numMinAge.Enabled = false;
            }
        }

        private void checkMaxAge_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMaxAge.CheckState == CheckState.Checked)
            {
                numMaxAge.Enabled = true;
            }
            else
            {
                numMaxAge.Enabled = false;
            }
        }

        public void setTypeName(String s)
        {
            txtTypeName.Text = s;
        }

        public void setNumberMinAge(int i)
        {
            numMinAge.Value = i;
        }

        public void setNumberMaxAge(int i)
        {
            numMaxAge.Value = i;
        }


        public void setCheckLoan()
        {
            checkLoan.CheckState = CheckState.Checked;
        }

        public void setCheckSavings()
        {
            checkSavings.CheckState = CheckState.Checked;
        }

        public void setCheckShareCapital()
        {
            checkShareCapital.CheckState = CheckState.Checked;
        }

        public void setCheckMinAge()
        {
            checkMinAge.CheckState = CheckState.Checked;
        }

        public void setCheckMaxAge()
        {
            checkMaxAge.CheckState = CheckState.Checked;
        }


        public void setCheckStatus()
        {
            checkStatus.CheckState = CheckState.Checked;
        }

        public void errorTypeName() {

            lblTypeName.ForeColor = Color.Red;
        }

        public void errorServices()
        {

            groupAvailability.ForeColor = Color.Red;
        }

        public void errorAge()
        {

            groupAge.ForeColor = Color.Red;
        }


        public void resetTypeName()
        {

            lblTypeName.ForeColor = Color.Black;
        }

        public void resetServices()
        {

            groupAvailability.ForeColor = Color.Black;
        }

        public void resetAge()
        {

            groupAge.ForeColor = Color.Black;
        }

        public DataGridViewRowCollection getAllRows()
        {
            return this.dataMemberType.Rows;
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
            dataMemberType.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            dataMemberType.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataMemberType.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        public void showRetrieve()
        {
            this.btnRetrieve.Visible = true;
        }

        public void hideRetrieve()
        {
            this.btnRetrieve.Visible = false;
        }


        private void checkMinAge_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkMinAge.Checked)
                numMinAge.Enabled = true;
            else
            {
                numMinAge.Value = 0;
                numMinAge.Enabled = false;
            }      
        }

        private void checkMaxAge_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkMaxAge.Checked)
                numMaxAge.Enabled = true;
            else
            {
                numMaxAge.Value = 0;
                numMaxAge.Enabled = false;
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

        private void dataMemberType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataMemberType.Rows;
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

        private void checkSavings_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSavings.Checked || checkShareCapital.Checked)
            {
                checkLoan.Enabled = true;
               
            }
            else
            {
                checkLoan.CheckState = CheckState.Unchecked;
                checkLoan.Enabled = false;
         
            }
        }

        private void checkShareCapital_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSavings.Checked || checkShareCapital.Checked)
            {
                checkLoan.Enabled = true;
              
            }
            else
            {
                checkLoan.CheckState = CheckState.Unchecked;
                checkLoan.Enabled = false;
                
            }
        }


    }
}
