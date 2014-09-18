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

namespace CMS.Savings.Transaction.View
{
    public partial class SavingsAccount : Form
    {
        public SavingsAccount()
        {
            InitializeComponent();
            disableFunction();
        }

        public void enableFunction()
        {
            this.txtSearchMember.Clear();
            this.txtSearchMember.Enabled = true;
            this.dataMember.DataSource = null;
            this.btnForward.Enabled = true;
            this.btnBackward.Enabled = true;
            this.txtAccountNo.Clear();
            this.txtAccountHolder.Text = "0";
            this.comboAccountType.SelectedIndex = -1;
            this.comboAccountType.Enabled = true;
            this.dataDepositor.DataSource = null;
            this.dataDepositor.Enabled = true;
            this.txtInitialDeposit.Text = "0";
            this.txtInitialDeposit.Enabled = true;
            this.txtPassbook.Clear();
            this.radioAnd.Checked = false;
            this.radioOr.Checked = false;
            this.radioAnd.Enabled = true;
            this.radioOr.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            this.btnOpen.Enabled = false;
            this.btnTerminate.Enabled = false;
        }

        public void disableFunction()
        {
            this.txtSearchMember.Clear();
            this.txtSearchMember.Enabled = false;
            this.dataMember.DataSource = null;
            this.btnForward.Enabled = false;
            this.btnBackward.Enabled = false;
            this.txtAccountNo.Clear();
            this.txtAccountHolder.Text = "0";
            this.comboAccountType.SelectedIndex = -1;
            this.comboAccountType.Enabled = false;
            this.dataDepositor.DataSource = null;
            this.dataDepositor.Enabled = false;
            this.txtInitialDeposit.Text = "0";
            this.txtInitialDeposit.Enabled = false;
            this.txtPassbook.Clear();
            this.radioAnd.Checked = false;
            this.radioOr.Checked = false;
            this.radioAnd.Enabled = false;
            this.radioOr.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnOpen.Enabled = true;
            this.btnTerminate.Enabled = true;
        }

        public void txtSearchTextChanged(EventHandler e)
        {
            this.txtSearchMember.TextChanged += e;
        }

        public void btnClearEventHandler(EventHandler e)
        {
            this.btnCancel.Click += e;
        }

        public void btnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void btnForwardEventHandler(EventHandler e)
        {
            this.btnForward.Click += e;
        }

        public void btnBackwardEventHandler(EventHandler e)
        {
            this.btnBackward.Click += e;
        }

        public void setDataAccount(DataSet ds)
        {
            if (ds == null)
            {
                this.dataSavingsAccount.DataSource = null;
            }
            else
            {
                this.dataSavingsAccount.DataSource = ds.Tables[0];
                this.dataSavingsAccount.Columns[3].Visible = false;
            }
        }

