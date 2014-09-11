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

            ArrayList savingsTypesNo = new ArrayList();

            foreach (String s in dailyTransactionLogModel.checkedSavingsTypes)
            {
                foreach (KeyValuePair<int, string> pair in savingsTypes)
                {
                    if (s.Equals(pair.Value))
                        savingsTypesNo.Add(pair.Key);
                }
            }

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

            if (dailyTransactionLogModel.checkedSavingsTypes.Count == 0)
            { dailyTransactionLog.errorSavingsTypes(); hasError = 1; errors += "- Please check at least one account type." + Environment.NewLine; }
            if (dailyTransactionLogModel.sortBy == String.Empty)
            {dailyTransactionLog.errorSortBy(); hasError = 1;  errors += "- Please select field to sort." + Environment.NewLine;}
            if (dailyTransactionLogModel.order == String.Empty)
            { dailyTransactionLog.errorGroupBy(); hasError = 1; errors += "- Please select sorting method." + Environment.NewLine; }

            if (hasError == 0)
            {
                DataSet ds;
                MessageBox.Show(dailyTransactionLogModel.dateFrom + " " + dailyTransactionLogModel.dateTo + dailyTransactionLogModel.sortBy + " " + dailyTransactionLogModel.order);
                if (dailyTransactionLog.getDateToChecked())
                    ds = dailyTransactionLogModel.listDailyTransactions(dailyTransactionLogModel.dateFrom, dailyTransactionLogModel.dateTo, savingsTypesNo, dailyTransactionLogModel.sortBy, dailyTransactionLogModel.order, "TableTransLog");
                else
                    ds = dailyTransactionLogModel.listDailyTransactions(dailyTransactionLogModel.dateFrom, savingsTypesNo, dailyTransactionLogModel.sortBy, dailyTransactionLogModel.order, "TableTransLog");

                Dictionary<String,Object> parameters = new Dictionary<string,object>();
                SqlDataReader dr = dailyTransactionLogModel.getCompanyProfile();
                while (dr.Read())
                {
                    parameters.Add("@cooperativeName", dr["CompanyName"].ToString());
                    MessageBox.Show(dr["CompanyName"].ToString());
                    parameters.Add("@cooperativeAccreditationNo", dr["AccreditationNo"].ToString());
                    parameters.Add("@cooperativeAddress", dr["CompanyAddress"].ToString());
                    parameters.Add("@cooperativeContactDetails", dr["Telephone"].ToString() + "; " + dr["Cellphone"].ToString() + "; " + dr["Email"].ToString());
                }
                parameters.Add("@dateFrom",dailyTransactionLogModel.dateFrom);
                parameters.Add("@dateTo",dailyTransactionLogModel.dateTo);
                dailyTransactionLog.setReportDataSource(ds,parameters);
                MessageBox.Show(ds.Tables[0].Rows.Count + " ");

            }
            else
                MessageBox.Show("Errors had been found." + Environment.NewLine + errors);
            



        
        }
    }
}
