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
using System.Globalization;

namespace CMS.Loan_Management.Maintenance.View
{
    public partial class LoanTypes : Form
    {
        public LoanTypes()
        {
            InitializeComponent();
        }

        public void disableFunction() {
            txtTimesOfShareCap.Clear();
            txtTimesOfShareCap.Enabled = false;
            txtName.Clear();
            txtName.Enabled = false;
            minimumUD.Value = 0;
            minimumUD.Enabled = false;
            maximumUD.Value = 0;
            maximumUD.Enabled = false;
            cbMinimumStatus.SelectedIndex = -1;
            cbMinimumStatus.Enabled = false;
            cbMaximumStatus.SelectedIndex = -1;
            cbMaximumStatus.Enabled = false;
            txtMaxAmt.Clear();
            txtMaxAmt.Enabled = false;
            comakersUD.Value = 0;
            comakersUD.Enabled = false;
            chbCollateral.CheckState = CheckState.Unchecked;
            chbCollateral.Enabled = false;
            chbStatus.CheckState = CheckState.Unchecked;
            chbStatus.Enabled = false;
            chbMaximumPaymentDur.Enabled = false;
            clbMemberType.Enabled = false;
            clbMemberType.Items.Clear();

            btnRetrieve.Visible = false;

            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
        }

        public void enableFunction() {
            txtName.Clear();
            txtName.Enabled = true;
            minimumUD.Value = 0;
            minimumUD.Enabled = true;
            maximumUD.Value = 0;
            maximumUD.Enabled = false;
            cbMinimumStatus.SelectedIndex = -1;
            cbMinimumStatus.Enabled = true;
            cbMaximumStatus.SelectedIndex = -1;
            cbMaximumStatus.Enabled = false;
            txtMaxAmt.Clear();
            txtMaxAmt.Enabled = true;
            txtTimesOfShareCap.Clear();
            txtTimesOfShareCap.Enabled = true;
            comakersUD.Value = 0;
            comakersUD.Enabled = true;
            chbCollateral.CheckState = CheckState.Unchecked;
            chbCollateral.Enabled = true;
            chbStatus.Enabled = true;
            clbMemberType.Enabled = true;
            chbMaximumPaymentDur.Enabled = true;
            btnRetrieve.Visible = false;

            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            
        
        }

        public void setAllLabelsToBlack() {
            this.lblFixed.ForeColor = System.Drawing.Color.Black;
            this.lblComaker.ForeColor = System.Drawing.Color.Black;
            this.chbMaximumPaymentDur.ForeColor = System.Drawing.Color.Black;
            this.lblMaxLoanableAmt.ForeColor = System.Drawing.Color.Black;
            this.lblMinimumPaymentDur.ForeColor = System.Drawing.Color.Black;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.gbAvailability.ForeColor = System.Drawing.Color.Black;
            this.lblOf.ForeColor = System.Drawing.Color.Black;  
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
            this.dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            this.dataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            this.dataGridView.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
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
            return this.dataGridView.Rows;
        }

        public void populateMemberTypes(Dictionary<int, string> memberTypes)
        {
            foreach (String s in memberTypes.Values)
            {
                clbMemberType.Items.Add(s);
            }
        }


        public void toggleCheckedTypes(ArrayList activeTypes)
        {

            foreach (String s in activeTypes)
            {
                if (clbMemberType.Items.Contains(s))
                {
                    int i = clbMemberType.Items.IndexOf(s);
                    clbMemberType.SetItemChecked(i, true);
                }
            }
        }

        public void setTextName(String s)
        {
            this.txtName.Text = s;
        }

        public String getTextName()
        {
            return this.txtName.Text.Trim();
        }

        public void setMinimumPayment(int i)
        {
            this.minimumUD.Value = i;
        }

        public int getMinimumPayment()
        {
            return int.Parse(this.minimumUD.Value.ToString()); 
            
        }

        public void setMinimumStatus(String s) {
            this.cbMinimumStatus.SelectedItem = s;
        }

        public String getMinimumStatus() {
            return this.cbMinimumStatus.SelectedItem.ToString();
        }

        public void setMaximumPayment(int i)
        {
            this.maximumUD.Value = i;
        }

        public int getMaximumPayment()
        {
            return int.Parse(this.maximumUD.Value.ToString());
        }

        public void setMaximumStatus(String s)
        {
            this.cbMaximumStatus.SelectedItem = s;
        }

        public String getMaximumStatus()
        {
            return this.cbMaximumStatus.SelectedItem.ToString();
        }

        public void setMaximumAmount(Double d) {
            this.txtMaxAmt.Text = d.ToString();
        }

        public double getMaximumAmount() {
            try
            {
                return Double.Parse(this.txtMaxAmt.Text);
            }
            catch (Exception) { return 0; }
        }

        public void setTimesOfShareCap(double d) {
            this.txtTimesOfShareCap.Text = d.ToString();
        }

        public double getTimesOfShareCap() {
            return double.Parse(this.txtTimesOfShareCap.Text);
        }

        public void setComakers(int i)
        {
            this.comakersUD.Value = i;
        }

        public int getComakers()
        {
            return int.Parse(this.comakersUD.Value.ToString());
        }

        public void setCollateral()
        {
            this.chbCollateral.CheckState = CheckState.Checked;
        }

        public void setMaximumPaymentDuration()
        {
            this.chbMaximumPaymentDur.CheckState = CheckState.Checked;
        }

        public Boolean getCollateral()
        {
            if (this.chbCollateral.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public CheckedListBox.CheckedItemCollection getCheckedTypes()
        {

            return clbMemberType.CheckedItems;
        }

        public void setMemberType(ArrayList loanTypes)
        {
            clbMemberType.Items.Add(loanTypes);
        }

        public void setStatus()
        {
            this.chbStatus.CheckState = CheckState.Checked;
        }

        public Boolean getStatus()
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

        public void loanTypeGrid(DataSet ds)
        {
            this.dataGridView.DataSource = ds.Tables[0];
            this.dataGridView.Columns[0].Visible = false;
            this.dataGridView.Columns[9].Visible = false;
            this.dataGridView.Columns[4].DefaultCellStyle.Format = "c";
            CultureInfo ph = new CultureInfo("en-PH");
            this.dataGridView.Columns[4].DefaultCellStyle.FormatProvider = ph;

        }

        public DataGridViewRow getSelected()
        {
            return this.dataGridView.SelectedRows[0];
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

        private void comakersUD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void minimumUD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maximumUD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaxAmt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comakersUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (comakersUD.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void minimumUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (minimumUD.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void maximumUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (maximumUD.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void txtMaxAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataGridView.Rows;
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

        private void chbMaximumPaymentDur_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMaximumPaymentDur.Checked == true) { maximumUD.Enabled = true; cbMaximumStatus.Enabled = true; }
            else { maximumUD.Enabled = false; cbMaximumStatus.Enabled = false; cbMaximumStatus.SelectedIndex = -1; maximumUD.Value = 0; }
        }

        public Boolean getMaximumPaymentDurationStatus() 
        {
            if (chbMaximumPaymentDur.Checked == true) { return true; }
            else return false;
        }

        private void txtTimesOfShareCap_KeyPress(object sender, KeyPressEventArgs e)
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
                if (parts.Length > 1 || tb.TextLength > 1)
                {
                    try
                    {
                        if (parts[0].Length > 2 || parts[1].Length > 2 || parts.Length > 2)
                        {
                            e.Handled = true;
                        }
                    }
                    catch (Exception) { tb.Text = "0"; }
                }
            }   
                

        }

        private void txtTimesOfShareCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

    }
}
