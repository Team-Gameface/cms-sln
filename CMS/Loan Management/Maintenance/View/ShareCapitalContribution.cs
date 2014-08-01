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

namespace CMS.Loan_Management.Maintenance.View
{
    public partial class ShareCapitalContribution : Form
    {
        public ShareCapitalContribution()
        {
            InitializeComponent();
        }

        public void enableFunction()
        {
            this.comboAccountType.SelectedIndex = -1;
            this.txtContribution.Clear();
            this.comboContribution.SelectedIndex = -1;
            this.Status.CheckState = CheckState.Unchecked;

            this.comboAccountType.Enabled = true;
            this.txtContribution.Enabled = true;
            this.comboContribution.Enabled = true;
            this.Status.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
        }

        public void disableFunction()
        {
            this.comboAccountType.SelectedIndex = -1;
            this.txtContribution.Clear();
            this.comboContribution.SelectedIndex = -1;
            this.Status.CheckState = CheckState.Unchecked;

            this.comboAccountType.Enabled = false;
            this.txtContribution.Enabled = false;
            this.comboContribution.Enabled = false;
            this.Status.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
        }




       
        public void disableType()
        {
            this.comboAccountType.Enabled = false;
        }

        public int initAccountType(DataSet ds)
        {
            int i = 0;
            this.comboAccountType.DataSource = ds.Tables[0];
            this.comboAccountType.ValueMember = "MemberTypeNo";
            this.comboAccountType.DisplayMember = "Description";

            if (comboAccountType.Items.Count == 0) { i = -1; }
            return i;
        }

        public void setAccountType(String s)
        {
            this.comboAccountType.Text = s;
        }

        public int getAccountType()
        {
            return int.Parse(this.comboAccountType.SelectedValue.ToString());
        }

        public void setCapitalContrib(String s)
        {
            this.txtContribution.Text = s;
        }

        public double getCapitalContrib()
        {
            try
            {
                return double.Parse(this.txtContribution.Text.ToString());
            }
            catch (Exception) { return 0.00; }
        }

        public void setComboContrib(String s)
        {
            this.comboContribution.SelectedItem = s;
        }

        public String getComboContrib()
        {
            return this.comboContribution.SelectedItem.ToString();
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

        public void capitalContributionGrid(DataSet ds)
        {
            this.dataCapitalContribution.DataSource = ds.Tables[0];
            this.dataCapitalContribution.Columns[0].Visible = false;
            this.dataCapitalContribution.Columns[1].Visible = false;
            this.dataCapitalContribution.Columns[3].DefaultCellStyle.Format = "c";
            CultureInfo ph = new CultureInfo("en-PH");
            this.dataCapitalContribution.Columns[3].DefaultCellStyle.FormatProvider = ph;
            this.dataCapitalContribution.Columns[6].Visible = false;
        }

        public DataGridViewRow getSelected()
        {
            return this.dataCapitalContribution.SelectedRows[0];
        }

        public void setBtnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }

        public void setBtnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
        }
        public void setAllLabelsToBlack()
        {
            this.lblMemberType.ForeColor = System.Drawing.Color.Black;
            this.lblCapitalContrib.ForeColor = System.Drawing.Color.Black;
            this.lblDuration.ForeColor = System.Drawing.Color.Black;
        }

        private void txtContribution_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtContribution_KeyPress(object sender, KeyPressEventArgs e)
        {
            int length = this.txtContribution.Text.Length;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\b' && txtContribution.SelectionStart == this.txtContribution.Text.Length - 2)
            {
                this.txtContribution.SelectionStart = this.txtContribution.Text.Length - 3;
            }

            //if (e.KeyChar == '\b' && length % 4 == 0) 
            //{
            //  MessageBox.Show("hi");
            //this.txtMaxWith.SelectionStart = this.txtMaxWith.Text.Length-2;
            //} 

            if (Char.IsDigit(e.KeyChar) && txtContribution.Text.Length == 4)
            {
                this.txtContribution.SelectionStart = this.txtContribution.Text.Length - 3;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                this.txtContribution.Text = this.getCapitalContrib().ToString();
                this.txtContribution.SelectionStart = this.txtContribution.Text.Length - 2;
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

        public void cbShowArchive_CheckStateChanged(EventHandler e)
        {
            this.cbShowArchive.Click += e;
        }

        public bool checkArchivedState()
        {
            this.btnEdit.Enabled = true;

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
            return this.dataCapitalContribution.Rows;
        }

        public void setArchivedColor(int i)
        {
            this.dataCapitalContribution.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            this.dataCapitalContribution.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            this.dataCapitalContribution.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        public void getSelectedData()
        {
            DataGridViewRow selectedData = this.getSelected();
            this.btnEdit.Enabled = true;

            if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
            {
                this.btnEdit.Enabled = false;
            }
        }

        private void dataCapitalContribution_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                getSelectedData();
            }
        }

        private void dataCapitalContribution_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getSelectedData();
        }

        private void txtContribution_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtContribution.SelectionStart;
            this.txtContribution.Text = this.getCapitalContrib().ToString("N2", CultureInfo.InvariantCulture);
            if (selectionStart == txtContribution.Text.Length - 2)
            {
                this.txtContribution.SelectionStart = txtContribution.Text.Length - 2;
            }
            else if (selectionStart == txtContribution.Text.Length - 1)
            {
                this.txtContribution.SelectionStart = txtContribution.Text.Length - 1;
            }
            else this.txtContribution.SelectionStart = txtContribution.Text.Length - 3;
        }


    }
}
