using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Maintenance.Controller
{
    class TimeDepositInterestRatesController
    {
        Main.Logger logger = new Main.Logger();
        Maintenance.Model.TimeDepositInterestModel timeDepositModel;
        Maintenance.View.TimeDepositInterestRates interestRates;
        String errorMessage = String.Empty;
        Boolean isAdd = false;
        int InterestId = 0;

        public TimeDepositInterestRatesController(Maintenance.Model.TimeDepositInterestModel timeDepositModel, Maintenance.View.TimeDepositInterestRates interestRates, SavingsMenu savingsMenu)
        {
            this.timeDepositModel = timeDepositModel;
            this.interestRates = interestRates;
            this.interestRates.setBtnAddEventHandler(this.btnAdd);
            this.interestRates.setBtnCancelEventHandler(this.btnCancel);
            this.interestRates.setBtnEditEventHandler(this.btnEdit);
            this.interestRates.setBtnSaveEventHandler(this.btnSave);
            this.interestRates.txtSearch_TextChanged(this.txtSearch);
            this.interestRates.interestRatesGrid(this.timeDepositModel.selectTimeDepositInterest());
            this.interestRates.removeColumns();
            this.interestRates.disableFunction();
            this.interestRates.MdiParent = savingsMenu;
            InterestId = 0;
            this.interestRates.Show();
        }
        
        public void btnAdd(object args, EventArgs e)
        {
            this.interestRates.enableFunction();
            this.interestRates.setStatus();
            isAdd = true;
            InterestId = 0;
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.interestRates.disableFunction();
            this.interestRates.clearError();
            this.errorMessage = String.Empty;
            isAdd = false;
            InterestId = 0;
        }

        public void btnEdit(object args, EventArgs e)
        {
            DataGridViewRow selectedData = this.interestRates.getSelected();
            if (selectedData == null)
            {
                MessageBox.Show("No Row Selected.", "Interest Rates", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                isAdd = false;
                this.interestRates.enableFunction();
                this.InterestId = int.Parse(selectedData.Cells["InterestId"].Value.ToString());
                this.interestRates.setNoDays(int.Parse(selectedData.Cells["No of Days"].Value.ToString()));
                this.interestRates.setInterestRates(selectedData.Cells["Interest Rate"].Value.ToString());
                this.interestRates.setMinimumBalance(selectedData.Cells["Minimum Range"].Value.ToString());
                this.interestRates.setMaximumBalance(selectedData.Cells["Maximum Range"].Value.ToString());
                if (bool.Parse(selectedData.Cells["Status"].Value.ToString()))
                {
                    this.interestRates.setStatus();
                }
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            this.errorMessage = String.Empty;
            this.interestRates.clearError();
            Boolean checkDays = false;
            Boolean checkInterestRate = false;
            Boolean checkMinimumBalance = false;
            Boolean checkMaximumBalance = false;
            Boolean checkBalanceRange = false;
            if (isAdd)
            {
                errorMessage += "Add Failed." + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                errorMessage += "Update Failed." + Environment.NewLine + Environment.NewLine;
            }
            try
            {
                if (this.interestRates.getNoDays() != 0)
                {
                    this.timeDepositModel.NoDays = this.interestRates.getNoDays();
                    checkDays = true;
                }
                else
                {
                    errorMessage += "Please Specify - No of Days" + Environment.NewLine;
                    this.interestRates.setErrorNumDays();
                    checkDays = false;
                }
                if (this.interestRates.getInterestRates() != 0)
                {
                    if (isAdd)
                    {
                        if (this.timeDepositModel.checkInterestRate(this.interestRates.getInterestRates(), this.interestRates.getNoDays()) > 0)
                        {
                            errorMessage += "Interest Rate Already Exists for this No Of Days." + Environment.NewLine;
                            this.interestRates.setErrorInterestRate();
                            checkInterestRate = false;
                        }
                        else
                        {
                            this.timeDepositModel.InterestRate = this.interestRates.getInterestRates();
                            checkInterestRate = true;
                        }
                    }
                    else
                    {
                        if (this.timeDepositModel.checkInterestRate(this.interestRates.getInterestRates(), this.InterestId, this.interestRates.getNoDays()) > 0)
                        {
                            errorMessage += "Interest Rate Already Exists for this No Of Days." + Environment.NewLine;
                            this.interestRates.setErrorInterestRate();
                            checkInterestRate = false;
                        }
                        else
                        {
                            this.timeDepositModel.InterestRate = this.interestRates.getInterestRates();
                            checkInterestRate = true;
                        }
                    }
                }
                else
                {
                    errorMessage += "Please Specify Interest Rate." + Environment.NewLine;
                    this.interestRates.setErrorInterestRate();
                    checkInterestRate = false;
                }
                if (this.interestRates.getMinimumBalance() != 0)
                {
                    this.timeDepositModel.MinimumRange = this.interestRates.getMinimumBalance();
                    checkMinimumBalance = true;
                }
                else
                {
                    errorMessage += "Please Specify Amount - Minimum Balance Range." + Environment.NewLine;
                    this.interestRates.setErrorMinimum();
                    checkMinimumBalance = false;
                }
                if (this.interestRates.getMaximumBalance() > 0)
                {
                    if (this.interestRates.getMaximumBalance() <= this.interestRates.getMinimumBalance())
                    {
                        errorMessage += "Maximum Balance Range Must Be Greater Than Minimum Balance Range." + Environment.NewLine;
                        this.interestRates.setErrorMaximum();
                        checkMaximumBalance = false;
                    }
                    else
                    {
                        this.timeDepositModel.MaximumRange = this.interestRates.getMaximumBalance();
                        checkMaximumBalance = true;
                    }
                }
                else
                {
                    errorMessage += "Please Specify Amount - Maximum Balance Range." + Environment.NewLine;
                    this.interestRates.setErrorMaximum();
                    checkMaximumBalance = false;
                }
                if (isAdd)
                {
                    if (this.timeDepositModel.checkOverlap(this.interestRates.getMinimumBalance(), this.interestRates.getMaximumBalance(), this.interestRates.getNoDays()) > 0)
                    {
                        errorMessage += "Balance Range Overlap Detected." + Environment.NewLine;
                        checkBalanceRange = false;
                    }
                    else
                    {
                        checkBalanceRange = true;
                    }
                }
                else
                {
                    if (this.timeDepositModel.checkOverlap(this.interestRates.getMinimumBalance(), this.interestRates.getMaximumBalance(), this.InterestId, this.interestRates.getNoDays()) > 0)
                    {
                        errorMessage += "Balance Range Overlap Detected." + Environment.NewLine;
                        checkBalanceRange = false;
                    }
                    else
                    {
                        checkBalanceRange = true;
                    }
                }
                if (this.interestRates.getStatus())
                {
                    this.timeDepositModel.Status = 1;
                }
                else
                {
                    this.timeDepositModel.Status = 0;
                }
                if (checkDays && checkInterestRate && checkMinimumBalance && checkMaximumBalance && checkBalanceRange)
                {
                    if (isAdd)
                    {
                        if (this.timeDepositModel.insertTimeDepositInterest() == 1)
                        {
                            MessageBox.Show("Add Success.", "Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.interestRates.interestRatesGrid(this.timeDepositModel.selectTimeDepositInterest(this.interestRates.getSearch()));
                            this.interestRates.removeColumns();
                            this.interestRates.clearError();
                            this.interestRates.disableFunction();
                            execLogger("Add");
                            isAdd = false;
                            InterestId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Add Failed.", "Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (this.timeDepositModel.updateTimeDepositInterest(this.InterestId) == 1)
                        {
                            MessageBox.Show("Update Success.", "Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.interestRates.interestRatesGrid(this.timeDepositModel.selectTimeDepositInterest(this.interestRates.getSearch()));
                            this.interestRates.removeColumns();
                            this.interestRates.clearError();
                            this.interestRates.disableFunction();
                            execLogger("Update");
                            isAdd = false;
                            InterestId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Update Failed.", "Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage, "Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                this.interestRates.clearError();
                this.interestRates.setErrorInterestRate();
                this.interestRates.setErrorMinimum();
                this.interestRates.setErrorMaximum();
                MessageBox.Show(this.errorMessage + "Invalid Input!" + Environment.NewLine + "Check Red Labels.", "Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch(object sender, EventArgs e)
        {
            this.interestRates.interestRatesGrid(this.timeDepositModel.selectTimeDepositInterest(this.interestRates.getSearch()));
            this.interestRates.removeColumns();
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Maintenance - Time Deposit Terms and Rates";
            logger.Activity = ModuleActivity;
            if (logger.insertLog() > 0)
            {
                Console.WriteLine("Logged");
            }
            else
            {
                Console.WriteLine("Not Logged");
            }
        }
    }
}
