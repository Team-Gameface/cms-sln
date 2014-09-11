using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Reports.View
{
    public partial class DailyTransactionLogViewer : Form
    {

        DailyTransactionLogReport rpt = new DailyTransactionLogReport();

        public DailyTransactionLogViewer(DataSet ds, Dictionary<String, Object> parameters)
        {
            InitializeComponent();
            setSource(ds);
            foreach (KeyValuePair<String, Object> row in parameters)
            {
                try
                {
                    rpt.SetParameterValue(row.Key, row.Value);
                }
                catch (Exception) { }
            }
            this.Show();
        }

        public void setSource(DataSet ds) {

            rpt.SetDataSource(ds.Tables[0]);
            crViewer1.ReportSource = rpt;
        
        
        }

    }
}
