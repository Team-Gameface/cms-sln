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

namespace CMS.Loan_Management.Transaction.Model
{
    class LoanAmnestyModel
    {
        public double selectAmortizationPenalty(int amortizationId)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sqlSelect = "Select Penalty from LOAN_AMORTIZATION where AmortizationId=" + "'" + amortizationId + "'";
                double penalty = Convert.ToDouble(dal.executeScalar(sqlSelect));
                return penalty;
            }
            catch (Exception) { return 0; }
        }

        public DataSet selectAmortizationWithPenalty(int applicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select AmortizationId from LOAN_AMORTIZATION where Penalty is NOT NULL AND LoanApplicationId=" + "'" + applicationId + "'";
            DataSet ds = dal.executeDataSet(sqlSelect);
            return ds;
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

        public DataSet searchMemberByMemberName(String memberName, int duration, String durationStatus)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type' from Member, Member_Type, LOAN_INFORMATION, AMNESTY where Member.MemberTypeNo=Member_Type.MemberTypeNo AND Member.AccountNo = LOAN_INFORMATION.AccountNo and Member.Status=1 AND LOAN_INFORMATION.isCleared = 0 AND LOAN_INFORMATION.isAmnestized = 0 and CURRENT_TIMESTAMP > DATEADD(day,1,DATEADD(+" + durationStatus + ",+" + duration + ",LOAN_INFORMATION.MaturityDate)) AND ((Amnesty.DateTo = 'infinity' or Amnesty.DateTo > CURRENT_TIMESTAMP) and Amnesty.isArchived = 0) and concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) LIKE(@memberName)";
            memberName = "%" + memberName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@memberName", memberName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberByAccountNo(String accountNo, int duration, String durationStatus)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type' from Member, Member_Type, LOAN_INFORMATION, AMNESTY where Member.MemberTypeNo=Member_Type.MemberTypeNo AND Member.AccountNo = LOAN_INFORMATION.AccountNo and Member.Status=1 AND LOAN_INFORMATION.isCleared = 0 AND LOAN_INFORMATION.isAmnestized = 0 and CURRENT_TIMESTAMP > DATEADD(day,1,DATEADD(+" + durationStatus + ",+" + duration + ",LOAN_INFORMATION.MaturityDate)) AND ((Amnesty.DateTo = 'infinity' or Amnesty.DateTo > CURRENT_TIMESTAMP) and Amnesty.isArchived = 0) and Member.AccountNo LIKE(@accountNo)";
            accountNo = "%" + accountNo + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public String selectWaivable()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(waiveInterest,' ',waivePenalty) from AMNESTY where AmnestyId = (Select max(AmnestyId) from amnesty)";
            String waive = Convert.ToString(dal.executeScalar(sql));
            return waive;
        }

        public String selectPaymentDurationPerApplication(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(PaymentDurationValue,' ',PaymentDurationStatus) from LOAN_INFORMATION where LoanApplicationId =" + "'" + loanApplicationId + "'";
            String paymentDuration = Convert.ToString(dal.executeScalar(sql));
            return paymentDuration;
        }

        public DataSet selectPenaltiesPerLoanType(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select PenaltyName, GracePeriod, Amount, AmountStatus, Penalty.Deduction, DurationValue, DurationStatus from Penalty, LOAN_TYPE_PENALTY where Penalty.PenaltyId = LOAN_TYPE_PENALTY.PenaltyId and Penalty.Status = 1 and Penalty.isArchived=0 and LOAN_TYPE_PENALTY.LoanTypeId = " + "'" + loanTypeId + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
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

        public double selectCurrentBalance(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select sum(Amount) from LOAN_AMORTIZATION where isPaid = 0 and LoanApplicationId =" + "'" + loanApplicationId + "'";
            double curbal = Convert.ToDouble(dal.executeScalar(sql));
            return curbal;
        }

        public double selectAmortizationsPaid(int loanApplicationId)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select sum(Amount) from PAYMENT where LoanApplicationId = " + "'" + loanApplicationId + "'";
                double amopaid = Convert.ToDouble(dal.executeScalar(sql));
                return amopaid;
            }
            catch (Exception) { return 0; }
        }

        public String selectLoanInfo(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(Loan_Type.LoanTypeName,'-',LOAN_INFORMATION.ApprovedAmount,'-',CONVERT(varchar(11),LOAN_INFORMATION.DateApproved,106),'-', CONVERT(varchar(11),LOAN_INFORMATION.MaturityDate,106)) from LOAN_TYPE, LOAN_INFORMATION where LOAN_TYPE.LoanTypeId = LOAN_INFORMATION.LoanTypeId AND LoanApplicationId =" + "'" + loanApplicationId + "'";
            String info = Convert.ToString(dal.executeScalar(sql));
            return info;
        }

        public DataSet selectLoan(String accountNo, int value, String status) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_INFORMATION.LoanApplicationId, LOAN_INFORMATION.LoanTypeId, LOAN_TYPE.LoanTypeName as 'Loan Type', LOAN_INFORMATION.ApprovedAmount as 'Approved Amount', LOAN_INFORMATION.DateApproved as 'Date Approved' from LOAN_TYPE, LOAN_INFORMATION WHERE  Loan_Type.LoanTypeId = LOAN_INFORMATION.LoanTypeId and LOAN_INFORMATION.isCleared = 0 AND LOAN_INFORMATION.isAmnestized=0 AND CURRENT_TIMESTAMP > DATEADD(day,1,DATEADD(" + status + "," + value + ",LOAN_INFORMATION.MaturityDate)) and LOAN_INFORMATION.AccountNo =" + "'" + accountNo + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }


        public double selectTotalLoanBalance(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select sum(LOAN_AMORTIZATION.Amount) from LOAN_AMORTIZATION, LOAN_INFORMATION where LOAN_INFORMATION.LoanApplicationId = LOAN_AMORTIZATION.LoanApplicationId and LOAN_AMORTIZATION.isPaid = 0 and LOAN_INFORMATION.AccountNo = " + "'" + accountNo + "'";
            double totalbal = Convert.ToDouble(dal.executeScalar(sql));
            return totalbal;
        }

        public String selectClassification(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC dbo.getMemberStatus @accountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            String classification = Convert.ToString(dal.executeScalar(sql,parameters));
            return classification;
        }

        public String selectLastPaymentDate(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select CONVERT(varchar(19),max(PaymentDate)) from PAYMENT where PaymentType = 'Loan' and AccountNo =" + "'" + accountNo + "'";
            String date = Convert.ToString(dal.executeScalar(sql));
            return date;
        }

        public int selectUnpaidLoans(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select count(LoanApplicationId) from LOAN_INFORMATION where isCleared = 0 and AccountNo =" + "'" + accountNo + "'";
            int unpaid = Convert.ToInt32(dal.executeScalar(sql));
            return unpaid;
        }

        public DataSet selectActiveMember(int duration, String durationStatus)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type' from Member, Member_Type, LOAN_INFORMATION, AMNESTY where Member.MemberTypeNo=Member_Type.MemberTypeNo AND Member.AccountNo = LOAN_INFORMATION.AccountNo and Member.Status=1 AND LOAN_INFORMATION.isCleared = 0 AND LOAN_INFORMATION.isAmnestized = 0 and CURRENT_TIMESTAMP > DATEADD(day,1,DATEADD(+"+durationStatus+",+"+duration+",LOAN_INFORMATION.MaturityDate)) AND ((Amnesty.DateTo = 'infinity' or Amnesty.DateTo > CURRENT_TIMESTAMP) and Amnesty.isArchived = 0)";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public String selectAmnestyDuration()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(Duration,' ',DurationStatus) from AMNESTY where AmnestyId = (Select max(AmnestyId) from Amnesty)";
            String duration = Convert.ToString(dal.executeScalar(sql));
            return duration;
        }

        public void insertAmnesty(int lappId, String Reason, double Penalty, double Interest, double WaivedPenaltyPercentage, double WaivedInterestPercentage, double LoanBalance, String DateApproved)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);

            String sql = "EXEC insertLoanInformationAmnesty @LoanApplicationId, @Reason, @Penalty, @Interest, @WaivedPenaltyPercentage, @WaivedInterestPercentage, @LoanBalance, @DateApproved";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanApplicationId", lappId);
            parameters.Add("@Reason", Reason);
            parameters.Add("@Penalty", Penalty);
            parameters.Add("@Interest", Interest);
            parameters.Add("@WaivedPenaltyPercentage", WaivedPenaltyPercentage);
            parameters.Add("@WaivedInterestPercentage", WaivedInterestPercentage);
            parameters.Add("@LoanBalance", LoanBalance);
            parameters.Add("@DateApproved", DateApproved);

            Convert.ToInt32(dal.executeNonQuery(sql, parameters));

            String sqlUpdate = "Update Loan_Information set isAmnestized=1 where LoanApplicationId="+"'"+lappId+"'";
            dal.executeScalar(sqlUpdate);

        }
    }
}
