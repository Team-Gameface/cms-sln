using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Threading.Tasks;

namespace CMS.Loan_Management.Transaction.Controller
{
    class ShareCapitalContributionController
    {

        Loan_Management.Transaction.View.ShareCapitalContribution shareCapitalContribution;
        Loan_Management.Transaction.Model.ShareCapitalContributionModel shareModel;


        public ShareCapitalContributionController(Loan_Management.Transaction.Model.ShareCapitalContributionModel shareModel, Loan_Management.Transaction.View.ShareCapitalContribution shareCapitalContribution, Loan_Management.LoanManagementMenu loanMenu)
        {
            this.shareModel = shareModel;
            this.shareCapitalContribution = shareCapitalContribution;
            this.shareCapitalContribution.setTbAcctNameEventHandler(this.btnSearch);
            this.shareCapitalContribution.setTbAcctNoEventHandler(this.btnSearch);
            this.shareCapitalContribution.setTbDepAmtEventHandler(this.showBalance);
            this.shareCapitalContribution.setBtnSaveEventHandler(this.btnSave);
            this.shareCapitalContribution.setBtnClearEventHandler(this.btnClear);
            this.shareCapitalContribution.shareGrid(this.shareModel.selectMembers());
            this.shareCapitalContribution.MdiParent = loanMenu;
            this.shareCapitalContribution.clearAllFields();
            this.shareCapitalContribution.Show();
        }

        public void btnSearch(object sender, EventArgs e) 
        {

            String term = this.shareCapitalContribution.getSearch();

            if (this.shareCapitalContribution.getSearchType())
                this.shareCapitalContribution.shareGrid(this.shareModel.searchMemberByName(term));
            else
                this.shareCapitalContribution.shareGrid(this.shareModel.searchMemberByAccount(term));

        }


        public void btnClear(object sender, EventArgs e)
        {
            this.shareCapitalContribution.shareGrid(this.shareModel.selectMembers());
            this.shareCapitalContribution.clearAllFields();

        }

        public void showBalance(object sender, EventArgs e) {
            
            Double amt = 0.00;
            Double currBal = 0.00;
            try
            {
                currBal = Double.Parse(this.shareCapitalContribution.getSelected().Cells["Balance"].Value.ToString(), NumberStyles.Currency);
            }
            catch (Exception) { }
            amt = this.shareCapitalContribution.getAmount();
            if (amt > 0.00)
            {
                this.shareCapitalContribution.setBalance(currBal + amt);
                this.shareCapitalContribution.isZeroAmount(false);
            }
            else
                this.shareCapitalContribution.isZeroAmount(true);
        
        }

        public void btnSave(object sener, EventArgs e) {

            DataGridViewRow selectedData = this.shareCapitalContribution.getSelected();
            this.shareModel.accountNo = selectedData.Cells["Account No."].Value.ToString();
            this.shareModel.amount = this.shareCapitalContribution.getAmount();

            bool insertError = false;

            if (this.shareCapitalContribution.getAmount() == 0) {
                insertError = true;
                MessageBox.Show("Please enter an amount.", "Share Capital Contribution", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (!insertError)
                if (this.shareModel.insertContribution() == 1) {

                MessageBox.Show("Transaction Successful!", "Share Capital Contribution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.shareCapitalContribution.shareGrid(this.shareModel.selectMembers());
                this.shareCapitalContribution.clearAllFields();
                }
                
                else
                    MessageBox.Show("Transaction Failed!", "Share Capital Contribution", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        
        }


    }
}
