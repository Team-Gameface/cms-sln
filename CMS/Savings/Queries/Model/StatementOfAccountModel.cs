using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Savings.Queries.Model
{
    class StatementOfAccountModel
    {
        public DataSet selectMember()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT sa.SavingsAccountNo AS 'Account No',sat.AccountTypeId, sat.SavingsTypeName AS 'Savings Type', sa.WithdrawalMode, STUFF((SELECT ';' + CONCAT(m.LastName,', ', m.FirstName, ' ', m.MiddleName) AS [text()] FROM MEMBER m, MEMBER_SAVINGS_ACCOUNT msa WHERE m.AccountNo = msa.MemberAccountNo AND sa.SavingsAccountNo = msa.SavingsAccountNo FOR XML PATH('')),1,1,'') AS 'Depositors', Balance FROM SAVINGS_ACCOUNT sa INNER JOIN SAVINGS_ACCOUNT_TYPE sat ON sa.AccountTypeId  = sat.AccountTypeId WHERE sa.Status = 1";
            DataSet ds = dal.executeDataSet(sql);
            dal.Close();
            return ds;
        }

        public DataSet searchMemberName(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT sa.SavingsAccountNo AS 'Account No',sat.AccountTypeId, sat.SavingsTypeName AS 'Savings Type', sa.WithdrawalMode, STUFF((SELECT ';' + CONCAT(m.LastName,', ', m.FirstName, ' ', m.MiddleName) AS [text()] FROM MEMBER m, MEMBER_SAVINGS_ACCOUNT msa WHERE m.AccountNo = msa.MemberAccountNo AND sa.SavingsAccountNo = msa.SavingsAccountNo FOR XML PATH('')),1,1,'') AS 'Depositors', Balance FROM SAVINGS_ACCOUNT sa INNER JOIN SAVINGS_ACCOUNT_TYPE sat ON sa.AccountTypeId  = sat.AccountTypeId WHERE sa.Status = 1 AND STUFF((SELECT ';' + CONCAT(m.LastName,', ', m.FirstName, ' ', m.MiddleName) AS [text()] FROM MEMBER m, MEMBER_SAVINGS_ACCOUNT msa WHERE m.AccountNo = msa.MemberAccountNo AND sa.SavingsAccountNo = msa.SavingsAccountNo FOR XML PATH('')),1,1,'') LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            dal.Close();
            return ds;
        }

        public DataSet searchAccount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT sa.SavingsAccountNo AS 'Account No',sat.AccountTypeId, sat.SavingsTypeName AS 'Savings Type', sa.WithdrawalMode, STUFF((SELECT ';' + CONCAT(m.LastName,', ', m.FirstName, ' ', m.MiddleName) AS [text()] FROM MEMBER m, MEMBER_SAVINGS_ACCOUNT msa WHERE m.AccountNo = msa.MemberAccountNo AND sa.SavingsAccountNo = msa.SavingsAccountNo FOR XML PATH('')),1,1,'') AS 'Depositors', Balance FROM SAVINGS_ACCOUNT sa INNER JOIN SAVINGS_ACCOUNT_TYPE sat ON sa.AccountTypeId  = sat.AccountTypeId WHERE sa.Status = 1 AND sa.SavingsAccountNo LIKE(@accountNo)";
            accountNo = "%" + accountNo + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            dal.Close();
            return ds;
        }

        public DataSet selectTransactions(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC dbo.selectTransactions @accountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            dal.Close();
            return ds;
        }

    }
}
