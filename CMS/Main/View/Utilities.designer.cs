namespace CMS.Main.View
{
    partial class Utilities
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupUtilities = new System.Windows.Forms.GroupBox();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnBatchProcess = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupUtilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupUtilities
            // 
            this.groupUtilities.Controls.Add(this.btnCompany);
            this.groupUtilities.Controls.Add(this.btnClose);
            this.groupUtilities.Controls.Add(this.btnBatchProcess);
            this.groupUtilities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupUtilities.Location = new System.Drawing.Point(107, 129);
            this.groupUtilities.Name = "groupUtilities";
            this.groupUtilities.Size = new System.Drawing.Size(789, 254);
            this.groupUtilities.TabIndex = 17;
            this.groupUtilities.TabStop = false;
            this.groupUtilities.Text = "Utilities";
            // 
            // btnCompany
            // 
            this.btnCompany.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCompany.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.ForeColor = System.Drawing.Color.White;
            this.btnCompany.Image = global::CMS.Properties.Resources.CompanyProfile;
            this.btnCompany.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompany.Location = new System.Drawing.Point(401, 79);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(227, 111);
            this.btnCompany.TabIndex = 7;
            this.btnCompany.Text = "Company Profile";
            this.btnCompany.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCompany.UseVisualStyleBackColor = false;
            // 
            // btnBatchProcess
            // 
            this.btnBatchProcess.BackColor = System.Drawing.Color.Firebrick;
            this.btnBatchProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBatchProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchProcess.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchProcess.ForeColor = System.Drawing.Color.White;
            this.btnBatchProcess.Image = global::CMS.Properties.Resources.BatchProcess;
            this.btnBatchProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBatchProcess.Location = new System.Drawing.Point(140, 79);
            this.btnBatchProcess.Name = "btnBatchProcess";
            this.btnBatchProcess.Size = new System.Drawing.Size(227, 111);
            this.btnBatchProcess.TabIndex = 6;
            this.btnBatchProcess.Text = "Batch Process Automation";
            this.btnBatchProcess.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBatchProcess.UseVisualStyleBackColor = false;
            this.btnBatchProcess.Click += new System.EventHandler(this.btnBatchProcess_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(691, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 32);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupUtilities);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Utilities";
            this.Size = new System.Drawing.Size(1000, 530);
            this.groupUtilities.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupUtilities;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnBatchProcess;
        private System.Windows.Forms.Button btnClose;

    }
}
