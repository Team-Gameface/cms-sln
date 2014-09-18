using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace CMS.Loan_Management.Maintenance.Model
{
    class LoanInterestRateModel
    {
        public int LoanTypeId { get; set; }
        public double InterestRate { get; set; }
        public String InterestRateStatus { get; set; }
        public String Per { get; set; }
        public String DateFrom { get; set; }
        public int Status { get; set; }

        public LoanInterestRateModel()
        {
            this.LoanTypeId = 0;
            this.InterestRate = 0.00;
            this.InterestRateStatus = String.Empty;
            this.Per = String.Empty;
            this.DateFrom = String.Empty;
            this.Status = 0;
        }

        /*public int deleteInterestRate(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE LOAN_INTEREST_RATE SET isArchived = 1 WHERE LoanTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }*/
        public DataSet selectAllLoanTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId, LoanTypeName FROM LOAN_TYPE WHERE isArchived=0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectLoanTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId, LoanTypeName FROM LOAN_TYPE WHERE LoanTypeId NOT IN(Select LoanTypeId FROM LOAN_INTEREST_RATE where isArchived = 0) AND LOAN_TYPE.isArchived=0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectInterestRates()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LOAN_INTEREST_RATE.LoanTypeId as 'Loan Type Id', LOAN_TYPE.LoanTypeName as 'Loan Type Name', concat(LOAN_INTEREST_RATE.InterestRateValue,' ',LOAN_INTEREST_RATE.InterestRateStatus) as 'Interest Rate', LOAN_INTEREST_RATE.Per as 'Duration', LOAN_INTEREST_RATE.ActivationDate as 'Activation Date', LOAN_INTEREST_RATE.Status as 'Active', LOAN_INTEREST_RATE.isArchived from LOAN_INTEREST_RATE, LOAN_TYPE WHERE LOAN_INTEREST_RATE.LoanTypeId=LOAN_TYPE.LoanTypeId and LOAN_INTEREST_RATE.isArchived = 0 and LOAN_TYPE.isArchived = 0;";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectAllInterestRates()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LOAN_INTEREST_RATE.LoanTypeId as 'Loan Type Id', LOAN_TYPE.LoanTypeName as 'Loan Type Name', concat(LOAN_INTEREST_RATE.InterestRateValue,' ',LOAN_INTEREST_RATE.InterestRateStatus) as 'Interest Rate', LOAN_INTEREST_RATE.Per as 'Duration', LOAN_INTEREST_RATE.ActivationDate as 'Activation Date', LOAN_INTEREST_RATE.Status as 'Active', LOAN_INTEREST_RATE.isArchived from LOAN_INTEREST_RATE, LOAN_TYPE WHERE LOAN_INTEREST_RATE.LoanTypeId=LOAN_TYPE.LoanTypeId";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }


        public void insertInterestRate()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);

            String updateSql = "Update LOAN_INTEREST_RATE set isArchived = 1 where LoanTypeId = " + "'" + this.LoanTypeId + "'";
            dal.executeScalar(updateSql);

            String sql = "EXEC insertLoanInterestRate @LoanTypeId, @InterestRateStatus, @InterestRateValue, @Per, @ActivationDate, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();

            parameters.Add("@LoanTypeId", this.LoanTypeId);
            parameters.Add("@InterestRateStatus", this.InterestRateStatus);
            parameters.Add("@InterestRateValue", this.InterestRate);
            parameters.Add("@Per", this.Per);
            parameters.Add("@ActivationDate", this.DateFrom);        
            parameters.Add("@Status", this.Status);
            dal.executeNonQuery(sql, parameters);

        }

    }
}
