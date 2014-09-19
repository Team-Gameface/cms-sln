using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Reports.View
{
    public partial class CollectionReport : Form
    {
        public CollectionReport()
        {
            InitializeComponent();
            dateFrom.Value = DateTime.Today;
            dateTo.Enabled = false;
            panelLoan.Visible = false;
            panelMiscFees.Visible = false;
            panelShare.Visible = false;
            cbLoanTypesSort.Text = cbLoanTypesSort.Items[0].ToString();
            cbMiscFeesSort.Text = cbMiscFeesSort.Items[0].ToString();
            cbShareSort.Text = cbShareSort.Items[0].ToString();

        }

        public void setReportDataSource(DataSet ds, DataSet dsCoop, DataSet dsStaff, DataSet dsChair, DataSet dsMgr, String dateFrom, String dateTo, String type)
        {
            
            switch (type)
            {
                case "Loan": LoanCollectionViewer loanCollectionViewer = new LoanCollectionViewer(ds, dsCoop, dsStaff, dsChair, dsMgr, dateFrom, dateTo);
                            loanCollectionViewer.Show();
                             break;
                case "Miscellaneous": FeeCollectionViewer feeCollectionViewer = new FeeCollectionViewer(ds, dsCoop, dsStaff, dsChair, dsMgr, dateFrom, dateTo);
                             feeCollectionViewer.Show();
                             break;
                case "Share": ShareCollectionViewer shareCollectionViewer = new ShareCollectionViewer(ds, dsCoop, dsStaff, dsChair, dsMgr, dateFrom, dateTo);
                             shareCollectionViewer.Show();
                             break;
            }
        }

        private void cbDateTo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDateTo.Checked)
                dateTo.Enabled = true;
            else
                dateTo.Enabled = false;
        }

        private void rbLoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLoan.Checked)
                panelLoan.Visible = true;
            else
            {
                rbLoanTypesAscending.Checked = false;
                rbLoanTypesDescending.Checked = false;
                cbLoanTypesSort.Text = cbLoanTypesSort.Items[0].ToString();
                panelLoan.Visible = false;
            }
        }

        private void rbMiscFees_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMiscFees.Checked)
                panelMiscFees.Visible = true;
            else
            {
                rbMiscFeesAscending.Checked = false;
                rbMiscFeesDescending.Checked = false;
                panelMiscFees.Visible = false;
            }

        }

        private void rbShare_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShare.Checked)
                panelShare.Visible = true;
            else
            {
                rbShareAscending.Checked = false;
                rbShareDescending.Checked = false;
                cbShareSort.Text = cbShareSort.Items[0].ToString();
                panelShare.Visible = false;
            }
        }

        public String getDateFrom()
        {

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

        public String getTransactionType()
        {

            if (rbLoan.Checked)
                return "Loan";
            else if (rbMiscFees.Checked)
                return "Miscellaneous";
            else if (rbShare.Checked)
                return "Share";
            else
                return String.Empty;

        }

        public String getLoanSortBy()
        {
            try
            {
                
                return cbLoanTypesSort.SelectedItem.ToString();
            }
            catch (NullReferenceException) { return String.Empty; }

        }
        public String getLoanOrder()
        {
            
            if (rbLoanTypesAscending.Checked)
                return "asc";
            else if (rbLoanTypesDescending.Checked)
                return "desc";
            else return String.Empty;

        }

        public String getMiscFeesSortBy()
        {
            try
            {

                return cbMiscFeesSort.SelectedItem.ToString();
            }
            catch (NullReferenceException) { return String.Empty; }

        }
        public String getMiscFeesOrder()
        {

            if (rbMiscFeesAscending.Checked)
                return "asc";
            else if (rbMiscFeesDescending.Checked)
                return "desc";
            else return String.Empty;

        }

        public String getShareSortBy()
        {
            try
            {

                return cbShareSort.SelectedItem.ToString();
            }
            catch (NullReferenceException) { return String.Empty; }

        }
        public String getShareOrder()
        {

            if (rbShareAscending.Checked)
                return "asc";
            else if (rbShareDescending.Checked)
                return "desc";
            else return String.Empty;

        }

       
        public void errorDateFrom()
        {

            lblFrom.ForeColor = Color.Red;

        }

        public void errorDateTo()
        {
            cbDateTo.ForeColor = Color.Red;
        }

        public void errorTransType()
        {
            grpTransType.ForeColor = Color.Red;
        }

        public void errorLoanSortBy()
        {

            grpLoanTypesSort.ForeColor = Color.Red;
        }

        public void errorLoanGroupBy()
        {
            rbLoanTypesAscending.ForeColor = Color.Red;
            rbLoanTypesDescending.ForeColor = Color.Red;

        }

        public void errorMiscFeesSortBy()
        {

            grpMiscFeesSort.ForeColor = Color.Red;
        }

        public void errorMiscFeesGroupBy()
        {
            rbMiscFeesAscending.ForeColor = Color.Red;
            rbMiscFeesDescending.ForeColor = Color.Red;

        }

        public void errorShareSortBy()
        {
            grpShareSort.ForeColor = Color.Red;
        }

        public void errorShareGroupBy()
        {
            rbShareAscending.ForeColor = Color.Red;
            rbShareDescending.ForeColor = Color.Red;

        }

        public void clearLabels()
        {

            lblFrom.ForeColor = Color.Black;
            cbDateTo.ForeColor = Color.Black;
            grpShareSort.ForeColor = Color.Black;
            grpLoanTypesSort.ForeColor = Color.Black;
            grpMiscFeesSort.ForeColor = Color.Black;
            grpTransType.ForeColor = Color.Black;
            rbLoanTypesAscending.ForeColor = Color.Black;
            rbLoanTypesDescending.ForeColor = Color.Black;
            rbMiscFeesAscending.ForeColor = Color.Black;
            rbMiscFeesDescending.ForeColor = Color.Black;
            rbShareAscending.ForeColor = Color.Black;
            rbShareDescending.ForeColor = Color.Black;
            
        }

        public void setBtnPreviewEventHandler(EventHandler e) {

            this.btnPreview.Click += e;

        }
    }
}
