using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace CMS.Main.Controller
{
    class PaymentController : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~PaymentController()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (payment != null)
                {
                    payment.Dispose();
                    payment = null;
                    paymentModel = null;
                }
                if (paymentModel != null)
                {
                    paymentModel.Dispose();
                    paymentModel = null;
                }
            }
        }

        Model.PaymentModel paymentModel;
        View.PaymentForm payment;
        MainController mainController;
        Main.Logger logger = new Logger();
        Dictionary<int, string> fees = new Dictionary<int, string>();

        double totalPenalty = 0;
        double totalInterest = 0;
        Boolean hasInterest = false;

        public PaymentController(Model.PaymentModel paymentModel, View.PaymentForm payment, Main.View.CMSDashboard cms, MainController mainController)
        {
            this.paymentModel = paymentModel;
            this.payment = payment;
            this.mainController = mainController;
            cms.setPanel2(this.payment);
            this.payment.setBtnClearEventHandler(this.btnClear);
            this.payment.setBtnMoveAllEventHandler(this.btnMoveAll);
            this.payment.setBtnMoveBackAllEventHandler(this.btnMoveBackAll);
            this.payment.setBtnMoveBackSelectedEventHandler(this.btnMoveBackSelected);
            this.payment.setBtnMoveSelectedEventHandler(this.btnMoveSelected);
            this.payment.setBtnSaveEventHandler(this.btnSave);
            this.payment.dataAmortization_CellValueChanged(this.showPenalties);
            this.payment.txtAmountDue_TextChanged(this.showTotalAmortization);
            this.payment.txtInterest_TextChanged(this.showTotalAmortization);
            this.payment.txtPenalty_TextChanged(this.showTotalAmortization);
            this.payment.txtAccountNo_TextChanged(this.searchMember);
            this.payment.txtMemberName_TextChanged(this.searchMember);
            this.payment.classGridSearch(this.paymentModel.selectActiveMembershipUnpaid());
            if (this.paymentModel.checkEmpty != 0) this.payment.noRowsSelected();
            this.paymentModel.checkEmpty = 0;
            this.payment.clearLoanFields();
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


        public void listOfFees()
        {

            fees.Clear();
            DataTable ds = this.paymentModel.selectFees().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                fees.Add(int.Parse(dr["Fee Id"].ToString()), dr["Description"].ToString());

            }
        }

        public void showTotalAmortization(object args, EventArgs e) 
        {
            double amountdue = this.payment.getAmountDue();
            double penalty = this.payment.getPenalty();
            double interest = this.payment.getInterest();

            this.payment.setTotalAmortization(amountdue + penalty + interest);
        }

        public void showPenaltiesWithoutEvent() 
        {
            totalPenalty = 0;
            totalInterest = 0;

            this.payment.clearTendered();
            this.payment.resetLoanAmortizationAmount();
            this.payment.clearPenaltyList();
            this.payment.setPenalty(0);
            this.payment.setInterest(0);

            double lastInterest = this.paymentModel.selectLastInterest(Convert.ToInt32(this.payment.dataAmortization.Rows[0].Cells[4].Value));

            if (lastInterest != 0)
            {
                totalInterest += lastInterest;
            }
                 Dictionary<String, int> listOfInterestDates = new Dictionary<String, int>();
                Dictionary<String, int> finalListOfInterestDates = new Dictionary<String, int>();
                int lappId = Convert.ToInt32(this.payment.dataAmortization.Rows[0].Cells[4].Value);
                String maturityDate = this.paymentModel.selectMaturityDate(lappId);
                String interestDate = (DateTime.Parse(maturityDate).AddDays(1)).ToString();
                String[] interest = this.paymentModel.selectInterestPerLoanType(this.payment.getTypeOfLoan()).Split(' ');

                if (DateTime.Now > DateTime.Parse(maturityDate) && interest[0] != "")
                {
                    String interestRateStatus = interest[0];
                    double interestRate = Convert.ToDouble(interest[1]);
                    String per = interest[2];

                    if (interestRateStatus == "%") { interestRate *= 0.01; }


                    if (per == "month")
                    {
                        for (String a = interestDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(1)).ToString())
                        {
                            listOfInterestDates.Add(a, 0);
                        }

                        foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                        {
                            String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                            String secondDate = DateTime.Parse(pair.Key).AddMonths(1).ToString();
                            int i = this.paymentModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

                            if (i > 0)
                            {
                                finalListOfInterestDates.Add(pair.Key, 0);
                            }
                        }

                        String last = String.Empty;
                        try
                        {
                            last = finalListOfInterestDates.Keys.Last();
                        }
                        catch (Exception) { last = maturityDate; }
                        foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                        {
                            if (DateTime.Parse(pair.Key) > DateTime.Parse(last))
                            {
                                hasInterest = true;
                                double finalInterest = 0;
                                double grantedLoanAmount = this.paymentModel.selectGrantedLoanAmount(lappId);
                                String[] paymentDur = this.paymentModel.selectPaymentDurationPerApplication(lappId).Split(' ');
                                int pdValue = int.Parse(paymentDur[0]);
                                String pdStatus = paymentDur[1];
                                if (interestRateStatus == "%")
                                {
                                    if (pdStatus == "week/s")
                                    {
                                        finalInterest = grantedLoanAmount * ((interestRate / 4) * pdValue);
                                    }
                                    else if (pdStatus == "month/s")
                                    {
                                        finalInterest = grantedLoanAmount * interestRate * pdValue;
                                    }
                                    else if (pdStatus == "year/s")
                                    {
                                        finalInterest = grantedLoanAmount * interestRate * 12 * pdValue;
                                    }
                                }

                                else if (interestRateStatus == "Php")
                                {
                                    if (pdStatus == "week/s")
                                    {
                                        finalInterest = (interestRate / 4) * pdValue;
                                    }
                                    else if (pdStatus == "month/s")
                                    {
                                        finalInterest = interestRate * pdValue;
                                    }
                                    else if (pdStatus == "year/s")
                                    {
                                        finalInterest = interestRate * 12 * pdValue;
                                    }
                                }
                                totalInterest += finalInterest;
                                this.payment.setPenaltyList("Interest Rate: " + pair.Key + "- Php " + finalInterest);
                            }
                        }

                    }

                    else if (per == "annum")
                    {
                        for (String a = interestDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddYears(1)).ToString())
                        {
                            listOfInterestDates.Add(a, 0);
                        }

                        foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                        {
                            String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                            String secondDate = DateTime.Parse(pair.Key).AddYears(1).ToString();
                            int i = this.paymentModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

                            if (i > 0)
                            {
                                finalListOfInterestDates.Add(pair.Key, 0);
                            }
                        }

                        String last = String.Empty;
                        try
                        {
                            last = finalListOfInterestDates.Keys.Last();
                        }
                        catch (Exception) { last = maturityDate; }
                        foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                        {
                            if (DateTime.Parse(pair.Key) > DateTime.Parse(last))
                            {
                                hasInterest = true;
                                double finalInterest = 0;
                                double grantedLoanAmount = this.paymentModel.selectGrantedLoanAmount(lappId);
                                String[] paymentDur = this.paymentModel.selectPaymentDurationPerApplication(lappId).Split(' ');
                                int pdValue = int.Parse(paymentDur[0]);
                                String pdStatus = paymentDur[1];
                                if (interestRateStatus == "%")
                                {
                                    if (pdStatus == "week/s")
                                    {
                                        finalInterest = grantedLoanAmount * ((interestRate / 52) * pdValue);
                                    }
                                    else if (pdStatus == "month/s")
                                    {
                                        finalInterest = grantedLoanAmount * ((interestRate / 12) * pdValue);
                                    }
                                    else if (pdStatus == "year/s")
                                    {
                                        finalInterest = grantedLoanAmount * interestRate * pdValue;
                                    }
                                }
                                else if (interestRateStatus == "Php")
                                {
                                    if (pdStatus == "week/s")
                                    {
                                        finalInterest = (interestRate / 52) * pdValue;
                                    }
                                    else if (pdStatus == "month/s")
                                    {
                                        finalInterest = (interestRate / 12) * pdValue;
                                    }
                                    else if (pdStatus == "year/s")
                                    {
                                        finalInterest = interestRate * pdValue;
                                    }
                                }
                                totalInterest += finalInterest;
                                this.payment.setPenaltyList("Interest Rate: " + pair.Key + "- Php " + finalInterest.ToString("N", CultureInfo.InvariantCulture));
                            }
                        }
                    }
                }

                if (this.payment.getIfPenaltyListIsEmpty("Interest Rate"))
                {
                    this.payment.setPenaltyList("No interest.");
                }


            this.payment.setInterest(totalInterest);

            this.payment.setPenaltyList("");
            this.payment.setPenaltyList("PENALTY:");
            int appId = Convert.ToInt32(this.payment.dataAmortization.Rows[0].Cells[4].Value);
            double lastPenalty = this.paymentModel.selectLastPenalty(appId);
            if (lastPenalty != 0)
            {
                DataSet penaltySet = this.paymentModel.selectAmortizationWithPenalty(appId);
                for (int i = 0; i < penaltySet.Tables[0].Rows.Count; i++)
                {
                    int lastAmoId = this.paymentModel.selectAmortizationId(appId, this.payment.dataAmortization.Rows[0].Cells[3].Value.ToString());
                    int amoId = Convert.ToInt32(penaltySet.Tables[0].Rows[i][0]);
                    double penalty = this.paymentModel.selectAmortizationPenalty(amoId);
                    this.payment.setPenaltyList("Amortization #" + (Convert.ToInt32(this.payment.dataAmortization.Rows[0].Cells[1].Value) - (lastAmoId - amoId)) + " - Php " + penalty.ToString("N", CultureInfo.InvariantCulture));
                }

                totalPenalty += lastPenalty;
            }

            foreach (DataGridViewRow rows in this.payment.dataAmortization.Rows)
            {
                DataGridViewCheckBoxCell chk1 = rows.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chk1.Value) == true)
                {

                    int loanApplicationId = int.Parse(rows.Cells[4].Value.ToString());
                    DataSet ds2 = this.paymentModel.selectMonthlyAmortization(loanApplicationId);
                    double monthlyAmortization = double.Parse(ds2.Tables[0].Rows[0][0].ToString());
                    String loanDurationStatus = ds2.Tables[0].Rows[0][1].ToString();
                    if (loanDurationStatus == "week/s") { monthlyAmortization *= 4; }
                    else if (loanDurationStatus == "year/s") { monthlyAmortization /= 12; }
                    double grantedLoanAmount = this.paymentModel.selectGrantedLoanAmount(loanApplicationId);
                    double remainingBalance = this.paymentModel.selectRemainingBalance(loanApplicationId);

                    String dueDate = rows.Cells[3].Value.ToString();

                    double amortizationAmount = double.Parse(rows.Cells[2].Value.ToString());
                    int loanTypeId = this.payment.getTypeOfLoan();
                    DataSet ds = this.paymentModel.selectPenaltiesPerLoanType(loanTypeId);
                    if (ds.Tables[0].Rows.Count == 0 || DateTime.Parse(dueDate) > DateTime.Now)
                    {
                        this.payment.setPenalty(0);
                        this.payment.setLoanAmortizationAmount(amortizationAmount);
                        this.payment.setPenaltyList("Amortization #" + rows.Cells[1].Value.ToString() + " - Php 0.00");
                    }

                    else
                    {
                        double finalPenalty = 0;
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            double initialPenalty = 0;
                            String finalDate = String.Empty;
                            String penaltyName = ds.Tables[0].Rows[i][0].ToString();
                            int gracePeriod = int.Parse(ds.Tables[0].Rows[i][1].ToString());
                            double amount = double.Parse(ds.Tables[0].Rows[i][2].ToString());
                            String amountStatus = ds.Tables[0].Rows[i][3].ToString();
                            String deductTo = ds.Tables[0].Rows[i][4].ToString();
                            int duration = int.Parse(ds.Tables[0].Rows[i][5].ToString());
                            String durationStatus = ds.Tables[0].Rows[i][6].ToString();

                            if (durationStatus == "week/s") { duration = duration * 7; }
                            //TimeSpan diffDate = DateTime.Now.Subtract(DateTime.Parse(dueDate));
                            //int totalDays = (int)diffDate.TotalDays;
                            //totalDays -= gracePeriod;
                            String newDate = (DateTime.Parse(dueDate).AddDays(gracePeriod)).ToString();

                            if (amountStatus == "%") { amount = amount * 0.01; }

                            finalDate = DateTime.Parse(newDate).AddDays(1).ToString();

                            if (deductTo == "monthly amortization")
                            {
                                if (durationStatus == "month/s")
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                    {
                                        initialPenalty = amount * monthlyAmortization;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                                else
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                    {
                                        initialPenalty = amount * monthlyAmortization;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                            }
                            else if (deductTo == "remaining balance")
                            {
                                if (durationStatus == "month/s")
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                    {
                                        initialPenalty = amount * remainingBalance;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                                else
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                    {
                                        initialPenalty = amount * remainingBalance;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                            }
                            else if (deductTo == "granted loan amount")
                            {
                                if (durationStatus == "month/s")
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                    {
                                        initialPenalty = amount * grantedLoanAmount;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                                else
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                    {
                                        initialPenalty = amount * grantedLoanAmount;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                            }

                            else if (deductTo == String.Empty)
                            {
                                if (durationStatus == "month/s")
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                    {
                                        initialPenalty = amount;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                                else
                                {
                                    for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                    {
                                        initialPenalty = amount;
                                        finalPenalty += initialPenalty;
                                        totalPenalty += initialPenalty;
                                    }
                                }
                            }
                        }//end for loop

                        this.payment.setPenaltyList("Amortization #" + rows.Cells[1].Value.ToString() + " - Php " + finalPenalty.ToString("N", CultureInfo.InvariantCulture));

                        if (this.payment.getIfPenaltyListIsEmpty("Amortization #" + rows.Cells[1].Value.ToString()))
                        {
                            this.payment.setPenaltyList("Amortization #" + rows.Cells[1].Value.ToString() + " - Php 0.00");
                        }


                        this.payment.setLoanAmortizationAmount(amortizationAmount);

                    }//end else
                }
            }
            this.payment.setPenalty(totalPenalty);
        }


        public void showPenalties(object args, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowsCount = this.payment.dataAmortization.Rows.Count-1;
                if ((this.payment.getPayAll() && (Boolean)(this.payment.dataAmortization.Rows[rowsCount].Cells[0] as DataGridViewCheckBoxCell).Value == true) || !this.payment.getPayAll()) { this.showPenaltiesWithoutEvent(); }
            }
        }
    


        public void btnClear(object args, EventArgs e) 
        {
            if (this.payment.getPaymentType() == "Miscellaneous") 
            {
                this.payment.clearMiscellaneousFields();
            }
            else
            this.payment.clearLoanFields();
        }

        public void btnMoveAll(object args, EventArgs e) {
            this.payment.moveAllRows();
        }

        public void btnMoveBackAll(object args, EventArgs e) {
            this.payment.moveBackAllRows();
        }
        public void btnMoveBackSelected(object args, EventArgs e) {
            this.payment.moveBackSelectedRow();
        }
        public void btnMoveSelected(object args, EventArgs e) {
            this.payment.moveSelectedRow();
        }
        public void btnSave(object args, EventArgs e) {
            String paymentType = this.payment.getPaymentType();

            if (paymentType == "Miscellaneous")
            {
                this.listOfFees();
                DataGridViewRow selectedData = this.payment.getSelected();
                String accountNo = selectedData.Cells["Account No."].Value.ToString();
                double amount = this.payment.getTotalAmount();

                int isFullyPaid = this.payment.getTotalNoOfFees();

                if (isFullyPaid == 0) { isFullyPaid = 1; }
                else { isFullyPaid = 0; }

                ArrayList feeList = this.payment.getFees();

                ArrayList feeId = new ArrayList();
                foreach (String s in feeList)
                {
                    foreach (KeyValuePair<int, string> pair in fees)
                    {
                        if (s.Equals(pair.Value))
                            feeId.Add(pair.Key);
                    }
                }


                if (this.paymentModel.insertPayment(paymentType, amount, accountNo, isFullyPaid, feeId) == 1)
                {
                    DataSet ds;
                    ds = paymentModel.getReceiptDetails(this.paymentModel.ORNo);
                    View.ReceiptViewer reciptViewer = new View.ReceiptViewer(ds, paymentModel.getCompanyProfile("dtLogo"));

                    MessageBox.Show("Transaction successful.", "Miscellaneous Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Processed Miscellaneous - OR# '" + this.paymentModel.ORNo + "'");
                    this.payment.classGridSearch(this.paymentModel.selectActiveMembershipUnpaid());
                    this.payment.totAmt = 0.00;
                    this.payment.clearMiscellaneousFields();
                }
                else
                {
                    MessageBox.Show("Transaction failed.", "Miscellaneous Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                DataGridViewRow selectedDataLoan = this.payment.getSelectedLoan();
                String accountNo = selectedDataLoan.Cells["Account No."].Value.ToString();
                double amount = this.payment.getTotalAmortization();
                double paidAmount = this.payment.getAmountTendered();
                double amountDue = this.payment.getAmountDue();
                double nadagdag = 0;
                double amortizationAmount = this.payment.getLoanAmortizationAmount();
                double interest = this.payment.getInterest();
                double penalty = this.payment.getPenalty();
                double toInterest = 0, toPenalty = 0;
                double change = this.payment.getChange();
                double slBalance = this.payment.getSLTotalLoanBalance();
                double slPenalty = this.payment.getSLTotalPenalties();
                double slInterest = this.payment.getSLTotalInterest();
                Boolean check = false;
                this.paymentModel.amountPaid = paidAmount;
                int isfullyPaid = 0;

                if (this.payment.getDeductToNextAmortization())
                {
                    foreach (DataGridViewRow rows in this.payment.dataAmortization.Rows)
                    {
                        if ((Boolean)(rows.Cells[0] as DataGridViewCheckBoxCell).Value == false)
                        {
                            if (change >= double.Parse(rows.Cells[2].Value.ToString()))
                            {
                                MessageBox.Show("Change is still >= of unchecked amortization amount. Please check them.","Loan Payment",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                check = true;
                                break;
                            }
                        }
                    }
                }

                if(!check)
                {
                    if (this.payment.getIfPenaltyListIsEmpty("Amnestied") == true)
                    {

                        if (amortizationAmount == 0)
                        {
                            if (amount > paidAmount)
                            {
                                String penInt = this.paymentModel.deductPenaltyAndInterest(paidAmount, accountNo, this.payment.getTypeOfLoan(), this.payment.getLoanMaturityDate());
                                String[] pi = penInt.Split(' ');
                                toPenalty += double.Parse(pi[0]);
                                toInterest += double.Parse(pi[1]);
                            }
                            else
                            {
                                this.paymentModel.clearLoan(accountNo, this.payment.getTypeOfLoan(), this.payment.getLoanMaturityDate());
                                isfullyPaid = 1;
                                toPenalty += penalty;
                                toInterest += interest;
                            }
                        }

                        else if (amortizationAmount != 0 && paidAmount < amortizationAmount)
                        {
                            interest = 0;
                            penalty = 0;
                            //update amortization amount
                            double pAmount = paidAmount;

                            foreach (DataGridViewRow rows in this.payment.dataAmortization.Rows)
                            {
                                if ((Boolean)(rows.Cells[0] as DataGridViewCheckBoxCell).Value == true)
                                {
                                    double amoAmount = Convert.ToDouble(rows.Cells[2].Value);
                                    if (pAmount > 0)
                                    {
                                        if (pAmount >= amoAmount)
                                        {
                                            this.paymentModel.updateAmortizationAmount(Convert.ToDouble(rows.Cells[2].Value), Convert.ToInt32(rows.Cells[4].Value), rows.Cells[3].Value.ToString());
                                            pAmount -= amoAmount;
                                        }
                                        else
                                        {
                                            this.paymentModel.updateAmortizationAmount(amoAmount - pAmount, Convert.ToInt32(rows.Cells[4].Value), rows.Cells[3].Value.ToString());
                                            pAmount = 0;
                                        }
                                    }
                                }
                            }
                        }

                        else if (amortizationAmount != 0 && paidAmount < amount && paidAmount >= amortizationAmount)
                        {
                            double piAmount = paidAmount - amortizationAmount;
                            //less sa penalty
                            //insert sa LOAN_AMORTIZATION.Penalty or LOAN_INFORMATION.Interest

                            foreach (DataGridViewRow rows in this.payment.dataAmortization.Rows)
                            {
                                if ((Boolean)(rows.Cells[0] as DataGridViewCheckBoxCell).Value == true)
                                {
                                    double penaltyAmount = this.payment.getAmountPenaltyList(int.Parse(rows.Cells[1].Value.ToString()));
                                    if (piAmount > 0)
                                    {
                                        if (penaltyAmount > piAmount) { penaltyAmount -= piAmount; toPenalty += piAmount; piAmount = 0; this.paymentModel.insertAmortizationPenalty(penaltyAmount, Convert.ToInt32(rows.Cells[4].Value), rows.Cells[3].Value.ToString()); }
                                        else { piAmount -= penaltyAmount; toPenalty += penaltyAmount; }
                                    }
                                    else if (piAmount == 0)
                                    {
                                        this.paymentModel.insertAmortizationPenalty(penaltyAmount, Convert.ToInt32(rows.Cells[4].Value), rows.Cells[3].Value.ToString());
                                    }

                                }
                            }

                            if (piAmount > 0)
                            {
                                double inte = interest;
                                inte -= piAmount;
                                toInterest += piAmount;
                                this.paymentModel.insertLoanInterest(inte, Convert.ToInt32(this.payment.dataAmortization.Rows[0].Cells[4].Value));
                            }
                            else
                            {
                                this.paymentModel.insertLoanInterest(interest, Convert.ToInt32(this.payment.dataAmortization.Rows[0].Cells[4].Value));
                            }
                        }

                        else
                        {
                            toInterest = interest;
                            toPenalty = penalty;

                            if (paidAmount >= amount && this.payment.getDeductToNextAmortization() == false)
                            {
                                nadagdag = paidAmount - amount;
                                this.paymentModel.updateLoanInterest(Convert.ToInt32(this.payment.dataAmortization.Rows[0].Cells[4].Value));
                            }
                            if (this.payment.getDeductToNextAmortization())
                            {
                                this.paymentModel.updateLoanInterest(Convert.ToInt32(this.payment.dataAmortization.Rows[0].Cells[4].Value));
                            }
                        }
                    }

                    /*foreach (DataGridViewRow rows in this.payment.dataAmortization.Rows)
                    {
                        if ((Boolean)(rows.Cells[0] as DataGridViewCheckBoxCell).Value == true)
                        {
                            double penaltyAmount = this.payment.getAmountPenaltyList(int.Parse(rows.Cells[1].Value.ToString()));
                            this.paymentModel.insertPenaltyAmount(penaltyAmount, Convert.ToInt32(rows.Cells[4].Value), rows.Cells[3].Value.ToString());
                        }
                    }*/

                    if (this.payment.getIfPenaltyListIsEmpty("Amnestied") == false)
                    {
                        int ORNo = 0;
                        int rowCount = this.payment.dataAmortization.Rows.Count - 1;
                        foreach (DataGridViewRow rows in this.payment.dataAmortization.Rows)
                        {
                            if (this.payment.dataAmortization.Rows.Count == 1) { ORNo = this.paymentModel.insertLoanPayment(paymentType, accountNo, Convert.ToInt32(rows.Cells[4].Value), amountDue, interest, penalty, rows.Cells[3].Value.ToString(), hasInterest, 1, 0); }
                            else if (rows.Index == rowCount) { this.paymentModel.insertLoanPayment(paymentType, accountNo, Convert.ToInt32(rows.Cells[4].Value), amountDue, interest, penalty, rows.Cells[3].Value.ToString(), hasInterest, 1, 0); }
                            else { ORNo = this.paymentModel.insertLoanPayment(paymentType, accountNo, Convert.ToInt32(rows.Cells[4].Value), amountDue, interest, penalty, rows.Cells[3].Value.ToString(), hasInterest, 1, 1); }
                            this.paymentModel.insertAmortizationPayment(ORNo, Convert.ToInt32(rows.Cells[4].Value), rows.Cells[3].Value.ToString(), double.Parse(rows.Cells[2].Value.ToString()));
                        }
                    }
                    else
                    {
                        int ORNo = 0;
                        double pAmount = paidAmount;

                        if (amortizationAmount == 0)
                        {
                            ORNo = this.paymentModel.insertRemainingPayment(paymentType, accountNo, this.payment.getTypeOfLoan(), this.payment.getLoanMaturityDate(), toPenalty, toInterest, hasInterest, isfullyPaid);
                        }

                        else
                        {
                            foreach (DataGridViewRow rows in this.payment.dataAmortization.Rows)
                            {
                                if ((Boolean)(rows.Cells[0] as DataGridViewCheckBoxCell).Value == true)
                                {
                                    double amoAmount = double.Parse(rows.Cells[2].Value.ToString());
                                    if (pAmount > 0 && amoAmount <= pAmount)
                                    {
                                        if (pAmount == paidAmount)
                                        {
                                            ORNo = this.paymentModel.insertLoanPayment(paymentType, accountNo, Convert.ToInt32(rows.Cells[4].Value), pAmount - nadagdag - toInterest - toPenalty, toInterest, toPenalty, rows.Cells[3].Value.ToString(), hasInterest, 1, 0);
                                        }
                                        else { this.paymentModel.insertLoanPayment(paymentType, accountNo, Convert.ToInt32(rows.Cells[4].Value), pAmount - nadagdag - toInterest - toPenalty, toInterest, toPenalty, rows.Cells[3].Value.ToString(), hasInterest, 1, 1); }
                                        this.paymentModel.insertAmortizationPayment(ORNo, Convert.ToInt32(rows.Cells[4].Value), rows.Cells[3].Value.ToString(), amoAmount);
                                        pAmount -= amoAmount;
                                    }
                                    else if (pAmount > 0 && amoAmount > pAmount)
                                    {
                                        if (pAmount == paidAmount) { ORNo = this.paymentModel.insertLoanPayment(paymentType, accountNo, Convert.ToInt32(rows.Cells[4].Value), pAmount, toInterest, toPenalty, rows.Cells[3].Value.ToString(), false, 0, 0); }
                                        else { this.paymentModel.insertLoanPayment(paymentType, accountNo, Convert.ToInt32(rows.Cells[4].Value), pAmount, toInterest, toPenalty, rows.Cells[3].Value.ToString(), false, 0, 1); }
                                        this.paymentModel.insertAmortizationPayment(ORNo, Convert.ToInt32(rows.Cells[4].Value), rows.Cells[3].Value.ToString(), pAmount);
                                        pAmount = 0;
                                    }
                                }
                            }


                        }
                    }

                    if (this.payment.getDeductToNextAmortization() == true)
                    {
                        double excessAmount = this.payment.getAmortizationChange();
                        this.paymentModel.deductToNextAmortization(excessAmount, Convert.ToInt32(this.payment.dataAmortization.Rows[0].Cells[4].Value));
                        execLogger("Deducted next amortization from OR# '" + this.paymentModel.ORNo + "'");

                    }

                    if (this.payment.getAddToSavings() == true)
                    {
                        double excessAmount = this.payment.getAmortizationChange();
                        if (this.paymentModel.countSavingsAccount(accountNo) > 1)
                        {
                            new View.SavingsAccountSelection(this.paymentModel, this.paymentModel.selectSavingsAccounts(accountNo), excessAmount);
                        }
                        else
                        {
                            String savingsAccountNo = this.paymentModel.selectSavingsAccount(accountNo);
                            int result = this.paymentModel.insertSavingsTransaction(savingsAccountNo, excessAmount);
                            if (result > 0)
                            {
                                execLogger("Added Savings from OR# '" + this.paymentModel.ORNo + "'");
                            }
                        }
                    }

                    if (this.payment.getAddToShareCapital() == true)
                    {
                        double excessAmount = this.payment.getAmortizationChange();
                        int result = this.paymentModel.insertContribution(accountNo, excessAmount);
                        if (result > 0)
                        {
                            execLogger("Added Share Capital from OR# '" + this.paymentModel.ORNo + "'");
                        }

                    }

                    String[] bal = this.paymentModel.selectMaxOR().Split(' ');
                    double recentAmt = double.Parse(bal[0]);
                    double recentPen = double.Parse(bal[1]);
                    double recentInt = double.Parse(bal[2]);

                    this.paymentModel.insertPaymentBalance(this.paymentModel.ORNo, slBalance - recentAmt, slPenalty - recentPen, slInterest - recentInt);
                    DataSet ds;
                    ds = paymentModel.getReceiptDetails(this.paymentModel.ORNo);
                    View.ReceiptViewer receiptViewer = new View.ReceiptViewer(ds, paymentModel.getCompanyProfile("dtLogo"));

                    MessageBox.Show("Transaction successful.", "Amortization Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Processed Loan Payment - OR# '" + this.paymentModel.ORNo + "'");
                    this.payment.classGridLoanSearch(this.paymentModel.selectActiveMemberWithLoan());
                    this.payment.clearLoanFields();
                    totalPenalty = 0;
                    totalInterest = 0;
                }
            }
        }

        public void searchMember(object args, EventArgs e) {
            
            bool getSearchType = this.payment.getSearchType();
            String paymentType = this.payment.getPaymentType();

            if (paymentType == "Miscellaneous")
            {

                if (getSearchType)
                {
                    this.payment.classGridSearch(this.paymentModel.searchMemberByName(this.payment.getSearch()));
                    this.payment.clearSelectionDataSearch();
                }

                else
                {
                    this.payment.classGridSearch(this.paymentModel.searchMemberByAccount(this.payment.getSearch()));
                    this.payment.clearSelectionDataSearch();
                }
            }
            else 
            {
                if (getSearchType)
                {
                    this.payment.classGridLoanSearch(this.paymentModel.searchMemberByLName(this.payment.getSearch()));
                    this.payment.clearSelectionDataLoanSearch();
                }

                else
                {
                    this.payment.classGridLoanSearch(this.paymentModel.searchMemberByLAccount(this.payment.getSearch()));
                    this.payment.clearSelectionDataLoanSearch();
                }
            }

        }

    }
}
