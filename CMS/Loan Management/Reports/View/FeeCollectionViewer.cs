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
    public partial class FeeCollectionViewer : Form
    {
        FeeCollectionReport rpt = new FeeCollectionReport();

        public FeeCollectionViewer(DataSet ds, DataSet dsCoop, String dateFrom, String dateTo)
        {
            InitializeComponent();
            rpt.SetDataSource(ds.Tables[0]);
            rpt.Subreports[0].SetDataSource(dsCoop.Tables[0]);
            crViewer1.ReportSource = rpt;
            CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;

            txtReportHeader = rpt.ReportDefinition.ReportObjects["Subtitle"] as TextObject;
            if (dateTo.Length == 0)
                txtReportHeader.Text = DateTime.Parse(dateFrom).ToString("MMMM dd, yyyy");
            else
                txtReportHeader.Text = "from " + DateTime.Parse(dateFrom).ToString("MMMM dd, yyyy") + " to " + DateTime.Parse(dateTo).ToString("MMMM dd, yyyy");
            this.Show();
        }
    }
}
