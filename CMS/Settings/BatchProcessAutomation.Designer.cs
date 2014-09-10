namespace CMS.Settings
{
    partial class BatchProcessAutomation
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
            this.timeInterest = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.timeMainBal = new System.Windows.Forms.DateTimePicker();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.timeDormant = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeInterest
            // 
            this.timeInterest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeInterest.CustomFormat = "h:mm tt";
            this.timeInterest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInterest.Location = new System.Drawing.Point(193, 119);
            this.timeInterest.Name = "timeInterest";
            this.timeInterest.ShowUpDown = true;
            this.timeInterest.Size = new System.Drawing.Size(91, 25);
            this.timeInterest.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(8, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Check Savings Interest";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(199, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timeMainBal
            // 
            this.timeMainBal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeMainBal.CustomFormat = "h:mm tt";
            this.timeMainBal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeMainBal.Location = new System.Drawing.Point(193, 88);
            this.timeMainBal.Name = "timeMainBal";
            this.timeMainBal.ShowUpDown = true;
            this.timeMainBal.Size = new System.Drawing.Size(91, 25);
            this.timeMainBal.TabIndex = 12;
            // 
            // lblAccountType
            // 
            this.lblAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccountType.Location = new System.Drawing.Point(8, 60);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(165, 19);
            this.lblAccountType.TabIndex = 9;
            this.lblAccountType.Text = "Check Dormant Accounts";
            // 
            // timeDormant
            // 
            this.timeDormant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeDormant.CustomFormat = "h:mm tt";
            this.timeDormant.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeDormant.Location = new System.Drawing.Point(193, 57);
            this.timeDormant.Name = "timeDormant";
            this.timeDormant.ShowUpDown = true;
            this.timeDormant.Size = new System.Drawing.Size(91, 25);
            this.timeDormant.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Batch Processing - Automation";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Check Maintaining Balances";
            // 
            // BatchProcessAutomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.timeInterest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.timeMainBal);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.timeDormant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BatchProcessAutomation";
            this.Size = new System.Drawing.Size(294, 185);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timeInterest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker timeMainBal;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.DateTimePicker timeDormant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}
