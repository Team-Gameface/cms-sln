using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Savings.Transaction.Model
{
    class TimeDepositWithdrawalModel
    {
        public String CertificateNo { get; set; }
        public double Penalty { get; set; }
        public double TotalAmount { get; set; }
        
        public TimeDepositWithdrawalModel()
        {
            this.CertificateNo = String.Empty;
            this.Penalty = 0;
            this.TotalAmount = 0;
        }

        public DataSet selectTimeDeposit()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', CertificateNo AS 'Certificate No', DepositAmount AS 'Current Balance' FROM MEMBER m INNER JOIN TIME_DEPOSIT td ON m.AccountNo = td.AccountNo WHERE td.Status = 1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public SqlDataReader getTimeDepositDetails(String certificateNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT CertificateNo, SavingsTypeName, DepositAmount, Maturity, TIME_DEPOSIT.DateCreated,InterestRate,Per FROM TIME_DEPOSIT INNER JOIN INTEREST_RATE on TIME_DEPOSIT.AccountTypeId = INTEREST_RATE.AccountTypeId INNER JOIN SAVINGS_ACCOUNT_TYPE ON SAVINGS_ACCOUNT_TYPE.AccountTypeId = TIME_DEPOSIT.AccountTypeId WHERE CertificateNo = @certNo AND ((MinimumRange <= DepositAmount AND ISNULL(MaximumRange,9999999999999999.99) >= DepositAmount) OR (MinimumRange <= DepositAmount AND MaximumRange = null) OR (MinimumRange = 0 AND ISNULL(MaximumRange,9999999999999999.99) >= DepositAmount))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@certNo", CertificateNo);
            SqlDataReader ds = dal.executeReader(sql,parameters);
            return ds;
        }

        public SqlDataReader getPenalty(double percentage, double amount)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 PenaltyValue, PenaltyStatus FROM EARLY_WITHDRAWAL WHERE BalanceDurationValue <= @percentage AND ((MinimumRange <= @DepositAmount AND MaximumRange >= @DepositAmount) OR (MinimumRange <= @DepositAmount AND MaximumRange = 0) OR (MinimumRange = 0 AND MaximumRange >= @DepositAmount)) ORDER BY BalanceDurationValue desc";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@percentage", percentage);
            parameters.Add("@DepositAmount", amount);
            SqlDataReader ds = dal.executeReader(sql, parameters);
            return ds;
        }

        public DataSet searchTimeDepositAccountNo(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', CertificateNo AS 'Certificate No', DepositAmount AS 'Current Balance' FROM MEMBER m INNER JOIN TIME_DEPOSIT td ON m.AccountNo = td.AccountNo WHERE td.Status = 1 AND m.AccountNo LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchTimeDepositMemberName(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', CertificateNo AS 'Certificate No', DepositAmount AS 'Current Balance' FROM MEMBER m INNER JOIN TIME_DEPOSIT td ON m.AccountNo = td.AccountNo WHERE td.Status = 1 AND LastName LIKE(@searchName) OR MiddleName LIKE(@searchName) OR FirstName LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchTimeDepositCertificateNo(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', CertificateNo AS 'Certificate No', DepositAmount AS 'Current Balance' FROM MEMBER m INNER JOIN TIME_DEPOSIT td ON m.AccountNo = td.AccountNo WHERE td.Status = 1 AND CertificateNo LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertTimeDepositDetails()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertTimeDepositDetails @CertificateNo, @TotalAmount, @Penalty";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@CertificateNo", this.CertificateNo);
            parameters.Add("@TotalAmount", this.TotalAmount);
            parameters.Add("@Penalty", this.Penalty);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result == 1)
            {
                String sql2 = "UPDATE TIME_DEPOSIT SET Status = 0 WHERE CertificateNo = @CertificateNo";
                Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
                parameters2.Add("@CertificateNo", this.CertificateNo);
                dal.executeNonQuery(sql2, parameters2);
            }
            return result;
        }
    }
}
