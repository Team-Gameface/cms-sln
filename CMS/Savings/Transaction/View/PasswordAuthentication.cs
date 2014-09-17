using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.View
{
    public partial class PasswordAuthentication : Form
    {
        String AccountNo = String.Empty;
        Main.Logger logger = new Main.Logger();
        Transaction.View.SavingsAccount savingsAccount;
        Transaction.Model.SavingsAccountModel savingsAccountModel;
        SavingsMenu savingsMenu;
        String accessModule = String.Empty;

        public PasswordAuthentication(SavingsMenu savingsMenu)
        {
            accessModule = "Member";
            this.savingsMenu = savingsMenu;
            InitializeComponent();
        }

        public PasswordAuthentication(String AccountNo, Transaction.View.SavingsAccount savingsAccount, Transaction.Model.SavingsAccountModel savingsAccountModel)
        {
            accessModule = "Savings";
            this.AccountNo = AccountNo;
            this.savingsAccount = savingsAccount;
            this.savingsAccountModel = savingsAccountModel;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == selectManagerPassword())
            {
                if (accessModule == "Savings")
                {
                    new View.SavingsTermination(AccountNo, this.savingsAccount, this.savingsAccountModel).Show();
                    this.Dispose();
                }
                else if (accessModule == "Member")
                {
                    Transaction.Controller.TerminationController terminationController = new Transaction.Controller.TerminationController(new Transaction.Model.TerminationModel(), new Transaction.View.MemberTermination(), this.savingsMenu);
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Savings Termination", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public String selectManagerPassword()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT Password FROM SYSTEM_USERS WHERE UserType = 'Manager'";
            SqlDataReader read = dal.executeReader(sql);
            String password = String.Empty;
            while (read.Read())
            {
                password = read[0].ToString();
            }
            return password;
        }
    }
}
