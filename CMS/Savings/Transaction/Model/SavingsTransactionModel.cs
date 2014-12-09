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
    class SavingsTransactionModel
    {
        public String AccountNo { get; set; }
        public double Amount { get; set; }
        public String Representative { get; set; }
        public String TransactionMode { get; set; }
        public int PassbookNo { get; set; }

        public SavingsTransactionModel()
        {
            this.AccountNo = String.Empty;
            this.Amount = 0;
            this.Representative = String.Empty;
            this.TransactionMode = String.Empty;
            this.PassbookNo = 0;
        }

        public DataSet selectMember()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT DISTINCT sa.SavingsAccountNo AS 'Account No', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Account Holder', SavingsTypeName AS 'Savings Type', sa.AccountTypeId, Balance FROM SAVINGS_ACCOUNT sa INNER JOIN MEMBER_SAVINGS_ACCOUNT msa ON sa.SavingsAccountNo = msa.SavingsAccountNo INNER JOIN SAVINGS_ACCOUNT_TYPE sat ON sa.AccountTypeId = sat.AccountTypeId INNER JOIN MEMBER m ON msa.MemberAccountNo = m.AccountNo WHERE sa.Status = 1";
            DataSet ds = dal.executeDataSet(sql);
            dal.Close();
            return ds;
        }

        public DataSet searchMember(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT DISTINCT sa.SavingsAccountNo AS 'Account No', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Account Holder', SavingsTypeName AS 'Savings Type', sa.AccountTypeId, Balance FROM SAVINGS_ACCOUNT sa INNER JOIN MEMBER_SAVINGS_ACCOUNT msa ON sa.SavingsAccountNo = msa.SavingsAccountNo INNER JOIN SAVINGS_ACCOUNT_TYPE sat ON sa.AccountTypeId = sat.AccountTypeId INNER JOIN MEMBER m ON msa.MemberAccountNo = m.AccountNo WHERE sa.Status = 1 AND sa.SavingsAccountNo LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            dal.Close();
            return ds;
        }

        public double selectMaintainingBalance(int AccountType)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MaintainingBalance FROM MAINTAINING_BALANCE WHERE SavingsAccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", AccountType);
            SqlDataReader read = dal.executeReader(sql, parameters);
            double d = 0;
            while (read.Read())
            {
                d = double.Parse(read[0].ToString());
            }
            dal.Close();
            return d;
        }

        public double selectMaximumWithdrawal(int AccountType)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MaximumWithdrawal FROM SAVINGS_ACCOUNT_TYPE WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", AccountType);
            SqlDataReader read = dal.executeReader(sql, parameters);
            double d = 0;
            while (read.Read())
            {
                d = double.Parse(read[0].ToString());
            }
            dal.Close();
            return d;
        }

        public DataSet selectAccountHolder(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name' FROM MEMBER_SAVINGS_ACCOUNT msa INNER JOIN MEMBER m ON msa.MemberAccountNo = m.AccountNo WHERE msa.SavingsAccountNo LIKE(@AccountNo)";
            accountNo = "%" + accountNo + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            dal.Close();
            return ds;
        }

        public int selectActivePassbook(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT SavingsPassbookNo FROM MEMBER_SAVINGS_PASSBOOK WHERE SavingsAccountNo = @accountNo AND Status = 1";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            dal.Close();
            return i;
        }

        public int insertSavingsTransaction()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertSavingsTransaction @SavingsAccountNo, @TransactionMode, @Amount, @Representative, @SavingsPassbook, @TellerId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@SavingsAccountNo", this.AccountNo);
            parameters.Add("@TransactionMode", this.TransactionMode);
            parameters.Add("@Amount", this.Amount);
            parameters.Add("@Representative", this.Representative);
            parameters.Add("@SavingsPassbook", this.PassbookNo);
            parameters.Add("@TellerId", Main.UserData.userId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result == 1)
            {
                if (this.TransactionMode == "Withdraw")
                {
                    String sql2 = "UPDATE SAVINGS_ACCOUNT SET Balance = Balance - @Amount WHERE SavingsAccountNo = @SavingsAccountNo";
                    Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
                    parameters2.Add("@SavingsAccountNo", this.AccountNo);
                    parameters2.Add("@Amount", this.Amount);
                    dal.executeNonQuery(sql2, parameters2);
                }
                else if (this.TransactionMode == "Deposit")
                {
                    String sql2 = "UPDATE SAVINGS_ACCOUNT SET Balance = Balance + @Amount WHERE SavingsAccountNo = @SavingsAccountNo";
                    Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
                    parameters2.Add("@SavingsAccountNo", this.AccountNo);
                    parameters2.Add("@Amount", this.Amount);
                    dal.executeNonQuery(sql2, parameters2);
                }
            }
            dal.Close();
            return result;
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
            dal.Close();
            return i + 1;
        }

        public void setPassbookInactive(int activePassbookNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE MEMBER_SAVINGS_PASSBOOK SET Status = 0 WHERE SavingsPassbookNo = @PassbookNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@PassbookNo", activePassbookNo);
            dal.executeNonQuery(sql, parameters);
            dal.Close();
        }

        public int insertSavingsPassbook(int newPassbook, String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertMemberSavingsPassbook @SavingsPassbookNo, @SavingsAccountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@SavingsPassbookNo", newPassbook);
            parameters.Add("@SavingsAccountNo", accountNo);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            dal.Close();
            return result;
        }
    }
}
