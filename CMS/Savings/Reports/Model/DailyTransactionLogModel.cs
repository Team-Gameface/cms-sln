using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CMS.Savings.Reports.Model
{
    class DailyTransactionLogModel
    {

        public String dateFrom { get; set; }
        public String dateTo { get; set; }
        public CheckedListBox.CheckedItemCollection checkedSavingsTypes { get; set; }
        public String sortBy { get; set; }
        public String order { get; set; }

        public DailyTransactionLogModel() {

            this.dateFrom = String.Empty;
            this.dateTo = String.Empty;
            this.sortBy = String.Empty;
            this.order = String.Empty;

        }


        public DataSet selectSavingsTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId AS 'TypeId', SavingsTypeName AS 'SavingsType' FROM SAVINGS_ACCOUNT_TYPE WHERE isArchived = 0 AND Status = 1 AND isTimeDeposit = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }
    }
}
