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
    class PenaltiesModel
    {
        public String penaltyName { get; set; }
        public int gracePeriod { get; set; }
        public double Amount { get; set; }
        public String AmountStatus { get; set; }
        public String Deduction { get; set; }
        public int Duration { get; set; }
        public int Status{ get; set; }
        public String DurationStatus { get; set; }
        public CheckedListBox.CheckedItemCollection loanTypes { get; set; }

         public PenaltiesModel()
        {
            this.penaltyName = String.Empty;
            this.gracePeriod = 0;
            this.Deduction = String.Empty;
            this.Duration = 0;
            this.DurationStatus = String.Empty;
            this.Status = 0;
            this.Amount = 0.00;
            this.AmountStatus = String.Empty;
        }


         public DataSet selectLoanTypes()
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT LoanTypeId AS 'Type No', LoanTypeName AS 'Type Name' FROM LOAN_TYPE WHERE isArchived = 0";
             DataSet ds = dal.executeDataSet(sql);
             return ds;
         }

         public DataSet selectActiveLoanTypes(int penaltyId)
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT LOAN_TYPE_PENALTY.LoanTypeId, LoanTypeName FROM LOAN_TYPE inner JOIN LOAN_TYPE_PENALTY on LOAN_TYPE.LoanTypeId = LOAN_TYPE_PENALTY.LoanTypeId WHERE PenaltyId = @penaltyId";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@penaltyId", penaltyId);
             DataSet ds = dal.executeDataSet(sql, parameters);
             return ds;
         
         }

         public SqlDataReader checkExistingLoanTypes(int penaltyId)
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT COUNT(*) FROM LOAN_TYPE inner JOIN LOAN_TYPE_PENALTY on LOAN_TYPE.LoanTypeId = LOAN_TYPE_PENALTY.LoanTypeId WHERE PenaltyId = @penaltyId and LOAN_TYPE.isArchived = 1";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@penaltyId", penaltyId);
             SqlDataReader ds = dal.executeReader(sql, parameters);
             return ds;
         
         }

        //retrieve

         public DataSet selectPenalties() {

             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT PenaltyId AS 'Penalty Id', PenaltyName AS 'Penalty Name', GracePeriod as 'Grace Period', concat(Amount,' ',AmountStatus) as 'Penalty', Deduction, concat(DurationValue,' ',DurationStatus) as 'Duration', Status as 'Active', isArchived FROM PENALTY WHERE isArchived = 0";
             DataSet ds = dal.executeDataSet(sql);
             return ds;
         }

         public DataSet selectAllPenalties()
         {

             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT PenaltyId AS 'Penalty Id', PenaltyName AS 'Penalty Name', GracePeriod as 'Grace Period', concat(Amount,' ',AmountStatus) as 'Penalty', Deduction, concat(DurationValue,' ',DurationStatus) as 'Duration', Status as 'Active', isArchived FROM PENALTY";
             DataSet ds = dal.executeDataSet(sql);
             return ds;
         }

        //retrieve

         public DataSet searchPenalties(String penaltyName)
         {

             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT PenaltyId AS 'Penalty Id', PenaltyName AS 'Penalty Name', GracePeriod as 'Grace Period', concat(Amount,' ',AmountStatus) as 'Penalty', Deduction, concat(DurationValue,' ',DurationStatus) as 'Duration', Status, isArchived FROM PENALTY WHERE isArchived = 0 AND PenaltyName LIKE(@penaltyName)";
             penaltyName = "%" + penaltyName + "%";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@penaltyName", penaltyName);
             DataSet ds = dal.executeDataSet(sql, parameters);
             return ds;
         }

         public DataSet searchAllPenalties(String penaltyName)
         {

             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT PenaltyId AS 'Penalty Id', PenaltyName AS 'Penalty Name', GracePeriod as 'Grace Period', concat(Amount,' ',AmountStatus) as 'Penalty', Deduction, concat(DurationValue,' ',DurationStatus) as 'Duration', Status, isArchived FROM PENALTY WHERE PenaltyName LIKE(@penaltyName)";
             penaltyName = "%" + penaltyName + "%";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@penaltyName", penaltyName);
             DataSet ds = dal.executeDataSet(sql, parameters);
             return ds;
         }

         public int insertPenalties(String penaltyName, int gp, double amount, String amountStatus, String deduction, String durationStatus, int durationValue, ArrayList loanTypeNo, int Status)
         {
 
             int id = 0;
             int resultInner = 0;
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "EXEC insertPenalty @PenaltyName, @GracePeriod, @Amount, @AmountStatus, @Deduction, @DurationStatus, @DurationValue, @Status, @isArchived";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             
             parameters.Add("@PenaltyName", penaltyName);
             parameters.Add("@GracePeriod", gp); 
             parameters.Add("@Amount", amount);
             parameters.Add("@AmountStatus", amountStatus);
             parameters.Add("@Deduction", deduction);
             parameters.Add("@DurationStatus", durationStatus); 
             parameters.Add("@DurationValue", durationValue);
             parameters.Add("@Status", Status); 
             parameters.Add("@isArchived", 0);
             int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));


             String sqlSelect = "Select PenaltyId from PENALTY where isArchived=0 and PenaltyName= @penaltyName";
            Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
            parameters2.Add("@penaltyName", penaltyName);
            id = Convert.ToInt32(dal.executeScalar(sqlSelect,parameters2));



             if (result != 0) 
             {
 
                 foreach (int i in loanTypeNo)
                 {
                     String sqlInner = "INSERT INTO LOAN_TYPE_PENALTY VALUES (@LoanTypeId, @PenaltyId)";
                     Dictionary<String, Object> parametersInner = new Dictionary<string, object>();
                     parametersInner.Add("@LoanTypeId", i);
                     parametersInner.Add("@PenaltyId", id);
                     resultInner = Convert.ToInt32(dal.executeNonQuery(sqlInner, parametersInner));
                 }

             }
             
             return resultInner;
         }

         public int updatePenalties(int penaltyId, String penaltyName, int gp, double amount, String amountStatus, String deduction, String durationStatus, int durationValue, ArrayList loanTypeNo, int Status)
         {

             int resultInner = 0;
             int resultInner2 = 0;
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "EXEC updatePenalty @PenaltyId, @PenaltyName, @GracePeriod, @Amount, @AmountStatus, @Deduction, @DurationStatus, @DurationValue, @Status";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@PenaltyId", penaltyId);
             parameters.Add("@PenaltyName", penaltyName);
             parameters.Add("@GracePeriod", gp);
             parameters.Add("@Amount", amount);
             parameters.Add("@AmountStatus", amountStatus);
             parameters.Add("@Deduction", deduction);
             parameters.Add("@DurationStatus", durationStatus);
             parameters.Add("@DurationValue", durationValue);
             parameters.Add("@Status", Status);
             
             int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));

             if (result != 0)
             {
                 String sqlInner = "DELETE FROM LOAN_TYPE_PENALTY where PenaltyId = @penaltyId";
                 Dictionary<String, Object> parametersInner = new Dictionary<string, object>();
                 parametersInner.Add("@penaltyId", penaltyId);
                 resultInner = Convert.ToInt32(dal.executeNonQuery(sqlInner, parametersInner));



                 for (int ctr = 0; ctr < loanTypeNo.Count; ctr++)
                 {
   
                     String sqlInner2 = "INSERT INTO LOAN_TYPE_PENALTY (LoanTypeId, PenaltyId) VALUES (@LoanTypeId, @PenaltyId)";
                     Dictionary<String, Object> parametersInner2 = new Dictionary<string, object>();
                     parametersInner2.Add("@LoanTypeId", loanTypeNo[ctr]);
                     parametersInner2.Add("@PenaltyId", penaltyId);
                     resultInner2 = Convert.ToInt32(dal.executeNonQuery(sqlInner2, parametersInner2));
                 }

             }

             return resultInner2;
         }

         public int deletePenalties(int penaltyId)
         {
                 DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                 String sql = "UPDATE PENALTY SET isArchived = 1 WHERE PenaltyId = @penaltyId";
                 Dictionary<String, Object> parameters = new Dictionary<string, object>();
                 parameters.Add("@penaltyId", penaltyId);
                 int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
             return result;
         }

        //retrieve

         public int retrievePenalty(int penaltyId)
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "UPDATE PENALTY SET isArchived = 0 WHERE PenaltyId = @penaltyId";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@penaltyId", penaltyId);
             int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
             return result;
         }
    }
}
