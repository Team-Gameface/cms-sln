namespace CMS.Loan_Management.Reports.View
{
    partial class LoanReleases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanReleases));
            this.lblLoanTypes = new System.Windows.Forms.Label();
            this.checkedListBoxLoanTypes = new System.Windows.Forms.CheckedListBox();
            this.grpLoanTypesSort = new System.Windows.Forms.GroupBox();
            this.cbLoanTypesSort = new System.Windows.Forms.ComboBox();
            this.rbLoanTypesDescending = new System.Windows.Forms.RadioButton();
            this.rbLoanTypesAscending = new System.Windows.Forms.RadioButton();
            this.cbAllLoanTypes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatesTransaction = new System.Windows.Forms.GroupBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.grpLoanTypesSort.SuspendLayout();
            this.grpDatesTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoanTypes
            // 
            this.lblLoanTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoanTypes.AutoSize = true;
            this.lblLoanTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanTypes.Location = new System.Drawing.Point(21, 183);
            this.lblLoanTypes.Name = "lblLoanTypes";
            this.lblLoanTypes.Size = new System.Drawing.Size(151, 21);
            this.lblLoanTypes.TabIndex = 7;
            this.lblLoanTypes.Text = "Loan Types Included";
            // 
            // checkedListBoxLoanTypes
            // 
            this.checkedListBoxLoanTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBoxLoanTypes.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxLoanTypes.FormattingEnabled = true;
            this.checkedListBoxLoanTypes.Location = new System.Drawing.Point(14, 215);
            this.checkedListBoxLoanTypes.Name = "checkedListBoxLoanTypes";
            this.checkedListBoxLoanTypes.Size = new System.Drawing.Size(537, 124);
            this.checkedListBoxLoanTypes.TabIndex = 9;
            // 
            // grpLoanTypesSort
            // 
            this.grpLoanTypesSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpLoanTypesSort.Controls.Add(this.cbLoanTypesSort);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesDescending);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesAscending);
            this.grpLoanTypesSort.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grpLoanTypesSort.ForeColor = System.Drawing.Color.MediumBlue;
            this.grpLoanTypesSort.Location = new System.Drawing.Point(14, 345);
            this.grpLoanTypesSort.Name = "grpLoanTypesSort";
            this.grpLoanTypesSort.Size = new System.Drawing.Size(368, 83);
            this.grpLoanTypesSort.TabIndex = 10;
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
            "Approval Date",
            "Member Account No",
            "Member Name",
            "Loan Type",
            "Cash Voucher Number"});
            this.cbLoanTypesSort.Location = new System.Drawing.Point(11, 31);
            this.cbLoanTypesSort.Name = "cbLoanTypesSort";
            this.cbLoanTypesSort.Size = new System.Drawing.Size(200, 29);
            this.cbLoanTypesSort.TabIndex = 11;
            // 
            // rbLoanTypesDescending
            // 
            this.rbLoanTypesDescending.AutoSize = true;
            this.rbLoanTypesDescending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLoanTypesDescending.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLoanTypesDescending.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLoanTypesDescending.Location = new System.Drawing.Point(225, 53);
            this.rbLoanTypesDescending.Name = "rbLoanTypesDescending";
            this.rbLoanTypesDescending.Size = new System.Drawing.Size(108, 25);
            this.rbLoanTypesDescending.TabIndex = 13;
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
            this.rbLoanTypesAscending.Location = new System.Drawing.Point(225, 24);
            this.rbLoanTypesAscending.Name = "rbLoanTypesAscending";
            this.rbLoanTypesAscending.Size = new System.Drawing.Size(99, 25);
            this.rbLoanTypesAscending.TabIndex = 12;
            this.rbLoanTypesAscending.TabStop = true;
            this.rbLoanTypesAscending.Text = "Ascending";
            this.rbLoanTypesAscending.UseVisualStyleBackColor = true;
            // 
            // cbAllLoanTypes
            // 
            this.cbAllLoanTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAllLoanTypes.AutoSize = true;
            this.cbAllLoanTypes.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllLoanTypes.Location = new System.Drawing.Point(178, 182);
            this.cbAllLoanTypes.Name = "cbAllLoanTypes";
            this.cbAllLoanTypes.Size = new System.Drawing.Size(87, 25);
            this.cbAllLoanTypes.TabIndex = 8;
            this.cbAllLoanTypes.Text = "All types";
            this.cbAllLoanTypes.UseVisualStyleBackColor = true;
            this.cbAllLoanTypes.CheckedChanged += new System.EventHandler(this.cbAllLoanTypes_CheckedChanged);
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
            this.label1.Size = new System.Drawing.Size(367, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports - Loan Releases";
            // 
            // grpDatesTransaction
            // 
            this.grpDatesTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDatesTransaction.Controls.Add(this.lblTo);
            this.grpDatesTransaction.Controls.Add(this.dateTo);
            this.grpDatesTransaction.Controls.Add(this.dateFrom);
            this.grpDatesTransaction.Controls.Add(this.lblFrom);
            this.grpDatesTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDatesTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatesTransaction.ForeColor = System.Drawing.Color.MediumBlue;
            this.grpDatesTransaction.Location = new System.Drawing.Point(12, 60);
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
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTo.Location = new System.Drawing.Point(90, 73);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 21);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To";
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
            this.btnPreview.Location = new System.Drawing.Point(434, 388);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(105, 35);
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // LoanReleases
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(564, 446);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoanTypes);
            this.Controls.Add(this.checkedListBoxLoanTypes);
            this.Controls.Add(this.cbAllLoanTypes);
            this.Controls.Add(this.grpLoanTypesSort);
            this.Controls.Add(this.grpDatesTransaction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 485);
            this.Name = "LoanReleases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Releases";
            this.grpLoanTypesSort.ResumeLayout(false);
            this.grpLoanTypesSort.PerformLayout();
            this.grpDatesTransaction.ResumeLayout(false);
            this.grpDatesTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanTypes;
        private System.Windows.Forms.CheckedListBox checkedListBoxLoanTypes;
        private System.Windows.Forms.GroupBox grpLoanTypesSort;
        private System.Windows.Forms.ComboBox cbLoanTypesSort;
        private System.Windows.Forms.RadioButton rbLoanTypesDescending;
        private System.Windows.Forms.RadioButton rbLoanTypesAscending;
        private System.Windows.Forms.CheckBox cbAllLoanTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDatesTransaction;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnPreview;
    }
}