using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;


namespace CMS.Loan_Management.Reports.View
{
    public partial class LoanReleasesViewer : Form
    {
        LoanReleasesReport rpt = new LoanReleasesReport();


        public LoanReleasesViewer(DataSet ds, DataSet dsCoop, DataSet dsStaff, DataSet dsManager, DataSet dsChair, String dateFrom, String dateTo)
        {
            InitializeComponent();
            rpt.SetDataSource(ds.Tables[0]);
            rpt.Subreports["CompanyHeader"].SetDataSource(dsCoop.Tables[0]);
            rpt.Subreports["StaffSub"].SetDataSource(dsStaff.Tables[0]);
            rpt.Subreports["ChairSub"].SetDataSource(dsChair.Tables[0]);
            rpt.Subreports["ManagerSub"].SetDataSource(dsManager.Tables[0]);
            crViewer1.ReportSource = rpt;
            CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;

            txtReportHeader = rpt.ReportDefinition.ReportObjects["Subtitle"] as TextObject;
            txtReportHeader.Text = "from " + DateTime.Parse(dateFrom).ToString("MMMM dd, yyyy") + " to " + DateTime.Parse(dateTo).ToString("MMMM dd, yyyy");
            this.Show();
        }

    }
}
