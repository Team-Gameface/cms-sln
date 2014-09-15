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

        Main.Logger logger = new Main.Logger();
        Main.View.CMSDashboard cms;
        Main.View.PaymentForm paymentForm;
        Main.View.Utilities utilities;
        Main.View.Settings settings;
        public Boolean paymentOpen = false;
        public Boolean utilitiesOpen = false;
        public Boolean settingsOpen = false;

        public MainController(Main.View.CMSDashboard cms)
        {
            this.cms = cms;
            setUser();
            //this.cms.setBtnHomeEventHandler(this.btnHome);
            this.cms.setBtnLoanManagementEventHandler(this.btnLoanManagement);
            this.cms.setBtnPaymentsEventHandler(this.btnPayments);
            this.cms.setBtnSavingsEventHandler(this.btnSavings);
            this.cms.setBtnSettingsEventHandler(this.btnSettings);
            this.cms.setBtnUtitilitiesEventHandler(this.btnUtitilities);
            this.cms.setLinkSignOutEventHandler(this.linkSignout);
            this.cms.CMS_FormClosing(this.formClosing);
            this.updateMemberClass();
            this.cms.ShowDialog();
        }

        public void setUser()
        {
            if (Main.UserData.userAccountType != "Superuser")
            {
                this.cms.setUserName(Main.UserData.userLast + ", " + Main.UserData.userFirst);
            }
            else
            {
                this.cms.setUserName(Main.UserData.userPosition);
            }
            this.cms.setRole(Main.UserData.userAccountType);
            this.cms.setPictureUser();
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

        public void btnSavings(object args, EventArgs e)
        {
            this.Dispose();
            Savings.SavingsController savingsController = new Savings.SavingsController(new Savings.SavingsMenu());
        }

        public void btnPayments(object args, EventArgs e)
        {
            if (utilitiesOpen)
            {
                utilities.Dispose();
                utilitiesOpen = false;
            }
            if (settingsOpen)
            {
                settings.Dispose();
                settingsOpen = false;
            }
            if (!paymentOpen)
            {
                paymentOpen = true;
                paymentForm = new View.PaymentForm();
                paymentForm.Dock = DockStyle.Fill;
                Controller.PaymentController paymentController = new Controller.PaymentController(new Model.PaymentModel(), paymentForm, cms, this);
            }
        }

        public void btnUtitilities(object args, EventArgs e)
        {
            if (paymentOpen)
            {
                paymentForm.Dispose();
                paymentOpen = false;
            }
            if (settingsOpen)
            {
                settings.Dispose();
                settingsOpen = false;
            }
            if (!utilitiesOpen)
            {
                utilitiesOpen = true;
                utilities = new View.Utilities(this);
                utilities.Dock = DockStyle.Fill;
                this.cms.setPanel2(utilities);
            }
        }

        public void btnSettings(object args, EventArgs e)
        {
            if (paymentOpen)
            {
                paymentForm.Dispose();
                paymentOpen = false;
            }
            if (utilitiesOpen)
            {
                utilities.Dispose();
                utilitiesOpen = false;
            }
            if (!settingsOpen)
            {
                settingsOpen = true;
                settings = new View.Settings(this, this.cms);
                settings.Dock = DockStyle.Fill;
                this.cms.setPanel2(settings);
            }
        }

        public void linkSignout(object args, EventArgs e)
        {
            execLogger("User Log Out");
            Main.UserData.userId = String.Empty;
            Main.UserData.userFirst = String.Empty;
            Main.UserData.userMiddle = String.Empty;
            Main.UserData.userLast = String.Empty;
            Main.UserData.userPosition = String.Empty;
            Main.UserData.userAccountType = String.Empty;
            this.Dispose();
            new Login().ShowDialog();
        }

        public void formClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("You will be logged out of the system. Continue?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                execLogger("User Log Out");
                Main.UserData.userId = String.Empty;
                Main.UserData.userFirst = String.Empty;
                Main.UserData.userMiddle = String.Empty;
                Main.UserData.userLast = String.Empty;
                Main.UserData.userPosition = String.Empty;
                Main.UserData.userAccountType = String.Empty;
                this.Dispose();
                new Login().ShowDialog();
            }
            else
            {
                e.Cancel = true;
            }
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "CMS Dashboard";
            logger.Activity = ModuleActivity;
            if (logger.insertLog() > 0)
            {
                Console.WriteLine("Logged");
            }
            else
            {
                Console.WriteLine("Not Logged");
            }
        }
    }
}
