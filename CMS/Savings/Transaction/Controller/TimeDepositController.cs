using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.Controller
{
    class TimeDepositController
    {
        Model.TimeDepositModel timeDepositModel;
        View.TimeDepositApplication timeDeposit;

        public TimeDepositController(Model.TimeDepositModel timeDepositModel, View.TimeDepositApplication timeDeposit, SavingsMenu savingsMenu)
        {
            this.timeDepositModel = timeDepositModel;
            this.timeDeposit = timeDeposit;
            this.timeDeposit.initAccountType(this.timeDepositModel.selectTimeDeposit());
            this.timeDeposit.setDataMember(this.timeDepositModel.selectMember());
            this.timeDeposit.txtAccountNo_TextChanged(this.txtAccountNo);
            this.timeDeposit.txtMemberName_TextChanged(this.txtMemberName);
            this.timeDeposit.numDuration_ValueChanged(this.numDuration);
            this.timeDeposit.comboDuration_SelectedIndexChanged(this.comboDuration);
            this.timeDeposit.setBtnClearEventHandler(this.btnClear);
            this.timeDeposit.setBtnSaveEventHandler(this.btnSave);
            this.timeDeposit.MdiParent = savingsMenu;
            this.timeDeposit.Show();
        }

        public void txtAccountNo(object sender, EventArgs e)
        {
            this.timeDeposit.setDataMember(this.timeDepositModel.searchMemberAccount(this.timeDeposit.getTextAccountNo()));
        }

        public void txtMemberName(object sender, EventArgs e)
        {
            this.timeDeposit.setDataMember(this.timeDepositModel.searchMemberName(this.timeDeposit.getTextMemberName()));
        }

        public void numDuration(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            if (this.timeDeposit.getComboDuration() == "Day/s")
            {
                today = today.AddDays(this.timeDeposit.getNumDuration());
                this.timeDeposit.setMaturityDate(today);
            }
            else if (this.timeDeposit.getComboDuration() == "Week/s")
            {
                today = today.AddDays(this.timeDeposit.getNumDuration() * 7);
                this.timeDeposit.setMaturityDate(today);
            }
            else if (this.timeDeposit.getComboDuration() == "Month/s")
            {
                today = today.AddMonths(this.timeDeposit.getNumDuration());
                this.timeDeposit.setMaturityDate(today);
            }
            else if (this.timeDeposit.getComboDuration() == "Year/s")
            {
                today = today.AddYears(this.timeDeposit.getNumDuration());
                this.timeDeposit.setMaturityDate(today);
            }
        }

        public void comboDuration(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            if (this.timeDeposit.getComboDuration() == "Day/s")
            {
                today = today.AddDays(this.timeDeposit.getNumDuration());
                this.timeDeposit.setMaturityDate(today);
            }
            else if (this.timeDeposit.getComboDuration() == "Week/s")
            {
                today = today.AddDays(this.timeDeposit.getNumDuration() * 7);
                this.timeDeposit.setMaturityDate(today);
            }
            else if (this.timeDeposit.getComboDuration() == "Month/s")
            {
                today = today.AddMonths(this.timeDeposit.getNumDuration());
                this.timeDeposit.setMaturityDate(today);
            }
            else if (this.timeDeposit.getComboDuration() == "Year/s")
            {
                today = today.AddYears(this.timeDeposit.getNumDuration());
                this.timeDeposit.setMaturityDate(today);
            }
        }

        public void btnClear(object sender, EventArgs e)
        {
            this.timeDeposit.reset();
            this.timeDeposit.setDataMember(this.timeDepositModel.selectMember());
        }

        public void btnSave(object sender, EventArgs e)
        {
            this.timeDeposit.clearErrors();
            String errorMessage = String.Empty;
            Boolean checkAccountType = false;
            Boolean checkAmount = false;
            Boolean checkDuration = false;
            Boolean checkAccount = false;
            if (this.timeDeposit.getComboAccountType() == 0)
            {
                errorMessage += "Please Specify Account Type." + Environment.NewLine;
                this.timeDeposit.setErrorAccountType();
                checkAccountType = false;
            }
            else
            {
                this.timeDepositModel.AccountTypeId = this.timeDeposit.getComboAccountType();
                checkAccountType = true;
            }
            try
            {
                if (this.timeDeposit.getAmount() < this.timeDepositModel.selectInitialDeposit(this.timeDeposit.getComboAccountType()))
                {
                    errorMessage += "Deposit Amount Cannot be Less Than Initial Deposit Specified for this Account Type." + Environment.NewLine;
                    this.timeDeposit.setErrorAmount();
                    checkAmount = false;
                }
                else
                {
                    this.timeDepositModel.Amount = this.timeDeposit.getAmount();
                    checkAmount = true;
                }
            }
            catch (Exception)
            {
                errorMessage += "Invalid Amount." + Environment.NewLine;
                this.timeDeposit.setErrorAmount();
                checkAmount= false;
            }
            if (this.timeDeposit.getMaturityDate() == DateTime.Today.ToShortDateString())
            {
                errorMessage += "Please Specify Duration." + Environment.NewLine;
                this.timeDeposit.setErrorDuration();
                checkDuration = false;
            }
            else
            {
                this.timeDepositModel.Maturity = this.timeDeposit.getMaturityDate();
                checkDuration = true;
            }
            if (this.timeDeposit.getSelected() == null)
            {
                errorMessage += "No Selected Member." + Environment.NewLine;
                checkAccount = false;
            }
            else
            {
                DataGridViewRow row = this.timeDeposit.getSelected();
                this.timeDepositModel.AccountNo = row.Cells[0].Value.ToString();
                checkAccount = true;
            }
            if(checkAccount && checkAccountType && checkAmount && checkDuration)
            {
                this.timeDepositModel.CertificateNo = "TD-" + this.timeDepositModel.generateCertificateNo().ToString("D5");
                if(this.timeDepositModel.insertSavingsTransaction() == 1)
                {
                    MessageBox.Show("Transaction Success.", "Time Deposit Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.timeDeposit.reset();
                    this.timeDeposit.setDataMember(this.timeDepositModel.selectMember());
                }
                else
                {
                    MessageBox.Show("Transaction Failed.", "Time Deposit Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Transaction Failed." + Environment.NewLine + Environment.NewLine + errorMessage, "Time Deposit Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
