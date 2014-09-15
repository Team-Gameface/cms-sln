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

namespace CMS.Loan_Management.Reports.Model
{
    class LoanReleasesModel
    {
        public String dateFrom { get; set; }
        public String dateTo { get; set; }
        public CheckedListBox.CheckedItemCollection checkedLoanTypes { get; set; }
        public String sortBy { get; set; }
        public String order { get; set; }

        public LoanReleasesModel()
        {


            this.dateFrom = String.Empty;
            this.dateTo = String.Empty;
            this.sortBy = String.Empty;
            this.order = String.Empty;
        
        }

        public DataSet selectLoanTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId AS 'Type No', LoanTypeName AS 'Type Name' FROM LOAN_TYPE WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet getCompanyProfile(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CompanyName,AccreditationNo,CompanyAddress,CompanyLogo,Telephone,Cellphone,Email FROM COMPANY WHERE status = 1 ORDER BY dateCreated desc";
            DataSet ds = dal.executeDataSet(sql,src);
            return ds;
        }

        public DataSet listDailyTransactions(String dateFrom, String dateTo, ArrayList loanTypes, String sortBy, String order, String srcDataSet)
        {

            String inLoanTypes = String.Empty;

            foreach (int i in loanTypes)
            {

                inLoanTypes += "," + i.ToString();

            }
            inLoanTypes = inLoanTypes.Substring(1);
            MessageBox.Show(inLoanTypes);

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT li.DateApproved AS 'DateApproved', li.AccountNo AS 'AccountNo', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', lt.LoanTypeName AS 'LoanType', li.ApprovedAmount AS 'Amount', li.MaturityDate AS 'MaturityDate' FROM LOAN_INFORMATION li INNER JOIN MEMBER m ON li.AccountNo = m.AccountNo INNER JOIN LOAN_TYPE lt ON lt.LoanTypeId = li.LoanTypeId where CONVERT(Date,li.DateApproved) >= @dateFrom AND CONVERT(Date,li.DateApproved) <= @dateTo AND li.LoanTypeId IN (" + inLoanTypes + ") ORDER BY " + sortBy + " " + order;
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@dateFrom", dateFrom);
            parameters.Add("@dateTo", dateTo);
            DataSet ds = dal.executeDataSet(sql, parameters, srcDataSet);
            return ds;

        }
    }
}
