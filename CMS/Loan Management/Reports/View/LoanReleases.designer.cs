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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.grpDatesTransaction = new System.Windows.Forms.GroupBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblLoanTypes = new System.Windows.Forms.Label();
            this.checkedListBoxLoanTypes = new System.Windows.Forms.CheckedListBox();
            this.grpLoanTypesSort = new System.Windows.Forms.GroupBox();
            this.cbLoanTypesSort = new System.Windows.Forms.ComboBox();
            this.rbLoanTypesDescending = new System.Windows.Forms.RadioButton();
            this.rbLoanTypesAscending = new System.Windows.Forms.RadioButton();
            this.cbAllLoanTypes = new System.Windows.Forms.CheckBox();
            this.grpGroupBy = new System.Windows.Forms.GroupBox();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbMember = new System.Windows.Forms.RadioButton();
            this.rbLoanType = new System.Windows.Forms.RadioButton();
            this.grpDatesTransaction.SuspendLayout();
            this.grpLoanTypesSort.SuspendLayout();
            this.grpGroupBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Reports - Loan Releases";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(263, 460);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 32);
            this.btnPreview.TabIndex = 25;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // grpDatesTransaction
            // 
            this.grpDatesTransaction.Controls.Add(this.dateTo);
            this.grpDatesTransaction.Controls.Add(this.dateFrom);
            this.grpDatesTransaction.Controls.Add(this.lblTo);
            this.grpDatesTransaction.Controls.Add(this.lblFrom);
            this.grpDatesTransaction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatesTransaction.Location = new System.Drawing.Point(18, 50);
            this.grpDatesTransaction.Name = "grpDatesTransaction";
            this.grpDatesTransaction.Size = new System.Drawing.Size(334, 90);
            this.grpDatesTransaction.TabIndex = 35;
            this.grpDatesTransaction.TabStop = false;
            this.grpDatesTransaction.Text = "Date/s of Transaction:";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(82, 53);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(233, 25);
            this.dateTo.TabIndex = 23;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(82, 24);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(233, 25);
            this.dateFrom.TabIndex = 22;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTo.Location = new System.Drawing.Point(25, 59);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 17);
            this.lblTo.TabIndex = 18;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFrom.Location = new System.Drawing.Point(25, 32);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 17);
            this.lblFrom.TabIndex = 18;
            this.lblFrom.Text = "From:";
            // 
            // lblLoanTypes
            // 
            this.lblLoanTypes.AutoSize = true;
            this.lblLoanTypes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLoanTypes.Location = new System.Drawing.Point(15, 148);
            this.lblLoanTypes.Name = "lblLoanTypes";
            this.lblLoanTypes.Size = new System.Drawing.Size(130, 17);
            this.lblLoanTypes.TabIndex = 37;
            this.lblLoanTypes.Text = "Loan Types Included:";
            // 
            // checkedListBoxLoanTypes
            // 
            this.checkedListBoxLoanTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkedListBoxLoanTypes.FormattingEnabled = true;
            this.checkedListBoxLoanTypes.Location = new System.Drawing.Point(18, 172);
            this.checkedListBoxLoanTypes.Name = "checkedListBoxLoanTypes";
            this.checkedListBoxLoanTypes.Size = new System.Drawing.Size(334, 144);
            this.checkedListBoxLoanTypes.TabIndex = 39;
            // 
            // grpLoanTypesSort
            // 
            this.grpLoanTypesSort.Controls.Add(this.cbLoanTypesSort);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesDescending);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesAscending);
            this.grpLoanTypesSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpLoanTypesSort.Location = new System.Drawing.Point(18, 371);
            this.grpLoanTypesSort.Name = "grpLoanTypesSort";
            this.grpLoanTypesSort.Size = new System.Drawing.Size(334, 83);
            this.grpLoanTypesSort.TabIndex = 36;
            this.grpLoanTypesSort.TabStop = false;
            this.grpLoanTypesSort.Text = "Sort by:";
            // 
            // cbLoanTypesSort
            // 
            this.cbLoanTypesSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoanTypesSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoanTypesSort.FormattingEnabled = true;
            this.cbLoanTypesSort.Items.AddRange(new object[] {
            "Transaction Time",
            "Member Account No",
            "Member Name",
            "Loan Type",
            "OR Number"});
            this.cbLoanTypesSort.Location = new System.Drawing.Point(11, 24);
            this.cbLoanTypesSort.Name = "cbLoanTypesSort";
            this.cbLoanTypesSort.Size = new System.Drawing.Size(200, 25);
            this.cbLoanTypesSort.TabIndex = 25;
            // 
            // rbLoanTypesDescending
            // 
            this.rbLoanTypesDescending.AutoSize = true;
            this.rbLoanTypesDescending.Location = new System.Drawing.Point(225, 53);
            this.rbLoanTypesDescending.Name = "rbLoanTypesDescending";
            this.rbLoanTypesDescending.Size = new System.Drawing.Size(98, 23);
            this.rbLoanTypesDescending.TabIndex = 26;
            this.rbLoanTypesDescending.TabStop = true;
            this.rbLoanTypesDescending.Text = "Descending";
            this.rbLoanTypesDescending.UseVisualStyleBackColor = true;
            // 
            // rbLoanTypesAscending
            // 
            this.rbLoanTypesAscending.AutoSize = true;
            this.rbLoanTypesAscending.Location = new System.Drawing.Point(225, 24);
            this.rbLoanTypesAscending.Name = "rbLoanTypesAscending";
            this.rbLoanTypesAscending.Size = new System.Drawing.Size(90, 23);
            this.rbLoanTypesAscending.TabIndex = 26;
            this.rbLoanTypesAscending.TabStop = true;
            this.rbLoanTypesAscending.Text = "Ascending";
            this.rbLoanTypesAscending.UseVisualStyleBackColor = true;
            // 
            // cbAllLoanTypes
            // 
            this.cbAllLoanTypes.AutoSize = true;
            this.cbAllLoanTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAllLoanTypes.Location = new System.Drawing.Point(272, 146);
            this.cbAllLoanTypes.Name = "cbAllLoanTypes";
            this.cbAllLoanTypes.Size = new System.Drawing.Size(80, 23);
            this.cbAllLoanTypes.TabIndex = 38;
            this.cbAllLoanTypes.Text = "All types";
            this.cbAllLoanTypes.UseVisualStyleBackColor = true;
            this.cbAllLoanTypes.CheckedChanged += new System.EventHandler(this.cbAllLoanTypes_CheckedChanged);
            // 
            // grpGroupBy
            // 
            this.grpGroupBy.Controls.Add(this.rbNone);
            this.grpGroupBy.Controls.Add(this.rbMember);
            this.grpGroupBy.Controls.Add(this.rbLoanType);
            this.grpGroupBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpGroupBy.Location = new System.Drawing.Point(18, 322);
            this.grpGroupBy.Name = "grpGroupBy";
            this.grpGroupBy.Size = new System.Drawing.Size(334, 43);
            this.grpGroupBy.TabIndex = 36;
            this.grpGroupBy.TabStop = false;
            this.grpGroupBy.Text = "Group by:";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(79, 14);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(60, 23);
            this.rbNone.TabIndex = 26;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbMember
            // 
            this.rbMember.AutoSize = true;
            this.rbMember.Location = new System.Drawing.Point(153, 14);
            this.rbMember.Name = "rbMember";
            this.rbMember.Size = new System.Drawing.Size(79, 23);
            this.rbMember.TabIndex = 26;
            this.rbMember.TabStop = true;
            this.rbMember.Text = "Member";
            this.rbMember.UseVisualStyleBackColor = true;
            // 
            // rbLoanType
            // 
            this.rbLoanType.AutoSize = true;
            this.rbLoanType.Location = new System.Drawing.Point(238, 14);
            this.rbLoanType.Name = "rbLoanType";
            this.rbLoanType.Size = new System.Drawing.Size(90, 23);
            this.rbLoanType.TabIndex = 26;
            this.rbLoanType.TabStop = true;
            this.rbLoanType.Text = "Loan Type";
            this.rbLoanType.UseVisualStyleBackColor = true;
            // 
            // LoanReleases
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(367, 495);
            this.Controls.Add(this.lblLoanTypes);
            this.Controls.Add(this.checkedListBoxLoanTypes);
            this.Controls.Add(this.grpGroupBy);
            this.Controls.Add(this.grpLoanTypesSort);
            this.Controls.Add(this.cbAllLoanTypes);
            this.Controls.Add(this.grpDatesTransaction);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label1);
            this.Name = "LoanReleases";
            this.Text = "Loan Releases";
            this.grpDatesTransaction.ResumeLayout(false);
            this.grpDatesTransaction.PerformLayout();
            this.grpLoanTypesSort.ResumeLayout(false);
            this.grpLoanTypesSort.PerformLayout();
            this.grpGroupBy.ResumeLayout(false);
            this.grpGroupBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox grpDatesTransaction;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblLoanTypes;
        private System.Windows.Forms.CheckedListBox checkedListBoxLoanTypes;
        private System.Windows.Forms.GroupBox grpLoanTypesSort;
        private System.Windows.Forms.ComboBox cbLoanTypesSort;
        private System.Windows.Forms.RadioButton rbLoanTypesDescending;
        private System.Windows.Forms.RadioButton rbLoanTypesAscending;
        private System.Windows.Forms.CheckBox cbAllLoanTypes;
        private System.Windows.Forms.GroupBox grpGroupBy;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbMember;
        private System.Windows.Forms.RadioButton rbLoanType;
    }
}