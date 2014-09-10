namespace CMS.Savings.Transaction.View
{
    partial class SavingsTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsTransaction));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.dataMember = new System.Windows.Forms.DataGridView();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.checkRepresentative = new System.Windows.Forms.CheckBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.comboTransaction = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtRepresentative = new System.Windows.Forms.TextBox();
            this.groupWithdrawal = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupAccount = new System.Windows.Forms.GroupBox();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.dataAccountHolder = new System.Windows.Forms.DataGridView();
            this.txtSavingsAccountNo = new System.Windows.Forms.TextBox();
            this.lblSavingsAccount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPassbook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            this.groupWithdrawal.SuspendLayout();
            this.groupAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountHolder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by Account No.:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAccountNo.Location = new System.Drawing.Point(155, 24);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(285, 25);
            this.txtAccountNo.TabIndex = 3;
            // 
            // dataMember
            // 
            this.dataMember.AllowUserToAddRows = false;
            this.dataMember.AllowUserToDeleteRows = false;
            this.dataMember.AllowUserToResizeRows = false;
            this.dataMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMember.BackgroundColor = System.Drawing.Color.Silver;
            this.dataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMember.Location = new System.Drawing.Point(6, 66);
            this.dataMember.MultiSelect = false;
            this.dataMember.Name = "dataMember";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataMember.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMember.Size = new System.Drawing.Size(464, 317);
            this.dataMember.TabIndex = 4;
            // 
            // lblTransaction
            // 
            this.lblTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblTransaction.Location = new System.Drawing.Point(501, 293);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(119, 17);
            this.lblTransaction.TabIndex = 14;
            this.lblTransaction.Text = "Select Transaction:";
            // 
            // checkRepresentative
            // 
            this.checkRepresentative.AutoSize = true;
            this.checkRepresentative.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkRepresentative.Location = new System.Drawing.Point(13, 61);
            this.checkRepresentative.Name = "checkRepresentative";
            this.checkRepresentative.Size = new System.Drawing.Size(165, 21);
            this.checkRepresentative.TabIndex = 19;
            this.checkRepresentative.Text = "done by Representative";
            this.checkRepresentative.UseVisualStyleBackColor = true;
            this.checkRepresentative.CheckedChanged += new System.EventHandler(this.checkRepresentative_CheckedChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F);
            this.lblAmount.Location = new System.Drawing.Point(10, 31);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(68, 20);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Amount:";
            // 
            // comboTransaction
            // 
            this.comboTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTransaction.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboTransaction.FormattingEnabled = true;
            this.comboTransaction.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.comboTransaction.Location = new System.Drawing.Point(629, 290);
            this.comboTransaction.Name = "comboTransaction";
            this.comboTransaction.Size = new System.Drawing.Size(193, 25);
            this.comboTransaction.TabIndex = 15;
            this.comboTransaction.SelectedIndexChanged += new System.EventHandler(this.comboTransaction_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.ContextMenuStrip = this.contextMenuBlank;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtAmount.Location = new System.Drawing.Point(84, 32);
            this.txtAmount.MaxLength = 15;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(238, 27);
            this.txtAmount.TabIndex = 18;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // txtRepresentative
            // 
            this.txtRepresentative.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRepresentative.Location = new System.Drawing.Point(84, 88);
            this.txtRepresentative.Name = "txtRepresentative";
            this.txtRepresentative.Size = new System.Drawing.Size(238, 25);
            this.txtRepresentative.TabIndex = 21;
            // 
            // groupWithdrawal
            // 
            this.groupWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupWithdrawal.Controls.Add(this.txtRepresentative);
            this.groupWithdrawal.Controls.Add(this.txtAmount);
            this.groupWithdrawal.Controls.Add(this.checkRepresentative);
            this.groupWithdrawal.Controls.Add(this.label2);
            this.groupWithdrawal.Controls.Add(this.lblAmount);
            this.groupWithdrawal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.groupWithdrawal.Location = new System.Drawing.Point(494, 321);
            this.groupWithdrawal.Name = "groupWithdrawal";
            this.groupWithdrawal.Size = new System.Drawing.Size(328, 125);
            this.groupWithdrawal.TabIndex = 16;
            this.groupWithdrawal.TabStop = false;
            this.groupWithdrawal.Text = "Transaction Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name:";
            // 
            // groupAccount
            // 
            this.groupAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupAccount.Controls.Add(this.txtAccountBalance);
            this.groupAccount.Controls.Add(this.lblAccountBalance);
            this.groupAccount.Controls.Add(this.lblAccountHolder);
            this.groupAccount.Controls.Add(this.btnView);
            this.groupAccount.Controls.Add(this.dataAccountHolder);
            this.groupAccount.Controls.Add(this.txtSavingsAccountNo);
            this.groupAccount.Controls.Add(this.lblSavingsAccount);
            this.groupAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.groupAccount.Location = new System.Drawing.Point(494, 42);
            this.groupAccount.Name = "groupAccount";
            this.groupAccount.Size = new System.Drawing.Size(328, 242);
            this.groupAccount.TabIndex = 6;
            this.groupAccount.TabStop = false;
            this.groupAccount.Text = "Account Details:";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Enabled = false;
            this.txtAccountBalance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAccountBalance.Location = new System.Drawing.Point(145, 171);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(177, 25);
            this.txtAccountBalance.TabIndex = 12;
            this.txtAccountBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAccountBalance.Location = new System.Drawing.Point(34, 174);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(105, 17);
            this.lblAccountBalance.TabIndex = 11;
            this.lblAccountBalance.Text = "Account Balance:";
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAccountHolder.Location = new System.Drawing.Point(10, 50);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(112, 17);
            this.lblAccountHolder.TabIndex = 9;
            this.lblAccountHolder.Text = "Account Holder/s:";
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(159, 203);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(163, 33);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "&View Signature Card...";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // dataAccountHolder
            // 
            this.dataAccountHolder.AllowUserToAddRows = false;
            this.dataAccountHolder.AllowUserToDeleteRows = false;
            this.dataAccountHolder.AllowUserToResizeRows = false;
            this.dataAccountHolder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataAccountHolder.BackgroundColor = System.Drawing.Color.Silver;
            this.dataAccountHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccountHolder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataAccountHolder.Location = new System.Drawing.Point(10, 70);
            this.dataAccountHolder.MultiSelect = false;
            this.dataAccountHolder.Name = "dataAccountHolder";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAccountHolder.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataAccountHolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAccountHolder.Size = new System.Drawing.Size(312, 95);
            this.dataAccountHolder.TabIndex = 10;
            // 
            // txtSavingsAccountNo
            // 
            this.txtSavingsAccountNo.Enabled = false;
            this.txtSavingsAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSavingsAccountNo.Location = new System.Drawing.Point(170, 28);
            this.txtSavingsAccountNo.Name = "txtSavingsAccountNo";
            this.txtSavingsAccountNo.Size = new System.Drawing.Size(152, 25);
            this.txtSavingsAccountNo.TabIndex = 8;
            // 
            // lblSavingsAccount
            // 
            this.lblSavingsAccount.AutoSize = true;
            this.lblSavingsAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSavingsAccount.Location = new System.Drawing.Point(34, 31);
            this.lblSavingsAccount.Name = "lblSavingsAccount";
            this.lblSavingsAccount.Size = new System.Drawing.Size(130, 17);
            this.lblSavingsAccount.TabIndex = 7;
            this.lblSavingsAccount.Text = "Savings Account No.:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(291, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "SAVINGS TRANSACTION";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(629, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 22;
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
            this.btnClear.Location = new System.Drawing.Point(725, 452);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 32);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnPassbook
            // 
            this.btnPassbook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPassbook.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPassbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassbook.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnPassbook.ForeColor = System.Drawing.Color.White;
            this.btnPassbook.Location = new System.Drawing.Point(182, 437);
            this.btnPassbook.Name = "btnPassbook";
            this.btnPassbook.Size = new System.Drawing.Size(142, 33);
            this.btnPassbook.TabIndex = 5;
            this.btnPassbook.Text = "Re&issue Passbook ";
            this.btnPassbook.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.dataMember);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 389);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Account:";
            // 
            // SavingsTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(834, 496);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPassbook);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupAccount);
            this.Controls.Add(this.comboTransaction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupWithdrawal);
            this.Controls.Add(this.lblTransaction);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(850, 535);
            this.Name = "SavingsTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            this.groupWithdrawal.ResumeLayout(false);
            this.groupWithdrawal.PerformLayout();
            this.groupAccount.ResumeLayout(false);
            this.groupAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountHolder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.DataGridView dataMember;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.CheckBox checkRepresentative;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox comboTransaction;
        private System.Windows.Forms.TextBox txtRepresentative;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox groupWithdrawal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupAccount;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.DataGridView dataAccountHolder;
        private System.Windows.Forms.TextBox txtSavingsAccountNo;
        private System.Windows.Forms.Label lblSavingsAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPassbook;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}