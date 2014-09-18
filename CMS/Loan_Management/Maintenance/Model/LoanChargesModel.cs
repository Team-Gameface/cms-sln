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
    class LoanChargesModel
    {
        public String chargeName { get; set; }
        public double Amount { get; set; }
        public String AmountStatus { get; set; }
        public int Status{ get; set; }
        public CheckedListBox.CheckedItemCollection loanTypes { get; set; }

         public LoanChargesModel()
        {
            this.chargeName = String.Empty;
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

         public DataSet selectActiveLoanTypes(int chargeId)
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT LOAN_TYPE_CHARGES.LoanTypeId, LoanTypeName FROM LOAN_TYPE inner JOIN LOAN_TYPE_CHARGES on LOAN_TYPE.LoanTypeId = LOAN_TYPE_CHARGES.LoanTypeId WHERE ChargeId = @ChargeId";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@ChargeId", chargeId);
             DataSet ds = dal.executeDataSet(sql, parameters);
             return ds;
         
         }

         public SqlDataReader checkExistingLoanTypes(int chargeId)
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT COUNT(*) FROM LOAN_TYPE inner JOIN LOAN_TYPE_CHARGES on LOAN_TYPE.LoanTypeId = LOAN_TYPE_CHARGES.LoanTypeId WHERE ChargeId = @ChargeId and LOAN_TYPE.isArchived = 1";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@ChargeId", chargeId);
             SqlDataReader ds = dal.executeReader(sql, parameters);
             return ds;

         }

         public DataSet selectloanCharge() {

             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT ChargeId AS 'Charge Id', ChargeName AS 'Charge Name', concat(Amount,' ',AmountStatus) as 'Charge', Status, isArchived FROM CHARGES WHERE isArchived=0";
             DataSet ds = dal.executeDataSet(sql);
             return ds;
         }

         public DataSet selectAllLoanCharge()
         {

             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT ChargeId AS 'Charge Id', ChargeName AS 'Charge Name', concat(Amount,' ',AmountStatus) as 'Charge', Status, isArchived FROM CHARGES";
             DataSet ds = dal.executeDataSet(sql);
             return ds;
         }

         public DataSet searchloanCharge(String chargeName)
         {

             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT ChargeId AS 'Charge Id', ChargeName AS 'Charge Name', concat(Amount,' ',AmountStatus) as 'Charge', Status, isArchived FROM CHARGES WHERE isArchived = 0 AND ChargeName LIKE(@chargeName)";
             chargeName = "%" + chargeName + "%";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@chargeName", chargeName);
             DataSet ds = dal.executeDataSet(sql, parameters);
             return ds;
         }

         public DataSet searchAllLoanCharge(String chargeName)
         {

             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT ChargeId AS 'Charge Id', ChargeName AS 'Charge Name', concat(Amount,' ',AmountStatus) as 'Charge', Status, isArchived FROM CHARGES WHERE ChargeName LIKE(@chargeName)";
             chargeName = "%" + chargeName + "%";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@chargeName", chargeName);
             DataSet ds = dal.executeDataSet(sql, parameters);
             return ds;
         }

         public int insertloanCharge(String chargeName, double amount, String amountStatus, ArrayList loanTypeNo, int Status)
         {
 
             int id = 0;
             int resultInner = 0;
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "EXEC insertCharges @Status, @ChargeName, @Amount, @AmountStatus, @isArchived";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@Status", Status);
             parameters.Add("@ChargeName", chargeName);
             parameters.Add("@Amount", amount);
             parameters.Add("@AmountStatus", amountStatus);
             parameters.Add("@isArchived", 0);
             int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));


             String sqlSelect = "Select ChargeId from CHARGES where isArchived=0 and ChargeName=@chargeName";
            Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
            parameters2.Add("@chargeName", chargeName);
            id = Convert.ToInt32(dal.executeScalar(sqlSelect,parameters2));


             if (result != 0) 
             {
 
                 foreach (int i in loanTypeNo)
                 {
                     String sqlInner = "INSERT INTO LOAN_TYPE_CHARGES VALUES (@LoanTypeId, @ChargeId)";
                     Dictionary<String, Object> parametersInner = new Dictionary<string, object>();
                     parametersInner.Add("@LoanTypeId", i);
                     parametersInner.Add("@ChargeId", id);
                     resultInner = Convert.ToInt32(dal.executeNonQuery(sqlInner, parametersInner));
                 }

             }
             
             return resultInner;
         }

        public int updateloanCharge(int chargeId, String chargeName, double amount, String amountStatus, ArrayList loanTypeNo, int Status)
         {

             int resultInner = 0;
             int resultInner2 = 0;
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "EXEC updateCharges @ChargeId, @Status, @ChargeName, @Amount, @AmountStatus";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@ChargeId", chargeId);
             parameters.Add("@Status", Status);
             parameters.Add("@ChargeName", chargeName);
             parameters.Add("@Amount", amount);
             parameters.Add("@AmountStatus", amountStatus);
             
             int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));

             if (result != 0)
             {
                 String sqlInner = "DELETE FROM LOAN_TYPE_CHARGES where ChargeId = @ChargeId";
                 Dictionary<String, Object> parametersInner = new Dictionary<string, object>();
                 parametersInner.Add("@ChargeId", chargeId);
                 resultInner = Convert.ToInt32(dal.executeNonQuery(sqlInner, parametersInner));



                 for (int ctr = 0; ctr < loanTypeNo.Count; ctr++)
                 {
   
                     String sqlInner2 = "INSERT INTO LOAN_TYPE_CHARGES (LoanTypeId, ChargeId) VALUES (@LoanTypeId, @ChargeId)";
                     Dictionary<String, Object> parametersInner2 = new Dictionary<string, object>();
                     parametersInner2.Add("@LoanTypeId", loanTypeNo[ctr]);
                     parametersInner2.Add("@ChargeId", chargeId);
                     resultInner2 = Convert.ToInt32(dal.executeNonQuery(sqlInner2, parametersInner2));
                 }

             }

             return resultInner2;
         }

        public int deleteloanCharge(int chargeId)
         {
                 DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                 String sql = "UPDATE CHARGES SET isArchived = 1 WHERE ChargeId = @ChargeId";
                 Dictionary<String, Object> parameters = new Dictionary<string, object>();
                 parameters.Add("@ChargeId", chargeId);
                 int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
             return result;
         }

        public int retrieveLoanCharge(int chargeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE CHARGES SET isArchived = 0 WHERE ChargeId = @ChargeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@ChargeId", chargeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}
