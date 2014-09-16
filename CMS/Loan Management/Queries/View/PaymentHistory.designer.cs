namespace CMS.Loan_Management.Reports
{
    partial class PaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentHistory));
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAccountNo = new System.Windows.Forms.TextBox();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.rbAcctName = new System.Windows.Forms.RadioButton();
            this.rbAcctNo = new System.Windows.Forms.RadioButton();
            this.dataGridShare = new System.Windows.Forms.DataGridView();
            this.btnPreview = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShare)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Filter by loan:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 343);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(453, 25);
            this.comboBox1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Reports - Payment History";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbAccountNo);
            this.groupBox4.Controls.Add(this.tbAccountName);
            this.groupBox4.Controls.Add(this.rbAcctName);
            this.groupBox4.Controls.Add(this.rbAcctNo);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(9, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(674, 93);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Member:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(45, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search by:";
            // 
            // tbAccountNo
            // 
            this.tbAccountNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAccountNo.Enabled = false;
            this.tbAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbAccountNo.Location = new System.Drawing.Point(252, 26);
            this.tbAccountNo.Name = "tbAccountNo";
            this.tbAccountNo.Size = new System.Drawing.Size(321, 25);
            this.tbAccountNo.TabIndex = 4;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAccountName.Enabled = false;
            this.tbAccountName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbAccountName.Location = new System.Drawing.Point(252, 57);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(321, 25);
            this.tbAccountName.TabIndex = 6;
            // 
            // rbAcctName
            // 
            this.rbAcctName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAcctName.AutoSize = true;
            this.rbAcctName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbAcctName.Location = new System.Drawing.Point(119, 58);
            this.rbAcctName.Name = "rbAcctName";
            this.rbAcctName.Size = new System.Drawing.Size(118, 21);
            this.rbAcctName.TabIndex = 5;
            this.rbAcctName.TabStop = true;
            this.rbAcctName.Text = "Member Name:";
            this.rbAcctName.UseVisualStyleBackColor = true;
            // 
            // rbAcctNo
            // 
            this.rbAcctNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAcctNo.AutoSize = true;
            this.rbAcctNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbAcctNo.Location = new System.Drawing.Point(119, 27);
            this.rbAcctNo.Name = "rbAcctNo";
            this.rbAcctNo.Size = new System.Drawing.Size(127, 21);
            this.rbAcctNo.TabIndex = 3;
            this.rbAcctNo.TabStop = true;
            this.rbAcctNo.Text = "Account Number:";
            this.rbAcctNo.UseVisualStyleBackColor = true;
            // 
            // dataGridShare
            // 
            this.dataGridShare.AllowUserToAddRows = false;
            this.dataGridShare.AllowUserToDeleteRows = false;
            this.dataGridShare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridShare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridShare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShare.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridShare.Location = new System.Drawing.Point(9, 147);
            this.dataGridShare.Name = "dataGridShare";
            this.dataGridShare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridShare.Size = new System.Drawing.Size(674, 181);
            this.dataGridShare.TabIndex = 38;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreview.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(591, 385);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 32);
            this.btnPreview.TabIndex = 39;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkBox1.Location = new System.Drawing.Point(595, 345);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 21);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "All loans";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(692, 424);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridShare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentHistory";
            this.Text = "Payment History";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAccountNo;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.RadioButton rbAcctName;
        private System.Windows.Forms.RadioButton rbAcctNo;
        private System.Windows.Forms.DataGridView dataGridShare;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}