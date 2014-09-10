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
            txtPenalty.Clear();
            numDurationFrom.Value = 0;
            numDurationTo.Value = 0;
            Status.CheckState = CheckState.Unchecked;

            txtPenalty.Enabled = false;
            numDurationFrom.Enabled = false;
            numDurationTo.Enabled = false;
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
            txtPenalty.Clear();
            numDurationFrom.Value = 0;
            numDurationTo.Value = 0;
            Status.CheckState = CheckState.Unchecked;

            txtPenalty.Enabled = true;
            numDurationFrom.Enabled = true;
            numDurationTo.Enabled = true;

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

        public void setTextPenalty(String s)
        {
            this.txtPenalty.Text = s;
        }

        public double getTextPenalty()
        {
            return double.Parse(this.txtPenalty.Text.ToString());
        }

        public void setNumDurationFrom(int i)
        {
            this.numDurationFrom.Value = i;
        }

        public int getNumDurationFrom()
        {
            return int.Parse(this.numDurationFrom.Value.ToString());
        }

        public void setNumDurationTo(int i)
        {
            this.numDurationTo.Value = i;
        }

        public int getNumDurationTo()
        {
            return int.Parse(this.numDurationTo.Value.ToString());
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

        public void setErrorPenalty()
        {
            lblPenalty.ForeColor = Color.Red;
        }

        public void setErrorDurationFrom()
        {
            lblFrom.ForeColor = Color.Red;
        }

        public void setErrorDurationTo()
        {
            lblTo.ForeColor = Color.Red;
        }
        
        public void clearError()
        {
            lblPenalty.ForeColor = SystemColors.ControlText;
            lblFrom.ForeColor = SystemColors.ControlText;
            lblTo.ForeColor = SystemColors.ControlText;
        }

        public void removeColumns()
        {
            dataTimeDeposit.Columns[0].Visible = false;
            dataTimeDeposit.Columns[5].Visible = false;
            dataTimeDeposit.Columns[6].Visible = false;
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

        private void txtPenalty_KeyDown(object sender, KeyEventArgs e)
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
                    if (numDurationFrom.Text.Length >= 2)
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

        public void txtSearch_TextChanged(EventHandler e)
        {
            this.txtSearch.TextChanged += e;
        }

        public String getSearch()
        {
            return this.txtSearch.Text;
        }

        private void numDurationTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numDurationTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (numDurationTo.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }
    }
}
