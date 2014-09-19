namespace CMS.Loan_Management.Maintenance.View
{
    partial class LoanInterestRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanInterestRate));
            this.cbLoanType = new System.Windows.Forms.ComboBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblPer = new System.Windows.Forms.Label();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.cbInterestStatus = new System.Windows.Forms.ComboBox();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.dataInterest = new System.Windows.Forms.DataGridView();
            this.gbInterest = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbShowArchive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataInterest)).BeginInit();
            this.gbInterest.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLoanType
            // 
            this.cbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoanType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoanType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoanType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbLoanType.FormattingEnabled = true;
            this.cbLoanType.Location = new System.Drawing.Point(186, 36);
            this.cbLoanType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLoanType.Name = "cbLoanType";
            this.cbLoanType.Size = new System.Drawing.Size(215, 29);
            this.cbLoanType.TabIndex = 8;
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(186, 114);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(215, 29);
            this.startDate.TabIndex = 15;
            // 
            // txtInterest
            // 
            this.txtInterest.ContextMenuStrip = this.contextMenuBlank;
            this.txtInterest.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtInterest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInterest.Location = new System.Drawing.Point(186, 78);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInterest.MaxLength = 8;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 25);
            this.txtInterest.TabIndex = 10;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInterest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInterest_KeyDown);
            this.txtInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterest_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPer.Location = new System.Drawing.Point(409, 78);
            this.lblPer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(32, 21);
            this.lblPer.TabIndex = 12;
            this.lblPer.Text = "per";
            // 
            // cbDuration
            // 
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDuration.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Items.AddRange(new object[] {
            "month",
            "annum"});
            this.cbDuration.Location = new System.Drawing.Point(449, 75);
            this.cbDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(195, 29);
            this.cbDuration.TabIndex = 13;
            // 
            // cbInterestStatus
            // 
            this.cbInterestStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterestStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbInterestStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInterestStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbInterestStatus.FormattingEnabled = true;
            this.cbInterestStatus.Items.AddRange(new object[] {
            "%",
            "Php"});
            this.cbInterestStatus.Location = new System.Drawing.Point(294, 75);
            this.cbInterestStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbInterestStatus.Name = "cbInterestStatus";
            this.cbInterestStatus.Size = new System.Drawing.Size(107, 29);
            this.cbInterestStatus.TabIndex = 11;
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoanType.Location = new System.Drawing.Point(54, 39);
            this.lblLoanType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(81, 21);
            this.lblLoanType.TabIndex = 7;
            this.lblLoanType.Text = "Loan Type";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInterestRate.Location = new System.Drawing.Point(54, 78);
            this.lblInterestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(97, 21);
            this.lblInterestRate.TabIndex = 9;
            this.lblInterestRate.Text = "Interest Rate";
            // 
            // dataInterest
            // 
            this.dataInterest.AllowUserToAddRows = false;
            this.dataInterest.AllowUserToDeleteRows = false;
            this.dataInterest.AllowUserToOrderColumns = true;
            this.dataInterest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataInterest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataInterest.BackgroundColor = System.Drawing.Color.Silver;
            this.dataInterest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataInterest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataInterest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInterest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataInterest.Location = new System.Drawing.Point(13, 59);
            this.dataInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataInterest.Name = "dataInterest";
            this.dataInterest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInterest.Size = new System.Drawing.Size(696, 196);
            this.dataInterest.TabIndex = 2;
            this.dataInterest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInterest_CellClick);
            this.dataInterest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataInterest_KeyDown);
            this.dataInterest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataInterest_KeyUp);
            // 
            // gbInterest
            // 
            this.gbInterest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInterest.Controls.Add(this.startDate);
            this.gbInterest.Controls.Add(this.txtInterest);
            this.gbInterest.Controls.Add(this.btnSave);
            this.gbInterest.Controls.Add(this.label1);
            this.gbInterest.Controls.Add(this.btnCancel);
            this.gbInterest.Controls.Add(this.lblPer);
            this.gbInterest.Controls.Add(this.cbDuration);
            this.gbInterest.Controls.Add(this.cbInterestStatus);
            this.gbInterest.Controls.Add(this.cbLoanType);
            this.gbInterest.Controls.Add(this.lblLoanType);
            this.gbInterest.Controls.Add(this.lblInterestRate);
            this.gbInterest.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInterest.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbInterest.Location = new System.Drawing.Point(13, 310);
            this.gbInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInterest.Name = "gbInterest";
            this.gbInterest.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInterest.Size = new System.Drawing.Size(696, 174);
            this.gbInterest.TabIndex = 6;
            this.gbInterest.TabStop = false;
            this.gbInterest.Text = "Add/Edit Interest Rate";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CMS.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(483, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(54, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Effectivity Date";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CMS.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(589, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cbShowArchive
            // 
            this.cbShowArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShowArchive.AutoSize = true;
            this.cbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.cbShowArchive.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowArchive.Location = new System.Drawing.Point(22, 269);
            this.cbShowArchive.Name = "cbShowArchive";
            this.cbShowArchive.Size = new System.Drawing.Size(126, 25);
            this.cbShowArchive.TabIndex = 3;
            this.cbShowArchive.Text = "Show Archives";
            this.cbShowArchive.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maintenance - Loan Interest Rates";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::CMS.Properties.Resources.Edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(602, 263);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::CMS.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(496, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // LoanInterestRate
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(724, 491);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbShowArchive);
            this.Controls.Add(this.gbInterest);
            this.Controls.Add(this.dataInterest);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(740, 530);
            this.Name = "LoanInterestRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Interest Rates";
            ((System.ComponentModel.ISupportInitialize)(this.dataInterest)).EndInit();
            this.gbInterest.ResumeLayout(false);
            this.gbInterest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.ComboBox cbInterestStatus;
        private System.Windows.Forms.GroupBox gbInterest;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        public System.Windows.Forms.Label lblPer;
        public System.Windows.Forms.Label lblLoanType;
        public System.Windows.Forms.Label lblInterestRate;
        public System.Windows.Forms.DataGridView dataInterest;
        public System.Windows.Forms.ComboBox cbLoanType;
        private System.Windows.Forms.CheckBox cbShowArchive;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}