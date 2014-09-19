using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CMS.Loan_Management.Transaction.Model
{
    class ShareCapitalContributionModel
    {

        public String accountNo { get; set; }
        public double amount { get; set; }

        public ShareCapitalContributionModel() {

            accountNo = String.Empty;
            amount = 0.00;
        }

        public DataSet selectMembers() {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select m.AccountNo as 'Account No.', concat(m.FirstName,' ',m.MiddleName,' ',m.LastName) as 'Name', ISNULL(SUM(h.ShareCapital), 0) AS 'Balance' from Member m inner join MEMBER_TYPE t on m.MemberTypeNo = t.MemberTypeNo full join MEMBER_SHARECAPITAL h on m.AccountNo = h.accountNo where m.Status = 1 and t.hasShareCapital = 1 group by m.AccountNo, m.FirstName, m.LastName, m.MiddleName";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        
        }

        public DataSet searchMemberByName(String Name)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select m.AccountNo as 'Account No.', concat(m.FirstName,' ',m.MiddleName,' ',m.LastName) as 'Name', ISNULL(SUM(h.ShareCapital), 0) AS 'Balance' from Member m inner join MEMBER_TYPE t on m.MemberTypeNo = t.MemberTypeNo full join MEMBER_SHARECAPITAL h on m.AccountNo = h.accountNo  where m.Status = 1 and hasShareCapital = 1 and concat(m.FirstName,' ',m.MiddleName,' ',m.LastName) like(@MemberName) group by m.AccountNo, m.FirstName, m.LastName, m.MiddleName";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            Name = "%" + Name + "%";
            parameters.Add("@MemberName", Name);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberByAccount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select m.AccountNo as 'Account No.', concat(m.FirstName,' ',m.MiddleName,' ',m.LastName) as 'Name', SUM(h.ShareCapital) AS 'Balance' from Member m inner join MEMBER_TYPE t on m.MemberTypeNo = t.MemberTypeNo full join MEMBER_SHARECAPITAL h on m.AccountNo = h.accountNo where m.Status = 1 and t.hasShareCapital = 1 and m.AccountNo like(@AccountNo) group by m.AccountNo, m.FirstName, m.LastName, m.MiddleName";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            accountNo = "%" + accountNo + "%";
            parameters.Add("@AccountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertContribution() {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertContribution @accountNo, @amount";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", accountNo);
            parameters.Add("@amount", amount);
            int result = dal.executeNonQuery(sql, parameters);
            return result;
        
        }


    }
}
