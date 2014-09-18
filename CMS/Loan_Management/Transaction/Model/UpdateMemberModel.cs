using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Loan_Management.Transaction.Model
{
    class UpdateMemberModel
    {
        public UpdateMemberModel()
        {

        }

        public DataSet selectMember()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', Description AS 'Member Type' FROM MEMBER m INNER JOIN MEMBER_TYPE mt ON m.MemberTypeNo = mt.MemberTypeNo WHERE m.Status=1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchAccountNo(String AccountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', Description AS 'Member Type' FROM MEMBER m INNER JOIN MEMBER_TYPE mt ON m.MemberTypeNo = mt.MemberTypeNo WHERE m.Status=1 and AccountNo LIKE(@searchName)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            AccountNo = "%" + AccountNo + "%";
            parameters.Add("@searchName", AccountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberName(String MemberName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', Description AS 'Member Type' FROM MEMBER m INNER JOIN MEMBER_TYPE mt ON m.MemberTypeNo = mt.MemberTypeNo WHERE m.Status=1 and LastName LIKE(@searchName) OR FirstName LIKE(@searchName) OR MiddleName LIKE(@searchName)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            MemberName = "%" + MemberName + "%";
            parameters.Add("@searchName", MemberName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }
    }
}
