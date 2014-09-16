using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.View
{
    public partial class TimeDepositCertificateViewer : Form
    {
        TimeDepositCertificate rpt = new TimeDepositCertificate();
        public TimeDepositCertificateViewer(DataSet ds, DataSet dsCoop, DataSet dsMgr)
        {
            InitializeComponent();
            rpt.SetDataSource(ds.Tables[0]);
            rpt.Subreports["CompanyHeader"].SetDataSource(dsCoop.Tables[0]);
            rpt.Subreports["ManagerSub"].SetDataSource(dsMgr.Tables[0]);
            crViewer1.ReportSource = rpt;
            this.Show();

        }
    }
}
