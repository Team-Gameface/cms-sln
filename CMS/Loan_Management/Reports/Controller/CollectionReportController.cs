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
        Main.Logger logger = new Main.Logger();
        Dictionary<int, string> loanTypes = new Dictionary<int, string>();
        Dictionary<int, string> miscFees = new Dictionary<int, string>();


        public CollectionReportController(Reports.Model.CollectionReportModel collectionReportModel, Reports.View.CollectionReport collectionReport, Loan_Management.LoanManagementMenu loanMenu) 
        {
            this.collectionReportModel = collectionReportModel;
            this.collectionReport = collectionReport;
            this.collectionReport.MdiParent = loanMenu;
            this.collectionReport.setBtnPreviewEventHandler(this.btnPreview);
            this.collectionReport.Show();
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Reports - Daily Transaction Log";
            logger.Activity = ModuleActivity;
            if (logger.insertLog() > 0)
            {
                Console.WriteLine("Logged");
            }
            else
            {
                Console.WriteLine("Not Logged");
            }
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
                    this.collectionReportModel.sortBy = this.collectionReport.getLoanSortBy();
                    switch (this.collectionReport.getLoanSortBy()) {

                        case "Transaction Time": this.collectionReportModel.sortBy = "p.PaymentDate";
                                                 break;
                        case "Member Account No": this.collectionReportModel.sortBy = "p.AccountNo";
                                                 break;
                        case "Member Name": this.collectionReportModel.sortBy = "CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName)";
                                                 break;
                        case "OR No": this.collectionReportModel.sortBy = "TransactionID";
                                                 break;
                        case "Loan Type": this.collectionReportModel.sortBy = "lt.LoanTypeName";
                                                 break;
                        default: this.collectionReportModel.sortBy = String.Empty;
                                                 break;
                    
                    
                    }
                    this.collectionReportModel.order = this.collectionReport.getLoanOrder();
                    break;

                case "Miscellaneous": 
                    this.collectionReportModel.sortBy = this.collectionReport.getMiscFeesSortBy();
                    switch (this.collectionReport.getMiscFeesSortBy())
                    {

                        case "Transaction Time": this.collectionReportModel.sortBy = "p.PaymentDate";
                            break;
                        case "Member Account No": this.collectionReportModel.sortBy = "p.AccountNo";
                            break;
                        case "Member Name": this.collectionReportModel.sortBy = "CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName)";
                            break;
                        case "OR No": this.collectionReportModel.sortBy = "TransactionID";
                            break;
                        case "Description": this.collectionReportModel.sortBy = "f.Description";
                            break;
                        default: this.collectionReportModel.sortBy = String.Empty;
                            break;


                    }
                    this.collectionReportModel.order = this.collectionReport.getMiscFeesOrder();
                    break;
                case "Share": 
                    this.collectionReportModel.sortBy = this.collectionReport.getShareSortBy();
                    switch (this.collectionReport.getShareSortBy())
                    {

                        case "Transaction Time": this.collectionReportModel.sortBy = "DateOfTransaction";
                            break;
                        case "Member Account No": this.collectionReportModel.sortBy = "accountNo";
                            break;
                        case "Member Name": this.collectionReportModel.sortBy = "CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName)";
                            break;
                        case "OR No": this.collectionReportModel.sortBy = "TransactionId";
                            break;
                        default: this.collectionReportModel.sortBy = String.Empty;
                            break;

                    }
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
                    if (collectionReportModel.sortBy == String.Empty)
                    { collectionReport.errorLoanSortBy(); hasError = 1; errors += "- Please select field to sort." + Environment.NewLine; }
                    if (collectionReportModel.order == String.Empty)
                    { collectionReport.errorLoanGroupBy(); hasError = 1; errors += "- Please select sorting method." + Environment.NewLine; }
                    break;

                case "Miscellaneous":
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
            {
                DataSet ds = null;
                DataSet dsCoop = collectionReportModel.getCompanyProfile("dtLogo");
                DataSet dsStaff = collectionReportModel.getStaff(Main.UserData.userId, "dtStaff");
                DataSet dsMgr = collectionReportModel.getManager("dtManager");
                DataSet dsCredChair = collectionReportModel.getChair("dtCreditChair");
                switch (this.collectionReportModel.transType)
                {
                    case "Loan": 
                       
                        if (collectionReport.getDateToChecked())
                            ds = this.collectionReportModel.selectLoanCollections(this.collectionReportModel.dateFrom, this.collectionReportModel.dateTo, this.collectionReportModel.sortBy, this.collectionReportModel.order, "dtLoanCol");
                        else
                            ds = this.collectionReportModel.selectLoanCollections(this.collectionReportModel.dateFrom, this.collectionReportModel.sortBy, this.collectionReportModel.order, "dtLoanCol");
                        break;
             
                    case "Miscellaneous":
                         if (collectionReport.getDateToChecked())
                             ds = this.collectionReportModel.selectFeeCollections(this.collectionReportModel.dateFrom, this.collectionReportModel.dateTo, this.collectionReportModel.sortBy, this.collectionReportModel.order, "dtFeeCol");
                        else
                             ds = this.collectionReportModel.selectFeeCollections(this.collectionReportModel.dateFrom, this.collectionReportModel.sortBy, this.collectionReportModel.order, "dtFeeCol");
                        break;
                    case "Share":
                         if (collectionReport.getDateToChecked())
                             ds = this.collectionReportModel.selectShareCollections(this.collectionReportModel.dateFrom, this.collectionReportModel.dateTo, this.collectionReportModel.sortBy, this.collectionReportModel.order, "dtShareCol");
                        else
                             ds = this.collectionReportModel.selectShareCollections(this.collectionReportModel.dateFrom, this.collectionReportModel.sortBy, this.collectionReportModel.order, "dtShareCol");
                        break;
                    default:
                        break;

                }

                if (ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("No records to show.", "Collection Report");
                else
                {
                    collectionReport.setReportDataSource(ds, dsCoop, dsStaff, dsMgr, dsCredChair, collectionReportModel.dateFrom, collectionReportModel.dateTo, collectionReportModel.transType);
                    execLogger("Generated Report");
                }
            }
            else
                MessageBox.Show("Errors had been found." + Environment.NewLine + errors);
            
        
        }



    }
}
