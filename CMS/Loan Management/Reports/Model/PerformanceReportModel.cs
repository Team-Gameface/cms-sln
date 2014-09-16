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
    class PerformanceReportModel
    {

        public int year { get; set; }


        public PerformanceReportModel() {


            this.year = 0;
        
        }

        public DataSet getCompanyProfile(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CompanyName,AccreditationNo,CompanyAddress,CompanyLogo,Telephone,Cellphone,Email FROM COMPANY WHERE status = 1 ORDER BY dateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            return ds;
        }

        public DataSet getStaff(String userId, String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT CONCAT(FirstName,' ',MiddleName,' ',LastName) AS 'Name', Position FROM SYSTEM_USERS WHERE NOT (UserType = 'Superuser') AND UserId = @UserId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@UserId", userId);
            DataSet ds = dal.executeDataSet(sql, parameters, src);
            return ds;
        }

        public DataSet getManager(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CONCAT(FirstName,' ',MiddleName,' ',LastName) AS 'Name', Position FROM SYSTEM_USERS WHERE UserType = 'Manager' ORDER BY DateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            return ds;
        }

        public DataSet getCreditChair(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CONCAT(FirstName,' ',MiddleName,' ',LastName) AS 'Name', Position FROM SYSTEM_USERS WHERE UserType = 'Chairman - Credit Committee' ORDER BY DateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            return ds;
        }

        public DataSet getAuditChair(String src)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CONCAT(FirstName,' ',MiddleName,' ',LastName) AS 'Name', Position FROM SYSTEM_USERS WHERE UserType = 'Chairman - Audit Committee' ORDER BY DateCreated desc";
            DataSet ds = dal.executeDataSet(sql, src);
            return ds;
        }



    }
}
