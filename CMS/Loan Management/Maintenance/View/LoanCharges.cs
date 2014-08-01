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
    public partial class LoanCharges : Form
    {
        public LoanCharges()
        {
            InitializeComponent();
            dataLoanCharge.ReadOnly = true;

        }

        public void disableFunction()
        {
            this.txtName.Clear();
            this.txtAmount.Clear();
            gbCharge.Enabled = false;
            this.chbStatus.CheckState = CheckState.Unchecked;
            this.clbLoanType.Items.Clear();
            this.cbOption.SelectedIndex = -1;
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
            this.btnRetrieve.Visible = false;
            txtSearch.Enabled = true;

        }
        public void enableFunction()
        {
            this.txtName.Clear();
            this.txtAmount.Clear();
            gbCharge.Enabled = true;
            this.cbOption.SelectedIndex = -1;
            this.clbLoanType.Items.Clear();
            this.btnAdd.Enabled = false;
            this.btnAdd.BackColor = Color.Gray;
            this.btnEdit.Enabled = false;
            this.btnEdit.BackColor = Color.Gray;
            this.btnDelete.Enabled = false;
            this.btnDelete.BackColor = Color.Gray;
            this.btnSave.Enabled = true;
            this.btnSave.BackColor = Color.Green;
            this.btnCancel.Enabled = true;
            this.btnCancel.BackColor = Color.WhiteSmoke;
            this.btnRetrieve.Visible = false;
            txtSearch.Enabled = false;

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


        public void showRetrieve()
        {
            this.btnRetrieve.Visible = true;
        }

        public void hideRetrieve()
        {
            this.btnRetrieve.Visible = false;
        }

        public void setArchivedColor(int i)
        {
            this.dataLoanCharge.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            this.dataLoanCharge.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            this.dataLoanCharge.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        public void cbShowArchive_CheckStateChanged(EventHandler e)
        {
            this.cbShowArchive.Click += e;
        }


        public bool checkArchivedState()
        {
            if (this.cbShowArchive.CheckState == CheckState.Checked)
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
            return this.dataLoanCharge.Rows;
        }


        public void populateLoanTypes(Dictionary<int, string> loanTypes)
        {
            foreach (String s in loanTypes.Values)
            {
                clbLoanType.Items.Add(s);
            }
        }

        public String getTextSearch()
        {
            return this.txtSearch.Text;
        }

        public void toggleCheckedTypes(ArrayList activeTypes)
        {

            foreach (String s in activeTypes)
            {
                if (clbLoanType.Items.Contains(s))
                {
                    int i = clbLoanType.Items.IndexOf(s);
                    clbLoanType.SetItemChecked(i, true);
                }
            }
        }

        public void requirementGrid(DataSet ds)
        {
            this.dataLoanCharge.DataSource = ds.Tables[0];
            this.dataLoanCharge.Columns[0].Visible = false;
            this.dataLoanCharge.Columns[4].Visible = false;
        }

        public void setAmount(Double d)
        {
            this.txtAmount.Text = d.ToString();
        }

        public double getAmount()
        {
            return Double.Parse(this.txtAmount.Text);
        }

        public string getChargeName()
        {
            return this.txtName.Text.Trim();
        }

        public bool getStatus()
        {
            return this.chbStatus.Checked;
        }

        public string getSearch()
        {
            return this.txtSearch.Text;
        }


        public DataGridViewRow getSelected()
        {
            return this.dataLoanCharge.SelectedRows[0];
        }


        public void setChargeName(string s)
        {
            this.txtName.Text = s;
        }

        public void setStatus()
        {
            chbStatus.CheckState = CheckState.Checked;
        }

        public void setOption(String s)
        {
            this.cbOption.SelectedItem = s;
        }


        public String getOption()
        {
            return this.cbOption.SelectedItem.ToString();
        }


        public CheckedListBox.CheckedItemCollection getCheckedTypes()
        {

            return clbLoanType.CheckedItems;
        }

        public void setMemberType(ArrayList memberTypes)
        {
            clbLoanType.Items.Add(memberTypes);
        }

        public void setAllTextBlack()
        {
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblChargeName.ForeColor = System.Drawing.Color.Black;
            this.lblLoanType.ForeColor = System.Drawing.Color.Black;
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtAmount_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtAmount_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dataLoanCharge_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataLoanCharge.Rows;
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

        public void txtSearch_TextChanged(EventHandler e)
        {
            this.txtSearch.TextChanged += e;
        }
    }
}
