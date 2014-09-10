using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Reports.Controller
{
    class DailyTransactionLogController
    {

        Reports.Model.DailyTransactionLogModel dailyTransactionLogModel;
        Reports.View.DailyTransactionLog dailyTransactionLog;


        Dictionary<int, string> savingsTypes = new Dictionary<int, string>();

        public DailyTransactionLogController(Reports.Model.DailyTransactionLogModel dailyTransactionLogModel, Reports.View.DailyTransactionLog dailyTransactionLog, Savings.SavingsMenu savingsMenu) 
        {
            this.dailyTransactionLogModel = dailyTransactionLogModel;
            this.dailyTransactionLog = dailyTransactionLog;
            this.dailyTransactionLog.MdiParent = savingsMenu;
            this.dailyTransactionLog.setBtnPreviewEventHandler(this.btnPreview);
            this.clbSavingsTypes();
            this.dailyTransactionLog.Show();
        }

        public void clbSavingsTypes()
        {

            savingsTypes.Clear();
            DataTable ds = this.dailyTransactionLogModel.selectSavingsTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {
            
                savingsTypes.Add(int.Parse(dr[0].ToString()), dr[1].ToString());

            }
            this.dailyTransactionLog.populateSavingsTypes(savingsTypes);
        }

        private void btnPreview(object args, EventArgs e) {

            int hasError = 0;
            String errors = String.Empty;
            dailyTransactionLog.clearLabels();


            dailyTransactionLogModel.dateFrom = dailyTransactionLog.getDateFrom();
            if (dailyTransactionLog.getDateToChecked())
                dailyTransactionLogModel.dateTo = dailyTransactionLog.getDateTo();
            else
                dailyTransactionLogModel.dateTo = String.Empty;
            dailyTransactionLogModel.checkedSavingsTypes = dailyTransactionLog.getCheckedTypes();
            dailyTransactionLogModel.sortBy = dailyTransactionLog.getSortBy();
            dailyTransactionLogModel.order = dailyTransactionLog.getOrder();

            if (dailyTransactionLogModel.dateFrom == String.Empty)
            { dailyTransactionLog.errorDateFrom(); hasError = 1; errors += "- Start Date is empty." + Environment.NewLine; }
            if (dailyTransactionLog.getDateToChecked())
            {
                if (dailyTransactionLog.getDateTo() == String.Empty)
                {
                    dailyTransactionLog.errorDateTo();
                    hasError = 1;
                    errors += "- End Date is empty." + Environment.NewLine;
                }
                else if (DateTime.Compare(DateTime.Parse(dailyTransactionLog.getDateFrom()),DateTime.Parse(dailyTransactionLog.getDateTo())) > 0)
                {dailyTransactionLog.errorDateTo(); hasError = 1; errors += "- Start date is greater than End date." + Environment.NewLine;}
            }

            if (dailyTransactionLogModel.checkedSavingsTypes.Count == 0)
            { dailyTransactionLog.errorSavingsTypes(); hasError = 1; errors += "- Please check at least one account type." + Environment.NewLine; }
            if (dailyTransactionLogModel.sortBy == String.Empty)
            {dailyTransactionLog.errorSortBy(); hasError = 1;  errors += "- Please select field to sort." + Environment.NewLine;}
            if (dailyTransactionLogModel.order == String.Empty)
            { dailyTransactionLog.errorGroupBy(); hasError = 1; errors += "- Please select sorting method." + Environment.NewLine; }

            if (hasError == 0)
                MessageBox.Show(dailyTransactionLogModel.dateFrom + " " + dailyTransactionLogModel.dateTo + dailyTransactionLogModel.sortBy + " " + dailyTransactionLogModel.order);
            else
                MessageBox.Show("Errors had been found." + Environment.NewLine + errors);
            



        
        }
    }
}
