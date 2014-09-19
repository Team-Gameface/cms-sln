namespace CMS.Main.View
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flowSwitchboard = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSavingsSettings = new System.Windows.Forms.Button();
            this.btnBatchProcess = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnBackupRestore = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowSwitchboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.flowSwitchboard);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelSettings);
            this.splitContainer.Size = new System.Drawing.Size(1000, 530);
            this.splitContainer.SplitterDistance = 175;
            this.splitContainer.TabIndex = 17;
            // 
            // flowSwitchboard
            // 
            this.flowSwitchboard.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowSwitchboard.Controls.Add(this.btnSavingsSettings);
            this.flowSwitchboard.Controls.Add(this.btnBatchProcess);
            this.flowSwitchboard.Controls.Add(this.btnCompany);
            this.flowSwitchboard.Controls.Add(this.btnUserManagement);
            this.flowSwitchboard.Controls.Add(this.btnBackupRestore);
            this.flowSwitchboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSwitchboard.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowSwitchboard.Location = new System.Drawing.Point(0, 0);
            this.flowSwitchboard.Name = "flowSwitchboard";
            this.flowSwitchboard.Size = new System.Drawing.Size(175, 530);
            this.flowSwitchboard.TabIndex = 0;
            // 
            // btnSavingsSettings
            // 
            this.btnSavingsSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavingsSettings.BackColor = System.Drawing.Color.Firebrick;
            this.btnSavingsSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSavingsSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavingsSettings.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavingsSettings.ForeColor = System.Drawing.Color.White;
            this.btnSavingsSettings.Image = global::CMS.Properties.Resources.SavingsAccount;
            this.btnSavingsSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSavingsSettings.Location = new System.Drawing.Point(3, 3);
            this.btnSavingsSettings.Name = "btnSavingsSettings";
            this.btnSavingsSettings.Size = new System.Drawing.Size(170, 80);
            this.btnSavingsSettings.TabIndex = 15;
            this.btnSavingsSettings.Text = "Savings Account Settings";
            this.btnSavingsSettings.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSavingsSettings.UseVisualStyleBackColor = false;
            this.btnSavingsSettings.Click += new System.EventHandler(this.btnSavingsSettings_Click);
            // 
            // btnBatchProcess
            // 
            this.btnBatchProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBatchProcess.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBatchProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBatchProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchProcess.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchProcess.ForeColor = System.Drawing.Color.White;
            this.btnBatchProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnBatchProcess.Image")));
            this.btnBatchProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBatchProcess.Location = new System.Drawing.Point(3, 89);
            this.btnBatchProcess.Name = "btnBatchProcess";
            this.btnBatchProcess.Size = new System.Drawing.Size(170, 80);
            this.btnBatchProcess.TabIndex = 16;
            this.btnBatchProcess.Text = "Batch Process Automation";
            this.btnBatchProcess.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBatchProcess.UseVisualStyleBackColor = false;
            this.btnBatchProcess.Click += new System.EventHandler(this.btnBatchProcess_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompany.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCompany.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.ForeColor = System.Drawing.Color.White;
            this.btnCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnCompany.Image")));
            this.btnCompany.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompany.Location = new System.Drawing.Point(3, 175);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(170, 80);
            this.btnCompany.TabIndex = 17;
            this.btnCompany.Text = "Company Profile";
            this.btnCompany.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCompany.UseVisualStyleBackColor = false;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserManagement.BackColor = System.Drawing.Color.DarkViolet;
            this.btnUserManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Image = global::CMS.Properties.Resources.UserManagement;
            this.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUserManagement.Location = new System.Drawing.Point(3, 261);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(170, 80);
            this.btnUserManagement.TabIndex = 18;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackupRestore.BackColor = System.Drawing.Color.Crimson;
            this.btnBackupRestore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackupRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupRestore.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupRestore.ForeColor = System.Drawing.Color.White;
            this.btnBackupRestore.Image = global::CMS.Properties.Resources.BackupRestore;
            this.btnBackupRestore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBackupRestore.Location = new System.Drawing.Point(3, 347);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.Size = new System.Drawing.Size(170, 80);
            this.btnBackupRestore.TabIndex = 19;
            this.btnBackupRestore.Text = "Backup/Restore Database";
            this.btnBackupRestore.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBackupRestore.UseVisualStyleBackColor = false;
            this.btnBackupRestore.Click += new System.EventHandler(this.btnBackupRestore_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.Honeydew;
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(821, 530);
            this.panelSettings.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1000, 530);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowSwitchboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.FlowLayoutPanel flowSwitchboard;
        private System.Windows.Forms.Button btnSavingsSettings;
        private System.Windows.Forms.Button btnBatchProcess;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnBackupRestore;

    }
}
