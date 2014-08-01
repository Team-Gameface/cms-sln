namespace CMS.Savings.Transaction.View
{
    partial class TimeDepositApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeDepositApplication));
            this.dateMaturity = new System.Windows.Forms.DateTimePicker();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataMember = new System.Windows.Forms.DataGridView();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.comboDuration = new System.Windows.Forms.ComboBox();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblMaturity = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.radioMemberName = new System.Windows.Forms.RadioButton();
            this.radioAccountNo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupWithdrawal = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupWithdrawal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateMaturity
            // 
            this.dateMaturity.ContextMenuStrip = this.contextMenuBlank;
            this.dateMaturity.Enabled = false;
            this.dateMaturity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateMaturity.Location = new System.Drawing.Point(41, 156);
            this.dateMaturity.Name = "dateMaturity";
            this.dateMaturity.Size = new System.Drawing.Size(241, 25);
            this.dateMaturity.TabIndex = 17;
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
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
            this.dataMember.Location = new System.Drawing.Point(12, 158);
            this.dataMember.MultiSelect = false;
            this.dataMember.Name = "dataMember";
            this.dataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMember.Size = new System.Drawing.Size(375, 303);
            this.dataMember.TabIndex = 7;
            // 
            // comboAccountType
            // 
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAccountType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(116, 42);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(183, 25);
            this.comboAccountType.TabIndex = 0;
            // 
            // comboDuration
            // 
            this.comboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboDuration.FormattingEnabled = true;
            this.comboDuration.Items.AddRange(new object[] {
            "Day/s",
            "Week/s",
            "Month/s",
            "Year/s"});
            this.comboDuration.Location = new System.Drawing.Point(193, 109);
            this.comboDuration.Name = "comboDuration";
            this.comboDuration.Size = new System.Drawing.Size(106, 25);
            this.comboDuration.TabIndex = 15;
            // 
            // numDuration
            // 
            this.numDuration.ContextMenuStrip = this.contextMenuBlank;
            this.numDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numDuration.Location = new System.Drawing.Point(134, 109);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(53, 25);
            this.numDuration.TabIndex = 14;
            this.numDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numDuration_KeyDown);
            this.numDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDuration_KeyPress);
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAccountType.Location = new System.Drawing.Point(21, 45);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(89, 17);
            this.lblAccountType.TabIndex = 9;
            this.lblAccountType.Text = "Account Type:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDuration.Location = new System.Drawing.Point(10, 112);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(102, 17);
            this.lblDuration.TabIndex = 13;
            this.lblDuration.Text = "Terms/Duration:";
            // 
            // lblMaturity
            // 
            this.lblMaturity.AutoSize = true;
            this.lblMaturity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblMaturity.Location = new System.Drawing.Point(38, 136);
            this.lblMaturity.Name = "lblMaturity";
            this.lblMaturity.Size = new System.Drawing.Size(88, 17);
            this.lblMaturity.TabIndex = 16;
            this.lblMaturity.Text = "Maturity Date:";
            // 
            // txtDeposit
            // 
            this.txtDeposit.ContextMenuStrip = this.contextMenuBlank;
            this.txtDeposit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDeposit.Location = new System.Drawing.Point(118, 76);
            this.txtDeposit.MaxLength = 10;
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(181, 25);
            this.txtDeposit.TabIndex = 12;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeposit_KeyDown);
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDeposit.Location = new System.Drawing.Point(7, 79);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(105, 17);
            this.lblDeposit.TabIndex = 11;
            this.lblDeposit.Text = "Deposit Amount:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtAccountNo);
            this.groupBox4.Controls.Add(this.txtMemberName);
            this.groupBox4.Controls.Add(this.radioMemberName);
            this.groupBox4.Controls.Add(this.radioAccountNo);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(12, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(680, 93);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Member:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAccountNo.Location = new System.Drawing.Point(248, 26);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(365, 25);
            this.txtAccountNo.TabIndex = 4;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMemberName.Location = new System.Drawing.Point(248, 57);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(366, 25);
            this.txtMemberName.TabIndex = 6;
            // 
            // radioMemberName
            // 
            this.radioMemberName.AutoSize = true;
            this.radioMemberName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radioMemberName.Location = new System.Drawing.Point(115, 58);
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
            this.radioAccountNo.Location = new System.Drawing.Point(115, 27);
            this.radioAccountNo.Name = "radioAccountNo";
            this.radioAccountNo.Size = new System.Drawing.Size(127, 21);
            this.radioAccountNo.TabIndex = 3;
            this.radioAccountNo.TabStop = true;
            this.radioAccountNo.Text = "Account Number:";
            this.radioAccountNo.UseVisualStyleBackColor = true;
            this.radioAccountNo.CheckedChanged += new System.EventHandler(this.radioAccountNo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(197, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "TIME DEPOSIT APPLICATION";
            // 
            // groupWithdrawal
            // 
            this.groupWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupWithdrawal.Controls.Add(this.lblAccountType);
            this.groupWithdrawal.Controls.Add(this.lblDeposit);
            this.groupWithdrawal.Controls.Add(this.txtDeposit);
            this.groupWithdrawal.Controls.Add(this.lblMaturity);
            this.groupWithdrawal.Controls.Add(this.dateMaturity);
            this.groupWithdrawal.Controls.Add(this.lblDuration);
            this.groupWithdrawal.Controls.Add(this.numDuration);
            this.groupWithdrawal.Controls.Add(this.comboDuration);
            this.groupWithdrawal.Controls.Add(this.comboAccountType);
            this.groupWithdrawal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.groupWithdrawal.Location = new System.Drawing.Point(393, 158);
            this.groupWithdrawal.Name = "groupWithdrawal";
            this.groupWithdrawal.Size = new System.Drawing.Size(307, 211);
            this.groupWithdrawal.TabIndex = 8;
            this.groupWithdrawal.TabStop = false;
            this.groupWithdrawal.Text = "TIme Deposit Account Details:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(507, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 18;
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
            this.btnClear.Location = new System.Drawing.Point(603, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 32);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // TimeDepositApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupWithdrawal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataMember);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "TimeDepositApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Deposit Application";
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupWithdrawal.ResumeLayout(false);
            this.groupWithdrawal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateMaturity;
        private System.Windows.Forms.DataGridView dataMember;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.ComboBox comboDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblMaturity;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.RadioButton radioMemberName;
        private System.Windows.Forms.RadioButton radioAccountNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupWithdrawal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}