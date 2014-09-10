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
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblLoanTypes = new System.Windows.Forms.Label();
            this.checkedListBoxLoanTypes = new System.Windows.Forms.CheckedListBox();
            this.cbAllLoanTypes = new System.Windows.Forms.CheckBox();
            this.panelMiscFees = new System.Windows.Forms.Panel();
            this.lblMiscFees = new System.Windows.Forms.Label();
            this.checkedListBoxMiscFees = new System.Windows.Forms.CheckedListBox();
            this.grpMiscFeesSort = new System.Windows.Forms.GroupBox();
            this.cbMiscFeesSort = new System.Windows.Forms.ComboBox();
            this.rbMiscFeesDescending = new System.Windows.Forms.RadioButton();
            this.rbMiscFeesAscending = new System.Windows.Forms.RadioButton();
            this.cbAllMiscFees = new System.Windows.Forms.CheckBox();
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reports - Daily Collection Report";
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreview.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(574, 317);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 32);
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
            this.grpTransType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpTransType.Location = new System.Drawing.Point(18, 148);
            this.grpTransType.Name = "grpTransType";
            this.grpTransType.Size = new System.Drawing.Size(334, 105);
            this.grpTransType.TabIndex = 28;
            this.grpTransType.TabStop = false;
            this.grpTransType.Text = "Transaction Type:";
            // 
            // rbShare
            // 
            this.rbShare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbShare.AutoSize = true;
            this.rbShare.Location = new System.Drawing.Point(24, 76);
            this.rbShare.Name = "rbShare";
            this.rbShare.Size = new System.Drawing.Size(195, 23);
            this.rbShare.TabIndex = 26;
            this.rbShare.TabStop = true;
            this.rbShare.Text = "Share Capital Contributions";
            this.rbShare.UseVisualStyleBackColor = true;
            this.rbShare.CheckedChanged += new System.EventHandler(this.rbShare_CheckedChanged);
            // 
            // rbMiscFees
            // 
            this.rbMiscFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMiscFees.AutoSize = true;
            this.rbMiscFees.Location = new System.Drawing.Point(24, 51);
            this.rbMiscFees.Name = "rbMiscFees";
            this.rbMiscFees.Size = new System.Drawing.Size(143, 23);
            this.rbMiscFees.TabIndex = 26;
            this.rbMiscFees.TabStop = true;
            this.rbMiscFees.Text = "Miscellaneous Fees";
            this.rbMiscFees.UseVisualStyleBackColor = true;
            this.rbMiscFees.CheckedChanged += new System.EventHandler(this.rbMiscFees_CheckedChanged);
            // 
            // rbLoan
            // 
            this.rbLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbLoan.AutoSize = true;
            this.rbLoan.Location = new System.Drawing.Point(24, 28);
            this.rbLoan.Name = "rbLoan";
            this.rbLoan.Size = new System.Drawing.Size(121, 23);
            this.rbLoan.TabIndex = 26;
            this.rbLoan.TabStop = true;
            this.rbLoan.Text = "Loan Payments";
            this.rbLoan.UseVisualStyleBackColor = true;
            this.rbLoan.CheckedChanged += new System.EventHandler(this.rbLoan_CheckedChanged);
            // 
            // grpLoanTypesSort
            // 
            this.grpLoanTypesSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpLoanTypesSort.Controls.Add(this.cbLoanTypesSort);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesDescending);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesAscending);
            this.grpLoanTypesSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpLoanTypesSort.Location = new System.Drawing.Point(6, 178);
            this.grpLoanTypesSort.Name = "grpLoanTypesSort";
            this.grpLoanTypesSort.Size = new System.Drawing.Size(291, 83);
            this.grpLoanTypesSort.TabIndex = 28;
            this.grpLoanTypesSort.TabStop = false;
            this.grpLoanTypesSort.Text = "Sort by:";
            // 
            // cbLoanTypesSort
            // 
            this.cbLoanTypesSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLoanTypesSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoanTypesSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoanTypesSort.FormattingEnabled = true;
            this.cbLoanTypesSort.Items.AddRange(new object[] {
            "Transaction Time",
            "Member Account No",
            "Member Name",
            "Loan Type",
            "OR Number"});
            this.cbLoanTypesSort.Location = new System.Drawing.Point(23, 24);
            this.cbLoanTypesSort.Name = "cbLoanTypesSort";
            this.cbLoanTypesSort.Size = new System.Drawing.Size(251, 25);
            this.cbLoanTypesSort.TabIndex = 25;
            // 
            // rbLoanTypesDescending
            // 
            this.rbLoanTypesDescending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbLoanTypesDescending.AutoSize = true;
            this.rbLoanTypesDescending.Location = new System.Drawing.Point(135, 55);
            this.rbLoanTypesDescending.Name = "rbLoanTypesDescending";
            this.rbLoanTypesDescending.Size = new System.Drawing.Size(98, 23);
            this.rbLoanTypesDescending.TabIndex = 26;
            this.rbLoanTypesDescending.TabStop = true;
            this.rbLoanTypesDescending.Text = "Descending";
            this.rbLoanTypesDescending.UseVisualStyleBackColor = true;
            // 
            // rbLoanTypesAscending
            // 
            this.rbLoanTypesAscending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbLoanTypesAscending.AutoSize = true;
            this.rbLoanTypesAscending.Location = new System.Drawing.Point(23, 55);
            this.rbLoanTypesAscending.Name = "rbLoanTypesAscending";
            this.rbLoanTypesAscending.Size = new System.Drawing.Size(90, 23);
            this.rbLoanTypesAscending.TabIndex = 26;
            this.rbLoanTypesAscending.TabStop = true;
            this.rbLoanTypesAscending.Text = "Ascending";
            this.rbLoanTypesAscending.UseVisualStyleBackColor = true;
            // 
            // panelLoan
            // 
            this.panelLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLoan.Controls.Add(this.lblLoanTypes);
            this.panelLoan.Controls.Add(this.checkedListBoxLoanTypes);
            this.panelLoan.Controls.Add(this.grpLoanTypesSort);
            this.panelLoan.Controls.Add(this.cbAllLoanTypes);
            this.panelLoan.Location = new System.Drawing.Point(362, 40);
            this.panelLoan.Name = "panelLoan";
            this.panelLoan.Size = new System.Drawing.Size(304, 271);
            this.panelLoan.TabIndex = 32;
            // 
            // lblLoanTypes
            // 
            this.lblLoanTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoanTypes.AutoSize = true;
            this.lblLoanTypes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLoanTypes.Location = new System.Drawing.Point(3, 7);
            this.lblLoanTypes.Name = "lblLoanTypes";
            this.lblLoanTypes.Size = new System.Drawing.Size(130, 17);
            this.lblLoanTypes.TabIndex = 29;
            this.lblLoanTypes.Text = "Loan Types Included:";
            // 
            // checkedListBoxLoanTypes
            // 
            this.checkedListBoxLoanTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBoxLoanTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkedListBoxLoanTypes.FormattingEnabled = true;
            this.checkedListBoxLoanTypes.Location = new System.Drawing.Point(6, 31);
            this.checkedListBoxLoanTypes.Name = "checkedListBoxLoanTypes";
            this.checkedListBoxLoanTypes.Size = new System.Drawing.Size(291, 144);
            this.checkedListBoxLoanTypes.TabIndex = 31;
            // 
            // cbAllLoanTypes
            // 
            this.cbAllLoanTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAllLoanTypes.AutoSize = true;
            this.cbAllLoanTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAllLoanTypes.Location = new System.Drawing.Point(217, 5);
            this.cbAllLoanTypes.Name = "cbAllLoanTypes";
            this.cbAllLoanTypes.Size = new System.Drawing.Size(80, 23);
            this.cbAllLoanTypes.TabIndex = 30;
            this.cbAllLoanTypes.Text = "All types";
            this.cbAllLoanTypes.UseVisualStyleBackColor = true;
            this.cbAllLoanTypes.CheckedChanged += new System.EventHandler(this.cbAllLoanTypes_CheckedChanged);
            // 
            // panelMiscFees
            // 
            this.panelMiscFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMiscFees.Controls.Add(this.lblMiscFees);
            this.panelMiscFees.Controls.Add(this.checkedListBoxMiscFees);
            this.panelMiscFees.Controls.Add(this.grpMiscFeesSort);
            this.panelMiscFees.Controls.Add(this.cbAllMiscFees);
            this.panelMiscFees.Location = new System.Drawing.Point(362, 40);
            this.panelMiscFees.Name = "panelMiscFees";
            this.panelMiscFees.Size = new System.Drawing.Size(304, 271);
            this.panelMiscFees.TabIndex = 32;
            // 
            // lblMiscFees
            // 
            this.lblMiscFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMiscFees.AutoSize = true;
            this.lblMiscFees.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMiscFees.Location = new System.Drawing.Point(3, 7);
            this.lblMiscFees.Name = "lblMiscFees";
            this.lblMiscFees.Size = new System.Drawing.Size(124, 17);
            this.lblMiscFees.TabIndex = 29;
            this.lblMiscFees.Text = "Misc. Fees Included:";
            // 
            // checkedListBoxMiscFees
            // 
            this.checkedListBoxMiscFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBoxMiscFees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkedListBoxMiscFees.FormattingEnabled = true;
            this.checkedListBoxMiscFees.Location = new System.Drawing.Point(6, 31);
            this.checkedListBoxMiscFees.Name = "checkedListBoxMiscFees";
            this.checkedListBoxMiscFees.Size = new System.Drawing.Size(291, 144);
            this.checkedListBoxMiscFees.TabIndex = 31;
            // 
            // grpMiscFeesSort
            // 
            this.grpMiscFeesSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpMiscFeesSort.Controls.Add(this.cbMiscFeesSort);
            this.grpMiscFeesSort.Controls.Add(this.rbMiscFeesDescending);
            this.grpMiscFeesSort.Controls.Add(this.rbMiscFeesAscending);
            this.grpMiscFeesSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpMiscFeesSort.Location = new System.Drawing.Point(6, 178);
            this.grpMiscFeesSort.Name = "grpMiscFeesSort";
            this.grpMiscFeesSort.Size = new System.Drawing.Size(291, 83);
            this.grpMiscFeesSort.TabIndex = 28;
            this.grpMiscFeesSort.TabStop = false;
            this.grpMiscFeesSort.Text = "Sort by:";
            // 
            // cbMiscFeesSort
            // 
            this.cbMiscFeesSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMiscFeesSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMiscFeesSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMiscFeesSort.FormattingEnabled = true;
            this.cbMiscFeesSort.Items.AddRange(new object[] {
            "Transaction Time",
            "Member Account No",
            "Member Name",
            "Description",
            "OR Number"});
            this.cbMiscFeesSort.Location = new System.Drawing.Point(23, 24);
            this.cbMiscFeesSort.Name = "cbMiscFeesSort";
            this.cbMiscFeesSort.Size = new System.Drawing.Size(251, 25);
            this.cbMiscFeesSort.TabIndex = 25;
            // 
            // rbMiscFeesDescending
            // 
            this.rbMiscFeesDescending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMiscFeesDescending.AutoSize = true;
            this.rbMiscFeesDescending.Location = new System.Drawing.Point(135, 55);
            this.rbMiscFeesDescending.Name = "rbMiscFeesDescending";
            this.rbMiscFeesDescending.Size = new System.Drawing.Size(98, 23);
            this.rbMiscFeesDescending.TabIndex = 26;
            this.rbMiscFeesDescending.TabStop = true;
            this.rbMiscFeesDescending.Text = "Descending";
            this.rbMiscFeesDescending.UseVisualStyleBackColor = true;
            // 
            // rbMiscFeesAscending
            // 
            this.rbMiscFeesAscending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMiscFeesAscending.AutoSize = true;
            this.rbMiscFeesAscending.Location = new System.Drawing.Point(23, 55);
            this.rbMiscFeesAscending.Name = "rbMiscFeesAscending";
            this.rbMiscFeesAscending.Size = new System.Drawing.Size(90, 23);
            this.rbMiscFeesAscending.TabIndex = 26;
            this.rbMiscFeesAscending.TabStop = true;
            this.rbMiscFeesAscending.Text = "Ascending";
            this.rbMiscFeesAscending.UseVisualStyleBackColor = true;
            // 
            // cbAllMiscFees
            // 
            this.cbAllMiscFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAllMiscFees.AutoSize = true;
            this.cbAllMiscFees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAllMiscFees.Location = new System.Drawing.Point(217, 5);
            this.cbAllMiscFees.Name = "cbAllMiscFees";
            this.cbAllMiscFees.Size = new System.Drawing.Size(71, 23);
            this.cbAllMiscFees.TabIndex = 30;
            this.cbAllMiscFees.Text = "All fees";
            this.cbAllMiscFees.UseVisualStyleBackColor = true;
            this.cbAllMiscFees.CheckedChanged += new System.EventHandler(this.cbAllMiscFees_CheckedChanged);
            // 
            // panelShare
            // 
            this.panelShare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelShare.Controls.Add(this.grpShareSort);
            this.panelShare.Location = new System.Drawing.Point(362, 40);
            this.panelShare.Name = "panelShare";
            this.panelShare.Size = new System.Drawing.Size(304, 271);
            this.panelShare.TabIndex = 33;
            // 
            // grpShareSort
            // 
            this.grpShareSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpShareSort.Controls.Add(this.cbShareSort);
            this.grpShareSort.Controls.Add(this.rbShareDescending);
            this.grpShareSort.Controls.Add(this.rbShareAscending);
            this.grpShareSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpShareSort.Location = new System.Drawing.Point(3, 113);
            this.grpShareSort.Name = "grpShareSort";
            this.grpShareSort.Size = new System.Drawing.Size(291, 83);
            this.grpShareSort.TabIndex = 28;
            this.grpShareSort.TabStop = false;
            this.grpShareSort.Text = "Sort by:";
            // 
            // cbShareSort
            // 
            this.cbShareSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShareSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShareSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbShareSort.FormattingEnabled = true;
            this.cbShareSort.Items.AddRange(new object[] {
            "Transaction Time",
            "Member Account No",
            "Member Name",
            "OR Number"});
            this.cbShareSort.Location = new System.Drawing.Point(23, 24);
            this.cbShareSort.Name = "cbShareSort";
            this.cbShareSort.Size = new System.Drawing.Size(251, 25);
            this.cbShareSort.TabIndex = 25;
            // 
            // rbShareDescending
            // 
            this.rbShareDescending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbShareDescending.AutoSize = true;
            this.rbShareDescending.Location = new System.Drawing.Point(135, 55);
            this.rbShareDescending.Name = "rbShareDescending";
            this.rbShareDescending.Size = new System.Drawing.Size(98, 23);
            this.rbShareDescending.TabIndex = 26;
            this.rbShareDescending.TabStop = true;
            this.rbShareDescending.Text = "Descending";
            this.rbShareDescending.UseVisualStyleBackColor = true;
            // 
            // rbShareAscending
            // 
            this.rbShareAscending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbShareAscending.AutoSize = true;
            this.rbShareAscending.Location = new System.Drawing.Point(23, 55);
            this.rbShareAscending.Name = "rbShareAscending";
            this.rbShareAscending.Size = new System.Drawing.Size(90, 23);
            this.rbShareAscending.TabIndex = 26;
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
            this.grpDatesTransaction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatesTransaction.Location = new System.Drawing.Point(18, 47);
            this.grpDatesTransaction.Name = "grpDatesTransaction";
            this.grpDatesTransaction.Size = new System.Drawing.Size(334, 90);
            this.grpDatesTransaction.TabIndex = 34;
            this.grpDatesTransaction.TabStop = false;
            this.grpDatesTransaction.Text = "Date/s of Transaction:";
            // 
            // dateTo
            // 
            this.dateTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTo.Location = new System.Drawing.Point(82, 53);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(233, 25);
            this.dateTo.TabIndex = 23;
            // 
            // cbDateTo
            // 
            this.cbDateTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDateTo.AutoSize = true;
            this.cbDateTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDateTo.Location = new System.Drawing.Point(7, 55);
            this.cbDateTo.Name = "cbDateTo";
            this.cbDateTo.Size = new System.Drawing.Size(46, 23);
            this.cbDateTo.TabIndex = 23;
            this.cbDateTo.Text = "To:";
            this.cbDateTo.UseVisualStyleBackColor = true;
            this.cbDateTo.CheckedChanged += new System.EventHandler(this.cbDateTo_CheckedChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateFrom.Location = new System.Drawing.Point(82, 24);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(233, 25);
            this.dateFrom.TabIndex = 22;
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFrom.Location = new System.Drawing.Point(25, 32);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 17);
            this.lblFrom.TabIndex = 18;
            this.lblFrom.Text = "From:";
            // 
            // CollectionReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(678, 352);
            this.Controls.Add(this.grpDatesTransaction);
            this.Controls.Add(this.grpTransType);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelShare);
            this.Controls.Add(this.panelMiscFees);
            this.Controls.Add(this.panelLoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CollectionReport";
            this.Text = "Collection Report";
            this.grpTransType.ResumeLayout(false);
            this.grpTransType.PerformLayout();
            this.grpLoanTypesSort.ResumeLayout(false);
            this.grpLoanTypesSort.PerformLayout();
            this.panelLoan.ResumeLayout(false);
            this.panelLoan.PerformLayout();
            this.panelMiscFees.ResumeLayout(false);
            this.panelMiscFees.PerformLayout();
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox grpTransType;
        private System.Windows.Forms.RadioButton rbMiscFees;
        private System.Windows.Forms.RadioButton rbLoan;
        private System.Windows.Forms.GroupBox grpLoanTypesSort;
        private System.Windows.Forms.ComboBox cbLoanTypesSort;
        private System.Windows.Forms.RadioButton rbLoanTypesDescending;
        private System.Windows.Forms.RadioButton rbLoanTypesAscending;
        private System.Windows.Forms.Panel panelLoan;
        private System.Windows.Forms.Label lblLoanTypes;
        private System.Windows.Forms.CheckedListBox checkedListBoxLoanTypes;
        private System.Windows.Forms.CheckBox cbAllLoanTypes;
        private System.Windows.Forms.Panel panelMiscFees;
        private System.Windows.Forms.Label lblMiscFees;
        private System.Windows.Forms.CheckedListBox checkedListBoxMiscFees;
        private System.Windows.Forms.GroupBox grpMiscFeesSort;
        private System.Windows.Forms.ComboBox cbMiscFeesSort;
        private System.Windows.Forms.RadioButton rbMiscFeesDescending;
        private System.Windows.Forms.RadioButton rbMiscFeesAscending;
        private System.Windows.Forms.CheckBox cbAllMiscFees;
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
    }
}