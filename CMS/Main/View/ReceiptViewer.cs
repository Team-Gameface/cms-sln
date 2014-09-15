using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Main.View
{
    public partial class ReceiptViewer : Form
    {
        PaymentReceipt rpt = new PaymentReceipt();
        public ReceiptViewer(DataSet ds, DataSet dsCoop)
        {
            InitializeComponent();
            rpt.SetDataSource(ds.Tables[0]);
            rpt.Subreports[0].SetDataSource(dsCoop.Tables[0]);
            crViewer1.ReportSource = rpt;
            this.Show();
        }
    }
}
