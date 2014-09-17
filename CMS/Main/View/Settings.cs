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
    public partial class Settings : UserControl
    {
        Controller.MainController mainController;
        View.CMSDashboard cms;

        public Boolean savingsOpen = false;
        public Boolean batchOpen = false;
        public Boolean companyProfileOpen = false;
        public Boolean userOpen = false;

        public Settings(Controller.MainController mainController, View.CMSDashboard cms)
        {
            InitializeComponent();
        }

        private void btnBatchProcess_Click(object sender, EventArgs e)
        {
            if (companyProfileOpen)
            {
                companyProfileOpen = false;
            }
            if (savingsOpen)
            {
                savingsOpen = false;
            }
            if (userOpen)
            {
                userOpen = false;
            }
            if (!batchOpen)
            {
                batchOpen = true;
                this.panelSettings.Controls.Clear();
                CMS.Settings.BatchProcessAutomation b = new CMS.Settings.BatchProcessAutomation(this);
                b.Dock = DockStyle.Fill;
                this.panelSettings.Controls.Add(b);
            }
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            if (batchOpen)
            {
                batchOpen = false;
            }
            if (savingsOpen)
            {
                savingsOpen = false;
            }
            if (userOpen)
            {
                userOpen = false;
            }
            if (!companyProfileOpen)
            {
                companyProfileOpen = true;
                this.panelSettings.Controls.Clear();
                CMS.Settings.CompanyProfile c = new CMS.Settings.CompanyProfile(this, this.cms);
                c.Dock = DockStyle.Fill;
                this.panelSettings.Controls.Add(c);
            }
        }

        private void btnSavingsSettings_Click(object sender, EventArgs e)
        {
            if (batchOpen)
            {
                batchOpen = false;
            }
            if (companyProfileOpen)
            {
                companyProfileOpen = false;
            }
            if (userOpen)
            {
                userOpen = false;
            }
            if (!savingsOpen)
            {
                savingsOpen = true;
                this.panelSettings.Controls.Clear();
                CMS.Settings.SavingsSettings s = new CMS.Settings.SavingsSettings(this);
                s.Dock = DockStyle.Fill;
                this.panelSettings.Controls.Add(s);
            }
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            if (batchOpen)
            {
                batchOpen = false;
            }
            if (companyProfileOpen)
            {
                companyProfileOpen = false;
            }
            if (savingsOpen)
            {
                savingsOpen = false;
            }
            if (!userOpen)
            {
                userOpen = true;
                this.panelSettings.Controls.Clear();
                CMS.Settings.UserManagement u = new CMS.Settings.UserManagement();
                u.Dock = DockStyle.Fill;
                this.panelSettings.Controls.Add(u);
            }
        }
    }
}
