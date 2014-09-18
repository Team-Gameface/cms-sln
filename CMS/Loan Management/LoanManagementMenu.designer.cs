namespace CMS.Loan_Management
{
    partial class LoanManagementMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanManagementMenu));
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMemberTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDeliquencyClassification = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFeeSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.itemLoanTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInterestRates = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoanCharges = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPenalties = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoanAmnestyActivation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMemberProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCapitalContribution = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.itemLoanApp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoanAmnesty = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQueriesReports = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPaymentHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.itemLoanReleases = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCollectionReport = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDelinquencySchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAnnualFinancialReport = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.MediumBlue;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusDateTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 526);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 35);
            this.statusStrip.TabIndex = 4;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 29);
            // 
            // statusDateTime
            // 
            this.statusDateTime.BackColor = System.Drawing.Color.Transparent;
            this.statusDateTime.ForeColor = System.Drawing.Color.White;
            this.statusDateTime.Name = "statusDateTime";
            this.statusDateTime.Size = new System.Drawing.Size(667, 30);
            this.statusDateTime.Spring = true;
            this.statusDateTime.Text = "DateTime";
            this.statusDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMaintenance,
            this.menuTransaction,
            this.menuQueriesReports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip";
            // 
            // menuMaintenance
            // 
            this.menuMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membershipToolStripMenuItem,
            this.toolStripSeparator4,
            this.itemLoanTypes,
            this.itemInterestRates,
            this.itemLoanCharges,
            this.itemPenalties,
            this.itemLoanAmnestyActivation});
            this.menuMaintenance.Name = "menuMaintenance";
            this.menuMaintenance.Size = new System.Drawing.Size(130, 25);
            this.menuMaintenance.Text = "&MAINTENANCE";
            // 
            // membershipToolStripMenuItem
            // 
            this.membershipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMemberTypes,
            this.itemDeliquencyClassification,
            this.itemFeeSchedule});
            this.membershipToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipToolStripMenuItem.Name = "membershipToolStripMenuItem";
            this.membershipToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.membershipToolStripMenuItem.Text = "Membership";
            // 
            // itemMemberTypes
            // 
            this.itemMemberTypes.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemMemberTypes.Name = "itemMemberTypes";
            this.itemMemberTypes.Size = new System.Drawing.Size(258, 24);
            this.itemMemberTypes.Text = "Member Types";
            // 
            // itemDeliquencyClassification
            // 
            this.itemDeliquencyClassification.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDeliquencyClassification.Name = "itemDeliquencyClassification";
            this.itemDeliquencyClassification.Size = new System.Drawing.Size(258, 24);
            this.itemDeliquencyClassification.Text = "Deliquency Classification";
            // 
            // itemFeeSchedule
            // 
            this.itemFeeSchedule.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFeeSchedule.Name = "itemFeeSchedule";
            this.itemFeeSchedule.Size = new System.Drawing.Size(258, 24);
            this.itemFeeSchedule.Text = "Miscelleneous Fee Schedule";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(238, 6);
            // 
            // itemLoanTypes
            // 
            this.itemLoanTypes.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLoanTypes.Name = "itemLoanTypes";
            this.itemLoanTypes.Size = new System.Drawing.Size(241, 24);
            this.itemLoanTypes.Text = "Loan Types";
            // 
            // itemInterestRates
            // 
            this.itemInterestRates.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInterestRates.Name = "itemInterestRates";
            this.itemInterestRates.Size = new System.Drawing.Size(241, 24);
            this.itemInterestRates.Text = "Loan Interest Rates";
            // 
            // itemLoanCharges
            // 
            this.itemLoanCharges.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLoanCharges.Name = "itemLoanCharges";
            this.itemLoanCharges.Size = new System.Drawing.Size(241, 24);
            this.itemLoanCharges.Text = "Loan Charges";
            // 
            // itemPenalties
            // 
            this.itemPenalties.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPenalties.Name = "itemPenalties";
            this.itemPenalties.Size = new System.Drawing.Size(241, 24);
            this.itemPenalties.Text = "Loan Penalties";
            // 
            // itemLoanAmnestyActivation
            // 
            this.itemLoanAmnestyActivation.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLoanAmnestyActivation.Name = "itemLoanAmnestyActivation";
            this.itemLoanAmnestyActivation.Size = new System.Drawing.Size(241, 24);
            this.itemLoanAmnestyActivation.Text = "Loan Amnesty Activation";
            // 
            // menuTransaction
            // 
            this.menuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMemberProfile,
            this.itemCapitalContribution,
            this.toolStripSeparator5,
            this.itemLoanApp,
            this.itemLoanAmnesty});
            this.menuTransaction.Name = "menuTransaction";
            this.menuTransaction.Size = new System.Drawing.Size(125, 25);
            this.menuTransaction.Text = "&TRANSACTION";
            // 
            // itemMemberProfile
            // 
            this.itemMemberProfile.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemMemberProfile.Name = "itemMemberProfile";
            this.itemMemberProfile.Size = new System.Drawing.Size(250, 24);
            this.itemMemberProfile.Text = "Member Profile";
            // 
            // itemCapitalContribution
            // 
            this.itemCapitalContribution.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCapitalContribution.Name = "itemCapitalContribution";
            this.itemCapitalContribution.Size = new System.Drawing.Size(250, 24);
            this.itemCapitalContribution.Text = "Share Capital Contribution";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(247, 6);
            // 
            // itemLoanApp
            // 
            this.itemLoanApp.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLoanApp.Name = "itemLoanApp";
            this.itemLoanApp.Size = new System.Drawing.Size(250, 24);
            this.itemLoanApp.Text = "Loan Information";
            // 
            // itemLoanAmnesty
            // 
            this.itemLoanAmnesty.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLoanAmnesty.Name = "itemLoanAmnesty";
            this.itemLoanAmnesty.Size = new System.Drawing.Size(250, 24);
            this.itemLoanAmnesty.Text = "Loan Amnesty";
            // 
            // menuQueriesReports
            // 
            this.menuQueriesReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPaymentHistory,
            this.toolStripSeparator6,
            this.itemLoanReleases,
            this.itemCollectionReport,
            this.itemDelinquencySchedule,
            this.itemAnnualFinancialReport});
            this.menuQueriesReports.Name = "menuQueriesReports";
            this.menuQueriesReports.Size = new System.Drawing.Size(186, 25);
            this.menuQueriesReports.Text = "&QUERIES AND REPORTS";
            // 
            // itemPaymentHistory
            // 
            this.itemPaymentHistory.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPaymentHistory.Name = "itemPaymentHistory";
            this.itemPaymentHistory.Size = new System.Drawing.Size(269, 24);
            this.itemPaymentHistory.Text = "Loan Status";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(266, 6);
            // 
            // itemLoanReleases
            // 
            this.itemLoanReleases.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLoanReleases.Name = "itemLoanReleases";
            this.itemLoanReleases.Size = new System.Drawing.Size(269, 24);
            this.itemLoanReleases.Text = "Loan Releases";
            // 
            // itemCollectionReport
            // 
            this.itemCollectionReport.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCollectionReport.Name = "itemCollectionReport";
            this.itemCollectionReport.Size = new System.Drawing.Size(269, 24);
            this.itemCollectionReport.Text = "Collection Report";
            // 
            // itemDelinquencySchedule
            // 
            this.itemDelinquencySchedule.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDelinquencySchedule.Name = "itemDelinquencySchedule";
            this.itemDelinquencySchedule.Size = new System.Drawing.Size(269, 24);
            this.itemDelinquencySchedule.Text = "Deliquency Schedule";
            // 
            // itemAnnualFinancialReport
            // 
            this.itemAnnualFinancialReport.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemAnnualFinancialReport.Name = "itemAnnualFinancialReport";
            this.itemAnnualFinancialReport.Size = new System.Drawing.Size(269, 24);
            this.itemAnnualFinancialReport.Text = "Financial Performance Report";
            // 
            // LoanManagementMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CMS.Properties.Resources.LoanBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoanManagementMenu";
            this.Text = "Loan Management Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoanManagementMenu_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusDateTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMaintenance;
        private System.Windows.Forms.ToolStripMenuItem menuTransaction;
        private System.Windows.Forms.ToolStripMenuItem menuQueriesReports;
        private System.Windows.Forms.ToolStripMenuItem membershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMemberTypes;
        private System.Windows.Forms.ToolStripMenuItem itemDeliquencyClassification;
        private System.Windows.Forms.ToolStripMenuItem itemFeeSchedule;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem itemLoanTypes;
        private System.Windows.Forms.ToolStripMenuItem itemInterestRates;
        private System.Windows.Forms.ToolStripMenuItem itemLoanCharges;
        private System.Windows.Forms.ToolStripMenuItem itemPenalties;
        private System.Windows.Forms.ToolStripMenuItem itemLoanAmnestyActivation;
        private System.Windows.Forms.ToolStripMenuItem itemMemberProfile;
        private System.Windows.Forms.ToolStripMenuItem itemCapitalContribution;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem itemLoanApp;
        private System.Windows.Forms.ToolStripMenuItem itemLoanAmnesty;
        private System.Windows.Forms.ToolStripMenuItem itemPaymentHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem itemLoanReleases;
        private System.Windows.Forms.ToolStripMenuItem itemCollectionReport;
        private System.Windows.Forms.ToolStripMenuItem itemDelinquencySchedule;
        private System.Windows.Forms.ToolStripMenuItem itemAnnualFinancialReport;
    }
}