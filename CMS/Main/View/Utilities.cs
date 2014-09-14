using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Main.View
{
    public partial class Utilities : UserControl
    {
        Controller.MainController main;

        bool LoanCalcOpen = false;
        bool TDCalcOpen = false;
        bool accountOpen = false;
        bool auditOpen = false;

        public Utilities(Controller.MainController main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void btnLoanCalc_Click(object sender, EventArgs e)
        {
            if (!LoanCalcOpen)
            {
                LoanCalcOpen = true;
                //openLoanCalcForm
            }
        }

        private void btnTimeDepositCalc_Click(object sender, EventArgs e)
        {
            if (!TDCalcOpen)
            {
                TDCalcOpen = true;
                //openTDCalcForm
            }
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            if (accountOpen)
            {
                accountOpen = false;
            }
            if (!auditOpen)
            {
                auditOpen = true;
                panelUtilities.Controls.Clear();
                CMS.Utilities.View.AuditLog a = new CMS.Utilities.View.AuditLog();
                a.Dock = DockStyle.Fill;
                panelUtilities.Controls.Add(a);
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (auditOpen)
            {
                auditOpen = false;
            }
            if (!accountOpen)
            {
                accountOpen = true;
                panelUtilities.Controls.Clear();
                CMS.Utilities.View.AccountSettings a = new CMS.Utilities.View.AccountSettings();
                a.Dock = DockStyle.Fill;
                CMS.Utilities.Controller.AccountSettingsController asc = new CMS.Utilities.Controller.AccountSettingsController(a, this, this.main);
            }
        }

        public void setUtilities(UserControl uc)
        {
            this.panelUtilities.Controls.Add(uc);
        }
    }
}
