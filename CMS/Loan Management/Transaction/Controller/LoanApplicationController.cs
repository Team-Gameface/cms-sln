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

namespace CMS.Loan_Management.Transaction.Controller
{
    class LoanApplicationController
    {
        double loanBal = 0, totPen = 0;
        Transaction.Model.LoanApplicationModel loanApplicationModel;
        Transaction.View.LoanApplication loanApplication;

        Boolean isbtnDetailsPrevious = false;
        Boolean isAddEditCollateral = false;
        Boolean isAddEditComaker = false;
        Boolean isAddCollateral = false;
        Boolean isAddComaker = false;
        Boolean hasSpouse = false;
        int collateralIndex = 0;
        int comakerIndex = 0;
        int isCollateral = 0;
        int noOfComakers = 0;

        String finalAccountNo = String.Empty;
        int finalMemberType = 0;
        int loanAppId = 0;

        String accountNo = String.Empty;
        String memberName = String.Empty;

        Dictionary<int, string> charges = new Dictionary<int, string>();
        int noOfAmortizations = 0;
        double amortizationAmt = 0;
        DateTime maturityDate = DateTime.Now;

        double totalInterest = 0;

        public LoanApplicationController(Transaction.Model.LoanApplicationModel loanApplicationModel, Transaction.View.LoanApplication loanApplication, Loan_Management.LoanManagementMenu loanMenu)
        {
            this.loanApplicationModel = loanApplicationModel;
            this.loanApplication = loanApplication;
            this.loanApplication.setBtnAddCollateralEventHandler(this.btnAddCollateral);
            this.loanApplication.setBtnAddComakerEventHandler(this.btnAddComaker);
            this.loanApplication.setBtnApplyLoanEventHandler(this.btnApplyLoan);
            this.loanApplication.setBtnCancelLoanEventHandler(this.btnCancelLoan);
            this.loanApplication.setBtnCollateralNextEventHandler(this.btnCollateralNext);
            this.loanApplication.setBtnCollateralPreviousEventHandler(this.btnCollateralPrevious);
            this.loanApplication.setBtnComakerPreviousEventHandler(this.btnComakerPrevious);
            this.loanApplication.setBtnComakerNextEventHandler(this.btnComakerNext);
            this.loanApplication.setBtnApprovalPreviousEventHandler(this.btnApprovalPrevious);
            this.loanApplication.setBtnDetailsNextEventHandler(this.btnDetailsNext);
            this.loanApplication.setBtnDetailsPreviousEventHandler(this.btnDetailsPrevious);
            this.loanApplication.setBtnEditCollateralEventHandler(this.btnEditCollateral);
            this.loanApplication.setBtnProceedEventHandler(this.btnProceed);
            this.loanApplication.setBtnDeleteComakerEventHandler(this.btnDeleteComaker);
            this.loanApplication.setBtnSaveCollateralEventHandler(this.btnSaveCollateral);
            this.loanApplication.setBtnDeleteCollateralEventHandler(this.btnDeleteCollateral);
            this.loanApplication.setBtnCancelCollateralEventHandler(this.btnCancelCollateral);
            this.loanApplication.chbLoanBalance_CheckChanged(loanBalance);
            this.loanApplication.setBtnEditComakerEventHandler(this.btnEditComaker);
            this.loanApplication.setBtnSaveComakerEventHandler(this.btnSaveComaker);
            this.loanApplication.setBtnCancelComakerEventHandler(this.btnCancelComaker);
            this.loanApplication.disableCollateralFunction();
            this.loanApplication.txtPurpose_TextChanged(this.changeLabelCount);
            this.loanApplication.txtCMMemberName_TextChanged(this.searchCMMemberName);
            this.loanApplication.txtCMAccountNo_TextChanged(this.searchCMAccountNo);
            this.loanApplication.txtMemberName_TextChanged(this.searchMemberName);
            this.loanApplication.txtAccountNo_TextChanged(this.searchAccountNo);
            this.loanApplication.cbLoanType_SelectedIndexChanged(this.loanTypeSelected);
            this.loanApplication.dataActiveMember_CellClick(this.showShareCapitalAndSavings);
            this.loanApplication.activeMemberGrid(this.loanApplicationModel.selectActiveMemberWithLoan());
            this.loanApplication.amount_TextChanged(addNetLoan);
            this.loanApplication.dateApproved_ValueChanged(setMaturityDate);
            this.loanApplication.udPaymentDuration_ValueChanged(durationAndTermsChanged);
            this.loanApplication.cbDurationStatus_SelectedIndexChanged(durationStatusChanged);
            this.loanApplication.cbTerms_SelectedIndexChanged(durationAndTermsChanged);
            this.loanApplication.txtLoanAmount_Leave(loanAmountLeave);
            this.loanApplication.txtAmount_TextChanged(txtAmountChange);
            this.loanApplication.disableFunction();
            this.loanApplication.enableDataActiveMember();
            this.loanApplication.MdiParent = loanMenu;
            this.loanApplication.Show();
            this.loanApplication.clearSelectionActiveMember();
        }


        public void loanBalance(object sender, EventArgs e)
        {
            if (this.loanApplication.getLoanBalanceStatus())
            {
                loanBalanceFunc();
            }
            else 
            {
                this.loanApplication.setLoanBalance(0);
                this.loanApplication.clearPenaltyList();
            }
        }

        public void loanBalInterestRateFunction() 
        {
            totalInterest = 0;


            Dictionary<String, int> listOfInterestDates = new Dictionary<String, int>();
            Dictionary<String, int> finalListOfInterestDates = new Dictionary<String, int>();
            int lappId = Convert.ToInt32(this.loanApplication.dataAmortization.Rows[0].Cells[4].Value);
            double lastInterest = this.loanApplicationModel.selectLastInterest(lappId);

            if (lastInterest != 0)
            {
                totalInterest += lastInterest;
            }
            String maturityDate = this.loanApplicationModel.selectMaturityDate(lappId);
            String interestDate = (DateTime.Parse(maturityDate).AddDays(1)).ToString();
            String[] interest = this.loanApplicationModel.selectInterestPerLoanType(this.loanApplication.getTypeOfLoan()).Split(' ');

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
                        int i = this.loanApplicationModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

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
                            double grantedLoanAmount = this.loanApplicationModel.selectGrantedLoanAmount(lappId);
                            String[] paymentDur = this.loanApplicationModel.selectPaymentDurationPerApplication(lappId).Split(' ');
                            int pdValue = int.Parse(paymentDur[0]);
                            String pdStatus = paymentDur[1];
                            if (interestRateStatus == "%") 
                            {
                                if (pdStatus == "week/s") 
                                {
                                    finalInterest = grantedLoanAmount * ((interestRate/4)*pdValue); 
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
                            this.loanApplication.setPenaltyList("Interest Rate: " + pair.Key + "- Php " + finalInterest);
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
                        int i = this.loanApplicationModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

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
                            double grantedLoanAmount = this.loanApplicationModel.selectGrantedLoanAmount(lappId);
                            String[] paymentDur = this.loanApplicationModel.selectPaymentDurationPerApplication(lappId).Split(' ');
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
                                    finalInterest = grantedLoanAmount * ((interestRate/12) * pdValue);
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
                            this.loanApplication.setPenaltyList("Interest Rate: " + pair.Key + "- Php " + finalInterest);
                        }
                    }
                }
            }

