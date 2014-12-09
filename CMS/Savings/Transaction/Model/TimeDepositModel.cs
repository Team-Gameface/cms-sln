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
            dal.Close();
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
            dal.Close();
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
            dal.Close();
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
            dal.Close();
            read.Close();
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
            dal.Close();
            read.Close();
            return d;
        }

        public int insertSavingsTransaction()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertTimeDeposit @CertificateNo, @AccountNo, @Amount, @Maturity; SELECT @@IDENTITY";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@CertificateNo", this.CertificateNo);
            parameters.Add("@AccountNo", this.AccountNo);
            parameters.Add("@Amount", this.Amount);
            parameters.Add("@Maturity", this.Maturity);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            dal.Close();
            return result;

        }

        public DataSet getDepositDetails(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 td.CertificateNo AS 'CertNo', td.AccountNo, CONCAT(m.FirstName, ' ', m.MiddleName, ' ', m.LastName) AS 'Name', td.Maturity, td.DepositAmount AS 'Amount', DATEDIFF(day, td.DateCreated, td.Maturity) AS 'TermDays', tdi.InterestRate  FROM TIME_DEPOSIT td INNER JOIN MEMBER m ON td.AccountNo = m.AccountNo, TIME_DEPOSIT_INTEREST tdi WHERE DATEDIFF(day, td.DateCreated, td.Maturity) >= NoDays AND td.DepositAmount >= tdi.MinimumRange AND td.DepositAmount <= MaximumRange AND CertificateNo = @CertNo ORDER BY NoDays desc";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@CertNo", this.CertificateNo);
            DataSet ds = dal.executeDataSet(sql, parameters, src);
            dal.Close();
            return ds;
        }

        public DataSet getCompanyProfile(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CompanyName,AccreditationNo,CompanyAddress,CompanyLogo,Telephone,Cellphone,Email FROM COMPANY WHERE status = 1 ORDER BY dateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            dal.Close();
            return ds;
        }

        public DataSet getManager(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CONCAT(FirstName,' ',MiddleName,' ',LastName) AS 'Name', Position FROM SYSTEM_USERS WHERE UserType = 'Manager' ORDER BY DateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            dal.Close();
            return ds;
        }

    }
}
