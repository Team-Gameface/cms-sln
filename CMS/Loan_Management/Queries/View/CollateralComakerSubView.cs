using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Loan_Management.Queries.View
{
    public partial class CollateralComaker : Form
    {
        public CollateralComaker()
        {
            InitializeComponent();
        }

        public void comakerGrid(DataSet ds)
        {
            this.dataGridComaker.DataSource = ds.Tables[0];
        }

        public void collateralGrid(DataSet ds)
        {
            this.dataGridCollateral.DataSource = ds.Tables[0];
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
