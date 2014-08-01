using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.View
{
    public partial class TerminationPayment : Form
    {
        View.MemberTermination termination;
        Model.TerminationModel terminationModel;
        String accountNo = String.Empty;
        String reason = String.Empty;
        String details = String.Empty;
        double netRefunds = 0;

        public TerminationPayment(String accountNo, String reason, String details, double netRefunds, View.MemberTermination termination, Model.TerminationModel terminationModel)
        {
            InitializeComponent();
            this.termination = termination;
            this.terminationModel = terminationModel;
            this.accountNo = accountNo;
            this.reason = reason;
            this.details = details;
            this.netRefunds = netRefunds;
            setDetails();
        }

        public void setDetails()
        {
            txtAccountNo.Text = this.accountNo;
            txtLoanBalance.Text = this.netRefunds.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (this.terminationModel.insertTermination(reason, details, accountNo) == 1)
            {
                if (this.terminationModel.clearLoans(accountNo) == 1)
                {
                    MessageBox.Show("Member Termination Success.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.termination.classGridSearch(this.terminationModel.selectActiveMember());
                    this.termination.clearFields();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Clear Loans Failed.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Member Termination Failed.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
