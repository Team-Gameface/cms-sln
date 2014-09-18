namespace CMS.Savings.Transaction.View
{
    partial class SavingsTermination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsTermination));
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTermination = new System.Windows.Forms.DateTimePicker();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.groupDetails = new System.Windows.Forms.GroupBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.txtAccountType = new System.Windows.Forms.TextBox();
            this.dataSavingsAccount = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupReason = new System.Windows.Forms.GroupBox();
            this.txtSpecify = new System.Windows.Forms.TextBox();
            this.lblSpecify = new System.Windows.Forms.Label();
            this.radioOthers = new System.Windows.Forms.RadioButton();
            this.radioForced = new System.Windows.Forms.RadioButton();
            this.radioReCreate = new System.Windows.Forms.RadioButton();
            this.radioVoluntary = new System.Windows.Forms.RadioButton();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSavingsAccount)).BeginInit();
            this.groupReason.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(473, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 21);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // dateTermination
            // 
            this.dateTermination.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTermination.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTermination.Location = new System.Drawing.Point(521, 12);
            this.dateTermination.Name = "dateTermination";
            this.dateTermination.Size = new System.Drawing.Size(119, 29);
            this.dateTermination.TabIndex = 2;
            this.dateTermination.Value = new System.DateTime(2014, 7, 27, 21, 2, 34, 0);
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNo.Location = new System.Drawing.Point(15, 27);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(128, 21);
            this.lblAccountNo.TabIndex = 5;
            this.lblAccountNo.Text = "Account Number";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(189, 24);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(174, 29);
            this.txtAccountNo.TabIndex = 6;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(15, 62);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(120, 21);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Current Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(189, 59);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(174, 29);
            this.txtBalance.TabIndex = 8;
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountHolder.Location = new System.Drawing.Point(15, 130);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(130, 21);
            this.lblAccountHolder.TabIndex = 11;
            this.lblAccountHolder.Text = "Account Holder/s";
            // 
            // groupDetails
            // 
            this.groupDetails.Controls.Add(this.lblAccountType);
            this.groupDetails.Controls.Add(this.txtAccountType);
            this.groupDetails.Controls.Add(this.dataSavingsAccount);
            this.groupDetails.Controls.Add(this.lblAccountNo);
            this.groupDetails.Controls.Add(this.lblAccountHolder);
            this.groupDetails.Controls.Add(this.txtAccountNo);
            this.groupDetails.Controls.Add(this.txtBalance);
            this.groupDetails.Controls.Add(this.lblBalance);
            this.groupDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDetails.Location = new System.Drawing.Point(12, 81);
            this.groupDetails.Name = "groupDetails";
            this.groupDetails.Size = new System.Drawing.Size(369, 284);
            this.groupDetails.TabIndex = 4;
            this.groupDetails.TabStop = false;
            this.groupDetails.Text = "Savings Account Details";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(15, 97);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(103, 21);
            this.lblAccountType.TabIndex = 9;
            this.lblAccountType.Text = "Account Type";
            // 
            // txtAccountType
            // 
            this.txtAccountType.Enabled = false;
            this.txtAccountType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountType.Location = new System.Drawing.Point(189, 94);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(174, 29);
            this.txtAccountType.TabIndex = 10;
            // 
            // dataSavingsAccount
            // 
            this.dataSavingsAccount.AllowUserToAddRows = false;
            this.dataSavingsAccount.AllowUserToDeleteRows = false;
            this.dataSavingsAccount.AllowUserToOrderColumns = true;
            this.dataSavingsAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSavingsAccount.BackgroundColor = System.Drawing.Color.Silver;
            this.dataSavingsAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSavingsAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSavingsAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSavingsAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataSavingsAccount.Location = new System.Drawing.Point(6, 158);
            this.dataSavingsAccount.MultiSelect = false;
            this.dataSavingsAccount.Name = "dataSavingsAccount";
            this.dataSavingsAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSavingsAccount.Size = new System.Drawing.Size(357, 120);
            this.dataSavingsAccount.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Savings Account will be Terminated. Continue?";
            // 
            // groupReason
            // 
            this.groupReason.Controls.Add(this.txtSpecify);
            this.groupReason.Controls.Add(this.lblSpecify);
            this.groupReason.Controls.Add(this.radioOthers);
            this.groupReason.Controls.Add(this.radioForced);
            this.groupReason.Controls.Add(this.radioReCreate);
            this.groupReason.Controls.Add(this.radioVoluntary);
            this.groupReason.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupReason.Location = new System.Drawing.Point(387, 81);
            this.groupReason.Name = "groupReason";
            this.groupReason.Size = new System.Drawing.Size(253, 211);
            this.groupReason.TabIndex = 13;
            this.groupReason.TabStop = false;
            this.groupReason.Text = "Reason for Termination";
            // 
            // txtSpecify
            // 
            this.txtSpecify.Enabled = false;
            this.txtSpecify.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecify.Location = new System.Drawing.Point(13, 165);
            this.txtSpecify.Name = "txtSpecify";
            this.txtSpecify.Size = new System.Drawing.Size(234, 29);
            this.txtSpecify.TabIndex = 19;
            // 
            // lblSpecify
            // 
            this.lblSpecify.AutoSize = true;
            this.lblSpecify.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecify.Location = new System.Drawing.Point(91, 136);
            this.lblSpecify.Name = "lblSpecify";
            this.lblSpecify.Size = new System.Drawing.Size(61, 21);
            this.lblSpecify.TabIndex = 18;
            this.lblSpecify.Text = "Specify:";
            // 
            // radioOthers
            // 
            this.radioOthers.AutoSize = true;
            this.radioOthers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOthers.Location = new System.Drawing.Point(10, 134);
            this.radioOthers.Name = "radioOthers";
            this.radioOthers.Size = new System.Drawing.Size(75, 25);
            this.radioOthers.TabIndex = 17;
            this.radioOthers.TabStop = true;
            this.radioOthers.Text = "Others";
            this.radioOthers.UseVisualStyleBackColor = true;
            this.radioOthers.CheckedChanged += new System.EventHandler(this.radioOthers_CheckedChanged);
            // 
            // radioForced
            // 
            this.radioForced.AutoSize = true;
            this.radioForced.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioForced.Location = new System.Drawing.Point(10, 103);
            this.radioForced.Name = "radioForced";
            this.radioForced.Size = new System.Drawing.Size(163, 25);
            this.radioForced.TabIndex = 16;
            this.radioForced.TabStop = true;
            this.radioForced.Text = "Forced Termination";
            this.radioForced.UseVisualStyleBackColor = true;
            // 
            // radioReCreate
            // 
            this.radioReCreate.AutoSize = true;
            this.radioReCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioReCreate.Location = new System.Drawing.Point(10, 41);
            this.radioReCreate.Name = "radioReCreate";
            this.radioReCreate.Size = new System.Drawing.Size(229, 25);
            this.radioReCreate.TabIndex = 14;
            this.radioReCreate.TabStop = true;
            this.radioReCreate.Text = "Savings Account Re-Creation";
            this.radioReCreate.UseVisualStyleBackColor = true;
            // 
            // radioVoluntary
            // 
            this.radioVoluntary.AutoSize = true;
            this.radioVoluntary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVoluntary.Location = new System.Drawing.Point(10, 72);
            this.radioVoluntary.Name = "radioVoluntary";
            this.radioVoluntary.Size = new System.Drawing.Size(96, 25);
            this.radioVoluntary.TabIndex = 15;
            this.radioVoluntary.TabStop = true;
            this.radioVoluntary.Text = "Voluntary";
            this.radioVoluntary.UseVisualStyleBackColor = true;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Green;
            this.btnProceed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Image = global::CMS.Properties.Resources.Proceed;
            this.btnProceed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceed.Location = new System.Drawing.Point(400, 314);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(110, 35);
            this.btnProceed.TabIndex = 20;
            this.btnProceed.Text = "&Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CMS.Properties.Resources.Delete;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(516, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SavingsTermination
            // 
            this.AcceptButton = this.btnProceed;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 381);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.groupReason);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupDetails);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTermination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SavingsTermination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Termination";
            this.TopMost = true;
            this.groupDetails.ResumeLayout(false);
            this.groupDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSavingsAccount)).EndInit();
            this.groupReason.ResumeLayout(false);
            this.groupReason.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTermination;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.GroupBox groupDetails;
        private System.Windows.Forms.DataGridView dataSavingsAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupReason;
        private System.Windows.Forms.RadioButton radioForced;
        private System.Windows.Forms.RadioButton radioReCreate;
        private System.Windows.Forms.RadioButton radioVoluntary;
        private System.Windows.Forms.RadioButton radioOthers;
        private System.Windows.Forms.TextBox txtSpecify;
        private System.Windows.Forms.Label lblSpecify;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.TextBox txtAccountType;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnCancel;
    }
}