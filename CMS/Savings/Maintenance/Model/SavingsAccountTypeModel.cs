using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CMS.Savings.Maintenance.Model
{
    class SavingsAccountTypeModel
    {
        public String Name { get; set; }
        public double InitDeposit { get; set; }
        public double MaxWith { get; set; }
        public int AccountHolders { get; set; }
        public int isMaintainingBalance { get; set; }
        public int isDormancy { get; set; }
        public int isInterestRates { get; set; }
        public int Status { get; set; }
        public List<MemberSavingsTypeModel> memberSavingsChecklist { get; set; }
        public MaintainingBalancesModel maintainingBalanceModel { get; set; }
        public DormancyModel dormancyModel { get; set; }
        public InterestRatesModel interestModel { get; set; }

        public SavingsAccountTypeModel()
        {
            this.Name = String.Empty;
            this.InitDeposit = 0;
            this.MaxWith = 0;
            this.AccountHolders = 0;
            this.isMaintainingBalance = 0;
            this.isDormancy = 0;
            this.isInterestRates = 0;
            this.Status = 0;
            this.memberSavingsChecklist = new List<MemberSavingsTypeModel>();
            this.maintainingBalanceModel = new MaintainingBalancesModel();
            this.dormancyModel = new DormancyModel();
            this.interestModel = new InterestRatesModel();
        }

        public DataSet selectAccountTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT s.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Savings Type Name', InitialDeposit AS 'Initial Deposit', MaximumWithdrawal AS 'Maximum Withdrawal', NoOfAccountHolders AS 'No of Account Holders', isMaintainingBalance AS 'Maintaining Balance', isDormancy AS 'Dormancy', isInterestRate AS 'Interest Rate', isArchived, DateCreated AS 'Date Created',	DateModified AS 'Last Modified', Status FROM SAVINGS_ACCOUNT_TYPE s WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectAccountTypesAll()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT s.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Savings Type Name', InitialDeposit AS 'Initial Deposit', MaximumWithdrawal AS 'Maximum Withdrawal', NoOfAccountHolders AS 'No of Account Holders', isMaintainingBalance AS 'Maintaining Balance', isDormancy AS 'Dormancy', isInterestRate AS 'Interest Rate', isArchived, DateCreated AS 'Date Created',	DateModified AS 'Last Modified', Status FROM SAVINGS_ACCOUNT_TYPE s";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectMemberTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberTypeNo, Description FROM MEMBER_TYPE WHERE hasSavings = 1 AND Status = 1 AND isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public int checkName(String Name)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM SAVINGS_ACCOUNT_TYPE WHERE dbo.RemoveSpecialChars(SavingsTypeName) = dbo.RemoveSpecialChars(@Name) AND isArchived = 0";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Name", Name);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public DataSet selectMemberTypeSavings(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberTypeNo FROM MEMBER_TYPE_SAVINGS_TYPE WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int getInsertId()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 AccountTypeId FROM SAVINGS_ACCOUNT_TYPE ORDER BY AccountTypeId DESC";
            SqlDataReader read = dal.executeReader(sql);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int insertSavingsAccount()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertSavingsAccountType @Name, @InitDeposit, @MaxWith, @AccountHolders, @isMaintainingBalance, @isDormancy, @isInterestRates, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Name", this.Name);
            parameters.Add("@InitDeposit", this.InitDeposit);
            parameters.Add("@MaxWith", this.MaxWith);
            parameters.Add("@AccountHolders", this.AccountHolders);
            parameters.Add("@isMaintainingBalance", this.isMaintainingBalance);
            parameters.Add("@isDormancy", this.isDormancy);
            parameters.Add("@isInterestRates", this.isInterestRates);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result == 1)
            {
                foreach (MemberSavingsTypeModel memberSavings in this.memberSavingsChecklist)
                {
                    String s = "EXEC insertMemberTypeSavings @AccountTypeId, @MemberTypeNo";
                    Dictionary<String, Object> param = new Dictionary<string, object>();
                    param.Add("@AccountTypeId", memberSavings.AccountTypeId);
                    param.Add("@MemberTypeNo", memberSavings.MemberTypeNo);
                    dal.executeNonQuery(s, param);
                }
            }
            return result;
        }

        public int insertInterestRate()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertInterestRate @TypeId, @InterestRate, @MinRange";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", this.interestModel.TypeId);
            parameters.Add("@InterestRate", this.interestModel.InterestRate);
            parameters.Add("@MinRange", this.interestModel.MinRange);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int updateInterestRate(int InterestId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateInterestRate @TypeId, @InterestRate, @MinRange";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", this.interestModel.TypeId);
            parameters.Add("@InterestRate", this.interestModel.InterestRate);
            parameters.Add("@MinRange", this.interestModel.MinRange);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int deleteInterestRate(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "DELETE FROM INTEREST_RATE WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
        
        public int insertMaintainingBalance()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertMaintainingBalance @TypeId, @Balance, @Charge, @ChargeStatus, @Duration, @DurationStatus";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", this.maintainingBalanceModel.AccountTypeId);
            parameters.Add("@Balance", this.maintainingBalanceModel.MaintainingBalance);
            parameters.Add("@Charge", this.maintainingBalanceModel.ServiceCharge);
            parameters.Add("@ChargeStatus", this.maintainingBalanceModel.ServiceChargeStatus);
            parameters.Add("@Duration", this.maintainingBalanceModel.ServiceChargeDuration);
            parameters.Add("@DurationStatus", this.maintainingBalanceModel.ServiceChargeDurationStatus);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int updateMaintainingBalance(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateMaintainingBalance @TypeId, @Balance, @Charge, @ChargeStatus, @Duration, @DurationStatus";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            parameters.Add("@Balance", this.maintainingBalanceModel.MaintainingBalance);
            parameters.Add("@Charge", this.maintainingBalanceModel.ServiceCharge);
            parameters.Add("@ChargeStatus", this.maintainingBalanceModel.ServiceChargeStatus);
            parameters.Add("@Duration", this.maintainingBalanceModel.ServiceChargeDuration);
            parameters.Add("@DurationStatus", this.maintainingBalanceModel.ServiceChargeDurationStatus);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int deleteMaintainingBalance(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "DELETE FROM MAINTAINING_BALANCE WHERE SavingsAccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int insertDormancy()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertDormancy @TypeId, @PenaltyValue, @PenaltyStatus, @DormancyValue, @DormancyStatus, @ChargeValue, @ChargeStatus";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", this.dormancyModel.TypeId);
            parameters.Add("@PenaltyValue", this.dormancyModel.Penalty);
            parameters.Add("@PenaltyStatus", this.dormancyModel.PenaltyStatus);
            parameters.Add("@DormancyValue", this.dormancyModel.Dormancy);
            parameters.Add("@DormancyStatus", this.dormancyModel.DormancyStatus);
            parameters.Add("@ChargeValue", this.dormancyModel.Charge);
            parameters.Add("@ChargeStatus", this.dormancyModel.ChargeStatus);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int updateDormancy(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateDormancy @TypeId, @PenaltyValue, @PenaltyStatus, @DormancyValue, @DormancyStatus, @ChargeValue, @ChargeStatus";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            parameters.Add("@PenaltyValue", this.dormancyModel.Penalty);
            parameters.Add("@PenaltyStatus", this.dormancyModel.PenaltyStatus);
            parameters.Add("@DormancyValue", this.dormancyModel.Dormancy);
            parameters.Add("@DormancyStatus", this.dormancyModel.DormancyStatus);
            parameters.Add("@ChargeValue", this.dormancyModel.Charge);
            parameters.Add("@ChargeStatus", this.dormancyModel.ChargeStatus);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int deleteDormancy(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "DELETE FROM DORMANCY WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int updateSavingsAccount(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateSavingsAccountType @Name, @InitDeposit, @MaxWith, @AccountHolders, @isMaintainingBalance, @isDormancy, @isInterestRates, @Status, @AccountTypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Name", this.Name);
            parameters.Add("@InitDeposit", this.InitDeposit);
            parameters.Add("@MaxWith", this.MaxWith);
            parameters.Add("@AccountHolders", this.AccountHolders);
            parameters.Add("@isMaintainingBalance", this.isMaintainingBalance);
            parameters.Add("@isDormancy", this.isDormancy);
            parameters.Add("@isInterestRates", this.isInterestRates);
            parameters.Add("@Status", this.Status);
            parameters.Add("@AccountTypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result != 0)
            {
                String sqlInner = "DELETE FROM MEMBER_TYPE_SAVINGS_TYPE WHERE AccountTypeId = @TypeId";
                Dictionary<String, Object> parametersInner = new Dictionary<string, object>();
                parametersInner.Add("@TypeId", TypeId);
                dal.executeNonQuery(sqlInner, parametersInner);
                foreach (MemberSavingsTypeModel memberSavings in this.memberSavingsChecklist)
                {
                    String s = "EXEC insertMemberTypeSavings @TypeId, @MemberTypeNo";
                    Dictionary<String, Object> param = new Dictionary<string, object>();
                    param.Add("@TypeId", TypeId);
                    param.Add("@MemberTypeNo", memberSavings.MemberTypeNo);
                    dal.executeNonQuery(s, param);
                }
            }
            return result;
        }

        public int deleteSavingsAccount(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE SAVINGS_ACCOUNT_TYPE SET isArchived = 1 WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int retrieveSavingsAccount(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE SAVINGS_ACCOUNT_TYPE SET isArchived = 0 WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public String[] selectMaintainingBalance(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT * FROM MAINTAINING_BALANCE WHERE SavingsAccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            SqlDataReader read = dal.executeReader(sql, parameters);
            String[] result = new String[5];
            while (read.Read())
            {
                result[0] = read[1].ToString();
                result[1] = read[2].ToString();
                result[2] = read[3].ToString();
                result[3] = read[4].ToString();
                result[4] = read[5].ToString();
            }
            return result;
        }

        public String[] selectDormancy(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT * FROM DORMANCY WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            SqlDataReader read = dal.executeReader(sql, parameters);
            String[] result = new String[6];
            while (read.Read())
            {
                result[0] = read[1].ToString();
                result[1] = read[2].ToString();
                result[2] = read[3].ToString();
                result[3] = read[4].ToString();
                result[4] = read[5].ToString();
                result[5] = read[6].ToString();
            }
            return result;
        }

        public String[] selectInterestRate(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT * FROM INTEREST_RATE WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            SqlDataReader read = dal.executeReader(sql, parameters);
            String[] result = new String[6];
            while (read.Read())
            {
                result[0] = read[1].ToString();
                result[1] = read[2].ToString();
            }
            return result;
        }

        public int checkMainBal(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM MAINTAINING_BALANCE WHERE SavingsAccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkDormancy(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM DORMANCY WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkInterest(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM INTEREST_RATE WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
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