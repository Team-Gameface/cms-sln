namespace CMS.Loan_Management.Maintenance.View
{
    partial class LoanAmnestyActivation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanAmnestyActivation));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataAmnesty = new System.Windows.Forms.DataGridView();
            this.chbShowArchive = new System.Windows.Forms.CheckBox();
            this.gbAmnesty = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.clbLoanType = new System.Windows.Forms.CheckedListBox();
            this.udOverdue = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWaive = new System.Windows.Forms.Label();
            this.chbWaivePenalties = new System.Windows.Forms.CheckBox();
            this.chbWaiveInterest = new System.Windows.Forms.CheckBox();
            this.gbInclusiveDates = new System.Windows.Forms.GroupBox();
            this.clbDateTo = new System.Windows.Forms.CheckBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.lblAndAbove = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataAmnesty)).BeginInit();
            this.gbAmnesty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udOverdue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbInclusiveDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(491, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(589, 168);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Maintenance - Loan Amnesty Activation";
            // 
            // dataAmnesty
            // 
            this.dataAmnesty.AllowUserToAddRows = false;
            this.dataAmnesty.AllowUserToDeleteRows = false;
            this.dataAmnesty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataAmnesty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataAmnesty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataAmnesty.BackgroundColor = System.Drawing.Color.Silver;
            this.dataAmnesty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAmnesty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataAmnesty.Location = new System.Drawing.Point(3, 39);
            this.dataAmnesty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataAmnesty.Name = "dataAmnesty";
            this.dataAmnesty.ReadOnly = true;
            this.dataAmnesty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAmnesty.Size = new System.Drawing.Size(678, 122);
            this.dataAmnesty.TabIndex = 1;
            // 
            // chbShowArchive
            // 
            this.chbShowArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbShowArchive.AutoSize = true;
            this.chbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.chbShowArchive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.chbShowArchive.Location = new System.Drawing.Point(12, 174);
            this.chbShowArchive.Name = "chbShowArchive";
            this.chbShowArchive.Size = new System.Drawing.Size(127, 24);
            this.chbShowArchive.TabIndex = 2;
            this.chbShowArchive.Text = "Show Archives";
            this.chbShowArchive.UseVisualStyleBackColor = false;
            // 
            // gbAmnesty
            // 
            this.gbAmnesty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbAmnesty.Controls.Add(this.btnCancel);
            this.gbAmnesty.Controls.Add(this.btnSave);
            this.gbAmnesty.Controls.Add(this.cbDuration);
            this.gbAmnesty.Controls.Add(this.lblLoanType);
            this.gbAmnesty.Controls.Add(this.clbLoanType);
            this.gbAmnesty.Controls.Add(this.udOverdue);
            this.gbAmnesty.Controls.Add(this.lblStatus);
            this.gbAmnesty.Controls.Add(this.groupBox1);
            this.gbAmnesty.Controls.Add(this.gbInclusiveDates);
            this.gbAmnesty.Controls.Add(this.chbStatus);
            this.gbAmnesty.Controls.Add(this.lblOverdue);
            this.gbAmnesty.Controls.Add(this.lblAndAbove);
            this.gbAmnesty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gbAmnesty.Location = new System.Drawing.Point(3, 208);
            this.gbAmnesty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAmnesty.Name = "gbAmnesty";
            this.gbAmnesty.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAmnesty.Size = new System.Drawing.Size(678, 238);
            this.gbAmnesty.TabIndex = 5;
            this.gbAmnesty.TabStop = false;
            this.gbAmnesty.Text = "Add/Edit Amnesty Activation";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(579, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(479, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // cbDuration
            // 
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Items.AddRange(new object[] {
            "month/s",
            "year/s"});
            this.cbDuration.Location = new System.Drawing.Point(200, 103);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(86, 25);
            this.cbDuration.TabIndex = 14;
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLoanType.Location = new System.Drawing.Point(369, 23);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(95, 17);
            this.lblLoanType.TabIndex = 20;
            this.lblLoanType.Text = "Applicable for:";
            // 
            // clbLoanType
            // 
            this.clbLoanType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.clbLoanType.FormattingEnabled = true;
            this.clbLoanType.Location = new System.Drawing.Point(373, 47);
            this.clbLoanType.Name = "clbLoanType";
            this.clbLoanType.Size = new System.Drawing.Size(298, 144);
            this.clbLoanType.TabIndex = 21;
            // 
            // udOverdue
            // 
            this.udOverdue.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.udOverdue.Location = new System.Drawing.Point(132, 101);
            this.udOverdue.Name = "udOverdue";
            this.udOverdue.Size = new System.Drawing.Size(62, 25);
            this.udOverdue.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStatus.Location = new System.Drawing.Point(11, 205);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWaive);
            this.groupBox1.Controls.Add(this.chbWaivePenalties);
            this.groupBox1.Controls.Add(this.chbWaiveInterest);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(7, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 57);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Penalty Condonation";
            // 
            // lblWaive
            // 
            this.lblWaive.AutoSize = true;
            this.lblWaive.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblWaive.Location = new System.Drawing.Point(18, 27);
            this.lblWaive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaive.Name = "lblWaive";
            this.lblWaive.Size = new System.Drawing.Size(46, 17);
            this.lblWaive.TabIndex = 17;
            this.lblWaive.Text = "Waive:";
            // 
            // chbWaivePenalties
            // 
            this.chbWaivePenalties.AutoSize = true;
            this.chbWaivePenalties.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chbWaivePenalties.Location = new System.Drawing.Point(216, 26);
            this.chbWaivePenalties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbWaivePenalties.Name = "chbWaivePenalties";
            this.chbWaivePenalties.Size = new System.Drawing.Size(110, 21);
            this.chbWaivePenalties.TabIndex = 19;
            this.chbWaivePenalties.Text = "Loan Penalties";
            this.chbWaivePenalties.UseVisualStyleBackColor = true;
            // 
            // chbWaiveInterest
            // 
            this.chbWaiveInterest.AutoSize = true;
            this.chbWaiveInterest.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chbWaiveInterest.Location = new System.Drawing.Point(111, 26);
            this.chbWaiveInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbWaiveInterest.Name = "chbWaiveInterest";
            this.chbWaiveInterest.Size = new System.Drawing.Size(76, 21);
            this.chbWaiveInterest.TabIndex = 18;
            this.chbWaiveInterest.Text = "Interests";
            this.chbWaiveInterest.UseVisualStyleBackColor = true;
            // 
            // gbInclusiveDates
            // 
            this.gbInclusiveDates.Controls.Add(this.clbDateTo);
            this.gbInclusiveDates.Controls.Add(this.startDate);
            this.gbInclusiveDates.Controls.Add(this.lblFrom);
            this.gbInclusiveDates.Controls.Add(this.endDate);
            this.gbInclusiveDates.Controls.Add(this.lblTo);
            this.gbInclusiveDates.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInclusiveDates.Location = new System.Drawing.Point(6, 30);
            this.gbInclusiveDates.Name = "gbInclusiveDates";
            this.gbInclusiveDates.Size = new System.Drawing.Size(349, 61);
            this.gbInclusiveDates.TabIndex = 6;
            this.gbInclusiveDates.TabStop = false;
            this.gbInclusiveDates.Text = "Inclusive Dates";
            // 
            // clbDateTo
            // 
            this.clbDateTo.AutoSize = true;
            this.clbDateTo.Location = new System.Drawing.Point(195, 35);
            this.clbDateTo.Name = "clbDateTo";
            this.clbDateTo.Size = new System.Drawing.Size(15, 14);
            this.clbDateTo.TabIndex = 10;
            this.clbDateTo.UseVisualStyleBackColor = true;
            this.clbDateTo.CheckedChanged += new System.EventHandler(this.clbDateTo_CheckedChanged);
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(41, 28);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(122, 25);
            this.startDate.TabIndex = 8;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFrom.Location = new System.Drawing.Point(7, 33);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 17);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "from";
            // 
            // endDate
            // 
            this.endDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(217, 28);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(122, 25);
            this.endDate.TabIndex = 11;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTo.Location = new System.Drawing.Point(168, 34);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 17);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "to";
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chbStatus.Location = new System.Drawing.Point(64, 204);
            this.chbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(61, 21);
            this.chbStatus.TabIndex = 23;
            this.chbStatus.Text = "Active";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOverdue.Location = new System.Drawing.Point(13, 103);
            this.lblOverdue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(112, 17);
            this.lblOverdue.TabIndex = 12;
            this.lblOverdue.Text = "Overdue loans of:";
            // 
            // lblAndAbove
            // 
            this.lblAndAbove.AutoSize = true;
            this.lblAndAbove.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAndAbove.Location = new System.Drawing.Point(288, 106);
            this.lblAndAbove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAndAbove.Name = "lblAndAbove";
            this.lblAndAbove.Size = new System.Drawing.Size(70, 17);
            this.lblAndAbove.TabIndex = 15;
            this.lblAndAbove.Text = "and above";
            // 
            // LoanAmnestyActivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.gbAmnesty);
            this.Controls.Add(this.chbShowArchive);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataAmnesty);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "LoanAmnestyActivation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Amnesty Activation";
            ((System.ComponentModel.ISupportInitialize)(this.dataAmnesty)).EndInit();
            this.gbAmnesty.ResumeLayout(false);
            this.gbAmnesty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udOverdue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbInclusiveDates.ResumeLayout(false);
            this.gbInclusiveDates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataAmnesty;
        private System.Windows.Forms.CheckBox chbShowArchive;
        private System.Windows.Forms.GroupBox gbAmnesty;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbDuration;
        public System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.CheckedListBox clbLoanType;
        private System.Windows.Forms.NumericUpDown udOverdue;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblWaive;
        private System.Windows.Forms.CheckBox chbWaivePenalties;
        private System.Windows.Forms.CheckBox chbWaiveInterest;
        private System.Windows.Forms.GroupBox gbInclusiveDates;
        private System.Windows.Forms.CheckBox clbDateTo;
        private System.Windows.Forms.DateTimePicker startDate;
        public System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker endDate;
        public System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.CheckBox chbStatus;
        public System.Windows.Forms.Label lblOverdue;
        public System.Windows.Forms.Label lblAndAbove;
    }
}