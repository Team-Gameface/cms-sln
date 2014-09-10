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
                this.EarlyWithdrawalId = int.Parse(selectedData.Cells["EarlyWithdrawalId"].Value.ToString());
                String[] from = selectedData.Cells["Term Elapsed From"].Value.ToString().Split('%');
                this.earlyWithdrawal.setNumDurationFrom(int.Parse(from[0]));
                String[] to = selectedData.Cells["Term Elapsed To"].Value.ToString().Split('%');
                this.earlyWithdrawal.setNumDurationTo(int.Parse(to[0]));
                String[] penalty = selectedData.Cells["Interest Reduction"].Value.ToString().Split('%');
                this.earlyWithdrawal.setTextPenalty(penalty[0]);
                if (bool.Parse(selectedData.Cells["Status"].Value.ToString()))
                {
                    this.earlyWithdrawal.setStatus();
                }
                isAdd = false;
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            errorMessage = String.Empty;
            this.earlyWithdrawal.clearError();
            Boolean checkPenalty = false;
            Boolean checkElapsedFrom = false;
            Boolean checkElapsedTo = false;
            Boolean checkElapsedRange = false;
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
                if (this.earlyWithdrawal.getNumDurationFrom() != 0)
                {
                    if (this.earlyWithdrawal.getNumDurationFrom() > 0)
                    {
                        this.earlyWithdrawalModel.TermElapsedFrom = this.earlyWithdrawal.getNumDurationFrom();
                        checkElapsedFrom = true;
                    }
                    else
                    {
                        errorMessage += "Please Specify - Elapsed Term From." + Environment.NewLine;
                        this.earlyWithdrawal.setErrorDurationFrom();
                        checkElapsedFrom = false;
                    }
                }
                else
                {
                    errorMessage += "Please Specify - Elapsed Term From." + Environment.NewLine;
                    checkElapsedFrom = false;
                }
                if (this.earlyWithdrawal.getNumDurationTo() != 0)
                {
                    if (this.earlyWithdrawal.getNumDurationTo() > 0)
                    {
                        if (this.earlyWithdrawal.getNumDurationTo() <= this.earlyWithdrawal.getNumDurationFrom())
                        {
                            errorMessage += "Elapsed Duration To Cannot be Less Than Elapsed Duration From." + Environment.NewLine;
                            this.earlyWithdrawal.setErrorDurationTo();
                            checkElapsedTo = false;
                        }
                        else
                        {
                            this.earlyWithdrawalModel.TermElapsedTo = this.earlyWithdrawal.getNumDurationTo();
                            checkElapsedTo = true;
                        }
                    }
                    else
                    {
                        errorMessage += "Please Specify - Elapsed Term To." + Environment.NewLine;
                        this.earlyWithdrawal.setErrorDurationTo();
                        checkElapsedFrom = false;
                    }
                }
                if (this.earlyWithdrawal.getTextPenalty() != 0)
                {
                    if (this.earlyWithdrawal.getTextPenalty() > 0)
                    {
                        if (isAdd)
                        {
                            if (this.earlyWithdrawalModel.checkReduction(this.earlyWithdrawal.getTextPenalty()) > 0)
                            {
                                errorMessage += "Interest Reduction Rate Already Exists." + Environment.NewLine;
                                this.earlyWithdrawal.setErrorPenalty();
                            }
                            else
                            {
                                this.earlyWithdrawalModel.InterestReduction = this.earlyWithdrawal.getTextPenalty();
                                checkPenalty = true;
                            }
                        }
                        else
                        {
                            if (this.earlyWithdrawalModel.checkReduction(this.earlyWithdrawal.getTextPenalty(), this.EarlyWithdrawalId) > 0)
                            {
                                errorMessage += "Interest Reduction Rate Already Exists." + Environment.NewLine;
                                this.earlyWithdrawal.setErrorPenalty();
                            }
                            else
                            {
                                this.earlyWithdrawalModel.InterestReduction = this.earlyWithdrawal.getTextPenalty();
                                checkPenalty = true;
                            }
                        }
                    }
                    else
                    {
                        errorMessage += "Please Specify - Interest Reduction." + Environment.NewLine;
                        this.earlyWithdrawal.setErrorPenalty();
                        checkPenalty = false;
                    }
                }
                else
                {
                    errorMessage += "Please Specify - Interest Reduction." + Environment.NewLine;
                    this.earlyWithdrawal.setErrorPenalty();
                    checkPenalty = false;
                }
                if (isAdd)
                {
                    if (this.earlyWithdrawalModel.checkOverlap(this.earlyWithdrawal.getNumDurationFrom(), this.earlyWithdrawal.getNumDurationTo()) > 0)
                    {
                        errorMessage += "Elapsed Term Overlap Detected" + Environment.NewLine;
                        checkElapsedRange = false;
                    }
                    else
                    {
                        checkElapsedRange = true;
                    }
                }
                else
                {
                    if (this.earlyWithdrawalModel.checkOverlap(this.earlyWithdrawal.getNumDurationFrom(), this.earlyWithdrawal.getNumDurationTo(), this.EarlyWithdrawalId) > 0)
                    {
                        errorMessage += "Elapsed Term Overlap Detected" + Environment.NewLine;
                        checkElapsedRange = false;
                    }
                    else
                    {
                        checkElapsedRange = true;
                    }
                }
                if (this.earlyWithdrawal.getStatus())
                {
                    this.earlyWithdrawalModel.Status = 1;
                }
                else
                {
                    this.earlyWithdrawalModel.Status = 0;
                }
                if (checkElapsedFrom && checkElapsedTo && checkPenalty && checkElapsedRange)
                {
                    if (isAdd)
                    {
                        if (this.earlyWithdrawalModel.insertEarlyWithdrawal() == 1)
                        {
                            MessageBox.Show("Add Success.", "Early Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.earlyWithdrawal.timeDepositGrid(this.earlyWithdrawalModel.searchEarlyWithdrawal(this.earlyWithdrawal.getSearch()));
                            this.earlyWithdrawal.clearError();
                            this.earlyWithdrawal.removeColumns();
                            this.earlyWithdrawal.disableFunction();
                            isAdd = false;
                            EarlyWithdrawalId = 0;
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
                            this.earlyWithdrawal.timeDepositGrid(this.earlyWithdrawalModel.searchEarlyWithdrawal(this.earlyWithdrawal.getSearch()));
                            this.earlyWithdrawal.clearError();
                            this.earlyWithdrawal.removeColumns();
                            this.earlyWithdrawal.disableFunction();
                            isAdd = false;
                            EarlyWithdrawalId = 0;
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
                this.earlyWithdrawal.setErrorPenalty();
                MessageBox.Show(this.errorMessage + "Invalid Input!" + Environment.NewLine + "Check Red Labels.", "Early Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.earlyWithdrawal.disableFunction();
            this.earlyWithdrawal.clearError();
            errorMessage = String.Empty;
            isAdd = false;
            EarlyWithdrawalId = 0;
        }

        private void txtSearch(object sender, EventArgs e)
        {
            this.earlyWithdrawal.timeDepositGrid(this.earlyWithdrawalModel.searchEarlyWithdrawal(this.earlyWithdrawal.getSearch()));
        }
    }
}
