using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CMS.Savings.Maintenance.Controller
{
    class EarlyWithdrawalController
    {
        Maintenance.Model.EarlyWithdrawalModel earlyWithdrawalModel;
        Maintenance.View.EarlyWithdrawal earlyWithdrawal;
        String errorMessage = String.Empty;
        Boolean isAdd = false;
        int accountType = 0;
        int EarlyWithdrawalId = 0;

        public EarlyWithdrawalController(Maintenance.Model.EarlyWithdrawalModel earlyWithdrawalModel, Maintenance.View.EarlyWithdrawal earlyWithdrawal, SavingsMenu savingsMenu)
        {
            this.earlyWithdrawalModel = earlyWithdrawalModel;
            this.earlyWithdrawal = earlyWithdrawal;
            this.earlyWithdrawal.setBtnAddEventHandler(this.btnAdd);
            this.earlyWithdrawal.setBtnCancelEventHandler(this.btnCancel);
            this.earlyWithdrawal.setBtnEditEventHandler(this.btnEdit);
            this.earlyWithdrawal.setBtnSaveEventHandler(this.btnSave);
            this.earlyWithdrawal.txtSearch_TextChanged(this.txtSearch);
            this.earlyWithdrawal.disableFunction();
            this.earlyWithdrawal.timeDepositGrid(this.earlyWithdrawalModel.selectEarlyWithdrawal());
            this.earlyWithdrawal.removeColumns();
            this.earlyWithdrawal.MdiParent = savingsMenu;
            this.earlyWithdrawal.Show();
        }

        public void btnAdd(object args, EventArgs e)
        {
            this.earlyWithdrawal.enableFunction();
            this.earlyWithdrawal.setStatus();
            isAdd = true;
            EarlyWithdrawalId = 0;
            accountType = 0;
        }

        public void btnEdit(object args, EventArgs e)
        {
            DataGridViewRow selectedData = this.earlyWithdrawal.getSelected();
            if (selectedData == null)
            {
                MessageBox.Show("No Row Selected.", "Early Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.earlyWithdrawal.enableFunction();
                this.EarlyWithdrawalId = int.Parse(selectedData.Cells["Early Withdrawal Id"].Value.ToString());
                this.accountType = int.Parse(selectedData.Cells["Account Type Id"].Value.ToString());
                String[] penalty = selectedData.Cells["Penalty"].Value.ToString().Split(' ');
                this.earlyWithdrawal.setTextPenalty(penalty[0]);
                String[] duration = selectedData.Cells["Duration"].Value.ToString().Split(' ');
                String durationStatus = String.Empty;
                for (int i = 0; i < duration.Length; i++)
                {
                    if (i == 0)
                    {
                        //this.earlyWithdrawal.setNumDuration(int.Parse(duration[0]));
                    }
                    else if (i == duration.Length - 1)
                    {
                        durationStatus += duration[i];
                    }
                    else
                    {
                        durationStatus += duration[i] + ' ';
                    }
                }
                String[] balance = selectedData.Cells["Balance Range"].Value.ToString().Split('-');
                if (bool.Parse(selectedData.Cells["Status"].Value.ToString()))
                {
                    this.earlyWithdrawal.setStatus();
                }
                isAdd = false;
            }
        }

        public void btnSave(object args, EventArgs e)
        {/*
            errorMessage = String.Empty;
            this.earlyWithdrawal.clearError();
            Boolean checkAccountType = false;
            Boolean checkDuration = false;
            Boolean checkDurationStatus = false;
            Boolean checkPenalty = false;
            Boolean checkPenaltyPer = false;
            Boolean checkMinRange = false;
            Boolean checkMaxRange = false;
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
                if (this.earlyWithdrawal.getTextPenalty() != 0)
                {
                    if (isAdd)
                    {
                        if (this.earlyWithdrawalModel.checkPenalty(this.earlyWithdrawal.getAccountType(), this.earlyWithdrawal.getTextPenalty(), this.earlyWithdrawal.getComboPenalty(), 0, this.earlyWithdrawal.getNumDuration(), this.earlyWithdrawal.getComboDuration()) > 0)
                        {
                            errorMessage += "Penalty Value Already Exist For This Account Type." + Environment.NewLine;
                            this.earlyWithdrawal.setErrorPenalty();
                            checkPenalty = false;
                        }
                        else
                        {
                            this.earlyWithdrawalModel.Penalty = this.earlyWithdrawal.getTextPenalty();
                            checkPenalty = true;
                        }
                    }
                    else
                    {
                        if (this.earlyWithdrawalModel.checkPenalty(this.accountType, this.earlyWithdrawal.getTextPenalty(), this.earlyWithdrawal.getComboPenalty(), this.EarlyWithdrawalId, this.earlyWithdrawal.getNumDuration(), this.earlyWithdrawal.getComboDuration()) > 0)
                        {
                            errorMessage += "Penalty Value Already Exist For This Account Type." + Environment.NewLine;
                            this.earlyWithdrawal.setErrorPenalty();
                            checkPenalty = false;
                        }
                        else
                        {
                            this.earlyWithdrawalModel.Penalty = this.earlyWithdrawal.getTextPenalty();
                            checkPenalty = true;
                        }
                    }
                }
                else
                {
                    errorMessage += "Please Specify Amount - Penalty." + Environment.NewLine;
                    this.earlyWithdrawal.setErrorPenalty();
                    checkPenalty = false;
                }
                if (this.earlyWithdrawal.getComboPenalty() == String.Empty)
                {
                    errorMessage += "Please Specify Penalty Schedule." + Environment.NewLine;
                    this.earlyWithdrawal.setErrorPenalty();
                    checkPenaltyPer = false;
                }
                else
                {
                    this.earlyWithdrawalModel.Per = this.earlyWithdrawal.getComboPenalty();
                    checkPenaltyPer = true;
                }
                if (this.earlyWithdrawal.getMinimumBalance() == 0)
                {
                    errorMessage += "Please Specify Amount - Minimum Range." + Environment.NewLine;
                    this.earlyWithdrawal.setErrorMinimum();
                    checkMinRange = false;
                }
                else
                {
                    this.earlyWithdrawalModel.MinRange = this.earlyWithdrawal.getMinimumBalance();
                    checkMinRange = true;
                }
                if (this.earlyWithdrawal.getCheckMaximumBalance())
                {
                    if (this.earlyWithdrawal.getMaximumBalance() > 0)
                    {
                        if (this.earlyWithdrawal.getMaximumBalance() <= this.earlyWithdrawal.getMinimumBalance())
                        {
                            errorMessage += "Maximum Balance Range Must Be Greater Than Minimum Balance Range." + Environment.NewLine;
                            this.earlyWithdrawal.setErrorMaximum();
                            checkMaxRange = false;
                        }
                        else
                        {
                            this.earlyWithdrawalModel.MaxRange = this.earlyWithdrawal.getMaximumBalance();
                            checkMaxRange = true;
                        }
                    }
                    else
                    {
                        errorMessage += "Please Specify Amount - Maximum Range." + Environment.NewLine;
                        this.earlyWithdrawal.setErrorMaximum();
                        checkMaxRange = false;
                    }
                    if (isAdd)
                    {
                        if (this.earlyWithdrawalModel.checkBalanceRange(this.earlyWithdrawal.getMinimumBalance(), this.earlyWithdrawal.getMaximumBalance(), this.earlyWithdrawal.getAccountType(), 0, this.earlyWithdrawal.getNumDuration(), this.earlyWithdrawal.getComboDuration()) > 0 || this.earlyWithdrawalModel.checkUnbracketed(this.earlyWithdrawal.getAccountType(), this.earlyWithdrawal.getMaximumBalance(), 0, this.earlyWithdrawal.getNumDuration(), this.earlyWithdrawal.getComboDuration()) > 0)
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
                        if (this.earlyWithdrawalModel.checkBalanceRange(this.earlyWithdrawal.getMinimumBalance(), this.earlyWithdrawal.getMaximumBalance(), this.accountType, this.EarlyWithdrawalId, this.earlyWithdrawal.getNumDuration(), this.earlyWithdrawal.getComboDuration()) > 0 || this.earlyWithdrawalModel.checkUnbracketed(this.accountType, this.earlyWithdrawal.getMaximumBalance(), this.EarlyWithdrawalId, this.earlyWithdrawal.getNumDuration(), this.earlyWithdrawal.getComboDuration()) > 0)
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
                        if (this.earlyWithdrawalModel.checkBracketed(this.earlyWithdrawal.getAccountType(), this.earlyWithdrawal.getMinimumBalance(), 0, this.earlyWithdrawal.getNumDuration(), this.earlyWithdrawal.getComboDuration()) > 0 || this.earlyWithdrawalModel.checkUnbracketed(this.earlyWithdrawal.getAccountType(), this.earlyWithdrawal.getMinimumBalance(), 0, this.earlyWithdrawal.getNumDuration(), this.earlyWithdrawal.getComboDuration()) > 0)
                        {
                            errorMessage += "An Unbracketed Balance Already Defined As The Highest Penalty." + Environment.NewLine;
                            this.earlyWithdrawalModel.MaxRange = 0;
                            checkBalanceRange = false;
                        }
                        else
                        {
                            this.earlyWithdrawalModel.MaxRange = 0;
                            checkBalanceRange = true;
                        }
                    }
                    else
                    {
                        if (this.earlyWithdrawalModel.checkBracketed(this.accountType, this.earlyWithdrawal.getMinimumBalance(), this.EarlyWithdrawalId, this.earlyWithdrawal.getNumDuration(), this.earlyWithdrawal.getComboDuration()) > 0 || this.earlyWithdrawalModel.checkUnbracketed(this.accountType, this.earlyWithdrawal.getMinimumBalance(), this.EarlyWithdrawalId, this.earlyWithdrawal.getNumDuration(), this.earlyWithdrawal.getComboDuration()) > 0)
                        {
                            errorMessage += "An Unbracketed Balance Already Defined As The Highest Penalty." + Environment.NewLine;
                            this.earlyWithdrawalModel.MaxRange = 0;
                            checkBalanceRange = false;
                        }
                        else
                        {
                            this.earlyWithdrawalModel.MaxRange = 0;
                            checkBalanceRange = true;
                        }
                    }
                    checkMaxRange = true;
                }
                if (this.earlyWithdrawal.getStatus())
                {
                    this.earlyWithdrawalModel.Status = 1;
                }
                else
                {
                    this.earlyWithdrawalModel.Status = 0;
                }
                if (checkAccountType && checkDuration && checkDurationStatus && checkPenalty && checkPenaltyPer && checkMinRange && checkMaxRange && checkBalanceRange)
                {
                    if (isAdd)
                    {
                        if (this.earlyWithdrawalModel.insertEarlyWithdrawal() == 1)
                        {
                            MessageBox.Show("Add Success.", "Early Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.earlyWithdrawal.checkArchivedState())
                            {
                                this.earlyWithdrawal.timeDepositGrid(this.earlyWithdrawalModel.searchEarlyWithdrawalAll(this.earlyWithdrawal.getSearch()));
                                DataGridViewRowCollection dr = this.earlyWithdrawal.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.earlyWithdrawal.setArchivedColor(i);
                                    }
                                    i++;
                                }
                            }
                            else
                            {
                                this.earlyWithdrawal.timeDepositGrid(this.earlyWithdrawalModel.searchEarlyWithdrawal(this.earlyWithdrawal.getSearch()));
                            }
                            this.earlyWithdrawal.clearError();
                            this.earlyWithdrawal.removeColumns();
                            this.earlyWithdrawal.disableFunction();
                            isAdd = false;
                            EarlyWithdrawalId = 0;
                            accountType = 0;
                        }
                        else
                        {
                            MessageBox.Show("Add Failed.", "Early Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (this.earlyWithdrawalModel.updateEarlyWithdrawal(EarlyWithdrawalId) == 1)
                        {
                            MessageBox.Show("Update Success.", "Early Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.earlyWithdrawal.checkArchivedState())
                            {
                                this.earlyWithdrawal.timeDepositGrid(this.earlyWithdrawalModel.searchEarlyWithdrawalAll(this.earlyWithdrawal.getSearch()));
                                DataGridViewRowCollection dr = this.earlyWithdrawal.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.earlyWithdrawal.setArchivedColor(i);
                                    }
                                    i++;
                                }
                            }
                            else
                            {
                                this.earlyWithdrawal.timeDepositGrid(this.earlyWithdrawalModel.searchEarlyWithdrawal(this.earlyWithdrawal.getSearch()));
                            }
                            this.earlyWithdrawal.clearError();
                            this.earlyWithdrawal.removeColumns();
                            this.earlyWithdrawal.disableFunction();
                            isAdd = false;
                            EarlyWithdrawalId = 0;
                            accountType = 0;
                        }
                        else
                        {
                            MessageBox.Show("Update Failed.", "Early Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage, "Early Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                this.earlyWithdrawal.clearError();
                this.earlyWithdrawal.setErrorBalDuration();
                this.earlyWithdrawal.setErrorMaximum();
                this.earlyWithdrawal.setErrorMinimum();
                this.earlyWithdrawal.setErrorPenalty();
                MessageBox.Show(this.errorMessage + "Invalid Input!" + Environment.NewLine + "Check Red Labels.", "Early Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.earlyWithdrawal.disableFunction();
            this.earlyWithdrawal.clearError();
            errorMessage = String.Empty;
            isAdd = false;
            EarlyWithdrawalId = 0;
            accountType = 0;
        }

        private void txtSearch(object sender, EventArgs e)
        {/*
            if (this.earlyWithdrawal.checkArchivedState())
            {
                this.earlyWithdrawal.timeDepositGrid(this.earlyWithdrawalModel.searchEarlyWithdrawalAll(this.earlyWithdrawal.getSearch()));
                this.earlyWithdrawal.removeColumns();
            }
            else
            {
                this.earlyWithdrawal.timeDepositGrid(this.earlyWithdrawalModel.searchEarlyWithdrawal(this.earlyWithdrawal.getSearch()));
                this.earlyWithdrawal.removeColumns();
            }*/
        }
    }
}
