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


namespace CMS.Loan_Management.Queries.Model
{
    class LoanStatusModel
    {
        public int loanApplicationId {get; set;}

        public LoanStatusModel() {

            this.loanApplicationId = 0;
        
        }


        public DataSet selectUnpaidLoans()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select li.LoanApplicationId, li.AccountNo AS 'Account No.', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', LoanTypeName AS 'Loan Type', li.MaturityDate AS 'Maturity Date' from LOAN_INFORMATION li INNER JOIN MEMBER m ON li.AccountNo = m.AccountNo INNER JOIN LOAN_TYPE lt ON li.LoanTypeId = lt.LoanTypeId where isCleared = 0 and isAmnestized = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchMemberLoan(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select li.LoanApplicationId, li.AccountNo AS 'Account No.', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', LoanTypeName AS 'Loan Type', li.MaturityDate AS 'Maturity Date' from LOAN_INFORMATION li INNER JOIN MEMBER m ON li.AccountNo = m.AccountNo INNER JOIN LOAN_TYPE lt ON li.LoanTypeId = lt.LoanTypeId where isCleared = 0 and isAmnestized = 0 AND li.AccountNo LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberLoanName(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select li.LoanApplicationId, li.AccountNo AS 'Account No.', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', LoanTypeName AS 'Loan Type', li.MaturityDate AS 'Maturity Date'from LOAN_INFORMATION li INNER JOIN MEMBER m ON li.AccountNo = m.AccountNo INNER JOIN LOAN_TYPE lt ON li.LoanTypeId = lt.LoanTypeId where isCleared = 0 and isAmnestized = 0 AND LastName LIKE(@searchName) OR FirstName LIKE(@searchName) OR MiddleName LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectPaymentsMade()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT ORNo AS 'OR #', PaymentDate AS 'Date', Amount FROM PAYMENT p WHERE p.LoanApplicationId = @lAppId ORDER BY p.PaymentDate";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@lAppId", this.loanApplicationId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectLoanStatus()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT li.DateApproved, li.MaturityDate, li.ApprovedAmount, li.isCleared, li.isAmnestized FROM LOAN_INFORMATION li WHERE li.LoanApplicationId = @lAppId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@lAppId", this.loanApplicationId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectAmortizationsPaid()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT CONCAT((SELECT COUNT(isPaid) FROM LOAN_AMORTIZATION la WHERE la.LoanApplicationId = @lAppId AND isPaid = 1),'/',(SELECT COUNT(amortizationId) FROM LOAN_AMORTIZATION la WHERE LoanApplicationId = @lAppId))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@lAppId", this.loanApplicationId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
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







    }
}
