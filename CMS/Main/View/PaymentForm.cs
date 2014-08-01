using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Globalization;


namespace CMS.Main.View
{
    public partial class PaymentForm : UserControl
    {
        public double totAmt = 0.00;
        Model.PaymentModel paymentModel = new Model.PaymentModel();

        public PaymentForm()
        {
            InitializeComponent();
            dataFee.ReadOnly = true;
            dataAddedFee.ReadOnly = true;
            dataSearch.ReadOnly = true;
            txtTotalAmount.ReadOnly = true;
            txtChange.ReadOnly = true;
            txtAmountDue.ReadOnly = true;
            txtPenalty.ReadOnly = true;
            txtInterest.ReadOnly = true;
            txtTotalAmortization.ReadOnly = true;
            txtPenalty.ReadOnly = true;
            groupMembership.Hide();
            groupUnpaidLoans.Hide();
            groupLoan.Hide();
            rbLoan.Checked = true;
           

        }

        public void noRowsSelected()
        {
            dataSearch.Rows[0].Selected = false;
        }

        public void noRowsLoanSelected()
        {
            dataLoan.Rows[0].Selected = false;
        }

        public void clearLoanFields()
        {
            this.btnMoveAll.Enabled = false;
            this.btnMoveBackAll.Enabled = false;
            this.btnMoveBackSelected.Enabled = false;
            this.btnMoveSelected.Enabled = false;
            this.btnSave.Enabled = false;
            this.dataSearch.ClearSelection();
            this.dataFee.DataSource = null;
            this.dataFee.Columns.Clear();
            this.dataAddedFee.Rows.Clear();
            this.txtAccountNo.Clear();
            this.txtMemberName.Clear();
            this.txtAmount.Clear();
            this.txtTotalAmount.Clear();
            this.txtChange.Clear();
            this.rbAccountNo.Checked = false;
            this.rbMemberName.Checked = false;
            this.txtAccountNo.Enabled = false;
            this.txtMemberName.Enabled = false;

            this.txtAMAmountTendered.Clear();
            this.txtAMChange.Clear();
            this.txtAmountDue.Text = "0.00";
            this.setPenalty(0.00);
            this.setInterest(0.00);
            this.setTotalAmortization(0.00);
            this.dataLoan.Enabled = true;
            this.dataAmortization.Enabled = true;
            this.txtPenaltyList.Clear();
            this.dataAmortization.DataSource = null;
            this.dataAmortization.Rows.Clear();
            this.dataAmortization.Columns.Clear();
            this.dataLoan.ClearSelection();
            this.cbLoanType.Enabled = false;
            this.cbLoanType.DataSource = null;
            this.chbPayAll.Checked = false;
            this.chbPayAll.Enabled = true;
        }

        public void clearTendered() 
        {
            this.btnSave.Enabled = false;
            this.txtAMAmountTendered.Clear();
            this.txtAMChange.Clear();
        }

