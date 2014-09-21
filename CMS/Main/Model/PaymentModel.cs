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
    public class PaymentModel
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
        public double amountPaid = 0.00;
        public int ORNo { get; set; }
        public PaymentModel() { 
        
             ORNo = 0;
        
        }

        public int selectMinAmortId(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select min(AmortizationId) from LOAN_AMORTIZATION where LoanApplicationId =" + "'" +loanApplicationId + "'";
            int id = Convert.ToInt32(dal.executeScalar(sqlSelect));
            return id;
        }

        public int selectApplicationId(String accountNo, int loanTypeId, String duedate)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select LoanApplicationId from loan_information where loan_information.accountNo=" + "'" + accountNo + "' and loan_information.loantypeid=" + "'" + loanTypeId + "' and loan_information.maturitydate =" + "'" + duedate + "'";
            int id = Convert.ToInt32(dal.executeScalar(sqlSelect));
            return id;
        }

        public String selectMaxOR()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(Amount,' ',Penalty,' ',Interest) from PAYMENT where ORNo = (Select max(ORNo) from Payment)";
            String bal = Convert.ToString(dal.executeScalar(sql));
            return bal;
        }

        public double selectInterestByAccountNo(String accountNo) 
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sqlSelect = "Select sum(Interest) from loan_information where AccountNo = " + "'" + accountNo + "'";
                double interest = Convert.ToDouble(dal.executeScalar(sqlSelect));
                return interest;
            }
            catch (Exception) { return 0; }
        }

        public double selectPenaltyByAccountNo(String accountNo)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sqlSelect = "Select sum(Penalty) from loan_information, loan_amortization where loan_information.loanapplicationid=loan_amortization.loanapplicationid and AccountNo = " + "'" + accountNo + "'";
                double penalty = Convert.ToDouble(dal.executeScalar(sqlSelect));
                return penalty;
            }
            catch (Exception) { return 0; }
        }

        public DataSet getCompanyProfile(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CompanyName,AccreditationNo,CompanyAddress,CompanyLogo,Telephone,Cellphone,Email FROM COMPANY WHERE status = 1 ORDER BY dateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            return ds;
        }

        public int selectAmortizationId(int applicationId, String duedate) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select AmortizationId from loan_amortization where LoanApplicationId = " + "'" + applicationId + "' and AmortizationDueDate =" + "'" + duedate + "'";
            int amortizationId = Convert.ToInt32(dal.executeScalar(sqlSelect));
            return amortizationId;
        }

        public Boolean selectIfLoanIsAmnestized2(int lappId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select isAmnestized from LOAN_INFORMATION where LoanApplicationId = " + "'" + lappId + "'";
            Boolean isAm = Convert.ToBoolean(dal.executeScalar(sql));
            return isAm;
        }

        public double selectRemainingPenalties(String accountNo, int loanTypeId, String maturity) 
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select sum(Penalty) from LOAN_AMORTIZATION, LOAN_INFORMATION where LOAN_INFORMATION.LoanApplicationId = LOAN_AMORTIZATION.LoanApplicationId AND LOAN_INFORMATION.AccountNo ="+"'"+accountNo+"' and LOAN_INFORMATION.LoanTypeId ="+"'"+loanTypeId+"' and MaturityDate ="+"'"+maturity+"'";
                double bal = Convert.ToDouble(dal.executeScalar(sql));
                return bal;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public double selectRemainingInterest(String accountNo, int loanTypeId, String maturity)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select LOAN_INFORMATION.Interest from LOAN_INFORMATION where AccountNo ="+"'"+accountNo+"' and LoanTypeId ="+"'"+loanTypeId+"' and MaturityDate = "+"'"+ maturity + "'";
                double bal = Convert.ToDouble(dal.executeScalar(sql));
                return bal;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public double selectTotalLoanBalance(String accountNo) 
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select sum(Loan_Amortization.Amount) from LOAN_INFORMATION, LOAN_AMORTIZATION where Loan_Information.LoanApplicationId = Loan_Amortization.LoanApplicationId and Loan_Amortization.isPaid = 0 and Loan_Information.AccountNo= " + "'" + accountNo + "'";
                double bal = Convert.ToDouble(dal.executeScalar(sql));
                return bal;
            }
            catch (Exception) 
            {
                return 0;
            }
        }

        public String selectCurrentLoanBalance(int lappId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(Penalty-(Penalty*(WaivedPenaltyPercentage/100)),' ',Interest-(Interest*(WaivedInterestPercentage/100)),' ', LoanBalance) from LOAN_INFORMATION_AMNESTY where LoanApplicationId = " + "'" + lappId + "'";
            String bal = Convert.ToString(dal.executeScalar(sql));
            return bal;
        }

        public String selectifLoanIsAmnestized(String accountNo, int loanTypeId, String maturityDate)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(isAmnestized,' ',LoanApplicationId) from LOAN_INFORMATION where isCleared = 0 and AccountNo ="+"'"+accountNo+"' and LoanTypeId ="+"'"+loanTypeId+"' and MaturityDate = "+"'"+ maturityDate + "'";
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

        public DataSet selectLoanType2(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_TYPE.LoanTypeId, Loan_INFORMATION.MaturityDate from LOAN_TYPE, LOAN_INFORMATION where LOAN_TYPE.LoanTypeId = LOAN_INFORMATION.LoanTypeId and LOAN_INFORMATION.isCleared = 0 and LOAN_INFORMATION.AccountNo = " + "'" + accountNo + "'";
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

        public double selectRemainingBalanceWithout(String accountNo, String maturityDate, int loanTypeId)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select sum(loan_amortization.Amount) from loan_amortization, loan_information where loan_information.loanapplicationid=loan_amortization.loanapplicationid and loan_amortization.isPaid = 0 and LOAN_INFORMATION.AccountNo = " + "'" + accountNo + "' and LOAN_INFORMATION.MaturityDate =" + "'" + maturityDate + "' and LOAN_INFORMATION.LoanTypeId =" + "'" + loanTypeId + "'";
                double amount = Convert.ToDouble(dal.executeScalar(sql));
                return amount;
            }
            catch (Exception) { return 0.00; }
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
            String sql = "Select LOAN_AMORTIZATION.isPaid as 'Check to Pay', (Select count(AmortizationId) from LOAN_INFORMATION, LOAN_AMORTIZATION WHERE LOAN_INFORMATION.LoanApplicationId=LOAN_AMORTIZATION.LoanApplicationId and LOAN_INFORMATION.isCleared = 0 and LOAN_AMORTIZATION.isPaid = 1 and LOAN_INFORMATION.AccountNo = " + "'" + accountNo + "'" + " and LOAN_INFORMATION.LoanTypeId = " + "'" + loanTypeId + "'" + ")+ row_number() OVER (PARTITION BY LOAN_AMORTIZATION.LoanApplicationId ORDER BY LOAN_AMORTIZATION.LoanApplicationId) Amortization#, LOAN_AMORTIZATION.Amount as 'Amount(Php)', LOAN_AMORTIZATION.AmortizationDueDate as 'Due Date', Loan_Information.LoanApplicationId from LOAN_INFORMATION, LOAN_AMORTIZATION WHERE LOAN_INFORMATION.LoanApplicationId=LOAN_AMORTIZATION.LoanApplicationId and LOAN_INFORMATION.isCleared = 0 and LOAN_INFORMATION.MaturityDate=" + "'" + maturityDate + "'" + " and LOAN_AMORTIZATION.isPaid = 0 and LOAN_INFORMATION.AccountNo = " + "'" + accountNo + "'" + " and LOAN_INFORMATION.LoanTypeId = " + "'" + loanTypeId + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectActiveMemberWithLoan()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat (Member.FirstName,' ',member.LastName) as 'Name', MEMBER_TYPE.Description from MEMBER, MEMBER_TYPE, LOAN_INFORMATION, LOAN_AMORTIZATION WHERE MEMBER.AccountNo = LOAN_INFORMATION.AccountNo and LOAN_INFORMATION.LoanApplicationId = LOAN_AMORTIZATION.LoanApplicationId and MEMBER.MemberTypeNo = MEMBER_TYPE.MemberTypeNo AND LOAN_INFORMATION.isCleared = 0 and (LOAN_AMORTIZATION.isPaid = 0 or LOAN_AMORTIZATION.Penalty is NOT NULL OR LOAN_INFORMATION.Interest is Not null) and Member.AccountNo not in (Select AccountNo from Termination)";
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
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat (Member.FirstName,' ',member.LastName) as 'Name', MEMBER_TYPE.Description from MEMBER, MEMBER_TYPE, LOAN_INFORMATION, LOAN_AMORTIZATION WHERE MEMBER.AccountNo = LOAN_INFORMATION.AccountNo and LOAN_INFORMATION.LoanApplicationId = LOAN_AMORTIZATION.LoanApplicationId and MEMBER.MemberTypeNo = MEMBER_TYPE.MemberTypeNo AND LOAN_INFORMATION.isCleared = 0 and (LOAN_AMORTIZATION.isPaid = 0 or LOAN_AMORTIZATION.Penalty is NOT NULL OR LOAN_INFORMATION.Interest is Not null) and Member.AccountNo not in (Select AccountNo from Termination) AND concat(Member.FirstName,' ',Member.LastName) like(@MemberName)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            Name = "%" + Name + "%";
            parameters.Add("@MemberName", Name);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberByLAccount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat (Member.FirstName,' ',member.LastName) as 'Name', MEMBER_TYPE.Description from MEMBER, MEMBER_TYPE, LOAN_INFORMATION, LOAN_AMORTIZATION WHERE MEMBER.AccountNo = LOAN_INFORMATION.AccountNo and LOAN_INFORMATION.LoanApplicationId = LOAN_AMORTIZATION.LoanApplicationId and MEMBER.MemberTypeNo = MEMBER_TYPE.MemberTypeNo AND LOAN_INFORMATION.isCleared = 0 and (LOAN_AMORTIZATION.isPaid = 0 or LOAN_AMORTIZATION.Penalty is NOT NULL OR LOAN_INFORMATION.Interest is Not null) and Member.AccountNo not in (Select AccountNo from Termination) and Member.AccountNo like(@AccountNo)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            accountNo = "%" + accountNo + "%";
            parameters.Add("@AccountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet getReceiptDetails(int ORNo)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC getReceiptDetails @ORNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@ORNo", ORNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertPayment(String paymentType, double amount, String accountNo, int isFullyPaid, ArrayList feeId)
        {

            int id = -1;
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertPayment @PaymentType, @AmountPaid, @AccountNo, @isFullyPaid; SELECT @@IDENTITY";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@PaymentType", paymentType);
            parameters.Add("@AmountPaid", amount);
            parameters.Add("@AccountNo", accountNo);
            parameters.Add("@isFullyPaid", isFullyPaid);
            id = Convert.ToInt32(dal.executeScalar(sql, parameters));
            ORNo = id;


            if (isFullyPaid == 1)
            {
                String sqlUpdate = "Update Payment set isFullyPaid=1 where AccountNo=@AccountNo";
                Dictionary<String, Object> parametersUpdate = new Dictionary<string, object>();
                parametersUpdate.Add("@AccountNo", accountNo);
                int resultUpdate = Convert.ToInt32(dal.executeNonQuery(sqlUpdate, parametersUpdate));
            }
            int resultFinal = 0;


            if (id != -1)
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

        public DataSet selectAmortizationWithPenalty(int applicationId) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select AmortizationId from LOAN_AMORTIZATION where Penalty is NOT NULL AND LoanApplicationId=" + "'" + applicationId + "'";
            DataSet ds = dal.executeDataSet(sqlSelect);
            return ds;
        }

        public DataSet selectAmortizationWithPenaltyWithoutApplicationId(String accountNo, int loanTypeId, String duedate)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select AmortizationId from loan_amortization, loan_information where loan_information.loanapplicationid=loan_amortization.loanapplicationid and LOAN_AMORTIZATION.Penalty IS NOT NULL and loan_information.accountNo="+"'"+accountNo+"' and loan_information.loantypeid=" + "'" + loanTypeId + "' and loan_information.maturitydate =" + "'" + duedate + "'";
            DataSet ds = dal.executeDataSet(sqlSelect);
            return ds;
        }

        public double selectLastPenaltyWithoutApplicationId(String accountNo, int loanTypeId, String duedate)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sqlSelect = "Select sum(Loan_Amortization.Penalty) from LOAN_AMORTIZATION, loan_information where loan_information.loanapplicationid=loan_amortization.loanapplicationid and loan_information.accountNo=" + "'" + accountNo + "' and loan_information.loantypeid=" + "'" + loanTypeId + "' and loan_information.maturitydate =" + "'" + duedate + "'";
                double penalty = Convert.ToDouble(dal.executeScalar(sqlSelect));
                return penalty;
            }
            catch (Exception) { return 0; }
        }

        public double selectAmortizationPenalty(int amortizationId)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sqlSelect = "Select Penalty from LOAN_AMORTIZATION where AmortizationId=" + "'" + amortizationId+ "'";
                double penalty = Convert.ToDouble(dal.executeScalar(sqlSelect));
                return penalty;
            }
            catch (Exception) { return 0; }
        }

        public double selectLastPenalty(int applicationId)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sqlSelect = "Select sum(Penalty) from LOAN_AMORTIZATION where LoanApplicationId="+"'"+applicationId+"'";
                double penalty = Convert.ToDouble(dal.executeScalar(sqlSelect));
                return penalty;
            }
            catch (Exception) { return 0; }
        }



        public void updateAmortizationAmount(double amount, int applicationId, String duedate) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select AmortizationId from loan_amortization where LoanApplicationId = " + "'" + applicationId + "' and AmortizationDueDate =" + "'" + duedate + "'";
            int amortizationId = Convert.ToInt32(dal.executeScalar(sqlSelect));

            String updateAmount = "Update LOAN_AMORTIZATION set Amount=" + "'" + amount + "' where AmortizationId=" + "'" + amortizationId + "'";
            dal.executeScalar(updateAmount);
        }

        public void insertAmortizationPenalty(double penalty, int applicationId, String duedate) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select AmortizationId from loan_amortization where LoanApplicationId = " + "'" + applicationId + "' and AmortizationDueDate =" + "'" + duedate + "'";
            int amortizationId = Convert.ToInt32(dal.executeScalar(sqlSelect));

            String updateAmortization = "Update LOAN_AMORTIZATION set Penalty=" + "'" + penalty + "' where AmortizationId=" + "'" + amortizationId + "'";
            dal.executeScalar(updateAmortization);
        }

        public void insertLoanInterest(double interest, int applicationId) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String updateLoanInformation = "Update LOAN_INFORMATION set Interest=" + "'" + interest + "' where LoanApplicationId=" + "'" + applicationId + "'";
            int amortizationId = Convert.ToInt32(dal.executeScalar(updateLoanInformation));
        }

        public void deductToNextAmortization(double excess, int lappId) 
        {
            try
            {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select min(AmortizationId) from loan_amortization where LoanApplicationId = " + "'" + lappId + "' and isPaid = 0";
            int amortizationId = Convert.ToInt32(dal.executeScalar(sqlSelect));

            while (excess != 0)
            {
                    String selectAmount = "Select amount from loan_amortization where AmortizationId =" + "'" + amortizationId + "' and LoanApplicationId =" + "'" + lappId + "'";
                    String sAmount = Convert.ToString(dal.executeScalar(selectAmount));
                    if (sAmount.Equals(String.Empty))
                    {
                        MessageBox.Show("Change was deducted to all amortizations. Exceeding amount is Php" + excess);
                        String selectAmountMaxORNo = "Select amount from PAYMENT where ORNo=(Select max(ORNo) from Payment)";
                        double am = Convert.ToDouble(dal.executeScalar(selectAmountMaxORNo));
                        am = am - excess;
                        String updatePayment = "Update payment set Amount =" + "'" + am + "'" + " where ORNo=(Select max(ORNo) from Payment)";
                        dal.executeScalar(updatePayment);
                        excess = 0;
                        String sql6 = "Update LOAN_INFORMATION set isCleared = 1 where LoanApplicationId =" + "'" + lappId + "'";
                        dal.executeScalar(sql6);
                    }
                    else
                    {
                        double amount1 = Convert.ToDouble(dal.executeScalar(selectAmount));
                        double amount = Convert.ToDouble(dal.executeScalar(selectAmount))-excess;
                        String selectMaxOR = "Select max(ORNo) from PAYMENT";
                        int ORNo = Convert.ToInt32(dal.executeScalar(selectMaxOR));
                        String insertAmoPayment = String.Empty;
                        if (excess > amount)
                        {
                            insertAmoPayment = "Insert into PAYMENT_AMORTIZATION(ORNo, AmortizationId, Amount) VALUES (" + "'" + ORNo + "'" + ", '" + amortizationId + "'" + ", '" + amount1 + "')";
                        }
                        else 
                        {
                            insertAmoPayment = "Insert into PAYMENT_AMORTIZATION(ORNo, AmortizationId, Amount) VALUES (" + "'" + ORNo + "'" + ", '" + amortizationId + "'" + ", '" + excess + "')";
                        }

                        dal.executeScalar(insertAmoPayment);
                        if (amount < 0 && excess != 0)
                        {
                            String updateAmortization = "Update LOAN_AMORTIZATION set isPaid = 1 where AmortizationId= " + "'" + amortizationId + "'";
                            dal.executeScalar(updateAmortization);
                            excess = amount * -1;
                            amortizationId++;
                        }
                        else
                        {
                            String updateAmortization = "Update LOAN_AMORTIZATION set Amount = " + "'" + amount + "' where AmortizationId= " + "'" + amortizationId + "'";
                            dal.executeScalar(updateAmortization);
                            excess = 0;
                        }
                    }
            }

            }
            catch (Exception) { MessageBox.Show("Change was deducted to all amortizations. Exceeding amount is Php" + excess); }

            
        }

        public void insertPenaltyAmount(double penalty, int applicationId, String duedate) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select AmortizationId from loan_amortization where LoanApplicationId = " + "'" + applicationId + "' and AmortizationDueDate =" + "'" + duedate + "'";
            int amortizationId = Convert.ToInt32(dal.executeScalar(sqlSelect));

            String selectPenalty = "Select Penalty from Loan_Amortization where AmortizationId = " + "'" + amortizationId + "'";
            String pen = Convert.ToString(dal.executeScalar(selectPenalty));

            if(pen.Equals(String.Empty))
            {
                String updateAmo = "Update loan_amortization set Penalty ="+"'"+penalty+"' where AmortizationId ="+"'"+amortizationId+"'";
                dal.executeScalar(updateAmo);
            }
        }

        public void insertAmortizationPayment(int ORNo, int applicationId, String duedate, double amount) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select AmortizationId from loan_amortization where LoanApplicationId = " + "'" + applicationId + "' and AmortizationDueDate =" + "'" + duedate + "'";
            int amortizationId = Convert.ToInt32(dal.executeScalar(sqlSelect));

            String insertAmoPayment = "Insert into PAYMENT_AMORTIZATION(ORNo, AmortizationId, Amount) VALUES (" +"'" + ORNo + "'"+", '" + amortizationId + "'"+", '" + amount + "')";
            dal.executeScalar(insertAmoPayment);
        }

        public void clearLoan(String accountNo, int loanTypeId, String maturity) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String selectapp = "Select loanApplicationId from LOAN_INFORMATION where ACCOUNTNo=" + "'" + accountNo + "' and LoanTypeId =" + "'" + loanTypeId + "' and MaturityDate="+"'"+maturity+"'";
            int applicationId = Convert.ToInt32(dal.executeScalar(selectapp));

            String update = "Update LOAN_INFORMATION set isCleared = 1, Interest = NULL where LoanApplicationId = " + "'" + applicationId + "'";
            dal.executeScalar(update);

            String updateAmo = "Update LOAN_AMORTIZATION set isPaid = 1, Penalty = NULL where LoanApplicationId = " + "'" + applicationId + "'";
            dal.executeScalar(updateAmo);
        }

        public void updateLoanInterest(int applicationid) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String selectapp = "Update LOAN_INFORMATION set Interest = NULL where LoanApplicationId=" + "'" + applicationid + "'";
            dal.executeScalar(selectapp);
        }

        public String deductPenaltyAndInterest(double paidAmount, String accountNo, int loanTypeId, String maturity) 
        {
            double toPenalty = 0, toInterest = 0;
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String selectapp = "Select loanApplicationId from LOAN_INFORMATION where ACCOUNTNo=" + "'" + accountNo + "' and LoanTypeId =" + "'" + loanTypeId + "' and MaturityDate=" + "'" + maturity + "'";
            int applicationId = Convert.ToInt32(dal.executeScalar(selectapp));

            while (paidAmount != 0) 
            {
                try
                {
                    String selectAmo = "Select min(AmortizationId) from LOAN_AMORTIZATION where Penalty IS NOT NULL AND LoanApplicationId =" + "'" + applicationId + "'";
                    int amortizationId = Convert.ToInt32(dal.executeScalar(selectAmo));

                    String selectAmount = "Select Penalty from LOAN_AMORTIZATION where AmortizationId=" + "'" + amortizationId + "'";
                    double penalty = Convert.ToDouble(dal.executeScalar(selectAmount));

                    if (paidAmount > penalty)
                    {
                        String updateAmo = "Update LOAN_AMORTIZATION set Penalty = NULL where AmortizationId=" + "'" + amortizationId + "'";
                        dal.executeScalar(updateAmo);
                        paidAmount -= penalty;
                        toPenalty += penalty;
                    }
                    else
                    {
                        penalty = penalty - paidAmount;
                        toPenalty += paidAmount;
                        paidAmount = 0;
                        String updateAmo = "Update LOAN_AMORTIZATION set Penalty = " + "'" + penalty + "' where AmortizationId=" + "'" + amortizationId + "'";
                        dal.executeScalar(updateAmo);
                    }
                }
                catch (Exception) 
                {
                    double interest = 0;
                    try
                    {
                        String selectAmount = "Select Interest from LOAN_INFORMATION where LoanApplicationId=" + "'" + applicationId + "'";
                        interest = Convert.ToDouble(dal.executeScalar(selectAmount));
                    }
                    catch (Exception) { interest = 0; }

                    if (paidAmount > interest)
                    {
                        String updateLoan = "Update LOAN_INFORMATION set Interest = NULL where LoanApplicationId=" + "'" + applicationId + "'";
                        dal.executeScalar(updateLoan);
                        toInterest += interest;
                        MessageBox.Show("Exceeding amount of Php " + (paidAmount-interest));
                    }
                    else 
                    {
                        interest -= paidAmount;
                        toInterest += paidAmount;
                        paidAmount = 0;

                        String updateAmo = "Update LOAN_INFORMATION set Interest = " + "'" + interest + "' where LoanApplicationId=" + "'" + applicationId + "'";
                        dal.executeScalar(updateAmo);
                    }
                }
            }

            return toPenalty + " " + toInterest;
        }

        public int insertRemainingPayment(String paymentType, String accountNo, int loanTypeId, String maturity, double penalty, double interest, Boolean hasInterest, int isFullyPaid) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String selectapp = "Select loanApplicationId from LOAN_INFORMATION where ACCOUNTNo=" + "'" + accountNo + "' and LoanTypeId =" + "'" + loanTypeId + "' and MaturityDate=" + "'" + maturity + "'";
            int applicationId = Convert.ToInt32(dal.executeScalar(selectapp));

            String sql = "EXEC insertAmortizationPayment @PaymentType, @AmountPaid, @Penalty, @Interest, @hasInterest, @AccountNo, @LoanApplicationId, @isFullyPaid";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@PaymentType", paymentType);
            parameters.Add("@AmountPaid", 0);
            parameters.Add("@Penalty", penalty);
            parameters.Add("@Interest", interest);
            parameters.Add("@hasInterest", hasInterest);
            parameters.Add("@AccountNo", accountNo);
            parameters.Add("@LoanApplicationId", applicationId);
            parameters.Add("@isFullyPaid", isFullyPaid);
            dal.executeNonQuery(sql, parameters);

            String selectMaxOR = "Select max(ORNo) from PAYMENT";
            int ORNo = Convert.ToInt32(dal.executeScalar(selectMaxOR));
            this.ORNo = ORNo;
            return ORNo;
        }
        public int insertLoanPayment(String paymentType, String accountNo, int applicationId, double amount, double interest, double penalty, String duedate, Boolean hasInterest, int isFullyPaid, int isPaid)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select AmortizationId from loan_amortization where LoanApplicationId = " + "'" + applicationId + "' and AmortizationDueDate =" + "'" + duedate + "'";
            int amortizationId = Convert.ToInt32(dal.executeScalar(sqlSelect));

            if (isPaid == 0)
            {
                String sql = "EXEC insertAmortizationPayment @PaymentType, @AmountPaid, @Penalty, @Interest, @hasInterest, @AccountNo, @LoanApplicationId, @isFullyPaid";
                Dictionary<String, Object> parameters = new Dictionary<string, object>();
                parameters.Add("@PaymentType", paymentType);
                parameters.Add("@AmountPaid", amount);
                parameters.Add("@Penalty", penalty);
                parameters.Add("@Interest", interest);
                parameters.Add("@hasInterest", hasInterest);
                parameters.Add("@AccountNo", accountNo);
                parameters.Add("@LoanApplicationId", applicationId);
                parameters.Add("@isFullyPaid", 0);
                dal.executeNonQuery(sql, parameters);
            }

            String selectMaxOR = "Select max(ORNo) from PAYMENT";
            int ORNo = Convert.ToInt32(dal.executeScalar(selectMaxOR));
            this.ORNo = ORNo;

            String sql2 = "Update LOAN_AMORTIZATION set isPaid = "+"'"+isFullyPaid+"' where AmortizationId =" +"'"+amortizationId+"'";
            dal.executeScalar(sql2);

            String sql3 = "Select count(AmortizationId) from LOAN_AMORTIZATION, LOAN_INFORMATION WHERE Loan_information.loanapplicationid=loan_amortization.loanapplicationid and loan_amortization.isPaid = 1 and loan_amortization.Penalty IS NULL and loan_information.Interest is null and Loan_Information.LoanApplicationId= "+"'"+applicationId+"'";
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

            return ORNo;

        }

        public int insertContribution(String accountNo, Double amount)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertContribution @accountNo, @amount";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", accountNo);
            parameters.Add("@amount", amount);
            int result = dal.executeNonQuery(sql, parameters);
            return result;

        }

        public int insertSavingsTransaction(String AccountNo, double Amount)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertSavingsTransaction @SavingsAccountNo, @TransactionMode, @Amount, @Representative, @SavingsPassbook, @TellerId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@SavingsAccountNo", AccountNo);
            parameters.Add("@TransactionMode", "Deposit");
            parameters.Add("@Amount", Amount);
            parameters.Add("@Representative", "");
            parameters.Add("@SavingsPassbook", this.selectActivePassbook(AccountNo));
            parameters.Add("@TellerId", Main.UserData.userId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result == 1)
            {
                String sql2 = "UPDATE SAVINGS_ACCOUNT SET Balance = Balance + @Amount WHERE SavingsAccountNo = @SavingsAccountNo";
                Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
                parameters2.Add("@SavingsAccountNo", AccountNo);
                parameters2.Add("@Amount", Amount);
                dal.executeNonQuery(sql2, parameters2);
            }
            return result;
        }

        public int selectActivePassbook(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT SavingsPassbookNo FROM MEMBER_SAVINGS_PASSBOOK WHERE SavingsAccountNo = @accountNo AND Status = 1";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            return i;
        }

        public int countSavingsAccount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM SAVINGS_ACCOUNT sa INNER JOIN MEMBER_SAVINGS_ACCOUNT msa ON sa.SavingsAccountNo = msa.SavingsAccountNo WHERE msa.MemberAccountNo = @accountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            return i;
        }

        public DataSet selectSavingsAccounts(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT sa.SavingsAccountNo FROM SAVINGS_ACCOUNT sa INNER JOIN MEMBER_SAVINGS_ACCOUNT msa ON sa.SavingsAccountNo = msa.SavingsAccountNo WHERE msa.MemberAccountNo = @accountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public String selectSavingsAccount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT sa.SavingsAccountNo FROM SAVINGS_ACCOUNT sa INNER JOIN MEMBER_SAVINGS_ACCOUNT msa ON sa.SavingsAccountNo = msa.SavingsAccountNo WHERE msa.MemberAccountNo = @accountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            String s = String.Empty;
            while (read.Read())
            {
                s = read[0].ToString();
            }
            return s;
        }

        public void insertPaymentBalance(int ORNo, double balance, double penalty, double interest) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Insert into PAYMENT_BALANCE values ("+"'"+ORNo+"'"+","+"'"+balance+"'"+","+"'"+penalty+"'"+","+"'"+interest+"')";
            dal.executeScalar(sql);
        }
    }
}
