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
            DataGridViewRow row = this.timeDepositWithdrawal.getSelected();
            this.timeDepositWithdrawalModel.CertificateNo = row.Cells[2].Value.ToString();
            String certNo = row.Cells[2].Value.ToString();
            double principal = double.Parse(row.Cells[3].Value.ToString());
            this.timeDepositWithdrawal.setDate(timeDepositWithdrawalModel.getStartDate(certNo).ToString());
            this.timeDepositWithdrawal.setDepositAmount(principal.ToString("N2", new CultureInfo("en-PH")));
            DateTime maturityDate = this.timeDepositWithdrawalModel.getMaturityDate(certNo);
            this.timeDepositWithdrawal.setMaturity(maturityDate.ToString());
            String status = "Pre-mature";
            if (maturityDate < DateTime.Now)
            {
                status = "Matured";
            }
            else
            {
                status = "Pre-Mature";
            }
            this.timeDepositWithdrawal.setStatus(status);
            int timeElapsed = Convert.ToInt32((DateTime.Now - timeDepositWithdrawalModel.getStartDate(certNo)).TotalDays);
            String converter = this.timeDepositWithdrawalModel.getInterest(timeElapsed, principal).ToString("#.##");
            double interest = 0.00;
            try
            {
                interest = Convert.ToDouble(converter);
            }
            catch (Exception) { }
            int noDays = Convert.ToInt32(this.timeDepositWithdrawalModel.getDaysElapsed(timeElapsed, principal));
            converter = (noDays / 360.00).ToString("#.##");
            double multiplier = 0.00;
            try
            {
                multiplier = Convert.ToDouble(converter);
            }
            catch (Exception) { }
            converter = (principal * (interest / 100.00) * multiplier).ToString("#.##");
            double interestEarned = 0.00;
            try
            {
                interestEarned = Convert.ToDouble(converter);
            }
            catch (Exception) { }
            this.timeDepositWithdrawal.setInterest(interestEarned.ToString("N2", new CultureInfo("en-PH")));
            if (status == "Matured")
            {
                this.timeDepositWithdrawal.setGross(Convert.ToDouble(principal + interestEarned).ToString("N2", new CultureInfo("en-PH")));
                this.timeDepositWithdrawal.setPenalty("0.00");
                this.timeDepositWithdrawal.setTotal(Convert.ToDouble(principal + interestEarned).ToString("N2", new CultureInfo("en-PH")));
            }
            else if (status == "Pre-Mature")
            {
                DateTime startDate = this.timeDepositWithdrawalModel.getStartDate(certNo);
                int TotalDays = Convert.ToInt32((maturityDate - startDate).TotalDays);
                converter = (Convert.ToDouble(timeElapsed) / Convert.ToDouble(TotalDays)).ToString("#.##");
                double timeElapsedPercent = 0.00;
                try
                {
                    timeElapsedPercent = Math.Round(Convert.ToDouble(converter), 2) * 100.00;
                }
                catch (Exception) { }
                converter = this.timeDepositWithdrawalModel.getPenalty(timeElapsedPercent).ToString("#.##");
                double penalty = 0.00;
                try
                {
                    penalty = Convert.ToDouble(converter);
                }
                catch (Exception) { }
                converter = (interest * (penalty / 100.00)).ToString("#.##");
                double penaltyValue = 0.00;
                try
                {
                    penaltyValue = Convert.ToDouble(converter);
                }
                catch (Exception) { }
                converter = (noDays / 360.00).ToString("#.##");
                try
                {
                    multiplier = Convert.ToDouble(converter);
                }
                catch (Exception) { }
                converter = (principal * (penaltyValue / 100.00) * multiplier).ToString("#.##");
                double penaltyAmount = 0.00;
                try
                {
                    penaltyAmount = Convert.ToDouble(converter);
                }
                catch (Exception) { }
                converter = (principal + interestEarned).ToString("#.##");
                this.timeDepositWithdrawal.setGross(Convert.ToDouble(converter).ToString("N2", new CultureInfo("en-PH")));
                this.timeDepositWithdrawal.setPenalty(penaltyAmount.ToString("N2", new CultureInfo("en-PH")));
                converter = (principal + (interestEarned - penaltyAmount)).ToString("N2", new CultureInfo("en-PH"));
                this.timeDepositWithdrawal.setTotal(Convert.ToDouble(converter).ToString("N2", new CultureInfo("en-PH")));
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
