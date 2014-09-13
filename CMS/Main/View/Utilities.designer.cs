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
            this.btnAudit = new System.Windows.Forms.Button();
            this.btnLoanCalc = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnTimeDepositCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAudit
            // 
            this.btnAudit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAudit.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAudit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudit.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudit.ForeColor = System.Drawing.Color.White;
            this.btnAudit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAudit.Location = new System.Drawing.Point(246, 130);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(227, 111);
            this.btnAudit.TabIndex = 11;
            this.btnAudit.Text = "Audit Log";
            this.btnAudit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAudit.UseVisualStyleBackColor = false;
            // 
            // btnLoanCalc
            // 
            this.btnLoanCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoanCalc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoanCalc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoanCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanCalc.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanCalc.ForeColor = System.Drawing.Color.White;
            this.btnLoanCalc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoanCalc.Location = new System.Drawing.Point(13, 13);
            this.btnLoanCalc.Name = "btnLoanCalc";
            this.btnLoanCalc.Size = new System.Drawing.Size(227, 111);
            this.btnLoanCalc.TabIndex = 8;
            this.btnLoanCalc.Text = "Loan Calculator";
            this.btnLoanCalc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLoanCalc.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccount.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccount.Location = new System.Drawing.Point(13, 130);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(227, 111);
            this.btnAccount.TabIndex = 10;
            this.btnAccount.Text = "Account Settings";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // btnTimeDepositCalc
            // 
            this.btnTimeDepositCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimeDepositCalc.BackColor = System.Drawing.Color.Firebrick;
            this.btnTimeDepositCalc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTimeDepositCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeDepositCalc.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeDepositCalc.ForeColor = System.Drawing.Color.White;
            this.btnTimeDepositCalc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimeDepositCalc.Location = new System.Drawing.Point(246, 13);
            this.btnTimeDepositCalc.Name = "btnTimeDepositCalc";
            this.btnTimeDepositCalc.Size = new System.Drawing.Size(227, 111);
            this.btnTimeDepositCalc.TabIndex = 9;
            this.btnTimeDepositCalc.Text = "Time Deposit Calculator";
            this.btnTimeDepositCalc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTimeDepositCalc.UseVisualStyleBackColor = false;
            // 
            // Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAudit);
            this.Controls.Add(this.btnLoanCalc);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnTimeDepositCalc);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Utilities";
            this.Size = new System.Drawing.Size(489, 257);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAudit;
        private System.Windows.Forms.Button btnLoanCalc;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnTimeDepositCalc;

    }
}
