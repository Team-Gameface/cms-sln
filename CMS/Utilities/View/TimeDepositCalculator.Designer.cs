namespace CMS.Utilities.View
{
    partial class TimeDepositCalculator
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.groupBreakdown = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepAmt = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.comboDuration = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBreakdown.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.Green;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(106, 97);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(92, 32);
            this.btnCompute.TabIndex = 7;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            // 
            // groupBreakdown
            // 
            this.groupBreakdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBreakdown.Controls.Add(this.lblTotal);
            this.groupBreakdown.Controls.Add(this.txtTotal);
            this.groupBreakdown.Controls.Add(this.label5);
            this.groupBreakdown.Controls.Add(this.label6);
            this.groupBreakdown.Controls.Add(this.txtDepAmt);
            this.groupBreakdown.Controls.Add(this.txtInterest);
            this.groupBreakdown.Controls.Add(this.label23);
            this.groupBreakdown.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.groupBreakdown.Location = new System.Drawing.Point(8, 197);
            this.groupBreakdown.Name = "groupBreakdown";
            this.groupBreakdown.Size = new System.Drawing.Size(340, 140);
            this.groupBreakdown.TabIndex = 9;
            this.groupBreakdown.TabStop = false;
            this.groupBreakdown.Text = "Maturity Details:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(12, 104);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 20);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total Amount:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(128, 99);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(194, 28);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(57, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "add: Interest Earned:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(51, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Principal Amount:";
            // 
            // txtDepAmt
            // 
            this.txtDepAmt.Enabled = false;
            this.txtDepAmt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDepAmt.Location = new System.Drawing.Point(162, 24);
            this.txtDepAmt.Name = "txtDepAmt";
            this.txtDepAmt.ReadOnly = true;
            this.txtDepAmt.Size = new System.Drawing.Size(160, 25);
            this.txtDepAmt.TabIndex = 11;
            this.txtDepAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterest
            // 
            this.txtInterest.Enabled = false;
            this.txtInterest.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtInterest.Location = new System.Drawing.Point(201, 55);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.ReadOnly = true;
            this.txtInterest.Size = new System.Drawing.Size(121, 25);
            this.txtInterest.TabIndex = 13;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 30.75F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(5, 37);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(330, 55);
            this.label23.TabIndex = 14;
            this.label23.Text = "__________________";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.lblDuration);
            this.groupBox1.Controls.Add(this.numDuration);
            this.groupBox1.Controls.Add(this.comboDuration);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(24, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Deposit Details:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(204, 97);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deposit Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAmount.Location = new System.Drawing.Point(120, 24);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(181, 25);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDuration.Location = new System.Drawing.Point(12, 60);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(102, 17);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Terms/Duration:";
            // 
            // numDuration
            // 
            this.numDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numDuration.Location = new System.Drawing.Point(120, 57);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(69, 25);
            this.numDuration.TabIndex = 5;
            this.numDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboDuration
            // 
            this.comboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboDuration.FormattingEnabled = true;
            this.comboDuration.Items.AddRange(new object[] {
            "Day/s",
            "Month/s",
            "Year/s"});
            this.comboDuration.Location = new System.Drawing.Point(195, 57);
            this.comboDuration.Name = "comboDuration";
            this.comboDuration.Size = new System.Drawing.Size(106, 25);
            this.comboDuration.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(52, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time Deposit Calculator";
            // 
            // TimeDepositCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 346);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBreakdown);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(370, 385);
            this.Name = "TimeDepositCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Deposit Calculator";
            this.groupBreakdown.ResumeLayout(false);
            this.groupBreakdown.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.GroupBox groupBreakdown;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepAmt;
        private System.Windows.Forms.TextBox txtInterest;
        public System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.ComboBox comboDuration;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
    }
}