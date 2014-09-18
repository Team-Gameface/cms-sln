using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Reports.Controller
{
    class ScheduleOfDelinquentsController
    {

        Reports.Model.ScheduleOfDelinquentsModel scheduleOfDelinquentsModel;
        Reports.View.ScheduleOfDelinquents scheduleOfDelinquents;
        Main.Logger logger = new Main.Logger();

        Dictionary<int, string> loanTypes = new Dictionary<int, string>();

        public ScheduleOfDelinquentsController(Reports.Model.ScheduleOfDelinquentsModel scheduleOfDelinquentsModel, Reports.View.ScheduleOfDelinquents scheduleOfDelinquents, Loan_Management.LoanManagementMenu loanMenu)
        {
            this.scheduleOfDelinquentsModel = scheduleOfDelinquentsModel;
            this.scheduleOfDelinquents = scheduleOfDelinquents;
            this.scheduleOfDelinquents.MdiParent = loanMenu;
            this.scheduleOfDelinquents.setBtnPreviewEventHandler(this.btnPreview);
            this.clbLoanTypes();
            this.scheduleOfDelinquents.Show();
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Transaction - Share Capital Contribution";
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

        public void clbLoanTypes()
        {

            loanTypes.Clear();
            DataTable ds = this.scheduleOfDelinquentsModel.selectLoanTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                loanTypes.Add(int.Parse(dr[0].ToString()), dr[1].ToString());

            }
            this.scheduleOfDelinquents.populateLoanTypes(loanTypes);


        }

        private void btnPreview(object sender, EventArgs e) {

            int hasError = 0;
            String errors = String.Empty;
            this.scheduleOfDelinquents.clearLabels();


            this.scheduleOfDelinquentsModel.dateFrom = this.scheduleOfDelinquents.getDateFrom();
            if (scheduleOfDelinquents.getAgeFilterChecked())
                this.scheduleOfDelinquentsModel.ageBracket = this.scheduleOfDelinquents.getAgeBracket();
            else this.scheduleOfDelinquentsModel.ageBracket = String.Empty;
            this.scheduleOfDelinquentsModel.checkedLoanTypes = this.scheduleOfDelinquents.getCheckedLoanTypes();
            this.scheduleOfDelinquentsModel.sortBy = this.scheduleOfDelinquents.getSortBy();
            this.scheduleOfDelinquentsModel.order = this.scheduleOfDelinquents.getOrder();


            switch (scheduleOfDelinquents.getSortBy())
            {


                case "Member Account No": scheduleOfDelinquentsModel.sortBy = "LOAN_INFORMATION.AccountNo";
                    break;
                case "Member Name": scheduleOfDelinquentsModel.sortBy = "CONCAT(MEMBER.LastName, ', ', MEMBER.FirstName, ' ', MEMBER.MiddleName)";
                    break;
                case "Loan Type": scheduleOfDelinquentsModel.sortBy = "LOAN_TYPE.LoanTypeName";
                    break;
                default: scheduleOfDelinquentsModel.sortBy = String.Empty;
                    break;

            }

            if (scheduleOfDelinquentsModel.dateFrom == String.Empty)
            { scheduleOfDelinquents.errorDateFrom(); hasError = 1; errors += "- Start Date is empty." + Environment.NewLine; }

            if (scheduleOfDelinquents.getAgeFilterChecked() && scheduleOfDelinquentsModel.ageBracket == String.Empty)
            { scheduleOfDelinquents.errorDateFrom(); hasError = 1; errors += "- Please select Loan Age Bracket." + Environment.NewLine; }

            if (scheduleOfDelinquentsModel.checkedLoanTypes.Count == 0)
            { scheduleOfDelinquents.errorLoanTypes(); hasError = 1; errors += "- Please check at least one loan type." + Environment.NewLine; }
            if (scheduleOfDelinquentsModel.sortBy == String.Empty)
            { scheduleOfDelinquents.errorLoanSortBy(); hasError = 1; errors += "- Please select field to sort." + Environment.NewLine; }
            if (scheduleOfDelinquentsModel.order == String.Empty)
            { scheduleOfDelinquents.errorLoanOrder(); hasError = 1; errors += "- Please select sorting method." + Environment.NewLine; }




            if (hasError == 0)
            {
                  ArrayList loanTypesNo = new ArrayList();

                  foreach (String s in scheduleOfDelinquentsModel.checkedLoanTypes)
                    {
                        foreach (KeyValuePair<int, string> pair in loanTypes)
                        {
                            if (s.Equals(pair.Value))
                                loanTypesNo.Add(pair.Key);
                        }
                     }
            


                DataSet deliquentLoan = this.scheduleOfDelinquentsModel.selectDeliquentLoans(scheduleOfDelinquentsModel.dateFrom, loanTypesNo, this.scheduleOfDelinquentsModel.sortBy, this.scheduleOfDelinquentsModel.order);
                int ctr = 0;
                int countResult = deliquentLoan.Tables[0].Rows.Count;
                double[] balance = new double[countResult];
                String[] ageCategory = new String[countResult];
                double[] shareCapBal = new double[countResult];
                double[] exposedAmt = new double[countResult];

                for (int i = 0; i < countResult; i++) 
                {
                    String accountNo = deliquentLoan.Tables[0].Rows[i][0].ToString();
                    int lappId = int.Parse(deliquentLoan.Tables[0].Rows[i][4].ToString());
                    int loanTypeId = int.Parse(deliquentLoan.Tables[0].Rows[i][2].ToString());
                    String maturityDate = deliquentLoan.Tables[0].Rows[i][6].ToString();
                    try
                    {
                        String[] amnestyBal = this.scheduleOfDelinquentsModel.selectLoanBalanceFromAmnestied(lappId).Split(' ');
                        balance[ctr] += Convert.ToDouble(amnestyBal[0]);
                        balance[ctr] += Convert.ToDouble(amnestyBal[1]);
                        balance[ctr] += Convert.ToDouble(amnestyBal[2]);
                    }
                    catch (Exception) 
                    {
                        double balFromRegLoans = this.scheduleOfDelinquentsModel.selectRemainingBalance(lappId);
                        balance[ctr] += balFromRegLoans;
                        String[] penint = this.getInterestAndPenalty(lappId,loanTypeId, accountNo).Split(' ');
                        balance[ctr] += double.Parse(penint[0]);
                        balance[ctr] += double.Parse(penint[1]);
                    }

                    TimeSpan diffDate = DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom).Subtract(DateTime.Parse(maturityDate));
                    int age = (int)diffDate.TotalDays;

                    if (age >= 1 && age <= 30) { ageCategory[ctr] = "1-30 days"; }
                    else if (age >= 31 && age <= 60) { ageCategory[ctr] = "31-60 days"; }
                    else if(age >= 61 && age <= 90) { ageCategory[ctr] = "61-90 days"; }
                    else if(age >= 91 && age <= 120) { ageCategory[ctr] = "91-120 days"; }
                    else if(age >= 121 && age <= 180) { ageCategory[ctr] = "121-180 days"; }
                    else if(age >= 181 && age <= 365) { ageCategory[ctr] = "181-365 days"; }
                    else if(age >= 366) { ageCategory[ctr] = "366 days above"; }

                    shareCapBal[ctr] = this.scheduleOfDelinquentsModel.selectShareCapital(accountNo);

                    if (balance[ctr] - shareCapBal[ctr] > 0) { exposedAmt[ctr] = balance[ctr] - shareCapBal[ctr]; }
                    else { exposedAmt[ctr] = 0; }

                    ctr++;
                }

                DataSet finalSetOfDeliquentAccounts = new DataSet();

                DataTable dt = new DataTable("MyTable");
                dt.Columns.Add(new DataColumn("AccountNo", typeof(String)));
                dt.Columns.Add(new DataColumn("MemberName", typeof(String)));
                dt.Columns.Add(new DataColumn("LoanTypeName", typeof(String)));
                dt.Columns.Add(new DataColumn("DateApproved", typeof(String)));
                dt.Columns.Add(new DataColumn("MaturityDate", typeof(String)));
                dt.Columns.Add(new DataColumn("Balance", typeof(double)));
                dt.Columns.Add(new DataColumn("AgeCategory", typeof(String)));
                dt.Columns.Add(new DataColumn("ShareCapitalBalance", typeof(double)));
                dt.Columns.Add(new DataColumn("ExposedAmount", typeof(double)));

                for (int j = 0; j < countResult; j++) 
                {
                    String accountNo = deliquentLoan.Tables[0].Rows[j][0].ToString();
                    String memberName = deliquentLoan.Tables[0].Rows[j][1].ToString();
                    int lappId = int.Parse(deliquentLoan.Tables[0].Rows[j][4].ToString());
                    String loanTypeName = deliquentLoan.Tables[0].Rows[j][3].ToString();
                    String maturityDate = Convert.ToDateTime(deliquentLoan.Tables[0].Rows[j][6]).ToString("MM/dd/yyyy");
                    String dateApproved = Convert.ToDateTime(deliquentLoan.Tables[0].Rows[j][5]).ToString("MM/dd/yyyy");
                    
                    bool isInsert = false;

                    if (scheduleOfDelinquents.getAgeFilterChecked())
                    {
                        if (scheduleOfDelinquentsModel.ageBracket == ageCategory[j])
                            isInsert = true;
                        else
                            isInsert = false;
                    }
                    else
                        isInsert = true;

                    if (isInsert)
                    {

                    DataRow dr = dt.NewRow();
                    dr["AccountNo"] = accountNo;
                    dr["MemberName"] = memberName;
                    dr["LoanTypeName"] = loanTypeName;
                    dr["DateApproved"] = dateApproved;
                    dr["MaturityDate"] = maturityDate;
                    dr["Balance"] = balance[j];
                    dr["AgeCategory"] = ageCategory[j];
                    dr["ShareCapitalBalance"] = shareCapBal[j];
                    dr["ExposedAmount"] = exposedAmt[j];
                    dt.Rows.Add(dr);

                    }
                }
                finalSetOfDeliquentAccounts.Tables.Add(dt);

                DataSet dsCoop = scheduleOfDelinquentsModel.getCompanyProfile("dtLogo");
                DataSet dsStaff = scheduleOfDelinquentsModel.getStaff(Main.UserData.userId, "dtStaff");
                DataSet dsMgr = scheduleOfDelinquentsModel.getManager("dtManager");
                DataSet dsCredChair = scheduleOfDelinquentsModel.getChair("dtCreditChair");

                if (finalSetOfDeliquentAccounts.Tables[0].Rows.Count == 0)
                    MessageBox.Show("No records to show.", "Loan Releases");
                else
                {
                    scheduleOfDelinquents.setReportDataSource(finalSetOfDeliquentAccounts, dsCoop, dsStaff, dsMgr, dsCredChair, scheduleOfDelinquentsModel.dateFrom);
                    execLogger("Generated Report");
                }


            }
            else
                MessageBox.Show("Errors had been found." + Environment.NewLine + errors);
        
        }


        public String getInterestAndPenalty(int lappId, int loanTypeId, String accountNo)
        {
            double miniInterest = 0, miniPenalty = 0;

            double lastInterest = this.scheduleOfDelinquentsModel.selectLastInterest(lappId);

            if (lastInterest != 0)
            {
                miniInterest += lastInterest;
            }

            Dictionary<String, int> listOfInterestDates = new Dictionary<String, int>();
            Dictionary<String, int> finalListOfInterestDates = new Dictionary<String, int>();

            String maturityDate = this.scheduleOfDelinquentsModel.selectMaturityDate(lappId);
            String interestDate = (DateTime.Parse(maturityDate).AddDays(1)).ToString();
            String[] interest = this.scheduleOfDelinquentsModel.selectInterestPerLoanType(loanTypeId).Split(' ');

            if (DateTime.Now > DateTime.Parse(maturityDate) && interest[0] != "")
            {
                String interestRateStatus = interest[0];
                double interestRate = Convert.ToDouble(interest[1]);
                String per = interest[2];

                if (interestRateStatus == "%") { interestRate *= 0.01; }


                if (per == "month")
                {
                    for (String a = interestDate; DateTime.Parse(a) <= DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom); a = (DateTime.Parse(a).AddMonths(1)).ToString())
                    {
                        listOfInterestDates.Add(a, 0);
                    }

                    foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                    {
                        String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                        String secondDate = DateTime.Parse(pair.Key).AddMonths(1).ToString();
                        int i = this.scheduleOfDelinquentsModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

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
                            double grantedLoanAmount = this.scheduleOfDelinquentsModel.selectGrantedLoanAmount(lappId);
                            String[] paymentDur = this.scheduleOfDelinquentsModel.selectPaymentDurationPerApplication(lappId).Split(' ');
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
                            miniInterest += finalInterest;
                        }
                    }

                }

                else if (per == "annum")
                {
                    for (String a = interestDate; DateTime.Parse(a) <= DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom); a = (DateTime.Parse(a).AddYears(1)).ToString())
                    {
                        listOfInterestDates.Add(a, 0);
                    }

                    foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                    {
                        String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                        String secondDate = DateTime.Parse(pair.Key).AddYears(1).ToString();
                        int i = this.scheduleOfDelinquentsModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

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
                            double grantedLoanAmount = this.scheduleOfDelinquentsModel.selectGrantedLoanAmount(lappId);
                            String[] paymentDur = this.scheduleOfDelinquentsModel.selectPaymentDurationPerApplication(lappId).Split(' ');
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
                            miniInterest += finalInterest;
                        }
                    }
                }
            }


            double lastPenalty = this.scheduleOfDelinquentsModel.selectLastPenalty(lappId);
            if (lastPenalty != 0)
            {
                miniPenalty += lastPenalty;
            }

            DataSet amorSet = this.scheduleOfDelinquentsModel.selectAmortizations(accountNo, lappId);

            for (int j = 0; j < amorSet.Tables[0].Rows.Count; j++)
            {
                DataSet ds2 = this.scheduleOfDelinquentsModel.selectMonthlyAmortization(lappId);
                double monthlyAmortization = double.Parse(ds2.Tables[0].Rows[0][0].ToString());
                String loanDurationStatus = ds2.Tables[0].Rows[0][1].ToString();
                if (loanDurationStatus == "week/s") { monthlyAmortization *= 4; }
                else if (loanDurationStatus == "year/s") { monthlyAmortization /= 12; }
                double grantedLoanAmount = this.scheduleOfDelinquentsModel.selectGrantedLoanAmount(lappId);
                double remainingBalance = this.scheduleOfDelinquentsModel.selectCurrentBalance(lappId);

                String dueDate = amorSet.Tables[0].Rows[j][3].ToString();
                double amortizationAmount = double.Parse(amorSet.Tables[0].Rows[j][2].ToString());

                DataSet ds = this.scheduleOfDelinquentsModel.selectPenaltiesPerLoanType(loanTypeId);
                if (ds.Tables[0].Rows.Count == 0 || DateTime.Parse(dueDate) > DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom))
                {
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
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom); a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                {
                                    initialPenalty = amount * monthlyAmortization;
                                    miniInterest += initialPenalty;

                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom); a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * monthlyAmortization;
                                    miniInterest += initialPenalty;
                                }
                            }
                        }
                        else if (deductTo == "remaining balance")
                        {
                            if (durationStatus == "month/s")
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom); a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                {
                                    initialPenalty = amount * remainingBalance;
                                    miniPenalty += initialPenalty;
                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom); a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * remainingBalance;
                                    miniInterest += initialPenalty;
                                }
                            }
                        }
                        else if (deductTo == "granted loan amount")
                        {
                            if (durationStatus == "month/s")
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom); a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                {
                                    initialPenalty = amount * grantedLoanAmount;
                                    miniInterest += initialPenalty;
                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom); a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * grantedLoanAmount;
                                    miniInterest += initialPenalty;
                                }
                            }
                        }

                        else if (deductTo == String.Empty)
                        {
                            if (durationStatus == "month/s")
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom); a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                {
                                    initialPenalty = amount;
                                    miniPenalty += initialPenalty;
                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Parse(this.scheduleOfDelinquentsModel.dateFrom); a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount;
                                    miniInterest += initialPenalty;
                                }
                            }
                        }
                    }//end for loop


                }//end else

            }

            return miniPenalty + " " + miniInterest;
        }
    }
}
