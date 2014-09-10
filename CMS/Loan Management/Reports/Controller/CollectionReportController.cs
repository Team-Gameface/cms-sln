using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Reports.Controller
{
    class CollectionReportController
    {

        Reports.Model.CollectionReportModel collectionReportModel;
        Reports.View.CollectionReport collectionReport;

        Dictionary<int, string> loanTypes = new Dictionary<int, string>();
        Dictionary<int, string> miscFees = new Dictionary<int, string>();


        public CollectionReportController(Reports.Model.CollectionReportModel collectionReportModel, Reports.View.CollectionReport collectionReport, Loan_Management.LoanManagementMenu loanMenu) 
        {
            this.collectionReportModel = collectionReportModel;
            this.collectionReport = collectionReport;
            this.collectionReport.MdiParent = loanMenu;
            this.collectionReport.setBtnPreviewEventHandler(this.btnPreview);
            this.clbLoanTypes();
            this.clbMiscFees();
            this.collectionReport.Show();
        }

        public void clbLoanTypes() {

            loanTypes.Clear();
            DataTable ds = this.collectionReportModel.selectLoanTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                loanTypes.Add(int.Parse(dr[0].ToString()), dr[1].ToString());

            }
            this.collectionReport.populateLoanTypes(loanTypes);
        
        
        }

        public void clbMiscFees()
        {

            miscFees.Clear();
            DataTable ds = this.collectionReportModel.selectFees().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                miscFees.Add(int.Parse(dr[0].ToString()), dr[1].ToString());

            }
            this.collectionReport.populateMiscFees(miscFees);


        }

        private void btnPreview(object sender, EventArgs e) {

            int hasError = 0;
            String errors = String.Empty;
            this.collectionReport.clearLabels();


            this.collectionReportModel.dateFrom = this.collectionReport.getDateFrom();
            if (this.collectionReport.getDateToChecked())
                this.collectionReportModel.dateTo = this.collectionReport.getDateTo();
            else
                this.collectionReportModel.dateTo = String.Empty;
            this.collectionReportModel.transType = this.collectionReport.getTransactionType();
            
            switch (this.collectionReportModel.transType) {

                case "Loan": 
                    this.collectionReportModel.checkedLoanTypes = this.collectionReport.getCheckedLoanTypes();
                    this.collectionReportModel.sortBy = this.collectionReport.getLoanSortBy();
                    this.collectionReportModel.order = this.collectionReport.getLoanOrder();
                    break;

                case "Miscellaneous": 
                    this.collectionReportModel.checkedMiscFees = this.collectionReport.getCheckedMiscFees();
                    this.collectionReportModel.sortBy = this.collectionReport.getMiscFeesSortBy();
                    this.collectionReportModel.order = this.collectionReport.getMiscFeesOrder();
                    break;
                case "Share": 
                    this.collectionReportModel.sortBy = this.collectionReport.getShareSortBy();
                    this.collectionReportModel.order = this.collectionReport.getShareOrder();
                    break;
                             
                default : 
                    this.collectionReportModel.sortBy = String.Empty;
                    this.collectionReportModel.order = String.Empty;
                    break;
            }

            if (collectionReportModel.dateFrom == String.Empty)
            { collectionReport.errorDateFrom(); hasError = 1; errors += "- Start Date is empty." + Environment.NewLine; }
            if (collectionReport.getDateToChecked())
            {
                if (collectionReport.getDateTo() == String.Empty)
                {
                    collectionReport.errorDateTo();
                    hasError = 1;
                    errors += "- End Date is empty." + Environment.NewLine;
                }
                else if (DateTime.Compare(DateTime.Parse(collectionReport.getDateFrom()), DateTime.Parse(collectionReport.getDateTo())) > 0)
                { collectionReport.errorDateTo(); hasError = 1; errors += "- Start date is greater than End date." + Environment.NewLine; }
            }

            if (collectionReportModel.transType == String.Empty)
            { collectionReport.errorTransType(); hasError = 1; errors += "- Please select a transaction type." + Environment.NewLine; }

            switch (this.collectionReportModel.transType) {

                case "Loan": 
                    if (collectionReportModel.checkedLoanTypes.Count == 0)
                    { collectionReport.errorLoanTypes(); hasError = 1; errors += "- Please check at least one loan type." + Environment.NewLine; }
                    if (collectionReportModel.sortBy == String.Empty)
                    { collectionReport.errorLoanSortBy(); hasError = 1; errors += "- Please select field to sort." + Environment.NewLine; }
                    if (collectionReportModel.order == String.Empty)
                    { collectionReport.errorLoanGroupBy(); hasError = 1; errors += "- Please select sorting method." + Environment.NewLine; }
                    break;

                case "Miscellaneous":
                    if (collectionReportModel.checkedMiscFees.Count == 0)
                    { collectionReport.errorMiscFees(); hasError = 1; errors += "- Please check at least one miscellaneous fee." + Environment.NewLine; }
                    if (collectionReportModel.sortBy == String.Empty)
                    { collectionReport.errorMiscFeesSortBy(); hasError = 1; errors += "- Please select field to sort." + Environment.NewLine; }
                    if (collectionReportModel.order == String.Empty)
                    { collectionReport.errorMiscFeesGroupBy(); hasError = 1; errors += "- Please select sorting method." + Environment.NewLine; }
                    break;

                case "Share":
                    if (collectionReportModel.sortBy == String.Empty)
                    { collectionReport.errorShareSortBy(); hasError = 1; errors += "- Please select field to sort." + Environment.NewLine; }
                    if (collectionReportModel.order == String.Empty)
                    { collectionReport.errorShareGroupBy(); hasError = 1; errors += "- Please select sorting method." + Environment.NewLine; }
                    break;
                default: break;
            
            
            }

            if (hasError == 0)
                MessageBox.Show(collectionReportModel.dateFrom + " " + collectionReportModel.dateTo + collectionReportModel.transType + " " + collectionReportModel.sortBy + " " + collectionReportModel.order);
            else
                MessageBox.Show("Errors had been found." + Environment.NewLine + errors);
            
        
        }



    }
}
