using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Savings.Maintenance.Model
{
    class TimeDepositInterestModel
    {
        public double InterestRate { get; set; }
        public double NoDays { get; set; }
        public double MinimumRange { get; set; }
        public double MaximumRange { get; set; }
        public int Status { get; set; }

        public TimeDepositInterestModel()
        {
            this.InterestRate = 0;
            this.NoDays = 0;
            this.MinimumRange = 0;
            this.MaximumRange = 0;
            this.Status = 0;
        }

        public DataSet selectTimeDepositInterest()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT InterestId, InterestRate AS 'Interest Rate', NoDays AS 'No of Days', CONCAT(MinimumRange, '-', MaximumRange) AS 'Balance Range', Status, DateCreated, DateModified FROM TIME_DEPOSIT_INTEREST";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectTimeDepositInterest(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT InterestId, InterestRate AS 'Interest Rate', NoDays AS 'No of Days', CONCAT(MinimumRange, '-', MaximumRange) AS 'Balance Range', Status, DateCreated, DateModified FROM TIME_DEPOSIT_INTEREST WHERE InterestRate LIKE(@SearchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@SearchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertTimeDepositInterest()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertTimeDepositInterest @InterestRate, @NoDays, @MinimumRange, @MaximumRange, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@InterestRate", this.InterestRate);
            parameters.Add("@NoDays", this.NoDays);
            parameters.Add("@MinimumRange", this.MinimumRange);
            parameters.Add("@MaximumRange", this.MaximumRange);
            parameters.Add("@Status", this.Status);
            int result = dal.executeNonQuery(sql, parameters);
            return result;
        }

        public int updateTimeDepositInterest(int Id)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateTimeDepositInterest @InterestRate, @NoDays, @MinimumRange, @MaximumRange, @Status, @Id";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@InterestRate", this.InterestRate);
            parameters.Add("@NoDays", this.NoDays);
            parameters.Add("@MinimumRange", this.MinimumRange);
            parameters.Add("@MaximumRange", this.MaximumRange);
            parameters.Add("@Status", this.Status);
            parameters.Add("@Id", Id);
            int result = dal.executeNonQuery(sql, parameters);
            return result;
        }

        public int checkInterestRate(double InterestRate)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM TIME_DEPOSIT_INTEREST WHERE InterestRate = @InterestRate AND Status = 1";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@InterestRate", InterestRate);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkInterestRate(double InterestRate, int Id)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM TIME_DEPOSIT_INTEREST WHERE InterestId != @InterestId AND InterestRate = @InterestRate AND Status = 1";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@InterestRate", InterestRate);
            parameters.Add("@InterestId", Id);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkOverlap(double MinimumRange, double MaximumRange)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM TIME_DEPOSIT_INTEREST WHERE Status = 1 AND ((@MinBal BETWEEN MinimumRange AND MaximumRange) OR (@MaxBal BETWEEN MinimumRange AND MaximumRange) OR (MinimumRange >= @MinBal AND MaximumRange <= @MaxBal))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@MinBal", MinimumRange);
            parameters.Add("@MaxBal", MaximumRange);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkOverlap(double MinimumRange, double MaximumRange, int Id)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM TIME_DEPOSIT_INTEREST WHERE InterestId != @InterestId AND Status = 1 AND ((@MinBal BETWEEN MinimumRange AND MaximumRange) OR (@MaxBal BETWEEN MinimumRange AND MaximumRange) OR (MinimumRange >= @MinBal AND MaximumRange <= @MaxBal))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@MinBal", MinimumRange);
            parameters.Add("@MaxBal", MaximumRange);
            parameters.Add("@InterestId", Id);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }
    }
}
