namespace CMS.Savings.Reports.View
{
    partial class DailyTransactionLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyTransactionLog));
            this.btnPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.cbDateTo = new System.Windows.Forms.CheckBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.grpDatesTransaction = new System.Windows.Forms.GroupBox();
            this.rbAscending = new System.Windows.Forms.RadioButton();
            this.rbDescending = new System.Windows.Forms.RadioButton();
            this.cbSortBy = new System.Windows.Forms.ComboBox();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.grpDatesTransaction.SuspendLayout();
            this.grpSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreview.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(260, 251);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 32);
            this.btnPreview.TabIndex = 21;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Reports - Daily Transaction Log";
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFrom.Location = new System.Drawing.Point(8, 34);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 17);
            this.lblFrom.TabIndex = 18;
            this.lblFrom.Text = "From:";
            // 
            // dateFrom
            // 
            this.dateFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(55, 28);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(97, 25);
            this.dateFrom.TabIndex = 22;
            this.dateFrom.Value = new System.DateTime(2014, 9, 7, 0, 0, 0, 0);
            // 
            // cbDateTo
            // 
            this.cbDateTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDateTo.AutoSize = true;
            this.cbDateTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDateTo.Location = new System.Drawing.Point(180, 30);
            this.cbDateTo.Name = "cbDateTo";
            this.cbDateTo.Size = new System.Drawing.Size(46, 23);
            this.cbDateTo.TabIndex = 23;
            this.cbDateTo.Text = "To:";
            this.cbDateTo.UseVisualStyleBackColor = true;
            this.cbDateTo.CheckedChanged += new System.EventHandler(this.cbDateTo_CheckedChanged);
            // 
            // dateTo
            // 
            this.dateTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(231, 28);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(97, 25);
            this.dateTo.TabIndex = 23;
            // 
            // grpDatesTransaction
            // 
            this.grpDatesTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDatesTransaction.Controls.Add(this.dateTo);
            this.grpDatesTransaction.Controls.Add(this.cbDateTo);
            this.grpDatesTransaction.Controls.Add(this.dateFrom);
            this.grpDatesTransaction.Controls.Add(this.lblFrom);
            this.grpDatesTransaction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatesTransaction.Location = new System.Drawing.Point(18, 69);
            this.grpDatesTransaction.Name = "grpDatesTransaction";
            this.grpDatesTransaction.Size = new System.Drawing.Size(334, 62);
            this.grpDatesTransaction.TabIndex = 20;
            this.grpDatesTransaction.TabStop = false;
            this.grpDatesTransaction.Text = "Date/s of Transaction:";
            // 
            // rbAscending
            // 
            this.rbAscending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAscending.AutoSize = true;
            this.rbAscending.Location = new System.Drawing.Point(217, 24);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(90, 23);
            this.rbAscending.TabIndex = 26;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "Ascending";
            this.rbAscending.UseVisualStyleBackColor = true;
            // 
            // rbDescending
            // 
            this.rbDescending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDescending.AutoSize = true;
            this.rbDescending.Location = new System.Drawing.Point(217, 48);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(98, 23);
            this.rbDescending.TabIndex = 26;
            this.rbDescending.TabStop = true;
            this.rbDescending.Text = "Descending";
            this.rbDescending.UseVisualStyleBackColor = true;
            // 
            // cbSortBy
            // 
            this.cbSortBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSortBy.FormattingEnabled = true;
            this.cbSortBy.Items.AddRange(new object[] {
            "Transaction Time",
            "Member Account No",
            "Member Name",
            "OR Number"});
            this.cbSortBy.Location = new System.Drawing.Point(7, 24);
            this.cbSortBy.Name = "cbSortBy";
            this.cbSortBy.Size = new System.Drawing.Size(198, 25);
            this.cbSortBy.TabIndex = 25;
            // 
            // grpSort
            // 
            this.grpSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpSort.Controls.Add(this.cbSortBy);
            this.grpSort.Controls.Add(this.rbDescending);
            this.grpSort.Controls.Add(this.rbAscending);
            this.grpSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpSort.Location = new System.Drawing.Point(18, 150);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(334, 77);
            this.grpSort.TabIndex = 27;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sort by:";
            // 
            // DailyTransactionLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(368, 292);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.grpDatesTransaction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DailyTransactionLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Transaction Log";
            this.grpDatesTransaction.ResumeLayout(false);
            this.grpDatesTransaction.PerformLayout();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.CheckBox cbDateTo;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.GroupBox grpDatesTransaction;
        private System.Windows.Forms.RadioButton rbAscending;
        private System.Windows.Forms.RadioButton rbDescending;
        private System.Windows.Forms.ComboBox cbSortBy;
        private System.Windows.Forms.GroupBox grpSort;
    }
}