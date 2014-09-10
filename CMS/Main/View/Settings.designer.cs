﻿namespace CMS.Main.View
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
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBatchProcess = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.btnSavingsSettings = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompany
            // 
            this.btnCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompany.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCompany.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.ForeColor = System.Drawing.Color.White;
            this.btnCompany.Image = global::CMS.Properties.Resources.CompanyProfile;
            this.btnCompany.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompany.Location = new System.Drawing.Point(12, 249);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(227, 111);
            this.btnCompany.TabIndex = 3;
            this.btnCompany.Text = "Company Profile";
            this.btnCompany.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCompany.UseVisualStyleBackColor = false;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(21, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBatchProcess
            // 
            this.btnBatchProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBatchProcess.BackColor = System.Drawing.Color.Firebrick;
            this.btnBatchProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBatchProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchProcess.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchProcess.ForeColor = System.Drawing.Color.White;
            this.btnBatchProcess.Image = global::CMS.Properties.Resources.BatchProcess;
            this.btnBatchProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBatchProcess.Location = new System.Drawing.Point(12, 132);
            this.btnBatchProcess.Name = "btnBatchProcess";
            this.btnBatchProcess.Size = new System.Drawing.Size(227, 111);
            this.btnBatchProcess.TabIndex = 2;
            this.btnBatchProcess.Text = "Batch Process Automation";
            this.btnBatchProcess.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBatchProcess.UseVisualStyleBackColor = false;
            this.btnBatchProcess.Click += new System.EventHandler(this.btnBatchProcess_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelBoard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelSettings);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 530);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 17;
            // 
            // panelBoard
            // 
            this.panelBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBoard.Controls.Add(this.btnUserSettings);
            this.panelBoard.Controls.Add(this.btnSavingsSettings);
            this.panelBoard.Controls.Add(this.btnCompany);
            this.panelBoard.Controls.Add(this.btnBatchProcess);
            this.panelBoard.Controls.Add(this.btnClose);
            this.panelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoard.Location = new System.Drawing.Point(0, 0);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(251, 530);
            this.panelBoard.TabIndex = 0;
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserSettings.BackColor = System.Drawing.Color.DarkViolet;
            this.btnUserSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSettings.ForeColor = System.Drawing.Color.White;
            this.btnUserSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUserSettings.Location = new System.Drawing.Point(12, 366);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(227, 111);
            this.btnUserSettings.TabIndex = 4;
            this.btnUserSettings.Text = "User Settings";
            this.btnUserSettings.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUserSettings.UseVisualStyleBackColor = false;
            // 
            // btnSavingsSettings
            // 
            this.btnSavingsSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavingsSettings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSavingsSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSavingsSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavingsSettings.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavingsSettings.ForeColor = System.Drawing.Color.White;
            this.btnSavingsSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSavingsSettings.Location = new System.Drawing.Point(12, 15);
            this.btnSavingsSettings.Name = "btnSavingsSettings";
            this.btnSavingsSettings.Size = new System.Drawing.Size(227, 111);
            this.btnSavingsSettings.TabIndex = 1;
            this.btnSavingsSettings.Text = "Savings Account Settings";
            this.btnSavingsSettings.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSavingsSettings.UseVisualStyleBackColor = false;
            this.btnSavingsSettings.Click += new System.EventHandler(this.btnSavingsSettings_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(745, 530);
            this.panelSettings.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1000, 530);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnBatchProcess;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnUserSettings;
        private System.Windows.Forms.Button btnSavingsSettings;
        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Panel panelSettings;

    }
}
