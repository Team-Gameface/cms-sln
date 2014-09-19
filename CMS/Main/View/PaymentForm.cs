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

        double totalInterest = 0, totalPenalty = 0;
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
            this.setTotalLoanBalance(0);
            this.setTotalPenalties(0);
            this.setTotalInterest(0);
            this.setSLTotalLoanBalance(0);
            this.setSLTotalPenalties(0);
            this.setSLTotalInterest(0);
            this.lblTLB.Visible = true;
            this.lblSL.Visible = true;
            this.lblTotalLoanBalance.Visible = true;
            this.lblSLTotalLoanBalance.Visible = true;
            this.lblTP.Visible = true;
            this.lblTotalPenalties.Visible = true;
            this.lblSLTotalPenalties.Visible = true;
            this.lblTI.Visible = true;
            this.lblTotalInterest.Visible = true;
            this.lblSLTotalInterest.Visible = true;
            this.lblNTLB.Visible = true;
            this.lblNetTotalLoanBalance.Visible = true;
            this.lblSLNetTotalLoanBalance.Visible = true;
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
            this.chbDeductToNext.Enabled = false;
            this.rbAddToSavings.Enabled = false;
            this.rbAddToShareCapital.Enabled = false;
            this.rbNone.Enabled = false;
            this.chbDeductToNext.Checked = false;
            this.rbAddToSavings.Checked = false;
            this.rbAddToShareCapital.Checked = false;
            this.rbNone.Checked = false;
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
                this.lblSL.Visible = false;
                this.lblTLB.Visible = false;
                this.lblTotalLoanBalance.Visible = false;
                this.lblTP.Visible = false;
                this.lblTotalPenalties.Visible = false;
                this.lblTI.Visible = false;
                this.lblTotalInterest.Visible = false;
                this.lblNTLB.Visible = false;
                this.lblNetTotalLoanBalance.Visible = false;
                this.lblSLTotalLoanBalance.Visible = false;
                this.lblSLTotalPenalties.Visible = false;
                this.lblSLTotalInterest.Visible = false;
                this.lblSLNetTotalLoanBalance.Visible = false;
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
            this.dataAmortization.Columns[2].DefaultCellStyle.Format = "c";
            CultureInfo ph = new CultureInfo("en-PH");
            this.dataAmortization.Columns[2].DefaultCellStyle.FormatProvider = ph;
            this.dataAmortization.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataAmortization.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataAmortization.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataAmortization.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void classGridAmortization2(DataSet ds)
        {
            this.dataAmortization2.DataSource = ds.Tables[0];
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

        public void setSLTotalLoanBalance(double d)
        {
            this.lblSLTotalLoanBalance.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public double getSLTotalLoanBalance() 
        {
            return double.Parse(this.lblSLTotalLoanBalance.Text);
        }

        public void setTotalPenalties(double d)
        {
            this.lblTotalPenalties.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public void setSLTotalPenalties(double d)
        {
            this.lblSLTotalPenalties.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public double getSLTotalPenalties()
        {
            return double.Parse(this.lblSLTotalPenalties.Text);
        }

        public void setTotalInterest(double d)
        {
            this.lblTotalInterest.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public void setSLTotalInterest(double d)
        {
            this.lblSLTotalInterest.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public double getSLTotalInterest()
        {
            return double.Parse(this.lblSLTotalInterest.Text);
        }

        public double getChange() 
        {
            String change = this.txtAMChange.Text;
            String newChange = change.Substring(1);
            return double.Parse(newChange);
        }

        public void setNetTotalLoanBalance(double d)
        {
            CultureInfo ph = new CultureInfo("en-PH");
            this.lblNetTotalLoanBalance.Text = d.ToString("c", ph);
        }

        public void setSLNetTotalLoanBalance(double d)
        {
            CultureInfo ph = new CultureInfo("en-PH");
            this.lblSLNetTotalLoanBalance.Text = d.ToString("c", ph);
        }

        public void setTotalAmount(double totalAmount)
        {
            CultureInfo ph = new CultureInfo("en-PH");
            this.txtTotalAmount.Text = totalAmount.ToString("c",ph);
        }

        public double getTotalAmount() {
            String stotalAmount = this.txtTotalAmount.Text;
            return double.Parse(stotalAmount.ToString(),NumberStyles.Currency);  
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
                    double totalAmount = double.Parse(stotalAmount.ToString(),NumberStyles.Currency);
                    
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

        public double getAmountPenaltyList(int i) 
        {
            double amount = 0;
            String[] penaltyList = this.txtPenaltyList.Lines;
            for (int line = 0; line < penaltyList.Count(); line++) 
            {
                if (penaltyList[line].Contains("Amortization #"+i)) 
                {
                    String[] lineSplit = penaltyList[line].Split(' ');
                    amount += double.Parse(lineSplit[4]);
                }
            }

            return amount;
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

        public Boolean getDeductToNextAmortization()
        {
            if (this.chbDeductToNext.Checked == true) { return true; }
            else return false;
        }

        public Boolean getAddToSavings()
        {
            if (this.rbAddToSavings.Checked == true) { return true; }
            else return false;
        }

        public Boolean getAddToShareCapital()
        {
            if (this.rbAddToShareCapital.Checked == true) { return true; }
            else return false;
        }


        public void setLoanAmortizationAmount(double d) 
        {
            double d1 = this.getLoanAmortizationAmount();
            d1 += d;
            this.txtAmountDue.Text = d1.ToString("N", CultureInfo.InvariantCulture);
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
            this.txtPenalty.Text = d.ToString("N", CultureInfo.InvariantCulture);
        }

        public double getPenalty() 
        {
            try
            {
                return double.Parse(this.txtPenalty.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getAmortizationChange() 
        {
            return double.Parse(this.txtAMChange.Text,NumberStyles.Currency);
        }

        public double getAmountTendered() 
        {
            return double.Parse(this.txtAMAmountTendered.Text);
        }

        public void setInterest(double d)
        {
            this.txtInterest.Text = d.ToString("N", CultureInfo.InvariantCulture);
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
            this.txtTotalAmortization.Text = d.ToString("N", CultureInfo.InvariantCulture);
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
                totalInterest = 0;
                totalPenalty = 0;
                int row = this.dataLoan.SelectedRows[0].Index;
                this.addItemsAtTypeOfLoan(this.paymentModel.selectLoanType(this.dataLoan[0, row].Value.ToString()));
                this.cbLoanType.Enabled = true;
                this.cbLoanType.SelectedIndex = -1;
                this.dataLoan.Enabled = false;
                this.setCBLoanTypeSelectionChanged(this.getCBLoanTypeIndex);
                DataGridViewRow selectedData = this.getSelectedLoan();
                String accountNo = selectedData.Cells["Account No."].Value.ToString();

                this.setTotalLoanBalance(this.paymentModel.selectTotalLoanBalance(accountNo));
                DataSet ds = this.paymentModel.selectLoanType2(accountNo);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    this.classGridAmortization2(this.paymentModel.selectAmortizations(accountNo, Convert.ToInt32(ds.Tables[0].Rows[i][0]), Convert.ToString(ds.Tables[0].Rows[i][1])));
                    foreach (DataGridViewRow rows in this.dataAmortization2.Rows)
                    {
                        rows.Selected = true;
                        (rows.Cells[0] as DataGridViewCheckBoxCell).Value = true;
                        rows.Selected = false;
                    }
                    try
                    {
                        if (this.paymentModel.selectIfLoanIsAmnestized2(Convert.ToInt32(this.dataAmortization2.Rows[0].Cells[4].Value)) == true)
                        {
                            String[] penInt = this.paymentModel.selectCurrentLoanBalance(Convert.ToInt32(this.dataAmortization2.Rows[0].Cells[4].Value)).Split(' ');
                            totalPenalty += Convert.ToDouble(penInt[0]);
                            totalInterest += Convert.ToDouble(penInt[1]);
                        }
                        else
                        {
                            this.showPenaltiesAndInterests(Convert.ToInt32(ds.Tables[0].Rows[i][0]));
                        }
                    }
                    catch (Exception) 
                    {
                        totalPenalty += this.paymentModel.selectPenaltyByAccountNo(accountNo);
                        totalInterest += this.paymentModel.selectInterestByAccountNo(accountNo);
                    }
                    this.dataAmortization2.DataSource = null;
                }
                this.setTotalPenalties(totalPenalty);
                this.setTotalInterest(totalInterest);
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
                if (parts.Length > 1 || tb.TextLength > 9)
                {
                    if (parts[0].Length > 10 || parts[1].Length > 2 || parts.Length > 2)
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
                            int i = this.dataAmortization.Rows.Count;
                            if (amountPaid != totalAmount)
                            {
                                if (i != 0 && i!=1) { this.chbDeductToNext.Enabled = true; }
                                this.rbAddToShareCapital.Enabled = true; this.rbAddToSavings.Enabled = true; this.rbNone.Enabled = true;
                            }
                        }
                        else
                        {
                            if (this.getIfPenaltyListIsEmpty("Amnestied") == false) 
                            {
                                MessageBox.Show("Insufficient amount.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                double change = 0.00;
                                CultureInfo ph = new CultureInfo("en-PH");
                                this.txtAMChange.Text = change.ToString("c", ph);
                                this.btnSave.Enabled = true;
                            }
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
            totalPenalty = 0;
            totalInterest = 0;
            this.setSLTotalLoanBalance(0);
            this.setSLTotalInterest(0);
            this.setSLTotalPenalties(0);
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
                    try
                    {
                        this.classGridAmortization(this.paymentModel.selectAmortizations(this.dataLoan[0, row].Value.ToString(), this.getTypeOfLoan(), this.getLoanMaturityDate()));
                        this.clearSelectionDataAmortization();
                        this.setSLTotalLoanBalance(this.paymentModel.selectRemainingBalance(Convert.ToInt32(this.dataAmortization.Rows[0].Cells[4].Value)));
                        this.classGridAmortization2(this.paymentModel.selectAmortizations(this.dataLoan[0, row].Value.ToString(), this.getTypeOfLoan(), this.getLoanMaturityDate()));
                        foreach (DataGridViewRow rows in this.dataAmortization2.Rows)
                        {
                            rows.Selected = true;
                            (rows.Cells[0] as DataGridViewCheckBoxCell).Value = true;
                            rows.Selected = false;
                        }
                        try
                        {
                            if (this.paymentModel.selectIfLoanIsAmnestized2(Convert.ToInt32(this.dataAmortization2.Rows[0].Cells[4].Value)) == true)
                            {
                                String[] penInt = this.paymentModel.selectCurrentLoanBalance(Convert.ToInt32(this.dataAmortization2.Rows[0].Cells[4])).Split(' ');
                                totalPenalty += Convert.ToDouble(penInt[0]);
                                totalInterest += Convert.ToDouble(penInt[1]);
                            }
                            else
                            {
                                this.showPenaltiesAndInterests(this.getTypeOfLoan());
                            }
                        }
                        catch (Exception)
                        {
                            totalPenalty += this.paymentModel.selectPenaltyByAccountNo(this.dataLoan[0, row].Value.ToString());
                            totalInterest += this.paymentModel.selectInterestByAccountNo(this.dataLoan[0, row].Value.ToString());
                        }
                        this.dataAmortization2.DataSource = null;
                        this.setSLTotalInterest(totalInterest);
                        this.setSLTotalPenalties(totalPenalty);
                    }
                    catch (Exception) 
                    {
                        DataGridViewRow selectedData = this.getSelectedLoan();
                        String accountNo = selectedData.Cells["Account No."].Value.ToString();
                        this.setSLTotalLoanBalance(this.paymentModel.selectRemainingBalanceWithout(accountNo, this.getLoanMaturityDate(), this.getTypeOfLoan()));
                        this.setPenaltyList("");

                        double lastPenalty = this.paymentModel.selectLastPenaltyWithoutApplicationId(accountNo, this.getTypeOfLoan(), this.getLoanMaturityDate());
                        int appId = this.paymentModel.selectApplicationId(accountNo, this.getTypeOfLoan(), this.getLoanMaturityDate());
                        if (lastPenalty != 0)
                        {
                            this.setPenaltyList("PENALTIES:");
                            DataSet penaltySet = this.paymentModel.selectAmortizationWithPenaltyWithoutApplicationId(accountNo, this.getTypeOfLoan(), this.getLoanMaturityDate());
                            for (int ctr = 0; ctr < penaltySet.Tables[0].Rows.Count; ctr++)
                            {
                                int minAmoId = this.paymentModel.selectMinAmortId(appId);
                                int amoId = Convert.ToInt32(penaltySet.Tables[0].Rows[ctr][0]);
                                double penalty = this.paymentModel.selectAmortizationPenalty(amoId);
                                this.setPenaltyList("Amortization #" + (amoId-minAmoId+1) + " - Php " + penalty.ToString("N", CultureInfo.InvariantCulture));
                            }
                        }
                         
                        
                        this.setPenalty(this.paymentModel.selectRemainingPenalties(accountNo, this.getTypeOfLoan(), this.getLoanMaturityDate()));
                        this.setInterest(this.paymentModel.selectRemainingInterest(accountNo, this.getTypeOfLoan(), this.getLoanMaturityDate()));
                        this.setSLTotalInterest(this.getInterest());
                        this.setSLTotalPenalties(this.getPenalty());
                    }
                }
                else
                {
                    this.setPenaltyList("Amnestied");
                    this.chbPayAll.Enabled = false;
                    String[] money = this.paymentModel.selectCurrentLoanBalance(int.Parse(isAmnestized[1])).Split(' ');
                    double penalty = double.Parse(money[0]);
                    double interest = double.Parse(money[1]);
                    double loanBalance = double.Parse(money[2]) - penalty - interest;
                    
                    this.setSLTotalLoanBalance(loanBalance);
                    this.setSLTotalInterest(interest);
                    this.setSLTotalPenalties(penalty);

                    this.setLoanAmortizationAmount(loanBalance);
                    this.setInterest(interest);
                    this.setPenalty(penalty);

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

        public Boolean getPayAll() 
        {
            if (chbPayAll.Checked == true) { return true; }
            else { return false; }
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
                this.txtPenaltyList.Clear();
                this.setLoanAmortizationAmount(0);
                this.setPenalty(0);
                this.setInterest(0);
                this.txtAMAmountTendered.Clear();

                try
                {
                    int row = this.dataLoan.SelectedRows[0].Index;
                    this.dataAmortization.DataSource = null;
                    this.classGridAmortization(this.paymentModel.selectAmortizations(this.dataLoan[0, row].Value.ToString(), this.getTypeOfLoan(), this.getLoanMaturityDate()));
                    this.clearSelectionDataAmortization();
                }
                catch (Exception) { }
               
                /*foreach (DataGridViewRow rows in this.dataAmortization.Rows)
                {
                    rows.Selected = true;
                    (rows.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                    rows.Selected = false;
                }*/
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

        public void setTotalLoanBalance(double d) 
        {
            this.lblTotalLoanBalance.Text = d.ToString("N",CultureInfo.InvariantCulture);
        }

        public void txtInterest_TextChanged(EventHandler e)
        {
            this.txtInterest.TextChanged += e;
        }

        private void lblTotalLoanBalance_TextChanged(object sender, EventArgs e)
        {
            double d1 = 0, d2 = 0, d3 = 0;
            try
            {
               d1 = double.Parse(this.lblTotalLoanBalance.Text);
            }
            catch (Exception) { d1 = 0; }
            try{

                d2 = double.Parse(this.lblTotalPenalties.Text);
            }
            catch (Exception) { d2 = 0; }
            try{
                d3 = double.Parse(this.lblTotalInterest.Text);
            }
            catch (Exception) { d3 = 0; }

            this.setNetTotalLoanBalance(d1+d2+d3);
        }

        private void lblSLTotalLoanBalance_TextChanged(object sender, EventArgs e)
        {
            double d1 = 0, d2 = 0, d3 = 0;
            try
            {
                d1 = double.Parse(this.lblSLTotalLoanBalance.Text);
            }
            catch (Exception) { d1 = 0; }
            try
            {

                d2 = double.Parse(this.lblSLTotalPenalties.Text);
            }
            catch (Exception) { d2 = 0; }
            try
            {
                d3 = double.Parse(this.lblSLTotalInterest.Text);
            }
            catch (Exception) { d3 = 0; }

            this.setSLNetTotalLoanBalance(d1 + d2 + d3);
        }

        
        public void showPenaltiesAndInterests(int ltypeId) 
        {
            double lastInterest = this.paymentModel.selectLastInterest(Convert.ToInt32(this.dataAmortization2.Rows[0].Cells[4].Value));

            if (lastInterest != 0)
            {
                totalInterest = lastInterest;
            }


                Dictionary<String, int> listOfInterestDates = new Dictionary<String, int>();
                Dictionary<String, int> finalListOfInterestDates = new Dictionary<String, int>();
                int lappId = Convert.ToInt32(this.dataAmortization2.Rows[0].Cells[4].Value);
                String maturityDate = this.paymentModel.selectMaturityDate(lappId);
                String interestDate = (DateTime.Parse(maturityDate).AddDays(1)).ToString();
                String[] interest = this.paymentModel.selectInterestPerLoanType(ltypeId).Split(' ');

                if (DateTime.Now > DateTime.Parse(maturityDate) && interest[0] != "")
                {
                    String interestRateStatus = interest[0];
                    double interestRate = Convert.ToDouble(interest[1]);
                    String per = interest[2];

                    if (interestRateStatus == "%") { interestRate *= 0.01; }


                    if (per == "month")
                    {
                        for (String a = interestDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(1)).ToString())
                        {
                            listOfInterestDates.Add(a, 0);
                        }

                        foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                        {
                            String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                            String secondDate = DateTime.Parse(pair.Key).AddMonths(1).ToString();
                            int i = this.paymentModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

                            if (i > 0)
                            {
                                finalListOfInterestDates.Add(pair.Key, 0);
                            }
                        }

                        String last = String.Empty;
                        try
                        {
                            last = finalListOfInterestDates.Keys.Last();
                        }
                        catch (Exception) { last = maturityDate; }
                        foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                        {
                            if (DateTime.Parse(pair.Key) > DateTime.Parse(last))
                            {
                                double finalInterest = 0;
                                double grantedLoanAmount = this.paymentModel.selectGrantedLoanAmount(lappId);
                                String[] paymentDur = this.paymentModel.selectPaymentDurationPerApplication(lappId).Split(' ');
                                int pdValue = int.Parse(paymentDur[0]);
                                String pdStatus = paymentDur[1];
                                if (interestRateStatus == "%")
                                {
                                    if (pdStatus == "week/s")
                                    {
                                        finalInterest = grantedLoanAmount * ((interestRate / 4) * pdValue);
                                    }
                                    else if (pdStatus == "month/s")
                                    {
                                        finalInterest = grantedLoanAmount * interestRate * pdValue;
                                    }
                                    else if (pdStatus == "year/s")
                                    {
                                        finalInterest = grantedLoanAmount * interestRate * 12 * pdValue;
                                    }
                                }

                                else if (interestRateStatus == "Php")
                                {
                                    if (pdStatus == "week/s")
                                    {
                                        finalInterest = (interestRate / 4) * pdValue;
                                    }
                                    else if (pdStatus == "month/s")
                                    {
                                        finalInterest = interestRate * pdValue;
                                    }
                                    else if (pdStatus == "year/s")
                                    {
                                        finalInterest = interestRate * 12 * pdValue;
                                    }
                                }
                                totalInterest += finalInterest;
                            }
                        }

                    }

                    else if (per == "annum")
                    {
                        for (String a = interestDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddYears(1)).ToString())
                        {
                            listOfInterestDates.Add(a, 0);
                        }

                        foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                        {
                            String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                            String secondDate = DateTime.Parse(pair.Key).AddYears(1).ToString();
                            int i = this.paymentModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

                            if (i > 0)
                            {
                                finalListOfInterestDates.Add(pair.Key, 0);
                            }
                        }

                        String last = String.Empty;
                        try
                        {
                            last = finalListOfInterestDates.Keys.Last();
                        }
                        catch (Exception) { last = maturityDate; }
                        foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                        {
                            if (DateTime.Parse(pair.Key) > DateTime.Parse(last))
                            {
                                double finalInterest = 0;
                                double grantedLoanAmount = this.paymentModel.selectGrantedLoanAmount(lappId);
                                String[] paymentDur = this.paymentModel.selectPaymentDurationPerApplication(lappId).Split(' ');
                                int pdValue = int.Parse(paymentDur[0]);
                                String pdStatus = paymentDur[1];
                                if (interestRateStatus == "%")
                                {
                                    if (pdStatus == "week/s")
                                    {
                                        finalInterest = grantedLoanAmount * ((interestRate / 52) * pdValue);
                                    }
                                    else if (pdStatus == "month/s")
                                    {
                                        finalInterest = grantedLoanAmount * ((interestRate / 12) * pdValue);
                                    }
                                    else if (pdStatus == "year/s")
                                    {
                                        finalInterest = grantedLoanAmount * interestRate * pdValue;
                                    }
                                }
                                else if (interestRateStatus == "Php")
                                {
                                    if (pdStatus == "week/s")
                                    {
                                        finalInterest = (interestRate / 52) * pdValue;
                                    }
                                    else if (pdStatus == "month/s")
                                    {
                                        finalInterest = (interestRate / 12) * pdValue;
                                    }
                                    else if (pdStatus == "year/s")
                                    {
                                        finalInterest = interestRate * pdValue;
                                    }
                                }
                                totalInterest += finalInterest;
                            }
                        }
                    }
                }
            

            int appId = Convert.ToInt32(this.dataAmortization2.Rows[0].Cells[4].Value);
            double lastPenalty = this.paymentModel.selectLastPenalty(appId);
            if (lastPenalty != 0)
            {
                DataSet penaltySet = this.paymentModel.selectAmortizationWithPenalty(appId);
                for (int i = 0; i < penaltySet.Tables[0].Rows.Count; i++)
                {
                    int amoId = Convert.ToInt32(penaltySet.Tables[0].Rows[i][0]);
                    double penalty = this.paymentModel.selectAmortizationPenalty(amoId);
                }

                totalPenalty += lastPenalty;
            }

            foreach (DataGridViewRow rows in this.dataAmortization2.Rows)
            {
                DataGridViewCheckBoxCell chk1 = rows.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chk1.Value) == true)
                {

                    int loanApplicationId = Convert.ToInt32(rows.Cells[4].Value);
                    DataSet ds2 = this.paymentModel.selectMonthlyAmortization(loanApplicationId);
                    double monthlyAmortization = double.Parse(ds2.Tables[0].Rows[0][0].ToString());
                    String loanDurationStatus = ds2.Tables[0].Rows[0][1].ToString();
                    if (loanDurationStatus == "week/s") { monthlyAmortization *= 4; }
                    else if (loanDurationStatus == "year/s") { monthlyAmortization /= 12; }
                    double grantedLoanAmount = this.paymentModel.selectGrantedLoanAmount(loanApplicationId);
                    double remainingBalance = this.paymentModel.selectRemainingBalance(loanApplicationId);
                    String dueDate = rows.Cells[3].Value.ToString();

                    double amortizationAmount = double.Parse(rows.Cells[2].Value.ToString());
                    DataSet ds = this.paymentModel.selectPenaltiesPerLoanType(ltypeId);
                    if (ds.Tables[0].Rows.Count == 0 || DateTime.Parse(dueDate) > DateTime.Now)
                    {

                    }

                    else
                    {
                        double finalPenalty = 0;
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            double initialPenalty = 0;
                            String finalDate = String.Empty;
                            String penaltyName = ds.Tables[0].Rows[i][0].ToString();
                            int gracePeriod = int.Parse(ds.Tables[0].Rows[i][1].ToString());
                            double amount = double.Parse(ds.Tables[0].Rows[i][2].ToString());
                            String amountStatus = ds.Tables[0].Rows[i][3].ToString();
                            String deductTo = ds.Tables[0].Rows[i][4].ToString();
                            int duration = int.Parse(ds.Tables[0].Rows[i][5].ToString());
                            String durationStatus = ds.Tables[0].Rows[i][6].ToString();

                            if (durationStatus == "week/s") { duration = duration * 7; }
                            //TimeSpan diffDate = DateTime.Now.Subtract(DateTime.Parse(dueDate));
                            //int totalDays = (int)diffDate.TotalDays;
                            //totalDays -= gracePeriod;
                            String newDate = (DateTime.Parse(dueDate).AddDays(gracePeriod)).ToString();

                            if (amountStatus == "%") { amount = amount * 0.01; }

                            finalDate = DateTime.Parse(newDate).AddDays(1).ToString();

                            if (deductTo == "monthly amortization")
                            {
                                if (durationStatus == "month/s")
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                    {
                                        initialPenalty = amount * monthlyAmortization;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                                else
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                    {
                                        initialPenalty = amount * monthlyAmortization;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                            }
                            else if (deductTo == "remaining balance")
                            {
                                if (durationStatus == "month/s")
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                    {
                                        initialPenalty = amount * remainingBalance;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                                else
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                    {
                                        initialPenalty = amount * remainingBalance;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                            }
                            else if (deductTo == "granted loan amount")
                            {
                                if (durationStatus == "month/s")
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                    {
                                        initialPenalty = amount * grantedLoanAmount;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                                else
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                    {
                                        initialPenalty = amount * grantedLoanAmount;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                            }

                            else if (deductTo == String.Empty)
                            {
                                if (durationStatus == "month/s")
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                    {
                                        initialPenalty = amount;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                                else
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                    {
                                        initialPenalty = amount;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                            }
                        }//end for loop


                    }//end else
                }
            }

        }
    }
}
