using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CMS.Loan_Management.Queries.Controller
{
    class LoanStatusController
    {
        Queries.Model.LoanStatusModel loanStatusModel;
        Queries.View.LoanStatus loanStatus;
        Main.Logger logger = new Main.Logger();


        public LoanStatusController(Queries.Model.LoanStatusModel loanStatusModel, Queries.View.LoanStatus loanStatus, Loan_Management.LoanManagementMenu loanMenu)
        {
            this.loanStatusModel = loanStatusModel;
            this.loanStatus = loanStatus;
            this.loanStatus.MdiParent = loanMenu;
            this.loanStatus.setTxtAccountNoTextChangedEventHandler(txtAccountNo);
            this.loanStatus.setTxtAccountNameTextChangedEventHandler(txtAccountName);
            this.loanStatus.setDataGridLoanCellClickEventHandler(dataGridPayment);
            this.loanStatus.loanGrid(this.loanStatusModel.selectUnpaidLoans());
            this.loanStatus.setBtnCollateralEventHandler(btnCollateral);
            this.loanStatus.Show();
        }

        private void txtAccountNo(object sender, EventArgs e) 
        {

            String srch = loanStatus.getAccountNo();
            this.loanStatus.loanGrid(this.loanStatusModel.searchMemberLoan(srch));
        
        }

        private void txtAccountName(object sender, EventArgs e)
        {
            String srch = loanStatus.getAccountName();
            this.loanStatus.loanGrid(this.loanStatusModel.searchMemberLoanName(srch));
        }

        private void dataGridPayment(object sender, DataGridViewCellEventArgs e) {

            this.loanStatusModel.loanApplicationId = Convert.ToInt32(this.loanStatus.getSelected().Cells[0].Value.ToString());
            this.loanStatus.paymentGrid(this.loanStatusModel.selectPaymentsMade());
            DataTable ds = this.loanStatusModel.selectLoanStatus().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                this.loanStatus.setDateGranted(DateTime.Parse(dr[0].ToString()).ToShortDateString());
                this.loanStatus.setMaturity(DateTime.Parse(dr[1].ToString()).ToShortDateString());
                this.loanStatus.setLoanAmount(dr[2].ToString());

                bool isCleared = bool.Parse(dr[3].ToString());
                bool isAmnestied = bool.Parse(dr[4].ToString());

                if (isCleared)
                    this.loanStatus.setStatus("Cleared");
                else if (isAmnestied)
                    this.loanStatus.setStatus("Amnestied");
                else if (!(isCleared) && DateTime.Compare(DateTime.Now, DateTime.Parse(dr[1].ToString())) > 0)
                    this.loanStatus.setStatus("Delinquent");
                else
                    this.loanStatus.setStatus("Active");

                this.loanStatus.setAmortizations(this.loanStatusModel.selectAmortizationsPaid().Tables[0].Rows[0][0].ToString());
                //accountBalance insert here

                
                //
                this.loanStatus.enableCollaterals();
            }

        }


            public void btnCollateral (object sender, EventArgs e){
            
                Queries.Controller.CollateralComakerController CollateralComakerController = new CollateralComakerController(new Queries.Model.CollateralComakerModel(), new Queries.View.CollateralComaker(),this.loanStatusModel.loanApplicationId);
            
            }
        
    }
}
