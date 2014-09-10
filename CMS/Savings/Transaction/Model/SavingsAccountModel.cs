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
    public class SavingsAccountModel
    {
        public String SavingsAccountNo { get; set; }
        public String WithdrawalMode { get; set; }
        public int AccountTypeId { get; set; }
        public double InitialDeposit { get; set; }
        public int PassbookNo { get; set; }
        public List<MemberSavingsAccountModel> memberSavingsAccount { get; set; }

        public SavingsAccountModel()
        {
            this.SavingsAccountNo = String.Empty;
            this.WithdrawalMode = String.Empty;
            this.AccountTypeId = 0;
            this.InitialDeposit = 0;
            this.PassbookNo = 0;
            this.memberSavingsAccount = new List<MemberSavingsAccountModel>();
        }

        public DataSet selectAccountType()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId AS 'TypeId', SavingsTypeName AS 'SavingsType' FROM SAVINGS_ACCOUNT_TYPE WHERE isArchived = 0 AND Status = 1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectAccountTypeDetails(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT InitialDeposit, NoOfAccountHolders FROM SAVINGS_ACCOUNT_TYPE WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectSavingsAccount()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT DISTINCT sa.SavingsAccountNo AS 'Account No', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Account Holder', SavingsTypeName AS 'Savings Type', sa.AccountTypeId, Balance FROM SAVINGS_ACCOUNT sa INNER JOIN MEMBER_SAVINGS_ACCOUNT msa ON sa.SavingsAccountNo = msa.SavingsAccountNo INNER JOIN SAVINGS_ACCOUNT_TYPE sat ON sa.AccountTypeId = sat.AccountTypeId INNER JOIN MEMBER m ON msa.MemberAccountNo = m.AccountNo WHERE sa.Status = 1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchSavingsAccount(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT DISTINCT sa.SavingsAccountNo AS 'Account No', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Account Holder', SavingsTypeName AS 'Savings Type', sa.AccountTypeId, Balance FROM SAVINGS_ACCOUNT sa INNER JOIN MEMBER_SAVINGS_ACCOUNT msa ON sa.SavingsAccountNo = msa.SavingsAccountNo INNER JOIN SAVINGS_ACCOUNT_TYPE sat ON sa.AccountTypeId = sat.AccountTypeId INNER JOIN MEMBER m ON msa.MemberAccountNo = m.AccountNo WHERE sa.Status = 1 AND sa.SavingsAccountNo LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectMember(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountNo, CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name' FROM MEMBER WHERE AccountNo NOT IN (SELECT MemberAccountNo FROM MEMBER_SAVINGS_ACCOUNT ms INNER JOIN SAVINGS_ACCOUNT s ON ms.SavingsAccountNo = s.SavingsAccountNo WHERE s.Status = 1) AND MemberTypeNo IN (SELECT MemberTypeNo FROM MEMBER_TYPE_SAVINGS_TYPE WHERE AccountTypeId = @TypeId) AND AccountNo NOT IN (SELECT AccountNo FROM TERMINATION)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMember(int TypeId, String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountNo, CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name' FROM MEMBER WHERE AccountNo NOT IN (SELECT MemberAccountNo FROM MEMBER_SAVINGS_ACCOUNT ms INNER JOIN SAVINGS_ACCOUNT s ON ms.SavingsAccountNo = s.SavingsAccountNo WHERE s.Status = 1) AND MemberTypeNo IN (SELECT MemberTypeNo FROM MEMBER_TYPE_SAVINGS_TYPE WHERE AccountTypeId = @TypeId) AND AccountNo NOT IN (SELECT AccountNo FROM TERMINATION) AND (LastName LIKE(@searchName) OR FirstName LIKE(@searchName) OR MiddleName LIKE(@searchName))";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int generateSavingsPassbook()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 SavingsPassbookNo FROM MEMBER_SAVINGS_PASSBOOK ORDER BY SavingsPassbookNo DESC";
            SqlDataReader read = dal.executeReader(sql);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i + 1;
        }

        public int generateAccountNo()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 SavingsAccountNo FROM SAVINGS_ACCOUNT ORDER BY SavingsAccountNo DESC";
            SqlDataReader read = dal.executeReader(sql);
            int i = 0;
            while (read.Read())
            {
                String maxAcctNo = read[0].ToString().Split('-')[1];
                i = Convert.ToInt32(maxAcctNo);
            }
            return i + 1;
        }

        public int insertSavingsAccount()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertSavingsAccount @SavingsAccountNo, @WithMode, @TypeId, @Balance";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@SavingsAccountNo", this.SavingsAccountNo);
            parameters.Add("@WithMode", this.WithdrawalMode);
            parameters.Add("@TypeId", this.AccountTypeId);
            parameters.Add("@Balance", this.InitialDeposit);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            foreach (MemberSavingsAccountModel memberSavings in this.memberSavingsAccount)
            {
                String s = "EXEC insertMemberSavingsAccount @MemberAccountNo, @SavingsAccountNo";
                Dictionary<String, Object> param = new Dictionary<string, object>();
                param.Add("@MemberAccountNo", memberSavings.MemberAccountNo);
                param.Add("@SavingsAccountNo", memberSavings.SavingsAccountNo);
                dal.executeNonQuery(s, param);
            }
            String sql2 = "EXEC insertMemberSavingsPassbook @SavingsPassbookNo, @SavingsAccountNo";
            Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
            parameters2.Add("@SavingsPassbookNo", this.PassbookNo);
            parameters2.Add("@SavingsAccountNo", this.SavingsAccountNo);
            int result2 = Convert.ToInt32(dal.executeNonQuery(sql2, parameters2));

            String sql3 = "EXEC insertSavingsTransaction @SavingsAccountNo, @TransactionMode, @Amount, @Representative, @SavingsPassbook";
            Dictionary<String, Object> parameters3 = new Dictionary<string, object>();
            parameters3.Add("@SavingsAccountNo", this.SavingsAccountNo);
            parameters3.Add("@TransactionMode", "Deposit");
            parameters3.Add("@Amount", this.InitialDeposit);
            parameters3.Add("@Representative", String.Empty);
            parameters3.Add("@SavingsPassbook", this.PassbookNo);
            int result3 = Convert.ToInt32(dal.executeNonQuery(sql3, parameters3));
            if (result == 1 && result2 == 1 && result3 == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
