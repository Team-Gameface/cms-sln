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
            this.menuMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSavingsAccountTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemInterestRates = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTimeDepositWithdrawal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpenAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSavingsAccountTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemTimeDepositApp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTimeDepositWith = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemMemberTermination = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDailyTransactionLog = new System.Windows.Forms.ToolStripMenuItem();
            this.itemStatementOfAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panelMemberCount = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panelMemberCount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.Snow;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMaintenance,
            this.menuTransaction,
            this.reportsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(15, 2, 0, 10);
            this.menuStrip.Size = new System.Drawing.Size(784, 70);
            this.menuStrip.TabIndex = 1;
            // 
            // menuMaintenance
            // 
            this.menuMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSavingsAccountTypes,
            this.toolStripSeparator3,
            this.itemInterestRates,
            this.itemTimeDepositWithdrawal});
            this.menuMaintenance.Image = global::CMS.Properties.Resources.Maintenance_SV;
            this.menuMaintenance.Name = "menuMaintenance";
            this.menuMaintenance.Size = new System.Drawing.Size(94, 58);
            this.menuMaintenance.Text = "Maintenance";
            this.menuMaintenance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // itemSavingsAccountTypes
            // 
            this.itemSavingsAccountTypes.BackColor = System.Drawing.Color.Snow;
            this.itemSavingsAccountTypes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSavingsAccountTypes.Name = "itemSavingsAccountTypes";
            this.itemSavingsAccountTypes.Size = new System.Drawing.Size(255, 22);
            this.itemSavingsAccountTypes.Text = "Savings Account Types";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.Snow;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(252, 6);
            // 
            // itemInterestRates
            // 
            this.itemInterestRates.BackColor = System.Drawing.Color.Snow;
            this.itemInterestRates.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInterestRates.Name = "itemInterestRates";
            this.itemInterestRates.Size = new System.Drawing.Size(255, 22);
            this.itemInterestRates.Text = "Time Deposit Terms and Rates";
            // 
            // itemTimeDepositWithdrawal
            // 
            this.itemTimeDepositWithdrawal.BackColor = System.Drawing.Color.Snow;
            this.itemTimeDepositWithdrawal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTimeDepositWithdrawal.Name = "itemTimeDepositWithdrawal";
            this.itemTimeDepositWithdrawal.Size = new System.Drawing.Size(255, 22);
            this.itemTimeDepositWithdrawal.Text = "Early Withdrawal Penalties";
            // 
            // menuTransaction
            // 
            this.menuTransaction.AutoSize = false;
            this.menuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpenAccount,
            this.itemSavingsAccountTrans,
            this.toolStripSeparator1,
            this.itemTimeDepositApp,
            this.itemTimeDepositWith,
            this.toolStripSeparator2,
            this.itemMemberTermination});
            this.menuTransaction.Image = global::CMS.Properties.Resources.Transaction_SV;
            this.menuTransaction.Name = "menuTransaction";
            this.menuTransaction.Size = new System.Drawing.Size(87, 62);
            this.menuTransaction.Text = "Transaction";
            this.menuTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // itemOpenAccount
            // 
            this.itemOpenAccount.BackColor = System.Drawing.Color.Snow;
            this.itemOpenAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemOpenAccount.Name = "itemOpenAccount";
            this.itemOpenAccount.Size = new System.Drawing.Size(241, 22);
            this.itemOpenAccount.Text = "Savings Account";
            // 
            // itemSavingsAccountTrans
            // 
            this.itemSavingsAccountTrans.BackColor = System.Drawing.Color.Snow;
            this.itemSavingsAccountTrans.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSavingsAccountTrans.Name = "itemSavingsAccountTrans";
            this.itemSavingsAccountTrans.Size = new System.Drawing.Size(241, 22);
            this.itemSavingsAccountTrans.Text = "Savings Account Transaction";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Snow;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // itemTimeDepositApp
            // 
            this.itemTimeDepositApp.BackColor = System.Drawing.Color.Snow;
            this.itemTimeDepositApp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTimeDepositApp.Name = "itemTimeDepositApp";
            this.itemTimeDepositApp.Size = new System.Drawing.Size(241, 22);
            this.itemTimeDepositApp.Text = "Time Deposit Application";
            // 
            // itemTimeDepositWith
            // 
            this.itemTimeDepositWith.BackColor = System.Drawing.Color.Snow;
            this.itemTimeDepositWith.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTimeDepositWith.Name = "itemTimeDepositWith";
            this.itemTimeDepositWith.Size = new System.Drawing.Size(241, 22);
            this.itemTimeDepositWith.Text = "Time Deposit Withdrawal";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.Snow;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // itemMemberTermination
            // 
            this.itemMemberTermination.BackColor = System.Drawing.Color.Snow;
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
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(141, 58);
            this.reportsToolStripMenuItem.Text = "Queries and Reports";
            this.reportsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // itemDailyTransactionLog
            // 
            this.itemDailyTransactionLog.BackColor = System.Drawing.Color.Snow;
            this.itemDailyTransactionLog.Name = "itemDailyTransactionLog";
            this.itemDailyTransactionLog.Size = new System.Drawing.Size(201, 22);
            this.itemDailyTransactionLog.Text = "Daily Transaction Log";
            // 
            // itemStatementOfAccount
            // 
            this.itemStatementOfAccount.BackColor = System.Drawing.Color.Snow;
            this.itemStatementOfAccount.Name = "itemStatementOfAccount";
            this.itemStatementOfAccount.Size = new System.Drawing.Size(201, 22);
            this.itemStatementOfAccount.Text = "Statement of Account";
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // panelMemberCount
            // 
            this.panelMemberCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMemberCount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMemberCount.BackColor = System.Drawing.Color.DarkBlue;
            this.panelMemberCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMemberCount.Controls.Add(this.label2);
            this.panelMemberCount.Controls.Add(this.label1);
            this.panelMemberCount.Location = new System.Drawing.Point(488, 114);
            this.panelMemberCount.Name = "panelMemberCount";
            this.panelMemberCount.Size = new System.Drawing.Size(284, 146);
            this.panelMemberCount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 106);
            this.label2.TabIndex = 0;
            this.label2.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "active accounts";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(488, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 146);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 106);
            this.label3.TabIndex = 0;
            this.label3.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "time deposits";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.Snow;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(434, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(338, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.Color.Snow;
            this.lblTime.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(446, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(326, 36);
            this.lblTime.TabIndex = 0;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SavingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMS.Properties.Resources.savingsmenu_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panelMemberCount);
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
            this.Load += new System.EventHandler(this.SavingsMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelMemberCount.ResumeLayout(false);
            this.panelMemberCount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuTransaction;
        private System.Windows.Forms.ToolStripMenuItem itemSavingsAccountTrans;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemTimeDepositApp;
        private System.Windows.Forms.ToolStripMenuItem itemTimeDepositWith;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.ToolStripMenuItem menuMaintenance;
        private System.Windows.Forms.ToolStripMenuItem itemSavingsAccountTypes;
        private System.Windows.Forms.ToolStripMenuItem itemInterestRates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem itemTimeDepositWithdrawal;
        private System.Windows.Forms.ToolStripMenuItem itemOpenAccount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemMemberTermination;
        private System.Windows.Forms.ToolStripMenuItem itemDailyTransactionLog;
        private System.Windows.Forms.ToolStripMenuItem itemStatementOfAccount;
        private System.Windows.Forms.Panel panelMemberCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
    }
}