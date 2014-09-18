using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Reports.Controller
{
    class PerformanceReportController
    {

        Reports.Model.PerformanceReportModel performanceReportModel;
        Reports.View.PerformanceReportViewer performanceReport;
        Main.Logger logger = new Main.Logger();

        public PerformanceReportController(Reports.Model.PerformanceReportModel performanceReportModel, Reports.View.PerformanceReportViewer performanceReport, Loan_Management.LoanManagementMenu loanMenu)
        {

            this.performanceReportModel = performanceReportModel;
            this.performanceReport = performanceReport;
            this.performanceReport.MdiParent = loanMenu;
            this.performanceReport.setBtnPreviewEventHandler(this.btnPreview);
            this.performanceReport.Show();
        
        }


        private void btnPreview(object sender, EventArgs e) {

            this.performanceReportModel.year = this.performanceReport.getYear().ToString();
           
            /*
            DataSet loanTypes = this.performanceReportModel.selectLoanTypes();

            DataSet ds = new DataSet();

            DataTable dt = new DataTable("dtLoanReceivables");
            dt.Columns.Add(new DataColumn("LoanType", typeof(String)));
            dt.Columns.Add(new DataColumn("TotalBalance", typeof(Decimal)));
            dt.Columns.Add(new DataColumn("TotalInterest", typeof(Decimal)));
           
            for (int h = 0; h < loanTypes.Tables[0].Rows.Count; h++)
            {
                String loanTypeName = loanTypes.Tables[0].Rows[h][1].ToString();
                int loanTypeId = int.Parse(loanTypes.Tables[0].Rows[h][0].ToString());
                DataSet setAmnestizedLoans = this.performanceReportModel.selectUnpaidAmnestiedLoans(loanTypeId);
                DataSet setLoans = this.performanceReportModel.selectUnpaidLoans(loanTypeId);

                double totalBalance = 0;
                double totalInterest = 0;

                for (int i = 0; i < setAmnestizedLoans.Tables[0].Rows.Count; i++)
                {
                    String[] amnestyBal = this.performanceReportModel.selectLoanBalanceFromAmnestied(int.Parse(setAmnestizedLoans.Tables[0].Rows[i][0].ToString())).Split(' ');
                    totalBalance += Convert.ToDouble(amnestyBal[0]);
                    totalInterest += Convert.ToDouble(amnestyBal[2]);
                }

                for (int j = 0; j < setLoans.Tables[0].Rows.Count; j++)
                {
                    double balFromRegLoans = this.performanceReportModel.selectRemainingBalance(int.Parse(setLoans.Tables[0].Rows[j][0].ToString()));
                    totalBalance += balFromRegLoans;
                    totalInterest += this.getInterestAndPenalty(int.Parse(setLoans.Tables[0].Rows[j][0].ToString()), int.Parse(setLoans.Tables[0].Rows[j][1].ToString()), setLoans.Tables[0].Rows[j][2].ToString());
                }

                DataRow dr = dt.NewRow();
                dr["LoanType"] = loanTypeName;
                dr["TotalBalance"] = totalBalance;
                dr["TotalInterest"] = totalInterest;
                dt.Rows.Add(dr);
            }
            ds.Tables.Add(dt); 
          */
          
            this.performanceReport.setReportSource(this.performanceReportModel.getMemberPopulation(this.performanceReportModel.year, "dtMemberPopulation"), this.performanceReportModel.getTotalShare(this.performanceReportModel.year, "dtTotalShare"), this.performanceReportModel.getTotalSavings(this.performanceReportModel.year, "dtTotalSavings"), this.performanceReportModel.getTimeDeposit(this.performanceReportModel.year, "dtTotalTimeDeposit"), this.performanceReportModel.getTotalLoanReleases(this.performanceReportModel.year, "dtTotalLoanReleases"), this.performanceReportModel.getCompanyProfile("dtLogo"), this.performanceReportModel.getStaff(Main.UserData.userId, "dtStaff"), this.performanceReportModel.getCreditChair("dtCreditChairSet"), this.performanceReportModel.getAuditChair("dtAuditChair"), this.performanceReportModel.getManager("dtManager"), this.performanceReportModel.year);

        }


            /*

        public double getInterestAndPenalty(int lappId, int loanTypeId, String accountNo)
        {
            double miniInterest = 0;

            double lastInterest = this.performanceReportModel.selectLastInterest(lappId);

            if (lastInterest != 0)
            {
                miniInterest += lastInterest;
            }

            Dictionary<String, int> listOfInterestDates = new Dictionary<String, int>();
            Dictionary<String, int> finalListOfInterestDates = new Dictionary<String, int>();

            String maturityDate = this.performanceReportModel.selectMaturityDate(lappId);
            String interestDate = (DateTime.Parse(maturityDate).AddDays(1)).ToString();
            String[] interest = this.performanceReportModel.selectInterestPerLoanType(loanTypeId).Split(' ');

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
                        int i = this.performanceReportModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

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
                            double grantedLoanAmount = this.performanceReportModel.selectGrantedLoanAmount(lappId);
                            String[] paymentDur = this.performanceReportModel.selectPaymentDurationPerApplication(lappId).Split(' ');
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
                    for (String a = interestDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddYears(1)).ToString())
                    {
                        listOfInterestDates.Add(a, 0);
                    }

                    foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                    {
                        String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                        String secondDate = DateTime.Parse(pair.Key).AddYears(1).ToString();
                        int i = this.performanceReportModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

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
                            double grantedLoanAmount = this.performanceReportModel.selectGrantedLoanAmount(lappId);
                            String[] paymentDur = this.performanceReportModel.selectPaymentDurationPerApplication(lappId).Split(' ');
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

            return miniInterest;
        }
             * */

    }
}
