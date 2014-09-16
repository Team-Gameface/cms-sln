using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CMS.Loan_Management.Reports.Controller
{
    class LoanReleasesController
    {
        Reports.Model.LoanReleasesModel loanReleasesModel;
        Reports.View.LoanReleases loanReleases;
        Main.Logger logger = new Main.Logger();
        Dictionary<int, string> loanTypes = new Dictionary<int, string>();

        public LoanReleasesController(Reports.Model.LoanReleasesModel loanReleasesModel, Reports.View.LoanReleases loanReleases, Loan_Management.LoanManagementMenu loanMenu)
        {
            this.loanReleasesModel = loanReleasesModel;
            this.loanReleases = loanReleases;
            this.loanReleases.MdiParent = loanMenu;
            this.loanReleases.setBtnPreviewEventHandler(this.btnPreview);
            this.clbLoanTypes();
            this.loanReleases.Show();
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Transaction - Share Capital Contribution";
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

        public void clbLoanTypes() {
          
            loanTypes.Clear();
            DataTable ds = this.loanReleasesModel.selectLoanTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                loanTypes.Add(int.Parse(dr[0].ToString()), dr[1].ToString());

            }
            this.loanReleases.populateLoanTypes(loanTypes);
        
        
        }

        private void btnPreview(object sender, EventArgs e) {

            int hasError = 0;
            String errors = String.Empty;
            this.loanReleases.clearLabels();


            this.loanReleasesModel.dateFrom = this.loanReleases.getDateFrom();
            this.loanReleasesModel.dateTo = this.loanReleases.getDateTo();
            this.loanReleasesModel.checkedLoanTypes = this.loanReleases.getCheckedLoanTypes();
            this.loanReleasesModel.sortBy = this.loanReleases.getSortBy();
            this.loanReleasesModel.order = this.loanReleases.getOrder();

            ArrayList loanTypesNo = new ArrayList();

            foreach (String s in loanReleasesModel.checkedLoanTypes)
            {
                foreach (KeyValuePair<int, string> pair in loanTypes)
                {
                    if (s.Equals(pair.Value))
                        loanTypesNo.Add(pair.Key);
                }
            }

            switch (loanReleases.getSortBy())
            {

                case "Approval Date": loanReleasesModel.sortBy = "li.DateApproved";
                    break;
                case "Member Account No": loanReleasesModel.sortBy = "li.AccountNo";
                    break;
                case "Member Name": loanReleasesModel.sortBy = "CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName)";
                    break;
                case "Loan Type": loanReleasesModel.sortBy = "lt.LoanTypeName";
                    break;
                case "CV Number": loanReleasesModel.sortBy = "LoanApplicationID"; //AAYUSIN LALAGYAN NG VOUCHER NO
                    break;
                default: loanReleasesModel.sortBy = String.Empty;
                    break;

            }

            if (loanReleasesModel.dateFrom == String.Empty)
            { loanReleases.errorDateFrom(); hasError = 1; errors += "- Start Date is empty." + Environment.NewLine; }
            if (loanReleasesModel.dateTo == String.Empty)
                {
                    loanReleases.errorDateTo();
                    hasError = 1;
                    errors += "- End Date is empty." + Environment.NewLine;
                }
            else if (DateTime.Compare(DateTime.Parse(loanReleasesModel.dateFrom), DateTime.Parse(loanReleasesModel.dateTo)) > 0)
                { loanReleases.errorDateTo(); hasError = 1; errors += "- Start date is greater than End date." + Environment.NewLine; }

            if (loanReleasesModel.checkedLoanTypes.Count == 0)
            { loanReleases.errorLoanTypes(); hasError = 1; errors += "- Please check at least one loan type." + Environment.NewLine; }
            if (loanReleasesModel.sortBy == String.Empty)
            { loanReleases.errorLoanSortBy(); hasError = 1; errors += "- Please select field to sort." + Environment.NewLine; }
            if (loanReleasesModel.order == String.Empty)
            { loanReleases.errorLoanOrder(); hasError = 1; errors += "- Please select sorting method." + Environment.NewLine; }


            if (hasError == 0)
            {
                DataSet ds = loanReleasesModel.listDailyTransactions(loanReleasesModel.dateFrom, loanReleasesModel.dateTo, loanTypesNo, loanReleasesModel.sortBy, loanReleasesModel.order, "dtLoanReleases");
                DataSet dsCoop = loanReleasesModel.getCompanyProfile("dtLogo");
                DataSet dsStaff = loanReleasesModel.getStaff(Main.UserData.userId, "dtStaff");
                DataSet dsMgr = loanReleasesModel.getManager("dtManager");
                DataSet dsCredChair = loanReleasesModel.getChair("dtCreditChair");

                if (ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("No records to show.", "Loan Releases");
                else
                {
                    loanReleases.setReportDataSource(ds, dsCoop, dsStaff, dsMgr, dsCredChair, loanReleasesModel.dateFrom, loanReleasesModel.dateTo);
                    execLogger("Generated Report");
                }

            }
            else
                MessageBox.Show("Errors had been found." + Environment.NewLine + errors);
        }
    }
}
