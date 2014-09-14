using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Utilities.Controller
{
    class TimeDepositCalculatorController
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~TimeDepositCalculatorController()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (tdCalc != null)
                {
                    tdCalc.Dispose();
                    tdCalc = null;
                }
            }
        }

        View.TimeDepositCalculator tdCalc;
        Model.TimeDepositCalculatorModel tdModel;
        Main.View.Utilities utilities;

        public TimeDepositCalculatorController(View.TimeDepositCalculator tdCalc, Model.TimeDepositCalculatorModel tdModel, Main.View.Utilities utilities)
        {
            this.tdCalc = tdCalc;
            this.tdModel = tdModel;
            this.utilities = utilities;
            this.tdCalc.setFormClosing(this.formClosing);
            this.tdCalc.setBtnComputeEventHandler(this.btnCompute);
            tdCalc.Show();
        }

        public void formClosing(object sender, EventArgs e)
        {
            utilities.TDCalcOpen = false;
            this.Dispose();
        }

        public void btnCompute(object sender, EventArgs e)
        {
            double principal = this.tdCalc.getPrincipal();
            int noDays = this.tdCalc.getDuration();
            try
            {
                this.tdCalc.setPrincipal(principal.ToString("N2", new CultureInfo("en-PH")));
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Amount", "Time Deposit Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            String converter = this.tdModel.getInterest(noDays, principal).ToString("#.##");
            double interest = 0.00;
            try
            {
                interest = Convert.ToDouble(converter);
            }
            catch (Exception) { }

            int days = Convert.ToInt32(this.tdModel.getDaysElapsed(noDays, principal));
            converter = (days / 360.00).ToString("#.##");
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
            this.tdCalc.setInterest(interestEarned.ToString("N2", new CultureInfo("en-PH")));
            double total = this.tdCalc.getPrincipal() + interestEarned;
            this.tdCalc.setTotal(total.ToString("N2", new CultureInfo("en-PH")));
        }
    }
}
