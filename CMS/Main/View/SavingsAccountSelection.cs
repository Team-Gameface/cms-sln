using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Main.View
{
    public partial class SavingsAccountSelection : Form
    {
        Main.Logger logger = new Logger();
        Model.PaymentModel paymentModel;
        double amount = 0;

        public SavingsAccountSelection(Model.PaymentModel paymentModel, DataSet ds, double amount)
        {
            this.paymentModel = paymentModel;
            this.amount = amount;
            InitializeComponent();
            setComboSavingsAccount(ds);
        }

        public void setComboSavingsAccount(DataSet ds)
        {
            this.comboSavingsAccount.DataSource = ds.Tables[0];
            this.comboSavingsAccount.DisplayMember = "SavingsAccountNo";
            this.comboSavingsAccount.ValueMember = "SavingsAccountNo";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.comboSavingsAccount.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Savings Account.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                String savingsAccount = this.comboSavingsAccount.SelectedValue.ToString();
                if (this.paymentModel.insertSavingsTransaction(savingsAccount, amount) > 0)
                {
                    MessageBox.Show("Deposit Success.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    execLogger("Added Savings from OR# '" + this.paymentModel.ORNo + "'");
                    this.Dispose();
                }
            }
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Payment";
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