            if (this.loanApplication.getIfPenaltyListIsEmpty("Interest Rate"))
            {
                this.loanApplication.setPenaltyList("No interest.");
            }

        }

        public void loanBalanceFunc() 
        {
            double totalPenalty = 0;
            int noOfLoanBalance = 0;
                int loanApplicationId = this.loanApplicationModel.selectUnclearedLoan(finalAccountNo);

                if (loanApplicationId > 0)
                {
                    loanAppId = loanApplicationId;
                    if (this.loanApplicationModel.selectIfLoanIsAmnestized(loanApplicationId))
                    {
                        this.loanApplication.setPenaltyList("Amnestied");
                        String[] money = this.loanApplicationModel.selectCurrentLoanBalance(loanApplicationId).Split(' ');
                        double penalty = double.Parse(money[0]);
                        double interest = double.Parse(money[1]);
                        double loanBalance = double.Parse(money[2]) - penalty - interest;
                        loanBal += loanBalance;
                        totPen += penalty;
                        totalInterest += interest;
                        this.loanApplication.setLoanBalance(loanBalance + interest);
                        this.loanApplication.setPenalty(penalty);
                        String[] loanType = this.loanApplicationModel.selectUnclearedLoanType(loanApplicationId).Split(' ');
                        int loanTypeId = Convert.ToInt32(loanType[0]);
                        this.loanApplication.classGridAmortization(this.loanApplicationModel.selectAmortizations(finalAccountNo, loanTypeId));
                    }
                    else
                    {
                        try
                        {
                            String[] loanType = this.loanApplicationModel.selectUnclearedLoanType(loanApplicationId).Split(' ');
                            int loanTypeId = Convert.ToInt32(loanType[0]);
                            this.loanApplication.classGridAmortization(this.loanApplicationModel.selectAmortizations(finalAccountNo, loanTypeId));


                            int lappId = Convert.ToInt32(this.loanApplication.dataAmortization.Rows[0].Cells[4].Value);

                            foreach (DataGridViewRow rows in this.loanApplication.dataAmortization.Rows)
                            {
                                noOfLoanBalance++;
                            }
                            double grantedLoanAmount = this.loanApplicationModel.selectGrantedLoanAmount(loanApplicationId);
                            double remainingBalance = this.loanApplicationModel.selectRemainingBalance(loanApplicationId);
                            String maturityDate = this.loanApplicationModel.selectMaturityDate(loanApplicationId);

                            this.loanApplication.setPenaltyList("Loan Type: " + loanType[1]);
                            this.loanApplication.setPenaltyList("Loan Amount: " + grantedLoanAmount);
                            this.loanApplication.setPenaltyList("Maturity Date: " + maturityDate);
                            this.loanApplication.setPenaltyList("No. of Amortizations: " + noOfLoanBalance);
                            this.loanApplication.setPenaltyList("Remaining Balance: " + remainingBalance);
                            this.loanApplication.setPenaltyList("");
                            this.loanApplication.setPenaltyList("INTERESTS:");
                            loanBalInterestRateFunction();
                            this.loanApplication.setPenaltyList("");
                            this.loanApplication.setPenaltyList("PENALTIES:");
                            this.loanApplication.setPenaltyList("");
                            double lastPenalty = this.loanApplicationModel.selectLastPenalty(lappId);
                            if (lastPenalty != 0)
                            {
                                DataSet penaltySet = this.loanApplicationModel.selectAmortizationWithPenalty(lappId);
                                for (int i = 0; i < penaltySet.Tables[0].Rows.Count; i++)
                                {
                                    int amoId = Convert.ToInt32(penaltySet.Tables[0].Rows[i][0]);
                                    double penalty = this.loanApplicationModel.selectAmortizationPenalty(amoId);
                                }

                                totalPenalty += lastPenalty;
                            }

                            foreach (DataGridViewRow rows in this.loanApplication.dataAmortization.Rows)
                            {
                                DataSet ds2 = this.loanApplicationModel.selectMonthlyAmortization(loanApplicationId);
                                double monthlyAmortization = double.Parse(ds2.Tables[0].Rows[0][0].ToString());
                                String loanDurationStatus = ds2.Tables[0].Rows[0][1].ToString();
                                if (loanDurationStatus == "week/s") { monthlyAmortization *= 4; }
                                else if (loanDurationStatus == "year/s") { monthlyAmortization /= 12; }

                                String dueDate = rows.Cells[3].Value.ToString();
                                double amortizationAmount = double.Parse(rows.Cells[2].Value.ToString());

                                DataSet ds = this.loanApplicationModel.selectPenaltiesPerLoanType(loanTypeId);
                                if (ds.Tables[0].Rows.Count == 0 || DateTime.Parse(dueDate) > DateTime.Now)
                                {
                                    this.loanApplication.setPenalty(0);
                                    this.loanApplication.setPenaltyList("No penalties - Amortization #" + rows.Cells[1].Value.ToString());
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
                                                    this.loanApplication.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                                }
                                            }
                                            else
                                            {
                                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                                {
                                                    initialPenalty = amount * monthlyAmortization;
                                                    totalPenalty += initialPenalty;
                                                    this.loanApplication.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
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
                                                    this.loanApplication.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                                }
                                            }
                                            else
                                            {
                                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                                {
                                                    initialPenalty = amount * remainingBalance;
                                                    totalPenalty += initialPenalty;
                                                    this.loanApplication.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
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
                                                    this.loanApplication.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                                }
                                            }
                                            else
                                            {
                                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                                {
                                                    initialPenalty = amount * grantedLoanAmount;
                                                    totalPenalty += initialPenalty;
                                                    this.loanApplication.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
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
                                                    this.loanApplication.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                                }
                                            }
                                            else
                                            {
                                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                                {
                                                    initialPenalty = amount;
                                                    totalPenalty += initialPenalty;
                                                    this.loanApplication.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                                }
                                            }
                                        }
                                    }//end for loop

                                    if (this.loanApplication.getIfPenaltyListIsEmpty("Amortization #" + rows.Cells[1].Value.ToString()))
                                    {
                                        this.loanApplication.setPenaltyList("No penalties - Amortization #" + rows.Cells[1].Value.ToString());
                                    }

                                }//end else

                                this.loanApplication.setPenalty(totalPenalty);
                                this.loanApplication.setLoanBalance(remainingBalance + totalInterest);
                            }
                            totPen += totalPenalty;
                            loanBal += remainingBalance;
                        }
                        catch (Exception) 
                        {
                            this.loanApplication.setPenalty(totalPenalty += this.loanApplicationModel.selectPenaltyByAccountNo(this.finalAccountNo));
                            totPen += totalPenalty;
                            totalInterest += this.loanApplicationModel.selectInterestByAccountNo(this.finalAccountNo);
                            this.loanApplication.setLoanBalance(totalInterest);
                        }
                    }
                }

                else
                {
                    this.loanApplication.setPenaltyList("No loan balance.");
                }
        }

        public void txtAmountChange(object sender, EventArgs e) 
        {
            this.loanApplication.txtAmountChange();
            interestRateFunc();
            maturityDateFunc();
            addChargesFunc();
        }

        public void loanAmountLeave(object sender, EventArgs e) 
        {
            this.loanApplication.setAmount(this.loanApplication.getLoanAmount());
            interestRateFunc();
        }

        public void durationStatusChanged(object sender, EventArgs e)
        {
            this.loanApplication.editTerms();
            maturityDateFunc();
            addChargesFunc();
        }

        public void durationAndTermsChanged(object sender, EventArgs e) 
        {
            maturityDateFunc();
            addChargesFunc();
        }

        public void setMaturityDate(object sender, EventArgs e) 
        {
            maturityDateFunc();
        }

        public void interestRateFunc() 
        {
            String ir = this.loanApplicationModel.selectInterestRate(this.loanApplication.getTypeOfLoan());
            double interest = 0;

            int pdValue = this.loanApplication.getPaymentDurationValue();
            String pdStatus = this.loanApplication.getDurationStatus();

            if (ir != String.Empty)
            {
                String[] interestRate = ir.Split(' ');
                if (interestRate[1] == "Php")
                {
                    if (pdStatus == "week/s")
                    {
                        interest = (double.Parse(interestRate[0]) / 52) * pdValue;
                    }
                    else if (pdStatus == "month/s")
                    {
                        interest = (double.Parse(interestRate[0]) / 12) * pdValue;
                    }
                    else if (pdStatus == "year/s")
                    {
                        interest = double.Parse(interestRate[0]) * pdValue;
                    }  
                }
                else if (interestRate[1] == "%")
                {
                    if (pdStatus == "week/s")
                    {
                        interest = this.loanApplication.getAmount() * (((double.Parse(interestRate[0]) / 100) / 52) * pdValue);
                    }
                    else if (pdStatus == "month/s")
                    {
                        interest = this.loanApplication.getAmount() * (((double.Parse(interestRate[0]) / 100) / 12) * pdValue);
                    }
                    else if (pdStatus == "year/s")
                    {
                        interest = this.loanApplication.getAmount() * (double.Parse(interestRate[0]) / 100) * pdValue;
                    }
                }
            }
            else { interest = 0; }
            this.loanApplication.setInterestRate(interest);
        }

        public void maturityDateFunc() 
        {
            noOfAmortizations = 0;
            amortizationAmt = 0;
            maturityDate = this.loanApplication.getDateOfApproval();

            String paymentDuration = String.Empty;
            String terms = String.Empty;
            //noOfAmortization
            try
            {
                paymentDuration = this.loanApplication.getDurationStatus();
                terms = this.loanApplication.getTermsOfPayment();
            }
            catch (Exception) {}
            int paymentDurationValue = this.loanApplication.getPaymentDurationValue();

            if (paymentDuration == "week/s")
            {
                noOfAmortizations = paymentDurationValue;
                maturityDate = maturityDate.AddDays(paymentDurationValue * 7);
            }
            else if (paymentDuration == "month/s")
            {
                maturityDate = maturityDate.AddMonths(paymentDurationValue);
                if (terms == "weekly") 
                {
                    for (DateTime startDate = this.loanApplication.getDateOfApproval().AddDays(7); startDate <= maturityDate; startDate = startDate.AddDays(7)) 
                    {
                        noOfAmortizations++;
                    }               
                }
                else if (terms == "monthly") { noOfAmortizations = paymentDurationValue; }
            }
            else if (paymentDuration == "year/s")
            {
                maturityDate = maturityDate.AddYears(paymentDurationValue);
                if (terms == "weekly") 
                {
                    for (DateTime startDate = this.loanApplication.getDateOfApproval().AddDays(7); startDate <= maturityDate; startDate = startDate.AddDays(7))
                    {
                        noOfAmortizations++;
                    }  
                }
                else if (terms == "monthly") { noOfAmortizations = paymentDurationValue * 12; }
                else if (terms == "quarterly") { noOfAmortizations = paymentDurationValue * 3; }
                else if (terms == "semi-annually") { noOfAmortizations = paymentDurationValue * 2; }
                else if (terms == "annually") { noOfAmortizations = paymentDurationValue; }
            }

            //maturitydate
            this.loanApplication.setMaturityDate(maturityDate.ToString("MM/dd/yyyy"));


            //amortization amount
            amortizationAmt = this.loanApplication.getAmount() / noOfAmortizations;

        }

        public void addChargesFunc() 
        {
            double finalCharge = 0;
            CheckedListBox.CheckedItemCollection charges = this.loanApplication.getCheckedCharges();

            foreach (String s in charges)
            {
                String[] initAmount = s.Split('-');
                String[] finalAmount = initAmount[1].Split(' ');
                if (initAmount[1].Contains("Php"))
                {
                    finalCharge += double.Parse(finalAmount[1]);
                }
                else if (initAmount[1].Contains("% of loan"))
                {
                    finalCharge = finalCharge + ((double.Parse(finalAmount[1]) / 100) * this.loanApplication.getAmount());
                }
                else if (initAmount[1].Contains("% of amortization"))
                {
                    finalCharge = finalCharge + ((double.Parse(finalAmount[1]) / 100) * amortizationAmt);
                }

            }

            this.loanApplication.setCharges(finalCharge);
        }

        public void addNetLoan(object sender, EventArgs e)
        {
            double netLoan = 0;
            double amount = this.loanApplication.getAmount();
            double charge = this.loanApplication.getCharges();
            double interest = this.loanApplication.getInterestRate();
            double loanBalance = this.loanApplication.getLoanBalance();
            double penalty = this.loanApplication.getPenalty();

            netLoan += amount;
            netLoan -= charge;
            netLoan -= interest;
            netLoan -= loanBalance;
            netLoan -= penalty;

            this.loanApplication.setNetLoan(netLoan);
        }

        public void showShareCapitalAndSavings(object args, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0)
            {
                Boolean hasSavings = this.loanApplicationModel.selectSavingsStatus(this.loanApplication.getMemberType());
                this.loanApplication.setRowSelectionActiveMemberErrorFalse();
                this.loanApplication.setCurrentShareCapital(this.loanApplicationModel.selectCurrentShareCapital(this.loanApplication.getAccountNo()));
                this.loanApplication.setClassification(this.loanApplicationModel.selectClassification(this.loanApplication.getAccountNo()));
                if (hasSavings) { this.loanApplication.setCurrentTotalSavings(this.loanApplicationModel.selectTotalSavings(this.loanApplication.getAccountNo())); }

                else { this.loanApplication.disableSavings(); }
            }
        }

        public void loanTypeSelected(object args, EventArgs e)
        {
            this.loanApplication.setCharges(0);
            this.loanApplication.setAllTpDetailsLabelsToBlack();
            int i = this.loanApplication.getCBLoanTypeIndex();
            if (i == -1) { this.loanApplication.getifcbLoanTypeIndexNegOne(); this.loanApplication.setStatePaymentDurationFalse(); this.loanApplication.setStateMaxAmountFalse(); }
            else
            {
                int selectedLoanTypeId = this.loanApplication.getTypeOfLoan();

                //interest
                interestRateFunc();

                //show clbcharges
                charges.Clear();
                DataTable ds1 = this.loanApplicationModel.selectActiveCharges(selectedLoanTypeId).Tables[0];
                foreach (DataRow dr in ds1.Rows)
                {

                    charges.Add(int.Parse(dr["ChargeId"].ToString()), (dr["Charge Name"].ToString() + " - " + dr["Amount"].ToString() + " " + dr["Amount Status"].ToString()));

                }
                this.loanApplication.addItemsAtCharges(charges);

                isCollateral = this.loanApplicationModel.checkIfLoanIsCollateralized(selectedLoanTypeId);
                noOfComakers = this.loanApplicationModel.checkIfLoanHasComakers(selectedLoanTypeId);
                this.loanApplication.setLblMaxComaker(noOfComakers + "");
                this.loanApplication.setBtnDetailsNext();

                String paymentDuration = this.loanApplicationModel.selectPaymentDuration(selectedLoanTypeId);
                String[] newPD= paymentDuration.Split(' ');
                String finalPD = "";
                for (int ii = 0; ii < newPD.Count(); ii++) 
                {
                    if (newPD[ii] == "0") { newPD[ii] = ""; }
                    finalPD += newPD[ii] + " ";
                }
                
                this.loanApplication.setLblPaymentDuration(finalPD);

                    String maxLoanableAmount = this.loanApplicationModel.selectMaximumLoanableAmount(selectedLoanTypeId);
                    String[] amount = maxLoanableAmount.Split(' ');
                    double fixedAmt = double.Parse(amount[0]);
                    double timesOfSC = double.Parse(amount[1]);
                    double shareCapital = this.loanApplication.getCurrentShareCapital();
                    if(timesOfSC*shareCapital > fixedAmt)
                    {
                        this.loanApplication.setLblMaxAmount(fixedAmt+"");
                    }

                    else
                    {
                        this.loanApplication.setLblMaxAmount((timesOfSC*shareCapital)+"");
                    }
                
            }
        }


        public void searchMemberName(object args, EventArgs e) 
        {
            this.loanApplication.activeMemberGrid(this.loanApplicationModel.searchMemberByMemberName(this.loanApplication.getActiveMemberName()));
            this.loanApplication.clearSelectionActiveMember();
            this.loanApplication.clearSavingsAndShareCapital();
        }

        public void searchAccountNo(object args, EventArgs e) 
        {
            this.loanApplication.activeMemberGrid(this.loanApplicationModel.searchMemberByAccountNo(this.loanApplication.getActiveAccountNo()));
            this.loanApplication.clearSelectionActiveMember();
            this.loanApplication.clearSavingsAndShareCapital();
        }

        public void searchCMMemberName(object args, EventArgs e) 
        {
            this.loanApplication.viewComakerGrid(this.loanApplicationModel.searchComakerByMemberName(this.finalAccountNo,this.loanApplication.getCMMemberName()));
            this.loanApplication.clearSelectionViewComaker();
            this.loanApplication.clearComaker();
        }

        public void searchCMAccountNo(object args, EventArgs e) 
        { 
             this.loanApplication.viewComakerGrid(this.loanApplicationModel.searchComakerByAccountNo(this.finalAccountNo,this.loanApplication.getCMAccountNo()));
             this.loanApplication.clearSelectionViewComaker();
             this.loanApplication.clearComaker();
        }

        public void changeLabelCount(object args, EventArgs e)
        {
            int length = 160;
            length-=this.loanApplication.getPurposeLength();
            this.loanApplication.setLabelLimit(length);
        }

        public void btnProceed(object args, EventArgs e)
        {
      
            int row = this.loanApplication.getActiveMemberIndex();

            if(row>=0)
            {
            
            this.loanApplication.btnProceedFunc();
            this.loanApplication.disableDataActiveMember();
            finalAccountNo = this.loanApplication.getAccountNo();
            finalMemberType = this.loanApplication.getMemberType();

            if (isbtnDetailsPrevious == false)
            {
                int loanCountUnpaid = this.loanApplicationModel.selectIfThereIsAlreadyLoan(finalAccountNo);

                if (loanCountUnpaid == 0)
                {
                    this.loanApplication.setLoanCount(this.loanApplicationModel.selectLoanApprovedCount(this.loanApplication.getAccountNo()));
                    this.loanApplication.addItemsAtTypeOfLoan(this.loanApplicationModel.selectLoanType(finalMemberType));
                    this.loanApplication.setCBLoanTypeIndex();
                }
                else 
                {

                    String message = String.Empty;
                    DataSet ds = this.loanApplicationModel.selectLoanInfo(finalAccountNo);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        message +="Loan Type: "+ ds.Tables[0].Rows[i][0] + "\n";
                        message +="Approved Amount: " + ds.Tables[0].Rows[i][1] + "\n";
                        message +="Date Approved: " + ds.Tables[0].Rows[i][2] + "\n";
                        message +="Maturity Date: " + ds.Tables[0].Rows[i][3] + "\n";
                        message += "\n\n";
                    }

                    DialogResult dialogResult = MessageBox.Show("The member selected has still existing unpaid loan/s. Do you wish to continue?\n\n"+message, "Loan Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes) 
                    {
                        this.loanApplication.setLoanCount(this.loanApplicationModel.selectLoanApprovedCount(this.loanApplication.getAccountNo()));
                        this.loanApplication.addItemsAtTypeOfLoan(this.loanApplicationModel.selectLoanType(finalMemberType));
                        this.loanApplication.setCBLoanTypeIndex();
                    }
                    else
                    {
                        this.loanApplication.disableFunction();
                        this.loanApplication.enableDataActiveMember();
                        this.loanApplication.clearSelectionActiveMember();
                        isbtnDetailsPrevious = false;
                        isAddEditCollateral = false;
                        isAddEditComaker = false;
                        isAddCollateral = false;
                        isAddComaker = false;
                        hasSpouse = false;
                        collateralIndex = 0;
                        comakerIndex = 0;
                        isCollateral = 0;
                        noOfComakers = 0;

                        finalAccountNo = String.Empty;
                        loanAppId = 0;
                        finalMemberType = 0;

                        accountNo = String.Empty;
                        memberName = String.Empty;

                        charges.Clear();
                        noOfAmortizations = 0;
                        amortizationAmt = 0;
                        maturityDate = DateTime.Now;
                    }

                }
            }

            }
        }
        
        
        public void btnDetailsPrevious(object args, EventArgs e) 
        {
            isbtnDetailsPrevious = true;
            this.loanApplication.btnDetailsPreviousFunc();
            this.loanApplication.setAllTpDetailsLabelsToBlack();
        }

        public void btnDetailsNext(object args, EventArgs e)
        {
            this.loanApplication.setAllTpDetailsLabelsToBlack();
            int countError = 0;

            //details-validation
            if (this.loanApplication.getCBLoanTypeIndex() == -1) { this.loanApplication.lblLoanType.ForeColor = Color.Red; countError++; }
            if (this.loanApplication.getPurpose() == String.Empty) { this.loanApplication.lblPurpose.ForeColor = Color.Red; countError++; }
            try
            {
                if (this.loanApplication.getLoanAmount() > this.loanApplication.getMaxAmount()) { this.loanApplication.lblLoanAmount.ForeColor = Color.Red; countError++; }
            }
            catch (Exception) { this.loanApplication.lblLoanAmount.ForeColor = Color.Red; countError++; }
            if (this.loanApplication.getPaymentDurationValue() <= 0) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }
            try
            {
                int value = this.loanApplication.getPaymentDurationValue();
                String duration = this.loanApplication.getDurationStatus();
                if (duration == "month/s") { value *= 4; }
                else if (duration == "year/s") { value *= 48; }
                String[] s = this.loanApplication.getLblPaymentDuration().Split(' ');

                if (this.loanApplication.lblStatePaymentDuration.Text.Contains("infinity")) 
                {
                    if (value < int.Parse(s[0])) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }
                }
                else
                {
                    if (value < int.Parse(s[0]) || value > int.Parse(s[1])) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }
                }
           }
           catch (Exception) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }

            try 
            {
                this.loanApplication.getTermsOfPayment();
            }
            catch (Exception) { this.loanApplication.lblTerms.ForeColor = Color.Red; countError++; }

            //details-validation end

            if(countError == 0)
            {
                this.loanApplication.checkAllCheckBox();
                addChargesFunc();
                if (isCollateral == 1)
                {
                    this.loanApplication.btnDetailsNextFunc();
                }

                if (noOfComakers == 0) //pag walang comaker
                {
                    this.loanApplication.noComakerFunc();
                }

                if (isCollateral == 0 && noOfComakers > 0) //pag walang collateral
                {
                    this.loanApplication.btnCollateralNextFunc();
                    this.loanApplication.viewComakerGrid(this.loanApplicationModel.selectActiveMemberWithNoDeficiency(this.finalAccountNo));
                    this.loanApplication.clearSelectionViewComaker();
                    this.loanApplication.disableComakerFunction();
                }

                if (isCollateral == 0 && noOfComakers == 0) 
                {
                    this.loanApplication.btnComakerNextFunc();
                }
            }
            this.interestRateFunc();
        }
        
        public void btnCollateralPrevious(object args, EventArgs e)
        {
            this.loanApplication.btnCollateralPreviousFunc();
            this.loanApplication.setRowSelectionCollateralErrorFalse();
        }

        public void btnCollateralNext(object args, EventArgs e) 
        {
            this.loanApplication.setPlsAddCollateralFalse();
            this.loanApplication.setAllTpCollateralsLabelsToBlack();
            int countError = 0;

            if (this.loanApplication.dataCollateral.Rows.Count == 0) { this.loanApplication.setPlsAddCollateralTrue(); countError++; }
            
            if (isAddEditCollateral) 
            {
                this.loanApplication.gbProperty.ForeColor = Color.Red;
                countError++;
            }

            if (countError == 0)
            {
                this.loanApplication.btnCollateralNextFunc();
                this.loanApplication.viewComakerGrid(this.loanApplicationModel.selectActiveMemberWithNoDeficiency(this.finalAccountNo));
                this.loanApplication.clearSelectionViewComaker();
                this.loanApplication.disableComakerFunction();
            }
        }

        public void btnComakerPrevious(object args, EventArgs e) 
        {
            if (isCollateral == 1)
            {
                this.loanApplication.btnComakerPreviousFunc();
                this.loanApplication.lblComaker.ForeColor = System.Drawing.Color.Black;
                this.loanApplication.setRowSelectionComakerErrorFalse();
            }
            else 
            {
                this.loanApplication.btnCollateralPreviousFunc();
                this.loanApplication.setRowSelectionCollateralErrorFalse();
            }
        }

        public void btnComakerNext(object args, EventArgs e) 
        {
            this.loanApplication.setPlsAddComakerFalse();
            int countError = 0;

            if (this.loanApplication.dataAddedComaker.Rows.Count == 0) { this.loanApplication.setPlsAddComakerTrue(); countError++; }

            if (isAddEditComaker)
            {
                this.loanApplication.gbSelectedComaker.ForeColor = Color.Red;
                countError++;
            }

            if (countError == 0) 
            {
                this.loanApplication.btnComakerNextFunc();
            }
        }

        public void btnApprovalPrevious(object args, EventArgs e) 
        {
            if (isCollateral == 0 && noOfComakers == 0)
            {
                this.loanApplication.btnCollateralPreviousFunc();
            }
            else if (isCollateral == 1 && noOfComakers == 0)
            {
                this.loanApplication.btnComakerPreviousFunc();
            }
            else
            {
                this.loanApplication.btnApprovalPreviousFunc();
            }
        }

        public void btnAddCollateral(object args, EventArgs e) 
        {
            this.loanApplication.enableCollateralFunction();
            this.loanApplication.setRowSelectionCollateralErrorFalse();
            isAddCollateral = true;
            isAddEditCollateral = true;
        }
        
        public void btnEditCollateral(object args, EventArgs e) 
        {
                this.loanApplication.setPlsAddCollateralFalse();
                this.loanApplication.setRowSelectionCollateralErrorFalse();
                collateralIndex = this.loanApplication.getSelectedCollateralIndex();
                if (collateralIndex >=0)
                {
                    isAddEditCollateral = true;
                    this.loanApplication.enableCollateralFunction();
                    isAddCollateral = false;
                    collateralIndex = this.loanApplication.getSelectedCollateralIndex();
                }

        }
        
        public void btnDeleteCollateral(object args, EventArgs e) 
        {
            this.loanApplication.setPlsAddCollateralFalse();
            this.loanApplication.deleteCollateralRow();
            this.loanApplication.clearSelectionCollateral();
        }
        
        public void btnSaveCollateral(object args, EventArgs e) 
        {
            this.loanApplication.setAllTpCollateralsLabelsToBlack();
            int countError = 0;
            isAddEditCollateral = false;
            String title = this.loanApplication.getTitle();
            String condition = this.loanApplication.getCondition();
            String description = this.loanApplication.getDescription();
            String serialNo = this.loanApplication.getSerialNo();
            int yearAcquired = this.loanApplication.getYearAcquired();
            double acquiredAmount = 0;

            try
            {
                acquiredAmount = this.loanApplication.getAcquiredAmount();
            }
            catch (Exception) { this.loanApplication.lblAcquiredAmount.ForeColor = Color.Red; countError++; }

            if (title == String.Empty) { this.loanApplication.lblTitle.ForeColor = Color.Red; countError++; }
            if (condition == String.Empty) { this.loanApplication.lblCondition.ForeColor = Color.Red; countError++; }
            if (description == String.Empty) { this.loanApplication.lblDescription.ForeColor = Color.Red; countError++; }
            if (serialNo == String.Empty) { this.loanApplication.lblSerialNo.ForeColor = Color.Red; countError++; }

            if (isAddCollateral && countError ==0)
            {
                this.loanApplication.addCollateralRow(title, condition, description, serialNo, yearAcquired, acquiredAmount);
                this.loanApplication.disableCollateralFunction();
                this.loanApplication.clearSelectionCollateral();
                isAddCollateral = false;
            }

            else if (!isAddCollateral && countError ==0)
            {
                this.loanApplication.editCollateralRow(title, condition, description, serialNo, yearAcquired, acquiredAmount, collateralIndex);
                this.loanApplication.disableCollateralFunction();
                this.loanApplication.clearSelectionCollateral();
                collateralIndex = 0;
            }

        }

        public void btnCancelCollateral(object args, EventArgs e) 
        {
            isAddEditCollateral = false;
            isAddCollateral = false;
            this.loanApplication.disableCollateralFunction();
        }
        
        public void btnAddComaker(object args, EventArgs e) 
        {
            if (this.loanApplication.dataAddedComaker.Rows.Count<=noOfComakers)
            {
                hasSpouse = false;
                this.loanApplication.setRowSelectionComakerErrorFalse();
                if (this.loanApplication.getComaker() == String.Empty)
                {
                    this.loanApplication.lblComaker.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    isAddEditComaker = true;
                    this.loanApplication.lblComaker.ForeColor = System.Drawing.Color.Black;
                    this.loanApplication.enableComakerFunction();
                    isAddComaker = true;


                    DataGridViewRow selectedData = this.loanApplication.getSelectedViewComaker();
                    accountNo = selectedData.Cells["Account No."].Value.ToString();
                    memberName = selectedData.Cells["Name"].Value.ToString();

                    String spouse = this.loanApplicationModel.checkSpouseName(accountNo);

                    if (spouse == String.Empty) { this.loanApplication.hideSpouseFields(); }
                    else { this.loanApplication.showSpouseFields(); hasSpouse = true; }
                }
            }
            this.loanApplication.setCMMemberNameUnchecked();
        }

        public void btnEditComaker(object args, EventArgs e)
        {
            hasSpouse = false;
            this.loanApplication.setPlsAddComakerFalse();
            this.loanApplication.lblComaker.ForeColor = System.Drawing.Color.Black;
            this.loanApplication.setRowSelectionComakerErrorFalse();
            comakerIndex = this.loanApplication.getSelectedComakerIndex();
            if (comakerIndex >= 0)
            {
                isAddEditComaker = true;
                String spouse = this.loanApplicationModel.checkSpouseName(this.loanApplication.getAccountNoOfDataAddedMember());

                if (spouse == String.Empty) { this.loanApplication.hideSpouseFields(); }
                else { this.loanApplication.showSpouseFields(); hasSpouse = true; }
                this.loanApplication.enableComakerFunction();
                isAddComaker = false;
                comakerIndex = this.loanApplication.getSelectedComakerIndex();
            }

        }
        
        public void btnDeleteComaker(object args, EventArgs e) 
        {
            this.loanApplication.setPlsAddComakerFalse();
            this.loanApplication.lblComaker.ForeColor = System.Drawing.Color.Black;
            this.loanApplication.deleteAddedComakerRow();
            this.loanApplication.clearSelectionAddedComaker();
        }

        public void btnSaveComaker(object args, EventArgs e) 
        {
            this.loanApplication.setAllTpComakersLabelsToBlack();
            int countError = 0;
            isAddEditComaker = false;
            String resCertNo = this.loanApplication.getCResidentCertNo();
            String resPlaceOfIssue = this.loanApplication.getCPlaceIssued();
            String resDateIssued = this.loanApplication.getDateRIssued();
            String spouseResCertNo = String.Empty;
            String spousePlaceOfIssue = String.Empty;
            String spouseDateIssued = String.Empty;

            if (resCertNo == String.Empty) { this.loanApplication.lblResCertNo.ForeColor = Color.Red; countError++; }
            if (resPlaceOfIssue == String.Empty) { this.loanApplication.lblRPlaceIssued.ForeColor = Color.Red; countError++; }

            if (hasSpouse)
            {
                spouseResCertNo = this.loanApplication.getSResidentCertNo();
                spousePlaceOfIssue = this.loanApplication.getSPlaceIssued();
                spouseDateIssued = this.loanApplication.getDateSIssued();

                if (spouseResCertNo == String.Empty) { this.loanApplication.lblSpouseCertNo.ForeColor = Color.Red; countError++; }
                if (spousePlaceOfIssue == String.Empty) { this.loanApplication.lblSPlaceIssued.ForeColor = Color.Red; countError++; }
            }


            if (isAddComaker && countError ==0)
            {
                this.loanApplication.addComakerRow(accountNo, memberName, resCertNo, resPlaceOfIssue, resDateIssued, spouseResCertNo, spousePlaceOfIssue, spouseDateIssued);
                this.loanApplication.disableComakerFunction();
                this.loanApplication.clearSelectionViewComaker();
                this.loanApplication.clearSelectionAddedComaker();
                this.loanApplication.setPlsAddComakerFalse();
                this.loanApplication.hideSpouseFields();
                isAddComaker = false;
            }

            else if (!isAddEditComaker && countError ==0)
            {
                this.loanApplication.editComakerRow(resCertNo, resPlaceOfIssue, resDateIssued, spouseResCertNo, spousePlaceOfIssue, spouseDateIssued, comakerIndex);
                this.loanApplication.disableComakerFunction();
                this.loanApplication.clearSelectionAddedComaker();
                this.loanApplication.hideSpouseFields();
                collateralIndex = 0;
            }

        }

        public void btnCancelComaker(object args, EventArgs e)
        {
            isAddEditComaker = false;
            isAddComaker = false;
            this.loanApplication.clearSelectionViewComaker();
            this.loanApplication.disableComakerFunction();
        }
        
        public void btnCancelLoan(object args, EventArgs e) 
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?\nAll inputs will be reset.", "Cancel Loan Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.loanApplication.disableFunction();
                this.loanApplication.enableDataActiveMember();
                this.loanApplication.clearSelectionActiveMember();
                isbtnDetailsPrevious = false;
                isAddEditCollateral = false;
                isAddEditComaker = false;
                isAddCollateral = false;
                isAddComaker = false;
                hasSpouse = false;
                collateralIndex = 0;
                comakerIndex = 0;
                isCollateral = 0;
                noOfComakers = 0;

                finalAccountNo = String.Empty;
                loanAppId = 0;
                finalMemberType = 0;

                accountNo = String.Empty;
                memberName = String.Empty;

                charges.Clear();
                noOfAmortizations = 0;
                amortizationAmt = 0;
                maturityDate = DateTime.Now;
            }
        }
        
        public void btnApplyLoan(object args, EventArgs e) 
        {
            this.loanApplication.setAllTpDetailsLabelsToBlack();
            int countError = 0;

            //details validation start
            if (this.loanApplication.getCBLoanTypeIndex() == -1) { this.loanApplication.lblLoanType.ForeColor = Color.Red; countError++; }
            if (this.loanApplication.getPurpose() == String.Empty) { this.loanApplication.lblPurpose.ForeColor = Color.Red; countError++; }
            try
            {
                if (this.loanApplication.getLoanAmount() > this.loanApplication.getMaxAmount()) { this.loanApplication.lblLoanAmount.ForeColor = Color.Red; countError++; }
            }
            catch (Exception) { this.loanApplication.lblLoanAmount.ForeColor = Color.Red; countError++; }
            if (this.loanApplication.getPaymentDurationValue() <= 0) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }
            try
            {
                int value = this.loanApplication.getPaymentDurationValue();
                String duration = this.loanApplication.getDurationStatus();
                if (duration == "month/s") { value *= 4; }
                else if (duration == "year/s") { value *= 48; }
                String[] s = this.loanApplication.getLblPaymentDuration().Split(' ');

                if (this.loanApplication.lblStatePaymentDuration.Text.Contains("infinity"))
                {
                    if (value < int.Parse(s[0])) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }
                }
                else
                {
                    if (value < int.Parse(s[0]) || value > int.Parse(s[1])) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }
                }
            }
            catch (Exception) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }

            try
            {
                this.loanApplication.getTermsOfPayment();
            }
            catch (Exception) { this.loanApplication.lblTerms.ForeColor = Color.Red; countError++; }

            //details validation end


            //collaterals validation start
            if (isCollateral != 0)
            {
                this.loanApplication.setPlsAddCollateralTrue();
                this.loanApplication.setAllTpCollateralsLabelsToBlack();

                if (this.loanApplication.dataCollateral.Rows.Count == 0) { this.loanApplication.setPlsAddCollateralTrue(); countError++; }

                if (isAddEditCollateral)
                {
                    this.loanApplication.gbProperty.ForeColor = Color.Red;
                    countError++;
                }
            }
            //collaterals validation end


            //comakers validation start
            if (noOfComakers != 0)
            {
                this.loanApplication.setPlsAddComakerFalse();
                this.loanApplication.setAllTpComakersLabelsToBlack();

                if (this.loanApplication.dataAddedComaker.Rows.Count == 0) { this.loanApplication.setPlsAddComakerTrue(); countError++; }

                if (isAddEditComaker)
                {
                    this.loanApplication.gbSelectedComaker.ForeColor = Color.Red;
                    countError++;
                }
            }
            //comakers validation end


            //loan approvaldetails start
            double netLoan = this.loanApplication.getNetLoan();
            this.loanApplication.lblNetLoan.ForeColor = Color.Black;

            if (netLoan < 0) { this.loanApplication.lblNetLoan.ForeColor = Color.Red; countError++; }
            //loan approval details end

            if(countError ==0)
            {


                //insert loanapplication start

                int loanApplicationId = 0;

                int loanTypeId = this.loanApplication.getTypeOfLoan();
                String purpose = this.loanApplication.getPurpose();
                String paymentDurationStatus = this.loanApplication.getDurationStatus();
                int paymentDurationValue = this.loanApplication.getPaymentDurationValue();
                String terms = this.loanApplication.getTermsOfPayment();
                double loanAmount = this.loanApplication.getLoanAmount();
                double approvedAmount = this.loanApplication.getAmount();
                String dateApproved = this.loanApplication.getDateOfApproval().ToString();
                String dateMaturity = this.loanApplication.getMaturityDate();
                String dateFiled = this.loanApplication.getDateOfFiling();
                double lessCharges = this.loanApplication.getCharges();
                double lessLoanBalance = this.loanApplication.getLoanBalance();
                double lessPenalties = this.loanApplication.getPenalty();
                double lessInterest = this.loanApplication.getInterestRate();


                loanApplicationId = this.loanApplicationModel.insertLoanApplication(finalAccountNo, loanTypeId, purpose, paymentDurationStatus, paymentDurationValue, terms, loanAmount, approvedAmount, dateFiled, dateApproved, dateMaturity, lessCharges, lessLoanBalance, lessPenalties, lessInterest, netLoan);

                    //loanAmortization
                DateTime dueDate = this.loanApplication.getDateOfApproval();

                for (int i = 0; i < noOfAmortizations; i++)
                {
                    if (terms == "weekly") { dueDate = dueDate.AddDays(7); }
                    if (terms == "monthly") { dueDate = dueDate.AddMonths(1); }
                    if (terms == "quarterly") { dueDate = dueDate.AddMonths(4); }
                    if (terms == "semi-annually") { dueDate = dueDate.AddMonths(6); }
                    if (terms == "annually") { dueDate = dueDate.AddYears(1); }

                    this.loanApplicationModel.insertLoanAmortization(loanApplicationId, dueDate.ToString("yyyy-MM-dd"), amortizationAmt);
                }

                //insert loan application end


                //insert collaterals start

                if (collateralIndex >= 0)
                {

                    for (int i = 0; i < this.loanApplication.dataCollateral.Rows.Count; i++)
                    {

                        String title = this.loanApplication.dataCollateral.Rows[i].Cells[0].Value.ToString();
                        String condition = this.loanApplication.dataCollateral.Rows[i].Cells[1].Value.ToString();
                        String description = this.loanApplication.dataCollateral.Rows[i].Cells[2].Value.ToString();
                        String serialNo = this.loanApplication.dataCollateral.Rows[i].Cells[3].Value.ToString();
                        String yearAcquired = this.loanApplication.dataCollateral.Rows[i].Cells[4].Value.ToString();
                        double acquiredAmount = double.Parse(this.loanApplication.dataCollateral.Rows[i].Cells[4].Value.ToString());

                        this.loanApplicationModel.insertCollateral(loanApplicationId, serialNo, title, condition, description, yearAcquired, acquiredAmount);
                    }
                }

                //insert collateral end


                //insert comaker start

                if (comakerIndex >= 0)
                {

                    for (int i = 0; i < this.loanApplication.dataAddedComaker.Rows.Count; i++)
                    {
                        int spouseCheck = 0;
                        String comakerAccountNo = this.loanApplication.dataAddedComaker.Rows[i].Cells[0].Value.ToString();
                        String resCertNo = this.loanApplication.dataAddedComaker.Rows[i].Cells[2].Value.ToString();
                        String placeIssued = this.loanApplication.dataAddedComaker.Rows[i].Cells[3].Value.ToString();
                        String dateIssued = this.loanApplication.dataAddedComaker.Rows[i].Cells[4].Value.ToString();
                        String spouseCertNo = this.loanApplication.dataAddedComaker.Rows[i].Cells[5].Value.ToString();
                        String splaceIssued = this.loanApplication.dataAddedComaker.Rows[i].Cells[6].Value.ToString();
                        String sdateIssued = this.loanApplication.dataAddedComaker.Rows[i].Cells[5].Value.ToString();

                        if (spouseCertNo == String.Empty) { spouseCheck = 1; }
                        this.loanApplicationModel.insertComaker(spouseCheck, loanApplicationId, comakerAccountNo, resCertNo, placeIssued, dateIssued, spouseCertNo, splaceIssued, sdateIssued);
                    }
                }

                //insert comaker end

                if(this.loanApplication.getLoanBalance()!=0){
                if (this.loanApplication.getIfPenaltyListIsEmpty("Amnestied") == false)
                {
                    int ORNo = 0;
                    int rowCount = this.loanApplication.dataAmortization.Rows.Count - 1;
                    foreach (DataGridViewRow rows in this.loanApplication.dataAmortization.Rows)
                    {
                        if (rows.Index == rowCount) { this.loanApplicationModel.insertLoanPayment("Loan", finalAccountNo, Convert.ToInt32(rows.Cells[4].Value), loanBal, totalInterest, totPen, rows.Cells[3].Value.ToString(), false, 1, 0); }
                        else { ORNo = this.loanApplicationModel.insertLoanPayment("Loan", finalAccountNo, Convert.ToInt32(rows.Cells[4].Value), loanBal, totalInterest, totPen, rows.Cells[3].Value.ToString(), false, 1, 1); }
                        this.loanApplicationModel.insertAmortizationPayment(ORNo, Convert.ToInt32(rows.Cells[4].Value), rows.Cells[3].Value.ToString(), double.Parse(rows.Cells[2].Value.ToString()));
                    }
                }
                else
                {
                    int ORNo = 0;
                    Boolean check = false;
                    if (this.loanApplication.dataAmortization.Rows.Count ==0)
                    {
                        this.loanApplicationModel.insertRemainingPayment("Loan", loanAppId,finalAccountNo, totPen, totalInterest, false, 1);
                        this.loanApplicationModel.clearLoan(loanAppId);
                    }

                    else
                    {
                        foreach (DataGridViewRow rows in this.loanApplication.dataAmortization.Rows)
                        {
                                if (!check) { ORNo = this.loanApplicationModel.insertLoanPayment("Loan", finalAccountNo, Convert.ToInt32(rows.Cells[4].Value), loanBal, totalInterest, totPen, rows.Cells[3].Value.ToString(), false, 1, 0); check = true; }
                                    else { this.loanApplicationModel.insertLoanPayment("Loan", finalAccountNo, Convert.ToInt32(rows.Cells[4].Value), loanBal, totalInterest, totPen, rows.Cells[3].Value.ToString(), false, 1, 1); }
                                    this.loanApplicationModel.insertAmortizationPayment(ORNo, Convert.ToInt32(rows.Cells[4].Value), rows.Cells[3].Value.ToString(), Convert.ToDouble(rows.Cells[2].Value));                            
                        }
                    }
                }

                }
                MessageBox.Show("Loan processing successful", "LOAN INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.loanApplication.disableFunction();
                this.loanApplication.enableDataActiveMember();
                this.loanApplication.clearSelectionActiveMember();
                isbtnDetailsPrevious = false;
                isAddEditCollateral = false;
                isAddEditComaker = false;
                isAddCollateral = false;
                isAddComaker = false;
                hasSpouse = false;
                collateralIndex = 0;
                comakerIndex = 0;
                isCollateral = 0;
                noOfComakers = 0;

                finalAccountNo = String.Empty;
                loanAppId = 0;
                finalMemberType = 0;

                accountNo = String.Empty;
                memberName = String.Empty;

                charges.Clear();
                noOfAmortizations = 0;
                amortizationAmt = 0;
                maturityDate = DateTime.Now;
            }
        }//end applyloan
    






    
    }
}
