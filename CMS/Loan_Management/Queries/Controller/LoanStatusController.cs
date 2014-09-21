using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CMS.Loan_Management.Queries.Controller
{
    class LoanStatusController
    {
        Queries.Model.LoanStatusModel loanStatusModel;
        Queries.View.LoanStatus loanStatus;
        Main.Logger logger = new Main.Logger();

        double totalBalance = 0;
 
        public LoanStatusController(Queries.Model.LoanStatusModel loanStatusModel, Queries.View.LoanStatus loanStatus, Loan_Management.LoanManagementMenu loanMenu)
        {
            this.loanStatusModel = loanStatusModel;
            this.loanStatus = loanStatus;
            this.loanStatus.MdiParent = loanMenu;
            this.loanStatus.setTxtAccountNoTextChangedEventHandler(txtAccountNo);
            this.loanStatus.setTxtAccountNameTextChangedEventHandler(txtAccountName);
            this.loanStatus.setDataGridLoanCellClickEventHandler(dataGridPayment);
            this.loanStatus.loanGrid(this.loanStatusModel.selectUnpaidLoans());
            this.loanStatus.setBtnCollateralEventHandler(btnCollateral);
            this.loanStatus.Show();
        }

        private void txtAccountNo(object sender, EventArgs e) 
        {

            String srch = loanStatus.getAccountNo();
            this.loanStatus.loanGrid(this.loanStatusModel.searchMemberLoan(srch));
        
        }

        private void txtAccountName(object sender, EventArgs e)
        {
            String srch = loanStatus.getAccountName();
            this.loanStatus.loanGrid(this.loanStatusModel.searchMemberLoanName(srch));
        }

        private void dataGridPayment(object sender, DataGridViewCellEventArgs e) {
            try
            {
                totalBalance = 0;
                this.loanStatusModel.loanApplicationId = Convert.ToInt32(this.loanStatus.getSelected().Cells[0].Value.ToString());
                int loanTypeId = Convert.ToInt32(this.loanStatus.getSelected().Cells[1].Value.ToString());
                String accountNo = this.loanStatus.getSelected().Cells[2].Value.ToString(); ;
                this.loanStatus.paymentGrid(this.loanStatusModel.selectPaymentsMade());
                DataTable ds = this.loanStatusModel.selectLoanStatus().Tables[0];
                foreach (DataRow dr in ds.Rows)
                {

                    this.loanStatus.setDateGranted(DateTime.Parse(dr[0].ToString()).ToShortDateString());
                    this.loanStatus.setMaturity(DateTime.Parse(dr[1].ToString()).ToShortDateString());
                    this.loanStatus.setLoanAmount(Convert.ToDouble(dr[2]));

                    bool isCleared = bool.Parse(dr[3].ToString());
                    bool isAmnestied = bool.Parse(dr[4].ToString());

                    if (isCleared)
                        this.loanStatus.setStatus("Cleared");
                    else if (isAmnestied)
                        this.loanStatus.setStatus("Amnestied");
                    else if (!(isCleared) && DateTime.Compare(DateTime.Now, DateTime.Parse(dr[1].ToString())) > 0)
                        this.loanStatus.setStatus("Delinquent");
                    else
                        this.loanStatus.setStatus("Active");

                    this.loanStatus.setAmortizations(this.loanStatusModel.selectAmortizationsPaid().Tables[0].Rows[0][0].ToString());

                    try
                    {
                        String[] amnestyBal = this.loanStatusModel.selectLoanBalanceFromAmnestied(this.loanStatusModel.loanApplicationId).Split(' ');
                        totalBalance += Convert.ToDouble(amnestyBal[0]);
                        totalBalance += Convert.ToDouble(amnestyBal[1]);
                        totalBalance += Convert.ToDouble(amnestyBal[2]);
                    }
                    catch (Exception) { totalBalance += 0; }

                    double balFromRegLoans = this.loanStatusModel.selectRemainingBalance(this.loanStatusModel.loanApplicationId);
                    totalBalance += balFromRegLoans;

                    this.getInterestAndPenalty(this.loanStatusModel.loanApplicationId, loanTypeId, accountNo);

                    this.loanStatus.setBalance(totalBalance);

                    this.loanStatus.enableCollaterals();
                }
            }
            catch (Exception) { }

        }


            public void btnCollateral (object sender, EventArgs e){
            
                Queries.Controller.CollateralComakerController CollateralComakerController = new CollateralComakerController(new Queries.Model.CollateralComakerModel(), new Queries.View.CollateralComaker(),this.loanStatusModel.loanApplicationId);
            
            }

            public void getInterestAndPenalty(int lappId, int loanTypeId, String accountNo)
            {
                double totalInterest = 0;
                double totalPenalty = 0;

                double lastInterest = this.loanStatusModel.selectLastInterest(lappId);

                if (lastInterest != 0)
                {
                    totalInterest += lastInterest;
                }

                Dictionary<String, int> listOfInterestDates = new Dictionary<String, int>();
                Dictionary<String, int> finalListOfInterestDates = new Dictionary<String, int>();

                String maturityDate = this.loanStatusModel.selectMaturityDate(lappId);
                String interestDate = (DateTime.Parse(maturityDate).AddDays(1)).ToString();
                String[] interest = this.loanStatusModel.selectInterestPerLoanType(loanTypeId).Split(' ');

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
                        int i = this.loanStatusModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

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
                            double grantedLoanAmount = this.loanStatusModel.selectGrantedLoanAmount(lappId);
                            String[] paymentDur = this.loanStatusModel.selectPaymentDurationPerApplication(lappId).Split(' ');
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

                totalBalance += totalInterest;

                double lastPenalty = this.loanStatusModel.selectLastPenalty(lappId);
                if (lastPenalty != 0)
                {
                    totalPenalty += lastPenalty;
                }

                DataSet amorSet = this.loanStatusModel.selectAmortizations(accountNo, lappId);

                for (int j = 0; j < amorSet.Tables[0].Rows.Count; j++)
                {
                    DataSet ds2 = this.loanStatusModel.selectMonthlyAmortization(lappId);
                    double monthlyAmortization = double.Parse(ds2.Tables[0].Rows[0][0].ToString());
                    String loanDurationStatus = ds2.Tables[0].Rows[0][1].ToString();
                    if (loanDurationStatus == "week/s") { monthlyAmortization *= 4; }
                    else if (loanDurationStatus == "year/s") { monthlyAmortization /= 12; }
                    double grantedLoanAmount = this.loanStatusModel.selectGrantedLoanAmount(lappId);
                    double remainingBalance = this.loanStatusModel.selectCurrentBalance(lappId);

                    String dueDate = amorSet.Tables[0].Rows[j][3].ToString();
                    double amortizationAmount = double.Parse(amorSet.Tables[0].Rows[j][2].ToString());

                    DataSet ds = this.loanStatusModel.selectPenaltiesPerLoanType(loanTypeId);
                    if (ds.Tables[0].Rows.Count == 0 || DateTime.Parse(dueDate) > DateTime.Now)
                    {
                        totalPenalty += 0;
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


                    }//end else

                }

                totalBalance += totalPenalty;
            }
    }
}
