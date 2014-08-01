using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMS.Loan_Management.Transaction.Model
{
    class MembershipApplicationModel
    {
        public String AccountNo { get; set; }
        public byte[] Picture { get; set; }
        public String membershipDate { get; set; }
        public int MemberType { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String AddressNo { get; set; }
        public String AddressStreet { get; set; }
        public String AddressBarangay { get; set; }
        public String AddressCity { get; set; }
        public String AddressProvince { get; set; }
        public String AddressZip { get; set; }
        public String telNo { get; set; }
        public String celNo { get; set; }
        public String emailAdd { get; set; }
        public int ResidencyYears { get; set; }
        public int ResidencyMonths { get; set; }
        public String ResidenceType { get; set; }
        public DateTime BirthDate { get; set; }
        public String BirthPlace { get; set; }
        public String Gender { get; set; }
        public String CivilStatus { get; set; }
        public String Spouse { get; set; }
        public int NoChildren { get; set; }
        public int NoDependency { get; set; }


        public String EducAttainment { get; set; }
        public String Course { get; set; }
        public String EmploymentStatus { get; set; }
        public int EmploymentYears { get; set; }
        public String EmploymentOccupation { get; set; }
        public int SelfEmployedYears { get; set; }
        public double Gross { get; set; }
        public String EmployerName { get; set; }
        public String EmployerNature { get; set; }
        public String EmployerAddress { get; set; }
        public String EmployerContact { get; set; }
        public int OtherCoop { get; set; }
        public String CoopName { get; set; }
        public String CoopAddress { get; set; }

        public String guardianName { get; set; }
        public String guardianRelation { get; set; }
        public int Account { get; set; }
        public int SavingsPassbook { get; set; }
        public int CapitalPassbook { get; set; }
        public int LoanPassbook { get; set; }
        public byte[] acctHolderSign1 { get; set; }
        public byte[] acctHolderSign2 { get; set; }
        public byte[] acctHolderSign3 { get; set; }
        public byte[] guardianSign1 { get; set; }
        public byte[] guardianSign2 { get; set; }
        public byte[] guardianSign3 { get; set; }


        public MembershipApplicationModel()
        {
            this.AccountNo = String.Empty;
            this.MemberType = 0;
            this.membershipDate = String.Empty;
            this.Picture = null;
            this.LastName = String.Empty;
            this.FirstName = String.Empty;
            this.MiddleName = String.Empty;
            this.AddressNo = String.Empty;
            this.AddressStreet = String.Empty;
            this.AddressBarangay = String.Empty;
            this.AddressCity = String.Empty;
            this.AddressProvince = String.Empty;
            this.AddressZip = String.Empty;
            this.telNo = String.Empty;
            this.celNo = String.Empty;
            this.emailAdd = String.Empty;
            this.ResidencyYears = 0;
            this.ResidencyMonths = 0;
            this.ResidenceType = String.Empty;
            this.BirthDate = DateTime.Today;
            this.BirthPlace = String.Empty;
            this.Gender = String.Empty;
            this.CivilStatus = String.Empty;
            this.Spouse = String.Empty;
            this.NoChildren = 0;
            this.NoDependency = 0;
            this.EducAttainment = String.Empty;
            this.Course = String.Empty;
            this.EmploymentStatus = String.Empty;
            this.EmploymentYears = 0;
            this.EmploymentOccupation = String.Empty;
            this.SelfEmployedYears = 0;
            this.Gross = 0;
            this.EmployerName = String.Empty;
            this.EmployerNature = String.Empty;
            this.EmployerAddress = String.Empty;
            this.EmployerContact = String.Empty;
            this.OtherCoop = 0;
            this.CoopName = String.Empty;
            this.CoopAddress = String.Empty;
            this.guardianName = String.Empty;
            this.guardianRelation = String.Empty;
            this.Account = 0;
            this.SavingsPassbook = 0;
            this.CapitalPassbook = 0;
            this.LoanPassbook = 0;
            this.acctHolderSign1 = null;
            this.acctHolderSign2 = null;
            this.acctHolderSign3 = null;
            this.guardianSign1 = null;
            this.guardianSign2 = null;
            this.guardianSign3 = null;

        }

        public SqlDataReader selectMember(String accountNo) {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT * FROM MEMBER INNER JOIN MEMBER_TYPE ON MEMBER.MemberTypeNo = MEMBER_TYPE.MemberTypeNo WHERE AccountNo = @acctNo";
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("@acctNo", accountNo);
            SqlDataReader ds = dal.executeReader(sql, parameters);
            return ds;

        }

        public DataSet selectMemberTypes(int age)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberTypeNo, Description, hasLoan, hasSavings, hasShareCapital FROM Member_Type WHERE ((MinimumAge <= @age AND MaximumAge >= @age) OR (MinimumAge <= @age AND MaximumAge = 0) OR (MinimumAge = 0 AND MaximumAge >= @age)) AND isArchived = 0 AND Status = 1";
            Dictionary<String,Object> parameters = new Dictionary<String,Object>();
            parameters.Add("@age", age);
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public DataSet selectRequirements(int memberType)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MEMBER_TYPE_REQUIREMENT.RequirementNo, Description FROM MEMBERSHIP_REQUIREMENT INNER JOIN MEMBER_TYPE_REQUIREMENT on MEMBERSHIP_REQUIREMENT.RequirementNo = MEMBER_TYPE_REQUIREMENT.RequirementNo WHERE MemberTypeNo = @id AND isArchived = 0 AND Status = 1 AND dateCreated < CURRENT_TIMESTAMP";
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("@id", memberType);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectRequirements(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MEMBER_TYPE_REQUIREMENT.RequirementNo, Description FROM MEMBERSHIP_REQUIREMENT INNER JOIN MEMBER_TYPE_REQUIREMENT on MEMBERSHIP_REQUIREMENT.RequirementNo = MEMBER_TYPE_REQUIREMENT.RequirementNo WHERE MemberTypeNo = (SELECT MemberTypeNo FROM MEMBER WHERE AccountNo = @accountNo) AND isArchived = 0 AND Status = 1 AND dateCreated < (SELECT dateCreated FROM MEMBER WHERE AccountNo = @accountNo)";
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("@accountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }


        public DataSet selectActiveRequirements(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT RequirementNo FROM MEMBER_REQUIREMENT_STATUS WHERE AccountNo = @AccountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectAccountTypes(int age)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId, SavingsTypeName FROM SAVINGS_ACCOUNT_TYPE WHERE isArchived = 0 AND Status = 1 AND ((MinimumAge <= @age AND MaximumAge >= @age) OR MaximumAge = 0)";
            //String sql = "SELECT AccountTypeId, SavingsTypeName FROM SAVINGS_ACCOUNT_TYPE WHERE isArchived = 0 AND Status = 1 AND WHERE ((MinimumAge <= @age AND MaximumAge >= @age) OR MaximumAge = 0) AND AccountTypeId IN(SELECT AccountTypeId FROM MEMBER_TYPE_SAVINGS_TYPE ms INNER JOIN MEMBER_TYPE m ON m.MemberTypeNo = ms.MemberTypeNo WHERE m.memberTypeNo = @memberType)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@age", age);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int generateAccountNo()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 AccountNo FROM MEMBER ORDER BY AccountNo DESC";
            SqlDataReader read = dal.executeReader(sql);
            int i = 0;
            while (read.Read())
            {
                String maxAcctNo = read[0].ToString().Split('-')[1];
                i = Convert.ToInt32(maxAcctNo); 
            }
            return i + 1;
        }


       public int generateLoanPassbook()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 LoanPassbookNo FROM MEMBER_LOAN_PASSBOOK ORDER BY LoanPassbookNo DESC";
            SqlDataReader read = dal.executeReader(sql);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i + 1;
        }

        public int getLoanPassbook(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 LoanPassbookNo FROM MEMBER_LOAN_PASSBOOK WHERE AccountNo = @acctNo ORDER BY LoanPassbookNo DESC";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@acctNo", accountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }


        public int generateCapitalPassbook()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CapitalPassbookNo FROM MEMBER_CAPITAL_PASSBOOK ORDER BY CapitalPassbookNo DESC";
            SqlDataReader read = dal.executeReader(sql);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i + 1;
        }

        public int getCapitalPassbook(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 CapitalPassbookNo FROM MEMBER_CAPITAL_PASSBOOK WHERE AccountNo = @acctNo ORDER BY CapitalPassbookNo DESC";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@acctNo", accountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }


        public int insertMember()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertMember @AccountNo, @MemberTypeNo, @dateMembership, @Picture, @LastName, @FirstName, @MiddleName, @AddressNo, @AddressStreet, @AddressBarangay, @AddressCity, @AddressProvince, @AddressZip, @telNo, @celNo, @email, @ResidenceYear, @ResidenceMonths, @ResidentialType, @BirthDate, @BirthPlace, @Gender, @CivilStatus, @SpouseName, @NoOfChildren, @NoOfDependents, @EducAttainment, @Course, @EmployementStatus, @EmploymentYears, @EmploymentOccupation, @SelfEmployedYears, @SelfEmployedGross, @EmployerName, @EmployerNature, @EmployerAddress, @EmployerContact, @OtherCoop, @CoopName, @CoopAddress, @guardianName, @guardianRelation, @acctHolderSign1, @acctHolderSign2, @acctHolderSign3, @guardianSign1, @guardianSign2, @guardianSign3";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", this.AccountNo);
            parameters.Add("@MemberTypeNo", this.MemberType);
            parameters.Add("@dateMembership", this.membershipDate);
            parameters.Add("@Picture", this.Picture);
            parameters.Add("@LastName", this.LastName);
            parameters.Add("@FirstName", this.FirstName);
            parameters.Add("@MiddleName", this.MiddleName);
            parameters.Add("@AddressNo", this.AddressNo);
            parameters.Add("@AddressStreet", this.AddressStreet);
            parameters.Add("@AddressBarangay", this.AddressBarangay);
            parameters.Add("@AddressCity", this.AddressCity);
            parameters.Add("@AddressProvince", this.AddressProvince);
            parameters.Add("@AddressZip", this.AddressZip);
            parameters.Add("@telNo", this.telNo);
            parameters.Add("@celNo", this.celNo);
            parameters.Add("@email", this.emailAdd);
            parameters.Add("@ResidenceYear", this.ResidencyYears);
            parameters.Add("@ResidenceMonths", this.ResidencyMonths);
            parameters.Add("@ResidentialType", this.ResidenceType);
            parameters.Add("@BirthDate", this.BirthDate);
            parameters.Add("@BirthPlace", this.BirthPlace);
            parameters.Add("@Gender", this.Gender);
            parameters.Add("@CivilStatus", this.CivilStatus);
            parameters.Add("@SpouseName", this.Spouse);
            parameters.Add("@NoOfChildren", this.NoChildren);
            parameters.Add("@NoOfDependents", this.NoDependency);
            parameters.Add("@EducAttainment", this.EducAttainment);
            parameters.Add("@Course", this.Course);
            parameters.Add("@EmployementStatus", this.EmploymentStatus);
            parameters.Add("@EmploymentYears", this.EmploymentYears);
            parameters.Add("@EmploymentOccupation", this.EmploymentOccupation);
            parameters.Add("@SelfEmployedYears", this.SelfEmployedYears);
            parameters.Add("@SelfEmployedGross", this.Gross);
            parameters.Add("@EmployerName", this.EmployerName);
            parameters.Add("@EmployerNature", this.EmployerNature);
            parameters.Add("@EmployerAddress", this.EmployerAddress);
            parameters.Add("@EmployerContact", this.EmployerContact);
            parameters.Add("@OtherCoop", this.OtherCoop);
            parameters.Add("@CoopName", this.CoopName);
            parameters.Add("@CoopAddress", this.CoopAddress);
            parameters.Add("@guardianName", this.guardianName);
            parameters.Add("@guardianRelation", this.guardianRelation);
            if (this.acctHolderSign1 == null)
                parameters.Add("@acctHolderSign1", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@acctHolderSign1", this.acctHolderSign1);
            if (this.acctHolderSign2 == null)
                parameters.Add("@acctHolderSign2", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@acctHolderSign2", this.acctHolderSign2);
            if (this.acctHolderSign3 == null)
                parameters.Add("@acctHolderSign3", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@acctHolderSign3", this.acctHolderSign3);
            if (this.guardianSign1 == null)
                parameters.Add("@guardianSign1", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@guardianSign1", this.guardianSign1);
            if (this.guardianSign2 == null)
                parameters.Add("@guardianSign2", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@guardianSign2", this.guardianSign2);
            if (this.guardianSign3 == null)
                parameters.Add("@guardianSign3", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@guardianSign3", this.guardianSign3);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int updateMember()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateMember @AccountNo ,@MemberTypeNo,@Picture, @dateMembership,@LastName,@FirstName,@MiddleName,@AddressNo,@AddressStreet,@AddressBarangay,@AddressCity,@AddressProvince,@AddressZip,@Telephone,@CellphoneNo,@EmailAddress,@ResidenceYear,@ResidenceMonths,@ResidentialType,@BirthDate,@BirthPlace,@Gender,@CivilStatus,@SpouseName,@NoOfChildren,@NoOfDependents,@EducAttainment,@Course,@EmploymentStatus,@EmploymentYears,@EmploymentOccupation,@SelfEmployedYears,@Gross,@EmployerName,@EmployerNature,@EmployerAddress,@EmployerContact,@OtherCoop,@CoopName,@CoopAddress,@guardianName,@guardianRelation,@AcctHolderSign1,@AcctHolderSign2,@AcctHolderSign3,@GuardianSign1,@GuardianSign2,@GuardianSign3";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", this.AccountNo);
            parameters.Add("@MemberTypeNo", this.MemberType);
            parameters.Add("@Picture", this.Picture);
            parameters.Add("@dateMembership", this.membershipDate);
            parameters.Add("@LastName", this.LastName);
            parameters.Add("@FirstName", this.FirstName);
            parameters.Add("@MiddleName", this.MiddleName);
            parameters.Add("@AddressNo", this.AddressNo);
            parameters.Add("@AddressStreet", this.AddressStreet);
            parameters.Add("@AddressBarangay", this.AddressBarangay);
            parameters.Add("@AddressCity", this.AddressCity);
            parameters.Add("@AddressProvince", this.AddressProvince);
            parameters.Add("@AddressZip", this.AddressZip);
            parameters.Add("@Telephone", this.telNo);
            parameters.Add("@CellphoneNo", this.celNo);
            parameters.Add("@EmailAddress", this.emailAdd);
            parameters.Add("@ResidenceYear", this.ResidencyYears);
            parameters.Add("@ResidenceMonths", this.ResidencyMonths);
            parameters.Add("@ResidentialType", this.ResidenceType);
            parameters.Add("@BirthDate", this.BirthDate);
            parameters.Add("@BirthPlace", this.BirthPlace);
            parameters.Add("@Gender", this.Gender);
            parameters.Add("@CivilStatus", this.CivilStatus);
            parameters.Add("@SpouseName", this.Spouse);
            parameters.Add("@NoOfChildren", this.NoChildren);
            parameters.Add("@NoOfDependents", this.NoDependency);
            parameters.Add("@EducAttainment", this.EducAttainment);
            parameters.Add("@Course", this.Course);
            parameters.Add("@EmploymentStatus", this.EmploymentStatus);
            parameters.Add("@EmploymentYears", this.EmploymentYears);
            parameters.Add("@EmploymentOccupation", this.EmploymentOccupation);
            parameters.Add("@SelfEmployedYears", this.SelfEmployedYears);
            parameters.Add("@Gross", this.Gross);
            parameters.Add("@EmployerName", this.EmployerName);
            parameters.Add("@EmployerNature", this.EmployerNature);
            parameters.Add("@EmployerAddress", this.EmployerAddress);
            parameters.Add("@EmployerContact", this.EmployerContact);
            parameters.Add("@OtherCoop", this.OtherCoop);
            parameters.Add("@CoopName", this.CoopName);
            parameters.Add("@CoopAddress", this.CoopAddress);
            parameters.Add("@guardianName", this.guardianName);
            parameters.Add("@guardianRelation", this.guardianRelation);
            if (this.acctHolderSign1 == null)
                parameters.Add("@AcctHolderSign1", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@AcctHolderSign1", this.acctHolderSign1);
            if (this.acctHolderSign2 == null)
                parameters.Add("@AcctHolderSign2", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@AcctHolderSign2", this.acctHolderSign2);
            if (this.acctHolderSign3 == null)
                parameters.Add("@AcctHolderSign3", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@AcctHolderSign3", this.acctHolderSign3);
            if (this.guardianSign1 == null)
                parameters.Add("@GuardianSign1", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@GuardianSign1", this.guardianSign1);
            if (this.guardianSign2 == null)
                parameters.Add("@GuardianSign2", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@GuardianSign2", this.guardianSign2);
            if (this.guardianSign3 == null)
                parameters.Add("@GuardianSign3", System.Text.Encoding.UTF8.GetBytes(DBNull.Value.ToString()));
            else parameters.Add("@GuardianSign3", this.guardianSign3);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int activateStatus(String accountNo)
        {
            int result = 0;
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberStatusNo FROM MEMBER_STATUS WHERE isArchived = 0 AND status=1 AND DelinquencyValue=0";
            try
            {
                int StatusNo = int.Parse(dal.executeScalar(sql).ToString());
                String sqle = "Update Member SET MemberStatusNo = @statusNo WHERE AccountNo=@AccountNo";
                Dictionary<String, Object> parameters = new Dictionary<string, object>();
                parameters.Add("@statusNo", StatusNo);
                parameters.Add("@AccountNo", this.AccountNo);
                result = Convert.ToInt32(dal.executeNonQuery(sqle, parameters));
            }
            catch (Exception) { }
            return result;
        }


        public int insertLoanPassbook()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertMemberLoanPassbook @LoanPassbook, @AccountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanPassbook", this.LoanPassbook);
            parameters.Add("@AccountNo", this.AccountNo);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int insertCapitalPassbook()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertMemberCapitalPassbook @CapitalPassbook, @AccountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@CapitalPassbook", this.CapitalPassbook);
            parameters.Add("@AccountNo", this.AccountNo);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}
