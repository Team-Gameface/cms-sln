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
    class TimeDepositModel
    {
        public String CertificateNo { get; set; }
        public int AccountTypeId { get; set; }
        public String AccountNo { get; set; }
        public double Amount { get; set; }
        public String Maturity { get; set; }

        public TimeDepositModel()
        {
            this.CertificateNo = String.Empty;
            this.AccountTypeId = 0;
            this.AccountNo = String.Empty;
            this.Amount = 0;
            this.Maturity = String.Empty;
        }

        public DataSet selectTimeDeposit()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId, SavingsTypeName FROM SAVINGS_ACCOUNT_TYPE WHERE Status = 1 AND isArchived = 0 AND isTimeDeposit = 1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectMember()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name' FROM MEMBER WHERE MemberTypeNo IN(SELECT MemberTypeNo FROM MEMBER_TYPE_SAVINGS_TYPE WHERE AccountTypeId IN (SELECT AccountTypeId FROM SAVINGS_ACCOUNT_TYPE WHERE isTimeDeposit = 1))";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public double selectInitialDeposit(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT InitialDeposit FROM SAVINGS_ACCOUNT_TYPE WHERE Status = 1 AND isArchived = 0 AND isTimeDeposit = 1 AND AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            SqlDataReader read = dal.executeReader(sql, parameters);
            double d = 0;
            while (read.Read())
            {
                d = double.Parse(read[0].ToString());
            }
            return d;
        }

        public DataSet searchMemberAccount(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name' FROM MEMBER WHERE MemberTypeNo IN(SELECT MemberTypeNo FROM MEMBER_TYPE_SAVINGS_TYPE WHERE AccountTypeId IN (SELECT AccountTypeId FROM SAVINGS_ACCOUNT_TYPE WHERE isTimeDeposit = 1)) AND AccountNo LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberName(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name' FROM MEMBER WHERE MemberTypeNo IN(SELECT MemberTypeNo FROM MEMBER_TYPE_SAVINGS_TYPE WHERE AccountTypeId IN (SELECT AccountTypeId FROM SAVINGS_ACCOUNT_TYPE WHERE isTimeDeposit = 1)) AND LastName LIKE(@searchName) OR FirstName LIKE(@searchName) OR MiddleName LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int generateCertificateNo()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CertificateNo FROM TIME_DEPOSIT ORDER BY CertificateNo DESC";
            SqlDataReader read = dal.executeReader(sql);
            int i = 0;
            while (read.Read())
            {
                String maxAcctNo = read[0].ToString().Split('-')[1];
                i = Convert.ToInt32(maxAcctNo);
            }
            return i + 1;
        }

        public int insertSavingsTransaction()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertTimeDeposit @CertificateNo, @AccountTypeId, @AccountNo, @Amount, @Maturity";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@CertificateNo", this.CertificateNo);
            parameters.Add("@AccountTypeId", this.AccountTypeId);
            parameters.Add("@AccountNo", this.AccountNo);
            parameters.Add("@Amount", this.Amount);
            parameters.Add("@Maturity", this.Maturity);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}
