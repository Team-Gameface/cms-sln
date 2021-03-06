﻿using System;
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

        public bool LoanCalcOpen = false;
        public bool TDCalcOpen = false;
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
                CMS.Utilities.Controller.LoanCalculatorController tdCalcController = new CMS.Utilities.Controller.LoanCalculatorController(new CMS.Utilities.View.LoanCalculator(), new CMS.Utilities.Model.LoanCalculatorModel(), this);
            }
        }

        private void btnTimeDepositCalc_Click(object sender, EventArgs e)
        {
            if (!TDCalcOpen)
            {
                TDCalcOpen = true;
                CMS.Utilities.Controller.TimeDepositCalculatorController tdCalcController = new CMS.Utilities.Controller.TimeDepositCalculatorController(new CMS.Utilities.View.TimeDepositCalculator(), new CMS.Utilities.Model.TimeDepositCalculatorModel(), this);
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
                CMS.Utilities.Controller.AuditLogController alc = new CMS.Utilities.Controller.AuditLogController(a, new CMS.Utilities.Model.AuditLogModel(), this);
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
