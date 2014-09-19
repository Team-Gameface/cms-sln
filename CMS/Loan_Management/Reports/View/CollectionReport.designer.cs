namespace CMS.Loan_Management.Reports.View
{
    partial class CollectionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionReport));
            this.btnPreview = new System.Windows.Forms.Button();
            this.grpTransType = new System.Windows.Forms.GroupBox();
            this.rbShare = new System.Windows.Forms.RadioButton();
            this.rbMiscFees = new System.Windows.Forms.RadioButton();
            this.rbLoan = new System.Windows.Forms.RadioButton();
            this.grpLoanTypesSort = new System.Windows.Forms.GroupBox();
            this.cbLoanTypesSort = new System.Windows.Forms.ComboBox();
            this.rbLoanTypesDescending = new System.Windows.Forms.RadioButton();
            this.rbLoanTypesAscending = new System.Windows.Forms.RadioButton();
            this.panelLoan = new System.Windows.Forms.Panel();
            this.panelMiscFees = new System.Windows.Forms.Panel();
            this.grpMiscFeesSort = new System.Windows.Forms.GroupBox();
            this.cbMiscFeesSort = new System.Windows.Forms.ComboBox();
            this.rbMiscFeesDescending = new System.Windows.Forms.RadioButton();
            this.rbMiscFeesAscending = new System.Windows.Forms.RadioButton();
            this.panelShare = new System.Windows.Forms.Panel();
            this.grpShareSort = new System.Windows.Forms.GroupBox();
            this.cbShareSort = new System.Windows.Forms.ComboBox();
            this.rbShareDescending = new System.Windows.Forms.RadioButton();
            this.rbShareAscending = new System.Windows.Forms.RadioButton();
            this.grpDatesTransaction = new System.Windows.Forms.GroupBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.cbDateTo = new System.Windows.Forms.CheckBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTransType.SuspendLayout();
            this.grpLoanTypesSort.SuspendLayout();
            this.panelLoan.SuspendLayout();
            this.panelMiscFees.SuspendLayout();
            this.grpMiscFeesSort.SuspendLayout();
            this.panelShare.SuspendLayout();
            this.grpShareSort.SuspendLayout();
            this.grpDatesTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreview.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Image = global::CMS.Properties.Resources.ReportView;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(435, 305);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(105, 35);
            this.btnPreview.TabIndex = 24;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // grpTransType
            // 
            this.grpTransType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTransType.Controls.Add(this.rbShare);
            this.grpTransType.Controls.Add(this.rbMiscFees);
            this.grpTransType.Controls.Add(this.rbLoan);
            this.grpTransType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTransType.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTransType.ForeColor = System.Drawing.Color.MediumBlue;
            this.grpTransType.Location = new System.Drawing.Point(12, 172);
            this.grpTransType.Name = "grpTransType";
            this.grpTransType.Size = new System.Drawing.Size(539, 69);
            this.grpTransType.TabIndex = 7;
            this.grpTransType.TabStop = false;
            this.grpTransType.Text = "Transaction Type";
            // 
            // rbShare
            // 
            this.rbShare.AutoSize = true;
            this.rbShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbShare.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbShare.Location = new System.Drawing.Point(313, 32);
            this.rbShare.Name = "rbShare";
            this.rbShare.Size = new System.Drawing.Size(215, 25);
            this.rbShare.TabIndex = 10;
            this.rbShare.TabStop = true;
            this.rbShare.Text = "Share Capital Contributions";
            this.rbShare.UseVisualStyleBackColor = true;
            this.rbShare.CheckedChanged += new System.EventHandler(this.rbShare_CheckedChanged);
            // 
            // rbMiscFees
            // 
            this.rbMiscFees.AutoSize = true;
            this.rbMiscFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMiscFees.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMiscFees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbMiscFees.Location = new System.Drawing.Point(147, 32);
            this.rbMiscFees.Name = "rbMiscFees";
            this.rbMiscFees.Size = new System.Drawing.Size(160, 25);
            this.rbMiscFees.TabIndex = 9;
            this.rbMiscFees.TabStop = true;
            this.rbMiscFees.Text = "Miscellaneous Fees";
            this.rbMiscFees.UseVisualStyleBackColor = true;
            this.rbMiscFees.CheckedChanged += new System.EventHandler(this.rbMiscFees_CheckedChanged);
            // 
            // rbLoan
            // 
            this.rbLoan.AutoSize = true;
            this.rbLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLoan.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLoan.Location = new System.Drawing.Point(12, 32);
            this.rbLoan.Name = "rbLoan";
            this.rbLoan.Size = new System.Drawing.Size(129, 25);
            this.rbLoan.TabIndex = 8;
            this.rbLoan.TabStop = true;
            this.rbLoan.Text = "Loan Payments";
            this.rbLoan.UseVisualStyleBackColor = true;
            this.rbLoan.CheckedChanged += new System.EventHandler(this.rbLoan_CheckedChanged);
            // 
            // grpLoanTypesSort
            // 
            this.grpLoanTypesSort.Controls.Add(this.cbLoanTypesSort);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesDescending);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesAscending);
            this.grpLoanTypesSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpLoanTypesSort.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoanTypesSort.ForeColor = System.Drawing.Color.MediumBlue;
            this.grpLoanTypesSort.Location = new System.Drawing.Point(3, 3);
            this.grpLoanTypesSort.Name = "grpLoanTypesSort";
            this.grpLoanTypesSort.Size = new System.Drawing.Size(290, 90);
            this.grpLoanTypesSort.TabIndex = 20;
            this.grpLoanTypesSort.TabStop = false;
            this.grpLoanTypesSort.Text = "Sort by";
            // 
            // cbLoanTypesSort
            // 
            this.cbLoanTypesSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoanTypesSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoanTypesSort.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoanTypesSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbLoanTypesSort.FormattingEnabled = true;
            this.cbLoanTypesSort.Items.AddRange(new object[] {
            "Transaction Time",
            "Member Account No",
            "Member Name",
            "Loan Type",
            "OR Number"});
            this.cbLoanTypesSort.Location = new System.Drawing.Point(23, 29);
            this.cbLoanTypesSort.Name = "cbLoanTypesSort";
            this.cbLoanTypesSort.Size = new System.Drawing.Size(251, 29);
            this.cbLoanTypesSort.TabIndex = 21;
            // 
            // rbLoanTypesDescending
            // 
            this.rbLoanTypesDescending.AutoSize = true;
            this.rbLoanTypesDescending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLoanTypesDescending.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLoanTypesDescending.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLoanTypesDescending.Location = new System.Drawing.Point(132, 64);
            this.rbLoanTypesDescending.Name = "rbLoanTypesDescending";
            this.rbLoanTypesDescending.Size = new System.Drawing.Size(108, 25);
            this.rbLoanTypesDescending.TabIndex = 23;
            this.rbLoanTypesDescending.TabStop = true;
            this.rbLoanTypesDescending.Text = "Descending";
            this.rbLoanTypesDescending.UseVisualStyleBackColor = true;
            // 
            // rbLoanTypesAscending
            // 
            this.rbLoanTypesAscending.AutoSize = true;
            this.rbLoanTypesAscending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLoanTypesAscending.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLoanTypesAscending.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLoanTypesAscending.Location = new System.Drawing.Point(27, 64);
            this.rbLoanTypesAscending.Name = "rbLoanTypesAscending";
            this.rbLoanTypesAscending.Size = new System.Drawing.Size(99, 25);
            this.rbLoanTypesAscending.TabIndex = 22;
            this.rbLoanTypesAscending.TabStop = true;
            this.rbLoanTypesAscending.Text = "Ascending";
            this.rbLoanTypesAscending.UseVisualStyleBackColor = true;
            // 
            // panelLoan
            // 
            this.panelLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLoan.Controls.Add(this.grpLoanTypesSort);
            this.panelLoan.Location = new System.Drawing.Point(12, 247);
            this.panelLoan.Name = "panelLoan";
            this.panelLoan.Size = new System.Drawing.Size(300, 100);
            this.panelLoan.TabIndex = 32;
            // 
            // panelMiscFees
            // 
            this.panelMiscFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMiscFees.Controls.Add(this.grpMiscFeesSort);
            this.panelMiscFees.Location = new System.Drawing.Point(12, 247);
            this.panelMiscFees.Name = "panelMiscFees";
            this.panelMiscFees.Size = new System.Drawing.Size(300, 100);
            this.panelMiscFees.TabIndex = 32;
            // 
            // grpMiscFeesSort
            // 
            this.grpMiscFeesSort.Controls.Add(this.cbMiscFeesSort);
            this.grpMiscFeesSort.Controls.Add(this.rbMiscFeesDescending);
            this.grpMiscFeesSort.Controls.Add(this.rbMiscFeesAscending);
            this.grpMiscFeesSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMiscFeesSort.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMiscFeesSort.ForeColor = System.Drawing.Color.MediumBlue;
            this.grpMiscFeesSort.Location = new System.Drawing.Point(3, 3);
            this.grpMiscFeesSort.Name = "grpMiscFeesSort";
            this.grpMiscFeesSort.Size = new System.Drawing.Size(290, 90);
            this.grpMiscFeesSort.TabIndex = 11;
            this.grpMiscFeesSort.TabStop = false;
            this.grpMiscFeesSort.Text = "Sort by";
            // 
            // cbMiscFeesSort
            // 
            this.cbMiscFeesSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMiscFeesSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMiscFeesSort.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMiscFeesSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbMiscFeesSort.FormattingEnabled = true;
            this.cbMiscFeesSort.Items.AddRange(new object[] {
            "Transaction Time",
            "Member Account No",
            "Member Name",
            "Description",
            "OR Number"});
            this.cbMiscFeesSort.Location = new System.Drawing.Point(23, 29);
            this.cbMiscFeesSort.Name = "cbMiscFeesSort";
            this.cbMiscFeesSort.Size = new System.Drawing.Size(251, 29);
            this.cbMiscFeesSort.TabIndex = 12;
            // 
            // rbMiscFeesDescending
            // 
            this.rbMiscFeesDescending.AutoSize = true;
            this.rbMiscFeesDescending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMiscFeesDescending.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMiscFeesDescending.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbMiscFeesDescending.Location = new System.Drawing.Point(132, 64);
            this.rbMiscFeesDescending.Name = "rbMiscFeesDescending";
            this.rbMiscFeesDescending.Size = new System.Drawing.Size(108, 25);
            this.rbMiscFeesDescending.TabIndex = 14;
            this.rbMiscFeesDescending.TabStop = true;
            this.rbMiscFeesDescending.Text = "Descending";
            this.rbMiscFeesDescending.UseVisualStyleBackColor = true;
            // 
            // rbMiscFeesAscending
            // 
            this.rbMiscFeesAscending.AutoSize = true;
            this.rbMiscFeesAscending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMiscFeesAscending.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMiscFeesAscending.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbMiscFeesAscending.Location = new System.Drawing.Point(27, 64);
            this.rbMiscFeesAscending.Name = "rbMiscFeesAscending";
            this.rbMiscFeesAscending.Size = new System.Drawing.Size(99, 25);
            this.rbMiscFeesAscending.TabIndex = 13;
            this.rbMiscFeesAscending.TabStop = true;
            this.rbMiscFeesAscending.Text = "Ascending";
            this.rbMiscFeesAscending.UseVisualStyleBackColor = true;
            // 
            // panelShare
            // 
            this.panelShare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelShare.Controls.Add(this.grpShareSort);
            this.panelShare.Location = new System.Drawing.Point(12, 247);
            this.panelShare.Name = "panelShare";
            this.panelShare.Size = new System.Drawing.Size(300, 100);
            this.panelShare.TabIndex = 33;
            // 
            // grpShareSort
            // 
            this.grpShareSort.Controls.Add(this.cbShareSort);
            this.grpShareSort.Controls.Add(this.rbShareDescending);
            this.grpShareSort.Controls.Add(this.rbShareAscending);
            this.grpShareSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpShareSort.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShareSort.ForeColor = System.Drawing.Color.MediumBlue;
            this.grpShareSort.Location = new System.Drawing.Point(3, 3);
            this.grpShareSort.Name = "grpShareSort";
            this.grpShareSort.Size = new System.Drawing.Size(290, 90);
            this.grpShareSort.TabIndex = 16;
            this.grpShareSort.TabStop = false;
            this.grpShareSort.Text = "Sort by";
            // 
            // cbShareSort
            // 
            this.cbShareSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShareSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShareSort.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShareSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbShareSort.FormattingEnabled = true;
            this.cbShareSort.Items.AddRange(new object[] {
            "Transaction Time",
            "Member Account No",
            "Member Name",
            "OR Number"});
            this.cbShareSort.Location = new System.Drawing.Point(23, 29);
            this.cbShareSort.Name = "cbShareSort";
            this.cbShareSort.Size = new System.Drawing.Size(251, 29);
            this.cbShareSort.TabIndex = 17;
            // 
            // rbShareDescending
            // 
            this.rbShareDescending.AutoSize = true;
            this.rbShareDescending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbShareDescending.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShareDescending.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbShareDescending.Location = new System.Drawing.Point(132, 64);
            this.rbShareDescending.Name = "rbShareDescending";
            this.rbShareDescending.Size = new System.Drawing.Size(108, 25);
            this.rbShareDescending.TabIndex = 19;
            this.rbShareDescending.TabStop = true;
            this.rbShareDescending.Text = "Descending";
            this.rbShareDescending.UseVisualStyleBackColor = true;
            // 
            // rbShareAscending
            // 
            this.rbShareAscending.AutoSize = true;
            this.rbShareAscending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbShareAscending.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShareAscending.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbShareAscending.Location = new System.Drawing.Point(27, 64);
            this.rbShareAscending.Name = "rbShareAscending";
            this.rbShareAscending.Size = new System.Drawing.Size(99, 25);
            this.rbShareAscending.TabIndex = 18;
            this.rbShareAscending.TabStop = true;
            this.rbShareAscending.Text = "Ascending";
            this.rbShareAscending.UseVisualStyleBackColor = true;
            // 
            // grpDatesTransaction
            // 
            this.grpDatesTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDatesTransaction.Controls.Add(this.dateTo);
            this.grpDatesTransaction.Controls.Add(this.cbDateTo);
            this.grpDatesTransaction.Controls.Add(this.dateFrom);
            this.grpDatesTransaction.Controls.Add(this.lblFrom);
            this.grpDatesTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDatesTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatesTransaction.ForeColor = System.Drawing.Color.MediumBlue;
            this.grpDatesTransaction.Location = new System.Drawing.Point(12, 57);
            this.grpDatesTransaction.Name = "grpDatesTransaction";
            this.grpDatesTransaction.Size = new System.Drawing.Size(539, 109);
            this.grpDatesTransaction.TabIndex = 2;
            this.grpDatesTransaction.TabStop = false;
            this.grpDatesTransaction.Text = "Date/s of Transaction";
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Location = new System.Drawing.Point(166, 67);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(266, 29);
            this.dateTo.TabIndex = 6;
            // 
            // cbDateTo
            // 
            this.cbDateTo.AutoSize = true;
            this.cbDateTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDateTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDateTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbDateTo.Location = new System.Drawing.Point(91, 72);
            this.cbDateTo.Name = "cbDateTo";
            this.cbDateTo.Size = new System.Drawing.Size(43, 25);
            this.cbDateTo.TabIndex = 5;
            this.cbDateTo.Text = "To";
            this.cbDateTo.UseVisualStyleBackColor = true;
            this.cbDateTo.CheckedChanged += new System.EventHandler(this.cbDateTo_CheckedChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Location = new System.Drawing.Point(166, 32);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(266, 29);
            this.dateFrom.TabIndex = 4;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFrom.Location = new System.Drawing.Point(90, 38);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(47, 21);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports - Daily Collection Report";
            // 
            // CollectionReport
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(559, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDatesTransaction);
            this.Controls.Add(this.grpTransType);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.panelShare);
            this.Controls.Add(this.panelLoan);
            this.Controls.Add(this.panelMiscFees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(575, 395);
            this.Name = "CollectionReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Collection Report";
            this.grpTransType.ResumeLayout(false);
            this.grpTransType.PerformLayout();
            this.grpLoanTypesSort.ResumeLayout(false);
            this.grpLoanTypesSort.PerformLayout();
            this.panelLoan.ResumeLayout(false);
            this.panelMiscFees.ResumeLayout(false);
            this.grpMiscFeesSort.ResumeLayout(false);
            this.grpMiscFeesSort.PerformLayout();
            this.panelShare.ResumeLayout(false);
            this.grpShareSort.ResumeLayout(false);
            this.grpShareSort.PerformLayout();
            this.grpDatesTransaction.ResumeLayout(false);
            this.grpDatesTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox grpTransType;
        private System.Windows.Forms.RadioButton rbMiscFees;
        private System.Windows.Forms.RadioButton rbLoan;
        private System.Windows.Forms.GroupBox grpLoanTypesSort;
        private System.Windows.Forms.ComboBox cbLoanTypesSort;
        private System.Windows.Forms.RadioButton rbLoanTypesDescending;
        private System.Windows.Forms.RadioButton rbLoanTypesAscending;
        private System.Windows.Forms.Panel panelLoan;
        private System.Windows.Forms.Panel panelMiscFees;
        private System.Windows.Forms.GroupBox grpMiscFeesSort;
        private System.Windows.Forms.ComboBox cbMiscFeesSort;
        private System.Windows.Forms.RadioButton rbMiscFeesDescending;
        private System.Windows.Forms.RadioButton rbMiscFeesAscending;
        private System.Windows.Forms.RadioButton rbShare;
        private System.Windows.Forms.Panel panelShare;
        private System.Windows.Forms.GroupBox grpShareSort;
        private System.Windows.Forms.ComboBox cbShareSort;
        private System.Windows.Forms.RadioButton rbShareDescending;
        private System.Windows.Forms.RadioButton rbShareAscending;
        private System.Windows.Forms.GroupBox grpDatesTransaction;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.CheckBox cbDateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label1;
    }
}