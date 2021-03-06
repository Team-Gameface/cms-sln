﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings
{
    public partial class SavingsMenu : Form
    {
        public SavingsMenu()
        {
            InitializeComponent();
            setAccess();
        }

        public void setAccess()
        {
            if (Main.UserData.userAccountType == "Staff")
            {
                menuMaintenance.Dispose();
            }
        }

        public void setItemSavingsAccountTypesEventHandler(EventHandler e)
        {
            this.itemSavingsAccountTypes.Click += e;
        }

        public void setItemInterestRatesEventHandler(EventHandler e)
        {
            this.itemInterestRates.Click += e;
        }

        public void setItemTimeDepositWithdrawalEventHandler(EventHandler e)
        {
            this.itemTimeDepositWithdrawal.Click += e;
        }

        //trans

        public void setItemOpenAccountEventHandler(EventHandler e)
        {
            this.itemOpenAccount.Click += e;
        }

        public void setItemSavingsAccountTransEventHandler(EventHandler e)
        {
            this.itemSavingsAccountTrans.Click += e;
        }

        public void setItemTimeDepositAppEventHandler(EventHandler e)
        {
            this.itemTimeDepositApp.Click += e;
        }

        public void setItemTimeDepositWithEventHandler(EventHandler e)
        {
            this.itemTimeDepositWith.Click += e;
        }

        public void setItemMemberTerminationEventHandler(EventHandler e)
        {
            this.itemMemberTermination.Click += e;
        }

        public void setItemDailyTransactionLogEventHandler(EventHandler e)
        {
            this.itemDailyTransactionLog.Click += e;
        }
     
        public void setItemStatementOfAccountEventHandler(EventHandler e)
        {
            this.itemStatementOfAccount.Click += e;
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            statusDateTime.Text = DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToString("h:mm:ss tt"); 
        }

        public void SavingsMenu_FormClosing(FormClosingEventHandler e)
        {
            this.FormClosing += e;
        }
    }
}

