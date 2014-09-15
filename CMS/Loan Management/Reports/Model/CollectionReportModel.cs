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
    class CollectionReportModel
    {

        public String dateFrom { get; set; }
        public String dateTo { get; set; }
        public String transType { get; set; }
        public CheckedListBox.CheckedItemCollection checkedLoanTypes { get; set; }
        public CheckedListBox.CheckedItemCollection checkedMiscFees { get; set; }
        public String sortBy { get; set; }
        public String order { get; set; }

        public CollectionReportModel() {


            this.dateFrom = String.Empty;
            this.dateTo = String.Empty;
            this.transType = String.Empty;
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

        public DataSet selectFees()
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT FeeId AS 'Fee No', Description FROM fee WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectLoanCollections(String dateFrom, String dateTo, String sortBy, String order, String srcDataSet) {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT p.ORNo AS 'ORNo', p.PaymentDate AS 'Date', p.AccountNo AS 'AccountNo', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', lt.LoanTypeName AS 'Type', p.Amount AS 'Amount' FROM PAYMENT p INNER JOIN MEMBER m ON p.AccountNo = m.AccountNo INNER JOIN LOAN_INFORMATION li ON li.LoanApplicationId = p.LoanApplicationId INNER JOIN LOAN_TYPE lt ON lt.LoanTypeId = li.LoanTypeId WHERE PaymentType = 'Loan' AND CONVERT(Date,p.PaymentDate) >= @dateFrom AND CONVERT(Date,p.PaymentDate) <= @dateTo ORDER BY " + sortBy + " " + order;
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@dateFrom", dateFrom);
            parameters.Add("@dateTo", dateTo);
            DataSet ds = dal.executeDataSet(sql, parameters, srcDataSet);
            return ds;
        
        }

        public DataSet selectLoanCollections(String dateFrom, String sortBy, String order, String srcDataSet)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT p.ORNo AS 'ORNo', p.PaymentDate AS 'Date', p.AccountNo AS 'AccountNo', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', lt.LoanTypeName AS 'Type', p.Amount AS 'Amount' FROM PAYMENT p INNER JOIN MEMBER m ON p.AccountNo = m.AccountNo INNER JOIN LOAN_INFORMATION li ON li.LoanApplicationId = p.LoanApplicationId INNER JOIN LOAN_TYPE lt ON lt.LoanTypeId = li.LoanTypeId WHERE PaymentType = 'Loan' AND CONVERT(Date,p.PaymentDate) = @dateFrom ORDER BY " + sortBy + " " + order;
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@dateFrom", dateFrom);
            DataSet ds = dal.executeDataSet(sql, parameters, srcDataSet);
            return ds;

        }

        public DataSet selectFeeCollections(String dateFrom, String dateTo, String sortBy, String order, String srcDataSet)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT p.ORNo AS 'ORNo', p.PaymentDate AS 'Date', p.AccountNo AS 'AccountNo', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', f.Description AS 'Item', f.Amount AS 'Amount' FROM PAYMENT p INNER JOIN MEMBER m ON p.AccountNo = m.AccountNo INNER JOIN PAYMENT_FEE pf ON pf.ORNo = p.ORNo INNER JOIN FEE f ON f.FeeId = pf.FeeId WHERE PaymentType = 'Miscellaneous' AND CONVERT(Date,p.PaymentDate) >= @dateFrom AND CONVERT(Date,p.PaymentDate) <= @dateTo ORDER BY " + sortBy + " " + order;
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@dateFrom", dateFrom);
            parameters.Add("@dateTo", dateTo);
            DataSet ds = dal.executeDataSet(sql, parameters, srcDataSet);
            return ds;

        }

        public DataSet selectFeeCollections(String dateFrom, String sortBy, String order, String srcDataSet)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT p.ORNo AS 'ORNo', p.PaymentDate AS 'Date', p.AccountNo AS 'AccountNo', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', f.Description AS 'Item', f.Amount AS 'Amount' FROM PAYMENT p INNER JOIN MEMBER m ON p.AccountNo = m.AccountNo INNER JOIN PAYMENT_FEE pf ON pf.ORNo = p.ORNo INNER JOIN FEE f ON f.FeeId = pf.FeeId WHERE PaymentType = 'Miscellaneous' AND CONVERT(Date,p.PaymentDate) = @dateFrom ORDER BY " + sortBy + " " + order;
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@dateFrom", dateFrom);
            DataSet ds = dal.executeDataSet(sql, parameters, srcDataSet);
            return ds;

        }

        public DataSet selectShareCollections(String dateFrom, String dateTo, String sortBy, String order, String srcDataSet)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT c.TransactionId as 'ID', c.DateOfTransaction AS 'Date', c.AccountNo AS 'AccountNo', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', c.ShareCapital AS 'Amount' FROM MEMBER_SHARECAPITAL c INNER JOIN MEMBER m ON c.accountNo = m.AccountNo WHERE CONVERT(Date,c.DateOfTransaction) >= @dateFrom AND CONVERT(Date,c.DateOfTransaction) <= @dateTo ORDER BY " + sortBy + " " + order;
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@dateFrom", dateFrom);
            parameters.Add("@dateTo", dateTo);
            DataSet ds = dal.executeDataSet(sql, parameters, srcDataSet);
            return ds;

        }

        public DataSet selectShareCollections(String dateFrom, String sortBy, String order, String srcDataSet)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT c.TransactionId as 'ID', c.DateOfTransaction AS 'Date', c.AccountNo AS 'AccountNo', CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName) AS 'Name', c.ShareCapital AS 'Amount' FROM MEMBER_SHARECAPITAL c INNER JOIN MEMBER m ON c.accountNo = m.AccountNo WHERE CONVERT(Date,c.DateOfTransaction) = @dateFrom ORDER BY " + sortBy + " " + order;
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@dateFrom", dateFrom);
            DataSet ds = dal.executeDataSet(sql, parameters, srcDataSet);
            return ds;

        }

        public DataSet getCompanyProfile(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CompanyName,AccreditationNo,CompanyAddress,CompanyLogo,Telephone,Cellphone,Email FROM COMPANY WHERE status = 1 ORDER BY dateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            return ds;
        }

    }
}
