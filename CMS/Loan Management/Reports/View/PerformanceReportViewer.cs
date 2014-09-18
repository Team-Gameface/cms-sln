using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

namespace CMS.Loan_Management.Reports.View
{
    public partial class PerformanceReportViewer : Form
    {
        Loan_Management.Reports.PerformanceReport rpt = new Loan_Management.Reports.PerformanceReport();

        public PerformanceReportViewer()
        {
            InitializeComponent();
            numReportYear.Maximum = Convert.ToInt32(DateTime.Today.Year);
            numReportYear.Value = Convert.ToInt32(DateTime.Today.Year);
        }


        public void setBtnPreviewEventHandler (EventHandler e){

            this.btnPreview.Click += e;
        
        }

        public int getYear() {

            try
            {
                return Convert.ToInt32(numReportYear.Value);
            }
            catch (Exception) { return 0; }
        }


        public void setReportSource(DataSet dsMem, DataSet dsShare, DataSet dsSavings, DataSet dsTimeDep, DataSet dsLoanReleases, DataSet dsCoop, DataSet dsStaff, DataSet dsCreditChair, DataSet dsAuditChair, DataSet dsManager, String year)
        {
            rpt.Subreports["CompanyHeader"].SetDataSource(dsCoop.Tables[0]);
            rpt.Subreports["StaffSub"].SetDataSource(dsStaff.Tables[0]);
            rpt.Subreports["CreditChairSub"].SetDataSource(dsCreditChair.Tables[0]);
            rpt.Subreports["AuditChairSub"].SetDataSource(dsAuditChair.Tables[0]);
            rpt.Subreports["ManagerSub"].SetDataSource(dsManager.Tables[0]);
            rpt.Subreports["MemberPopulation"].SetDataSource(dsMem.Tables[0]);
            rpt.Subreports["TotalShare"].SetDataSource(dsShare.Tables[0]);
            rpt.Subreports["TotalSavings"].SetDataSource(dsSavings.Tables[0]);
            rpt.Subreports["TimeDeposit"].SetDataSource(dsTimeDep.Tables[0]);
            rpt.Subreports["TotalLoanReleases"].SetDataSource(dsLoanReleases.Tables[0]);
            rpt.SetParameterValue("year", Convert.ToInt32(year),"MemberPopulation");
            rpt.SetParameterValue("year", Convert.ToInt32(year), "TotalShare");
            rpt.SetParameterValue("year", Convert.ToInt32(year), "TotalSavings");
            rpt.SetParameterValue("year", Convert.ToInt32(year), "TotalLoanReleases");
            CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;
            txtReportHeader = rpt.ReportDefinition.ReportObjects["Subtitle"] as TextObject;
            txtReportHeader.Text = "from January 1, " + year.ToString() + " to December 31, " + year.ToString();
            crViewer1.ReportSource = rpt;
        }
    }
}
