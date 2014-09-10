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

namespace CMS.Loan_Management.Reports.Model
{
    class ScheduleOfDelinquentsModel
    {
        public String dateFrom { get; set; }
        public CheckedListBox.CheckedItemCollection checkedLoanTypes { get; set; }
        public String groupBy { get; set; }
        public String ageBracket { get; set; }
        public String sortBy { get; set; }
        public String order { get; set; }

        public ScheduleOfDelinquentsModel()
        {
            
            this.dateFrom = String.Empty;
            this.groupBy = String.Empty;
            this.ageBracket = String.Empty;
            this.sortBy = String.Empty;
            this.order = String.Empty;
        
        }

        public DataSet selectLoanTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId AS 'Type No', LoanTypeName AS 'Type Name' FROM LOAN_TYPE WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }
    }
}
