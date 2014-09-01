using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Main.Controller
{
    public class MainController
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~MainController()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (cms != null)
                {
                    cms.Dispose();
                    cms = null;
                }
                if (paymentForm != null)
                {
                    paymentForm.Dispose();
                    paymentForm = null;
                }
                if (utilities != null)
                {
                    utilities.Dispose();
                    utilities = null;
                }
            }
        }

        Main.View.CMS cms;
        Main.View.PaymentForm paymentForm;
        Main.View.Utilities utilities;
        public Boolean paymentOpen = false;
        public Boolean utilitiesOpen = false;

        public MainController(Main.View.CMS cms)
        {
            this.cms = cms;
            this.cms.setUserName(Main.UserData.userName);
            this.cms.setRole(Main.UserData.userAccountType);
            //this.cms.setBtnHomeEventHandler(this.btnHome);
            this.cms.setBtnLoanManagementEventHandler(this.btnLoanManagement);
            this.cms.setBtnPaymentsEventHandler(this.btnPayments);
            this.cms.setBtnSavingsEventHandler(this.btnSavings);
            this.cms.setBtnSettingsEventHandler(this.btnSettings);
            this.cms.setLinkSignOutEventHandler(this.linkSignout);
            this.cms.CMS_FormClosing(this.formClosing);
            this.updateMemberClass();
            this.cms.ShowDialog();
        }

        /*public void btnHome(object args, EventArgs e)
        {
            
        }*/

        public void updateMemberClass()
        {
            
        }

        public void btnLoanManagement(object args, EventArgs e)
        {
            this.Dispose();
            Loan_Management.LoanManagementController loanController = new Loan_Management.LoanManagementController(new Loan_Management.LoanManagementMenu());
        }

        public void btnPayments(object args, EventArgs e)
        {
            if (utilitiesOpen)
            {
                utilities.Dispose();
                utilitiesOpen = false;
            }
            if (!paymentOpen)
            {
                paymentOpen = true;
                paymentForm = new View.PaymentForm();
                Controller.PaymentController paymentController = new Controller.PaymentController(new Model.PaymentModel(), paymentForm, cms, this);
            }
        }

        public void btnSavings(object args, EventArgs e)
        {
            this.Dispose();
            Savings.SavingsController savingsController = new Savings.SavingsController(new Savings.SavingsMenu());
        }

        public void btnSettings(object args, EventArgs e)
        {
            if (paymentOpen)
            {
                paymentForm.Dispose();
                paymentOpen = false;
            }
            if (!utilitiesOpen)
            {
                utilitiesOpen = true;
                utilities = new View.Utilities(this);
                this.cms.setPanel2(utilities);
            }
        }

        public void linkSignout(object args, EventArgs e)
        {
            Main.UserData.userFirst = String.Empty;
            Main.UserData.userLast = String.Empty;
            Main.UserData.userMiddle = String.Empty;
            Main.UserData.userName = String.Empty;
            Main.UserData.userAccountType = String.Empty;
            this.Dispose();
            new Login().ShowDialog();
        }

        public void formClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("You will be logged out of the system. Continue?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Main.UserData.userFirst = String.Empty;
                Main.UserData.userLast = String.Empty;
                Main.UserData.userMiddle = String.Empty;
                Main.UserData.userName = String.Empty;
                Main.UserData.userAccountType = String.Empty;
                this.Dispose();
                new Login().ShowDialog();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
