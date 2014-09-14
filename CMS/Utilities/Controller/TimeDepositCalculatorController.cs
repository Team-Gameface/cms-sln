using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        }
    }
}
