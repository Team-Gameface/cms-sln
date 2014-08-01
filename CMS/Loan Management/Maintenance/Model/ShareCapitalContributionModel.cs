using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CMS.Loan_Management.Maintenance.Model
{
    class ShareCapitalContributionModel
    {
        public int comboAccountType { get; set; }
        public double txtContribution { get; set; }
        public string comboContribution { get; set; }
        public int Status { get; set; }

        public ShareCapitalContributionModel()
        {
            this.comboAccountType = 0;
            this.txtContribution = 0;
            this.comboContribution = String.Empty;
            this.Status = 0;
        }
        public DataSet SelectCapitalContribution()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MinCapitalContributionId AS 'Minimum Capital Contribution ID', l.MemberTypeNo AS 'Member Type Id', Description AS 'Member Type', MinimumContribution AS 'Share Capital', Duration, l.Status, l.isArchived FROM MINIMUM_CAPITAL_CONTRIBUTION l INNER JOIN MEMBER_TYPE m ON l.MemberTypeNo = m.MemberTypeNo and l.isArchived =0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet SelectAllCapitalContribution()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MinCapitalContributionId AS 'Minimum Capital Contribution ID', l.MemberTypeNo AS 'Member Type Id', Description AS 'Member Type', MinimumContribution AS 'Share Capital', Duration, l.Status, l.isArchived FROM MINIMUM_CAPITAL_CONTRIBUTION l INNER JOIN MEMBER_TYPE m ON l.MemberTypeNo = m.MemberTypeNo";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectAllMemberTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberTypeNo, Description FROM MEMBER_TYPE WHERE isArchived=0 and hasShareCapital=1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet SelectMemberType()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MEMBER_TYPE.MemberTypeNo, Description from MEMBER_TYPE where MEMBER_TYPE.MemberTypeNo NOT IN(SELECT MemberTypeNo from MINIMUM_CAPITAL_CONTRIBUTION WHERE isArchived = 0) AND MEMBER_TYPE.isArchived = 0 and MEMBER_TYPE.hasShareCapital =1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }
        public int InsertMinCapitalContrib()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlUpdate = "Update MINIMUM_CAPITAL_CONTRIBUTION set isArchived = 1 where MemberTypeNo = "+"'"+this.comboAccountType+"'";
            dal.executeScalar(sqlUpdate);

            String sql = "EXEC SpInsert_MinimumCapitalContribution @MinimumContribution,@Duration,@Status,@MemberTypeNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@MinimumContribution", this.txtContribution);
            parameters.Add("@Duration", this.comboContribution);
            parameters.Add("@Status", this.Status);
            parameters.Add("@MemberTypeNo", this.comboAccountType);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
         }


    }
}
