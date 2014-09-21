using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Globalization;

namespace CMS.Loan_Management.Transaction.Controller
{
    class LoanAmnestyController
    {
        Transaction.Model.LoanAmnestyModel loanAmnestyModel;
        Transaction.View.LoanAmnesty loanAmnesty;
        Main.Logger logger = new Main.Logger();
        String finalAccountNo = String.Empty;
        Boolean isDetailsPrevious = false;

        double totalPenalty = 0;
        double totalInterest = 0;

        public LoanAmnestyController(Transaction.Model.LoanAmnestyModel loanAmnestyModel, Transaction.View.LoanAmnesty loanAmnesty, Loan_Management.LoanManagementMenu loanMenu) 
        {
            this.loanAmnestyModel = loanAmnestyModel;
            this.loanAmnesty = loanAmnesty;
            this.loanAmnesty.MdiParent = loanMenu;
            this.loanAmnesty.dataActiveMember_CellClick(showMemberLoanStatus);
            this.loanAmnesty.dataSelectLoan_CellClick(showLoanInfo);
            this.loanAmnesty.setBtnProceedEventHandler(btnProceed);
            this.loanAmnesty.setBtnDetailsPreviousEventHandler(btnDetailsPrevious);
            this.loanAmnesty.setBtnDetailsNextEventHandler(btnDetailsNext);
            this.loanAmnesty.setBtnApprovalPreviousEventHandler(btnApprovalPrevious);
            this.loanAmnesty.setBtnCancelAmnestyEventHandler(btnCancel);
            this.loanAmnesty.setBtnApplyAmnestyEventHandler(btnSave);
            this.loanAmnesty.txtMemberName_TextChanged(this.searchMemberName);
            this.loanAmnesty.txtPenaltyWaive_TextChanged(this.penaltyWaived);
            this.loanAmnesty.txtAccountNo_TextChanged(this.searchAccountNo);
            this.loanAmnesty.txtInterestWaive_TextChanged(this.interestWaived);
            this.loanAmnesty.disableFunction();
            this.showAmnestyMembers();
            this.loanAmnesty.Show();
            this.loanAmnesty.clearSelectionActiveMember();
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Transaction - Loan Amnesty";
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


        public void btnSave(object sender, EventArgs e) 
        {
            int lappId = this.loanAmnesty.getApplicationId();
            String reason = this.loanAmnesty.getPurpose();
            double penalty = this.loanAmnesty.getPenalty();
            double interest = this.loanAmnesty.getInterest();
            double waivedPenaltyPerc = this.loanAmnesty.getPenaltyWaivePercentage();
            double waivedInterestPerc = this.loanAmnesty.getInterestWaivePercentage();
            double loanbal = this.loanAmnesty.getNewLoanBalance();
            String date = this.loanAmnesty.getDateOfApproval();

            this.loanAmnestyModel.insertAmnesty(lappId, reason, penalty, interest, waivedPenaltyPerc, waivedInterestPerc, loanbal, date);

            MessageBox.Show("Loan amnesty transaction successful.","Loan Amnesty",MessageBoxButtons.OK, MessageBoxIcon.Information);
            execLogger("Processed for Loan ID '" + lappId + "'");
            this.loanAmnesty.disableFunction();
            this.showAmnestyMembers();
            finalAccountNo = String.Empty;
            isDetailsPrevious = false;
            totalPenalty = 0;
            totalInterest = 0;
        }

        public void interestWaived(object args, EventArgs e)
        {
            if (this.loanAmnesty.getInterestWaivePercentage() > 100)
                this.loanAmnesty.setInterestWaivePercentage(100);
            double intWaived = this.loanAmnesty.getInterestWaivePercentage();
            double interest = this.loanAmnesty.getInterest();

            this.loanAmnesty.setWaivedInterest((intWaived * 0.01) * interest);
            this.loanAmnesty.setNewLoanBalance(this.loanAmnesty.getGrossLoanBalance() - (this.loanAmnesty.getWaivePenalty() + this.loanAmnesty.getWaiveInterest()));

        }

        public void penaltyWaived(object args, EventArgs e)
        {
            if (this.loanAmnesty.getPenaltyWaivePercentage() > 100)
                this.loanAmnesty.setPenaltyWaivePercentage(100);
            double penaltyWaived = this.loanAmnesty.getPenaltyWaivePercentage();
            double penalty = this.loanAmnesty.getPenalty();

            this.loanAmnesty.setWaivePenalty((penaltyWaived * 0.01) * penalty);
            this.loanAmnesty.setNewLoanBalance(this.loanAmnesty.getGrossLoanBalance() - (this.loanAmnesty.getWaivePenalty() + this.loanAmnesty.getWaiveInterest()));

        }

        public void searchMemberName(object args, EventArgs e)
        {
            int value;
            String status, finalStatus = String.Empty;

            try
            {
                String[] duration = this.loanAmnestyModel.selectAmnestyDuration().Split(' ');
                value = int.Parse(duration[0]);
                status = duration[1];
                if (status == "month/s") { finalStatus = "month"; }
                else if (status == "year/s") { finalStatus = "year"; }
            }
            catch (Exception) { value = 0; finalStatus = "day"; }

            this.loanAmnesty.activeMemberGrid(this.loanAmnestyModel.searchMemberByMemberName(this.loanAmnesty.getActiveMemberName(), value, finalStatus));
            this.loanAmnesty.clearSelectionActiveMember();
            this.loanAmnesty.clearMemberInfoData();
        }

        public void searchAccountNo(object args, EventArgs e)
        {
            int value;
            String status, finalStatus = String.Empty;

            try
            {
                String[] duration = this.loanAmnestyModel.selectAmnestyDuration().Split(' ');
                value = int.Parse(duration[0]);
                status = duration[1];
                if (status == "month/s") { finalStatus = "month"; }
                else if (status == "year/s") { finalStatus = "year"; }
            }
            catch (Exception) { value = 0; finalStatus = "day"; }

            this.loanAmnesty.activeMemberGrid(this.loanAmnestyModel.searchMemberByAccountNo(this.loanAmnesty.getActiveAccountNo(),value, finalStatus));
            this.loanAmnesty.clearSelectionActiveMember();
            this.loanAmnesty.clearMemberInfoData();
        }

        public void btnCancel(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?\nAll inputs will be reset.", "Cancel Loan Amnesty", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.loanAmnesty.disableFunction();
                finalAccountNo = String.Empty;
                isDetailsPrevious = false;
                totalPenalty = 0;
                totalInterest = 0;
            }
        }

