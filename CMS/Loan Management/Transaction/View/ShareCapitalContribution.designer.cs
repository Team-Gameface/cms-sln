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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupWithdrawal = new System.Windows.Forms.GroupBox();
            this.tbDepAmt = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShare)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupWithdrawal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNewBal
            // 
            this.tbNewBal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewBal.ContextMenuStrip = this.contextMenuBlank;
            this.tbNewBal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.tbNewBal.Location = new System.Drawing.Point(197, 57);
            this.tbNewBal.Name = "tbNewBal";
            this.tbNewBal.ReadOnly = true;
            this.tbNewBal.Size = new System.Drawing.Size(210, 35);
            this.tbNewBal.TabIndex = 12;
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
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(11, 57);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(180, 21);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "New Account Balance:";
            // 
            // dataGridShare
            // 
            this.dataGridShare.AllowUserToAddRows = false;
            this.dataGridShare.AllowUserToDeleteRows = false;
            this.dataGridShare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridShare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridShare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShare.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridShare.Location = new System.Drawing.Point(12, 137);
            this.dataGridShare.Name = "dataGridShare";
            this.dataGridShare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridShare.Size = new System.Drawing.Size(674, 181);
            this.dataGridShare.TabIndex = 7;
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
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(12, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(674, 93);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Member:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by:";
            // 
            // tbAccountNo
            // 
            this.tbAccountNo.Enabled = false;
            this.tbAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbAccountNo.Location = new System.Drawing.Point(252, 26);
            this.tbAccountNo.Name = "tbAccountNo";
            this.tbAccountNo.Size = new System.Drawing.Size(321, 25);
            this.tbAccountNo.TabIndex = 4;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Enabled = false;
            this.tbAccountName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbAccountName.Location = new System.Drawing.Point(252, 57);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(321, 25);
            this.tbAccountName.TabIndex = 6;
            // 
            // rbAcctName
            // 
            this.rbAcctName.AutoSize = true;
            this.rbAcctName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbAcctName.Location = new System.Drawing.Point(119, 58);
            this.rbAcctName.Name = "rbAcctName";
            this.rbAcctName.Size = new System.Drawing.Size(118, 21);
            this.rbAcctName.TabIndex = 5;
            this.rbAcctName.TabStop = true;
            this.rbAcctName.Text = "Member Name:";
            this.rbAcctName.UseVisualStyleBackColor = true;
            this.rbAcctName.CheckedChanged += new System.EventHandler(this.rbAcctName_CheckedChanged);
            // 
            // rbAcctNo
            // 
            this.rbAcctNo.AutoSize = true;
            this.rbAcctNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbAcctNo.Location = new System.Drawing.Point(119, 27);
            this.rbAcctNo.Name = "rbAcctNo";
            this.rbAcctNo.Size = new System.Drawing.Size(127, 21);
            this.rbAcctNo.TabIndex = 3;
            this.rbAcctNo.TabStop = true;
            this.rbAcctNo.Text = "Account Number:";
            this.rbAcctNo.UseVisualStyleBackColor = true;
            this.rbAcctNo.CheckedChanged += new System.EventHandler(this.rbAcctNo_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(482, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 92;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(578, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 32);
            this.btnClear.TabIndex = 93;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // groupWithdrawal
            // 
            this.groupWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupWithdrawal.Controls.Add(this.tbNewBal);
            this.groupWithdrawal.Controls.Add(this.tbDepAmt);
            this.groupWithdrawal.Controls.Add(this.lblBalance);
            this.groupWithdrawal.Controls.Add(this.lblAmount);
            this.groupWithdrawal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.groupWithdrawal.Location = new System.Drawing.Point(27, 324);
            this.groupWithdrawal.Name = "groupWithdrawal";
            this.groupWithdrawal.Size = new System.Drawing.Size(417, 100);
            this.groupWithdrawal.TabIndex = 8;
            this.groupWithdrawal.TabStop = false;
            this.groupWithdrawal.Text = "Transaction Details:";
            // 
            // tbDepAmt
            // 
            this.tbDepAmt.ContextMenuStrip = this.contextMenuBlank;
            this.tbDepAmt.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.tbDepAmt.Location = new System.Drawing.Point(197, 24);
            this.tbDepAmt.MaxLength = 9;
            this.tbDepAmt.Name = "tbDepAmt";
            this.tbDepAmt.Size = new System.Drawing.Size(210, 27);
            this.tbDepAmt.TabIndex = 10;
            this.tbDepAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDepAmt.TextChanged += new System.EventHandler(this.tbDepAmt_TextChanged);
            this.tbDepAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopyPaste);
            this.tbDepAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDepAmt_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F);
            this.lblAmount.Location = new System.Drawing.Point(123, 27);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(68, 20);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(184, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "SHARE CAPITAL TRANSACTION";
            // 
            // ShareCapitalContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(704, 431);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupWithdrawal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridShare);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 470);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupWithdrawal;
        private System.Windows.Forms.TextBox tbDepAmt;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label4;
    }
}