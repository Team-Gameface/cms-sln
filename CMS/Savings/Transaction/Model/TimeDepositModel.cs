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
        public String AccountNo { get; set; }
        public double Amount { get; set; }
        public String Maturity { get; set; }

        public TimeDepositModel()
        {
            this.CertificateNo = String.Empty;
            this.AccountNo = String.Empty;
            this.Amount = 0;
            this.Maturity = String.Empty;
        }

        public DataSet selectMember()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name' FROM MEMBER WHERE MemberTypeNo IN(SELECT MemberTypeNo FROM MEMBER_TYPE WHERE hasSavings = 1)";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchMemberAccount(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name' FROM MEMBER WHERE MemberTypeNo IN(SELECT MemberTypeNo FROM MEMBER_TYPE WHERE hasSavings = 1) AND AccountNo LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberName(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name' FROM MEMBER WHERE MemberTypeNo IN(SELECT MemberTypeNo FROM MEMBER_TYPE WHERE hasSavings = 1) AND LastName LIKE(@searchName) OR FirstName LIKE(@searchName) OR MiddleName LIKE(@searchName)";
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

        public double selectMinimumAmount()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 MinimumRange FROM TIME_DEPOSIT_INTEREST WHERE Status = 1 ORDER BY 1";
            SqlDataReader read = dal.executeReader(sql);
            double d = 0;
            while (read.Read())
            {
                d = double.Parse(read[0].ToString());
            }
            return d;
        }

        public int insertSavingsTransaction()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertTimeDeposit @CertificateNo, @AccountNo, @Amount, @Maturity";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@CertificateNo", this.CertificateNo);
            parameters.Add("@AccountNo", this.AccountNo);
            parameters.Add("@Amount", this.Amount);
            parameters.Add("@Maturity", this.Maturity);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}
