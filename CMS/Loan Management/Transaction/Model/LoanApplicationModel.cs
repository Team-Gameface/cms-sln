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
    class LoanApplicationModel
    {
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

        public String selectCurrentLoanBalance(int lappId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(Penalty-(Penalty*(WaivedPenaltyPercentage/100)),' ',Interest-(Interest*(WaivedInterestPercentage/100)),' ', LoanBalance) from LOAN_INFORMATION_AMNESTY where LoanApplicationId = " + "'" + lappId + "'";
            String bal = Convert.ToString(dal.executeScalar(sql));
            return bal;
        }

        public Boolean selectIfLoanIsAmnestized(int lappId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select isAmnestized from LOAN_INFORMATION where LoanApplicationId = " + "'" + lappId + "'";
            Boolean isAm = Convert.ToBoolean(dal.executeScalar(sql));
            return isAm;
        }

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

        public int selectIfThereIsAlreadyLoan(String accountNo)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select count(LoanApplicationId) from LOAN_INFORMATION where isCleared = 0 and AccountNo ="+"'"+accountNo+ "'";
                int i = Convert.ToInt32(dal.executeScalar(sql));
                return i;
            }
            catch (Exception) { return 0; }
        }

        public DataSet selectLoanInfo(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Loan_Type.LoanTypeName, LOAN_INFORMATION.ApprovedAmount, CONVERT(varchar(11),LOAN_INFORMATION.DateApproved,106), CONVERT(varchar(11),LOAN_INFORMATION.MaturityDate,106) from LOAN_TYPE, LOAN_INFORMATION where LOAN_TYPE.LoanTypeId = LOAN_INFORMATION.LoanTypeId AND Loan_Information.isCleared = 0 and AccountNo =" + "'" + accountNo + "'";
            DataSet info = dal.executeDataSet(sql);
            return info;
        }

        public String selectClassification(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC dbo.getMemberStatus @accountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            String classification = Convert.ToString(dal.executeScalar(sql, parameters));
            return classification;
        }

        public String selectPaymentDurationPerApplication(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(PaymentDurationValue,' ',PaymentDurationStatus) from LOAN_INFORMATION where LoanApplicationId =" + "'" + loanApplicationId+ "'";
            String paymentDuration = Convert.ToString(dal.executeScalar(sql));
            return paymentDuration;
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

        public String selectMaturityDate(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select MaturityDate from LOAN_INFORMATION where LoanApplicationId = " + "'" + loanApplicationId + "'";
            String mdate = Convert.ToString(dal.executeScalar(sql));
            return mdate;
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
            String sql = "Select ApprovedAmount from loan_INFORMATION where loanapplicationid = " + "'" + loanApplicationId + "'";
            double amount = Convert.ToDouble(dal.executeScalar(sql));
            return amount;
        }
        public DataSet selectAmortizations(String accountNo, int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_AMORTIZATION.isPaid as 'Check to Pay', (Select count(AmortizationId) from LOAN_INFORMATION, LOAN_AMORTIZATION WHERE LOAN_INFORMATION.LoanApplicationId=LOAN_AMORTIZATION.LoanApplicationId and LOAN_INFORMATION.isCleared = 0 and LOAN_AMORTIZATION.isPaid = 1 and LOAN_INFORMATION.AccountNo = " + "'" + accountNo + "'" + " and LOAN_INFORMATION.LoanTypeId = " + "'" + loanTypeId + "'" + ")+ row_number() OVER (PARTITION BY LOAN_AMORTIZATION.LoanApplicationId ORDER BY LOAN_AMORTIZATION.LoanApplicationId) Amortization#, LOAN_AMORTIZATION.Amount, LOAN_AMORTIZATION.AmortizationDueDate as 'Due Date', Loan_INFORMATION.LoanApplicationId from LOAN_INFORMATION, LOAN_AMORTIZATION WHERE LOAN_INFORMATION.LoanApplicationId=LOAN_AMORTIZATION.LoanApplicationId and LOAN_INFORMATION.isCleared = 0 and LOAN_AMORTIZATION.isPaid = 0 and LOAN_INFORMATION.AccountNo = " + "'" + accountNo + "'" + " and LOAN_INFORMATION.LoanTypeId = " + "'" + loanTypeId + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public String selectUnclearedLoanType(int loanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(LOAN_INFORMATION.LoanTypeId,' ',LOAN_TYPE.LoanTypeName) from LOAN_INFORMATION, LOAN_TYPE where LOAN_INFORMATION.LoanTypeId = LOAN_TYPE.LoanTypeId and LOAN_INFORMATION.LoanApplicationId = " + "'" + loanApplicationId + "'";
            String loanType = Convert.ToString(dal.executeScalar(sql));
            return loanType;
        }

        public int selectUnclearedLoan(String accountNo)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select LoanApplicationId from LOAN_INFORMATION where isCleared = 0 and AccountNo = " + "'" + accountNo + "'";
                int lappId = Convert.ToInt32(dal.executeScalar(sql));
                return lappId;
            }
            catch (Exception) { return 0; }
        }

        public String selectInterestRate(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(InterestRateValue,' ',InterestRateStatus) as 'Interest Rate' from LOAN_INTEREST_RATE where isArchived = 0 and loanTypeId =" + "'" + loanTypeId + "'";
            String interest = Convert.ToString(dal.executeScalar(sql));
            return interest;
        }

        public DataSet selectActiveCharges(int LoanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT c.ChargeId, c.Amount as 'Amount',c.ChargeName as 'Charge Name', c.AmountStatus as 'Amount Status' from CHARGES c INNER JOIN LOAN_TYPE_CHARGES ltc on c.ChargeId = ltc.ChargeId AND c.Status=1 AND c.isArchived=0 AND ltc.LoanTypeId = @searchName";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", LoanTypeId);
            DataSet ds = dal.executeDataSet(sql, parameters);

            return ds;

        }

        public Boolean selectSavingsStatus(int memberTypeNo) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select hasSavings from MEMBER_TYPE WHERE MemberTypeNo =" + "'" + memberTypeNo + "'";
            Boolean hasSavings = Convert.ToBoolean(dal.executeScalar(sql));
            return hasSavings;
        }

        public int selectPreviousEligibility(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select isPreviousUnpaid from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            int elig = Convert.ToInt32(dal.executeScalar(sql));
            return elig;
        }

        public int selectCurrentEligibility(int loanTypeId) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select isCurrentUnpaid from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            int elig = Convert.ToInt32(dal.executeScalar(sql));
            return elig;
        }

        public DataSet selectLoanTypeUnpaid(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_INFORMATION.LoanTypeId FROM LOAN_INFORMATION where LOAN_INFORMATION.isCleared = 0 and LOAN_INFORMATION.AccountNo = " + "'" + accountNo + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public String selectPaymentDuration(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(MinimumPaymentDuration,' ',MinPDStatus,' to ',MaximumPaymentDuration,' ',MaxPDStatus) from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            String pd = Convert.ToString(dal.executeScalar(sql));
            return pd;
        }

        public String selectMaximumLoanableAmount(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(MaxLoanableAmt,' ',MaxLoanableAmtStatus,' ',Deduction) from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            String mla = Convert.ToString(dal.executeScalar(sql));
            return mla;
        }

        public double selectTimeDepositBalance(int certificateNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select DepositAmount from TIME_DEPOSIT where CertificateNo = " + "'" + certificateNo + "'";
            double balance = Convert.ToDouble(dal.executeScalar(sql));
            return balance;
        }

        public DataSet selectTimeDepositAccounts(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select CertificateNo from TIME_DEPOSIT where Maturity > CURRENT_TIMESTAMP and isHold = 0 and Status=1 and AccountNo = "+"'"+accountNo+"'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public String checkSpouseName(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select SpouseName from MEMBER WHERE AccountNo = " + "'" + accountNo + "'";
            String spouse = Convert.ToString(dal.executeScalar(sql));
            return spouse;
        }

        public int selectLoanApprovedCount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select count(LoanApplicationId)+1 from LOAN_INFORMATION where AccountNo = " + "'" + accountNo + "'";
            int loanCount = Convert.ToInt32(dal.executeScalar(sql));
            return loanCount;
        }

        public String selectTotalSavings(String accountNo)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select sum(SAVINGS_ACCOUNT.Balance) from SAVINGS_ACCOUNT, MEMBER_SAVINGS_ACCOUNT WHERE SAVINGS_ACCOUNT.SavingsAccountNo = MEMBER_SAVINGS_ACCOUNT.SavingsAccountNo AND MEMBER_SAVINGS_ACCOUNT.MemberAccountNo = " + "'" + accountNo + "'";
                String totalSavings = (Convert.ToDouble(dal.executeScalar(sql))).ToString();
                return totalSavings;
            }
            catch (Exception) { return "0"; }
        }

        public String selectCurrentShareCapital(String accountNo) 
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select SUM(ShareCapital) from MEMBER_SHARECAPITAL where  AccountNo =  " + "'" + accountNo + "'";
                String currentShareCapital = (Convert.ToDouble(dal.executeScalar(sql))).ToString();
                return currentShareCapital;
            }
            catch (Exception) { return "0"; }
        }

        public int checkIfLoanHasComakers(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select CoMaker from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            int comaker = Convert.ToInt32(dal.executeScalar(sql));
            return comaker;
        }

        public int checkIfLoanIsCollateralized(int loanTypeId) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select isCollateral from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            int isCollateral = Convert.ToInt32(dal.executeScalar(sql));
            return isCollateral;
        }

        public DataSet selectActiveMemberWithLoan()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type', MEMBER_TYPE.MemberTypeNo from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member_Type.hasLoan=1 and Member.Status=1 and Member.AccountNo not in (Select AccountNo from Termination)";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectLoanType(int memberTypeNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_TYPE.LoanTypeId as 'LoanTypeId', LOAN_TYPE.LoanTypeName as 'LoanTypeName' from LOAN_TYPE, LOAN_TYPE_AVAILABILITY, LOAN_INTEREST_RATE, MEMBER_TYPE WHERE LOAN_TYPE_AVAILABILITY.MemberTypeNo=MEMBER_TYPE.MemberTypeNo and LOAN_TYPE_AVAILABILITY.LoanTypeId=LOAN_TYPE.LoanTypeId and LOAN_TYPE.LoanTypeId = LOAN_INTEREST_RATE.LoanTypeId and LOAN_INTEREST_RATE.isArchived = 0 and Member_Type.hasLoan = 1 and Loan_Type.isArchived=0 and Loan_Type.Status=1 and Member_Type.MemberTypeNo = " + "'" + memberTypeNo + "'" + " order by LOAN_TYPE.LoanTypeName";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchMemberByMemberName(String memberName)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type', MEMBER_TYPE.MemberTypeNo from Member, Member_Type, Payment where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member.AccountNo = Payment.AccountNo and Member_Type.hasLoan=1 and Member_Type.MinimumAge >= 18 and Member.Status=1 and Payment.PaymentType = 'Membership' and Payment.isFullyPaid = 1 and Member.AccountNo not in (Select AccountNo from Termination) AND concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) LIKE(@memberName)";
            memberName = "%" + memberName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@memberName", memberName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberByAccountNo(String accountNo)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type', MEMBER_TYPE.MemberTypeNo from Member, Member_Type, Payment where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member.AccountNo = Payment.AccountNo and Member_Type.hasLoan=1 and Member_Type.MinimumAge >= 18 and Member.Status=1 and Payment.PaymentType = 'Membership' and Payment.isFullyPaid = 1 and Member.AccountNo not in (Select AccountNo from Termination) AND Member.AccountNo LIKE(@accountNo)";
            accountNo = "%" + accountNo + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchComakerByMemberName(String makerAccountNo,String memberName)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type' from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member_Type.MinimumAge >=18 and Member.Status=1 and Member.AccountNo not in (Select AccountNo from Termination) AND concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) LIKE(@memberName) AND NOT(Member.AccountNo LIKE @makerAccountNo) ";
            memberName = "%" + memberName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@memberName", memberName);
            parameters.Add("@makerAccountNo", makerAccountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchComakerByAccountNo(String makerAccountNo,String accountNo)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type' from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member_Type.MinimumAge >=18 and Member.Status=1 and Member.AccountNo not in (Select AccountNo from Termination) AND Member.AccountNo LIKE(@accountNo) AND NOT(Member.AccountNo LIKE @makerAccountNo)";
            accountNo = "%" + accountNo + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            parameters.Add("@makerAccountNo", makerAccountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectActiveMemberWithNoDeficiency(String makerAccountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type' from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member_Type.MinimumAge >=18 and Member.Status=1 and Member.AccountNo not in (Select AccountNo from Termination) AND NOT(Member.AccountNo LIKE @makerAccountNo)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@makerAccountNo", makerAccountNo);
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public int insertLoanApplication(String AccountNo, int LoanTypeId, String Purpose, String PaymentDurationStatus, int PaymentDurationValue, String Terms, double LoanAmount, double ApprovedAmount, String DateFiled, String DateApproved, String DateMaturity,double LessCharges,double LessLoanBalance,double LessPenalties, double LessInterest, double NetLoan)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertLoanInformation @AccountNo,@LoanTypeId,@Purpose,@PaymentDurationStatus,@PaymentDurationValue,@Terms,@LoanAmount,@ApprovedAmount,@DateFiled,@DateApproved,@MaturityDate,@LessCharges, @LessLoanBalance, @LessPenalties, @LessInterest,@NetLoanProceeds";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", AccountNo);
            parameters.Add("@LoanTypeId", LoanTypeId);
            parameters.Add("@Purpose", Purpose);
            parameters.Add("@PaymentDurationStatus", PaymentDurationStatus);
            parameters.Add("@PaymentDurationValue", PaymentDurationValue);
            parameters.Add("@Terms", Terms);
            parameters.Add("@LoanAmount", LoanAmount);
            parameters.Add("@ApprovedAmount", ApprovedAmount);
            parameters.Add("@DateFiled", DateFiled);
            parameters.Add("@DateApproved", DateApproved);
            parameters.Add("@MaturityDate", DateMaturity);
            parameters.Add("@LessCharges", LessCharges);
            parameters.Add("@LessLoanBalance", LessLoanBalance);
            parameters.Add("@LessPenalties", LessPenalties);
            parameters.Add("@LessInterest", LessInterest);
            parameters.Add("@NetLoanProceeds", NetLoan);
            dal.executeNonQuery(sql, parameters);

            String sql2 = "select max(LoanApplicationId) from Loan_Information";
            int loanApplicationId = Convert.ToInt32(dal.executeScalar(sql2));
            return loanApplicationId;

        }


        public void insertCollateral(int LoanApplicationId, String SerialNo, String Name, String Condition, String Description, String YearAcquired, double AcquiredAmount)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertPropertyCollateral @LoanApplicationId,@SerialNo,@Name,@Condition,@Description,@YearAcquired,@AcquiredAmount";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanApplicationId", LoanApplicationId);
            parameters.Add("@SerialNo", SerialNo);
            parameters.Add("@Name", Name);
            parameters.Add("@Condition", Condition);
            parameters.Add("@Description", Description);
            parameters.Add("@YearAcquired", YearAcquired);
            parameters.Add("@AcquiredAmount", AcquiredAmount);
            dal.executeNonQuery(sql, parameters);
        }

        public void insertComaker(int spouseCheck, int LoanApplicationId, String AccountNo, String ResidentCertificateNo, String RPlaceIssued, String RDateIssued, String SpouseCertificateNo, String SPlaceIssued, String SDateIssued)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertComaker @LoanApplicationId,@AccountNo,@ResidentCertificateNo,@RPlaceIssued,@RDateIssued,@SpouseCertificateNo,@SPlaceIssued,@SDateIssued";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanApplicationId", LoanApplicationId);
            parameters.Add("@AccountNo", AccountNo);
            parameters.Add("@ResidentCertificateNo", ResidentCertificateNo);
            parameters.Add("@RPlaceIssued", RPlaceIssued);
            parameters.Add("@RDateIssued", RDateIssued);
            parameters.Add("@SpouseCertificateNo", SpouseCertificateNo);
            parameters.Add("@SPlaceIssued", SPlaceIssued);
            parameters.Add("@SDateIssued", SDateIssued);
            dal.executeNonQuery(sql, parameters);
        }



        public void insertLoanAmortization(int LappId, String dueDate, double amount)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertLoanAmortization @LoanApplicationId,@AmortizationDueDate, @Amount";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanApplicationId", LappId);
            parameters.Add("@AmortizationDueDate", dueDate);
            parameters.Add("@Amount", amount);

            dal.executeNonQuery(sql, parameters);

        }

        public void insertRemainingPayment(String paymentType, int applicationId, String accountNo, double penalty, double interest, Boolean hasInterest, int isFullyPaid)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);

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
        }

        public void insertAmortizationPayment(int ORNo, int applicationId, String duedate, double amount)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "Select AmortizationId from loan_amortization where LoanApplicationId = " + "'" + applicationId + "' and AmortizationDueDate =" + "'" + duedate + "'";
            int amortizationId = Convert.ToInt32(dal.executeScalar(sqlSelect));

            String insertAmoPayment = "Insert into PAYMENT_AMORTIZATION(ORNo, AmortizationId, Amount) VALUES (" + "'" + ORNo + "'" + ", '" + amortizationId + "'" + ", '" + amount + "')";
            dal.executeScalar(insertAmoPayment);
        }

        public void clearLoan(int applicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);

            String update = "Update LOAN_INFORMATION set isCleared = 1, Interest = NULL where LoanApplicationId = " + "'" + applicationId + "'";
            dal.executeScalar(update);

            String updateAmo = "Update LOAN_AMORTIZATION set isPaid = 1, Penalty = NULL where LoanApplicationId = " + "'" + applicationId + "'";
            dal.executeScalar(updateAmo);
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

            String sql2 = "Update LOAN_AMORTIZATION set isPaid = " + "'" + isFullyPaid + "' where AmortizationId =" + "'" + amortizationId + "'";
            dal.executeScalar(sql2);

            String sql3 = "Select count(AmortizationId) from LOAN_AMORTIZATION, LOAN_INFORMATION WHERE Loan_information.loanapplicationid=loan_amortization.loanapplicationid and loan_amortization.isPaid = 1 and loan_amortization.Penalty IS NULL and loan_information.Interest is null and Loan_Information.LoanApplicationId= " + "'" + applicationId + "'";
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
    }
}
