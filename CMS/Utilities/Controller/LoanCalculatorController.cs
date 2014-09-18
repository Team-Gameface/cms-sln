using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Utilities.Controller
{
    class LoanCalculatorController
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ LoanCalculatorController()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (loanCalc != null)
                {
                    loanCalc.Dispose();
                    loanCalc = null;
                }
            }
        }

        View.LoanCalculator loanCalc;
        Model.LoanCalculatorModel loanCalcModel;
        Main.View.Utilities utilities;

        public LoanCalculatorController(View.LoanCalculator loanCalc, Model.LoanCalculatorModel loanCalcModel, Main.View.Utilities utilities)
        {
            this.loanCalc = loanCalc;
            this.loanCalcModel = loanCalcModel;
            this.utilities = utilities;
            this.loanCalc.setFormClosing(this.formClosing);
            this.loanCalc.setBtnCompute(this.btnCompute);
            this.loanCalc.setBtnClear(this.btnClear);
            this.loanCalc.addItemsAtTypeOfLoan(this.loanCalcModel.selectLoanType());
            this.loanCalc.cbLoanTypeSelectedIndexChanged(this.loanTypeSelected);
            this.loanCalc.clearFields();
            loanCalc.Show();
        }

        public void formClosing(object sender, EventArgs e)
        {
            utilities.LoanCalcOpen = false;
            this.Dispose();
        }

        public void loanTypeSelected(object args, EventArgs e)
        {
            int i = this.loanCalc.getCBLoanTypeIndex();
            if (i == -1) 
            { 
                this.loanCalc.setStatePaymentDurationFalse(); 
            }
            else
            {
                int selectedLoanTypeId = this.loanCalc.getTypeOfLoan();
                String paymentDuration = this.loanCalcModel.selectPaymentDuration(selectedLoanTypeId);
                String[] newPD = paymentDuration.Split(' ');
                String finalPD = "";
                for (int ii = 0; ii < newPD.Count(); ii++)
                {
                    if (newPD[ii] == "0") { newPD[ii] = ""; }
                    finalPD += newPD[ii] + " ";
                }

                this.loanCalc.setLblPaymentDuration(finalPD);
            }
        }

        public void btnCompute(object sender, EventArgs e) 
        {
            this.loanCalc.setLabelsToBlack();
            int loanTypeId = this.loanCalc.getTypeOfLoan();
            double loanAmount = this.loanCalc.getLoanAmount();
            int value = this.loanCalc.getPaymentDurationValue();
            String duration= this.loanCalc.getDurationStatus();
            String terms = this.loanCalc.getTermsOfPayment();
            int error = 0;
            if (loanTypeId == -1) 
            {
                error++;
                this.loanCalc.lblLoanType.ForeColor = System.Drawing.Color.Red;
            }

            if (loanAmount == 0) 
            {
                error++;
                this.loanCalc.lblAmount.ForeColor = System.Drawing.Color.Red;
            }

            if (value == 0) 
            {
                error++;
                this.loanCalc.lblDuration.ForeColor = System.Drawing.Color.Red; 
            }
            
            if (duration.Equals(String.Empty)) 
            {
                error++;
                this.loanCalc.lblDuration.ForeColor = System.Drawing.Color.Red;
            }

            if (terms.Equals(String.Empty)) 
            {
                error++;
                this.loanCalc.lblTerms.ForeColor = System.Drawing.Color.Red;
            }

            try
            {
                if (duration == "month/s") { value *= 4; }
                else if (duration == "year/s") { value *= 48; }
                String[] s = this.loanCalc.getLblPaymentDuration().Split(' ');

                if (this.loanCalc.lblStatePaymentDuration.Text.Contains("infinity"))
                {
                    if (value < int.Parse(s[0])) 
                    {
                        error++;
                        this.loanCalc.lblDuration.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    if (value < int.Parse(s[0]) || value > int.Parse(s[1])) 
                    {
                        error++;
                        this.loanCalc.lblDuration.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception) 
            {
                error++;
                this.loanCalc.lblDuration.ForeColor = System.Drawing.Color.Red;
            }

            if (error == 0) 
            {
                int noOfAmortizations = 0;
                DateTime maturityDate = this.loanCalc.getDateOfApproval();
                value = this.loanCalc.getPaymentDurationValue();
                
                if (duration == "week/s")
                {
                    noOfAmortizations = value;
                    maturityDate = maturityDate.AddDays(value * 7);
                }
                else if (duration == "month/s")
                {
                    maturityDate = maturityDate.AddMonths(value);
                    if (terms == "weekly")
                    {
                        for (DateTime startDate = this.loanCalc.getDateOfApproval().AddDays(7); startDate <= maturityDate; startDate = startDate.AddDays(7))
                        {
                            noOfAmortizations++;
                        }
                    }
                    else if (terms == "monthly") { noOfAmortizations = value; }
                }
                else if (duration == "year/s")
                {
                    maturityDate = maturityDate.AddYears(value);
                    if (terms == "weekly")
                    {
                        for (DateTime startDate = this.loanCalc.getDateOfApproval().AddDays(7); startDate <= maturityDate; startDate = startDate.AddDays(7))
                        {
                            noOfAmortizations++;
                        }
                    }
                    else if (terms == "monthly") { noOfAmortizations = value * 12; }
                    else if (terms == "quarterly") { noOfAmortizations = value * 3; }
                    else if (terms == "semi-annually") { noOfAmortizations = value * 2; }
                    else if (terms == "annually") { noOfAmortizations = value; }
                }

                this.loanCalc.setMaturityDate(maturityDate.ToString("MM/dd/yyyy"));

                //amortization amount
                double amortizationAmt = loanAmount / noOfAmortizations;
                this.loanCalc.setNoOfAmortizations(noOfAmortizations);
                this.loanCalc.setAmortizationAmount(amortizationAmt);

                this.loanCalc.setLoanReceivable(loanAmount);
                this.loanCalc.setCharge(this.loanCalcModel.selectCharges(loanTypeId));

                String ir = this.loanCalcModel.selectInterestRate(loanTypeId);
                double interest = 0;

                if (ir != String.Empty)
                {
                    String[] interestRate = ir.Split(' ');
                    if (interestRate[1] == "Php")
                    {
                        if (duration == "week/s")
                        {
                            interest = (double.Parse(interestRate[0]) / 52) * value;
                        }
                        else if (duration == "month/s")
                        {
                            interest = (double.Parse(interestRate[0]) / 12) * value;
                        }
                        else if (duration == "year/s")
                        {
                            interest = double.Parse(interestRate[0]) * value;
                        }
                    }
                    else if (interestRate[1] == "%")
                    {
                        if (duration == "week/s")
                        {
                            interest = loanAmount * (((double.Parse(interestRate[0]) / 100) / 52) * value);
                        }
                        else if (duration == "month/s")
                        {
                            interest = loanAmount * (((double.Parse(interestRate[0]) / 100) / 12) * value);
                        }
                        else if (duration == "year/s")
                        {
                            interest = loanAmount * (double.Parse(interestRate[0]) / 100) * value;
                        }
                    }
                }
                else { interest = 0; }

                this.loanCalc.setInterest(interest);
            }
        }

        public void btnClear(object sender, EventArgs e) 
        {
            this.loanCalc.clearFields();
            this.loanCalc.setLabelsToBlack();
        }
    }
}
