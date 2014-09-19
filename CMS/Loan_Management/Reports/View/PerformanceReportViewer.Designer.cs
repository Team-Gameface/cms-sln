namespace CMS.Loan_Management.Reports.View
{
    partial class PerformanceReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformanceReportViewer));
            this.numReportYear = new System.Windows.Forms.NumericUpDown();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.crViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numReportYear)).BeginInit();
            this.SuspendLayout();
            // 
            // numReportYear
            // 
            this.numReportYear.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numReportYear.Location = new System.Drawing.Point(122, 72);
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
            this.numReportYear.Size = new System.Drawing.Size(74, 29);
            this.numReportYear.TabIndex = 3;
            this.numReportYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numReportYear.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(30, 74);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(86, 21);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Select Year";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Image = global::CMS.Properties.Resources.ReportView;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(202, 67);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(110, 35);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // crViewer1
            // 
            this.crViewer1.ActiveViewIndex = -1;
            this.crViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crViewer1.Location = new System.Drawing.Point(0, 115);
            this.crViewer1.Name = "crViewer1";
            this.crViewer1.ShowGroupTreeButton = false;
            this.crViewer1.ShowLogo = false;
            this.crViewer1.ShowParameterPanelButton = false;
            this.crViewer1.Size = new System.Drawing.Size(784, 446);
            this.crViewer1.TabIndex = 5;
            this.crViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(706, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reports - Annual Financial Performance Report";
            // 
            // PerformanceReportViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.crViewer1);
            this.Controls.Add(this.numReportYear);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnPreview);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "PerformanceReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Report";
            ((System.ComponentModel.ISupportInitialize)(this.numReportYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numReportYear;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnPreview;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer1;
        private System.Windows.Forms.Label label2;
    }
}