        public void showLoanInfo(object sender, DataGridViewCellEventArgs e) 
        {
            this.loanAmnesty.clearLoanDetails();
           if(e.RowIndex>=0){
            int lappId = this.loanAmnesty.getApplicationId();
            String[] loanInfo = this.loanAmnestyModel.selectLoanInfo(lappId).Split('-');

            this.loanAmnesty.setLoanDetails("Loan Type: " + loanInfo[0]);
            this.loanAmnesty.setLoanDetails("Approved Amount: Php" + (double.Parse(loanInfo[1])).ToString("N", CultureInfo.InvariantCulture));
            this.loanAmnesty.setLoanDetails("Date Approved: "+ loanInfo[2]);
            this.loanAmnesty.setLoanDetails("Maturity Date: " + loanInfo[3]);
            this.loanAmnesty.setLoanDetails("Amortizations Paid: Php" + this.loanAmnestyModel.selectAmortizationsPaid(lappId).ToString("N", CultureInfo.InvariantCulture));
            this.loanAmnesty.setLoanDetails("Current Balance: Php" + this.loanAmnestyModel.selectCurrentBalance(lappId).ToString("N", CultureInfo.InvariantCulture));

            this.loanAmnesty.setLoanAmount(this.loanAmnestyModel.selectCurrentBalance(lappId));

            totalPenalty = 0;
            totalInterest = 0;

            double lastInterest = this.loanAmnestyModel.selectLastInterest(lappId);

            if (lastInterest != 0)
            {
                totalInterest += lastInterest;
            }

            Dictionary<String, int> listOfInterestDates = new Dictionary<String, int>();
            Dictionary<String, int> finalListOfInterestDates = new Dictionary<String, int>();

            String maturityDate = this.loanAmnestyModel.selectMaturityDate(lappId);
            String interestDate = (DateTime.Parse(maturityDate).AddDays(1)).ToString();
            String[] interest = this.loanAmnestyModel.selectInterestPerLoanType(this.loanAmnesty.getLoanTypeId()).Split(' ');

            if (DateTime.Now > DateTime.Parse(maturityDate) && interest[0] != "")
            {
                String interestRateStatus = interest[0];
                double interestRate = Convert.ToDouble(interest[1]);
                String per = interest[2];
                if (per == "month") interestRate *= 12;
                if (interestRateStatus == "%") { interestRate *= 0.01; }

                for (String a = interestDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(1)).ToString())
                {
                    listOfInterestDates.Add(a, 0);
                }

                foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                {
                    String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                    String secondDate = DateTime.Parse(pair.Key).AddMonths(1).ToString();
                    int i = this.loanAmnestyModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

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
                        double grantedLoanAmount = double.Parse(loanInfo[1]);
                        String[] paymentDur = this.loanAmnestyModel.selectPaymentDurationPerApplication(lappId).Split(' ');
                        int pdValue = int.Parse(paymentDur[0]);
                        String pdStatus = paymentDur[1];

                        if (pdStatus == "week/s")
                        {
                            pdValue *= 4;
                        }
                        else if (pdStatus == "month/s")
                        {
                            pdValue *= 1;

                        }
                        else if (pdStatus == "year/s")
                        {
                            pdValue /= 12;

                        }

                        if (interestRateStatus == "%")
                        {
                            finalInterest = grantedLoanAmount * (interestRate / 12) * pdValue;

                        }

                        else if (interestRateStatus == "Php")
                        {

                            finalInterest = (interestRate / 12) * pdValue;

                        }
                        totalInterest += finalInterest;
                    }
                }
            }

