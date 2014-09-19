namespace CMS.Loan_Management.Reports.View
{
    partial class ScheduleOfDelinquents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleOfDelinquents));
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblLoanTypes = new System.Windows.Forms.Label();
            this.checkedListBoxLoanTypes = new System.Windows.Forms.CheckedListBox();
            this.cbAllLoanTypes = new System.Windows.Forms.CheckBox();
            this.cbAge = new System.Windows.Forms.CheckBox();
            this.grpLoanTypesSort = new System.Windows.Forms.GroupBox();
            this.cbLoanTypesSort = new System.Windows.Forms.ComboBox();
            this.rbLoanTypesDescending = new System.Windows.Forms.RadioButton();
            this.rbLoanTypesAscending = new System.Windows.Forms.RadioButton();
            this.cbAgeBracket = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.grpLoanTypesSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateFrom
            // 
            this.dateFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Location = new System.Drawing.Point(383, 66);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(266, 29);
            this.dateFrom.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(334, 72);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(43, 21);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "as of";
            // 
            // lblLoanTypes
            // 
            this.lblLoanTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoanTypes.AutoSize = true;
            this.lblLoanTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanTypes.Location = new System.Drawing.Point(57, 110);
            this.lblLoanTypes.Name = "lblLoanTypes";
            this.lblLoanTypes.Size = new System.Drawing.Size(151, 21);
            this.lblLoanTypes.TabIndex = 4;
            this.lblLoanTypes.Text = "Loan Types Included";
            // 
            // checkedListBoxLoanTypes
            // 
            this.checkedListBoxLoanTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBoxLoanTypes.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxLoanTypes.FormattingEnabled = true;
            this.checkedListBoxLoanTypes.Location = new System.Drawing.Point(32, 139);
            this.checkedListBoxLoanTypes.Name = "checkedListBoxLoanTypes";
            this.checkedListBoxLoanTypes.Size = new System.Drawing.Size(593, 100);
            this.checkedListBoxLoanTypes.TabIndex = 6;
            // 
            // cbAllLoanTypes
            // 
            this.cbAllLoanTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAllLoanTypes.AutoSize = true;
            this.cbAllLoanTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAllLoanTypes.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllLoanTypes.Location = new System.Drawing.Point(214, 108);
            this.cbAllLoanTypes.Name = "cbAllLoanTypes";
            this.cbAllLoanTypes.Size = new System.Drawing.Size(84, 25);
            this.cbAllLoanTypes.TabIndex = 5;
            this.cbAllLoanTypes.Text = "All types";
            this.cbAllLoanTypes.UseVisualStyleBackColor = true;
            this.cbAllLoanTypes.CheckedChanged += new System.EventHandler(this.cbAllLoanTypes_CheckedChanged);
            // 
            // cbAge
            // 
            this.cbAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAge.AutoSize = true;
            this.cbAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAge.Location = new System.Drawing.Point(61, 246);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(113, 25);
            this.cbAge.TabIndex = 7;
            this.cbAge.Text = "Filter by Age";
            this.cbAge.UseVisualStyleBackColor = true;
            this.cbAge.CheckedChanged += new System.EventHandler(this.cbAge_CheckedChanged);
            // 
            // grpLoanTypesSort
            // 
            this.grpLoanTypesSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpLoanTypesSort.Controls.Add(this.cbLoanTypesSort);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesDescending);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesAscending);
            this.grpLoanTypesSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpLoanTypesSort.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoanTypesSort.ForeColor = System.Drawing.Color.MediumBlue;
            this.grpLoanTypesSort.Location = new System.Drawing.Point(27, 280);
            this.grpLoanTypesSort.Name = "grpLoanTypesSort";
            this.grpLoanTypesSort.Size = new System.Drawing.Size(377, 88);
            this.grpLoanTypesSort.TabIndex = 9;
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
            "Member Account No",
            "Member Name",
            "Loan Type"});
            this.cbLoanTypesSort.Location = new System.Drawing.Point(18, 32);
            this.cbLoanTypesSort.Name = "cbLoanTypesSort";
            this.cbLoanTypesSort.Size = new System.Drawing.Size(210, 29);
            this.cbLoanTypesSort.TabIndex = 10;
            // 
            // rbLoanTypesDescending
            // 
            this.rbLoanTypesDescending.AutoSize = true;
            this.rbLoanTypesDescending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLoanTypesDescending.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLoanTypesDescending.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLoanTypesDescending.Location = new System.Drawing.Point(243, 53);
            this.rbLoanTypesDescending.Name = "rbLoanTypesDescending";
            this.rbLoanTypesDescending.Size = new System.Drawing.Size(108, 25);
            this.rbLoanTypesDescending.TabIndex = 12;
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
            this.rbLoanTypesAscending.Location = new System.Drawing.Point(243, 24);
            this.rbLoanTypesAscending.Name = "rbLoanTypesAscending";
            this.rbLoanTypesAscending.Size = new System.Drawing.Size(99, 25);
            this.rbLoanTypesAscending.TabIndex = 11;
            this.rbLoanTypesAscending.TabStop = true;
            this.rbLoanTypesAscending.Text = "Ascending";
            this.rbLoanTypesAscending.UseVisualStyleBackColor = true;
            // 
            // cbAgeBracket
            // 
            this.cbAgeBracket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAgeBracket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgeBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAgeBracket.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgeBracket.FormattingEnabled = true;
            this.cbAgeBracket.Items.AddRange(new object[] {
            "1-30 days",
            "31-60 days",
            "61-90 days",
            "91-120 days",
            "121-180 days",
            "181-365 days",
            "1-2 years",
            "2-3 years",
            "3-4 years",
            "4-5 years",
            "5 years above"});
            this.cbAgeBracket.Location = new System.Drawing.Point(180, 245);
            this.cbAgeBracket.Name = "cbAgeBracket";
            this.cbAgeBracket.Size = new System.Drawing.Size(264, 29);
            this.cbAgeBracket.TabIndex = 8;
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
            this.label1.Size = new System.Drawing.Size(627, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports - Schedule of Deliquent Accounts";
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
            this.btnPreview.Location = new System.Drawing.Point(535, 323);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(105, 35);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // ScheduleOfDelinquents
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(659, 386);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAgeBracket);
            this.Controls.Add(this.grpLoanTypesSort);
            this.Controls.Add(this.cbAge);
            this.Controls.Add(this.lblLoanTypes);
            this.Controls.Add(this.checkedListBoxLoanTypes);
            this.Controls.Add(this.cbAllLoanTypes);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.lblFrom);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 425);
            this.Name = "ScheduleOfDelinquents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule of Delinquent Accounts";
            this.grpLoanTypesSort.ResumeLayout(false);
            this.grpLoanTypesSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblLoanTypes;
        private System.Windows.Forms.CheckedListBox checkedListBoxLoanTypes;
        private System.Windows.Forms.CheckBox cbAllLoanTypes;
        private System.Windows.Forms.CheckBox cbAge;
        private System.Windows.Forms.GroupBox grpLoanTypesSort;
        private System.Windows.Forms.ComboBox cbLoanTypesSort;
        private System.Windows.Forms.RadioButton rbLoanTypesDescending;
        private System.Windows.Forms.RadioButton rbLoanTypesAscending;
        private System.Windows.Forms.ComboBox cbAgeBracket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreview;
    }
}