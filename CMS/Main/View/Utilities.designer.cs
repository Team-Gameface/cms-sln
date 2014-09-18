namespace CMS.Main.View
{
    partial class Utilities
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
            this.flowSwitchBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoanCalc = new System.Windows.Forms.Button();
            this.btnTimeDepositCalc = new System.Windows.Forms.Button();
            this.btnAudit = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelUtilities = new System.Windows.Forms.Panel();
            this.flowSwitchBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowSwitchBoard
            // 
            this.flowSwitchBoard.BackColor = System.Drawing.Color.DarkCyan;
            this.flowSwitchBoard.Controls.Add(this.btnLoanCalc);
            this.flowSwitchBoard.Controls.Add(this.btnTimeDepositCalc);
            this.flowSwitchBoard.Controls.Add(this.btnAudit);
            this.flowSwitchBoard.Controls.Add(this.btnAccount);
            this.flowSwitchBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSwitchBoard.Location = new System.Drawing.Point(0, 0);
            this.flowSwitchBoard.Name = "flowSwitchBoard";
            this.flowSwitchBoard.Size = new System.Drawing.Size(175, 530);
            this.flowSwitchBoard.TabIndex = 12;
            // 
            // btnLoanCalc
            // 
            this.btnLoanCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoanCalc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoanCalc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoanCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanCalc.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanCalc.ForeColor = System.Drawing.Color.White;
            this.btnLoanCalc.Image = global::CMS.Properties.Resources.Calculator;
            this.btnLoanCalc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoanCalc.Location = new System.Drawing.Point(3, 3);
            this.btnLoanCalc.Name = "btnLoanCalc";
            this.btnLoanCalc.Size = new System.Drawing.Size(170, 80);
            this.btnLoanCalc.TabIndex = 16;
            this.btnLoanCalc.Text = "Loan Calculator";
            this.btnLoanCalc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLoanCalc.UseVisualStyleBackColor = false;
            this.btnLoanCalc.Click += new System.EventHandler(this.btnLoanCalc_Click);
            // 
            // btnTimeDepositCalc
            // 
            this.btnTimeDepositCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimeDepositCalc.BackColor = System.Drawing.Color.Firebrick;
            this.btnTimeDepositCalc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTimeDepositCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeDepositCalc.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeDepositCalc.ForeColor = System.Drawing.Color.White;
            this.btnTimeDepositCalc.Image = global::CMS.Properties.Resources.Calculator;
            this.btnTimeDepositCalc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimeDepositCalc.Location = new System.Drawing.Point(3, 89);
            this.btnTimeDepositCalc.Name = "btnTimeDepositCalc";
            this.btnTimeDepositCalc.Size = new System.Drawing.Size(170, 80);
            this.btnTimeDepositCalc.TabIndex = 17;
            this.btnTimeDepositCalc.Text = "Time Deposit Calculator";
            this.btnTimeDepositCalc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTimeDepositCalc.UseVisualStyleBackColor = false;
            this.btnTimeDepositCalc.Click += new System.EventHandler(this.btnTimeDepositCalc_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAudit.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAudit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudit.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudit.ForeColor = System.Drawing.Color.White;
            this.btnAudit.Image = global::CMS.Properties.Resources.AuditLog;
            this.btnAudit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAudit.Location = new System.Drawing.Point(3, 175);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(170, 80);
            this.btnAudit.TabIndex = 18;
            this.btnAudit.Text = "Audit Log";
            this.btnAudit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAudit.UseVisualStyleBackColor = false;
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccount.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::CMS.Properties.Resources.AccountSettings;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccount.Location = new System.Drawing.Point(3, 261);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(170, 80);
            this.btnAccount.TabIndex = 19;
            this.btnAccount.Text = "Account Settings";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
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
            this.splitContainer.Panel1.Controls.Add(this.flowSwitchBoard);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelUtilities);
            this.splitContainer.Size = new System.Drawing.Size(1000, 530);
            this.splitContainer.SplitterDistance = 175;
            this.splitContainer.TabIndex = 13;
            // 
            // panelUtilities
            // 
            this.panelUtilities.BackColor = System.Drawing.Color.Honeydew;
            this.panelUtilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUtilities.Location = new System.Drawing.Point(0, 0);
            this.panelUtilities.Name = "panelUtilities";
            this.panelUtilities.Size = new System.Drawing.Size(821, 530);
            this.panelUtilities.TabIndex = 0;
            // 
            // Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Utilities";
            this.Size = new System.Drawing.Size(1000, 530);
            this.flowSwitchBoard.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowSwitchBoard;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelUtilities;
        private System.Windows.Forms.Button btnLoanCalc;
        private System.Windows.Forms.Button btnTimeDepositCalc;
        private System.Windows.Forms.Button btnAudit;
        private System.Windows.Forms.Button btnAccount;

    }
}
