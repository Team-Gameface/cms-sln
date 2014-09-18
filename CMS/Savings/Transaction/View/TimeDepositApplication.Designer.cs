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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeDepositApplication));
            this.dateMaturity = new System.Windows.Forms.DateTimePicker();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataMember = new System.Windows.Forms.DataGridView();
            this.comboDuration = new System.Windows.Forms.ComboBox();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
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
            this.groupWithdrawal = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.dateMaturity.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMaturity.Location = new System.Drawing.Point(63, 133);
            this.dateMaturity.Name = "dateMaturity";
            this.dateMaturity.Size = new System.Drawing.Size(241, 29);
            this.dateMaturity.TabIndex = 16;
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
            this.dataMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMember.BackgroundColor = System.Drawing.Color.Silver;
            this.dataMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMember.Location = new System.Drawing.Point(12, 167);
            this.dataMember.MultiSelect = false;
            this.dataMember.Name = "dataMember";
            this.dataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMember.Size = new System.Drawing.Size(375, 303);
            this.dataMember.TabIndex = 8;
            // 
            // comboDuration
            // 
            this.comboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDuration.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboDuration.FormattingEnabled = true;
            this.comboDuration.Items.AddRange(new object[] {
            "Day/s",
            "Month/s",
            "Year/s"});
            this.comboDuration.Location = new System.Drawing.Point(219, 63);
            this.comboDuration.Name = "comboDuration";
            this.comboDuration.Size = new System.Drawing.Size(123, 29);
            this.comboDuration.TabIndex = 14;
            // 
            // numDuration
            // 
            this.numDuration.ContextMenuStrip = this.contextMenuBlank;
            this.numDuration.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numDuration.Location = new System.Drawing.Point(144, 63);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(69, 29);
            this.numDuration.TabIndex = 13;
            this.numDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numDuration_KeyDown);
            this.numDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDuration_KeyPress);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDuration.Location = new System.Drawing.Point(15, 65);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(120, 21);
            this.lblDuration.TabIndex = 12;
            this.lblDuration.Text = "Terms/Duration";
            // 
            // lblMaturity
            // 
            this.lblMaturity.AutoSize = true;
            this.lblMaturity.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaturity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaturity.Location = new System.Drawing.Point(43, 109);
            this.lblMaturity.Name = "lblMaturity";
            this.lblMaturity.Size = new System.Drawing.Size(105, 21);
            this.lblMaturity.TabIndex = 15;
            this.lblMaturity.Text = "Maturity Date";
            // 
            // txtDeposit
            // 
            this.txtDeposit.ContextMenuStrip = this.contextMenuBlank;
            this.txtDeposit.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDeposit.Location = new System.Drawing.Point(144, 28);
            this.txtDeposit.MaxLength = 10;
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(198, 29);
            this.txtDeposit.TabIndex = 11;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeposit_KeyDown);
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeposit.Location = new System.Drawing.Point(15, 31);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(123, 21);
            this.lblDeposit.TabIndex = 10;
            this.lblDeposit.Text = "Deposit Amount";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtAccountNo);
            this.groupBox4.Controls.Add(this.txtMemberName);
            this.groupBox4.Controls.Add(this.radioMemberName);
            this.groupBox4.Controls.Add(this.radioAccountNo);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox4.Location = new System.Drawing.Point(12, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(742, 104);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccountNo.Location = new System.Drawing.Point(320, 28);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(365, 29);
            this.txtAccountNo.TabIndex = 5;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberName.Location = new System.Drawing.Point(320, 63);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(365, 29);
            this.txtMemberName.TabIndex = 7;
            // 
            // radioMemberName
            // 
            this.radioMemberName.AutoSize = true;
            this.radioMemberName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMemberName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioMemberName.Location = new System.Drawing.Point(135, 64);
            this.radioMemberName.Name = "radioMemberName";
            this.radioMemberName.Size = new System.Drawing.Size(132, 25);
            this.radioMemberName.TabIndex = 6;
            this.radioMemberName.TabStop = true;
            this.radioMemberName.Text = "Member Name";
            this.radioMemberName.UseVisualStyleBackColor = true;
            this.radioMemberName.CheckedChanged += new System.EventHandler(this.radioMemberName_CheckedChanged);
            // 
            // radioAccountNo
            // 
            this.radioAccountNo.AutoSize = true;
            this.radioAccountNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioAccountNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAccountNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioAccountNo.Location = new System.Drawing.Point(135, 29);
            this.radioAccountNo.Name = "radioAccountNo";
            this.radioAccountNo.Size = new System.Drawing.Size(145, 25);
            this.radioAccountNo.TabIndex = 4;
            this.radioAccountNo.TabStop = true;
            this.radioAccountNo.Text = "Account Number";
            this.radioAccountNo.UseVisualStyleBackColor = true;
            this.radioAccountNo.CheckedChanged += new System.EventHandler(this.radioAccountNo_CheckedChanged);
            // 
            // groupWithdrawal
            // 
            this.groupWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupWithdrawal.Controls.Add(this.lblDeposit);
            this.groupWithdrawal.Controls.Add(this.txtDeposit);
            this.groupWithdrawal.Controls.Add(this.lblMaturity);
            this.groupWithdrawal.Controls.Add(this.dateMaturity);
            this.groupWithdrawal.Controls.Add(this.lblDuration);
            this.groupWithdrawal.Controls.Add(this.numDuration);
            this.groupWithdrawal.Controls.Add(this.comboDuration);
            this.groupWithdrawal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupWithdrawal.ForeColor = System.Drawing.Color.Firebrick;
            this.groupWithdrawal.Location = new System.Drawing.Point(393, 167);
            this.groupWithdrawal.Name = "groupWithdrawal";
            this.groupWithdrawal.Size = new System.Drawing.Size(361, 179);
            this.groupWithdrawal.TabIndex = 9;
            this.groupWithdrawal.TabStop = false;
            this.groupWithdrawal.Text = "Time Deposit Account Details";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(386, 45);
            this.label5.TabIndex = 1;
            this.label5.Text = "Time Deposit Application";
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
            this.btnSave.Location = new System.Drawing.Point(539, 424);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::CMS.Properties.Resources.Cancel;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(645, 424);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // TimeDepositApplication
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(764, 481);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupWithdrawal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataMember);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(780, 520);
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
        private System.Windows.Forms.ComboBox comboDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
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
        private System.Windows.Forms.GroupBox groupWithdrawal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}