        private void radioMembership_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMembership.Checked)
            {
                dataLoan.Hide();
                dataSearch.Show();
                groupMembership.Show();
                groupLoan.Hide();
                groupUnpaidLoans.Hide();
                this.classGridSearch(this.paymentModel.selectActiveMembershipUnpaid());
                if (this.paymentModel.checkEmpty != 0) this.noRowsSelected();
            }
        }

        private void radioLoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLoan.Checked)
            {
                dataLoan.Show();
                dataSearch.Hide();
                groupLoan.Show();
                groupUnpaidLoans.Show();
                groupMembership.Hide();
                this.clearLoanFields();

                this.classGridLoanSearch(this.paymentModel.selectActiveMemberWithLoan());
                if (this.paymentModel.checkEmpty != 0) this.dataLoan.ClearSelection();
            }
        }


        public void clearSelectionDataSearch() 
        {
            this.dataSearch.ClearSelection();
        }

        public void clearSelectionDataLoanSearch()
        {
            this.dataLoan.ClearSelection();
        }

        public void clearSelectionDataLoan() 
        {
            this.dataLoan.ClearSelection();
        }

        public void clearSelectionDataAmortization() 
        {
            this.dataAmortization.ClearSelection();
        }


        public void setBtnClearEventHandler(EventHandler e)
        {
            this.btnClear.Click += e;
        }

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void setBtnMoveAllEventHandler(EventHandler e)
        {
            this.btnMoveAll.Click += e;
        }

        public void setBtnMoveBackAllEventHandler(EventHandler e)
        {
            this.btnMoveBackAll.Click += e;
        }

        public void setBtnMoveBackSelectedEventHandler(EventHandler e)
        {
            this.btnMoveBackSelected.Click += e;
        }

        public void setBtnMoveSelectedEventHandler(EventHandler e)
        {
            this.btnMoveSelected.Click += e;
        }

        public void classGridSearch(DataSet ds)
        {
            this.dataSearch.DataSource = ds.Tables[0];
        }

        public void classGridLoanSearch(DataSet ds)
        {
            this.dataLoan.DataSource = ds.Tables[0];
        }

        public void classGridFee(DataSet ds)
        {
            this.dataFee.DataSource = ds.Tables[0];
        }

        public void classGridAddedFee(DataSet ds)
        {
            this.dataAddedFee.DataSource = ds.Tables[0];
        }

        public void classGridAmortization(DataSet ds)
        {
            this.dataAmortization.DataSource = ds.Tables[0];
            this.dataAmortization.Columns[4].Visible = false;
            this.dataAmortization.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataAmortization.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataAmortization.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataAmortization.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public DataGridViewRow getSelected()
        {
            return this.dataSearch.SelectedRows[0];
        }

        public DataGridViewRow getSelectedLoan()
        {
            return this.dataLoan.SelectedRows[0];
        }


        public bool checkIfEmpty() {

            Boolean check;
            if (this.dataSearch.Rows.Count == 0) { check = false; }
            else { check = true; }

            return check;
        }

        public void addItemsAtTypeOfLoan(DataSet ds)
        {
            this.cbLoanType.DataSource = ds.Tables[0];
            this.cbLoanType.ValueMember = "LoanTypeId";
            this.cbLoanType.DisplayMember = "LoanTypeName";
        }

        public int getTypeOfLoan()
        {
            DataRowView drv = (DataRowView)this.cbLoanType.SelectedItem;
            int valueOfItem = int.Parse(drv["LoanTypeId"].ToString());
            return valueOfItem;
        }

        public String getLoanMaturityDate()
        {
            DataRowView drv = (DataRowView)this.cbLoanType.SelectedItem;
            String[] value = drv["LoanTypeName"].ToString().Split('@');
            return value[1];
        }

        public int getCBLoanTypeIndex()
        {
            return this.cbLoanType.SelectedIndex;
        }

        public void moveBackSelectedRow() {
            this.txtChange.Clear();
            this.txtAmount.Clear();
            try
            {
                //dataFee.AllowUserToAddRows = true;
                DataTable table = new DataTable();
                DataRow row = table.NewRow();
                table.Columns.Add("Fee", typeof(String));
                table.Columns.Add("Amount", typeof(String));
                row[0] = dataAddedFee.SelectedRows[0].Cells[0].Value.ToString();
                row[1] = dataAddedFee.SelectedRows[0].Cells[1].Value.ToString();
                table.Rows.Add(row);

                foreach (DataGridViewRow rows in dataFee.Rows)
                {
                    row = table.NewRow();
                    row[0] = rows.Cells[0].Value.ToString();
                    row[1] = rows.Cells[1].Value.ToString();
                    table.Rows.Add(row);

                }

                dataFee.DataSource = table;
                totAmt -= double.Parse(dataAddedFee.SelectedRows[0].Cells[1].Value.ToString());
                this.setTotalAmount(totAmt);
                dataAddedFee.Rows.RemoveAt(dataAddedFee.SelectedRows[0].Index);
                dataFee.AllowUserToAddRows = false;
            }
            catch (Exception) { }
        }

        public void moveSelectedRow() {

            dataAddedFee.AllowUserToAddRows = true;
            try
            {
                dataAddedFee.Rows.Add(dataFee.SelectedRows[0].Cells[0].Value.ToString(), dataFee.SelectedRows[0].Cells[1].Value.ToString());
                totAmt += double.Parse(dataFee.SelectedRows[0].Cells[1].Value.ToString());
                this.setTotalAmount(totAmt);
                dataFee.Rows.RemoveAt(dataFee.SelectedRows[0].Index);
                dataAddedFee.AllowUserToAddRows = false;
            }
            catch (Exception) { }
        
        }

        public void moveBackAllRows() {
            this.txtChange.Clear();
            this.txtAmount.Clear();

            try
            {
                DataTable table = new DataTable();
                DataRow rows = table.NewRow();
                table.Columns.Add("Fee", typeof(String));
                table.Columns.Add("Amount", typeof(String));


                dataFee.AllowUserToAddRows = true;
                foreach (DataGridViewRow row in dataAddedFee.Rows)
                {
                    rows = table.NewRow();
                    rows[0] = row.Cells[0].Value.ToString();
                    rows[1] = row.Cells[1].Value.ToString();
                    table.Rows.Add(rows);
                    totAmt -= double.Parse(row.Cells[1].Value.ToString());
                    this.setTotalAmount(totAmt);
                }

                dataFee.AllowUserToAddRows = false;

                foreach (DataGridViewRow row in dataFee.Rows)
                {

                    rows = table.NewRow();
                    rows[0] = row.Cells[0].Value.ToString();
                    rows[1] = row.Cells[1].Value.ToString();
                    table.Rows.Add(rows);

                }


                dataFee.DataSource = table;

                if (dataAddedFee.DataSource != null)
                {
                    dataAddedFee.DataSource = null;
                }
                else
                {
                    dataAddedFee.Rows.Clear();
                }
                dataFee.AllowUserToAddRows = false;
            }
            catch (Exception) { }
        }

        public void moveAllRows()
        {


            dataAddedFee.AllowUserToAddRows = true;
            

            foreach (DataGridViewRow row in dataFee.Rows)
            {

                dataAddedFee.Rows.Add(row.Cells[0].Value.ToString(),row.Cells[1].Value.ToString());
                totAmt += double.Parse(row.Cells[1].Value.ToString());
                this.setTotalAmount(totAmt);
            }

            if (dataFee.DataSource != null)
            {
                dataFee.DataSource = null;
            }
            else
            {
                dataFee.Rows.Clear();
            }
            
            dataAddedFee.AllowUserToAddRows = false;

        }

        public ArrayList getFees() {

            ArrayList fees = new ArrayList();
            foreach (DataGridViewRow rows in dataAddedFee.Rows)
            {
                fees.Add(rows.Cells[0].Value.ToString());
            }

            return fees;
        }


        public int getTotalNoOfFees() {

            int count = 0;

            foreach (DataGridViewRow rows in dataFee.Rows)
            {
                count++;
            }
            return count;
        
        }

        public String getPaymentType()
        {

            String paymentType = String.Empty;
            if (rbMembership.Checked)
                paymentType = "Miscellaneous";
            if (rbLoan.Checked)
                paymentType="Loan";

            return paymentType;

        }

        public bool getSearchType()
        {
            bool check = false;

            if (rbAccountNo.Checked) check = false;
            if (rbMemberName.Checked) check = true;

            return check;

        }


        public void setTotalAmount(double totalAmount)
        {
            CultureInfo ph = new CultureInfo("en-PH");
            this.txtTotalAmount.Text = totalAmount.ToString("c",ph);
        }

        public double getTotalAmount() {
            String stotalAmount = this.txtTotalAmount.Text;
            return double.Parse(stotalAmount.Substring(1));  
        }



        public String getSearch()
        {
            String searchName = String.Empty;
            if (rbAccountNo.Checked == true)
            {
                searchName = this.txtAccountNo.Text;
            }

            else if (rbMemberName.Checked == true)
            {
                searchName = this.txtMemberName.Text;
            }


            return searchName;
        }

        private void rbAccountNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAccountNo.Checked == true) { txtAccountNo.Enabled = true; }
            else { txtAccountNo.Enabled = false; txtAccountNo.Clear(); }
        }

        private void rbMemberName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMemberName.Checked == true) { txtMemberName.Enabled = true; }
            else { txtMemberName.Enabled = false; txtMemberName.Clear(); }
        }

        private void dataSearch_SelectionChanged(object sender, EventArgs e)
        {



        }



        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.btnMoveAll.Enabled = true;
            this.btnMoveBackAll.Enabled = true;
            this.btnMoveBackSelected.Enabled = true;
            this.btnMoveSelected.Enabled = true;
            this.dataAddedFee.Rows.Clear();
            this.txtTotalAmount.Clear();
            totAmt = 0;
            DataGridViewRow selectedData = this.getSelected();
            String accountNo = selectedData.Cells["Account No."].Value.ToString();

     
                //String memberType = selectedData.Cells["Member Type"].Value.ToString();
                this.classGridFee(this.paymentModel.selectFeesPerMemberType(accountNo));
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
                    if (parts[0].Length > 6 || parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }


            if (e.KeyChar == (char)13)
            {
                try
                {
                    double amountPaid = double.Parse(this.txtAmount.Text);
                    String stotalAmount = this.txtTotalAmount.Text;
                    double totalAmount = double.Parse(stotalAmount.Substring(1));
                    
                    if (amountPaid >= totalAmount)
                    {
                        double change = amountPaid - totalAmount;
                        CultureInfo ph = new CultureInfo("en-PH");
                        this.txtChange.Text = change.ToString("c",ph);
                        this.btnSave.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Insufficient amount.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.btnSave.Enabled = false;
                        this.txtChange.Clear();
                        this.txtAmount.Clear();
                        this.txtAmount.Focus();
                    }
                }
                catch (FormatException) { MessageBox.Show("Please enter right amount.", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error); this.txtAmount.Clear(); }
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

        private void dataFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataAddedFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveSelected_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveAll_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveBackSelected_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveBackAll_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {

        }

        public void disableDataAmortization() 
        {
            this.dataAmortization.Enabled = false;
        }

        public double getTotalAmortization() 
        {
            return double.Parse(this.txtTotalAmortization.Text);
        }

        public void setPenaltyList(String s)
        {
            this.txtPenaltyList.AppendText(s);
            this.txtPenaltyList.AppendText(Environment.NewLine);
        }

        public void clearPenaltyList() 
        {
            this.txtPenaltyList.Text = String.Empty;
        }

        public Boolean getIfPenaltyListIsEmpty(String s) 
        {
            if (this.txtPenaltyList.Text.Contains(s)) { return false; }
            else return true;
        }


        public void setLoanAmortizationAmount(double d) 
        {
            double d1 = this.getLoanAmortizationAmount();
            d1 += d;
            this.txtAmountDue.Text = d1.ToString();
        }

        public void resetLoanAmortizationAmount() 
        {
            this.txtAmountDue.Text = 0 + "";
        }
        public double getLoanAmortizationAmount() 
        {
            try
            {
                return double.Parse(this.txtAmountDue.Text);
            }
            catch (Exception) { return 0; }
        }

        public void setPenalty(double d) 
        {
            this.txtPenalty.Text = d.ToString();
        }

        public double getPenalty() 
        {
            try
            {
                return double.Parse(this.txtPenalty.Text);
            }
            catch (Exception) { return 0; }
        }

        public void setInterest(double d)
        {
            this.txtInterest.Text = d.ToString();
        }

        public double getInterest()
        {
            try
            {
                return double.Parse(this.txtInterest.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getAmountDue()
        {
            try
            {
                return double.Parse(this.txtAmountDue.Text);
            }
            catch (Exception) { return 0; }
        }

        public void setTotalAmortization(double d) 
        {
            this.txtTotalAmortization.Text = d.ToString();
        }

        public void txtAmountDue_TextChanged(EventHandler e) 
        {
            this.txtAmountDue.TextChanged += e;
        }

        public void txtPenalty_TextChanged(EventHandler e)
        {
            this.txtPenalty.TextChanged += e;
        }


        public void dataAmortization_CellValueChanged(DataGridViewCellEventHandler e) 
        {
            this.dataAmortization.CellValueChanged += e;
        }        

        private void dataLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                int row = this.dataLoan.SelectedRows[0].Index;
                this.addItemsAtTypeOfLoan(this.paymentModel.selectLoanType(this.dataLoan[0, row].Value.ToString()));
                this.cbLoanType.Enabled = true;
                this.cbLoanType.SelectedIndex = -1;
                this.dataLoan.Enabled = false;
                this.setCBLoanTypeSelectionChanged(this.getCBLoanTypeIndex);
            }
        }


        private void txtAMAmountTendered_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (parts[0].Length > 6 || parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }


            if (e.KeyChar == (char)13)
            {
                int lastIndex = 0;
                Boolean check = false;

                foreach (DataGridViewRow rows in this.dataAmortization.Rows)
                {
                    if ((Boolean)(rows.Cells[0] as DataGridViewCheckBoxCell).Value == true)
                    {
                        lastIndex = rows.Index;
                    }
                }

                for (int i = 0; i < lastIndex; i++)
                {
                    if (Boolean.Parse((this.dataAmortization[0, i] as DataGridViewCheckBoxCell).Value.ToString()) == false)
                    {
                        check = true;
                    }
                }

                if (check) 
                {
                    MessageBox.Show("Please check/pay earlier due dates first.", "Loan Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtAMAmountTendered.Clear();
                }
                else
                {
                    try
                    {
                        double amountPaid = double.Parse(this.txtAMAmountTendered.Text);
                        double totalAmount = double.Parse(this.txtTotalAmortization.Text, NumberStyles.Currency);
                        if (amountPaid >= totalAmount)
                        {
                            double change = amountPaid - totalAmount;
                            CultureInfo ph = new CultureInfo("en-PH");
                            this.txtAMChange.Text = change.ToString("c", ph);
                            this.btnSave.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Insufficient amount.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.btnSave.Enabled = false;
                            this.txtAMChange.Clear();
                            this.txtAMAmountTendered.Clear();
                            this.txtAMAmountTendered.Focus();
                        }
                    }
                    catch (FormatException) { MessageBox.Show("Please enter right amount.", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error); this.txtAmount.Clear(); }
                }
            }
        }

        public void setCBLoanTypeSelectionChanged(EventHandler e) {

            this.cbLoanType.SelectedIndexChanged += e;
        }


        private void getCBLoanTypeIndex(object sender, EventArgs e) {

            this.dataAmortization.DataSource = null;
            this.txtAmountDue.Text = "0.00";
            this.txtPenalty.Text = "0.00";
            this.txtInterest.Text = "0.00";
            this.clearPenaltyList();
            this.chbPayAll.Checked = false;
            int i = this.getCBLoanTypeIndex();
            if (i == -1) { this.dataAmortization.DataSource = null; this.setLoanAmortizationAmount(0); }
            else
            {
                int row = this.dataLoan.SelectedRows[0].Index;
                String[] isAmnestized = this.paymentModel.selectifLoanIsAmnestized(this.dataLoan[0, row].Value.ToString(), this.getTypeOfLoan(), this.getLoanMaturityDate()).Split(' ');
                if (int.Parse(isAmnestized[0]) == 0)
                {
                    this.classGridAmortization(this.paymentModel.selectAmortizations(this.dataLoan[0, row].Value.ToString(), this.getTypeOfLoan(), this.getLoanMaturityDate()));
                    this.clearSelectionDataAmortization();
                }
                else
                {
                    this.setPenaltyList("Amnestied");
                    this.chbPayAll.Enabled = false;
                    this.setLoanAmortizationAmount(this.paymentModel.selectCurrentLoanBalance(int.Parse(isAmnestized[1])));

                    this.classGridAmortization(this.paymentModel.selectAmortizations(this.dataLoan[0, row].Value.ToString(), this.getTypeOfLoan(), this.getLoanMaturityDate()));
                    this.clearSelectionDataAmortization();

                    for (int j = 0; j < 5; j++)
                    {
                        dataAmortization.Columns[j].Visible = false;
                    }
                }
            } 
        
        }

        private void dataAmortization_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataAmortization.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void chbPayAll_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPenalty.Text = "0.00";
            this.txtInterest.Text = "0.00";
            if (chbPayAll.Checked == true)
            {
                foreach (DataGridViewRow rows in this.dataAmortization.Rows)
                {
                    rows.Selected = true;
                    (rows.Cells[0] as DataGridViewCheckBoxCell).Value = true;
                    rows.Selected = false;
                }
            }

            else 
            {
                foreach (DataGridViewRow rows in this.dataAmortization.Rows)
                {
                    rows.Selected = true;
                    (rows.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                    rows.Selected = false;
                }
            }
        }

        public void txtAccountNo_TextChanged(EventHandler e)
        {
            this.txtAccountNo.TextChanged += e;
        }

        public void txtMemberName_TextChanged(EventHandler e)
        {
            this.txtMemberName.TextChanged += e;
        }

        public void setLinkClosePaymentEventHandler(EventHandler e)
        {
            this.linkClosePayments.Click += e;
        }
    }
}
