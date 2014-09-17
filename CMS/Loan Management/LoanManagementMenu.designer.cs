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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMembership = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMemberTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDeliquencyClassification = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFeeSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemLoanTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInterestRates = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoanCharges = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPenalties = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoanAmnestyActivation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMemberProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCapitalContribution = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemLoanApp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoanAmnesty = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoanReleases = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPaymentHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCollectionReport = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDelinquencySchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAnnualFinancialReport = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMaintenance,
            this.menuTransaction,
            this.reportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(15, 2, 0, 10);
            this.menuStrip.Size = new System.Drawing.Size(784, 70);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuMaintenance
            // 
            this.menuMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMembership,
            this.toolStripSeparator1,
            this.itemLoanTypes,
            this.itemInterestRates,
            this.itemLoanCharges,
            this.itemPenalties,
            this.itemLoanAmnestyActivation});
            this.menuMaintenance.Image = global::CMS.Properties.Resources.Maintenance_LM;
            this.menuMaintenance.Name = "menuMaintenance";
            this.menuMaintenance.Size = new System.Drawing.Size(94, 58);
            this.menuMaintenance.Text = "Maintenance";
            this.menuMaintenance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // itemMembership
            // 
            this.itemMembership.BackColor = System.Drawing.Color.AliceBlue;
            this.itemMembership.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMemberTypes,
            this.itemDeliquencyClassification,
            this.itemFeeSchedule});
            this.itemMembership.Name = "itemMembership";
            this.itemMembership.Size = new System.Drawing.Size(217, 22);
            this.itemMembership.Text = "Membership";
            // 
            // itemMemberTypes
            // 
            this.itemMemberTypes.Name = "itemMemberTypes";
            this.itemMemberTypes.Size = new System.Drawing.Size(238, 22);
            this.itemMemberTypes.Text = "Member Types";
            // 
            // itemDeliquencyClassification
            // 
            this.itemDeliquencyClassification.Name = "itemDeliquencyClassification";
            this.itemDeliquencyClassification.Size = new System.Drawing.Size(238, 22);
            this.itemDeliquencyClassification.Text = "Delinquency Classifications";
            // 
            // itemFeeSchedule
            // 
            this.itemFeeSchedule.Name = "itemFeeSchedule";
            this.itemFeeSchedule.Size = new System.Drawing.Size(238, 22);
            this.itemFeeSchedule.Text = "Miscellaneous Fee Schedule";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // itemLoanTypes
            // 
            this.itemLoanTypes.BackColor = System.Drawing.Color.AliceBlue;
            this.itemLoanTypes.Name = "itemLoanTypes";
            this.itemLoanTypes.Size = new System.Drawing.Size(217, 22);
            this.itemLoanTypes.Text = "Loan Types";
            // 
            // itemInterestRates
            // 
            this.itemInterestRates.BackColor = System.Drawing.Color.AliceBlue;
            this.itemInterestRates.Name = "itemInterestRates";
            this.itemInterestRates.Size = new System.Drawing.Size(217, 22);
            this.itemInterestRates.Text = "Loan Interest Rates";
            // 
            // itemLoanCharges
            // 
            this.itemLoanCharges.BackColor = System.Drawing.Color.AliceBlue;
            this.itemLoanCharges.Name = "itemLoanCharges";
            this.itemLoanCharges.Size = new System.Drawing.Size(217, 22);
            this.itemLoanCharges.Text = "Loan Charges";
            // 
            // itemPenalties
            // 
            this.itemPenalties.BackColor = System.Drawing.Color.AliceBlue;
            this.itemPenalties.Name = "itemPenalties";
            this.itemPenalties.Size = new System.Drawing.Size(217, 22);
            this.itemPenalties.Text = "Loan Penalties";
            // 
            // itemLoanAmnestyActivation
            // 
            this.itemLoanAmnestyActivation.BackColor = System.Drawing.Color.AliceBlue;
            this.itemLoanAmnestyActivation.Name = "itemLoanAmnestyActivation";
            this.itemLoanAmnestyActivation.Size = new System.Drawing.Size(217, 22);
            this.itemLoanAmnestyActivation.Text = "Loan Amnesty Activation";
            // 
            // menuTransaction
            // 
            this.menuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMemberProfile,
            this.itemCapitalContribution,
            this.toolStripSeparator2,
            this.itemLoanApp,
            this.itemLoanAmnesty});
            this.menuTransaction.Image = global::CMS.Properties.Resources.Transaction_LM;
            this.menuTransaction.Name = "menuTransaction";
            this.menuTransaction.Size = new System.Drawing.Size(87, 58);
            this.menuTransaction.Text = "Transaction";
            this.menuTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // itemMemberProfile
            // 
            this.itemMemberProfile.BackColor = System.Drawing.Color.AliceBlue;
            this.itemMemberProfile.Name = "itemMemberProfile";
            this.itemMemberProfile.Size = new System.Drawing.Size(229, 22);
            this.itemMemberProfile.Text = "Member Profile";
            // 
            // itemCapitalContribution
            // 
            this.itemCapitalContribution.BackColor = System.Drawing.Color.AliceBlue;
            this.itemCapitalContribution.Name = "itemCapitalContribution";
            this.itemCapitalContribution.Size = new System.Drawing.Size(229, 22);
            this.itemCapitalContribution.Text = "Share Capital Contribution";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(226, 6);
            // 
            // itemLoanApp
            // 
            this.itemLoanApp.BackColor = System.Drawing.Color.AliceBlue;
            this.itemLoanApp.Name = "itemLoanApp";
            this.itemLoanApp.Size = new System.Drawing.Size(229, 22);
            this.itemLoanApp.Text = "Loan Information";
            // 
            // itemLoanAmnesty
            // 
            this.itemLoanAmnesty.BackColor = System.Drawing.Color.AliceBlue;
            this.itemLoanAmnesty.Name = "itemLoanAmnesty";
            this.itemLoanAmnesty.Size = new System.Drawing.Size(229, 22);
            this.itemLoanAmnesty.Text = "Loan Amnesty";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLoanReleases,
            this.itemPaymentHistory,
            this.itemCollectionReport,
            this.itemDelinquencySchedule,
            this.itemAnnualFinancialReport});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(141, 58);
            this.reportToolStripMenuItem.Text = "Queries and Reports";
            this.reportToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // itemLoanReleases
            // 
            this.itemLoanReleases.BackColor = System.Drawing.Color.AliceBlue;
            this.itemLoanReleases.Name = "itemLoanReleases";
            this.itemLoanReleases.Size = new System.Drawing.Size(247, 22);
            this.itemLoanReleases.Text = "Loan Releases";
            // 
            // itemPaymentHistory
            // 
            this.itemPaymentHistory.BackColor = System.Drawing.Color.AliceBlue;
            this.itemPaymentHistory.Name = "itemPaymentHistory";
            this.itemPaymentHistory.Size = new System.Drawing.Size(247, 22);
            this.itemPaymentHistory.Text = "Loan Payment History";
            // 
            // itemCollectionReport
            // 
            this.itemCollectionReport.BackColor = System.Drawing.Color.AliceBlue;
            this.itemCollectionReport.Name = "itemCollectionReport";
            this.itemCollectionReport.Size = new System.Drawing.Size(247, 22);
            this.itemCollectionReport.Text = "Collection Report";
            // 
            // itemDelinquencySchedule
            // 
            this.itemDelinquencySchedule.BackColor = System.Drawing.Color.AliceBlue;
            this.itemDelinquencySchedule.Name = "itemDelinquencySchedule";
            this.itemDelinquencySchedule.Size = new System.Drawing.Size(247, 22);
            this.itemDelinquencySchedule.Text = "Delinquency Schedule";
            // 
            // itemAnnualFinancialReport
            // 
            this.itemAnnualFinancialReport.BackColor = System.Drawing.Color.AliceBlue;
            this.itemAnnualFinancialReport.Name = "itemAnnualFinancialReport";
            this.itemAnnualFinancialReport.Size = new System.Drawing.Size(247, 22);
            this.itemAnnualFinancialReport.Text = "Financial Performance Report";
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
            // LoanManagementMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CMS.Properties.Resources.loanmenu_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoanManagementMenu";
            this.Text = "Loan Management Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoanManagementMenu_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuMaintenance;
        private System.Windows.Forms.ToolStripMenuItem menuTransaction;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemLoanTypes;
        private System.Windows.Forms.ToolStripMenuItem itemInterestRates;
        private System.Windows.Forms.ToolStripMenuItem itemLoanCharges;
        private System.Windows.Forms.ToolStripMenuItem itemLoanApp;
        private System.Windows.Forms.ToolStripMenuItem itemCapitalContribution;
        private System.Windows.Forms.ToolStripMenuItem itemPenalties;
        private System.Windows.Forms.ToolStripMenuItem itemMembership;
        private System.Windows.Forms.ToolStripMenuItem itemMemberTypes;
        private System.Windows.Forms.ToolStripMenuItem itemDeliquencyClassification;
        private System.Windows.Forms.ToolStripMenuItem itemFeeSchedule;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemMemberProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemLoanAmnestyActivation;
        private System.Windows.Forms.ToolStripMenuItem itemLoanAmnesty;
        private System.Windows.Forms.ToolStripMenuItem itemLoanReleases;
        private System.Windows.Forms.ToolStripMenuItem itemDelinquencySchedule;
        private System.Windows.Forms.ToolStripMenuItem itemCollectionReport;
        private System.Windows.Forms.ToolStripMenuItem itemAnnualFinancialReport;
        private System.Windows.Forms.ToolStripMenuItem itemPaymentHistory;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusDateTime;
    }
}