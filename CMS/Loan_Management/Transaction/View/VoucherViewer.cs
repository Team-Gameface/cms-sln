using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Loan_Management.Transaction.View
{
    public partial class VoucherViewer : Form
    {
        LoanVoucher rpt = new LoanVoucher();
        public VoucherViewer(DataSet ds, DataSet dsCoop, DataSet dsCharges, DataSet dsStaff,DataSet dsManager,DataSet dsCreditChair)
        {
            InitializeComponent();
            rpt.SetDataSource(ds.Tables[0]);
            rpt.Subreports["CompanyHeader"].SetDataSource(dsCoop.Tables[0]);
            rpt.Subreports["Charges"].SetDataSource(dsCharges.Tables[0]);
            rpt.Subreports["StaffSub"].SetDataSource(dsStaff.Tables[0]);
            rpt.Subreports["ManagerSub"].SetDataSource(dsManager.Tables[0]);
            rpt.Subreports["ChairSub"].SetDataSource(dsCreditChair.Tables[0]);
            crViewer1.ReportSource = rpt;
            this.Show();
        }
    }
}
