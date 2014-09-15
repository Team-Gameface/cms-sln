namespace CMS.Savings.Queries.View
{
    partial class StatementOfAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatementOfAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.rbMemberName = new System.Windows.Forms.RadioButton();
            this.rbAccountNo = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataTransactions = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAcctType = new System.Windows.Forms.Label();
            this.lblAccountHolders = new System.Windows.Forms.Label();
            this.dataMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search by:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAccountNo.Location = new System.Drawing.Point(145, 65);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(180, 25);
            this.txtAccountNo.TabIndex = 9;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMemberName.Location = new System.Drawing.Point(125, 92);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(200, 25);
            this.txtMemberName.TabIndex = 11;
            // 
            // rbMemberName
            // 
            this.rbMemberName.AutoSize = true;
            this.rbMemberName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbMemberName.Location = new System.Drawing.Point(11, 93);
            this.rbMemberName.Name = "rbMemberName";
            this.rbMemberName.Size = new System.Drawing.Size(118, 21);
            this.rbMemberName.TabIndex = 10;
            this.rbMemberName.TabStop = true;
            this.rbMemberName.Text = "Member Name:";
            this.rbMemberName.UseVisualStyleBackColor = true;
            this.rbMemberName.CheckedChanged += new System.EventHandler(this.rbMemberName_CheckedChanged);
            // 
            // rbAccountNo
            // 
            this.rbAccountNo.AutoSize = true;
            this.rbAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbAccountNo.Location = new System.Drawing.Point(11, 65);
            this.rbAccountNo.Name = "rbAccountNo";
            this.rbAccountNo.Size = new System.Drawing.Size(127, 21);
            this.rbAccountNo.TabIndex = 8;
            this.rbAccountNo.TabStop = true;
            this.rbAccountNo.Text = "Account Number:";
            this.rbAccountNo.UseVisualStyleBackColor = true;
            this.rbAccountNo.CheckedChanged += new System.EventHandler(this.rbAccountNo_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(246, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Savings Account #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Account Holder/s:";
            // 
            // dataTransactions
            // 
            this.dataTransactions.AllowUserToAddRows = false;
            this.dataTransactions.AllowUserToDeleteRows = false;
            this.dataTransactions.AllowUserToResizeRows = false;
            this.dataTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTransactions.BackgroundColor = System.Drawing.Color.Silver;
            this.dataTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTransactions.Location = new System.Drawing.Point(331, 153);
            this.dataTransactions.MultiSelect = false;
            this.dataTransactions.Name = "dataTransactions";
            this.dataTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTransactions.Size = new System.Drawing.Size(536, 304);
            this.dataTransactions.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Queries - Statement of Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Transaction History:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Account Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(652, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Balance:";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAccountNo.Location = new System.Drawing.Point(510, 47);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(0, 20);
            this.lblAccountNo.TabIndex = 13;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBalance.Location = new System.Drawing.Point(732, 46);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 20);
            this.lblBalance.TabIndex = 13;
            // 
            // lblAcctType
            // 
            this.lblAcctType.AutoSize = true;
            this.lblAcctType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAcctType.Location = new System.Drawing.Point(510, 68);
            this.lblAcctType.Name = "lblAcctType";
            this.lblAcctType.Size = new System.Drawing.Size(0, 20);
            this.lblAcctType.TabIndex = 13;
            // 
            // lblAccountHolders
            // 
            this.lblAccountHolders.AutoSize = true;
            this.lblAccountHolders.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAccountHolders.Location = new System.Drawing.Point(510, 88);
            this.lblAccountHolders.Name = "lblAccountHolders";
            this.lblAccountHolders.Size = new System.Drawing.Size(0, 20);
            this.lblAccountHolders.TabIndex = 13;
            // 
            // dataMember
            // 
            this.dataMember.AllowUserToAddRows = false;
            this.dataMember.AllowUserToDeleteRows = false;
            this.dataMember.AllowUserToResizeRows = false;
            this.dataMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMember.BackgroundColor = System.Drawing.Color.Silver;
            this.dataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMember.Location = new System.Drawing.Point(11, 153);
            this.dataMember.MultiSelect = false;
            this.dataMember.Name = "dataMember";
            this.dataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMember.Size = new System.Drawing.Size(314, 304);
            this.dataMember.TabIndex = 14;
            // 
            // StatementOfAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(880, 479);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataMember);
            this.Controls.Add(this.dataTransactions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccountHolders);
            this.Controls.Add(this.lblAcctType);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.rbMemberName);
            this.Controls.Add(this.rbAccountNo);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatementOfAccount";
            this.Text = "Statement of Account";
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.RadioButton rbMemberName;
        private System.Windows.Forms.RadioButton rbAccountNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataTransactions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAcctType;
        private System.Windows.Forms.Label lblAccountHolders;
        private System.Windows.Forms.DataGridView dataMember;

    }
}