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
            this.label6 = new System.Windows.Forms.Label();
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
            this.btnPreview = new System.Windows.Forms.Button();
            this.cbAgeBracket = new System.Windows.Forms.ComboBox();
            this.grpLoanTypesSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(395, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Reports - Schedule of Delinquent Accounts";
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateFrom.Location = new System.Drawing.Point(59, 74);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(233, 25);
            this.dateFrom.TabIndex = 39;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFrom.Location = new System.Drawing.Point(13, 80);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 19);
            this.lblFrom.TabIndex = 38;
            this.lblFrom.Text = "as of:";
            // 
            // lblLoanTypes
            // 
            this.lblLoanTypes.AutoSize = true;
            this.lblLoanTypes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLoanTypes.Location = new System.Drawing.Point(13, 124);
            this.lblLoanTypes.Name = "lblLoanTypes";
            this.lblLoanTypes.Size = new System.Drawing.Size(130, 17);
            this.lblLoanTypes.TabIndex = 40;
            this.lblLoanTypes.Text = "Loan Types Included:";
            // 
            // checkedListBoxLoanTypes
            // 
            this.checkedListBoxLoanTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkedListBoxLoanTypes.FormattingEnabled = true;
            this.checkedListBoxLoanTypes.Location = new System.Drawing.Point(16, 144);
            this.checkedListBoxLoanTypes.Name = "checkedListBoxLoanTypes";
            this.checkedListBoxLoanTypes.Size = new System.Drawing.Size(377, 144);
            this.checkedListBoxLoanTypes.TabIndex = 42;
            // 
            // cbAllLoanTypes
            // 
            this.cbAllLoanTypes.AutoSize = true;
            this.cbAllLoanTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAllLoanTypes.Location = new System.Drawing.Point(313, 122);
            this.cbAllLoanTypes.Name = "cbAllLoanTypes";
            this.cbAllLoanTypes.Size = new System.Drawing.Size(80, 23);
            this.cbAllLoanTypes.TabIndex = 41;
            this.cbAllLoanTypes.Text = "All types";
            this.cbAllLoanTypes.UseVisualStyleBackColor = true;
            this.cbAllLoanTypes.CheckedChanged += new System.EventHandler(this.cbAllLoanTypes_CheckedChanged);
            // 
            // cbAge
            // 
            this.cbAge.AutoSize = true;
            this.cbAge.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbAge.Location = new System.Drawing.Point(16, 302);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(107, 21);
            this.cbAge.TabIndex = 45;
            this.cbAge.Text = "Filter by Age:";
            this.cbAge.UseVisualStyleBackColor = true;
            this.cbAge.CheckedChanged += new System.EventHandler(this.cbAge_CheckedChanged);
            // 
            // grpLoanTypesSort
            // 
            this.grpLoanTypesSort.Controls.Add(this.cbLoanTypesSort);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesDescending);
            this.grpLoanTypesSort.Controls.Add(this.rbLoanTypesAscending);
            this.grpLoanTypesSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpLoanTypesSort.Location = new System.Drawing.Point(16, 361);
            this.grpLoanTypesSort.Name = "grpLoanTypesSort";
            this.grpLoanTypesSort.Size = new System.Drawing.Size(377, 88);
            this.grpLoanTypesSort.TabIndex = 47;
            this.grpLoanTypesSort.TabStop = false;
            this.grpLoanTypesSort.Text = "Sort by:";
            // 
            // cbLoanTypesSort
            // 
            this.cbLoanTypesSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoanTypesSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoanTypesSort.FormattingEnabled = true;
            this.cbLoanTypesSort.Items.AddRange(new object[] {
            "Member Account No",
            "Member Name",
            "Loan Type"});
            this.cbLoanTypesSort.Location = new System.Drawing.Point(16, 24);
            this.cbLoanTypesSort.Name = "cbLoanTypesSort";
            this.cbLoanTypesSort.Size = new System.Drawing.Size(210, 25);
            this.cbLoanTypesSort.TabIndex = 25;
            // 
            // rbLoanTypesDescending
            // 
            this.rbLoanTypesDescending.AutoSize = true;
            this.rbLoanTypesDescending.Location = new System.Drawing.Point(243, 53);
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
            this.rbLoanTypesAscending.Location = new System.Drawing.Point(243, 24);
            this.rbLoanTypesAscending.Name = "rbLoanTypesAscending";
            this.rbLoanTypesAscending.Size = new System.Drawing.Size(90, 23);
            this.rbLoanTypesAscending.TabIndex = 26;
            this.rbLoanTypesAscending.TabStop = true;
            this.rbLoanTypesAscending.Text = "Ascending";
            this.rbLoanTypesAscending.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(304, 484);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 32);
            this.btnPreview.TabIndex = 46;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // cbAgeBracket
            // 
            this.cbAgeBracket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgeBracket.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            this.cbAgeBracket.Location = new System.Drawing.Point(129, 300);
            this.cbAgeBracket.Name = "cbAgeBracket";
            this.cbAgeBracket.Size = new System.Drawing.Size(264, 25);
            this.cbAgeBracket.TabIndex = 48;
            // 
            // ScheduleOfDelinquents
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(405, 521);
            this.Controls.Add(this.cbAgeBracket);
            this.Controls.Add(this.grpLoanTypesSort);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cbAge);
            this.Controls.Add(this.lblLoanTypes);
            this.Controls.Add(this.checkedListBoxLoanTypes);
            this.Controls.Add(this.cbAllLoanTypes);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScheduleOfDelinquents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule of Delinquent Accounts";
            this.grpLoanTypesSort.ResumeLayout(false);
            this.grpLoanTypesSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cbAgeBracket;
    }
}