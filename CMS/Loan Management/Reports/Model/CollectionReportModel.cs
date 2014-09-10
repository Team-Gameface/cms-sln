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
    class CollectionReportModel
    {

        public String dateFrom { get; set; }
        public String dateTo { get; set; }
        public String transType { get; set; }
        public CheckedListBox.CheckedItemCollection checkedLoanTypes { get; set; }
        public CheckedListBox.CheckedItemCollection checkedMiscFees { get; set; }
        public String sortBy { get; set; }
        public String order { get; set; }

        public CollectionReportModel() {


            this.dateFrom = String.Empty;
            this.dateTo = String.Empty;
            this.transType = String.Empty;
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

        public DataSet selectFees()
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT FeeId AS 'Fee No', Description FROM fee WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

    }
}
