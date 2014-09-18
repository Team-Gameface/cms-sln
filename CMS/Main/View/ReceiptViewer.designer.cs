namespace CMS.Main.View
{
    partial class ReceiptViewer
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
            this.crViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crViewer1
            // 
            this.crViewer1.ActiveViewIndex = -1;
            this.crViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewer1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crViewer1.Location = new System.Drawing.Point(0, 0);
            this.crViewer1.Name = "crViewer1";
            this.crViewer1.ShowGroupTreeButton = false;
            this.crViewer1.ShowLogo = false;
            this.crViewer1.ShowParameterPanelButton = false;
            this.crViewer1.Size = new System.Drawing.Size(484, 611);
            this.crViewer1.TabIndex = 3;
            this.crViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReceiptViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.crViewer1);
            this.MaximumSize = new System.Drawing.Size(500, 650);
            this.Name = "ReceiptViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Official Receipt";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer1;
    }
}