        public DataGridViewRow getSelectedAccount()
        {
            try
            {
                return this.dataSavingsAccount.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public String getSearchAccount()
        {
            return this.txtSearchAccount.Text.ToString();
        }

        public void setSearchAccountTextChanged(EventHandler e)
        {
            this.txtSearchAccount.TextChanged += e;
        }

        public void setBtnOpenEventHandler(EventHandler e )
        {
            this.btnOpen.Click += e;
        }

        public void setBtnTerminateEventHandler(EventHandler e)
        {
            this.btnTerminate.Click += e;
        }

        public void setDataMember(DataSet ds)
        {
            if (ds == null)
            {
                this.dataMember.DataSource = null;
            }
            else
            {
                this.dataMember.DataSource = ds.Tables[0];
            }
        }

        public void setDataDepositor(DataSet ds)
        {
            if (ds == null)
            {
                this.dataDepositor.DataSource = null;
            }
            else
            {
                this.dataDepositor.DataSource = ds.Tables[0];
            }
        }
        
        public DataGridViewRow getSelectedMember()
        {
            try
            {
                return this.dataMember.SelectedRows[0];
            }
            catch(Exception)
            {
                return null;
            }
        }

        public DataGridViewRow getSelectedDepositor()
        {
            try
            {
                return this.dataDepositor.SelectedRows[0];
            }
            catch(Exception)
            {
                return null;
            }
        }

        public void addDataDepositor(DataGridViewRow row)
        {
            DataTable table = new DataTable();
            table.Columns.Add("AccountNo", typeof(String));
            table.Columns.Add("Member Name", typeof(String));

            foreach (DataGridViewRow rows in dataDepositor.Rows)
            {
                DataRow dr = table.NewRow();
                dr[0] = rows.Cells[0].Value.ToString();
                dr[1] = rows.Cells[1].Value.ToString();
                table.Rows.Add(dr);
            }

            DataRow newdr = table.NewRow();
            newdr[0] = row.Cells[0].Value.ToString();
            newdr[1] = row.Cells[1].Value.ToString();
            table.Rows.Add(newdr);

            dataDepositor.DataSource = table;
            dataMember.Rows.Remove(row);
        }

        public void addDataMember(DataGridViewRow row)
        {
            DataTable table = new DataTable();
            table.Columns.Add("AccountNo", typeof(String));
            table.Columns.Add("Member Name", typeof(String));

            foreach (DataGridViewRow rows in dataMember.Rows)
            {
                DataRow dr = table.NewRow();
                dr[0] = rows.Cells[0].Value.ToString();
                dr[1] = rows.Cells[1].Value.ToString();
                table.Rows.Add(dr);
            }

            DataRow newdr = table.NewRow();
            newdr[0] = row.Cells[0].Value.ToString();
            newdr[1] = row.Cells[1].Value.ToString();
            table.Rows.Add(newdr);

            dataMember.DataSource = table;
            dataDepositor.Rows.Remove(row);
        }
        
        public int getDepositorRowCount()
        {
            return this.dataDepositor.Rows.Count;
        }

        public DataGridViewRowCollection getDepositors()
        {
            return this.dataDepositor.Rows;
        }

        public void setComboSavingsType(int i)
        {
            this.comboAccountType.SelectedValue = i;
        }

        public void filterMember()
        {
            int i = 0;
            foreach (DataGridViewRow rows in dataMember.Rows)
            {
                dataMember.CurrentCell = null;
                dataMember.Rows[i].Visible = true;
                i++;
            }
            i = 0;
            foreach (DataGridViewRow rows in dataMember.Rows)
            {
                if (rows.Cells[1].Value.ToString().Contains(txtSearchMember.Text))
                {

                }
                else
                {
                    dataMember.CurrentCell = null;
                    dataMember.Rows[i].Visible = false;
                }
            }
            i++;
        }

        public String getSearch()
        {
            return this.txtSearchMember.Text;
        }

        public void initAccountType(DataSet ds)
        {
            this.comboAccountType.DataSource = ds.Tables[0];
            this.comboAccountType.DisplayMember = "SavingsType";
            this.comboAccountType.ValueMember = "TypeId";
            this.comboAccountType.SelectedIndex = -1;
        }

        public int getComboAccountType()
        {
            if (this.comboAccountType.SelectedIndex == -1)
            {
                return 0;
            }
            else
            {
                return int.Parse(this.comboAccountType.SelectedValue.ToString());
            }
        }

        public void setAccountTypeSelectedItemChanged(EventHandler e)
        {
            this.comboAccountType.SelectedIndexChanged += e;
        }

        public void setAccountHolder(String s)
        {
            this.txtAccountHolder.Text = s;
        }

        public int getAccountHolder()
        {
            return int.Parse(this.txtAccountHolder.Text.ToString());
        }

        public void setAccountNo(String s)
        {
            this.txtAccountNo.Text = s;
        }

        public String getAccountNo()
        {
            return this.txtAccountNo.Text;
        }

        public void disableInitialDeposit()
        {
            this.txtInitialDeposit.Enabled = false;
        }

        public double getInitialDeposit()
        {
            try
            {
                return double.Parse(this.txtInitialDeposit.Text.ToString());
            }
            catch (Exception) { return 0.00; }
        }

        public void setPassbookNo(String s)
        {
            this.txtPassbook.Text = s;
        }

        public int getPassbookNo()
        {
            return int.Parse(this.txtPassbook.Text.ToString());
        }

        public String getWithdrawMode()
        {
            if (radioAnd.Checked)
            {
                return "And";
            }
            else if (radioOr.Checked)
            {
                return "Or";
            }
            else
            {
                return String.Empty;
            }
        }

        public void enableWithdrawMode()
        {
            this.groupWithdrawMode.Enabled = true;
        }

        public void disableWithdrawMode()
        {
            this.groupWithdrawMode.Enabled = false;
        }

        public void reset(String accountNo, String passbookNo)
        {
            this.dataMember.DataSource = null;
            this.dataDepositor.DataSource = null;
            this.comboAccountType.SelectedIndex = -1;
            this.groupWithdrawMode.Enabled = false;
            this.radioAnd.Checked = false;
            this.radioOr.Checked = false;
            this.txtInitialDeposit.Clear();
            this.txtAccountNo.Text = accountNo;
            this.txtPassbook.Text = passbookNo;
            this.txtSearchMember.Clear();
        }

        public void setErrorAccountType()
        {
            this.lblAccountType.ForeColor = Color.Red;
        }

        public void setErrorDepositor()
        {
            this.lblDepositor.ForeColor = Color.Red;
        }

        public void setErrorWithdrawMode()
        {
            this.groupWithdrawMode.ForeColor = Color.Red;
        }

        public void setErrorInitialDeposit()
        {
            this.lblInitialDeposit.ForeColor = Color.Red;
        }

        public void clearErrors()
        {
            this.lblAccountType.ForeColor = SystemColors.ControlText;
            this.lblDepositor.ForeColor = SystemColors.ControlText;
            this.groupWithdrawMode.ForeColor = SystemColors.ControlText;
            this.lblInitialDeposit.ForeColor = SystemColors.ControlText;
        }

        private void txtAmount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            int length = this.txtInitialDeposit.Text.Length;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\b' && txtInitialDeposit.SelectionStart == this.txtInitialDeposit.Text.Length - 2)
            {
                this.txtInitialDeposit.SelectionStart = this.txtInitialDeposit.Text.Length - 3;
            }

            //if (e.KeyChar == '\b' && length % 4 == 0) 
            //{
            //  MessageBox.Show("hi");
            //this.txtMaxWith.SelectionStart = this.txtMaxWith.Text.Length-2;
            //} 

            if (Char.IsDigit(e.KeyChar) && txtInitialDeposit.Text.Length == 4)
            {
                this.txtInitialDeposit.SelectionStart = this.txtInitialDeposit.Text.Length - 3;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                this.txtInitialDeposit.Text = this.getInitialDeposit().ToString();
                this.txtInitialDeposit.SelectionStart = this.txtInitialDeposit.Text.Length - 2;
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

        private void txtInitialDeposit_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtInitialDeposit.SelectionStart;
            this.txtInitialDeposit.Text = this.getInitialDeposit().ToString("N2", CultureInfo.InvariantCulture);
            if (selectionStart == txtInitialDeposit.Text.Length - 2)
            {
                this.txtInitialDeposit.SelectionStart = txtInitialDeposit.Text.Length - 2;
            }
            else if (selectionStart == txtInitialDeposit.Text.Length - 1)
            {
                this.txtInitialDeposit.SelectionStart = txtInitialDeposit.Text.Length - 1;
            }
            else this.txtInitialDeposit.SelectionStart = txtInitialDeposit.Text.Length - 3;
        }
    }
}
