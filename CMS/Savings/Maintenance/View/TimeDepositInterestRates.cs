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
    public partial class TimeDepositInterestRates : Form
    {
        public TimeDepositInterestRates()
        {
            InitializeComponent();
        }

        public void disableFunction()
        {
            this.txtInterestRate.Clear();
            this.numDays.Value = 0;
            this.txtMinBal.Clear();
            this.txtMaxBal.Clear();
            this.Status.CheckState = CheckState.Unchecked;

            this.txtInterestRate.Enabled = false;
            this.numDays.Enabled = false;
            this.txtMinBal.Enabled = false;
            this.txtMaxBal.Enabled = false;
            this.Status.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
        }

        public void enableFunction()
        {
            this.txtInterestRate.Clear();
            this.numDays.Value = 0;
            this.txtMinBal.Clear();
            this.txtMaxBal.Clear();
            this.Status.CheckState = CheckState.Unchecked;

            this.txtInterestRate.Enabled = true;
            this.numDays.Enabled = true;
            this.txtMinBal.Enabled = true;
            this.txtMaxBal.Enabled = true;
            this.Status.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
        }
        
        public void setNoDays(int i)
        {
            this.numDays.Value = i;
        }

        public int getNoDays()
        {
            return int.Parse(this.numDays.Value.ToString());
        }

        public void setInterestRates(String s)
        {
            this.txtInterestRate.Text = s;
        }

        public double getInterestRates()
        {
            return double.Parse(this.txtInterestRate.Text.ToString());
        }

        public void setMinimumBalance(String s)
        {
            this.txtMinBal.Text = s;
        }

        public double getMinimumBalance()
        {
            try
            {
                return double.Parse(this.txtMinBal.Text);
            }
            catch (Exception) { return 0.00; }
        }

        public void setMaximumBalance(String s)
        {
            this.txtMaxBal.Text = s;
        }

        public double getMaximumBalance()
        {
            try
            {
                return double.Parse(this.txtMaxBal.Text);
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

        public void interestRatesGrid(DataSet ds)
        {
            this.dataInterestRates.DataSource = ds.Tables[0];
        }

        public DataGridViewRow getSelected()
        {
            try
            {
                return this.dataInterestRates.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
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

        public void setBtnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }

        public void setBtnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
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

        private void txtInterestRate_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (parts.Length > 1 || tb.TextLength > 4)
                    {
                        try
                        {
                            if (parts[0].Length > 3 || parts[1].Length > 4 || parts.Length > 2)
                            {
                                e.Handled = true;
                            }
                        }
                        catch (Exception) { tb.Text = "0"; }
                    }
               
            }
        }

        public void setErrorNumDays()
        {
            lblDays.ForeColor = Color.Red;
        }

        public void setErrorInterestRate()
        {
            lblInterestRate.ForeColor = Color.Red;
        }

        public void setErrorMinimum()
        {
            lblMinimum.ForeColor = Color.Red;
        }

        public void setErrorMaximum()
        {
            lblMaximum.ForeColor = Color.Red;
        }

        public void clearError()
        {
            lblDays.ForeColor = SystemColors.ControlText;
            lblInterestRate.ForeColor = SystemColors.ControlText;
            lblMinimum.ForeColor = SystemColors.ControlText;
            lblMaximum.ForeColor = SystemColors.ControlText;
        }

        public void removeColumns()
        {
            dataInterestRates.Columns[0].Visible = false;
            dataInterestRates.Columns[6].Visible = false;
            dataInterestRates.Columns[7].Visible = false;
            dataInterestRates.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataInterestRates.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataInterestRates.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataInterestRates.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataInterestRates.Columns[2].DefaultCellStyle.Format = "c";
            dataInterestRates.Columns[3].DefaultCellStyle.Format = "c";
            dataInterestRates.Columns[4].DefaultCellStyle.Format = "p";
            CultureInfo ph = new CultureInfo("en-PH");
            dataInterestRates.Columns[2].DefaultCellStyle.FormatProvider = ph;
            dataInterestRates.Columns[3].DefaultCellStyle.FormatProvider = ph;
        }

        private void txtInterestRate_KeyDown(object sender, KeyEventArgs e)
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

        /*private void dataInterestRates_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataInterestRates.Rows;
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
        }*/

        public DataGridViewRowCollection getAllRows()
        {
            return this.dataInterestRates.Rows;
        }

        public void setArchivedColor(int i)
        {
            dataInterestRates.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            dataInterestRates.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataInterestRates.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
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
