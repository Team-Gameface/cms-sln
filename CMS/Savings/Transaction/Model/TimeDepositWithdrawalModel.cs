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
            dal.Close();
            return ds;
        }

        public double getInterest(int TimeElapsed, double Principal)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT InterestRate FROM TIME_DEPOSIT_INTEREST WHERE Status = 1 AND NoDays <= @TimeElapsed AND (@Principal >= MinimumRange AND @Principal <= MaximumRange)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TimeElapsed", TimeElapsed);
            parameters.Add("@Principal", Principal);
            SqlDataReader read = dal.executeReader(sql, parameters);
            double d = 0;
            while (read.Read())
            {
                d = double.Parse(read[0].ToString());
            }
            dal.Close();
            read.Close();
            return d;
        }

        public int getDaysElapsed(int TimeElapsed, double Principal)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT NoDays FROM TIME_DEPOSIT_INTEREST WHERE Status = 1 AND NoDays <= @TimeElapsed AND (@Principal >= MinimumRange AND @Principal <= MaximumRange)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TimeElapsed", TimeElapsed);
            parameters.Add("@Principal", Principal);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            dal.Close();
            return i;
        }

        public double getPenalty(double TimeElapsed)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT InterestReduction FROM EARLY_WITHDRAWAL WHERE Status = 1 AND TermsElapsedFrom <= @TimeElapsed AND TermsElapsedTo >= @TimeElapsed";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TimeElapsed", TimeElapsed);
            SqlDataReader read = dal.executeReader(sql, parameters);
            double d = 0;
            while (read.Read())
            {
                d = double.Parse(read[0].ToString());
            }
            dal.Close();
            read.Close();
            return d;
        }

        public double getPrincipal(String certNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT DepositAmount FROM TIME_DEPOSIT WHERE CertificateNo = @certNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@certNo", certNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            double d = 0;
            while (read.Read())
            {
                d = double.Parse(read[0].ToString());
            }
            dal.Close();
            read.Close();
            return d;
        }

        public DateTime getStartDate(String certNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT DateCreated FROM TIME_DEPOSIT WHERE CertificateNo = @certNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@certNo", certNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            DateTime dt = DateTime.Now;
            while (read.Read())
            {
                dt = DateTime.Parse(read[0].ToString());
            }
            dal.Close();
            read.Close();
            return dt;
        }

        public DateTime getMaturityDate(String certNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT Maturity FROM TIME_DEPOSIT WHERE CertificateNo = @certNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@certNo", certNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            DateTime dt = DateTime.Now;
            while (read.Read())
            {
                dt = DateTime.Parse(read[0].ToString());
            }
            dal.Close();
            read.Close();
            return dt;
        }

        public DataSet searchTimeDepositAccountNo(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', CertificateNo AS 'Certificate No', DepositAmount AS 'Current Balance' FROM MEMBER m INNER JOIN TIME_DEPOSIT td ON m.AccountNo = td.AccountNo WHERE td.Status = 1 AND m.AccountNo LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            dal.Close();
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
            dal.Close();
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
            dal.Close();
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
            dal.Close();
            return result;
        }
    }
}
