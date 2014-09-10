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
                cbAllLoanTypes.CheckState = CheckState.Unchecked;
                cbLoanTypesSort.Text = cbLoanTypesSort.Items[0].ToString();
                for (int i = 0; i < checkedListBoxLoanTypes.Items.Count; i++)
                    checkedListBoxLoanTypes.SetItemChecked(i, false);
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
                cbAllMiscFees.CheckState = CheckState.Unchecked;
                cbMiscFeesSort.Text = cbMiscFeesSort.Items[0].ToString();
                for (int i = 0; i < checkedListBoxMiscFees.Items.Count; i++)
                    checkedListBoxMiscFees.SetItemChecked(i, false);
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

        public void populateMiscFees(Dictionary<int, string> miscFees)
        {
            foreach (String s in miscFees.Values)
            {
                checkedListBoxMiscFees.Items.Add(s);
            }
        }

        public CheckedListBox.CheckedItemCollection getCheckedMiscFees()
        {

            return checkedListBoxMiscFees.CheckedItems;
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

        private void cbAllLoanTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllLoanTypes.Checked)
                for (int i = 0; i < checkedListBoxLoanTypes.Items.Count; i++)
                    checkedListBoxLoanTypes.SetItemChecked(i, true);
            else
                for (int i = 0; i < checkedListBoxLoanTypes.Items.Count; i++)
                    checkedListBoxLoanTypes.SetItemChecked(i, false);
        }

        private void cbAllMiscFees_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllMiscFees.Checked)
                for (int i = 0; i < checkedListBoxMiscFees.Items.Count; i++)
                    checkedListBoxMiscFees.SetItemChecked(i, true);
            else
                for (int i = 0; i < checkedListBoxMiscFees.Items.Count; i++)
                    checkedListBoxMiscFees.SetItemChecked(i, false);
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

        public void errorLoanTypes()
        {
            lblLoanTypes.ForeColor = Color.Red;
        }

        public void errorMiscFees()
        {
            lblMiscFees.ForeColor = Color.Red;
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
            lblLoanTypes.ForeColor = Color.Black;
            lblMiscFees.ForeColor = Color.Black;
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
