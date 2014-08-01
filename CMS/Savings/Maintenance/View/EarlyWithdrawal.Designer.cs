namespace CMS.Savings.Maintenance.View
{
    partial class EarlyWithdrawal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EarlyWithdrawal));
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.lblBalDuration = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPenalty = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkMaximum = new System.Windows.Forms.CheckBox();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.txtMaxBal = new System.Windows.Forms.TextBox();
            this.txtMinBal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTimeDeposit = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkArchived = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimeDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // numDuration
            // 
            this.numDuration.ContextMenuStrip = this.contextMenuBlank;
            this.numDuration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numDuration.Location = new System.Drawing.Point(138, 61);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(47, 25);
            this.numDuration.TabIndex = 11;
            this.numDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numDuration_KeyDown);
            this.numDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDuration_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPenalty
            // 
            this.txtPenalty.ContextMenuStrip = this.contextMenuBlank;
            this.txtPenalty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPenalty.Location = new System.Drawing.Point(138, 94);
            this.txtPenalty.MaxLength = 10;
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(116, 25);
            this.txtPenalty.TabIndex = 14;
            this.txtPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPenalty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPenalty_KeyDown);
            this.txtPenalty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenalty_KeyPress);
            // 
            // comboAccountType
            // 
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAccountType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(138, 26);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(218, 25);
            this.comboAccountType.TabIndex = 9;
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPenalty.Location = new System.Drawing.Point(6, 97);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(57, 19);
            this.lblPenalty.TabIndex = 13;
            this.lblPenalty.Text = "Penalty:";
            // 
            // lblBalDuration
            // 
            this.lblBalDuration.AutoSize = true;
            this.lblBalDuration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBalDuration.Location = new System.Drawing.Point(6, 63);
            this.lblBalDuration.Name = "lblBalDuration";
            this.lblBalDuration.Size = new System.Drawing.Size(128, 19);
            this.lblBalDuration.TabIndex = 10;
            this.lblBalDuration.Text = "Duration of Tenure:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccountType.Location = new System.Drawing.Point(6, 29);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(95, 19);
            this.lblAccountType.TabIndex = 8;
            this.lblAccountType.Text = "Account Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboPenalty);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.numDuration);
            this.groupBox1.Controls.Add(this.txtPenalty);
            this.groupBox1.Controls.Add(this.comboAccountType);
            this.groupBox1.Controls.Add(this.lblPenalty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBalDuration);
            this.groupBox1.Controls.Add(this.lblAccountType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Early Withdrawal Penalty";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(584, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(490, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Status.Location = new System.Drawing.Point(99, 140);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(65, 23);
            this.Status.TabIndex = 22;
            this.Status.Text = "Active";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(33, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Status:";
            // 
            // comboPenalty
            // 
            this.comboPenalty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPenalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPenalty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPenalty.FormattingEnabled = true;
            this.comboPenalty.Items.AddRange(new object[] {
            "Php",
            "%"});
            this.comboPenalty.Location = new System.Drawing.Point(260, 94);
            this.comboPenalty.Name = "comboPenalty";
            this.comboPenalty.Size = new System.Drawing.Size(96, 25);
            this.comboPenalty.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkMaximum);
            this.groupBox2.Controls.Add(this.lblMinimum);
            this.groupBox2.Controls.Add(this.txtMaxBal);
            this.groupBox2.Controls.Add(this.txtMinBal);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(368, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 99);
            this.groupBox2.TabIndex = 16;
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
            this.checkMaximum.TabIndex = 19;
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
            this.lblMinimum.TabIndex = 17;
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
            this.txtMaxBal.TabIndex = 20;
            this.txtMaxBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxBal.TextChanged += new System.EventHandler(this.txtMaxBal_TextChanged);
            this.txtMaxBal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxBal_KeyDown);
            this.txtMaxBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxBal_KeyPress);
            // 
            // txtMinBal
            // 
            this.txtMinBal.ContextMenuStrip = this.contextMenuBlank;
            this.txtMinBal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMinBal.Location = new System.Drawing.Point(128, 27);
            this.txtMinBal.MaxLength = 25;
            this.txtMinBal.Name = "txtMinBal";
            this.txtMinBal.Size = new System.Drawing.Size(161, 25);
            this.txtMinBal.TabIndex = 18;
            this.txtMinBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinBal.TextChanged += new System.EventHandler(this.txtMinBal_TextChanged);
            this.txtMinBal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinBal_KeyDown);
            this.txtMinBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinBal_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(191, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "% of terms duration";
            // 
            // dataTimeDeposit
            // 
            this.dataTimeDeposit.AllowUserToAddRows = false;
            this.dataTimeDeposit.AllowUserToDeleteRows = false;
            this.dataTimeDeposit.AllowUserToResizeRows = false;
            this.dataTimeDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataTimeDeposit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTimeDeposit.BackgroundColor = System.Drawing.Color.Silver;
            this.dataTimeDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTimeDeposit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTimeDeposit.Location = new System.Drawing.Point(12, 75);
            this.dataTimeDeposit.MultiSelect = false;
            this.dataTimeDeposit.Name = "dataTimeDeposit";
            this.dataTimeDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTimeDeposit.Size = new System.Drawing.Size(678, 169);
            this.dataTimeDeposit.TabIndex = 3;
            this.dataTimeDeposit.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataTimeDeposit_CellFormatting);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(12, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(206, 19);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search by Savings Account type:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(224, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(466, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Maintenance - Early Withdrawal Penalties";
            // 
            // checkArchived
            // 
            this.checkArchived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkArchived.AutoSize = true;
            this.checkArchived.BackColor = System.Drawing.Color.Yellow;
            this.checkArchived.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkArchived.Location = new System.Drawing.Point(11, 250);
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
            this.btnAdd.Location = new System.Drawing.Point(502, 250);
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
            this.btnEdit.Location = new System.Drawing.Point(600, 250);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // EarlyWithdrawal
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
            this.Controls.Add(this.dataTimeDeposit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "EarlyWithdrawal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Early Withdrawal Penalties";
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimeDeposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label lblBalDuration;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkMaximum;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.TextBox txtMaxBal;
        private System.Windows.Forms.TextBox txtMinBal;
        private System.Windows.Forms.DataGridView dataTimeDeposit;
        private System.Windows.Forms.ComboBox comboPenalty;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkArchived;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}