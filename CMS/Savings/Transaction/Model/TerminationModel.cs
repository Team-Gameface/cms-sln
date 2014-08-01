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


namespace CMS.Savings.Transaction.Model
{
    public class TerminationModel
    {
        public int checkEmpty = 0;

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

        public double selectLoanBalanceFromAmnestied(int lappid)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LoanBalance from LOAN_INFORMATION_AMNESTY where LoanApplicationId= "+"'"+lappid+"'";
            double totalbal = Convert.ToDouble(dal.executeScalar(sql));
            return totalbal;
        }

        public DataSet selectUnpaidLoans(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LoanApplicationId, LoanTypeId from LOAN_INFORMATION where isCleared = 0 and isAmnestized = 0 and AccountNo ="+"'"+accountNo+"'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectUnpaidAmnestiedLoans(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LoanApplicationId from LOAN_INFORMATION where isCleared = 0 and isAmnestized = 1 and AccountNo =" + "'" + accountNo + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectActiveMember()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Account Name', Member_Type.Description AS 'Member Type' from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and AccountNo not in (Select AccountNo from Termination)";
            String sqlct = "Select COUNT(Member.AccountNo) from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and AccountNo not in (Select AccountNo from Termination)";
            DataSet ds = dal.executeDataSet(sql);
            checkEmpty = Convert.ToInt32(dal.executeScalar(sqlct));
            return ds;
        }

        public DataSet searchMemberByName(String Name)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Account Name', Member_Type.Description AS 'Member Type' from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and AccountNo not in (Select AccountNo from Termination) and concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) like(@MemberName)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            Name = "%" + Name + "%";
            parameters.Add("@MemberName", Name);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberByAccount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Account Name', Member_Type.Description AS 'Member Type' from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and AccountNo not in (Select AccountNo from Termination) and Member.AccountNo LIKE(@AccountNo)";
            accountNo = "%" + accountNo + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertTermination(String reason, String details, String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertTermination @Reason, @Details, @AccountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Reason", reason);
            parameters.Add("@Details", details);
            parameters.Add("@AccountNo", accountNo);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int clearLoans(String accountNo1)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE LOAN_AMORTIZATION SET isPaid = 1 WHERE LoanApplicationId IN (SELECT LoanApplicationId FROM LOAN_INFORMATION WHERE AccountNo = @AccountNo)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", accountNo1);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result == 1)
            {
                sql = "UPDATE LOAN_INFORMATION SET isCleared = 1 WHERE AccountNo = @AccountNo";
                result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            }
            return result;
        }

        public String selectSavingsAccount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT sa.SavingsAccountNo FROM SAVINGS_ACCOUNT sa INNER JOIN MEMBER_SAVINGS_ACCOUNT ms ON sa.SavingsAccountNo = ms.SavingsAccountNo WHERE sa.Status = 1 AND ms.MemberAccountNo = @accountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            String savingsAccountNo = "None";
            while (read.Read())
            {
                savingsAccountNo = read[0].ToString();
            }
            return savingsAccountNo;
        }

        public double selectCurrentShareCapital(String accountNo)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select SUM(ShareCapital) from MEMBER_SHARECAPITAL where AccountNo = @accountNo";
                Dictionary<String, Object> parameters = new Dictionary<string, object>();
                parameters.Add("@accountNo", accountNo);
                double currentShareCapital = (Convert.ToDouble(dal.executeScalar(sql, parameters)));
                return currentShareCapital;
            }
            catch (Exception) { return 0.00; }
        }

        public int selectMemberTimeDeposit(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM TIME_DEPOSIT WHERE Status = 1 AND AccountNo = @accountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int timeDeposit = 0;
            while (read.Read())
            {
                timeDeposit = int.Parse(read[0].ToString());
            }
            return timeDeposit;
        }

        public double selectRemainingBalance(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select sum(LOAN_AMORTIZATION.Amount) from LOAN_AMORTIZATION, LOAN_INFORMATION where LOAN_INFORMATION.LoanApplicationId = LOAN_AMORTIZATION.LoanApplicationId and LOAN_INFORMATION.isAmnestized = 0 and LOAN_AMORTIZATION.isPaid = 0 and LOAN_INFORMATION.AccountNo = " + "'" + accountNo + "'";
           double amount = 0.00;
           try
           {
               amount = Convert.ToDouble(dal.executeScalar(sql));
           }
           catch (InvalidCastException) {
               amount = 0.00;
           }
            return amount;
        }

        public int selectActivePassbook(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT SavingsPassbookNo FROM MEMBER_SAVINGS_PASSBOOK WHERE SavingsAccountNo = @accountNo AND Status = 1";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", this.selectSavingsAccount(accountNo));
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            return i;
        }

        public int withdrawSavings(String AccountNo, double Amount)
        {           
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertSavingsTransaction @SavingsAccountNo, @TransactionMode, @Amount, @Representative, @SavingsPassbook";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@SavingsAccountNo", this.selectSavingsAccount(AccountNo));
            parameters.Add("@TransactionMode", "Withdraw");
            parameters.Add("@Amount", Amount);
            parameters.Add("@Representative", "");
            parameters.Add("@SavingsPassbook", this.selectActivePassbook(AccountNo));
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result == 1)
            {
            String sql2 = "UPDATE SAVINGS_ACCOUNT SET Balance = 0.00, Status = 0 WHERE SavingsAccountNo = @AccountNo";
            Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
            parameters2.Add("@AccountNo", this.selectSavingsAccount(AccountNo));
            dal.executeNonQuery(sql2, parameters2);
            }
            return result;
        }

        public int withdrawShareCapital(String accountNo, double amount)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertContribution @accountNo, @amount";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", accountNo);
            parameters.Add("@amount", (amount*-1));
            int result = dal.executeNonQuery(sql, parameters);
            return result;
        }
    }
}
