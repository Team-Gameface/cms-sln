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

namespace CMS.Loan_Management.Maintenance.Model
{
    class LoanAmnestyActivationModel
    {

        public DataSet selectAllAmnesty()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AMNESTY.AmnestyId, DateFrom as 'From', CONVERT(VARCHAR(15), DateTo, 1) AS 'To', concat(Duration,' ',DurationStatus) as 'Loan Overdue Duration', waivePenalty as 'Waive Penalty?', waiveInterest as 'Waive Interest?', Status, isArchived from AMNESTY where (DateTo = 'infinity' OR Current_TIMESTAMP < DateTo)";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectAmnesty()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AMNESTY.AmnestyId, DateFrom as 'From', CONVERT(VARCHAR(15), DateTo, 1) AS 'To', concat(Duration,' ',DurationStatus) as 'Loan Overdue Duration', waivePenalty as 'Waive Penalty?', waiveInterest as 'Waive Interest?', Status, isArchived from AMNESTY where isArchived = 0 and (DateTo = 'infinity' OR Current_TIMESTAMP < DateTo)";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectLoanTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId AS 'Loan Type Id', LoanTypeName AS 'Loan Type Name' FROM LOAN_TYPE WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectActiveLoanTypes(int amnestyId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LOAN_AMNESTY.LoanTypeId as 'Loan Type Id', LoanTypeName as 'Loan Type Name' FROM LOAN_TYPE inner JOIN LOAN_AMNESTY on LOAN_TYPE.LoanTypeId = LOAN_AMNESTY.LoanTypeId WHERE AmnestyId = @AmnestyId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AmnestyId", amnestyId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;

        }

        public void insertAmnesty(ArrayList loanTypeId, String DateFrom, String DateTo, int Duration, String DurationStatus, Boolean waiveInterest, Boolean waivePenalty, Boolean Status)
        {
            int id = 0;

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);

            String sqlDates = "Update AMNESTY set isArchived = 1 where AmnestyId = (Select max(AmnestyId) from AMNESTY)";
            dal.executeScalar(sqlDates);
            
            String sql = "EXEC insertAmnesty @DateFrom, @DateTo, @Duration, @DurationStatus, @waiveInterest, @waivePenalty, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@DateFrom", DateFrom);
            parameters.Add("@DateTo", DateTo);
            parameters.Add("@Duration", Duration);
            parameters.Add("@DurationStatus", DurationStatus);
            parameters.Add("@waiveInterest", waiveInterest);
            parameters.Add("@waivePenalty", waivePenalty);
            parameters.Add("@Status", Status);

            Convert.ToInt32(dal.executeNonQuery(sql, parameters));



            String sqlSelect = "Select max(AmnestyId) from AMNESTY where isArchived=0";
            id = Convert.ToInt32(dal.executeScalar(sqlSelect));

            foreach (int i in loanTypeId)
            {
                String sqlInner = "INSERT INTO LOAN_AMNESTY VALUES (@LoanTypeId, @AmnestyId)";
                Dictionary<String, Object> parametersFinal = new Dictionary<string, object>();
                parametersFinal.Add("@LoanTypeId", i);
                parametersFinal.Add("@AmnestyId", id);
                dal.executeScalar(sqlInner, parametersFinal);
            }



        }

  }
}
