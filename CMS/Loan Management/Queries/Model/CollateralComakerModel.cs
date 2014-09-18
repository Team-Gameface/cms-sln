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

namespace CMS.Loan_Management.Queries.Model
{
    class CollateralComakerModel
    {

        public int loanApplicationId { get; set; }

        public CollateralComakerModel() {

            this.loanApplicationId = 0;
        }

        public DataSet selectCollaterals()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT SerialNo AS 'Serial No.', Name AS 'Property Name/Title', Description, YearAcquired AS 'Year Acquired', AcquiredAmount AS 'Acquired Amount' FROM PROPERTY_COLLATERAL WHERE LoanApplicationId = @lAppId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@lAppId", this.loanApplicationId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectComakers()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT c.AccountNo AS 'Account No.', CONCAT(m.LastName,', ',m.FirstName,' ',m.MiddleName) AS 'Comaker Name', CONCAT(m.AddressNo,' ',m.AddressStreet,' ',m.AddressBarangay,' ',m.AddressCity,' ',m.AddressProvince) AS 'Address', m.TelephoneNo AS 'Telephone', m.CellphoneNo AS 'Cellphone', m.EmailAddress AS 'E-mail' FROM COMAKER c INNER JOIN MEMBER m ON c.AccountNo = m.AccountNo WHERE c.LoanApplicationId = @lAppId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@lAppId", this.loanApplicationId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }
    }
}
