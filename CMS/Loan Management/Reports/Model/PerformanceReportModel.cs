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
    class PerformanceReportModel
    {

        public String year { get; set; }


        public PerformanceReportModel() {


            this.year = String.Empty;
        
        }
        /*
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

        public DataSet selectUnpaidLoans(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LoanApplicationId, LoanTypeId, AccountNo from LOAN_INFORMATION where isCleared = 0 and isAmnestized = 0 AND LoanTypeId = @typeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@typeId", loanTypeId);
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public DataSet selectUnpaidAmnestiedLoans(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LoanApplicationId from LOAN_INFORMATION where isCleared = 0 and isAmnestized = 1 AND LoanTypeId = @typeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@typeId", loanTypeId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectLoanTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId AS 'Type No', LoanTypeName AS 'Type Name' FROM LOAN_TYPE WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }
        */
        public DataSet getCompanyProfile(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CompanyName,AccreditationNo,CompanyAddress,CompanyLogo,Telephone,Cellphone,Email FROM COMPANY WHERE status = 1 ORDER BY dateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            return ds;
        }

        public DataSet getStaff(String userId, String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT CONCAT(FirstName,' ',MiddleName,' ',LastName) AS 'Name', Position FROM SYSTEM_USERS WHERE NOT (UserType = 'Superuser') AND UserId = @UserId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@UserId", userId);
            DataSet ds = dal.executeDataSet(sql, parameters, src);
            return ds;
        }

        public DataSet getManager(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CONCAT(FirstName,' ',MiddleName,' ',LastName) AS 'Name', Position FROM SYSTEM_USERS WHERE UserType = 'Manager' ORDER BY DateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            return ds;
        }

        public DataSet getCreditChair(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CONCAT(FirstName,' ',MiddleName,' ',LastName) AS 'Name', Position FROM SYSTEM_USERS WHERE UserType = 'Chairman - Credit Committee' ORDER BY DateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            return ds;
        }

        public DataSet getAuditChair(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CONCAT(FirstName,' ',MiddleName,' ',LastName) AS 'Name', Position FROM SYSTEM_USERS WHERE UserType = 'Chairman - Audit Committee' ORDER BY DateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            return ds;
        }

        public DataSet getMemberPopulation(String year, String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC getMemberPopulation @year";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@year", year);
            DataSet ds = dal.executeDataSet(sql, parameters, src);
            return ds;
        }

        public DataSet getTotalShare(String year, String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC getTotalShare @year";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@year", year);
            DataSet ds = dal.executeDataSet(sql, parameters, src);
            return ds;
        }

        public DataSet getTotalSavings(String year, String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC getTotalSavings @year";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@year", year);
            DataSet ds = dal.executeDataSet(sql, parameters, src);
            return ds;
        }

        public DataSet getTotalLoanReleases(String year, String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC getTotalLoanReleases @year";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@year", year);
            DataSet ds = dal.executeDataSet(sql, parameters, src);
            return ds;
        }

        public DataSet getTimeDeposit(String year, String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT SUM(td.DepositAmount) AS 'Amount' FROM TIME_DEPOSIT td WHERE td.CertificateNo NOT IN (SELECT CertificateNo FROM TIME_DEPOSIT_DETAILS) AND td.DateCreated <= DATEADD(yy,DATEDIFF(yy,0,@year)+1,-1)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@year", year);
            DataSet ds = dal.executeDataSet(sql, parameters, src);
            return ds;
        }



    }
}
