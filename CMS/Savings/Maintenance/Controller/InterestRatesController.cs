using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Maintenance.Controller
{
    class InterestRatesController
    {
        Maintenance.Model.InterestRatesModel interestRatesModel;
        Maintenance.View.InterestRates interestRates;
        String errorMessage = String.Empty;
        Boolean isAdd = false;
        int accountType = 0;
        int InterestId = 0;

        public InterestRatesController(Maintenance.Model.InterestRatesModel interestRatesModel, Maintenance.View.InterestRates interestRates, SavingsMenu savingsMenu)
        {
            /*this.interestRatesModel = interestRatesModel;
            this.interestRates = interestRates;
            this.interestRates.setBtnAddEventHandler(this.btnAdd);
            this.interestRates.setBtnCancelEventHandler(this.btnCancel);
            this.interestRates.setBtnEditEventHandler(this.btnEdit);
            this.interestRates.setBtnSaveEventHandler(this.btnSave);
            this.interestRates.checkArchived_CheckStateChanged(this.checkArchived);
            this.interestRates.txtSearch_TextChanged(this.txtSearch);
            this.interestRates.interestRatesGrid(this.interestRatesModel.selectInterestRates());
            this.interestRates.removeColumns();
            this.interestRates.disableFunction();
            this.interestRates.MdiParent = savingsMenu;
            InterestId = 0;
            accountType = 0;
            this.interestRates.Show();*/
        }
        /*
        public void btnAdd(object args, EventArgs e)
        {
            this.interestRates.initAccountType(this.interestRatesModel.selectAccountTypes());
            this.interestRates.enableFunction();
            this.interestRates.setStatus();
            accountType = 0;
            isAdd = true;
            InterestId = 0;
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.interestRates.disableFunction();
            this.interestRates.clearError();
            this.errorMessage = String.Empty;
            isAdd = false;
            accountType = 0;
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
                this.interestRates.disableType();
                this.InterestId = int.Parse(selectedData.Cells["Interest Id"].Value.ToString());
                this.accountType = int.Parse(selectedData.Cells["Account Type Id"].Value.ToString());
                this.interestRates.setAccountType(selectedData.Cells["Account Type"].Value.ToString());
                String[] interestRate = selectedData.Cells["Interest Rate"].Value.ToString().Split(new char[] { '%', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                this.interestRates.setInterestRates(interestRate[0]);
                this.interestRates.setInterestRatesSchedule(interestRate[1]);
                String[] balanceRange = selectedData.Cells["Balance Range"].Value.ToString().Split('-');
                this.interestRates.setMinimumBalance(balanceRange[0]);
                if (double.Parse(balanceRange[1]) != 0)
                {
                    this.interestRates.setCheckMaxBal(balanceRange[1]);
                }
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
            Boolean checkAccountType = false;
            Boolean checkInterestRate = false;
            Boolean checkInterestRateSchedule = false;
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
                if (isAdd)
                {
                    if (this.interestRates.getAccountType() == 0)
                    {
                        errorMessage += "Please Specify Account Type." + Environment.NewLine;
                        this.interestRates.setErrorAccountType();
                        checkAccountType = false;
                    }
                    else
                    {
                        this.interestRatesModel.TypeId = this.interestRates.getAccountType();
                        checkAccountType = true;
                    }
                }
                else
                {
                    checkAccountType = true;
                }
                if (this.interestRates.getInterestRates() != 0)
                {
                    if (isAdd)
                    {
                        if (this.interestRatesModel.checkInterest(this.interestRates.getAccountType(), this.interestRates.getInterestRates(), 0) > 0)
                        {
                            errorMessage += "Interest Rate Already Exist For This Account Type." + Environment.NewLine;
                            this.interestRates.setErrorInterestRate();
                            checkInterestRate = false;
                        }
                        else
                        {
                            this.interestRatesModel.InterestRate = this.interestRates.getInterestRates();
                            checkInterestRate = true;
                        }
                    }
                    else
                    {
                        if (this.interestRatesModel.checkInterest(this.accountType, this.interestRates.getInterestRates(), this.InterestId) > 0)
                        {
                            errorMessage += "Interest Rate Already Exist For This Account Type." + Environment.NewLine;
                            this.interestRates.setErrorInterestRate();
                            checkInterestRate = false;
                        }
                        else
                        {
                            this.interestRatesModel.InterestRate = this.interestRates.getInterestRates();
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
                if (this.interestRates.getInterestRatesSchedule() == String.Empty)
                {
                    errorMessage += "Please Specify Interest Rate Schedule." + Environment.NewLine;
                    this.interestRates.setErrorPer();
                    checkInterestRateSchedule = false;
                }
                else
                {
                    this.interestRatesModel.Per = this.interestRates.getInterestRatesSchedule();
                    checkInterestRateSchedule = true;
                }
                if (this.interestRates.getMinimumBalance() != 0)
                {
                    this.interestRatesModel.MinRange = this.interestRates.getMinimumBalance();
                    checkMinimumBalance = true;
                }
                else
                {
                    errorMessage += "Please Specify Amount - Minimum Balance Range." + Environment.NewLine;
                    this.interestRates.setErrorMinimum();
                    checkMinimumBalance = false;
                }
                if (this.interestRates.getCheckMaximumBalance())
                {
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
                            this.interestRatesModel.MaxRange = this.interestRates.getMaximumBalance();
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
                        if (this.interestRatesModel.checkBalanceRange(this.interestRates.getMinimumBalance(), this.interestRates.getMaximumBalance(), this.interestRates.getAccountType(), 0) > 0)
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
                        if (this.interestRatesModel.checkBalanceRange(this.interestRates.getMinimumBalance(), this.interestRates.getMaximumBalance(), this.accountType, this.InterestId) > 0)
                        {
                            errorMessage += "Balance Range Overlap Detected." + Environment.NewLine;
                            checkBalanceRange = false;
                        }
                        else
                        {
                            checkBalanceRange = true;
                        }
                    }
                }
                else
                {
                    if (isAdd)
                    {
                        if (this.interestRatesModel.checkBalanceRange(this.interestRates.getMinimumBalance(), DBNull.Value, this.interestRates.getAccountType(), 0) > 0 || this.interestRatesModel.checkUnbracketed(this.interestRates.getAccountType(), this.interestRates.getMinimumBalance(), 0) > 0)
                        {
                            errorMessage += "An Unbracketed Balance Already Defined As The Highest Interest Rate." + Environment.NewLine;
                            this.interestRatesModel.MaxRange = DBNull.Value;
                            checkBalanceRange = false;
                        }
                        else
                        {
                            this.interestRatesModel.MaxRange = DBNull.Value;
                            checkBalanceRange = true;
                        }
                    }
                    else
                    {
                        if (this.interestRatesModel.checkBalanceRange(this.interestRates.getMinimumBalance(), DBNull.Value, this.accountType, this.InterestId) > 0 || this.interestRatesModel.checkUnbracketed(this.accountType, this.interestRates.getMinimumBalance(), this.InterestId) > 0)
                        {
                            errorMessage += "An Unbracketed Balance Already Defined As The Highest Interest Rate." + Environment.NewLine;
                            this.interestRatesModel.MaxRange = DBNull.Value;
                            checkBalanceRange = false;
                        }
                        else
                        {
                            this.interestRatesModel.MaxRange = DBNull.Value;
                            checkBalanceRange = true;
                        }
                    }
                    checkMaximumBalance = true;
                }
                if (this.interestRates.getStatus())
                {
                    this.interestRatesModel.Status = 1;
                }
                else
                {
                    this.interestRatesModel.Status = 0;
                }
                if (checkAccountType && checkInterestRate && checkInterestRateSchedule && checkMinimumBalance && checkMaximumBalance && checkBalanceRange)
                {
                    if (isAdd)
                    {
                        if (this.interestRatesModel.insertInterestRate() == 1)
                        {
                            MessageBox.Show("Add Success.", "Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.interestRates.checkArchivedState())
                            {
                                this.interestRates.interestRatesGrid(this.interestRatesModel.searchInterestRatesAll(this.interestRates.getSearch()));
                                DataGridViewRowCollection dr = this.interestRates.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.interestRates.setArchivedColor(i);
                                    }
                                    i++;
                                }
                            }
                            else
                            {
                                this.interestRates.interestRatesGrid(this.interestRatesModel.searchInterestRates(this.interestRates.getSearch()));
                            }
                            this.interestRates.removeColumns();
                            this.interestRates.clearError();
                            this.interestRates.disableFunction();
                           // isAdd = false;
                            InterestId = 0;
                            accountType = 0;
                        }
                        else
                        {
                            MessageBox.Show("Add Failed.", "Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (this.interestRatesModel.updateInterestRate(this.InterestId) == 1)
                        {
                            MessageBox.Show("Update Success.", "Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.interestRates.checkArchivedState())
                            {
                                this.interestRates.interestRatesGrid(this.interestRatesModel.searchInterestRatesAll(this.interestRates.getSearch()));
                                DataGridViewRowCollection dr = this.interestRates.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.interestRates.setArchivedColor(i);
                                    }
                                    i++;
                                }
                            }
                            else
                            {
                                this.interestRates.interestRatesGrid(this.interestRatesModel.searchInterestRates(this.interestRates.getSearch()));
                            }
                            this.interestRates.removeColumns();
                            this.interestRates.clearError();
                            this.interestRates.disableFunction();
                           // isAdd = false;
                            InterestId = 0;
                            accountType = 0;
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

        public void checkArchived(object sender, EventArgs e)
        {
            if (this.interestRates.checkArchivedState())
            {
                this.interestRates.interestRatesGrid(this.interestRatesModel.searchInterestRatesAll(this.interestRates.getSearch()));
                DataGridViewRowCollection dr = this.interestRates.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.interestRates.setArchivedColor(i);
                    }
                    i++;
                }
                this.interestRates.removeColumns();
            }
            else
            {
                this.interestRates.interestRatesGrid(this.interestRatesModel.searchInterestRates(this.interestRates.getSearch()));
                this.interestRates.removeColumns();
            }
        }

        private void txtSearch(object sender, EventArgs e)
        {
            if(this.interestRates.checkArchivedState())
            {
                this.interestRates.interestRatesGrid(this.interestRatesModel.searchInterestRatesAll(this.interestRates.getSearch()));
                this.interestRates.removeColumns();
            }
            else
            {
                this.interestRates.interestRatesGrid(this.interestRatesModel.searchInterestRates(this.interestRates.getSearch()));
                this.interestRates.removeColumns();
            }
        }
         */
    }
}
