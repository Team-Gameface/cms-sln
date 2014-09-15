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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSavingsAccountTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemInterestRates = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTimeDepositWithdrawal = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpenAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSavingsAccountTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemTimeDepositApp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTimeDepositWith = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemMemberTermination = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDailyTransactionLog = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.itemStatementOfAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(15, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(784, 25);
            this.menuStrip.TabIndex = 1;
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSavingsAccountTypes,
            this.toolStripSeparator3,
            this.itemInterestRates,
            this.itemTimeDepositWithdrawal});
            this.maintenanceToolStripMenuItem.Image = global::CMS.Properties.Resources.Maintenance_SV;
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // itemSavingsAccountTypes
            // 
            this.itemSavingsAccountTypes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSavingsAccountTypes.Name = "itemSavingsAccountTypes";
            this.itemSavingsAccountTypes.Size = new System.Drawing.Size(255, 22);
            this.itemSavingsAccountTypes.Text = "Savings Account Types";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(252, 6);
            // 
            // itemInterestRates
            // 
            this.itemInterestRates.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInterestRates.Name = "itemInterestRates";
            this.itemInterestRates.Size = new System.Drawing.Size(255, 22);
            this.itemInterestRates.Text = "Time Deposit Terms and Rates";
            // 
            // itemTimeDepositWithdrawal
            // 
            this.itemTimeDepositWithdrawal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTimeDepositWithdrawal.Name = "itemTimeDepositWithdrawal";
            this.itemTimeDepositWithdrawal.Size = new System.Drawing.Size(255, 22);
            this.itemTimeDepositWithdrawal.Text = "Early Withdrawal Penalties";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpenAccount,
            this.itemSavingsAccountTrans,
            this.toolStripSeparator1,
            this.itemTimeDepositApp,
            this.itemTimeDepositWith,
            this.toolStripSeparator2,
            this.itemMemberTermination});
            this.transactionToolStripMenuItem.Image = global::CMS.Properties.Resources.Transaction_SV;
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // itemOpenAccount
            // 
            this.itemOpenAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemOpenAccount.Name = "itemOpenAccount";
            this.itemOpenAccount.Size = new System.Drawing.Size(241, 22);
            this.itemOpenAccount.Text = "Savings Account";
            // 
            // itemSavingsAccountTrans
            // 
            this.itemSavingsAccountTrans.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSavingsAccountTrans.Name = "itemSavingsAccountTrans";
            this.itemSavingsAccountTrans.Size = new System.Drawing.Size(241, 22);
            this.itemSavingsAccountTrans.Text = "Savings Account Transaction";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // itemTimeDepositApp
            // 
            this.itemTimeDepositApp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTimeDepositApp.Name = "itemTimeDepositApp";
            this.itemTimeDepositApp.Size = new System.Drawing.Size(241, 22);
            this.itemTimeDepositApp.Text = "Time Deposit Application";
            // 
            // itemTimeDepositWith
            // 
            this.itemTimeDepositWith.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTimeDepositWith.Name = "itemTimeDepositWith";
            this.itemTimeDepositWith.Size = new System.Drawing.Size(241, 22);
            this.itemTimeDepositWith.Text = "Time Deposit Withdrawal";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // itemMemberTermination
            // 
            this.itemMemberTermination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemMemberTermination.Name = "itemMemberTermination";
            this.itemMemberTermination.Size = new System.Drawing.Size(241, 22);
            this.itemMemberTermination.Text = "Member Termination";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDailyTransactionLog,
            this.itemStatementOfAccount});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(141, 21);
            this.reportsToolStripMenuItem.Text = "Queries and Reports";
            // 
            // itemDailyTransactionLog
            // 
            this.itemDailyTransactionLog.Name = "itemDailyTransactionLog";
            this.itemDailyTransactionLog.Size = new System.Drawing.Size(201, 22);
            this.itemDailyTransactionLog.Text = "Daily Transaction Log";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Tomato;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDateTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(61, 17);
            this.lblDateTime.Text = "Date Time";
            this.lblDateTime.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // itemStatementOfAccount
            // 
            this.itemStatementOfAccount.Name = "itemStatementOfAccount";
            this.itemStatementOfAccount.Size = new System.Drawing.Size(201, 22);
            this.itemStatementOfAccount.Text = "Statement of Account";
            // 
            // SavingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
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
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSavingsAccountTrans;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemTimeDepositApp;
        private System.Windows.Forms.ToolStripMenuItem itemTimeDepositWith;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSavingsAccountTypes;
        private System.Windows.Forms.ToolStripMenuItem itemInterestRates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem itemTimeDepositWithdrawal;
        private System.Windows.Forms.ToolStripMenuItem itemOpenAccount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemMemberTermination;
        private System.Windows.Forms.ToolStripMenuItem itemDailyTransactionLog;
        private System.Windows.Forms.ToolStripMenuItem itemStatementOfAccount;
    }
}