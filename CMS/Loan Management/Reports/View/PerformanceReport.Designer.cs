namespace CMS.Loan_Management.Reports.View
{
    partial class PerformanceReport
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
            this.numReportYear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.panelMiscFees = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numReportYear)).BeginInit();
            this.panelMiscFees.SuspendLayout();
            this.SuspendLayout();
            // 
            // numReportYear
            // 
            this.numReportYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numReportYear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numReportYear.Location = new System.Drawing.Point(158, 14);
            this.numReportYear.Maximum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.numReportYear.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.numReportYear.Name = "numReportYear";
            this.numReportYear.Size = new System.Drawing.Size(105, 33);
            this.numReportYear.TabIndex = 0;
            this.numReportYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numReportYear.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reports - Daily Collection Report";
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(68, 20);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(84, 20);
            this.lblFrom.TabIndex = 19;
            this.lblFrom.Text = "Select year:";
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreview.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(253, 130);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 32);
            this.btnPreview.TabIndex = 25;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // panelMiscFees
            // 
            this.panelMiscFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMiscFees.Controls.Add(this.numReportYear);
            this.panelMiscFees.Controls.Add(this.lblFrom);
            this.panelMiscFees.Location = new System.Drawing.Point(8, 54);
            this.panelMiscFees.Name = "panelMiscFees";
            this.panelMiscFees.Size = new System.Drawing.Size(337, 61);
            this.panelMiscFees.TabIndex = 33;
            // 
            // PerformanceReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(357, 171);
            this.Controls.Add(this.panelMiscFees);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label1);
            this.Name = "PerformanceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Report";
            ((System.ComponentModel.ISupportInitialize)(this.numReportYear)).EndInit();
            this.panelMiscFees.ResumeLayout(false);
            this.panelMiscFees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numReportYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel panelMiscFees;
    }
}