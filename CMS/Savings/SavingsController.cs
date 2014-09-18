using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings
{
    public class SavingsController : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~SavingsController()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (savingsMenu != null)
                {
                    savingsMenu.Dispose();
                    savingsMenu = null;
                }
            }
        }

        SavingsMenu savingsMenu = new SavingsMenu();

        public SavingsController(SavingsMenu savingsMenu)
        {
            this.savingsMenu = savingsMenu;
            this.savingsMenu.setItemInterestRatesEventHandler(this.itemInterestRates);
            this.savingsMenu.setItemSavingsAccountTypesEventHandler(this.itemSavingsAccountTypes);
            this.savingsMenu.setItemTimeDepositWithdrawalEventHandler(this.itemTimeDepositWithdrawal);
            //trans
            this.savingsMenu.setItemOpenAccountEventHandler(this.itemOpenAccount);
            this.savingsMenu.setItemSavingsAccountTransEventHandler(this.itemSavingsAccountTrans);
            this.savingsMenu.setItemTimeDepositAppEventHandler(this.itemTimeDepositApp);
            this.savingsMenu.setItemTimeDepositWithEventHandler(this.itemTimeDepositWith);
            this.savingsMenu.setItemMemberTerminationEventHandler(this.itemMemberTermination);
            //queries
            this.savingsMenu.setItemStatementOfAccountEventHandler(this.itemStatementOfAccount);
            //reports
            this.savingsMenu.setItemDailyTransactionLogEventHandler(this.itemDailyTransactionLog);
            this.savingsMenu.SavingsMenu_FormClosing(this.formClosing);
            this.savingsMenu.ShowDialog();
        }
        
        public void itemInterestRates(object args, EventArgs e)
        {
            Maintenance.Controller.TimeDepositInterestRatesController interestRatesController = new Maintenance.Controller.TimeDepositInterestRatesController(new Maintenance.Model.TimeDepositInterestModel(), new Maintenance.View.TimeDepositInterestRates(), savingsMenu);
        }

        public void itemSavingsAccountTypes(object args, EventArgs e)
        {
            Maintenance.Controller.SavingsAccountTypeController savingsAccountTypeController = new Maintenance.Controller.SavingsAccountTypeController(new Maintenance.Model.SavingsAccountTypeModel(), new Maintenance.View.SavingsAccountType(), savingsMenu);
        }

        public void itemTimeDepositWithdrawal(object args, EventArgs e)
        {
            Maintenance.Controller.EarlyWithdrawalController timeDepositController = new Maintenance.Controller.EarlyWithdrawalController(new Maintenance.Model.EarlyWithdrawalModel(), new Maintenance.View.EarlyWithdrawal(), savingsMenu);
        }

        //trans
        public void itemOpenAccount(object args, EventArgs e)
        {
            Transaction.Controller.SavingsAccountController openAccountController = new Transaction.Controller.SavingsAccountController(new Transaction.Model.SavingsAccountModel(), new Transaction.View.SavingsAccount(), this.savingsMenu);
        }

        public void itemSavingsAccountTrans(object args, EventArgs e)
        {
            Transaction.Controller.SavingsTransactionController savingsTransactionController = new Transaction.Controller.SavingsTransactionController(new Transaction.Model.SavingsTransactionModel(), new Transaction.View.SavingsTransaction(), this.savingsMenu);
        }

        public void itemTimeDepositApp(object args, EventArgs e)
        {
            Transaction.Controller.TimeDepositController timeDepositController = new Transaction.Controller.TimeDepositController(new Transaction.Model.TimeDepositModel(), new Transaction.View.TimeDepositApplication(), this.savingsMenu);
        }

        public void itemTimeDepositWith(object args, EventArgs e)
        {
            Transaction.Controller.TimeDepositWithdrawalController timeDepositWithdrawalModel = new Transaction.Controller.TimeDepositWithdrawalController(new Transaction.Model.TimeDepositWithdrawalModel(), new Transaction.View.TimeDepositWithdrawal(), this.savingsMenu);
        }

        public void itemMemberTermination(object args, EventArgs e)
        {
            if (Main.UserData.userAccountType == "Staff")
            {
                new Transaction.View.PasswordAuthentication(this.savingsMenu).ShowDialog();
            }
            else
            {
                Transaction.Controller.TerminationController terminationController = new Transaction.Controller.TerminationController(new Transaction.Model.TerminationModel(), new Transaction.View.MemberTermination(), this.savingsMenu);
            }
        }

        //queries
        public void itemStatementOfAccount(object args, EventArgs e)
        {
            Queries.Controller.StatementOfAccountController statementOfAccountController = new Queries.Controller.StatementOfAccountController(new Queries.Model.StatementOfAccountModel(), new Queries.View.StatementOfAccount(), this.savingsMenu);
        }
        
        //reports
        public void itemAgingTimeDeposits(object args, EventArgs e)
        {
            //  Reports.Controller.DailyTransactionLogController dailyTransactionLogController = new Reports.Controller.DailyTransactionLogController(new Reports.Model.DailyTransactionLogModel(), new Reports.View.DailyTransactionLog(), this.savingsMenu);
        }
        public void itemDailyTransactionLog(object args, EventArgs e)
        {
            Reports.Controller.DailyTransactionLogController dailyTransactionLogController = new Reports.Controller.DailyTransactionLogController(new Reports.Model.DailyTransactionLogModel(), new Reports.View.DailyTransactionLog(), this.savingsMenu);
        }

        public void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            new Main.Controller.MainController(new Main.View.CMSDashboard());
        }
    }
}