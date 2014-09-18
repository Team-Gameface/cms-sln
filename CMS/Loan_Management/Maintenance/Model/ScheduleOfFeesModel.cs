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
    class ScheduleOfFeesModel
    {

        public String feeDesc { get; set; }
        public Double feeAmount {get; set;}
        public int Status{ get; set; }
        public CheckedListBox.CheckedItemCollection memberTypes { get; set; }

         public ScheduleOfFeesModel()
        {
            this.feeDesc = String.Empty;
            this.feeAmount = 0.00;
            this.Status = 0;
        }

         public DataSet selectMemberTypes()
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT MemberTypeNo AS 'Type No', Description AS 'Type Name' FROM Member_Type WHERE isArchived = 0";
             DataSet ds = dal.executeDataSet(sql);
             return ds;
         }

         public DataSet selectActiveMemberTypes(int FeeId)
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT MEMBER_TYPE_FEE.MemberTypeNo, Description FROM MEMBER_TYPE inner JOIN MEMBER_TYPE_FEE on MEMBER_TYPE.MemberTypeNo = MEMBER_TYPE_Fee.MemberTypeNo WHERE FeeId= @feeId";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@feeId", FeeId);
             DataSet ds = dal.executeDataSet(sql, parameters);
             return ds;

         }

         
        public SqlDataReader checkExistingMemberTypes(int FeeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM MEMBER_TYPE inner JOIN MEMBER_TYPE_FEE on MEMBER_TYPE.MemberTypeNo = MEMBER_TYPE_Fee.MemberTypeNo WHERE FeeId= @feeId and MEMBER_TYPE.isArchived = 1";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@feeId", FeeId);
            SqlDataReader ds = dal.executeReader(sql, parameters);
            return ds;

        }

         public DataSet selectFees()
         {

             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT FeeId AS 'Fee No', Description, Amount, Status, isArchived FROM fee WHERE isArchived = 0";
             DataSet ds = dal.executeDataSet(sql);
             return ds;
         }

         public DataSet selectAllFees()
         {

             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT FeeId AS 'Fee No', Description, Amount, Status, isArchived FROM fee";
             DataSet ds = dal.executeDataSet(sql);
             return ds;
         }

         public SqlDataReader selectFeeNames(String newName, String oldName)
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT COUNT(*) FROM Fee WHERE isArchived = 0 and Description != @oldname AND dbo.RemoveSpecialChars(Description) = dbo.RemoveSpecialChars(@newname)";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@newname", newName);
             parameters.Add("@oldname", oldName);
             SqlDataReader ds = dal.executeReader(sql, parameters);
             return ds;
         }

         public SqlDataReader selectFeeNames(String name)
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString); 
             String sql = "SELECT COUNT(*) FROM Fee WHERE isArchived = 0 AND dbo.RemoveSpecialChars(Description) = dbo.RemoveSpecialChars(@name)";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@name", name);
             SqlDataReader ds = dal.executeReader(sql, parameters);
             return ds;
         }

         public DataSet searchFees(String searchName)
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "SELECT FeeId AS 'Fee No', Description, Amount, Status,isArchived FROM fee WHERE isArchived = 0 AND Description LIKE(@searchName)";
             searchName = "%" + searchName + "%";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@searchName", searchName);
             DataSet ds = dal.executeDataSet(sql, parameters);
             return ds;
         }

         public int insertFee(String feeDesc, Double feeAmount, ArrayList memberTypeNo, int Status)
         {
             int resultInner = 0;
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "EXEC insertFee @feeDesc, @Amount, @Status;";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@feeDesc", feeDesc);
             parameters.Add("@Amount", feeAmount);
             parameters.Add("@Status", Status);
             int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
             Object rs = dal.executeScalar("SELECT @@IDENTITY");     //problem area
             int id = int.Parse(rs.ToString());
             if (id != 0)
             {

                 foreach (int i in memberTypeNo)
                 {
                     String sqlInner = "INSERT INTO MEMBER_TYPE_FEE (MemberTypeNo, FeeId) VALUES (@memberTypeNo, @feeId)";
                     Dictionary<String, Object> parametersInner = new Dictionary<string, object>();
                     parametersInner.Add("@memberTypeNo", i);
                     parametersInner.Add("@feeId", id);
                     resultInner = Convert.ToInt32(dal.executeNonQuery(sqlInner, parametersInner));
                 }

             }

             return resultInner;
         }

         public int updateFee(int feeId, String feeDesc, Double feeAmount, ArrayList memberTypeNo, int Status)
         {
             int resultInner = 0;
             int resultInner2 = 0;
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "EXEC updateFee @feeId, @feeDesc, @feeAmount, @Status";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@feeId", feeId);
             parameters.Add("@feeDesc", feeDesc);
             parameters.Add("@feeAmount", feeAmount);
             parameters.Add("@Status", Status);
             int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));

             if (result != 0)
             {
                 String sqlInner = "DELETE MEMBER_TYPE_FEE WHERE FeeId = @feeId";
                 Dictionary<String, Object> parametersInner = new Dictionary<string, object>();
                 parametersInner.Add("@feeId", feeId);
                 resultInner = Convert.ToInt32(dal.executeNonQuery(sqlInner, parametersInner));

                 for (int ctr = 0; ctr < memberTypeNo.Count; ctr++)
                 {
                     String sqlInner2 = "INSERT INTO MEMBER_TYPE_FEE (MemberTypeNo, FeeId) VALUES (@memberTypeNo, @feeId)";
                     Dictionary<String, Object> parametersInner2 = new Dictionary<string, object>();
                     parametersInner2.Add("@memberTypeNo", memberTypeNo[ctr]);
                     parametersInner2.Add("@feeId", feeId);
                     resultInner2 = Convert.ToInt32(dal.executeNonQuery(sqlInner2, parametersInner2));
                 }

             }

             return resultInner;
         }

         public int deleteFee(int feeId)
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "UPDATE Fee SET isArchived = 1 WHERE FeeId = @feeId";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@feeId", feeId);
             int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
             return result;
         }

         public int retrieveFee(int feeId)
         {
             DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
             String sql = "UPDATE Fee SET isArchived = 0 WHERE FeeId = @feeId";
             Dictionary<String, Object> parameters = new Dictionary<string, object>();
             parameters.Add("@feeId", feeId);
             int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
             return result;
         }
    }
}
