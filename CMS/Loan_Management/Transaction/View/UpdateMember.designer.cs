namespace CMS.Loan_Management.Transaction.View
{
    partial class UpdateMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMember));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.radioMemberName = new System.Windows.Forms.RadioButton();
            this.radioAccountNo = new System.Windows.Forms.RadioButton();
            this.dataMember = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtAccountNo);
            this.groupBox4.Controls.Add(this.txtMemberName);
            this.groupBox4.Controls.Add(this.radioMemberName);
            this.groupBox4.Controls.Add(this.radioAccountNo);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(12, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(680, 93);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Member:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAccountNo.Location = new System.Drawing.Point(237, 23);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(321, 25);
            this.txtAccountNo.TabIndex = 5;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMemberName.Location = new System.Drawing.Point(237, 54);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(321, 25);
            this.txtMemberName.TabIndex = 7;
            // 
            // radioMemberName
            // 
            this.radioMemberName.AutoSize = true;
            this.radioMemberName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radioMemberName.Location = new System.Drawing.Point(104, 55);
            this.radioMemberName.Name = "radioMemberName";
            this.radioMemberName.Size = new System.Drawing.Size(118, 21);
            this.radioMemberName.TabIndex = 6;
            this.radioMemberName.TabStop = true;
            this.radioMemberName.Text = "Member Name:";
            this.radioMemberName.UseVisualStyleBackColor = true;
            this.radioMemberName.CheckedChanged += new System.EventHandler(this.radioMemberName_CheckedChanged);
            // 
            // radioAccountNo
            // 
            this.radioAccountNo.AutoSize = true;
            this.radioAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radioAccountNo.Location = new System.Drawing.Point(104, 24);
            this.radioAccountNo.Name = "radioAccountNo";
            this.radioAccountNo.Size = new System.Drawing.Size(127, 21);
            this.radioAccountNo.TabIndex = 4;
            this.radioAccountNo.TabStop = true;
            this.radioAccountNo.Text = "Account Number:";
            this.radioAccountNo.UseVisualStyleBackColor = true;
            this.radioAccountNo.CheckedChanged += new System.EventHandler(this.radioAccountNo_CheckedChanged);
            // 
            // dataMember
            // 
            this.dataMember.AllowUserToAddRows = false;
            this.dataMember.AllowUserToDeleteRows = false;
            this.dataMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMember.BackgroundColor = System.Drawing.Color.Silver;
            this.dataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMember.Location = new System.Drawing.Point(12, 152);
            this.dataMember.Name = "dataMember";
            this.dataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMember.Size = new System.Drawing.Size(680, 292);
            this.dataMember.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(538, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 32);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Selected...";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(590, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New...";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member Profile";
            // 
            // UpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(704, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataMember);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 528);
            this.Name = "UpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Profile";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.RadioButton radioMemberName;
        private System.Windows.Forms.RadioButton radioAccountNo;
        private System.Windows.Forms.DataGridView dataMember;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}