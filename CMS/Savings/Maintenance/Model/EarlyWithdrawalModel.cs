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
    class EarlyWithdrawalModel
    {
        public int TypeId { get; set; }
        public double Penalty { get; set; }
        public String Per { get; set; }
        public int Duration { get; set; }
        public String DurationStatus { get; set; }
        public double MinRange { get; set; }
        public double MaxRange { get; set; }
        public int Status { get; set; }

        public EarlyWithdrawalModel()
        {
            this.TypeId = 0;
            this.Penalty = 0;
            this.Per = String.Empty;
            this.Duration = 0;
            this.DurationStatus = String.Empty;
            this.MinRange = 0;
            this.MaxRange = 0;
            this.Status = 0;
        }

        public DataSet selectAccountTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId, SavingsTypeName FROM SAVINGS_ACCOUNT_TYPE WHERE isTimeDeposit = 1 AND isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectEarlyWithdrawal()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT EarlyWithdrawalId AS 'Early Withdrawal Id', t.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type',  CONCAT(BalanceDurationValue, ' ',  BalanceDurationStatus) AS 'Duration', CONCAT(PenaltyValue, ' ', PenaltyStatus) AS 'Penalty', CONCAT(MinimumRange, '-', MaximumRange) AS 'Balance Range', t.Status, isArchived, t.DateCreated AS 'Date Created', t.DateModified AS 'Last Modified' FROM EARLY_WITHDRAWAL t INNER JOIN SAVINGS_ACCOUNT_TYPE s ON t.AccountTypeId = s.AccountTypeId WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public int checkPenalty(int savings, double penalty, String penaltyRate, int id, int balDuration, String balDurationStatus)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM EARLY_WITHDRAWAL WHERE AccountTypeId = @savings AND PenaltyValue = @penalty AND PenaltyStatus = @penaltyRate AND EarlyWithdrawalId != @id AND BalanceDurationValue = @BalDuration AND BalanceDurationStatus = @BalDurationStatus";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@savings", savings);
            parameters.Add("@penalty", penalty);
            parameters.Add("@penaltyRate", penaltyRate);
            parameters.Add("@id", id);
            parameters.Add("@BalDuration", balDuration);
            parameters.Add("@BalDurationStatus", balDurationStatus);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkBalanceRange(double MinBal, double MaxBal, int savings, int id, int balDuration, String balDurationStatus)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM EARLY_WITHDRAWAL WHERE AccountTypeId = @savings AND EarlyWithdrawalId != @id AND MaximumRange != 0 AND Status = 1 AND BalanceDurationValue = @BalDuration AND BalanceDurationStatus = @BalDurationStatus AND ((@MinBal BETWEEN MinimumRange AND MaximumRange) OR (@MaxBal BETWEEN MinimumRange AND MaximumRange) OR (MinimumRange >= @MinBal AND MaximumRange <= @MaxBal))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@savings", savings);
            parameters.Add("@id", id);
            parameters.Add("@MinBal", MinBal);
            parameters.Add("@MaxBal", MaxBal);
            parameters.Add("@BalDuration", balDuration);
            parameters.Add("@BalDurationStatus", balDurationStatus);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkBracketed(int savings, double MinBal, int earlyWithdrawalId, int balDuration, String balDurationStatus)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM EARLY_WITHDRAWAL WHERE EarlyWithdrawalId != @earlyWithdrawalId AND AccountTypeId = @savings AND Status = 1 AND BalanceDurationValue = @BalDuration AND BalanceDurationStatus = @BalDurationStatus AND (MaximumRange >= @MinBal OR MinimumRange >= @MinBal)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@earlyWithdrawalId", earlyWithdrawalId);
            parameters.Add("@savings", savings);
            parameters.Add("@MinBal", MinBal);
            parameters.Add("@BalDuration", balDuration);
            parameters.Add("@BalDurationStatus", balDurationStatus);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkUnbracketed(int savings, double MinBal, int earlyWithdrawalId, int balDuration, String balDurationStatus)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM EARLY_WITHDRAWAL WHERE EarlyWithdrawalId != @earlyWithdrawalId AND AccountTypeId = @savings AND Status = 1 AND BalanceDurationValue = @BalDuration AND BalanceDurationStatus = @BalDurationStatus AND MaximumRange = 0  AND MinimumRange <= @MinBal";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@earlyWithdrawalId", earlyWithdrawalId);
            parameters.Add("@savings", savings);
            parameters.Add("@MinBal", MinBal);
            parameters.Add("@BalDuration", balDuration);
            parameters.Add("@BalDurationStatus", balDurationStatus);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public DataSet searchEarlyWithdrawal(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT EarlyWithdrawalId AS 'Early Withdrawal Id', t.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type',  CONCAT(BalanceDurationValue, ' ',  BalanceDurationStatus) AS 'Duration', CONCAT(PenaltyValue, ' ', PenaltyStatus) AS 'Penalty', CONCAT(MinimumRange, '-', MaximumRange) AS 'Balance Range', t.Status, isArchived, t.DateCreated AS 'Date Created', t.DateModified AS 'Last Modified' FROM EARLY_WITHDRAWAL t INNER JOIN SAVINGS_ACCOUNT_TYPE s ON t.AccountTypeId = s.AccountTypeId WHERE isArchived = 0 AND SavingsTypeName LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchEarlyWithdrawalAll(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT EarlyWithdrawalId AS 'Early Withdrawal Id', t.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type',  CONCAT(BalanceDurationValue, ' ',  BalanceDurationStatus) AS 'Duration', CONCAT(PenaltyValue, ' ', PenaltyStatus) AS 'Penalty', CONCAT(MinimumRange, '-', MaximumRange) AS 'Balance Range', t.Status, isArchived, t.DateCreated AS 'Date Created', t.DateModified AS 'Last Modified' FROM EARLY_WITHDRAWAL t INNER JOIN SAVINGS_ACCOUNT_TYPE s ON t.AccountTypeId = s.AccountTypeId WHERE SavingsTypeName LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertEarlyWithdrawal()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertEarlyWithdrawal @TypeId, @Penalty, @Per, @Duration, @DurationStatus, @MinRange, @MaxRange, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", this.TypeId);
            parameters.Add("@Penalty", this.Penalty);
            parameters.Add("@Per", this.Per);
            parameters.Add("@Duration", this.Duration);
            parameters.Add("@DurationStatus", this.DurationStatus);
            parameters.Add("@MinRange", this.MinRange);
            parameters.Add("@MaxRange", this.MaxRange);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int updateEarlyWithdrawal(int EarlyWithdrawalId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateEarlyWithdrawal @EarlyWithdrawalId, @Penalty, @Per, @Duration, @DurationStatus, @MinRange, @MaxRange, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@EarlyWithdrawalId", EarlyWithdrawalId);
            parameters.Add("@Penalty", this.Penalty);
            parameters.Add("@Per", this.Per);
            parameters.Add("@Duration", this.Duration);
            parameters.Add("@DurationStatus", this.DurationStatus);
            parameters.Add("@MinRange", this.MinRange);
            parameters.Add("@MaxRange", this.MaxRange);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}
