using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Transaction.Controller
{
    class UpdateMemberController
    {
        Transaction.Model.UpdateMemberModel updateMemberModel;
        Transaction.View.UpdateMember updateMember;
        LoanManagementMenu loanManagementMenu;

        public UpdateMemberController(Transaction.Model.UpdateMemberModel updateMemberModel, Transaction.View.UpdateMember updateMember, Loan_Management.LoanManagementMenu loanManagementMenu)
        {
            this.updateMemberModel = updateMemberModel;
            this.updateMember = updateMember;
            this.updateMember.setTxtAccountNoEventHandler(this.btnSearch);
            this.updateMember.setTxtMemberNameEventHandler(this.btnSearch);
            this.updateMember.setBtnUpdateEventHandler(this.btnUpdate);
            this.updateMember.setBtnAddEventHandler(this.btnAdd);
            this.updateMember.MdiParent = loanManagementMenu;
            this.loanManagementMenu = loanManagementMenu;
            this.updateMember.setDataMembers(this.updateMemberModel.selectMember());
            this.updateMember.Show();
        }

        public void btnSearch(object args, EventArgs e)
        {
            if (this.updateMember.searchBy() == 0)
            {
                this.updateMember.setDataMembers(this.updateMemberModel.searchAccountNo(this.updateMember.getAccountNo()));
            }
            else
            {
                this.updateMember.setDataMembers(this.updateMemberModel.searchMemberName(this.updateMember.getMemberName()));
            }
        }

       

        public void btnUpdate(object args, EventArgs e)
        {
            DataGridViewRow dr = this.updateMember.getSelected();
            String acctNo = dr.Cells[0].Value.ToString();
            Transaction.Controller.MembershipApplicationController membershipApplicationController = new Transaction.Controller.MembershipApplicationController(new Transaction.Model.MembershipApplicationModel(), new Transaction.View.MembershipApplication(), acctNo, updateMemberModel, updateMember, loanManagementMenu);
        }

        public void btnAdd(object args, EventArgs e) {

            Transaction.Controller.MembershipApplicationController membershipController = new Transaction.Controller.MembershipApplicationController(new Transaction.Model.MembershipApplicationModel(), new Transaction.View.MembershipApplication(), updateMemberModel, updateMember, this.loanManagementMenu);
        
        }
    }
}
