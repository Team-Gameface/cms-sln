using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CMS.Loan_Management.Reports.Model
{
    class ScheduleOfDelinquentsModel
    {
        public String dateFrom { get; set; }
        public CheckedListBox.CheckedItemCollection checkedLoanTypes { get; set; }
        public String groupBy { get; set; }
        public String ageBracket { get; set; }
        public String sortBy { get; set; }
        public String order { get; set; }

        public ScheduleOfDelinquentsModel()
        {
            
            this.dateFrom = String.Empty;
            this.groupBy = String.Empty;
            this.ageBracket = String.Empty;
            this.sortBy = String.Empty;
            this.order = String.Empty;
        
        }
        
        public double selectShareCapital(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select sum(ShareCapital) from MEMBER_SHARECAPITAL where accountNo=" + "'" + accountNo + "'";
            double share = Convert.ToDouble(dal.executeScalar(sql));
            return share;
        }

        public DataSet selectPenaltiesPerLoanType(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select PenaltyName, GracePeriod, Amount, AmountStatus, Penalty.Deduction, DurationValue, DurationStatus from Penalty, LOAN_TYPE_PENALTY where Penalty.PenaltyId = LOAN_TYPE_PENALTY.PenaltyId and Penalty.Status = 1 and Penalty.isArchived=0 and LOAN_TYPE_PENALTY.LoanTypeId = " + "'" + loanTypeId + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public double selectCurrentBalance(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select sum(Amount) from LOAN_AMORTIZATION where isPaid = 0 and LoanApplicationId =" + "'" + loanApplicationId + "'";
            double curbal = Convert.ToDouble(dal.executeScalar(sql));
            return curbal;
        }

        public DataSet selectMonthlyAmortization(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct LOAN_AMORTIZATION.Amount, LOAN_INFORMATION.PaymentDurationStatus from LOAN_AMORTIZATION, LOAN_INFORMATION WHERE LOAN_AMORTIZATION.LoanApplicationId = LOAN_INFORMATION.LoanApplicationId and LOAN_INFORMATION.LoanApplicationId = " + "'" + loanApplicationId + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }


        public DataSet selectAmortizations(String accountNo, int lappId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_AMORTIZATION.isPaid as 'Check to Pay', (Select count(AmortizationId) from LOAN_INFORMATION, LOAN_AMORTIZATION WHERE LOAN_INFORMATION.LoanApplicationId=LOAN_AMORTIZATION.LoanApplicationId and LOAN_INFORMATION.isCleared = 0 and LOAN_AMORTIZATION.isPaid = 1 and LOAN_INFORMATION.AccountNo = " + "'" + accountNo + "'" + " and LOAN_INFORMATION.LoanApplicationId = " + "'" + lappId + "'" + ")+ row_number() OVER (PARTITION BY LOAN_AMORTIZATION.LoanApplicationId ORDER BY LOAN_AMORTIZATION.LoanApplicationId) Amortization#, LOAN_AMORTIZATION.Amount as 'Amount(Php)', LOAN_AMORTIZATION.AmortizationDueDate as 'Due Date', Loan_Information.LoanApplicationId from LOAN_INFORMATION, LOAN_AMORTIZATION WHERE LOAN_INFORMATION.LoanApplicationId=LOAN_AMORTIZATION.LoanApplicationId and LOAN_INFORMATION.isCleared = 0 and LOAN_AMORTIZATION.isPaid = 0 and LOAN_INFORMATION.AccountNo = " + "'" + accountNo + "'" + " and LOAN_INFORMATION.LoanApplicationId = " + "'" + lappId + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public String selectPaymentDurationPerApplication(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(PaymentDurationValue,' ',PaymentDurationStatus) from LOAN_INFORMATION where LoanApplicationId =" + "'" + loanApplicationId + "'";
            String paymentDuration = Convert.ToString(dal.executeScalar(sql));
            return paymentDuration;
        }

        public double selectGrantedLoanAmount(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select ApprovedAmount from LOAN_INFORMATION where loanapplicationid = " + "'" + loanApplicationId + "'";
            double amount = Convert.ToDouble(dal.executeScalar(sql));
            return amount;
        }

        public int selectPaymentDatesWithInterestRates(int loanApplicationId, String firstDate, String secondDate)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select count(ORNo) from PAYMENT where hasInterest = 1 and LoanApplicationId = " + "'" + loanApplicationId + "'" + " and PaymentDate between " + "'" + firstDate + "'" + "and " + "'" + secondDate + "'";
            int i = Convert.ToInt32(dal.executeScalar(sql));
            return i;
        }


        public String selectInterestPerLoanType(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(InterestRateStatus,' ',InterestRateValue,' ',Per) from LOAN_INTEREST_RATE where (CURRENT_TIMESTAMP >= ActivationDate) and isArchived = 0 and LoanTypeId =" + "'" + loanTypeId + "'";
            String interest = Convert.ToString(dal.executeScalar(sql));
            return interest;
        }

        public String selectMaturityDate(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select MaturityDate from LOAN_INFORMATION where LoanApplicationId = " + "'" + loanApplicationId + "'";
            String mdate = Convert.ToString(dal.executeScalar(sql));
            return mdate;
        }

        public double selectLastPenalty(int applicationId)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sqlSelect = "Select sum(Penalty) from LOAN_AMORTIZATION where LoanApplicationId=" + "'" + applicationId + "'";
                double penalty = Convert.ToDouble(dal.executeScalar(sqlSelect));
                return penalty;
            }
            catch (Exception) { return 0; }
        }

        public double selectLastInterest(int applicationId)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sqlSelect = "Select Interest from loan_information where LoanApplicationId = " + "'" + applicationId + "'";
                double interest = Convert.ToDouble(dal.executeScalar(sqlSelect));
                return interest;
            }
            catch (Exception) { return 0; }
        }

        public double selectRemainingBalance(int applicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select sum(LOAN_AMORTIZATION.Amount) from LOAN_AMORTIZATION, LOAN_INFORMATION where LOAN_INFORMATION.LoanApplicationId = LOAN_AMORTIZATION.LoanApplicationId and LOAN_INFORMATION.isAmnestized = 0 and LOAN_AMORTIZATION.isPaid = 0 and LOAN_INFORMATION.LoanApplicationId = " + "'" + applicationId + "'";
            double amount = 0.00;
            try
            {
                amount = Convert.ToDouble(dal.executeScalar(sql));
            }
            catch (InvalidCastException)
            {
                amount = 0.00;
            }
            return amount;
        }

        public String selectLoanBalanceFromAmnestied(int lappid)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(LoanBalance-(Penalty-(Penalty*(WaivedPenaltyPercentage/100)))-(Interest-(Interest*(WaivedInterestPercentage/100))),' ',Penalty-(Penalty*(WaivedPenaltyPercentage/100)),' ',Interest-(Interest*(WaivedInterestPercentage/100))) from LOAN_INFORMATION_AMNESTY where LoanApplicationId= " + "'" + lappid + "'";
            String totalbal = Convert.ToString(dal.executeScalar(sql));
            return totalbal;
        }

        public DataSet selectDeliquentLoans(String date)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_INFORMATION.AccountNo, concat(Member.LastName,', ',Member.FirstName,' ',Member.MiddleName),LOAN_TYPE.LoanTypeId, Loan_Type.LoanTypeName, LOAN_INFORMATION.LoanApplicationId,LOAN_INFORMATION.DateApproved, LOAN_INFORMATION.MaturityDate from LOAN_INFORMATION, MEMBER, LOAN_TYPE where Member.AccountNo = Loan_Information.AccountNo and Loan_Type.LoanTypeId=Loan_Information.LoanTypeId and Loan_Information.isCleared = 0 and MaturityDate<" + "'" + date + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectLoanTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId AS 'Type No', LoanTypeName AS 'Type Name' FROM LOAN_TYPE WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }
    }
}
