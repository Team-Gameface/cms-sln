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
        public VoucherViewer(DataSet ds, DataSet dsCoop, DataSet dsCharges)
        {
            InitializeComponent();
            rpt.SetDataSource(ds.Tables[0]);
            rpt.Subreports[0].SetDataSource(dsCoop.Tables[0]);
            rpt.Subreports[1].SetDataSource(dsCharges.Tables[0]);
            crViewer1.ReportSource = rpt;
            this.Show();
        }
    }
}
