using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Main.View
{
    public partial class Utilities : UserControl
    {
        Controller.MainController mainController;
        View.CMS cms;
        public Boolean batchOpen = false;
        public Boolean companyProfileOpen = false;

        public Utilities(Controller.MainController mainController, View.CMS cms)
        {
            this.mainController = mainController;
            this.cms = cms;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            mainController.utilitiesOpen = false;
        }

        private void btnBatchProcess_Click(object sender, EventArgs e)
        {
            if (!batchOpen)
            {
                batchOpen = true;
                new BatchProcessAutomation(this).Show();
            }
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            if (!companyProfileOpen)
            {
                companyProfileOpen = true;
                new CompanyProfile(this, cms).Show();
            }
        }
    }
}
