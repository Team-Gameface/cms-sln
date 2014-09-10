using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management
{
    public partial class LoanManagementMenu : Form
    {
        public LoanManagementMenu()
        {
            InitializeComponent();
        }

        public void setItemLoanTypesEventHandler(EventHandler e)
        {
            this.itemLoanTypes.Click += e;
        }

        public void setItemLoanInterestRateEventHandler(EventHandler e)
        {
            this.itemInterestRates.Click += e;
        }

        public void setItemLoanChargesEventHandler(EventHandler e)
        {
            this.itemLoanCharges.Click += e;
        }

        public void setItemPenaltiesEventHandler(EventHandler e)
        {
            this.itemPenalties.Click += e;
        }

        public void setAmnestyActivationEventHandler(EventHandler e) 
        {
            this.itemLoanAmnestyActivation.Click += e;
        }

        public void setItemShareCapitalEventHandler(EventHandler e)
        {
            this.itemShareCapital.Click += e;
        }

        public void setItemMemberTypesEventHandler(EventHandler e)
        {
            this.itemMemberTypes.Click += e;
        }

        public void setItemDeliquencyClassification(EventHandler e)
        {
            this.itemDeliquencyClassification.Click += e;
        }

        public void setItemFeeSchedule(EventHandler e)
        {
            this.itemFeeSchedule.Click += e;
        }
        //trans

        public void setItemLoanApplicationEventHandler(EventHandler e)
        {
            this.itemLoanApp.Click += e;
        }

        public void setItemCapitalContributionEventHandler(EventHandler e)
        {
            this.itemCapitalContribution.Click += e;
        }

        public void setItemMemberProfileEventHandler(EventHandler e)
        {
            this.itemMemberProfile.Click += e;
        }

        public void setLoanAmnestyEventHandler(EventHandler e) 
        {
            this.itemLoanAmnesty.Click += e;
        }

        public void setPaymentHistoryEventHandler(EventHandler e)
        {
            this.itemPaymentHistory.Click += e;
        }

        public void setMemberInformationEventHandler(EventHandler e)
        {
            this.itemMemberInformation.Click += e;
        }

        public void setMemberStatisticsEventHandler(EventHandler e)
        {
            this.itemMemberStatistics.Click += e;
        }

        public void setLoanReleasesEventHandler(EventHandler e)
        {
            this.itemLoanReleases.Click += e;
        }

        public void setCollectionReportEventHandler(EventHandler e)
        {
            this.itemCollectionReport.Click += e;
        }

        public void setitemDelinquencyEventHandler(EventHandler e)
        {
            this.itemDelinquencySchedule.Click += e;
        }

        public void setAnnualFinancialReportEventHandler(EventHandler e)
        {
            this.itemAnnualFinancialReport.Click += e;
        }

        private void LoanManagementMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            new Main.Controller.MainController(new Main.View.CMS());
        }
    }
}
