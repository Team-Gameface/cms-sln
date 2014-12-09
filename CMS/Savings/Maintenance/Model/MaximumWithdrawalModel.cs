using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace CMS.Savings.Maintenance.Model
{
    class MaximumWithdrawalModel
    {
        public int AccountTypeId { get; set; }
        public double MaxWith { get; set; }
        public int Status { get; set; }

        public MaximumWithdrawalModel()
        {
            this.AccountTypeId = 0;
            this.MaxWith = 0;
            this.Status = 0;
        }

        public DataSet selectAccountTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId, SavingsTypeName FROM SAVINGS_ACCOUNT_TYPE WHERE AccountTypeId NOT IN(SELECT AccountTypeId FROM MAXIMUM_WITHDRAWAL) AND isMaximumWithdrawal = 1 AND isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            dal.Close();
            return ds;
        }

        public DataSet selectMaximumWithdrawal()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type', MaximumWithdrawal AS 'Maximum Withdrawal', m.Status, isArchived, m.DateCreated AS 'Date Created', m.DateModified AS 'Last Modified' FROM MAXIMUM_WITHDRAWAL m INNER JOIN SAVINGS_ACCOUNT_TYPE s ON m.AccountTypeId = s.AccountTypeId WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            dal.Close();
            return ds;
        }

        public DataSet selectMaximumWithdrawalAll()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type', MaximumWithdrawal AS 'Maximum Withdrawal', m.Status, isArchived, m.DateCreated AS 'Date Created', m.DateModified AS 'Last Modified' FROM MAXIMUM_WITHDRAWAL m INNER JOIN SAVINGS_ACCOUNT_TYPE s ON m.AccountTypeId = s.AccountTypeId";
            DataSet ds = dal.executeDataSet(sql);
            dal.Close();
            return ds;
        }

        public int insertMaximumWithdrawal()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertMaximumWithdrawal @TypeId, @MaxWith, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", this.AccountTypeId);
            parameters.Add("@MaxWith", this.MaxWith);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            dal.Close();
            return result;
        }

        public int updateMaximumWithdrawal(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateMaximumWithdrawal @TypeId, @MaxWith, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            parameters.Add("@MaxWith", this.MaxWith);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            dal.Close();
            return result;
        }
    }
}
