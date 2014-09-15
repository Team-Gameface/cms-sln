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
    public partial class LoanReleases : Form
    {
        public LoanReleases()
        {
            InitializeComponent();
            cbLoanTypesSort.Text = cbLoanTypesSort.Items[0].ToString();

        }

        public void setReportDataSource(DataSet ds, DataSet dsCoop, String dateFrom, String dateTo)
        {
            LoanReleasesViewer loanReleasesViewer = new LoanReleasesViewer(ds, dsCoop, dateFrom, dateTo);
            loanReleasesViewer.Show();
        }


        public void populateLoanTypes(Dictionary<int, string> loanTypes)
        {
            foreach (String s in loanTypes.Values)
            {
                checkedListBoxLoanTypes.Items.Add(s);
            }
        }

        public CheckedListBox.CheckedItemCollection getCheckedLoanTypes()
        {
            return checkedListBoxLoanTypes.CheckedItems;
        }

        public String getDateFrom()
        {

            return dateFrom.Value.ToString("yyyy-MM-dd");

        }

        public String getDateTo()
        {

            return dateTo.Value.ToString("yyyy-MM-dd");

        }

        public String getSortBy()
        {
            try
            {

                return cbLoanTypesSort.SelectedItem.ToString();
            }
            catch (NullReferenceException) { return String.Empty; }

        }
        public String getOrder()
        {

            if (rbLoanTypesAscending.Checked)
                return "asc";
            else if (rbLoanTypesDescending.Checked)
                return "desc";
            else return String.Empty;

        }

        private void cbAllLoanTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllLoanTypes.Checked)
                for (int i = 0; i < checkedListBoxLoanTypes.Items.Count; i++)
                    checkedListBoxLoanTypes.SetItemChecked(i, true);
            else
                for (int i = 0; i < checkedListBoxLoanTypes.Items.Count; i++)
                    checkedListBoxLoanTypes.SetItemChecked(i, false);
        }

        public void errorDateFrom()
        {

            lblFrom.ForeColor = Color.Red;

        }

        public void errorDateTo()
        {
            lblTo.ForeColor = Color.Red;
        }

        public void errorLoanTypes()
        {
            lblLoanTypes.ForeColor = Color.Red;
        }

        public void errorLoanSortBy()
        {
            grpLoanTypesSort.ForeColor = Color.Red;
        }

        public void errorLoanOrder()
        {
            rbLoanTypesAscending.ForeColor = Color.Red;
            rbLoanTypesDescending.ForeColor = Color.Red;

        }

        public void clearLabels()
        {

            lblFrom.ForeColor = Color.Black;
            lblTo.ForeColor = Color.Black;
            lblLoanTypes.ForeColor = Color.Black;
            grpLoanTypesSort.ForeColor = Color.Black;
            rbLoanTypesAscending.ForeColor = Color.Black;
            rbLoanTypesDescending.ForeColor = Color.Black;

        }

        public void setBtnPreviewEventHandler(EventHandler e)
        {

            this.btnPreview.Click += e;

        }
    }
}
