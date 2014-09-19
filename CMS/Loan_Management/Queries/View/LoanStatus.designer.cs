namespace CMS.Loan_Management.Queries.View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanStatus));
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbAccountNo);
            this.groupBox4.Controls.Add(this.tbAccountName);
            this.groupBox4.Controls.Add(this.rbAcctName);
            this.groupBox4.Controls.Add(this.rbAcctNo);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(491, 110);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Loan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(21, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search by";
            // 
            // tbAccountNo
            // 
            this.tbAccountNo.Enabled = false;
            this.tbAccountNo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountNo.Location = new System.Drawing.Point(259, 31);
            this.tbAccountNo.Name = "tbAccountNo";
            this.tbAccountNo.Size = new System.Drawing.Size(220, 29);
            this.tbAccountNo.TabIndex = 5;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Enabled = false;
            this.tbAccountName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountName.Location = new System.Drawing.Point(259, 66);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(220, 29);
            this.tbAccountName.TabIndex = 7;
            // 
            // rbAcctName
            // 
            this.rbAcctName.AutoSize = true;
            this.rbAcctName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAcctName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAcctName.Location = new System.Drawing.Point(104, 67);
            this.rbAcctName.Name = "rbAcctName";
            this.rbAcctName.Size = new System.Drawing.Size(136, 25);
            this.rbAcctName.TabIndex = 6;
            this.rbAcctName.TabStop = true;
            this.rbAcctName.Text = "Member Name:";
            this.rbAcctName.UseVisualStyleBackColor = true;
            this.rbAcctName.CheckedChanged += new System.EventHandler(this.rbAcctName_CheckedChanged);
            // 
            // rbAcctNo
            // 
            this.rbAcctNo.AutoSize = true;
            this.rbAcctNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAcctNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAcctNo.Location = new System.Drawing.Point(104, 32);
            this.rbAcctNo.Name = "rbAcctNo";
            this.rbAcctNo.Size = new System.Drawing.Size(149, 25);
            this.rbAcctNo.TabIndex = 4;
            this.rbAcctNo.TabStop = true;
            this.rbAcctNo.Text = "Account Number:";
            this.rbAcctNo.UseVisualStyleBackColor = true;
            this.rbAcctNo.CheckedChanged += new System.EventHandler(this.rbAcctNo_CheckedChanged);
            // 
            // dataGridLoan
            // 
            this.dataGridLoan.AllowUserToAddRows = false;
            this.dataGridLoan.AllowUserToDeleteRows = false;
            this.dataGridLoan.AllowUserToOrderColumns = true;
            this.dataGridLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridLoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridLoan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridLoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridLoan.Location = new System.Drawing.Point(12, 128);
            this.dataGridLoan.Name = "dataGridLoan";
            this.dataGridLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLoan.Size = new System.Drawing.Size(491, 216);
            this.dataGridLoan.TabIndex = 8;
            // 
            // dataGridPayment
            // 
            this.dataGridPayment.AllowUserToAddRows = false;
            this.dataGridPayment.AllowUserToDeleteRows = false;
            this.dataGridPayment.AllowUserToOrderColumns = true;
            this.dataGridPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPayment.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridPayment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridPayment.Location = new System.Drawing.Point(509, 75);
            this.dataGridPayment.Name = "dataGridPayment";
            this.dataGridPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPayment.Size = new System.Drawing.Size(563, 269);
            this.dataGridPayment.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 93);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(465, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Outstanding Loan Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(467, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(228, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Amortizations Paid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(228, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Maturity Date";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBalance.Location = new System.Drawing.Point(662, 59);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 21);
            this.lblBalance.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(662, 32);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 21);
            this.lblStatus.TabIndex = 21;
            // 
            // lblAmort
            // 
            this.lblAmort.AutoSize = true;
            this.lblAmort.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAmort.Location = new System.Drawing.Point(380, 59);
            this.lblAmort.Name = "lblAmort";
            this.lblAmort.Size = new System.Drawing.Size(0, 21);
            this.lblAmort.TabIndex = 19;
            // 
            // lblMaturity
            // 
            this.lblMaturity.AutoSize = true;
            this.lblMaturity.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaturity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaturity.Location = new System.Drawing.Point(380, 32);
            this.lblMaturity.Name = "lblMaturity";
            this.lblMaturity.Size = new System.Drawing.Size(0, 21);
            this.lblMaturity.TabIndex = 17;
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAmt.Location = new System.Drawing.Point(129, 59);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(0, 21);
            this.lblAmt.TabIndex = 15;
            // 
            // lblGranted
            // 
            this.lblGranted.AutoSize = true;
            this.lblGranted.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGranted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGranted.Location = new System.Drawing.Point(129, 32);
            this.lblGranted.Name = "lblGranted";
            this.lblGranted.Size = new System.Drawing.Size(0, 21);
            this.lblGranted.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(21, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Date Granted";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(22, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Loan Amount";
            // 
            // btnCollaterals
            // 
            this.btnCollaterals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCollaterals.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCollaterals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCollaterals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollaterals.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollaterals.ForeColor = System.Drawing.Color.White;
            this.btnCollaterals.Image = global::CMS.Properties.Resources.ReportView;
            this.btnCollaterals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCollaterals.Location = new System.Drawing.Point(866, 384);
            this.btnCollaterals.Name = "btnCollaterals";
            this.btnCollaterals.Size = new System.Drawing.Size(206, 55);
            this.btnCollaterals.TabIndex = 24;
            this.btnCollaterals.Text = "&Show Collaterals and Co-Makers";
            this.btnCollaterals.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(520, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Payment History";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(740, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Queries - Loan Status";
            // 
            // LoanStatus
            // 
            this.AcceptButton = this.btnCollaterals;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1084, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCollaterals);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridPayment);
            this.Controls.Add(this.dataGridLoan);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 490);
            this.Name = "LoanStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
    }
}