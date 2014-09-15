using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.View
{
    public partial class SavingsTermination : Form
    {
        String AccountNo = String.Empty;
        Main.Logger logger = new Main.Logger();
        Transaction.View.SavingsAccount savingsAccount;
        Transaction.Model.SavingsAccountModel savingsAccountModel;

        public SavingsTermination(String AccountNo, Transaction.View.SavingsAccount savingsAccount, Transaction.Model.SavingsAccountModel savingsAccountModel)
        {
            this.AccountNo = AccountNo;
            this.savingsAccount = savingsAccount;
            this.savingsAccountModel = savingsAccountModel;
            InitializeComponent();
            disableFields();
            setData();
        }

        public void disableFields()
        {
            txtAccountNo.Enabled = false;
            txtBalance.Enabled = false;
            txtAccountType.Enabled = false;
            dataSavingsAccount.Enabled = false;
            txtSpecify.Enabled = false;
        }

        private void radioOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOthers.Checked == true)
            {
                txtSpecify.Clear();
                txtSpecify.Enabled = true;
            }
            else
            {
                txtSpecify.Clear();
                txtSpecify.Enabled = false;
            }
        }

        public void setData()
        {
            txtAccountNo.Text = AccountNo;
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT s.Balance, st.SavingsTypeName FROM SAVINGS_ACCOUNT s INNER JOIN SAVINGS_ACCOUNT_TYPE st ON s.AccountTypeId = st.AccountTypeId WHERE SavingsAccountNo = @AccountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", this.AccountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            while (read.Read())
            {
                txtBalance.Text = read[0].ToString();
                txtAccountType.Text = read[1].ToString();
            }
            read.Close();
            sql = "SELECT m.AccountNo, CONCAT(m.FirstName, ' ', m.MiddleName, ' ', m.LastName) AS 'Member Name' FROM MEMBER m INNER JOIN MEMBER_SAVINGS_ACCOUNT ms ON m.AccountNo = ms.MemberAccountNo WHERE SavingsAccountNo = @AccountNo";
            DataSet ds = dal.executeDataSet(sql, parameters);
            dataSavingsAccount.DataSource = ds.Tables[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            String reason = String.Empty;
            if (radioReCreate.Checked == true)
            {
                reason = radioReCreate.Text;
                check = true;
            }
            if (radioVoluntary.Checked == true)
            {
                reason = radioVoluntary.Text;
                check = true;
            }
            if (radioForced.Checked == true)
            {
                reason = radioForced.Text;
                check = true;
            }
            if (radioOthers.Checked == true)
            {
                if (txtSpecify.Text != String.Empty)
                {
                    reason = txtSpecify.Text;
                    check = true;
                }
                else
                {
                    MessageBox.Show("Please Specify Reason of Termination.", "Savings Account Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblSpecify.ForeColor = Color.Red;
                    lblSpecify.Focus();
                }
            }
            if (check)
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "UPDATE SAVINGS_ACCOUNT SET Balance = 0, Status = 0 WHERE SavingsAccountNo = @AccountNo";
                Dictionary<String, Object> parameters = new Dictionary<string, object>();
                parameters.Add("@AccountNo", this.AccountNo);
                int result = dal.executeNonQuery(sql, parameters);
                if (result == 1)
                {
                    sql = "EXEC insertSavingsTermination @AccountNo, @Reason, @TerminationDate";
                    parameters.Add("@Reason", reason);
                    parameters.Add("@TerminationDate", dateTermination.Value.ToString());
                    result = dal.executeNonQuery(sql, parameters);
                }
                if (result == 1)
                {
                    int withdraw = withdrawSavings();
                    if (withdraw == 1)
                    {
                        setPassbookInactive();
                    }
                    MessageBox.Show("Termination Success.", "Savings Account Termination", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Terminate - " + this.AccountNo);
                    this.savingsAccount.setDataAccount(this.savingsAccountModel.selectSavingsAccount());
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Termination Failed.", "Savings Account Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Specify Reason of Termination.", "Savings Account Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int withdrawSavings()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertSavingsTransaction @SavingsAccountNo, @TransactionMode, @Amount, @Representative, @SavingsPassbook, @userId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@SavingsAccountNo", this.AccountNo);
            parameters.Add("@TransactionMode", "Withdraw");
            parameters.Add("@Amount", txtBalance.Text);
            parameters.Add("@Representative", "");
            parameters.Add("@SavingsPassbook", this.selectActivePassbook());
            parameters.Add("@userId", Main.UserData.userId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result == 1)
            {
                String sql2 = "UPDATE SAVINGS_ACCOUNT SET Balance = 0.00 WHERE SavingsAccountNo = @AccountNo";
                Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
                parameters2.Add("@AccountNo", this.AccountNo);
                dal.executeNonQuery(sql2, parameters2);
            }
            return result;
        }

        public int selectActivePassbook()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT SavingsPassbookNo FROM MEMBER_SAVINGS_PASSBOOK WHERE SavingsAccountNo = @accountNo AND Status = 1";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", this.AccountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            return i;
        }

        public void setPassbookInactive()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE MEMBER_SAVINGS_PASSBOOK SET Status = 0 WHERE SavingsPassbookNo = @PassbookNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@PassbookNo", this.selectActivePassbook());
            dal.executeNonQuery(sql, parameters);
        }
        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Transaction - Savings Account";
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
