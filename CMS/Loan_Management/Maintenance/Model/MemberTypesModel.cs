using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CMS.Loan_Management.Maintenance.Model
{
    class MemberTypesModel
    {
        public String TypeName { get; set; }
        public String Availability { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int Status { get; set; }

        public MemberTypesModel()
        {
            this.TypeName = String.Empty;
            this.Availability = String.Empty;
            this.MinAge = 0;
            this.MaxAge = 0;
            this.Status = 0;
        }

        public DataSet selectMemberTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberTypeNo AS 'Type No', Description AS 'Type Name', hasLoan AS 'Loan', hasSavings AS 'Savings', hasShareCapital AS 'Share Capital', MinimumAge AS 'Minimum Age', MaximumAge AS 'Maximum Age', Status, isArchived FROM Member_Type WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectMemberTypesAll()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberTypeNo AS 'Type No', Description AS 'Type Name', hasLoan AS 'Loan', hasSavings AS 'Savings', hasShareCapital AS 'Share Capital', MinimumAge AS 'Minimum Age', MaximumAge AS 'Maximum Age', Status, isArchived FROM Member_Type";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        } 

        public SqlDataReader selectMemberTypeNames(String s)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM Member_Type WHERE isArchived = 0 and dbo.RemoveSpecialChars(Description) = dbo.RemoveSpecialChars(@name)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", s);
            SqlDataReader ds = dal.executeReader(sql,parameters);
            return ds;
        }

        public SqlDataReader selectMemberTypeNames(String newName, String oldName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM Member_Type WHERE isArchived = 0 AND NOT(Description = @old) AND dbo.RemoveSpecialChars(Description) = dbo.RemoveSpecialChars(@new)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@old", oldName);
            parameters.Add("@new", newName);
            SqlDataReader ds = dal.executeReader(sql,parameters);
            return ds;
        }

        public int insertMemberType(String TypeName, int ServiceLoan, int ServiceSavings, int ServiceShareCapital, int MinAge, int MaxAge, int Status)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertMemberType @TypeName, @hasLoan, @hasSavings, @hasShareCapital, @MinAge, @MaxAge, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeName", TypeName);
            parameters.Add("@hasLoan", ServiceLoan);
            parameters.Add("@hasSavings", ServiceSavings);
            parameters.Add("@hasShareCapital", ServiceShareCapital);
            parameters.Add("@MinAge", MinAge);
            parameters.Add("@MaxAge", MaxAge);
            parameters.Add("@Status", Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int updateMemberType(int TypeNo, String TypeName, int ServiceLoan, int ServiceSavings, int ServiceShareCapital, int MinAge, int MaxAge, int Status)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateMemberType @TypeNo, @TypeName, @hasLoan, @hasSavings, @hasShareCapital, @MinAge, @MaxAge, @Status; ";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeNo", TypeNo);
            parameters.Add("@TypeName", TypeName);
            parameters.Add("@hasLoan", ServiceLoan);
            parameters.Add("@hasSavings", ServiceSavings);
            parameters.Add("@hasShareCapital", ServiceShareCapital);
            parameters.Add("@MinAge", MinAge);
            parameters.Add("@MaxAge", MaxAge);
            parameters.Add("@Status", Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
        public int deleteMemberTypes(int TypeNo)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE Member_Type SET isArchived = 1 WHERE MemberTypeNo = @TypeNo;";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeNo", TypeNo);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int retrieveMemberType(int TypeNo)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE Member_Type SET isArchived = 0 WHERE MemberTypeNo = @TypeNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeNo", TypeNo);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}
