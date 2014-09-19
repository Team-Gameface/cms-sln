namespace CMS.Loan_Management.Transaction.View
{
    partial class ShareCapitalContribution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShareCapitalContribution));
            this.tbNewBal = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblBalance = new System.Windows.Forms.Label();
            this.dataGridShare = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAccountNo = new System.Windows.Forms.TextBox();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.rbAcctName = new System.Windows.Forms.RadioButton();
            this.rbAcctNo = new System.Windows.Forms.RadioButton();
            this.groupWithdrawal = new System.Windows.Forms.GroupBox();
            this.tbDepAmt = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShare)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupWithdrawal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNewBal
            // 
            this.tbNewBal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewBal.ContextMenuStrip = this.contextMenuBlank;
            this.tbNewBal.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewBal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbNewBal.Location = new System.Drawing.Point(197, 64);
            this.tbNewBal.Name = "tbNewBal";
            this.tbNewBal.ReadOnly = true;
            this.tbNewBal.Size = new System.Drawing.Size(210, 29);
            this.tbNewBal.TabIndex = 13;
            this.tbNewBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBalance.Location = new System.Drawing.Point(11, 67);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(168, 21);
            this.lblBalance.TabIndex = 12;
            this.lblBalance.Text = "New Account Balance";
            // 
            // dataGridShare
            // 
            this.dataGridShare.AllowUserToAddRows = false;
            this.dataGridShare.AllowUserToDeleteRows = false;
            this.dataGridShare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridShare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridShare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShare.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridShare.Location = new System.Drawing.Point(12, 153);
            this.dataGridShare.Name = "dataGridShare";
            this.dataGridShare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridShare.Size = new System.Drawing.Size(674, 194);
            this.dataGridShare.TabIndex = 8;
            this.dataGridShare.SelectionChanged += new System.EventHandler(this.dataGridShare_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbAccountNo);
            this.groupBox4.Controls.Add(this.tbAccountName);
            this.groupBox4.Controls.Add(this.rbAcctName);
            this.groupBox4.Controls.Add(this.rbAcctNo);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox4.Location = new System.Drawing.Point(12, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(674, 93);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by";
            // 
            // tbAccountNo
            // 
            this.tbAccountNo.Enabled = false;
            this.tbAccountNo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAccountNo.Location = new System.Drawing.Point(296, 26);
            this.tbAccountNo.Name = "tbAccountNo";
            this.tbAccountNo.Size = new System.Drawing.Size(338, 29);
            this.tbAccountNo.TabIndex = 5;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Enabled = false;
            this.tbAccountName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAccountName.Location = new System.Drawing.Point(296, 61);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(338, 29);
            this.tbAccountName.TabIndex = 7;
            // 
            // rbAcctName
            // 
            this.rbAcctName.AutoSize = true;
            this.rbAcctName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAcctName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAcctName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAcctName.Location = new System.Drawing.Point(119, 62);
            this.rbAcctName.Name = "rbAcctName";
            this.rbAcctName.Size = new System.Drawing.Size(132, 25);
            this.rbAcctName.TabIndex = 6;
            this.rbAcctName.TabStop = true;
            this.rbAcctName.Text = "Member Name";
            this.rbAcctName.UseVisualStyleBackColor = true;
            this.rbAcctName.CheckedChanged += new System.EventHandler(this.rbAcctName_CheckedChanged);
            // 
            // rbAcctNo
            // 
            this.rbAcctNo.AutoSize = true;
            this.rbAcctNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAcctNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAcctNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAcctNo.Location = new System.Drawing.Point(119, 27);
            this.rbAcctNo.Name = "rbAcctNo";
            this.rbAcctNo.Size = new System.Drawing.Size(145, 25);
            this.rbAcctNo.TabIndex = 4;
            this.rbAcctNo.TabStop = true;
            this.rbAcctNo.Text = "Account Number";
            this.rbAcctNo.UseVisualStyleBackColor = true;
            this.rbAcctNo.CheckedChanged += new System.EventHandler(this.rbAcctNo_CheckedChanged);
            // 
            // groupWithdrawal
            // 
            this.groupWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupWithdrawal.Controls.Add(this.tbNewBal);
            this.groupWithdrawal.Controls.Add(this.tbDepAmt);
            this.groupWithdrawal.Controls.Add(this.lblBalance);
            this.groupWithdrawal.Controls.Add(this.lblAmount);
            this.groupWithdrawal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupWithdrawal.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupWithdrawal.Location = new System.Drawing.Point(12, 353);
            this.groupWithdrawal.Name = "groupWithdrawal";
            this.groupWithdrawal.Size = new System.Drawing.Size(417, 100);
            this.groupWithdrawal.TabIndex = 9;
            this.groupWithdrawal.TabStop = false;
            this.groupWithdrawal.Text = "Transaction Details:";
            // 
            // tbDepAmt
            // 
            this.tbDepAmt.ContextMenuStrip = this.contextMenuBlank;
            this.tbDepAmt.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepAmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDepAmt.Location = new System.Drawing.Point(197, 29);
            this.tbDepAmt.MaxLength = 9;
            this.tbDepAmt.Name = "tbDepAmt";
            this.tbDepAmt.Size = new System.Drawing.Size(210, 29);
            this.tbDepAmt.TabIndex = 11;
            this.tbDepAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDepAmt.TextChanged += new System.EventHandler(this.tbDepAmt_TextChanged);
            this.tbDepAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopyPaste);
            this.tbDepAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDepAmt_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAmount.Location = new System.Drawing.Point(113, 32);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 21);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 45);
            this.label5.TabIndex = 1;
            this.label5.Text = "Share Capital Contribution";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CMS.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(486, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::CMS.Properties.Resources.Cancel;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(592, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // ShareCapitalContribution
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(704, 466);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupWithdrawal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridShare);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 505);
            this.Name = "ShareCapitalContribution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Share Capital Contribution";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShare)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupWithdrawal.ResumeLayout(false);
            this.groupWithdrawal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewBal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.DataGridView dataGridShare;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAccountNo;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.RadioButton rbAcctName;
        private System.Windows.Forms.RadioButton rbAcctNo;
        private System.Windows.Forms.GroupBox groupWithdrawal;
        private System.Windows.Forms.TextBox tbDepAmt;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}