            this.loanAmnesty.setInterest(totalInterest);
            this.loanAmnesty.setLoanDetails("Total Interests: Php" + totalInterest.ToString("N", CultureInfo.InvariantCulture));

            this.loanAmnesty.classGridAmortization(this.loanAmnestyModel.selectAmortizations(finalAccountNo, lappId));

            double lastPenalty = this.loanAmnestyModel.selectLastPenalty(lappId);
            if (lastPenalty != 0)
            {
                DataSet penaltySet = this.loanAmnestyModel.selectAmortizationWithPenalty(lappId);
                for (int i = 0; i < penaltySet.Tables[0].Rows.Count; i++)
                {
                    int amoId = Convert.ToInt32(penaltySet.Tables[0].Rows[i][0]);
                    double penalty = this.loanAmnestyModel.selectAmortizationPenalty(amoId);
                }

                totalPenalty += lastPenalty;
            }
            foreach (DataGridViewRow rows in this.loanAmnesty.dataAmortization.Rows)
            {
                DataSet ds2 = this.loanAmnestyModel.selectMonthlyAmortization(lappId);
                double monthlyAmortization = double.Parse(ds2.Tables[0].Rows[0][0].ToString());
                String loanDurationStatus = ds2.Tables[0].Rows[0][1].ToString();
                if (loanDurationStatus == "week/s") { monthlyAmortization *= 4; }
                else if (loanDurationStatus == "year/s") { monthlyAmortization /= 12; }
                double grantedLoanAmount = double.Parse(loanInfo[1]);
                double remainingBalance = this.loanAmnestyModel.selectCurrentBalance(lappId);

                String dueDate = rows.Cells[3].Value.ToString();
                double amortizationAmount = double.Parse(rows.Cells[2].Value.ToString());

                DataSet ds = this.loanAmnestyModel.selectPenaltiesPerLoanType(this.loanAmnesty.getLoanTypeId());
                if (ds.Tables[0].Rows.Count == 0 || DateTime.Parse(dueDate) > DateTime.Now)
                {
                    totalPenalty = 0;
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

                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * monthlyAmortization;
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
                                    totalPenalty += initialPenalty;

                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * remainingBalance;
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
                                    totalPenalty += initialPenalty;

                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * grantedLoanAmount;
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
                                    totalPenalty += initialPenalty;

                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount;
                                    totalPenalty += initialPenalty;

                                }
                            }
                        }
                    }//end for loop


                    this.loanAmnesty.setPenalty(totalPenalty);

                }//end else

            }
            this.loanAmnesty.setLoanDetails("Total Penalties: Php" + totalPenalty.ToString("N", CultureInfo.InvariantCulture));
            this.loanAmnesty.setLoanBalance(totalPenalty + totalInterest + this.loanAmnestyModel.selectCurrentBalance(lappId));
            this.loanAmnesty.setGrossLoanBalance(totalPenalty + totalInterest + this.loanAmnestyModel.selectCurrentBalance(lappId));
            }
           
          
        }

        public void btnApprovalPrevious(object sender, EventArgs e)
        {
            this.loanAmnesty.btnApprovalPreviousFunction();
        }

        public void btnDetailsNext(object sender, EventArgs e)
        {
            this.loanAmnesty.btnDetailsNextFunction();

            String[] waive = this.loanAmnestyModel.selectWaivable().Split(' ');

            if (waive[0] == "1") { this.loanAmnesty.enableIWaive(); }
            if (waive[1] == "1") { this.loanAmnesty.enablePWaive(); }
        }

        public void btnDetailsPrevious(object sender, EventArgs e) 
        {
            this.loanAmnesty.btnDetailsPreviousFunction();
            isDetailsPrevious = true;
        }

        public void btnProceed(object sender, EventArgs e) 
        {
            this.loanAmnesty.disableDataActiveMember();
            this.loanAmnesty.btnProceedFunction();

            if(isDetailsPrevious == false)
            {
                int value;
                String status, finalStatus = String.Empty;
                try
                {
                    String[] duration = this.loanAmnestyModel.selectAmnestyDuration().Split(' ');
                    value = int.Parse(duration[0]);
                    status = duration[1];
                    if (status == "month/s") { finalStatus = "month"; }
                    else if (status == "year/s") { finalStatus = "year"; }
                }
                catch (Exception) { value = 0; finalStatus = "day"; }

                this.loanAmnesty.selectLoanGrid(this.loanAmnestyModel.selectLoan(finalAccountNo, value, finalStatus));
            this.loanAmnesty.clearSelectionLoan();
            }
        }

        public void showMemberLoanStatus(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0)
            {
                finalAccountNo = this.loanAmnesty.getAccountNo();
                this.loanAmnesty.setUnpaidLoan(this.loanAmnestyModel.selectUnpaidLoans(finalAccountNo));
                this.loanAmnesty.setTotalLoanBalance(this.loanAmnestyModel.selectTotalLoanBalance(finalAccountNo));
                this.loanAmnesty.setLastPaymentDate(this.loanAmnestyModel.selectLastPaymentDate(finalAccountNo));
                this.loanAmnesty.setClassification(this.loanAmnestyModel.selectClassification(finalAccountNo));
            }
        }

        public void showAmnestyMembers() 
        {
            int value;
            String status, finalStatus = String.Empty;

            try
            {
                String[] duration = this.loanAmnestyModel.selectAmnestyDuration().Split(' ');
                value = int.Parse(duration[0]);
                status = duration[1];
                if (status == "month/s") { finalStatus = "month"; }
                else if (status == "year/s") { finalStatus = "year"; }                
            }
            catch (Exception) { value = 0; finalStatus = "day"; }

            this.loanAmnesty.activeMemberGrid(this.loanAmnestyModel.selectActiveMember(value, finalStatus));
        }

    }
}
