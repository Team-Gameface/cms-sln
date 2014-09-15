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
    public partial class ShareCollectionViewer : Form
    {
        ShareCollectionReport rpt = new ShareCollectionReport();

        public ShareCollectionViewer(DataSet ds, DataSet dsCoop, String dateFrom, String dateTo)
        {
            InitializeComponent();
            rpt.SetDataSource(ds.Tables[0]);
            rpt.Subreports[0].SetDataSource(dsCoop.Tables[0]);
            crViewer1.ReportSource = rpt;
            this.Show();
        }
    }
}
