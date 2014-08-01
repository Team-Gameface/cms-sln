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


namespace CMS.Main.Model
{
    class PaymentModel
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~PaymentModel()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this != null)
                {
                    this.Dispose();
                }
            }
        }

        public int checkEmpty = 0;

        public PaymentModel() { 
        
        
        }

        public double selectCurrentLoanBalance(int lappId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LoanBalance from LOAN_INFORMATION_AMNESTY where LoanApplicationId = " + "'" + lappId + "'";
            double bal = Convert.ToDouble(dal.executeScalar(sql));
            return bal;
        }

        public String selectifLoanIsAmnestized(String accountNo, int loanTypeId, String maturityDate)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(isAmnestized,' ',LoanApplicationId) from LOAN_INFORMATION where AccountNo ="+"'"+accountNo+"' and LoanTypeId ="+"'"+loanTypeId+"' and MaturityDate = "+"'"+ maturityDate + "'";
            String isAmnestized = Convert.ToString(dal.executeScalar(sql));
            return isAmnestized;
        }

        public String selectPaymentDurationPerApplication(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(PaymentDurationValue,' ',PaymentDurationStatus) from LOAN_INFORMATION where LoanApplicationId =" + "'" + loanApplicationId + "'";
            String paymentDuration = Convert.ToString(dal.executeScalar(sql));
            return paymentDuration;
        }

        public int selectPaymentDatesWithInterestRates(int loanApplicationId, String firstDate, String secondDate)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select count(ORNo) from PAYMENT where hasInterest = 1 and LoanApplicationId = "+"'"+loanApplicationId+"'"+" and PaymentDate between "+"'"+firstDate+"'"+ "and " + "'" + secondDate + "'";
            int i = Convert.ToInt32(dal.executeScalar(sql));
            return i;
        }

        public String selectMaturityDate(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select MaturityDate from LOAN_INFORMATION where LoanApplicationId = " + "'" + loanApplicationId + "'";
            String mdate = Convert.ToString(dal.executeScalar(sql));
            return mdate;
        }

        public String selectInterestPerLoanType(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(InterestRateStatus,' ',InterestRateValue,' ',Per) from LOAN_INTEREST_RATE where (CURRENT_TIMESTAMP >= ActivationDate) and isArchived = 0 and LoanTypeId =" + "'" + loanTypeId + "'";
            String interest = Convert.ToString(dal.executeScalar(sql));
            return interest;
        }

        public DataSet selectLoanType(String accountNo) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_TYPE.LoanTypeId, concat(LOAN_TYPE.LoanTypeName,'@',Loan_INFORMATION.MaturityDate) as 'LoanTypeName' from LOAN_TYPE, LOAN_INFORMATION where LOAN_TYPE.LoanTypeId = LOAN_INFORMATION.LoanTypeId and LOAN_INFORMATION.isCleared = 0 and LOAN_INFORMATION.AccountNo = " + "'" +accountNo + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public double selectRemainingBalance(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select sum(Amount) from loan_amortization where isPaid = 0 and LoanApplicationId = " + "'" + loanApplicationId + "'";
            double amount = Convert.ToDouble(dal.executeScalar(sql));
            return amount;
        }

        public double selectGrantedLoanAmount(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select ApprovedAmount from LOAN_INFORMATION where loanapplicationid = " + "'" + loanApplicationId + "'";
            double amount = Convert.ToDouble(dal.executeScalar(sql));
            return amount;
        }

        public DataSet selectMonthlyAmortization(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct LOAN_AMORTIZATION.Amount, LOAN_INFORMATION.PaymentDurationStatus from LOAN_AMORTIZATION, LOAN_INFORMATION WHERE LOAN_AMORTIZATION.LoanApplicationId = LOAN_INFORMATION.LoanApplicationId and LOAN_INFORMATION.LoanApplicationId = " + "'" + loanApplicationId + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }


        public DataSet selectPenaltiesPerLoanType(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select PenaltyName, GracePeriod, Amount, AmountStatus, Penalty.Deduction, DurationValue, DurationStatus from Penalty, LOAN_TYPE_PENALTY where Penalty.PenaltyId = LOAN_TYPE_PENALTY.PenaltyId and Penalty.Status = 1 and Penalty.isArchived=0 and LOAN_TYPE_PENALTY.LoanTypeId = " + "'" + loanTypeId + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectAmortizations(String accountNo, int loanTypeId, String maturityDate)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_AMORTIZATION.isPaid as 'Check to Pay', (Select count(AmortizationId) from LOAN_INFORMATION, LOAN_AMORTIZATION WHERE LOAN_INFORMATION.LoanApplicationId=LOAN_AMORTIZATION.LoanApplicationId and LOAN_INFORMATION.isCleared = 0 and LOAN_AMORTIZATION.isPaid = 1 and LOAN_INFORMATION.AccountNo = "+ "'" + accountNo + "'"+" and LOAN_INFORMATION.LoanTypeId = "+ "'" + loanTypeId + "'"+")+ row_number() OVER (PARTITION BY LOAN_AMORTIZATION.LoanApplicationId ORDER BY LOAN_AMORTIZATION.LoanApplicationId) Amortization#, LOAN_AMORTIZATION.Amount as 'Amount(Php)', LOAN_AMORTIZATION.AmortizationDueDate as 'Due Date', Loan_Information.LoanApplicationId from LOAN_INFORMATION, LOAN_AMORTIZATION WHERE LOAN_INFORMATION.LoanApplicationId=LOAN_AMORTIZATION.LoanApplicationId and LOAN_INFORMATION.isCleared = 0 and LOAN_INFORMATION.MaturityDate="+"'"+maturityDate+"'"+" and LOAN_AMORTIZATION.isPaid = 0 and LOAN_INFORMATION.AccountNo = "+"'" + accountNo + "'"+" and LOAN_INFORMATION.LoanTypeId = " + "'" + loanTypeId + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectActiveMemberWithLoan()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat (Member.FirstName,' ',member.LastName) as 'Name', MEMBER_TYPE.Description from MEMBER, MEMBER_TYPE, LOAN_INFORMATION WHERE MEMBER.AccountNo = LOAN_INFORMATION.AccountNo and MEMBER.MemberTypeNo = MEMBER_TYPE.MemberTypeNo AND LOAN_INFORMATION.isCleared = 0 and Member.AccountNo not in (Select AccountNo from Termination);";
            String sqlct = "Select count(Member.AccountNo) from MEMBER, MEMBER_TYPE, LOAN_INFORMATION WHERE MEMBER.AccountNo = LOAN_INFORMATION.AccountNo and MEMBER.MemberTypeNo = MEMBER_TYPE.MemberTypeNo AND LOAN_INFORMATION.isCleared = 0;";
            DataSet ds = dal.executeDataSet(sql);
            checkEmpty = Convert.ToInt32(dal.executeScalar(sqlct));
            return ds;
        }

        public DataSet selectActiveMembershipUnpaid()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type' from Member, Member_Type where Member.Status = 1 and Member.MemberTypeNo=Member_Type.MemberTypeNo AND (AccountNo in (select accountNo from Fee, Member_Type, Member_Type_Fee,Member where Fee.FeeId=Member_Type_Fee.FeeId and Member_Type.MemberTypeNo=MEMBER_TYPE_FEE.MemberTypeNo and Member_type.MemberTypeNo = MEMBER.MemberTypeNo and Fee.isArchived=0 and Member_Type.MemberTypeNo= MEMBER.MemberTypeNo and Member.AccountNo not in (Select AccountNo from Termination)))";
            String sqlct = "Select COUNT(Member.AccountNo) from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo AND (AccountNo in (select accountNo from Fee, Member_Type, Member_Type_Fee,Member where Member.Status = 1 and Fee.FeeId=Member_Type_Fee.FeeId and Member_Type.MemberTypeNo=MEMBER_TYPE_FEE.MemberTypeNo and Member_type.MemberTypeNo = MEMBER.MemberTypeNo and Fee.isArchived=0 and Member_Type.MemberTypeNo= MEMBER.MemberTypeNo and Member.AccountNo not in (Select AccountNo from Termination)))";
            DataSet ds = dal.executeDataSet(sql);
            checkEmpty = Convert.ToInt32(dal.executeScalar(sqlct));
            return ds;
        }

        public DataSet selectAccountNoFromPayment(String AccountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select AccountNo from Payment where AccountNo = @accountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", AccountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectFeesPerMemberType(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Fee.Description as 'Fee', Fee.Amount from Fee, Member_Type, Member_Type_Fee where Fee.FeeId=Member_Type_Fee.FeeId and Member_Type.MemberTypeNo=MEMBER_TYPE_FEE.MemberTypeNo and Fee.isArchived=0 and Member_Type.MemberTypeNo= (SELECT MemberTypeNo FROM Member where AccountNo = @accountNo)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectFeesPerPayment(String AccountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Fee.Description as 'Fee', Fee.Amount from Fee";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", AccountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectFees()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select FeeId as 'Fee Id', Description from Fee";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchMemberByName(String Name)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type' from Member, Member_Type where Member.Status = 1 and Member.MemberTypeNo=Member_Type.MemberTypeNo AND (AccountNo in (select accountNo from Fee, Member_Type, Member_Type_Fee,Member where Fee.FeeId=Member_Type_Fee.FeeId and Member_Type.MemberTypeNo=MEMBER_TYPE_FEE.MemberTypeNo and Member_type.MemberTypeNo = MEMBER.MemberTypeNo and Fee.isArchived=0 and Member_Type.MemberTypeNo= MEMBER.MemberTypeNo and Member.AccountNo not in (Select AccountNo from Termination))) and concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) like(@MemberName)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            Name = "%" + Name + "%";
            parameters.Add("@MemberName", Name);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberByAccount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type' from Member, Member_Type where Member.Status = 1 and Member.MemberTypeNo=Member_Type.MemberTypeNo AND (AccountNo in (select accountNo from Fee, Member_Type, Member_Type_Fee,Member where Fee.FeeId=Member_Type_Fee.FeeId and Member_Type.MemberTypeNo=MEMBER_TYPE_FEE.MemberTypeNo and Member_type.MemberTypeNo = MEMBER.MemberTypeNo and Fee.isArchived=0 and Member_Type.MemberTypeNo= MEMBER.MemberTypeNo and Member.AccountNo not in (Select AccountNo from Termination))) and Member.AccountNo like(@AccountNo)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            accountNo = "%" + accountNo + "%";
            parameters.Add("@AccountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberByLName(String Name)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat (Member.FirstName,' ',member.LastName) as 'Name', MEMBER_TYPE.Description from MEMBER, MEMBER_TYPE, LOAN_INFORMATION WHERE MEMBER.AccountNo = LOAN_INFORMATION.AccountNo and MEMBER.MemberTypeNo = MEMBER_TYPE.MemberTypeNo AND LOAN_INFORMATION.isCleared = 0 and concat(Member.FirstName,' ',Member.LastName) like(@MemberName)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            Name = "%" + Name + "%";
            parameters.Add("@MemberName", Name);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberByLAccount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat (Member.FirstName,' ',member.LastName) as 'Name', MEMBER_TYPE.Description from MEMBER, MEMBER_TYPE, LOAN_INFORMATION WHERE MEMBER.AccountNo = LOAN_INFORMATION.AccountNo and MEMBER.MemberTypeNo = MEMBER_TYPE.MemberTypeNo AND LOAN_INFORMATION.isCleared = 0 and Member.AccountNo like(@AccountNo)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            accountNo = "%" + accountNo + "%";
            parameters.Add("@AccountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertPayment(String paymentType, double amount, String accountNo, int isFullyPaid, ArrayList feeId) {

            int id = 0;
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertPayment @PaymentType, @AmountPaid, @AccountNo, @isFullyPaid";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@PaymentType", paymentType);
            parameters.Add("@AmountPaid", amount);
            parameters.Add("@AccountNo", accountNo);
            parameters.Add("@isFullyPaid", isFullyPaid);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));

            if (isFullyPaid == 1) {
                String sqlUpdate = "Update Payment set isFullyPaid=1 where AccountNo=@AccountNo";
                Dictionary<String, Object> parametersUpdate = new Dictionary<string, object>();
                parametersUpdate.Add("@AccountNo",accountNo);
                int resultUpdate = Convert.ToInt32(dal.executeNonQuery(sqlUpdate, parametersUpdate));
            }


            SqlConnection con = null;
            string ConnectionString = ConfigurationManager.ConnectionStrings["CMS"].ConnectionString;
            con = new SqlConnection(ConnectionString);
            con.Open();


            SqlCommand command = new SqlCommand("Select ORNo from Payment where Amount=@Amount and AccountNo=@AccountNo ");
            command.Connection = con;

            command.Parameters.Add(
                    new SqlParameter(
                    "@Amount", // The name of the parameter to map
                    System.Data.SqlDbType.VarChar, // SqlDbType values
                    50, // The width of the parameter
                    "Amount"));  // The name of the source column

            command.Parameters.Add(
                    new SqlParameter(
                    "@AccountNo", // The name of the parameter to map
                    System.Data.SqlDbType.VarChar, // SqlDbType values
                    50, // The width of the parameter
                    "AccountNo"));  // The name of the source column

            // Fill the parameter with the value retrieved
            // from the text field
            command.Parameters["@Amount"].Value = amount;
            command.Parameters["@AccountNo"].Value = accountNo;

            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            id = dr.GetInt32(0);



            int resultFinal = 0;







            if (result == 1)
            {
                foreach (int i in feeId)
                {
                    String sqlInner = "INSERT INTO PAYMENT_FEE VALUES (@ORNo, @FeeId)";
                    Dictionary<String, Object> parametersFinal = new Dictionary<string, object>();
                    parametersFinal.Add("@ORNo", id);
                    parametersFinal.Add("@FeeId", i);
                    resultFinal = Convert.ToInt32(dal.executeNonQuery(sqlInner, parametersFinal));
                }

            }
            else return 0;







            return resultFinal;
        
        }

        public void insertLoanPayment(String paymentType, String accountNo, int applicationId, double amount, double interest, double penalty, String duedate, Boolean hasInterest)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select AmortizationId from loan_amortization where LoanApplicationId = " + "'" + applicationId + "' and AmortizationDueDate ="+"'"+duedate+"'";
            int amortizationId = Convert.ToInt32(dal.executeScalar(sqlSelect));

            String sql = "EXEC insertAmortizationPayment @PaymentType, @AmountPaid, @Penalty, @Interest, @hasInterest, @AccountNo, @AmortizationId, @LoanApplicationId, @isFullyPaid";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@PaymentType", paymentType);
            parameters.Add("@AmountPaid", amount);
            parameters.Add("@Penalty", penalty);
            parameters.Add("@Interest", interest);
            parameters.Add("@hasInterest", hasInterest);
            parameters.Add("@AccountNo", accountNo);
            parameters.Add("@AmortizationId", amortizationId);
            parameters.Add("@LoanApplicationId", applicationId);
            parameters.Add("@isFullyPaid", 0);
            dal.executeNonQuery(sql, parameters);

            String sql2 = "Update LOAN_AMORTIZATION set isPaid = 1 where AmortizationId =" +"'"+amortizationId+"'";
            dal.executeScalar(sql2);

            String sql3 = "Select count(AmortizationId) from LOAN_AMORTIZATION WHERE isPaid = 1 and LoanApplicationId= "+"'"+applicationId+"'";
            int countPaid = Convert.ToInt32(dal.executeScalar(sql3));

            String sql4 = "Select count(AmortizationId) from LOAN_AMORTIZATION WHERE LoanApplicationId= " + "'" + applicationId + "'";
            int countAmortization = Convert.ToInt32(dal.executeScalar(sql4));

            if (countPaid == countAmortization) 
            {
                String sql5 = "Update PAYMENT set isFullyPaid = 1 where LoanApplicationId =" + "'" + applicationId + "'";
                dal.executeScalar(sql5);

                String sql6 = "Update LOAN_INFORMATION set isCleared = 1 where LoanApplicationId =" + "'" + applicationId + "'";
                dal.executeScalar(sql6);

            }

        }

    }
}
