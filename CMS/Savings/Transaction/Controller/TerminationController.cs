using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CMS.Savings.Transaction.Controller
{
    public class TerminationController
    {
        Savings.Transaction.Model.TerminationModel terminationModel;
        Savings.Transaction.View.MemberTermination termination;

        public double totalPenalty = 0;
        public double totalInterest = 0;
        public double totalBalance = 0;
        public static int totalAppId = 0;
        public double[] arrBalance = new double[totalAppId];
        public double[] arrInterest = new double[totalAppId];
        public double[] arrPenalty = new double[totalAppId];
        public int[] arrAppId = new int[totalAppId];
        public String accountNo = String.Empty;
        

        public TerminationController(Transaction.Model.TerminationModel terminationModel, Transaction.View.MemberTermination termination, SavingsMenu savingsMenu)
        {
            this.terminationModel = terminationModel;
            this.termination = termination;
            this.termination.setBtnSaveEventHandler(this.btnSave);
            this.termination.setBtnCancelEventHandler(this.btnCancel);
            this.termination.setTxtAccountNameEventHandler(this.typeSearchMember);
            this.termination.setTxtAccountNoEventHandler(this.typeSearchMember);
            this.termination.classGridSearch(this.terminationModel.selectActiveMember());
            this.termination.setDataSearchEventHandler(this.dataSearch_CellClick);
            this.termination.MdiParent = savingsMenu;
            this.termination.Show();
            if(this.terminationModel.checkEmpty!=0)this.termination.noRowsSelected();
            this.terminationModel.checkEmpty = 0;
            this.termination.clearFields();
        }

        public void btnSave(object args, EventArgs e)
        {
            Boolean checkSavings = false;
            Boolean checkTimeDeposit = false;
            String errorMessage = "Cannot Terminate Member." + Environment.NewLine + Environment.NewLine;
            if (int.Parse(this.termination.getSavings()) > 0)
            {
                checkSavings = false;
                errorMessage += "Member has Active Savings Account." + Environment.NewLine + "Please Terminate Savings Account first." + Environment.NewLine;
            }
            else
            {
                checkSavings = true;
            }
            if (this.termination.getTextTimeDeposit() > 0)
            {
                checkTimeDeposit = false;
                errorMessage += "Member has Time Deposit/s." + Environment.NewLine + "Please Withdraw All Time Deposit/s first.";
            }
            else
            {
                checkTimeDeposit = true;
            }
            if (checkSavings && checkTimeDeposit)
            {
                DataGridViewRow selectedData = this.termination.getSelected();
                String accountNo = selectedData.Cells["Account No."].Value.ToString();
                String reason = this.termination.getReason();
                String details = this.termination.getDetails();
                double totalRefundables = this.termination.getShareCapital();
                double netRefunds = totalRefundables - this.termination.getNetRefunds();
                CultureInfo ph = new CultureInfo("en-PH");
                if (netRefunds < 0)
                {
                    DialogResult dr = MessageBox.Show("Member still has to pay " + netRefunds.ToString("c", ph) + " to continue termination. Proceed?", "Member Termination", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    if (dr == DialogResult.Yes)
                    {
                        new View.TerminationPayment(accountNo, reason, details, netRefunds, this.termination, this.terminationModel, this).ShowDialog();
                    }
                }
                else
                {
                    if (this.terminationModel.insertTermination(reason, details, accountNo) != 0)
                    {
                        if (this.terminationModel.clearLoans(accountNo, arrAppId, arrBalance, arrPenalty, arrInterest) != 0)
                        {
                            MessageBox.Show("Member Termination Success.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.termination.classGridSearch(this.terminationModel.selectActiveMember());
                            this.termination.clearFields();
                            totalPenalty = 0;
                            totalBalance = 0;
                            totalInterest = 0;
                            totalAppId = 0;
                            arrBalance = new double[totalAppId];
                            arrInterest = new double[totalAppId];
                            arrPenalty = new double[totalAppId];
                            arrAppId = new int[totalAppId];
                            accountNo = String.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Clear Loans Failed.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Member Termination Failed.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.termination.clearFields();
            totalPenalty = 0;
            totalBalance = 0;
            totalInterest = 0;
            totalAppId = 0;
            arrBalance = new double[totalAppId];
            arrInterest = new double[totalAppId];
            arrPenalty = new double[totalAppId];
            arrAppId = new int[totalAppId];
            accountNo = String.Empty;
        }

        public void btnSearchMember(object args, EventArgs e)
        {   
            bool getSearchType = this.termination.getSearchType();

            if (getSearchType)
            {
                this.termination.classGridSearch(this.terminationModel.searchMemberByName(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {
                    
                    this.termination.selectFeesBySearch();
                }
                else {
                    MessageBox.Show("Data not found.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.termination.classGridSearch(this.terminationModel.selectActiveMember());
                    if (this.terminationModel.checkEmpty != 0) this.termination.noRowsSelected();
                    this.termination.clearFields();
                }
            }

            else {
                this.termination.classGridSearch(this.terminationModel.searchMemberByAccount(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {
                    
                    this.termination.selectFeesBySearch();
                }
                else
                {
                    MessageBox.Show("Data not found.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.termination.classGridSearch(this.terminationModel.selectActiveMember());
                    if (this.terminationModel.checkEmpty != 0) this.termination.noRowsSelected();
                    this.termination.clearFields();
                }
            }
        }

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            totalBalance = 0;
            this.termination.selectAnotherMember();
            DataGridViewRow selectedData = this.termination.getSelected();
            accountNo = selectedData.Cells["Account No."].Value.ToString();
            this.termination.setSavingsBalance(this.terminationModel.selectSavingsAccount(accountNo).ToString());
            this.termination.setTextTimeDeposit(this.terminationModel.selectMemberTimeDeposit(accountNo).ToString());
            double shareCapital = this.terminationModel.selectCurrentShareCapital(accountNo);
            this.termination.setShareCapitalBalance(shareCapital.ToString());
                //this.terminationModel.selectRemainingBalance(accountNo);


            DataSet setAmnestizedLoans = this.terminationModel.selectUnpaidAmnestiedLoans(accountNo);
            DataSet setLoans = this.terminationModel.selectUnpaidLoans(accountNo);
            int ctr = 0;
            totalAppId = setAmnestizedLoans.Tables[0].Rows.Count + setLoans.Tables[0].Rows.Count;
            arrBalance = new double[totalAppId];
            arrPenalty = new double[totalAppId];
            arrInterest = new double[totalAppId];
            arrAppId = new int[totalAppId];

            for (int i = 0; i < setAmnestizedLoans.Tables[0].Rows.Count; i++) 
            {
                String[] amnestyBal = this.terminationModel.selectLoanBalanceFromAmnestied(int.Parse(setAmnestizedLoans.Tables[0].Rows[i][0].ToString())).Split(' ');
                totalBalance +=Convert.ToDouble(amnestyBal[0]);
                totalBalance +=Convert.ToDouble(amnestyBal[1]);
                totalBalance += Convert.ToDouble(amnestyBal[2]);
                arrAppId[ctr] = int.Parse(setAmnestizedLoans.Tables[0].Rows[i][0].ToString());
                arrBalance[ctr] = Convert.ToDouble(amnestyBal[0]);
                arrPenalty[ctr] = Convert.ToDouble(amnestyBal[1]);
                arrInterest[ctr] = Convert.ToDouble(amnestyBal[2]);
                ctr++;
            }

            for (int j = 0; j < setLoans.Tables[0].Rows.Count; j++)
            {
                double balFromRegLoans = this.terminationModel.selectRemainingBalance(int.Parse(setLoans.Tables[0].Rows[j][0].ToString()));
                totalBalance += balFromRegLoans;
                arrBalance[ctr] = balFromRegLoans;
                String[] penint = this.getInterestAndPenalty(int.Parse(setLoans.Tables[0].Rows[j][0].ToString()), int.Parse(setLoans.Tables[0].Rows[j][1].ToString())).Split(' ');
                arrPenalty[ctr] = double.Parse(penint[0]);
                arrInterest[ctr] = double.Parse(penint[1]);
                arrAppId[ctr] = int.Parse(setLoans.Tables[0].Rows[j][1].ToString());
                ctr++;
            }
            
            this.termination.setLoanBalance(totalBalance.ToString());           
            this.termination.setNetRefunds((shareCapital - totalBalance).ToString());
            this.termination.enablePanel1();
        }

        public void typeSearchMember(object args, EventArgs e)
        {
            bool getSearchType = this.termination.getSearchType();
            if (getSearchType)
            {
                this.termination.classGridSearch(this.terminationModel.searchMemberByName(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {

                    this.termination.selectFeesBySearch();
                }
               
            }

            else
            {
                this.termination.classGridSearch(this.terminationModel.searchMemberByAccount(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {

                    this.termination.selectFeesBySearch();
                }

            }
        }

        public String getInterestAndPenalty(int lappId, int loanTypeId) 
        {
            totalInterest = 0;
            totalPenalty = 0;

            double miniInterest = 0, miniPenalty = 0;

            double lastInterest = this.terminationModel.selectLastInterest(lappId);

            if (lastInterest != 0)
            {
                totalInterest += lastInterest;
                miniInterest += lastInterest;
            }

            Dictionary<String, int> listOfInterestDates = new Dictionary<String, int>();
            Dictionary<String, int> finalListOfInterestDates = new Dictionary<String, int>();

            String maturityDate = this.terminationModel.selectMaturityDate(lappId);
            String interestDate = (DateTime.Parse(maturityDate).AddDays(1)).ToString();
            String[] interest = this.terminationModel.selectInterestPerLoanType(loanTypeId).Split(' ');

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
                        int i = this.terminationModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

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
                            double grantedLoanAmount = this.terminationModel.selectGrantedLoanAmount(lappId);
                            String[] paymentDur = this.terminationModel.selectPaymentDurationPerApplication(lappId).Split(' ');
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
                            miniInterest += finalInterest;
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
                        int i = this.terminationModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

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
                            double grantedLoanAmount = this.terminationModel.selectGrantedLoanAmount(lappId);
                            String[] paymentDur = this.terminationModel.selectPaymentDurationPerApplication(lappId).Split(' ');
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
                            miniInterest += finalInterest;
                        }
                    }
                }
            }

            totalBalance += totalInterest;

            double lastPenalty = this.terminationModel.selectLastPenalty(lappId);
            if (lastPenalty != 0)
            {
                totalPenalty += lastPenalty;
                miniPenalty += lastPenalty;
            }

            DataSet amorSet = this.terminationModel.selectAmortizations(accountNo, lappId);

            for (int j = 0; j < amorSet.Tables[0].Rows.Count; j++)
            {
                DataSet ds2 = this.terminationModel.selectMonthlyAmortization(lappId);
                double monthlyAmortization = double.Parse(ds2.Tables[0].Rows[0][0].ToString());
                String loanDurationStatus = ds2.Tables[0].Rows[0][1].ToString();
                if (loanDurationStatus == "week/s") { monthlyAmortization *= 4; }
                else if (loanDurationStatus == "year/s") { monthlyAmortization /= 12; }
                double grantedLoanAmount = this.terminationModel.selectGrantedLoanAmount(lappId);
                double remainingBalance = this.terminationModel.selectCurrentBalance(lappId);

                String dueDate = amorSet.Tables[0].Rows[j][3].ToString();
                double amortizationAmount = double.Parse(amorSet.Tables[0].Rows[j][2].ToString());

                DataSet ds = this.terminationModel.selectPenaltiesPerLoanType(loanTypeId);
                if (ds.Tables[0].Rows.Count == 0 || DateTime.Parse(dueDate) > DateTime.Now)
                {
                    totalPenalty += 0;
                    miniPenalty += 0;
                }

                else
                {
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
                                    totalPenalty += initialPenalty;
                                    miniInterest += initialPenalty;

                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * monthlyAmortization;
                                    totalPenalty += initialPenalty;
                                    miniInterest += initialPenalty;
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
                                    totalPenalty += initialPenalty;
                                    miniPenalty += initialPenalty;
                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * remainingBalance;
                                    totalPenalty += initialPenalty;
                                    miniInterest += initialPenalty;
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
                                    totalPenalty += initialPenalty;
                                    miniInterest += initialPenalty;
                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * grantedLoanAmount;
                                    totalPenalty += initialPenalty;
                                    miniInterest += initialPenalty;
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
                                    totalPenalty += initialPenalty;
                                    miniPenalty += initialPenalty;
                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount;
                                    totalPenalty += initialPenalty;
                                    miniInterest += initialPenalty;
                                }
                            }
                        }
                    }//end for loop


                }//end else

            }

            totalBalance += totalPenalty;
            return miniPenalty + " " + miniInterest;
        }
    }
}
