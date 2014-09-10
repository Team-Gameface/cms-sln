using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Reports.Controller
{
    class ScheduleOfDelinquentsController
    {

        Reports.Model.ScheduleOfDelinquentsModel scheduleOfDelinquentsModel;
        Reports.View.ScheduleOfDelinquents scheduleOfDelinquents;

        Dictionary<int, string> loanTypes = new Dictionary<int, string>();

        public ScheduleOfDelinquentsController(Reports.Model.ScheduleOfDelinquentsModel scheduleOfDelinquentsModel, Reports.View.ScheduleOfDelinquents scheduleOfDelinquents, Loan_Management.LoanManagementMenu loanMenu)
        {
            this.scheduleOfDelinquentsModel = scheduleOfDelinquentsModel;
            this.scheduleOfDelinquents = scheduleOfDelinquents;
            this.scheduleOfDelinquents.MdiParent = loanMenu;
            this.scheduleOfDelinquents.setBtnPreviewEventHandler(this.btnPreview);
            this.clbLoanTypes();
            this.scheduleOfDelinquents.Show();
        }

        public void clbLoanTypes()
        {

            loanTypes.Clear();
            DataTable ds = this.scheduleOfDelinquentsModel.selectLoanTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                loanTypes.Add(int.Parse(dr[0].ToString()), dr[1].ToString());

            }
            this.scheduleOfDelinquents.populateLoanTypes(loanTypes);


        }

        private void btnPreview(object sender, EventArgs e) {

            int hasError = 0;
            String errors = String.Empty;
            this.scheduleOfDelinquents.clearLabels();


            this.scheduleOfDelinquentsModel.dateFrom = this.scheduleOfDelinquents.getDateFrom();
            if (scheduleOfDelinquents.getAgeFilterChecked())
                this.scheduleOfDelinquentsModel.ageBracket = this.scheduleOfDelinquents.getAgeBracket();
            else this.scheduleOfDelinquentsModel.ageBracket = String.Empty;
            this.scheduleOfDelinquentsModel.checkedLoanTypes = this.scheduleOfDelinquents.getCheckedLoanTypes();
            this.scheduleOfDelinquentsModel.sortBy = this.scheduleOfDelinquents.getSortBy();
            this.scheduleOfDelinquentsModel.order = this.scheduleOfDelinquents.getOrder();
            this.scheduleOfDelinquentsModel.groupBy = this.scheduleOfDelinquents.getGroupBy();

            if (scheduleOfDelinquentsModel.dateFrom == String.Empty)
            { scheduleOfDelinquents.errorDateFrom(); hasError = 1; errors += "- Start Date is empty." + Environment.NewLine; }

            if (scheduleOfDelinquents.getAgeFilterChecked() && scheduleOfDelinquentsModel.ageBracket == String.Empty)
            { scheduleOfDelinquents.errorDateFrom(); hasError = 1; errors += "- Please select Loan Age Bracket." + Environment.NewLine; }

            if (scheduleOfDelinquentsModel.groupBy == String.Empty)
            { scheduleOfDelinquents.errorLoanGroup(); hasError = 1; errors += "- Please select a grouping method." + Environment.NewLine; }

            if (scheduleOfDelinquentsModel.checkedLoanTypes.Count == 0)
            { scheduleOfDelinquents.errorLoanTypes(); hasError = 1; errors += "- Please check at least one loan type." + Environment.NewLine; }
            if (scheduleOfDelinquentsModel.sortBy == String.Empty)
            { scheduleOfDelinquents.errorLoanSortBy(); hasError = 1; errors += "- Please select field to sort." + Environment.NewLine; }
            if (scheduleOfDelinquentsModel.order == String.Empty)
            { scheduleOfDelinquents.errorLoanOrder(); hasError = 1; errors += "- Please select sorting method." + Environment.NewLine; }


            if (hasError == 0)
                MessageBox.Show(scheduleOfDelinquentsModel.dateFrom + " " + scheduleOfDelinquentsModel.ageBracket + scheduleOfDelinquentsModel.groupBy + " " + scheduleOfDelinquentsModel.sortBy + " " + scheduleOfDelinquentsModel.order);
            else
                MessageBox.Show("Errors had been found." + Environment.NewLine + errors);
        
        }
    }
}
