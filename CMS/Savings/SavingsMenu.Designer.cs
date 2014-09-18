namespace CMS.Savings
{
    partial class SavingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsMenu));
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSavingsAccountTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemInterestRates = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTimeDepositWithdrawal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpenAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSavingsAccountTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemTimeDepositApp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTimeDepositWith = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemMemberTermination = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQueriesReports = new System.Windows.Forms.ToolStripMenuItem();
            this.itemStatementOfAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.itemDailyTransactionLog = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
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
            this.statusStrip.BackColor = System.Drawing.Color.Firebrick;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusDateTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 30);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 24);
            // 
            // statusDateTime
            // 
            this.statusDateTime.ForeColor = System.Drawing.Color.White;
            this.statusDateTime.Name = "statusDateTime";
            this.statusDateTime.Size = new System.Drawing.Size(667, 25);
            this.statusDateTime.Spring = true;
            this.statusDateTime.Text = "DateTime";
            this.statusDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMaintenance,
            this.menuTransaction,
            this.menuQueriesReports});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 29);
            this.menuStrip.TabIndex = 7;
            // 
            // menuMaintenance
            // 
            this.menuMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSavingsAccountTypes,
            this.toolStripSeparator1,
            this.itemInterestRates,
            this.itemTimeDepositWithdrawal});
            this.menuMaintenance.Name = "menuMaintenance";
            this.menuMaintenance.Size = new System.Drawing.Size(130, 25);
            this.menuMaintenance.Text = "&MAINTENANCE";
            // 
            // itemSavingsAccountTypes
            // 
            this.itemSavingsAccountTypes.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSavingsAccountTypes.Name = "itemSavingsAccountTypes";
            this.itemSavingsAccountTypes.Size = new System.Drawing.Size(276, 24);
            this.itemSavingsAccountTypes.Text = "Savings Account Type";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(273, 6);
            // 
            // itemInterestRates
            // 
            this.itemInterestRates.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInterestRates.Name = "itemInterestRates";
            this.itemInterestRates.Size = new System.Drawing.Size(276, 24);
            this.itemInterestRates.Text = "Time Deposit Terms and Rates";
            // 
            // itemTimeDepositWithdrawal
            // 
            this.itemTimeDepositWithdrawal.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTimeDepositWithdrawal.Name = "itemTimeDepositWithdrawal";
            this.itemTimeDepositWithdrawal.Size = new System.Drawing.Size(276, 24);
            this.itemTimeDepositWithdrawal.Text = "Early Withdrawal Penalties";
            // 
            // menuTransaction
            // 
            this.menuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpenAccount,
            this.itemSavingsAccountTrans,
            this.toolStripSeparator2,
            this.itemTimeDepositApp,
            this.itemTimeDepositWith,
            this.toolStripSeparator3,
            this.itemMemberTermination});
            this.menuTransaction.Name = "menuTransaction";
            this.menuTransaction.Size = new System.Drawing.Size(125, 25);
            this.menuTransaction.Text = "&TRANSACTION";
            // 
            // itemOpenAccount
            // 
            this.itemOpenAccount.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemOpenAccount.Name = "itemOpenAccount";
            this.itemOpenAccount.Size = new System.Drawing.Size(264, 24);
            this.itemOpenAccount.Text = "Savings Account";
            // 
            // itemSavingsAccountTrans
            // 
            this.itemSavingsAccountTrans.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSavingsAccountTrans.Name = "itemSavingsAccountTrans";
            this.itemSavingsAccountTrans.Size = new System.Drawing.Size(264, 24);
            this.itemSavingsAccountTrans.Text = "Savings Account Transaction";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(261, 6);
            // 
            // itemTimeDepositApp
            // 
            this.itemTimeDepositApp.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTimeDepositApp.Name = "itemTimeDepositApp";
            this.itemTimeDepositApp.Size = new System.Drawing.Size(264, 24);
            this.itemTimeDepositApp.Text = "Time Deposit Application";
            // 
            // itemTimeDepositWith
            // 
            this.itemTimeDepositWith.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTimeDepositWith.Name = "itemTimeDepositWith";
            this.itemTimeDepositWith.Size = new System.Drawing.Size(264, 24);
            this.itemTimeDepositWith.Text = "Time Deposit Withdrawal";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(261, 6);
            // 
            // itemMemberTermination
            // 
            this.itemMemberTermination.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemMemberTermination.Name = "itemMemberTermination";
            this.itemMemberTermination.Size = new System.Drawing.Size(264, 24);
            this.itemMemberTermination.Text = "Member Termination";
            // 
            // menuQueriesReports
            // 
            this.menuQueriesReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemStatementOfAccount,
            this.toolStripSeparator4,
            this.itemDailyTransactionLog});
            this.menuQueriesReports.Name = "menuQueriesReports";
            this.menuQueriesReports.Size = new System.Drawing.Size(186, 25);
            this.menuQueriesReports.Text = "&QUERIES AND REPORTS";
            // 
            // itemStatementOfAccount
            // 
            this.itemStatementOfAccount.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStatementOfAccount.Name = "itemStatementOfAccount";
            this.itemStatementOfAccount.Size = new System.Drawing.Size(222, 24);
            this.itemStatementOfAccount.Text = "Statement of Account";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(219, 6);
            // 
            // itemDailyTransactionLog
            // 
            this.itemDailyTransactionLog.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDailyTransactionLog.Name = "itemDailyTransactionLog";
            this.itemDailyTransactionLog.Size = new System.Drawing.Size(222, 24);
            this.itemDailyTransactionLog.Text = "Daily Transaction Log";
            // 
            // SavingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMS.Properties.Resources.SavingsBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SavingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusDateTime;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuMaintenance;
        private System.Windows.Forms.ToolStripMenuItem itemSavingsAccountTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemInterestRates;
        private System.Windows.Forms.ToolStripMenuItem itemTimeDepositWithdrawal;
        private System.Windows.Forms.ToolStripMenuItem menuTransaction;
        private System.Windows.Forms.ToolStripMenuItem itemOpenAccount;
        private System.Windows.Forms.ToolStripMenuItem itemSavingsAccountTrans;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemTimeDepositApp;
        private System.Windows.Forms.ToolStripMenuItem itemTimeDepositWith;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem itemMemberTermination;
        private System.Windows.Forms.ToolStripMenuItem menuQueriesReports;
        private System.Windows.Forms.ToolStripMenuItem itemStatementOfAccount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem itemDailyTransactionLog;
    }
}