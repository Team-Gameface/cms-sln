using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace CMS.Savings.Transaction.Controller
{
    class TimeDepositWithdrawalController
    {
        Model.TimeDepositWithdrawalModel timeDepositWithdrawalModel;
        View.TimeDepositWithdrawal timeDepositWithdrawal;

        public TimeDepositWithdrawalController(Model.TimeDepositWithdrawalModel timeDepositWithdrawalModel, View.TimeDepositWithdrawal timeDepositWithdrawal, SavingsMenu savingsMenu)
        {
            this.timeDepositWithdrawal = timeDepositWithdrawal;
            this.timeDepositWithdrawalModel = timeDepositWithdrawalModel;
            this.timeDepositWithdrawal.setDataTimeDeposit(this.timeDepositWithdrawalModel.selectTimeDeposit());
            this.timeDepositWithdrawal.txtAccountNo_TextChanged(this.txtAccountNo);
            this.timeDepositWithdrawal.txtMemberName_TextChanged(this.txtMemberName);
            this.timeDepositWithdrawal.txtCertificateNo_TextChanged(this.txtCertificateNo);
            this.timeDepositWithdrawal.dataTimeDeposit_CellContentClick(this.dataTimeDeposit);
            this.timeDepositWithdrawal.setBtnClearEventHandler(this.btnClear);
            this.timeDepositWithdrawal.setBtnSaveEventHandler(this.btnSave);
            this.timeDepositWithdrawal.MdiParent = savingsMenu;
            this.timeDepositWithdrawal.Show();
        }

        public void txtAccountNo(object sender, EventArgs e)
        {
            this.timeDepositWithdrawal.setDataTimeDeposit(this.timeDepositWithdrawalModel.searchTimeDepositAccountNo(this.timeDepositWithdrawal.getAccountNo()));
        }

        public void txtMemberName(object sender, EventArgs e)
        {
            this.timeDepositWithdrawal.setDataTimeDeposit(this.timeDepositWithdrawalModel.searchTimeDepositMemberName(this.timeDepositWithdrawal.getMemberName()));
        }

        public void txtCertificateNo(object sender, EventArgs e)
        {
            this.timeDepositWithdrawal.setDataTimeDeposit(this.timeDepositWithdrawalModel.searchTimeDepositCertificateNo(this.timeDepositWithdrawal.getCertificateNo()));
        }

        public void dataTimeDeposit(object sender, EventArgs e)
        {
            double interestRate = 0.00;
            double baseAmount = 0.00;
            double interestAmt = 0.00;
            double days = 0;
            double daysTenure = 0;
            double percentage = 0;
            int divisor = 0;
            double penaltyValue = 0.00;
            String penaltyStatus = String.Empty;
            double penaltyAmount = 0.00;
            double total = 0.00;
            
            DataGridViewRow row = this.timeDepositWithdrawal.getSelected();

            this.timeDepositWithdrawalModel.CertificateNo = row.Cells[2].Value.ToString();
            String certNo = row.Cells[2].Value.ToString();
            SqlDataReader dr = this.timeDepositWithdrawalModel.getTimeDepositDetails(certNo);
            while (dr.Read()) {
                this.timeDepositWithdrawal.setAccountType(dr[1].ToString());
                this.timeDepositWithdrawal.setDepositAmount(dr[2].ToString());
                this.timeDepositWithdrawal.setMaturity(dr[3].ToString());

                baseAmount = double.Parse(dr[2].ToString());
                if (dr[6].ToString().Equals("Annually"))
                    divisor = 365;
                else if (dr[6].ToString().Equals("Bi-Annually"))
                    divisor = 365*2;
                else if (dr[6].ToString().Equals("Semi-Annually"))
                    divisor = 365/2;
                else
                    divisor = 30;
                if ((DateTime.Today) >= DateTime.Parse(dr[3].ToString()))
                {
                    days = Convert.ToInt32((DateTime.Parse(dr[3].ToString()) - DateTime.Parse(dr[4].ToString())).TotalDays);
                    this.timeDepositWithdrawal.setStatus("Matured");
                }

                else
                {
                    days = Convert.ToInt32((DateTime.Now - DateTime.Parse(dr[4].ToString())).TotalDays);
                    this.timeDepositWithdrawal.setStatus("Pre - mature");
                    daysTenure = Convert.ToInt32((DateTime.Parse(dr[3].ToString()) - DateTime.Now).TotalDays);
                    percentage = (days / daysTenure) * 100;
                    SqlDataReader rdr = this.timeDepositWithdrawalModel.getPenalty(percentage, baseAmount);
                    while (rdr.Read()) {
                        penaltyValue = double.Parse(rdr[0].ToString());
                        penaltyStatus = rdr[1].ToString();                    
                    }
                }

                interestRate = double.Parse(dr[5].ToString());
                double multiplier = days/divisor;
                interestAmt = baseAmount * interestRate/100 * multiplier;

                this.timeDepositWithdrawal.setInterest(interestAmt.ToString("N2", CultureInfo.InvariantCulture));
                this.timeDepositWithdrawal.setGross((interestAmt + baseAmount).ToString("N2", CultureInfo.InvariantCulture));

                if (penaltyValue > 0)
                {
                    if (penaltyStatus == "%")
                        penaltyAmount = (interestAmt + baseAmount) * (penaltyValue / 100);
                    else
                        penaltyAmount = penaltyValue;


                
                }
                total = interestAmt + baseAmount - penaltyAmount;
                this.timeDepositWithdrawal.setPenalty(penaltyAmount.ToString("N2", CultureInfo.InvariantCulture));
                this.timeDepositWithdrawal.setTotal(total.ToString("N2",CultureInfo.InvariantCulture));

    
            
            }
        }

        public void btnClear(object sender, EventArgs e)
        {
            this.timeDepositWithdrawal.reset();
            this.timeDepositWithdrawal.setDataTimeDeposit(this.timeDepositWithdrawalModel.selectTimeDeposit());
        }

        public void btnSave(object sender, EventArgs e)
        {
            DataGridViewRow row = this.timeDepositWithdrawal.getSelected();
            
                this.timeDepositWithdrawalModel.Penalty = this.timeDepositWithdrawal.getPenalty();
                this.timeDepositWithdrawalModel.TotalAmount = this.timeDepositWithdrawal.getTotal();
                if (this.timeDepositWithdrawalModel.insertTimeDepositDetails() == 1)
                {
                    MessageBox.Show("Transaction Success", "Time Deposit Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.timeDepositWithdrawal.reset();
                    this.timeDepositWithdrawal.setDataTimeDeposit(this.timeDepositWithdrawalModel.selectTimeDeposit());
                }
                else
                {
                    MessageBox.Show("Transaction Failed", "Time Deposit Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           
        }
    }
}
