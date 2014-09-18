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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatementOfAccount));
            this.label4 = new System.Windows.Forms.Label();
            this.dataMember = new System.Windows.Forms.DataGridView();
            this.dataTransactions = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAccountHolders = new System.Windows.Forms.Label();
            this.lblAcctType = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.rbMemberName = new System.Windows.Forms.RadioButton();
            this.rbAccountNo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "Statement of Accounts";
            // 
            // dataMember
            // 
            this.dataMember.AllowUserToAddRows = false;
            this.dataMember.AllowUserToDeleteRows = false;
            this.dataMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMember.BackgroundColor = System.Drawing.Color.Silver;
            this.dataMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMember.Location = new System.Drawing.Point(12, 168);
            this.dataMember.MultiSelect = false;
            this.dataMember.Name = "dataMember";
            this.dataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMember.Size = new System.Drawing.Size(426, 304);
            this.dataMember.TabIndex = 7;
            // 
            // dataTransactions
            // 
            this.dataTransactions.AllowUserToAddRows = false;
            this.dataTransactions.AllowUserToDeleteRows = false;
            this.dataTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTransactions.BackgroundColor = System.Drawing.Color.Silver;
            this.dataTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTransactions.Location = new System.Drawing.Point(444, 168);
            this.dataTransactions.MultiSelect = false;
            this.dataTransactions.Name = "dataTransactions";
            this.dataTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTransactions.Size = new System.Drawing.Size(536, 304);
            this.dataTransactions.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(444, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Transaction History:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(331, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(26, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(26, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Account Holder/s:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBalance.Location = new System.Drawing.Point(407, 29);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 21);
            this.lblBalance.TabIndex = 16;
            // 
            // lblAccountHolders
            // 
            this.lblAccountHolders.AutoSize = true;
            this.lblAccountHolders.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountHolders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccountHolders.Location = new System.Drawing.Point(192, 89);
            this.lblAccountHolders.Name = "lblAccountHolders";
            this.lblAccountHolders.Size = new System.Drawing.Size(0, 21);
            this.lblAccountHolders.TabIndex = 14;
            // 
            // lblAcctType
            // 
            this.lblAcctType.AutoSize = true;
            this.lblAcctType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAcctType.Location = new System.Drawing.Point(192, 29);
            this.lblAcctType.Name = "lblAcctType";
            this.lblAcctType.Size = new System.Drawing.Size(0, 21);
            this.lblAcctType.TabIndex = 10;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccountNo.Location = new System.Drawing.Point(192, 59);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(0, 21);
            this.lblAccountNo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Savings Account No:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccountNo.Location = new System.Drawing.Point(176, 31);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(244, 29);
            this.txtAccountNo.TabIndex = 4;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberName.Location = new System.Drawing.Point(176, 66);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(244, 29);
            this.txtMemberName.TabIndex = 6;
            // 
            // rbMemberName
            // 
            this.rbMemberName.AutoSize = true;
            this.rbMemberName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMemberName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbMemberName.Location = new System.Drawing.Point(21, 67);
            this.rbMemberName.Name = "rbMemberName";
            this.rbMemberName.Size = new System.Drawing.Size(132, 25);
            this.rbMemberName.TabIndex = 5;
            this.rbMemberName.TabStop = true;
            this.rbMemberName.Text = "Member Name";
            this.rbMemberName.UseVisualStyleBackColor = true;
            this.rbMemberName.CheckedChanged += new System.EventHandler(this.rbMemberName_CheckedChanged);
            // 
            // rbAccountNo
            // 
            this.rbAccountNo.AutoSize = true;
            this.rbAccountNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAccountNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAccountNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAccountNo.Location = new System.Drawing.Point(21, 32);
            this.rbAccountNo.Name = "rbAccountNo";
            this.rbAccountNo.Size = new System.Drawing.Size(145, 25);
            this.rbAccountNo.TabIndex = 3;
            this.rbAccountNo.TabStop = true;
            this.rbAccountNo.Text = "Account Number";
            this.rbAccountNo.UseVisualStyleBackColor = true;
            this.rbAccountNo.CheckedChanged += new System.EventHandler(this.rbAccountNo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rbAccountNo);
            this.groupBox1.Controls.Add(this.rbMemberName);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblAccountNo);
            this.groupBox2.Controls.Add(this.lblAccountHolders);
            this.groupBox2.Controls.Add(this.lblBalance);
            this.groupBox2.Controls.Add(this.lblAcctType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(444, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 125);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Details";
            // 
            // StatementOfAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(994, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataMember);
            this.Controls.Add(this.dataTransactions);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1010, 525);
            this.Name = "StatementOfAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statement of Account";
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataMember;
        private System.Windows.Forms.DataGridView dataTransactions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccountHolders;
        private System.Windows.Forms.Label lblAcctType;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.RadioButton rbMemberName;
        private System.Windows.Forms.RadioButton rbAccountNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;



    }
}