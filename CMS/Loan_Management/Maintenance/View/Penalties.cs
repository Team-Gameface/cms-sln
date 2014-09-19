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
    public partial class Penalties : Form
    {
        public Penalties()
        {
            InitializeComponent();
            dataPenalties.ReadOnly = true;
        }

        public void disableFunction()
        {
            this.cbGrace.CheckState = CheckState.Unchecked;
            this.txtName.Clear();
            this.txtAmount.Clear();
            this.gpUD.Value = 0;
            this.durationUD.Value = 0;
            this.chbStatus.CheckState = CheckState.Unchecked;
            this.clbLoanType.Items.Clear();
            this.cbAmountStatus.SelectedIndex = -1;
            this.cbDurationStatus.SelectedIndex = -1;
            this.cbDeduction.SelectedIndex = -1;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            this.txtName.Enabled = false;
            this.cbGrace.Enabled = false;
            this.gpUD.Enabled = false;
            this.txtAmount.Enabled = false;
            this.cbAmountStatus.Enabled = false;
            this.cbDeduction.Enabled = false;
            this.durationUD.Enabled = false;
            this.cbDurationStatus.Enabled = false;
            this.chbStatus.Enabled = false;
            this.clbLoanType.Enabled = false;

            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnRetrieve.Visible = false;
            this.cbDeduction.Enabled = false;
            txtSearch.Enabled = true;

        }
        public void enableFunction()
        {
            this.cbGrace.CheckState = CheckState.Unchecked;
            this.txtName.Clear();
            this.txtAmount.Clear();
            this.cbAmountStatus.SelectedIndex = -1;
            this.cbDurationStatus.SelectedIndex = -1;
            this.cbDeduction.SelectedIndex = -1;
            this.gpUD.Value = 0;
            this.durationUD.Value = 0;
            this.clbLoanType.Items.Clear();
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.btnRetrieve.Visible = false;
            this.cbDeduction.Enabled = false;
            txtSearch.Enabled = false;

            this.txtName.Enabled = true;
            this.cbGrace.Enabled = true;
            this.txtAmount.Enabled = true;
            this.cbAmountStatus.Enabled = true;
            this.cbDeduction.Enabled = true;
            this.durationUD.Enabled = true;
            this.cbDurationStatus.Enabled = true;
            this.chbStatus.Enabled = true;
            this.clbLoanType.Enabled = true;
        }


        public void enableDeduction() 
        {
            this.cbDeduction.Enabled = true;
        }

        public void disableDeduction() 
        {
            this.cbDeduction.Enabled = false;
            this.cbDeduction.SelectedIndex = -1;
        }

        public Boolean getDeductionStatus()
        {
            if (cbDeduction.Enabled == true) { return true; }
            else { return false; }
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

        //retrieve
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
            this.dataPenalties.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            this.dataPenalties.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            this.dataPenalties.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
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
            return this.dataPenalties.Rows;
        }

        //retrieve


        public void populateLoanTypes(Dictionary<int, string> loanTypes)
        {
            foreach (String s in loanTypes.Values)
            {
                clbLoanType.Items.Add(s);
            }
        }

        public void setCheckBox() {
            this.cbGrace.CheckState = CheckState.Checked;
            gpUD.Enabled = true;
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
            this.dataPenalties.DataSource = ds.Tables[0];
            this.dataPenalties.Columns[0].Visible = false;
            this.dataPenalties.Columns[7].Visible = false;
            this.dataPenalties.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataPenalties.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            return this.txtName.Text;
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
            return this.dataPenalties.SelectedRows[0];
        }


        public void setChargeName(string s)
        {
            this.txtName.Text = s;
        }

        public void setStatus()
        {
            chbStatus.CheckState = CheckState.Checked;
        }

        public void setAmountStatus(String s)
        {
            this.cbAmountStatus.SelectedItem = s;
        }


        public String getAmountStatus()
        {
            return this.cbAmountStatus.SelectedItem.ToString();
        }

        public void setDurationStatus(String s)
        {
            this.cbDurationStatus.SelectedItem = s;
        }


        public String getDurationStatus()
        {
            return this.cbDurationStatus.SelectedItem.ToString();
        }

        public void setDeduction(String s)
        {
            this.cbDeduction.SelectedItem = s;
        }


        public String getDeduction()
        {
            return this.cbDeduction.SelectedItem.ToString();
        }

        public void setDuration(int i)
        {
            this.durationUD.Value = i;
        }

        public int getDuration()
        {
            return int.Parse(this.durationUD.Value.ToString());
        }

        public void setGracePeriod(int i)
        {
            this.gpUD.Value = i;
        }

        public int getGracePeriod()
        {
            return int.Parse(this.gpUD.Value.ToString());
        }


        public CheckedListBox.CheckedItemCollection getCheckedTypes()
        {

            return clbLoanType.CheckedItems;
        }

        public void setMemberType(ArrayList memberTypes)
        {
            clbLoanType.Items.Add(memberTypes);
        }

        private void cbGrace_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGrace.CheckState == CheckState.Checked)
            {
                gpUD.Enabled = true;
            }
            else
            {
                gpUD.Enabled = false;
                gpUD.Value = 0;
            }
        }

        public void setAllTextBlack() 
        {
            this.lblPenaltyName.ForeColor = System.Drawing.Color.Black;
            this.lblLoanType.ForeColor = System.Drawing.Color.Black;
            this.lblGracePeriod.ForeColor = System.Drawing.Color.Black;
            this.lblDuration.ForeColor = System.Drawing.Color.Black;
            this.lblBasis.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
        
        }

       
        

       
        

       

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

  

        private void gpUD_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gpUD_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (gpUD.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void durationUD_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void durationUD_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (durationUD.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
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

        private void cbShowArchive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataPenalties_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataPenalties.Rows;
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

        private void cbAmountStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbAmountStatus.SelectedItem.ToString() == "Php") { this.disableDeduction(); }
                else { this.enableDeduction(); }
            }
            catch (Exception) { }
        }


    }
}
