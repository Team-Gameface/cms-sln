using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CMS.Savings.Reports.Model
{
    class DailyTransactionLogModel
    {

        public String dateFrom { get; set; }
        public String dateTo { get; set; }
        public CheckedListBox.CheckedItemCollection checkedSavingsTypes { get; set; }
        public String sortBy { get; set; }
        public String order { get; set; }

        public DailyTransactionLogModel() {

            this.dateFrom = String.Empty;
            this.dateTo = String.Empty;
            this.sortBy = String.Empty;
            this.order = String.Empty;

        }


        public DataSet selectSavingsTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId AS 'TypeId', SavingsTypeName AS 'SavingsType' FROM SAVINGS_ACCOUNT_TYPE WHERE isArchived = 0 AND Status = 1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public SqlDataReader getCompanyProfile()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CompanyId,CompanyName,AccreditationNo,CompanyAddress,CompanyLogo,Telephone,Cellphone,Email FROM COMPANY WHERE status = 1 ORDER BY dateCreated desc";
            SqlDataReader dr = dal.executeReader(sql);
            return dr;
        }


        public DataSet listDailyTransactions(String dateFrom, String dateTo, ArrayList savingsTypes, String sortBy, String order, String srcDataSet) {

            String inSavingsTypes = String.Empty;

            foreach (int i in savingsTypes) {

                inSavingsTypes += "," + i.ToString();
            
            }
            inSavingsTypes = inSavingsTypes.Substring(1);
            MessageBox.Show(inSavingsTypes);

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT st.DateCreated AS 'TransactionDate', st.SavingsAccountNo AS 'AccountNo', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', st.TransactionMode AS 'TransMode', st.Amount FROM SAVINGS_TRANSACTION st INNER JOIN SAVINGS_ACCOUNT sa ON st.SavingsAccountNo = sa.SavingsAccountNo INNER JOIN MEMBER_SAVINGS_ACCOUNT msa ON sa.SAvingsAccountNo = msa.SavingsAccountNo INNER JOIN MEMBER m ON msa.MemberAccountNo = m.AccountNo where CONVERT(Date,st.DateCreated) >= @dateFrom AND CONVERT(Date,st.DateCreated) <= @dateTo AND sa.AccountTypeId IN ("+inSavingsTypes+") ORDER BY " + sortBy + " " + order;
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@dateFrom", dateFrom);
            parameters.Add("@dateTo", dateTo);
            DataSet ds = dal.executeDataSet(sql,parameters,srcDataSet);
            return ds;

        }

        public DataSet listDailyTransactions(String dateFrom, ArrayList savingsTypes, String sortBy, String order, String srcDataSet)
        {

            String inSavingsTypes = String.Empty;

            foreach (int i in savingsTypes)
            {
                inSavingsTypes += "," + i.ToString();

            }
            inSavingsTypes = inSavingsTypes.Substring(1);
            MessageBox.Show(inSavingsTypes);

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT st.DateCreated AS 'TransactionDate', st.SavingsAccountNo AS 'AccountNo', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', st.TransactionMode AS 'TransMode', st.Amount FROM SAVINGS_TRANSACTION st INNER JOIN SAVINGS_ACCOUNT sa ON st.SavingsAccountNo = sa.SavingsAccountNo INNER JOIN MEMBER_SAVINGS_ACCOUNT msa ON sa.SAvingsAccountNo = msa.SavingsAccountNo INNER JOIN MEMBER m ON msa.MemberAccountNo = m.AccountNo where CONVERT(Date,st.DateCreated) = @dateFrom AND sa.AccountTypeId IN ("+inSavingsTypes+") ORDER BY " + sortBy + " " + order;
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@dateFrom", dateFrom);
            DataSet ds = dal.executeDataSet(sql, parameters, srcDataSet);
            return ds;

        }
    }
}
