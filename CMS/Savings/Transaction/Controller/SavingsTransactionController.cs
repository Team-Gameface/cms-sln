using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.Controller
{
    class SavingsTransactionController
    {
        Main.Logger logger = new Main.Logger();
        Model.SavingsTransactionModel savingsTransactionModel;
        View.SavingsTransaction savingsTransaction;
        int TypeId = 0;

        public SavingsTransactionController(Model.SavingsTransactionModel savingsTransactionModel, View.SavingsTransaction savingsTransaction, SavingsMenu savingsMenu)
        {
            this.savingsTransactionModel = savingsTransactionModel;
            this.savingsTransaction = savingsTransaction;
            this.savingsTransaction.setDataMember(this.savingsTransactionModel.selectMember());
            this.savingsTransaction.txtAccountNo_TextChanged(this.txtSearch);
            this.savingsTransaction.dataMember_CellContentClick(this.dataMemberCellClick);
            this.savingsTransaction.setBtnClearEventHandler(this.btnClear);
            this.savingsTransaction.setBtnSaveEventHandler(this.btnSave);
            this.savingsTransaction.setBtnViewEventHandler(this.btnView);
            this.savingsTransaction.setBtnPassbookEventHandler(this.btnPassbook);
            this.savingsTransaction.disableDetails();
            this.savingsTransaction.MdiParent = savingsMenu;
            this.savingsTransaction.Show();
        }

        public void txtSearch(object sender, EventArgs e)
        {
            this.savingsTransaction.clearDetails();
            this.savingsTransaction.disableDetails();
            this.savingsTransaction.setDataMember(this.savingsTransactionModel.searchMember(this.savingsTransaction.getAccountNo()));
        }

        public void dataMemberCellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.savingsTransaction.getSelectedMember();
            if (row == null)
            {
                MessageBox.Show("No row selected.");
            }
            else
            {
                this.savingsTransaction.enableDetails();
                this.savingsTransaction.setSavingsAccountNo(row.Cells[0].Value.ToString());
                this.savingsTransaction.setAccountBalance(row.Cells[4].Value.ToString());
                this.TypeId = int.Parse(row.Cells[3].Value.ToString());
                this.savingsTransaction.setDataAccountHolder(this.savingsTransactionModel.selectAccountHolder(row.Cells[0].Value.ToString()));
            }
        }

        public void btnView(object sender, EventArgs e)
        {
            DataGridViewRow row = this.savingsTransaction.getSelectedAccountHolder();
            if (row == null)
            {
                MessageBox.Show("No Row Selected.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new View.SignatureCard(row.Cells[0].Value.ToString()).ShowDialog();
            }
        }

        public void btnClear(object sender, EventArgs e)
        {
            this.savingsTransaction.clearAll();
            this.savingsTransaction.setAccountBalance("0");
            this.savingsTransaction.setDataMember(this.savingsTransactionModel.selectMember());
        }

        public void btnSave(object sender, EventArgs e)
        {
            this.savingsTransaction.clearErrors();
            String errorMessage = String.Empty;
            Boolean checkTransactionMode = false;
            Boolean checkAccountNo = false;
            Boolean checkAmount = false;
            Boolean checkRepresentative = false;
            if (this.savingsTransaction.getComboTransaction() != String.Empty)
            {
                this.savingsTransactionModel.TransactionMode = this.savingsTransaction.getComboTransaction();
                checkTransactionMode = true;
            }
            else
            {
                errorMessage += "Select Transaction Mode." + Environment.NewLine;
                this.savingsTransaction.setErrorMode();
                checkTransactionMode = false;
            }
            if (this.savingsTransaction.getSavingsAccountNo() == String.Empty)
            {
                errorMessage += "No Selected Account." + Environment.NewLine;
                checkAccountNo = false;
            }
            else
            {
                this.savingsTransactionModel.AccountNo = this.savingsTransaction.getSavingsAccountNo();
                checkAccountNo = true;
            }
            try
            {
                if (this.savingsTransaction.getAmount() <= 0)
                {
                    errorMessage += "Please Specify Amount." + Environment.NewLine;
                    this.savingsTransaction.setErrorAmount();
                    checkAmount = false;
                }
                else
                {
                    if (this.savingsTransaction.getComboTransaction() == "Withdraw")
                    {
                        if (this.savingsTransactionModel.selectMaximumWithdrawal(this.TypeId) != 0 && this.savingsTransaction.getAmount() > this.savingsTransactionModel.selectMaximumWithdrawal(this.TypeId))
                        {
                            DialogResult result = MessageBox.Show("You are Attempting to Withdraw Beyond Maximum Allowable Amount. Do You Wish to Continue?", "Savins Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                this.savingsTransactionModel.Amount = this.savingsTransaction.getAmount();
                                checkAmount = true;
                            }
                            else
                            {
                                checkAmount = false;
                            }
                        }
                        else
                        {
                            if (this.savingsTransaction.getAmount() > this.savingsTransaction.getAccountBalance())
                            {
                                errorMessage += "Insufficient Funds." + Environment.NewLine;
                                this.savingsTransaction.setErrorAmount();
                                checkAmount = false;
                            }
                            else if ((this.savingsTransaction.getAccountBalance() - this.savingsTransaction.getAmount()) < this.savingsTransactionModel.selectMaintainingBalance(this.TypeId))
                            {
                                MessageBox.Show("Account Balance is Now Below Maintaning Balance.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.savingsTransactionModel.Amount = this.savingsTransaction.getAmount();
                                checkAmount = true;
                            }
                            else if ((this.savingsTransaction.getAccountBalance() - this.savingsTransaction.getAmount()) == 0)
                            {
                                MessageBox.Show("Account Balance is Now Empty.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.savingsTransactionModel.Amount = this.savingsTransaction.getAmount();
                                checkAmount = true;
                            }
                            else
                            {
                                this.savingsTransactionModel.Amount = this.savingsTransaction.getAmount();
                                checkAmount = true;
                            }
                        }
                    }
                    else
                    {
                        this.savingsTransactionModel.Amount = this.savingsTransaction.getAmount();
                        checkAmount = true;
                    }
                }
            }
            catch (FormatException)
            {
                errorMessage += "Invalid Amount." + Environment.NewLine;
                this.savingsTransaction.setErrorAmount();
                checkAmount = false;
            }
            if (this.savingsTransaction.getCheckRepresentative())
            {
                if (this.savingsTransaction.getTextRepresentative() == String.Empty)
                {
                    errorMessage += "Please Specify Representative." + Environment.NewLine;
                    this.savingsTransaction.setErrorRepresentative();
                    checkRepresentative = false;
                }
                else
                {
                    this.savingsTransactionModel.Representative = this.savingsTransaction.getTextRepresentative();
                    checkRepresentative = true;
                }
            }
            else
            {
                this.savingsTransactionModel.Representative = String.Empty;
                checkRepresentative = true;
            }
            if (checkTransactionMode && checkAccountNo && checkAmount && checkRepresentative)
            {
                this.savingsTransactionModel.PassbookNo = this.savingsTransactionModel.selectActivePassbook(this.savingsTransaction.getSavingsAccountNo());
                if (this.savingsTransactionModel.insertSavingsTransaction() == 1)
                {
                    DataSet ds = this.savingsTransactionModel.getDepositDetails("dtDepSlip");
                    DataSet dsStaff = this.savingsTransactionModel.getStaff(Main.UserData.userId, "dtStaff");
                    View.DepositSlipViewer depSlipViewer = new View.DepositSlipViewer(ds, this.savingsTransactionModel.getCompanyProfile("dtLogo"), dsStaff);
                    MessageBox.Show("Transaction Success.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger(this.savingsTransaction.getComboTransaction() + "(" + this.savingsTransaction.getAmount() + ") - " + this.savingsTransactionModel.AccountNo);
                    this.savingsTransaction.clearAll();
                    this.savingsTransaction.setAccountBalance("0");
                    this.savingsTransaction.setDataMember(this.savingsTransactionModel.selectMember());
                }
                else
                {
                    MessageBox.Show("Transaction Failed.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Transaction Failed." + Environment.NewLine + Environment.NewLine + errorMessage, "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void btnPassbook(object sender, EventArgs e)
        {
            DataGridViewRow row = this.savingsTransaction.getSelectedMember();
            if (row == null)
            {
                MessageBox.Show("No Row Selected.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String accountNo = row.Cells[0].Value.ToString();
                int activePassbookNo = this.savingsTransactionModel.selectActivePassbook(accountNo);
                this.savingsTransactionModel.setPassbookInactive(activePassbookNo);
                int newPassbook = this.savingsTransactionModel.generateSavingsPassbook();
                int result = this.savingsTransactionModel.insertSavingsPassbook(newPassbook, accountNo);
                if (result == 1)
                {
                    MessageBox.Show("New Passbook Generated.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Passbook Generated(" + newPassbook + ") - " + accountNo);
                }
                else
                {
                    MessageBox.Show("Passbook Reissuance Failed.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Transaction - Savings Transaction";
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
