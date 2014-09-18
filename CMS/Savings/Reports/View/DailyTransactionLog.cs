using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Reports.View
{
    public partial class DailyTransactionLog : Form
    {
        public DailyTransactionLog()
        {
            InitializeComponent();
            dateFrom.Value = DateTime.Today;
            cbSortBy.SelectedValue = cbSortBy.Items[0];
            dateTo.Enabled = false;
        }

        private void cbDateTo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDateTo.Checked)
                dateTo.Enabled = true;
            else
                dateTo.Enabled = false;
        }

        public void setReportDataSource(DataSet ds, DataSet dsCoop, DataSet dsStaff, DataSet dsChair, DataSet dsManager, String dateFrom, String dateTo)
        {
            
                LoanReportViewer loanReleasesViewer = new LoanReportViewer(ds, dsCoop, dsStaff, dsChair, dsManager, dateFrom, dateTo);
                loanReleasesViewer.Show();
 
            
        }


        public String getDateFrom() {

            return dateFrom.Value.ToString("yyyy-MM-dd");
        
        }

        public String getDateTo()
        {

            return dateTo.Value.ToString("yyyy-MM-dd");

        }

        public bool getDateToChecked()
        {

            if (cbDateTo.Checked)
                return true;
            else
                return false;
        }


        public String getSortBy() {
            try
            {
                return cbSortBy.SelectedItem.ToString();
            }
            catch (NullReferenceException) { return String.Empty; }

        }
        public String getOrder() {

            if (rbAscending.Checked)
                return "asc";
            else if (rbDescending.Checked)
                return "desc";
            else return String.Empty;
        
        }


        public void errorDateFrom() {

            lblFrom.ForeColor = Color.Red;

        }

        public void errorDateTo()
        {
           cbDateTo.ForeColor = Color.Red;
        }

        public void errorSortBy()
        {
            grpSort.ForeColor = Color.Red;
        }

        public void errorGroupBy()
        {
            rbAscending.ForeColor = Color.Red;
            rbDescending.ForeColor = Color.Red;

        }

        public void clearLabels() {

            lblFrom.ForeColor = Color.Black;
            cbDateTo.ForeColor = Color.Black;
            grpSort.ForeColor = Color.Black;
            rbAscending.ForeColor = Color.Black;
            rbDescending.ForeColor = Color.Black;
        
        }

        public void setBtnPreviewEventHandler(EventHandler e) { 
        
            btnPreview.Click += e;
        
        }


    }
}
