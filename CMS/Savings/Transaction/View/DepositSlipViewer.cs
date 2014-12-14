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
    public partial class DepositSlipViewer : Form
    {
        DepositSlip rpt = new DepositSlip();
        public DepositSlipViewer(DataSet ds, DataSet dsCoop, DataSet dsStaff)
        {
            InitializeComponent();
            rpt.SetDataSource(ds.Tables[0]);
            rpt.Subreports["CompanyProfile"].SetDataSource(dsCoop.Tables[0]);
            rpt.Subreports["StaffSub"].SetDataSource(dsStaff.Tables[0]);
            crViewer1.ReportSource = rpt;
            this.Show();
        }
    }
}
