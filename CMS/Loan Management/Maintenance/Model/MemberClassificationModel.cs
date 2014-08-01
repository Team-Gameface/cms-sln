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
    class MemberClassificationModel
    {

        public String classificationName { get; set; }
        public int delinquencyValue { get; set; }
        public String delinquencyUnit { get; set; }
        public String delinquencyBasis { get; set; }
        public int Status { get; set; }
        public CheckedListBox.CheckedItemCollection memberTypes { get; set; }

        public MemberClassificationModel()
        {
            this.classificationName = String.Empty;
            this.delinquencyValue = 0;
            this.delinquencyUnit = String.Empty;
            this.delinquencyBasis = String.Empty;
            this.Status = 0;
        }

        public DataSet selectMemberTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberTypeNo AS 'Type No', Description AS 'Type Name',isArchived FROM Member_Type WHERE isArchived = 0 and hasLoan = 1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectActiveMemberTypes(int statusNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MEMBER_TYPE_STATUS.MemberTypeNo, Description FROM MEMBER_TYPE inner JOIN MEMBER_TYPE_STATUS on MEMBER_TYPE.MemberTypeNo = MEMBER_TYPE_STATUS.MemberTypeNo WHERE MemberStatusNo = @statusNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@statusNo", statusNo);
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;

        }

        public DataSet selectClasses()
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberStatusNo AS 'No', Description AS 'Classification', DelinquencyValue AS 'Delinquency', DelinquencyUnit AS 'Unit', DelinquencyBasis AS 'Basis', Status, isArchived FROM MEMBER_STATUS WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectAllClasses()
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberStatusNo AS 'No', Description AS 'Classification', DelinquencyValue AS 'Delinquency', DelinquencyUnit AS 'Unit', DelinquencyBasis AS 'Basis', Status, isArchived FROM MEMBER_STATUS";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public SqlDataReader selectClassNames(String s)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT dbo.RemoveSpecialChars(Description), dbo.RemoveSpecialChars(@name), DelinquencyValue AS 'Delinquency', DelinquencyUnit AS 'Unit', DelinquencyBasis AS 'Basis' FROM Member_Status WHERE isArchived = 0";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", s);
            SqlDataReader ds = dal.executeReader(sql, parameters);
            return ds;
        }

        public SqlDataReader selectClassNames(String newName, String oldName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT dbo.RemoveSpecialChars(Description), dbo.RemoveSpecialChars(@newname), DelinquencyValue AS 'Delinquency', DelinquencyUnit AS 'Unit', DelinquencyBasis AS 'Basis' FROM Member_Status WHERE isArchived = 0 and Description != @oldName";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@newname", newName);
            parameters.Add("@oldName", oldName);
            SqlDataReader ds = dal.executeReader(sql,parameters);
            return ds;
        }

        public DataSet searchClasses(String searchName)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberStatusNo AS 'No', Description AS 'Classification', DelinquencyValue AS 'Delinquency', DelinquencyUnit AS 'Unit', DelinquencyBasis AS 'Basis', Status, isArchived FROM MEMBER_STATUS WHERE isArchived = 0 AND Description LIKE(@searchName)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            searchName = "%" + searchName + "%";
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertClass(String className, int delinquencyValue, String delinquencyUnit, String delinquencyBasis, ArrayList memberTypeNo, int Status)
        {
            int resultInner = 0;
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertClassification @className, @delValue, @delUnit, @delBasis, @Status;";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@className", className);
            parameters.Add("@delValue", delinquencyValue);
            parameters.Add("@delUnit", delinquencyUnit);
            parameters.Add("@delBasis", delinquencyBasis);
            parameters.Add("@Status", Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            Object rs = dal.executeScalar("SELECT @@IDENTITY");
            int id = int.Parse(rs.ToString());
            if (id != 0)
            {

                foreach (int i in memberTypeNo)
                {
                    String sqlInner = "INSERT INTO MEMBER_TYPE_STATUS (MemberTypeNo, MemberStatusNo) VALUES (@memberTypeNo, @statusNo)";
                    Dictionary<String, Object> parametersInner = new Dictionary<string, object>();
                    parametersInner.Add("@memberTypeNo", i);
                    parametersInner.Add("@statusNo", id);
                    resultInner = Convert.ToInt32(dal.executeNonQuery(sqlInner, parametersInner));
                }

            }

            return resultInner;
        }

        public int updateClass(int statusNo, String className, int delinquencyValue, String delinquencyUnit, String delinquencyBasis, ArrayList memberTypeNo, int Status) // pag nagupdate, fetch laman arraylist then dataset ng member currently active then compare, pag wala sa ds pero asa al, add sa db, pag asa al pero ala sa ds, delete sa db
        {
            int resultInner = 0;
            int resultInner2 = 0;
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateClass @statusNo, @className, @delValue, @delUnit, @delBasis, @status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@statusNo", statusNo);
            parameters.Add("@className", className);
            parameters.Add("@delValue", delinquencyValue);
            parameters.Add("@delUnit", delinquencyUnit);
            parameters.Add("@delBasis", delinquencyBasis);
            parameters.Add("@Status", Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));

                if (result != 0)
                {

                    String sqlInner = "DELETE FROM MEMBER_TYPE_STATUS where MemberStatusNo = @statusNo";
                    Dictionary<String, Object> parametersInner = new Dictionary<string, object>();
                    parametersInner.Add("@statusNo", statusNo);
                    resultInner = Convert.ToInt32(dal.executeNonQuery(sqlInner, parametersInner));


                    for (int ctr = 0; ctr < memberTypeNo.Count; ctr++)
                    {

                        String sqlInner2 = "INSERT INTO MEMBER_TYPE_STATUS (MemberTypeNo, MemberStatusNo) VALUES (@memberTypeNo, @statusNo)";
                        Dictionary<String, Object> parametersInner2 = new Dictionary<string, object>();
                        parametersInner2.Add("@memberTypeNo", memberTypeNo[ctr]);
                        parametersInner2.Add("@statusNo", statusNo);
                        resultInner2 = Convert.ToInt32(dal.executeNonQuery(sqlInner2, parametersInner2));
                    }

                }

                return resultInner2;

        }

        
        public int deleteClass(int statusNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE Member_Status SET isArchived = 1 WHERE MemberStatusNo = @statusNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@statusNo", statusNo);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int retrieveClass(int statusNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE Member_Status SET isArchived = 0 WHERE MemberStatusNo = @statusNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@statusNo", statusNo);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}
