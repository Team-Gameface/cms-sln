namespace CMS.Savings.Transaction.View
{
    partial class TerminationPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminationPayment));
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLoanBalance = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTermination = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(20, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Payment Amount";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Loan Balance";
            // 
            // txtLoanBalance
            // 
            this.txtLoanBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoanBalance.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLoanBalance.Location = new System.Drawing.Point(159, 144);
            this.txtLoanBalance.Name = "txtLoanBalance";
            this.txtLoanBalance.ReadOnly = true;
            this.txtLoanBalance.Size = new System.Drawing.Size(173, 29);
            this.txtLoanBalance.TabIndex = 7;
            this.txtLoanBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPayment.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPayment.Location = new System.Drawing.Point(159, 179);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(173, 29);
            this.txtPayment.TabIndex = 9;
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(155, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 21);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // dateTermination
            // 
            this.dateTermination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTermination.Enabled = false;
            this.dateTermination.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTermination.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTermination.Location = new System.Drawing.Point(213, 60);
            this.dateTermination.Name = "dateTermination";
            this.dateTermination.Size = new System.Drawing.Size(119, 29);
            this.dateTermination.TabIndex = 3;
            this.dateTermination.Value = new System.DateTime(2014, 7, 27, 21, 2, 34, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account No";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccountNo.Location = new System.Drawing.Point(159, 109);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.ReadOnly = true;
            this.txtAccountNo.Size = new System.Drawing.Size(173, 29);
            this.txtAccountNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 45);
            this.label5.TabIndex = 1;
            this.label5.Text = "Balance Clearance";
            // 
            // btnProceed
            // 
            this.btnProceed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProceed.BackColor = System.Drawing.Color.Green;
            this.btnProceed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Image = global::CMS.Properties.Resources.Proceed;
            this.btnProceed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceed.Location = new System.Drawing.Point(59, 224);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(110, 35);
            this.btnProceed.TabIndex = 10;
            this.btnProceed.Text = "&Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CMS.Properties.Resources.Delete;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(175, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TerminationPayment
            // 
            this.AcceptButton = this.btnProceed;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(344, 281);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTermination);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLoanBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TerminationPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termination Payment";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLoanBalance;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTermination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnCancel;
    }
}