namespace CMS.Savings.Maintenance.View
{
    partial class InterestRates
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterestRates));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkMaximum = new System.Windows.Forms.CheckBox();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.txtMaxBal = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtMinBal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.CheckBox();
            this.lblPer = new System.Windows.Forms.Label();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.comboInterestRate = new System.Windows.Forms.ComboBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.dataInterestRates = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.checkArchived = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInterestRates)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPercent);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.lblPer);
            this.groupBox1.Controls.Add(this.comboAccountType);
            this.groupBox1.Controls.Add(this.comboInterestRate);
            this.groupBox1.Controls.Add(this.lblAccountType);
            this.groupBox1.Controls.Add(this.txtInterestRate);
            this.groupBox1.Controls.Add(this.lblInterestRate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 175);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Interest Rate";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(580, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(486, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkMaximum);
            this.groupBox2.Controls.Add(this.lblMinimum);
            this.groupBox2.Controls.Add(this.txtMaxBal);
            this.groupBox2.Controls.Add(this.txtMinBal);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(368, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 99);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance Range";
            // 
            // checkMaximum
            // 
            this.checkMaximum.AutoSize = true;
            this.checkMaximum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkMaximum.Location = new System.Drawing.Point(17, 62);
            this.checkMaximum.Name = "checkMaximum";
            this.checkMaximum.Size = new System.Drawing.Size(92, 23);
            this.checkMaximum.TabIndex = 18;
            this.checkMaximum.Text = "Maximum:";
            this.checkMaximum.UseVisualStyleBackColor = true;
            this.checkMaximum.CheckedChanged += new System.EventHandler(this.checkMaximum_CheckedChanged);
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMinimum.Location = new System.Drawing.Point(34, 30);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(71, 19);
            this.lblMinimum.TabIndex = 16;
            this.lblMinimum.Text = "Minimum:";
            // 
            // txtMaxBal
            // 
            this.txtMaxBal.ContextMenuStrip = this.contextMenuBlank;
            this.txtMaxBal.Enabled = false;
            this.txtMaxBal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaxBal.Location = new System.Drawing.Point(128, 60);
            this.txtMaxBal.MaxLength = 25;
            this.txtMaxBal.Name = "txtMaxBal";
            this.txtMaxBal.Size = new System.Drawing.Size(161, 25);
            this.txtMaxBal.TabIndex = 19;
            this.txtMaxBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxBal.TextChanged += new System.EventHandler(this.txtMaxBal_TextChanged);
            this.txtMaxBal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxBal_KeyDown);
            this.txtMaxBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxBal_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // txtMinBal
            // 
            this.txtMinBal.ContextMenuStrip = this.contextMenuBlank;
            this.txtMinBal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMinBal.Location = new System.Drawing.Point(128, 27);
            this.txtMinBal.MaxLength = 25;
            this.txtMinBal.Name = "txtMinBal";
            this.txtMinBal.Size = new System.Drawing.Size(161, 25);
            this.txtMinBal.TabIndex = 17;
            this.txtMinBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinBal.TextChanged += new System.EventHandler(this.txtMinBal_TextChanged);
            this.txtMinBal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinBal_KeyDown);
            this.txtMinBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinBal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(21, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Status:";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPercent.Location = new System.Drawing.Point(214, 67);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(20, 19);
            this.lblPercent.TabIndex = 12;
            this.lblPercent.Text = "%";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Status.Location = new System.Drawing.Point(88, 142);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(65, 23);
            this.Status.TabIndex = 21;
            this.Status.Text = "Active";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPer.Location = new System.Drawing.Point(114, 98);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(29, 19);
            this.lblPer.TabIndex = 13;
            this.lblPer.Text = "per";
            // 
            // comboAccountType
            // 
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAccountType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Items.AddRange(new object[] {
            "ALL"});
            this.comboAccountType.Location = new System.Drawing.Point(116, 27);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(205, 25);
            this.comboAccountType.TabIndex = 9;
            // 
            // comboInterestRate
            // 
            this.comboInterestRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInterestRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboInterestRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboInterestRate.FormattingEnabled = true;
            this.comboInterestRate.Items.AddRange(new object[] {
            "Monthly",
            "Semi-Annually",
            "Bi-Annually",
            "Annually"});
            this.comboInterestRate.Location = new System.Drawing.Point(149, 95);
            this.comboInterestRate.Name = "comboInterestRate";
            this.comboInterestRate.Size = new System.Drawing.Size(134, 25);
            this.comboInterestRate.TabIndex = 14;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccountType.Location = new System.Drawing.Point(8, 30);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(95, 19);
            this.lblAccountType.TabIndex = 8;
            this.lblAccountType.Text = "Account Type:";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.ContextMenuStrip = this.contextMenuBlank;
            this.txtInterestRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInterestRate.Location = new System.Drawing.Point(118, 64);
            this.txtInterestRate.MaxLength = 7;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(92, 25);
            this.txtInterestRate.TabIndex = 11;
            this.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInterestRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInterestRate_KeyDown);
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestRate_KeyPress);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInterestRate.Location = new System.Drawing.Point(10, 67);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(90, 19);
            this.lblInterestRate.TabIndex = 10;
            this.lblInterestRate.Text = "Interest Rate:";
            // 
            // dataInterestRates
            // 
            this.dataInterestRates.AllowUserToAddRows = false;
            this.dataInterestRates.AllowUserToDeleteRows = false;
            this.dataInterestRates.AllowUserToResizeRows = false;
            this.dataInterestRates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataInterestRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataInterestRates.BackgroundColor = System.Drawing.Color.Silver;
            this.dataInterestRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInterestRates.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataInterestRates.Location = new System.Drawing.Point(12, 71);
            this.dataInterestRates.MultiSelect = false;
            this.dataInterestRates.Name = "dataInterestRates";
            this.dataInterestRates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInterestRates.Size = new System.Drawing.Size(680, 171);
            this.dataInterestRates.TabIndex = 3;
            this.dataInterestRates.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataInterestRates_CellFormatting);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Maintenance - Interest Rates";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(9, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(206, 19);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search by Savings Account type:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(226, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(466, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // checkArchived
            // 
            this.checkArchived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkArchived.AutoSize = true;
            this.checkArchived.BackColor = System.Drawing.Color.Yellow;
            this.checkArchived.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkArchived.Location = new System.Drawing.Point(13, 248);
            this.checkArchived.Name = "checkArchived";
            this.checkArchived.Size = new System.Drawing.Size(127, 24);
            this.checkArchived.TabIndex = 4;
            this.checkArchived.Text = "Show Archives";
            this.checkArchived.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(504, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(602, 248);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // InterestRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.checkArchived);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataInterestRates);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "InterestRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Rates";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInterestRates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.ComboBox comboInterestRate;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.DataGridView dataInterestRates;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox checkArchived;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkMaximum;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.TextBox txtMaxBal;
        private System.Windows.Forms.TextBox txtMinBal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}