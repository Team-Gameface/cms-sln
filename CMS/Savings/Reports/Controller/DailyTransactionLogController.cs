using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Reports.Controller
{
    class DailyTransactionLogController
    {

        Reports.Model.DailyTransactionLogModel dailyTransactionLogModel;
        Reports.View.DailyTransactionLog dailyTransactionLog;
        Main.Logger logger = new Main.Logger();

        Dictionary<int, string> savingsTypes = new Dictionary<int, string>();

        public DailyTransactionLogController(Reports.Model.DailyTransactionLogModel dailyTransactionLogModel, Reports.View.DailyTransactionLog dailyTransactionLog, Savings.SavingsMenu savingsMenu) 
        {
            this.dailyTransactionLogModel = dailyTransactionLogModel;
            this.dailyTransactionLog = dailyTransactionLog;
            this.dailyTransactionLog.MdiParent = savingsMenu;
            this.dailyTransactionLog.setBtnPreviewEventHandler(this.btnPreview);
            this.dailyTransactionLog.Show();
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Reports - Daily Transaction Log";
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
      

        private void btnPreview(object args, EventArgs e) {

            int hasError = 0;
            String errors = String.Empty;
            dailyTransactionLog.clearLabels();


            dailyTransactionLogModel.dateFrom = dailyTransactionLog.getDateFrom();
            if (dailyTransactionLog.getDateToChecked())
                dailyTransactionLogModel.dateTo = dailyTransactionLog.getDateTo();
            else
                dailyTransactionLogModel.dateTo = String.Empty;

            switch (dailyTransactionLog.getSortBy()) {

                case "Transaction Time": dailyTransactionLogModel.sortBy = "TransactionDate";
                    break;
                case "Member Account No": dailyTransactionLogModel.sortBy = "st.SavingsAccountNo";
                    break;
                case "Member Name": dailyTransactionLogModel.sortBy = "CONCAT(m.LastName, ', ', m.FirstName, ' ', m.MiddleName)";
                    break;
                case "OR No": dailyTransactionLogModel.sortBy = "TransactionID";
                    break;
                default: dailyTransactionLogModel.sortBy = String.Empty;
                    break;
            
            }
            
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
            if (dailyTransactionLogModel.sortBy == String.Empty)
            {dailyTransactionLog.errorSortBy(); hasError = 1;  errors += "- Please select field to sort." + Environment.NewLine;}
            if (dailyTransactionLogModel.order == String.Empty)
            { dailyTransactionLog.errorGroupBy(); hasError = 1; errors += "- Please select sorting method." + Environment.NewLine; }

            if (hasError == 0)
            {
                DataSet ds;
                if (dailyTransactionLog.getDateToChecked())
                    ds = dailyTransactionLogModel.listDailyTransactions(dailyTransactionLogModel.dateFrom, dailyTransactionLogModel.dateTo, dailyTransactionLogModel.sortBy, dailyTransactionLogModel.order, "TableTransLog");
                else
                    ds = dailyTransactionLogModel.listDailyTransactions(dailyTransactionLogModel.dateFrom, dailyTransactionLogModel.sortBy, dailyTransactionLogModel.order, "TableTransLog");

                DataSet dsCoop = dailyTransactionLogModel.getCompanyProfile("dtLogo");
                DataSet dsStaff = dailyTransactionLogModel.getStaff(Main.UserData.userId, "dtStaff");
                DataSet dsMgr = dailyTransactionLogModel.getManager("dtManager");
                DataSet dsCredChair = dailyTransactionLogModel.getChair("dtCreditChair");

                if (ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("No records to show.", "Daily Transaction Log");
                else
                {
                    dailyTransactionLog.setReportDataSource(ds, dsCoop, dsStaff, dsCredChair, dsMgr, dailyTransactionLogModel.dateFrom, dailyTransactionLogModel.dateTo);
                    execLogger("Generated Report");
                }
            }
            else
                MessageBox.Show("Errors had been found." + Environment.NewLine + errors);
            



        
        }
    }
}
