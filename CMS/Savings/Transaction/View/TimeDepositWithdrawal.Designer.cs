namespace CMS.Savings.Transaction.View
{
    partial class TimeDepositWithdrawal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeDepositWithdrawal));
            this.dataTimeDeposit = new System.Windows.Forms.DataGridView();
            this.groupBreakdown = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.txtDepAmt = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCertificateNo = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.radioCertificateNo = new System.Windows.Forms.RadioButton();
            this.radioMemberName = new System.Windows.Forms.RadioButton();
            this.radioAccountNo = new System.Windows.Forms.RadioButton();
            this.groupWithdrawal = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtMaturityDate = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblMaturityStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaturity = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimeDeposit)).BeginInit();
            this.groupBreakdown.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupWithdrawal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTimeDeposit
            // 
            this.dataTimeDeposit.AllowUserToAddRows = false;
            this.dataTimeDeposit.AllowUserToDeleteRows = false;
            this.dataTimeDeposit.AllowUserToResizeRows = false;
            this.dataTimeDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataTimeDeposit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTimeDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTimeDeposit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTimeDeposit.Location = new System.Drawing.Point(14, 152);
            this.dataTimeDeposit.MultiSelect = false;
            this.dataTimeDeposit.Name = "dataTimeDeposit";
            this.dataTimeDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTimeDeposit.Size = new System.Drawing.Size(412, 183);
            this.dataTimeDeposit.TabIndex = 9;
            // 
            // groupBreakdown
            // 
            this.groupBreakdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBreakdown.Controls.Add(this.lblTotal);
            this.groupBreakdown.Controls.Add(this.txtTotal);
            this.groupBreakdown.Controls.Add(this.label5);
            this.groupBreakdown.Controls.Add(this.lblPenalty);
            this.groupBreakdown.Controls.Add(this.label6);
            this.groupBreakdown.Controls.Add(this.lblGross);
            this.groupBreakdown.Controls.Add(this.txtDepAmt);
            this.groupBreakdown.Controls.Add(this.txtGross);
            this.groupBreakdown.Controls.Add(this.txtInterest);
            this.groupBreakdown.Controls.Add(this.txtPenalty);
            this.groupBreakdown.Controls.Add(this.label7);
            this.groupBreakdown.Controls.Add(this.label23);
            this.groupBreakdown.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.groupBreakdown.Location = new System.Drawing.Point(432, 146);
            this.groupBreakdown.Name = "groupBreakdown";
            this.groupBreakdown.Size = new System.Drawing.Size(332, 200);
            this.groupBreakdown.TabIndex = 10;
            this.groupBreakdown.TabStop = false;
            this.groupBreakdown.Text = "Withdrawal Breakdown:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(12, 171);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 20);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total Amount:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(128, 166);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(194, 28);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(57, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "add: Interest Earned:";
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblPenalty.Location = new System.Drawing.Point(11, 123);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(184, 17);
            this.lblPenalty.TabIndex = 18;
            this.lblPenalty.Text = "less: Early Withdrawal Penalties:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(51, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Deposit Amount:";
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Location = new System.Drawing.Point(13, 95);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(99, 17);
            this.lblGross.TabIndex = 16;
            this.lblGross.Text = "Gross Amount:";
            // 
            // txtDepAmt
            // 
            this.txtDepAmt.Enabled = false;
            this.txtDepAmt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDepAmt.Location = new System.Drawing.Point(162, 18);
            this.txtDepAmt.Name = "txtDepAmt";
            this.txtDepAmt.ReadOnly = true;
            this.txtDepAmt.Size = new System.Drawing.Size(160, 25);
            this.txtDepAmt.TabIndex = 12;
            this.txtDepAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGross
            // 
            this.txtGross.Enabled = false;
            this.txtGross.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGross.Location = new System.Drawing.Point(116, 92);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(206, 25);
            this.txtGross.TabIndex = 17;
            this.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterest
            // 
            this.txtInterest.Enabled = false;
            this.txtInterest.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtInterest.Location = new System.Drawing.Point(201, 49);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.ReadOnly = true;
            this.txtInterest.Size = new System.Drawing.Size(121, 25);
            this.txtInterest.TabIndex = 14;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPenalty
            // 
            this.txtPenalty.Enabled = false;
            this.txtPenalty.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPenalty.Location = new System.Drawing.Point(201, 123);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.ReadOnly = true;
            this.txtPenalty.Size = new System.Drawing.Size(121, 25);
            this.txtPenalty.TabIndex = 19;
            this.txtPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))));
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "__________________________________";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 30.75F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(5, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(330, 55);
            this.label23.TabIndex = 15;
            this.label23.Text = "__________________";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(226, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "TIME DEPOSIT WITHDRAWAL";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtCertificateNo);
            this.groupBox4.Controls.Add(this.txtAccountNo);
            this.groupBox4.Controls.Add(this.txtMemberName);
            this.groupBox4.Controls.Add(this.radioCertificateNo);
            this.groupBox4.Controls.Add(this.radioMemberName);
            this.groupBox4.Controls.Add(this.radioAccountNo);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(14, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 106);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Member:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by:";
            // 
            // txtCertificateNo
            // 
            this.txtCertificateNo.Enabled = false;
            this.txtCertificateNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCertificateNo.Location = new System.Drawing.Point(320, 78);
            this.txtCertificateNo.Name = "txtCertificateNo";
            this.txtCertificateNo.Size = new System.Drawing.Size(367, 25);
            this.txtCertificateNo.TabIndex = 8;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAccountNo.Location = new System.Drawing.Point(320, 17);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(367, 25);
            this.txtAccountNo.TabIndex = 4;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMemberName.Location = new System.Drawing.Point(320, 48);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(367, 25);
            this.txtMemberName.TabIndex = 6;
            // 
            // radioCertificateNo
            // 
            this.radioCertificateNo.AutoSize = true;
            this.radioCertificateNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radioCertificateNo.Location = new System.Drawing.Point(121, 79);
            this.radioCertificateNo.Name = "radioCertificateNo";
            this.radioCertificateNo.Size = new System.Drawing.Size(193, 21);
            this.radioCertificateNo.TabIndex = 7;
            this.radioCertificateNo.TabStop = true;
            this.radioCertificateNo.Text = "Time Deposit Certificate No.:";
            this.radioCertificateNo.UseVisualStyleBackColor = true;
            this.radioCertificateNo.CheckedChanged += new System.EventHandler(this.radioCertificateNo_CheckedChanged);
            // 
            // radioMemberName
            // 
            this.radioMemberName.AutoSize = true;
            this.radioMemberName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radioMemberName.Location = new System.Drawing.Point(121, 49);
            this.radioMemberName.Name = "radioMemberName";
            this.radioMemberName.Size = new System.Drawing.Size(118, 21);
            this.radioMemberName.TabIndex = 5;
            this.radioMemberName.TabStop = true;
            this.radioMemberName.Text = "Member Name:";
            this.radioMemberName.UseVisualStyleBackColor = true;
            this.radioMemberName.CheckedChanged += new System.EventHandler(this.radioMemberName_CheckedChanged);
            // 
            // radioAccountNo
            // 
            this.radioAccountNo.AutoSize = true;
            this.radioAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radioAccountNo.Location = new System.Drawing.Point(121, 18);
            this.radioAccountNo.Name = "radioAccountNo";
            this.radioAccountNo.Size = new System.Drawing.Size(127, 21);
            this.radioAccountNo.TabIndex = 3;
            this.radioAccountNo.TabStop = true;
            this.radioAccountNo.Text = "Account Number:";
            this.radioAccountNo.UseVisualStyleBackColor = true;
            this.radioAccountNo.CheckedChanged += new System.EventHandler(this.radioAccountNo_CheckedChanged);
            // 
            // groupWithdrawal
            // 
            this.groupWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupWithdrawal.Controls.Add(this.label3);
            this.groupWithdrawal.Controls.Add(this.txtDate);
            this.groupWithdrawal.Controls.Add(this.lblDeposit);
            this.groupWithdrawal.Controls.Add(this.txtMaturityDate);
            this.groupWithdrawal.Controls.Add(this.txtDeposit);
            this.groupWithdrawal.Controls.Add(this.lblMaturityStatus);
            this.groupWithdrawal.Controls.Add(this.label2);
            this.groupWithdrawal.Controls.Add(this.lblMaturity);
            this.groupWithdrawal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.groupWithdrawal.Location = new System.Drawing.Point(14, 343);
            this.groupWithdrawal.Name = "groupWithdrawal";
            this.groupWithdrawal.Size = new System.Drawing.Size(750, 85);
            this.groupWithdrawal.TabIndex = 23;
            this.groupWithdrawal.TabStop = false;
            this.groupWithdrawal.Text = "TIme Deposit Account Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(36, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Application Date";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDate.Location = new System.Drawing.Point(147, 20);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(181, 25);
            this.txtDate.TabIndex = 32;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDeposit.Location = new System.Drawing.Point(36, 54);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(105, 17);
            this.lblDeposit.TabIndex = 26;
            this.lblDeposit.Text = "Deposit Amount:";
            // 
            // txtMaturityDate
            // 
            this.txtMaturityDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaturityDate.Location = new System.Drawing.Point(492, 20);
            this.txtMaturityDate.Name = "txtMaturityDate";
            this.txtMaturityDate.ReadOnly = true;
            this.txtMaturityDate.Size = new System.Drawing.Size(181, 25);
            this.txtMaturityDate.TabIndex = 28;
            this.txtMaturityDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDeposit.Location = new System.Drawing.Point(147, 51);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.ReadOnly = true;
            this.txtDeposit.Size = new System.Drawing.Size(181, 25);
            this.txtDeposit.TabIndex = 27;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMaturityStatus
            // 
            this.lblMaturityStatus.AutoSize = true;
            this.lblMaturityStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblMaturityStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMaturityStatus.Location = new System.Drawing.Point(489, 54);
            this.lblMaturityStatus.Name = "lblMaturityStatus";
            this.lblMaturityStatus.Size = new System.Drawing.Size(0, 17);
            this.lblMaturityStatus.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(382, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Maturity Status:";
            // 
            // lblMaturity
            // 
            this.lblMaturity.AutoSize = true;
            this.lblMaturity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMaturity.Location = new System.Drawing.Point(382, 23);
            this.lblMaturity.Name = "lblMaturity";
            this.lblMaturity.Size = new System.Drawing.Size(90, 17);
            this.lblMaturity.TabIndex = 30;
            this.lblMaturity.Text = "Maturity Date:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(565, 434);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 31;
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
            this.btnClear.Location = new System.Drawing.Point(661, 434);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 32);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // TimeDepositWithdrawal
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(770, 473);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBreakdown);
            this.Controls.Add(this.dataTimeDeposit);
            this.Controls.Add(this.groupWithdrawal);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(786, 512);
            this.Name = "TimeDepositWithdrawal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Deposit Withdrawal";
            ((System.ComponentModel.ISupportInitialize)(this.dataTimeDeposit)).EndInit();
            this.groupBreakdown.ResumeLayout(false);
            this.groupBreakdown.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupWithdrawal.ResumeLayout(false);
            this.groupWithdrawal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTimeDeposit;
        private System.Windows.Forms.GroupBox groupBreakdown;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.RadioButton radioCertificateNo;
        private System.Windows.Forms.RadioButton radioMemberName;
        private System.Windows.Forms.RadioButton radioAccountNo;
        private System.Windows.Forms.TextBox txtCertificateNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepAmt;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.GroupBox groupWithdrawal;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblMaturityStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaturity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtMaturityDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
    }
}