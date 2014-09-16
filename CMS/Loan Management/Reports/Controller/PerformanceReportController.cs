using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Reports.Controller
{
    class PerformanceReportController
    {

        Reports.Model.PerformanceReportModel performanceReportModel;
        Reports.View.PerformanceReport performanceReport;
        Main.Logger logger = new Main.Logger();

        public PerformanceReportController(Reports.Model.PerformanceReportModel performanceReportModel, Reports.View.PerformanceReport performanceReport, Loan_Management.LoanManagementMenu loanMenu)
        {

            this.performanceReportModel = performanceReportModel;
            this.performanceReport = performanceReport;
            this.performanceReport.MdiParent = loanMenu;
            this.performanceReport.setBtnPreviewEventHandler(this.btnPreview);
            this.performanceReport.Show();
        
        }


        private void btnPreview(object sender, EventArgs e) {

            this.performanceReportModel.year = this.performanceReport.getYear();
            MessageBox.Show(this.performanceReportModel.year + "");
        
        }

    }
}
