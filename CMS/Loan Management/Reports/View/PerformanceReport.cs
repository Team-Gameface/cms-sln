using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Loan_Management.Reports.View
{
    public partial class PerformanceReport : Form
    {
        public PerformanceReport()
        {
            InitializeComponent();
            numReportYear.Value = Convert.ToInt32(DateTime.Today.Year);
            numReportYear.Maximum = Convert.ToInt32(DateTime.Today.Year);
        }


        public void setBtnPreviewEventHandler (EventHandler e){

            this.btnPreview.Click += e;
        
        }

        public int getYear() {

            try
            {
                return Convert.ToInt32(numReportYear.Value);
            }
            catch (Exception) { return 0; }
        }


    }
}
