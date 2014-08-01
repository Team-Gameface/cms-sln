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
    public partial class LoanAmnestyActivation1 : Form
    {
        public LoanAmnestyActivation1()
        {
            InitializeComponent();
        }

        public void disableFunction()
        {
            this.clbDateTo.Checked = false;
            this.endDate.Enabled = false;
            this.startDate.Value = DateTime.Now;
            this.endDate.MinDate = this.startDate.Value;
            this.endDate.Value = this.startDate.Value.AddDays(1);
            this.udOverdue.Value = 0;
            this.cbDuration.SelectedIndex = -1;
            this.chbStatus.Checked = false;
            this.chbWaiveInterest.Checked = false;
            this.chbWaivePenalties.Checked = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.gbAmnesty.Enabled = false;
            this.clbLoanType.Items.Clear();
        }

        public void enableFunction()
        {
            this.clbDateTo.Checked = false;
            this.endDate.Enabled = false;
            this.startDate.Value = DateTime.Now;
            this.endDate.MinDate = this.startDate.Value;
            this.endDate.Value = this.startDate.Value.AddDays(1);
            this.udOverdue.Value = 0;
            this.cbDuration.SelectedIndex = -1;
            this.chbStatus.Checked = true;
            this.chbWaiveInterest.Checked = false;
            this.chbWaivePenalties.Checked = false;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.gbAmnesty.Enabled = true;
        }

        public void setClbDateTo() 
        {
            this.clbDateTo.Checked = true;
        }

        public void setAllLabelsToBlack()
        {
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblTo.ForeColor = System.Drawing.Color.Black;
            this.lblAndAbove.ForeColor = System.Drawing.Color.Black;
            this.lblWaive.ForeColor = System.Drawing.Color.Black;
            this.lblLoanType.ForeColor = System.Drawing.Color.Black;
            
        }

        public void cbShowArchive_CheckStateChanged(EventHandler e)
        {
            this.chbShowArchive.Click += e;
        }

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void setBtnCancelEventHandler(EventHandler e)
        {
            this.btnCancel.Click += e;
        }

        public void setBtnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }

        public void setBtnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
        }

        public void setOverdue(int i) 
        {
            this.udOverdue.Value = i;
        }

        public int getOverdue() 
        {
            return int.Parse(this.udOverdue.Value.ToString());
        }

        public void setDuration(String s)
        {
            this.cbDuration.SelectedItem = s;
        }

        public String getDuration()
        {
            return this.cbDuration.SelectedItem.ToString();
        }

        public void setStartDate(System.DateTime s)
        {
            this.startDate.Value = s;
        }

        public String getStartDate()
        {
            return this.startDate.Value.ToString("yyyy-MM-dd");
        }

        public void setEndDate(System.DateTime s)
        {
            this.endDate.Value = s;
        }

        public String getEndDate()
        {
            return this.endDate.Value.ToString("yyyy-MM-dd");
        }

        public void setWaiveInterest()
        {
            this.chbWaiveInterest.CheckState = CheckState.Checked;
        }

        public bool getWaiveInterest()
        {
            if (this.chbWaiveInterest.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setWaivePenalty()
        {
            this.chbWaivePenalties.CheckState = CheckState.Checked;
        }

        public bool getWaivePenalty()
        {
            if (this.chbWaivePenalties.CheckState == CheckState.Checked)
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
            this.chbStatus.CheckState = CheckState.Checked;
        }

        public bool getStatus()
        {
            if (this.chbStatus.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkArchivedState()
        {
            this.btnEdit.Enabled = true;

            if (this.chbShowArchive.CheckState == CheckState.Checked)
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
            return this.dataAmnesty.Rows;
        }

        public void populateLoanTypes(Dictionary<int, string> loanTypes)
        {
            foreach (String s in loanTypes.Values)
            {
                clbLoanType.Items.Add(s);
            }
        }

        public CheckedListBox.CheckedItemCollection getCheckedTypes()
        {

            return clbLoanType.CheckedItems;
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

        public void setArchivedColor(int i)
        {
            this.dataAmnesty.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            this.dataAmnesty.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            this.dataAmnesty.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        public void getSelectedData()
        {
            try
            {
                DataGridViewRow selectedData = this.getSelected();
                this.btnEdit.Enabled = true;

                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    this.btnEdit.Enabled = false;
                }
            }
            catch (Exception) { }
        }

        public void amnestyGrid(DataSet ds)
        {
            this.dataAmnesty.DataSource = ds.Tables[0];
            this.dataAmnesty.Columns[0].Visible = false;
            this.dataAmnesty.Columns[7].Visible = false;
            
        }

        public DataGridViewRow getSelected()
        {
            return this.dataAmnesty.SelectedRows[0];
        }

        public Boolean getInfinityDate() 
        {
            if (this.clbDateTo.Checked == true)
            {
                return true ;
            }
            else return false;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
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
           
        }

        private void txtCopyPaste(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dataAmnesty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getSelectedData();
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            if (endDate.Value < startDate.Value)
            {
                endDate.MinDate = startDate.Value.AddDays(1);
                endDate.Value = startDate.Value.AddDays(1);
            }
            else 
            {
                endDate.MinDate = startDate.Value.AddDays(1);
            }
        }

        private void dataAmnesty_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataAmnesty.Rows;
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

        private void clbDateTo_CheckedChanged(object sender, EventArgs e)
        {
            if (clbDateTo.Checked == true)
            {
                this.endDate.Enabled = true;
            }
            else 
            {
                this.endDate.Enabled = false;
            }
        }
    }
}
