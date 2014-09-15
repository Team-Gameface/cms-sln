using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CMS.Savings.Queries.Controller
{
    class StatementOfAccountController
    {
        Model.StatementOfAccountModel statementOfAccountModel;
        View.StatementOfAccount statementOfAccount;

        public StatementOfAccountController(Model.StatementOfAccountModel statementOfAccountModel, View.StatementOfAccount statementOfAccount, SavingsMenu savingsMenu)
        {
            this.statementOfAccountModel = statementOfAccountModel;
            this.statementOfAccount = statementOfAccount;
            this.statementOfAccount.setDataMember(this.statementOfAccountModel.selectMember());
            this.statementOfAccount.dataMember_CellContentClick(this.dataMemberCellClick);
            this.statementOfAccount.setBtnSearchEventHandler(this.btnSearch);
            this.statementOfAccount.setTxtAccountNoEventHandler(this.txtAccountNo);
            this.statementOfAccount.setTxtmemberNameEventHandler(this.txtMemberName);
            this.statementOfAccount.MdiParent = savingsMenu;
            this.statementOfAccount.Show();
        
        }

        private void dataMemberCellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.statementOfAccount.getSelectedMember();
            if (row == null)
            {
                MessageBox.Show("No row selected.");
            }
            else
            {
                this.statementOfAccount.setAccountNo(row.Cells[0].Value.ToString());
                this.statementOfAccount.setAccountType(row.Cells[2].Value.ToString());
                this.statementOfAccount.setBalance(row.Cells[5].Value.ToString());
                String depositors = row.Cells[4].Value.ToString().Replace(";", " " + row.Cells[3].Value.ToString() + " ");
                this.statementOfAccount.setAccountHolders(depositors.ToUpper());
                this.statementOfAccount.setDataTransactions(this.statementOfAccountModel.selectTransactions(row.Cells[0].Value.ToString()));
            }
        }

        private void txtAccountNo(object sender, EventArgs e)
        { 
                this.statementOfAccount.setDataMember(this.statementOfAccountModel.searchAccount(statementOfAccount.getSearchAccount()));        
        }

        private void txtMemberName(object sender, EventArgs e)
        {
            this.statementOfAccount.setDataMember(this.statementOfAccountModel.searchMemberName(statementOfAccount.getSearchMember()));
        }


        private void btnSearch(object sender, EventArgs e)
        {

            if (statementOfAccount.getSearchType())
                this.statementOfAccount.setDataMember(this.statementOfAccountModel.searchAccount(statementOfAccount.getSearchAccount()));
            else
                this.statementOfAccount.setDataMember(this.statementOfAccountModel.searchMemberName(statementOfAccount.getSearchMember()));

        }

        private void btnPreview(object sender, EventArgs e)
        {

           
        }


        private void btnPassbook(object sender, EventArgs e)
        {


        }

    }
}
