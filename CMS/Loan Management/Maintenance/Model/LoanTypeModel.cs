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
    class LoanTypeModel
    {
        public String Name { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public String MinStatus { get; set; }
        public String MaxStatus { get; set; }
        public double MaxAmt { get; set; }
        public String MaxAmtStatus { get; set; }
        public String Deduction { get; set; }
        public int Comakers { get; set; }
        public int collateralValue { get; set; }
        public CheckedListBox.CheckedItemCollection memberTypes { get; set; }
        public int Status { get; set; }

        public LoanTypeModel()
        {
            this.Name = String.Empty;
            this.MinValue = 0;
            this.MaxValue = 0;
            this.MinStatus = String.Empty;
            this.MaxStatus = String.Empty;
            this.MaxAmt = 0.00;
            this.MaxAmtStatus = String.Empty; 
            this.Deduction = String.Empty;
            this.Comakers = 0;
            this.collateralValue = 0;
            this.Status = 0;
        }

        public DataSet selectMemberTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberTypeNo AS 'Type No', Description AS 'Type Name' FROM Member_Type WHERE isArchived = 0 and hasLoan=1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectActiveMemberTypes(int LoanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MEMBER_TYPE.MemberTypeNo, Description FROM MEMBER_TYPE inner JOIN LOAN_TYPE_AVAILABILITY on MEMBER_TYPE.MemberTypeNo = LOAN_TYPE_AVAILABILITY.MemberTypeNo WHERE LoanTypeId = @LoanTypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanTypeId", LoanTypeId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;

        }

       /* public DataSet selectFixedCollateral(int LoanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId, Fixed_Collateral FROM FIXED_COLLATERAL WHERE LoanTypeId = @LoanTypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanTypeId", LoanTypeId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;

        }

        public DataSet selectEligibility(int LoanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId, Eligibility FROM ELIGIBILITY WHERE LoanTypeId = @LoanTypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanTypeId", LoanTypeId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;

        }*/

        public DataSet selectloanTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId as 'Loan Type Id', LoanTypeName as 'Loan Type Name', concat(MinimumPaymentDuration,' ',MinPDStatus) as 'Minimum Payment Duration', concat(MaximumPaymentDuration,' ',MaxPDStatus) as 'Maximum Payment Duration', concat(MaxLoanableAmt,' ',MaxLoanableAmtStatus) as 'Maximum Loan', Deduction, CoMaker, isCollateral, Status as 'Active', isArchived FROM LOAN_TYPE WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);            
            return ds;
        }

        public DataSet selectAllLoanTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId as 'Loan Type Id', LoanTypeName as 'Loan Type Name', concat(MinimumPaymentDuration,' ',MinPDStatus) as 'Minimum Payment Duration', concat(MaximumPaymentDuration,' ',MaxPDStatus) as 'Maximum Payment Duration', concat(MaxLoanableAmt,' ',MaxLoanableAmtStatus) as 'Maximum Loan', Deduction, CoMaker, isCollateral, Status as 'Active', isArchived FROM LOAN_TYPE";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public int deleteLoanType(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE LOAN_TYPE SET isArchived = 1 WHERE LoanTypeId = @TypeId; Update LOAN_INTEREST_RATE set isArchived = 1 where LoanTypeId = @TypeId; ";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            int finalresult = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return finalresult;
        }

        public int retrieveLoanType(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE LOAN_TYPE SET isArchived = 0 WHERE LoanTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public DataSet searchloanType(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT * FROM LOAN_TYPE WHERE isArchived = 0 AND LoanTypeName LIKE @searchName";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            searchName = "%" + searchName + "%";
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertLoanType(ArrayList memberTypeNo, int Collateral, int Status)
        {
            int id = 0;

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertLoanType @LoanTypeName, @MinimumPaymentDuration, @MinPDStatus, @MaximumPaymentDuration, @MaxPDStatus, @MaxLoanableAmt, @MaxLoanableAmtStatus, @Deduction, @CoMaker, @isCollateral, @Status, @isArchived";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanTypeName", this.Name);
            parameters.Add("@MinimumPaymentDuration", this.MinValue);
            parameters.Add("@MinPDStatus", this.MinStatus);
            parameters.Add("@MaximumPaymentDuration", this.MaxValue);
            parameters.Add("@MaxPDStatus", this.MaxStatus);
            parameters.Add("@MaxLoanableAmt", this.MaxAmt);
            parameters.Add("@MaxLoanableAmtStatus", this.MaxAmtStatus);
            parameters.Add("@Deduction", this.Deduction);
            parameters.Add("@Comaker", this.Comakers);
            parameters.Add("@isCollateral", Collateral);
            parameters.Add("@Status", Status);
            parameters.Add("@isArchived", 0);
   
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));

           
            String sqlSelect = "Select TOP 1 LoanTypeId from LOAN_TYPE where isArchived=0 and LoanTypeName=@LoanTypeName";
            Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
            parameters2.Add("@LoanTypeName", this.Name);
            id = Convert.ToInt32(dal.executeScalar(sqlSelect,parameters2));


            int resultFinal=0;
               
                   
                    if (result == 1) {
                        foreach (int i in memberTypeNo)
                        {
                            String sqlInner = "INSERT INTO LOAN_TYPE_AVAILABILITY VALUES (@MemberTypeNo, @LoanTypeId)";
                            Dictionary<String, Object> parametersFinal = new Dictionary<string, object>();
                            parametersFinal.Add("@MemberTypeNo", i);
                            parametersFinal.Add("@LoanTypeId", id);
                            resultFinal = Convert.ToInt32(dal.executeNonQuery(sqlInner, parametersFinal));
                        }

                    }
                    else return 0;

            return resultFinal;
        
              }

        public int updateLoanType(int loanTypeId, ArrayList memberTypeNo, int Collateral, int Status) {
            int resultInner = 0;
            int resultInner2 = 0;
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateLoanType @LoanTypeId, @LoanTypeName, @MinimumPaymentDuration, @MinPDStatus, @MaximumPaymentDuration, @MaxPDStatus, @MaxLoanableAmt, @MaxLoanableAmtStatus, @Deduction, @CoMaker, @isCollateral, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanTypeId", loanTypeId);
            parameters.Add("@LoanTypeName", this.Name);
            parameters.Add("@MinimumPaymentDuration", this.MinValue);
            parameters.Add("@MinPDStatus", this.MinStatus);
            parameters.Add("@MaximumPaymentDuration", this.MaxValue);
            parameters.Add("@MaxPDStatus", this.MaxStatus);
            parameters.Add("@MaxLoanableAmt", this.MaxAmt);
            parameters.Add("@MaxLoanableAmtStatus", this.MaxAmtStatus);
            parameters.Add("@Deduction", this.Deduction);
            parameters.Add("@CoMaker", this.Comakers);
            parameters.Add("@isCollateral", Collateral);
            parameters.Add("@Status", Status);

            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));

            if (result != 0)
            {
                String sqlInner = "DELETE FROM LOAN_TYPE_AVAILABILITY where LoanTypeId = @LoanTypeId";
                Dictionary<String, Object> parametersInner = new Dictionary<string, object>();
                parametersInner.Add("@LoanTypeId", loanTypeId);
                resultInner = Convert.ToInt32(dal.executeNonQuery(sqlInner, parametersInner));


                for (int ctr = 0; ctr < memberTypeNo.Count; ctr++)
                {

                    String sqlInner2 = "INSERT INTO LOAN_TYPE_AVAILABILITY (MemberTypeNo, LoanTypeId) VALUES (@MemberTypeNo, @LoanTypeId)";
                    Dictionary<String, Object> parametersInner2 = new Dictionary<string, object>();
                    parametersInner2.Add("@MemberTypeNo", memberTypeNo[ctr]);
                    parametersInner2.Add("@LoanTypeId", loanTypeId);
                    resultInner2 = Convert.ToInt32(dal.executeNonQuery(sqlInner2, parametersInner2));
                }

            }

            return resultInner2; 
        }

        
        
    }

    
}
