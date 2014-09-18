namespace CMS.Loan_Management.Reports.View
{
    partial class LoanStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAccountNo = new System.Windows.Forms.TextBox();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.rbAcctName = new System.Windows.Forms.RadioButton();
            this.rbAcctNo = new System.Windows.Forms.RadioButton();
            this.dataGridLoan = new System.Windows.Forms.DataGridView();
            this.dataGridPayment = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAmort = new System.Windows.Forms.Label();
            this.lblMaturity = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            this.lblGranted = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCollaterals = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Queries - Loan Status";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbAccountNo);
            this.groupBox4.Controls.Add(this.tbAccountName);
            this.groupBox4.Controls.Add(this.rbAcctName);
            this.groupBox4.Controls.Add(this.rbAcctNo);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(9, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(674, 93);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Loan:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(45, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search by:";
            // 
            // tbAccountNo
            // 
            this.tbAccountNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAccountNo.Enabled = false;
            this.tbAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbAccountNo.Location = new System.Drawing.Point(252, 28);
            this.tbAccountNo.Name = "tbAccountNo";
            this.tbAccountNo.Size = new System.Drawing.Size(321, 25);
            this.tbAccountNo.TabIndex = 4;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAccountName.Enabled = false;
            this.tbAccountName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbAccountName.Location = new System.Drawing.Point(252, 59);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(321, 25);
            this.tbAccountName.TabIndex = 6;
            // 
            // rbAcctName
            // 
            this.rbAcctName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAcctName.AutoSize = true;
            this.rbAcctName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbAcctName.Location = new System.Drawing.Point(119, 60);
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
            this.rbAcctNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAcctNo.AutoSize = true;
            this.rbAcctNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbAcctNo.Location = new System.Drawing.Point(119, 29);
            this.rbAcctNo.Name = "rbAcctNo";
            this.rbAcctNo.Size = new System.Drawing.Size(127, 21);
            this.rbAcctNo.TabIndex = 3;
            this.rbAcctNo.TabStop = true;
            this.rbAcctNo.Text = "Account Number:";
            this.rbAcctNo.UseVisualStyleBackColor = true;
            this.rbAcctNo.CheckedChanged += new System.EventHandler(this.rbAcctNo_CheckedChanged);
            // 
            // dataGridLoan
            // 
            this.dataGridLoan.AllowUserToAddRows = false;
            this.dataGridLoan.AllowUserToDeleteRows = false;
            this.dataGridLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridLoan.Location = new System.Drawing.Point(9, 163);
            this.dataGridLoan.Name = "dataGridLoan";
            this.dataGridLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLoan.Size = new System.Drawing.Size(382, 181);
            this.dataGridLoan.TabIndex = 38;
            // 
            // dataGridPayment
            // 
            this.dataGridPayment.AllowUserToAddRows = false;
            this.dataGridPayment.AllowUserToDeleteRows = false;
            this.dataGridPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPayment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridPayment.Location = new System.Drawing.Point(397, 163);
            this.dataGridPayment.Name = "dataGridPayment";
            this.dataGridPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPayment.Size = new System.Drawing.Size(286, 181);
            this.dataGridPayment.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblAmort);
            this.groupBox1.Controls.Add(this.lblMaturity);
            this.groupBox1.Controls.Add(this.lblAmt);
            this.groupBox1.Controls.Add(this.lblGranted);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(9, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 93);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Details:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(385, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Outstanding Loan Balance:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(501, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Status:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(219, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Amortizations Paid:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.Location = new System.Drawing.Point(219, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Maturity Date:";
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBalance.Location = new System.Drawing.Point(553, 59);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 17);
            this.lblBalance.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStatus.Location = new System.Drawing.Point(553, 32);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 2;
            // 
            // lblAmort
            // 
            this.lblAmort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmort.AutoSize = true;
            this.lblAmort.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAmort.Location = new System.Drawing.Point(345, 59);
            this.lblAmort.Name = "lblAmort";
            this.lblAmort.Size = new System.Drawing.Size(0, 17);
            this.lblAmort.TabIndex = 2;
            // 
            // lblMaturity
            // 
            this.lblMaturity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaturity.AutoSize = true;
            this.lblMaturity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMaturity.Location = new System.Drawing.Point(315, 32);
            this.lblMaturity.Name = "lblMaturity";
            this.lblMaturity.Size = new System.Drawing.Size(0, 17);
            this.lblMaturity.TabIndex = 2;
            // 
            // lblAmt
            // 
            this.lblAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmt.AutoSize = true;
            this.lblAmt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAmt.Location = new System.Drawing.Point(116, 59);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(0, 17);
            this.lblAmt.TabIndex = 2;
            // 
            // lblGranted
            // 
            this.lblGranted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGranted.AutoSize = true;
            this.lblGranted.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblGranted.Location = new System.Drawing.Point(116, 32);
            this.lblGranted.Name = "lblGranted";
            this.lblGranted.Size = new System.Drawing.Size(0, 17);
            this.lblGranted.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label9.Location = new System.Drawing.Point(24, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Date Granted:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loan Amount:";
            // 
            // btnCollaterals
            // 
            this.btnCollaterals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCollaterals.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCollaterals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCollaterals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollaterals.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCollaterals.ForeColor = System.Drawing.Color.White;
            this.btnCollaterals.Location = new System.Drawing.Point(442, 457);
            this.btnCollaterals.Name = "btnCollaterals";
            this.btnCollaterals.Size = new System.Drawing.Size(241, 32);
            this.btnCollaterals.TabIndex = 40;
            this.btnCollaterals.Text = "Show Collaterals and Co-makers...";
            this.btnCollaterals.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(394, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment History:";
            // 
            // LoanStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(690, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCollaterals);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridPayment);
            this.Controls.Add(this.dataGridLoan);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoanStatus";
            this.Text = "Loan Status";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAccountNo;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.RadioButton rbAcctName;
        private System.Windows.Forms.RadioButton rbAcctNo;
        private System.Windows.Forms.DataGridView dataGridLoan;
        private System.Windows.Forms.DataGridView dataGridPayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCollaterals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAmort;
        private System.Windows.Forms.Label lblMaturity;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Label lblGranted;
    }
}