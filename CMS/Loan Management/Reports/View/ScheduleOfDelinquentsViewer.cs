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
    public partial class ScheduleOfDelinquentsViewer : Form
    {
        ScheduleOfDelinquentReport rpt = new ScheduleOfDelinquentReport();
        public ScheduleOfDelinquentsViewer(DataSet ds, DataSet dsCoop, DataSet dsStaff, DataSet dsManager, DataSet dsChair, String dateFrom)
        {
            InitializeComponent();
            rpt.SetDataSource(ds.Tables["MyTable"]);
            rpt.Subreports["CompanyHeader"].SetDataSource(dsCoop.Tables[0]);
            rpt.Subreports["StaffSub"].SetDataSource(dsStaff.Tables[0]);
            rpt.Subreports["ChairSub"].SetDataSource(dsChair.Tables[0]);
            rpt.Subreports["ManagerSub"].SetDataSource(dsManager.Tables[0]);
            crViewer1.ReportSource = rpt;
            CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;

            txtReportHeader = rpt.ReportDefinition.ReportObjects["Subtitle"] as TextObject;
            txtReportHeader.Text = "as of " + DateTime.Parse(dateFrom).ToString("MMMM dd, yyyy");
            this.Show();
        }
    }
}
