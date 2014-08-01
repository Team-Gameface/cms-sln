using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace CMS.Savings.Maintenance.Model
{
    class InterestRatesModel
    {
        public int TypeId { get; set; }
        public double InterestRate { get; set; }
        public String Per { get; set; }
        public double MinRange { get; set; }
        public Object MaxRange { get; set; }
        public int Status { get; set; }

        public InterestRatesModel()
        {
            this.TypeId = 0;
            this.InterestRate = 0;
            this.Per = String.Empty;
            this.MinRange = 0;
            this.MaxRange = 0;
            this.Status = 0;
        }

        public DataSet selectAccountTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId, SavingsTypeName FROM SAVINGS_ACCOUNT_TYPE WHERE isInterestRate = 1 AND isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public int checkInterest(int savings, double interest, int interestid)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM INTEREST_RATE WHERE AccountTypeId = @savings AND InterestRate = @interest AND InterestId != @interestid";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@savings", savings);
            parameters.Add("@interest", interest);
            parameters.Add("@interestid", interestid);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkBalanceRange(double MinBal, Object MaxBal, int savings, int interestid)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM INTEREST_RATE WHERE AccountTypeId = @savings AND InterestId != @interestid AND Status = 1 AND MaximumRange != 0 AND ((@MinBal BETWEEN MinimumRange AND MaximumRange) OR (ISNULL(@MaxBal,999999999999999.99) BETWEEN MinimumRange AND MaximumRange) OR (MinimumRange >= @MinBal AND MaximumRange <= ISNULL(@MaxBal,9999999999999999.99)))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@savings", savings);
            parameters.Add("@interestid", interestid);
            parameters.Add("@MinBal", MinBal);
            parameters.Add("@MaxBal", MaxBal);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

   /*     public int checkBracketed(int savings, double MinBal, double MaxBal, int interestId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT * FROM INTEREST_RATE WHERE InterestId != 0  AND AccountTypeId = @savings AND Status = 1 AND ((MaximumRange != 0 AND ((MaximumRange >= @MinBal AND MaximumRange <= @MaxBal) OR (MinimumRange >= @MinBal AND MinimumRange <= @MaxBal))) OR (MinimumRange < @MinBal AND MaximumRange = 0))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@interestId", interestId);
            parameters.Add("@savings", savings);
            parameters.Add("@MinBal", MinBal);
            parameters.Add("@MaxBal", MaxBal);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }*/

        public int checkUnbracketed(int savings, double MinBal, int interestId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM INTEREST_RATE WHERE InterestId != @interestId AND AccountTypeId = @savings AND Status = 1 AND (MaximumRange = 0 AND (MinimumRange <= @MinBal OR MinimumRange >= @MinBal))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@interestId", interestId);
            parameters.Add("@savings", savings);
            parameters.Add("@MinBal", MinBal);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public DataSet selectInterestRates()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT i.InterestId AS 'Interest Id', i.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type', CONCAT(InterestRate, '% ', Per) AS 'Interest Rate', CONCAT(MinimumRange, '-', ISNULL(MaximumRange,0)) AS 'Balance Range', i.Status, isArchived, i.DateCreated AS 'Date Created', i.DateModified AS 'Last Modified' FROM INTEREST_RATE i INNER JOIN SAVINGS_ACCOUNT_TYPE s ON i.AccountTypeId = s.AccountTypeId WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchInterestRates(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT i.InterestId AS 'Interest Id', i.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type', CONCAT(InterestRate, '% ', Per) AS 'Interest Rate', CONCAT(MinimumRange, '-', ISNULL(MaximumRange,0)) AS 'Balance Range', i.Status, isArchived, i.DateCreated AS 'Date Created', i.DateModified AS 'Last Modified' FROM INTEREST_RATE i INNER JOIN SAVINGS_ACCOUNT_TYPE s ON i.AccountTypeId = s.AccountTypeId WHERE isArchived = 0 AND SavingsTypeName LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchInterestRatesAll(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT i.InterestId AS 'Interest Id', i.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type', CONCAT(InterestRate, '% ', Per) AS 'Interest Rate', CONCAT(MinimumRange, '-', ISNULL(MaximumRange,0)) AS 'Balance Range', i.Status, isArchived, i.DateCreated AS 'Date Created', i.DateModified AS 'Last Modified' FROM INTEREST_RATE i INNER JOIN SAVINGS_ACCOUNT_TYPE s ON i.AccountTypeId = s.AccountTypeId WHERE SavingsTypeName LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertInterestRate()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertInterestRate @TypeId, @InterestRate, @Per, @MinRange, @MaxRange, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", this.TypeId);
            parameters.Add("@InterestRate", this.InterestRate);
            parameters.Add("@Per", this.Per);
            parameters.Add("@MinRange", this.MinRange);
            parameters.Add("@MaxRange", this.MaxRange);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int updateInterestRate(int InterestId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateInterestRate @InterestId, @InterestRate, @Per, @MinRange, @MaxRange, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@InterestId", InterestId);
            parameters.Add("@InterestRate", this.InterestRate);
            parameters.Add("@Per", this.Per);
            parameters.Add("@MinRange", this.MinRange);
            parameters.Add("@MaxRange", this.MaxRange);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}
