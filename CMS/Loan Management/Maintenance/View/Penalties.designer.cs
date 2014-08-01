namespace CMS.Loan_Management.Maintenance.View
{
    partial class Penalties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penalties));
            this.dataPenalties = new System.Windows.Forms.DataGridView();
            this.gbPenalty = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPenaltyName = new System.Windows.Forms.Label();
            this.cbGrace = new System.Windows.Forms.CheckBox();
            this.cbDeduction = new System.Windows.Forms.ComboBox();
            this.cbDurationStatus = new System.Windows.Forms.ComboBox();
            this.cbAmountStatus = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.durationUD = new System.Windows.Forms.NumericUpDown();
            this.gpUD = new System.Windows.Forms.NumericUpDown();
            this.lblGracePeriod = new System.Windows.Forms.Label();
            this.lblBasis = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPenaltyCharges = new System.Windows.Forms.Label();
            this.clbLoanType = new System.Windows.Forms.CheckedListBox();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbShowArchive = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPenalties)).BeginInit();
            this.gbPenalty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpUD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPenalties
            // 
            this.dataPenalties.AllowUserToAddRows = false;
            this.dataPenalties.AllowUserToDeleteRows = false;
            this.dataPenalties.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataPenalties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataPenalties.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataPenalties.BackgroundColor = System.Drawing.Color.Silver;
            this.dataPenalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPenalties.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataPenalties.Location = new System.Drawing.Point(13, 69);
            this.dataPenalties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataPenalties.Name = "dataPenalties";
            this.dataPenalties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPenalties.Size = new System.Drawing.Size(678, 161);
            this.dataPenalties.TabIndex = 3;
            this.dataPenalties.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataPenalties_CellFormatting);
            // 
            // gbPenalty
            // 
            this.gbPenalty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPenalty.Controls.Add(this.btnCancel);
            this.gbPenalty.Controls.Add(this.btnRetrieve);
            this.gbPenalty.Controls.Add(this.btnSave);
            this.gbPenalty.Controls.Add(this.lblStatus);
            this.gbPenalty.Controls.Add(this.chbStatus);
            this.gbPenalty.Controls.Add(this.txtName);
            this.gbPenalty.Controls.Add(this.lblPenaltyName);
            this.gbPenalty.Controls.Add(this.cbGrace);
            this.gbPenalty.Controls.Add(this.cbDeduction);
            this.gbPenalty.Controls.Add(this.cbDurationStatus);
            this.gbPenalty.Controls.Add(this.cbAmountStatus);
            this.gbPenalty.Controls.Add(this.txtAmount);
            this.gbPenalty.Controls.Add(this.durationUD);
            this.gbPenalty.Controls.Add(this.gpUD);
            this.gbPenalty.Controls.Add(this.lblGracePeriod);
            this.gbPenalty.Controls.Add(this.lblBasis);
            this.gbPenalty.Controls.Add(this.lblDuration);
            this.gbPenalty.Controls.Add(this.lblAmount);
            this.gbPenalty.Controls.Add(this.lblPenaltyCharges);
            this.gbPenalty.Controls.Add(this.clbLoanType);
            this.gbPenalty.Controls.Add(this.lblLoanType);
            this.gbPenalty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gbPenalty.Location = new System.Drawing.Point(15, 272);
            this.gbPenalty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPenalty.Name = "gbPenalty";
            this.gbPenalty.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPenalty.Size = new System.Drawing.Size(682, 235);
            this.gbPenalty.TabIndex = 8;
            this.gbPenalty.TabStop = false;
            this.gbPenalty.Text = "Add/Edit Penalty";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(581, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRetrieve.Location = new System.Drawing.Point(141, 198);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(92, 32);
            this.btnRetrieve.TabIndex = 27;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(481, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStatus.Location = new System.Drawing.Point(10, 206);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Status:";
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chbStatus.Location = new System.Drawing.Point(64, 205);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(61, 21);
            this.chbStatus.TabIndex = 26;
            this.chbStatus.Text = "Active";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtName.Location = new System.Drawing.Point(135, 26);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 25);
            this.txtName.TabIndex = 10;
            // 
            // lblPenaltyName
            // 
            this.lblPenaltyName.AutoSize = true;
            this.lblPenaltyName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPenaltyName.Location = new System.Drawing.Point(9, 29);
            this.lblPenaltyName.Name = "lblPenaltyName";
            this.lblPenaltyName.Size = new System.Drawing.Size(91, 17);
            this.lblPenaltyName.TabIndex = 9;
            this.lblPenaltyName.Text = "Penalty Name:";
            // 
            // cbGrace
            // 
            this.cbGrace.AutoSize = true;
            this.cbGrace.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbGrace.Location = new System.Drawing.Point(13, 69);
            this.cbGrace.Name = "cbGrace";
            this.cbGrace.Size = new System.Drawing.Size(106, 21);
            this.cbGrace.TabIndex = 11;
            this.cbGrace.Text = "Grace Period:";
            this.cbGrace.UseVisualStyleBackColor = true;
            this.cbGrace.CheckedChanged += new System.EventHandler(this.cbGrace_CheckedChanged);
            // 
            // cbDeduction
            // 
            this.cbDeduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDeduction.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbDeduction.FormattingEnabled = true;
            this.cbDeduction.Items.AddRange(new object[] {
            "monthly amortization",
            "remaining balance",
            "granted loan amount"});
            this.cbDeduction.Location = new System.Drawing.Point(268, 121);
            this.cbDeduction.Name = "cbDeduction";
            this.cbDeduction.Size = new System.Drawing.Size(142, 25);
            this.cbDeduction.TabIndex = 19;
            // 
            // cbDurationStatus
            // 
            this.cbDurationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurationStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDurationStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbDurationStatus.FormattingEnabled = true;
            this.cbDurationStatus.Items.AddRange(new object[] {
            "day/s",
            "week/s",
            "month/s"});
            this.cbDurationStatus.Location = new System.Drawing.Point(268, 154);
            this.cbDurationStatus.Name = "cbDurationStatus";
            this.cbDurationStatus.Size = new System.Drawing.Size(142, 25);
            this.cbDurationStatus.TabIndex = 22;
            // 
            // cbAmountStatus
            // 
            this.cbAmountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmountStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAmountStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbAmountStatus.FormattingEnabled = true;
            this.cbAmountStatus.Items.AddRange(new object[] {
            "%",
            "Php"});
            this.cbAmountStatus.Location = new System.Drawing.Point(155, 121);
            this.cbAmountStatus.Name = "cbAmountStatus";
            this.cbAmountStatus.Size = new System.Drawing.Size(78, 25);
            this.cbAmountStatus.TabIndex = 17;
            this.cbAmountStatus.SelectedIndexChanged += new System.EventHandler(this.cbAmountStatus_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.ContextMenuStrip = this.contextMenuBlank;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAmount.Location = new System.Drawing.Point(80, 121);
            this.txtAmount.MaxLength = 8;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(69, 25);
            this.txtAmount.TabIndex = 16;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown_1);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress_1);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // durationUD
            // 
            this.durationUD.ContextMenuStrip = this.contextMenuBlank;
            this.durationUD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.durationUD.Location = new System.Drawing.Point(206, 155);
            this.durationUD.Name = "durationUD";
            this.durationUD.Size = new System.Drawing.Size(56, 25);
            this.durationUD.TabIndex = 21;
            this.durationUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.durationUD_KeyDown_1);
            this.durationUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.durationUD_KeyPress_1);
            // 
            // gpUD
            // 
            this.gpUD.ContextMenuStrip = this.contextMenuBlank;
            this.gpUD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gpUD.Location = new System.Drawing.Point(135, 68);
            this.gpUD.Name = "gpUD";
            this.gpUD.Size = new System.Drawing.Size(61, 25);
            this.gpUD.TabIndex = 12;
            this.gpUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gpUD_KeyDown_1);
            this.gpUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gpUD_KeyPress_1);
            // 
            // lblGracePeriod
            // 
            this.lblGracePeriod.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblGracePeriod.Location = new System.Drawing.Point(202, 74);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.Size = new System.Drawing.Size(202, 23);
            this.lblGracePeriod.TabIndex = 13;
            this.lblGracePeriod.Text = "days after amortization due date";
            // 
            // lblBasis
            // 
            this.lblBasis.AutoSize = true;
            this.lblBasis.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBasis.Location = new System.Drawing.Point(239, 124);
            this.lblBasis.Name = "lblBasis";
            this.lblBasis.Size = new System.Drawing.Size(20, 17);
            this.lblBasis.TabIndex = 18;
            this.lblBasis.Text = "of";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDuration.Location = new System.Drawing.Point(15, 157);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(126, 17);
            this.lblDuration.TabIndex = 20;
            this.lblDuration.Text = "to be charged every";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAmount.Location = new System.Drawing.Point(9, 124);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "Amount:";
            // 
            // lblPenaltyCharges
            // 
            this.lblPenaltyCharges.AutoSize = true;
            this.lblPenaltyCharges.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPenaltyCharges.Location = new System.Drawing.Point(9, 98);
            this.lblPenaltyCharges.Name = "lblPenaltyCharges";
            this.lblPenaltyCharges.Size = new System.Drawing.Size(104, 17);
            this.lblPenaltyCharges.TabIndex = 14;
            this.lblPenaltyCharges.Text = "Penalty Charges:";
            // 
            // clbLoanType
            // 
            this.clbLoanType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.clbLoanType.FormattingEnabled = true;
            this.clbLoanType.Location = new System.Drawing.Point(417, 43);
            this.clbLoanType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbLoanType.Name = "clbLoanType";
            this.clbLoanType.Size = new System.Drawing.Size(256, 144);
            this.clbLoanType.TabIndex = 24;
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLoanType.Location = new System.Drawing.Point(414, 21);
            this.lblLoanType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(95, 17);
            this.lblLoanType.TabIndex = 23;
            this.lblLoanType.Text = "Applicable for:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance - Loan Penalties";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search for penalties:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(145, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(543, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // cbShowArchive
            // 
            this.cbShowArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShowArchive.AutoSize = true;
            this.cbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.cbShowArchive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbShowArchive.Location = new System.Drawing.Point(15, 246);
            this.cbShowArchive.Name = "cbShowArchive";
            this.cbShowArchive.Size = new System.Drawing.Size(127, 24);
            this.cbShowArchive.TabIndex = 4;
            this.cbShowArchive.Text = "Show Archives";
            this.cbShowArchive.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(599, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(403, 240);
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
            this.btnEdit.Location = new System.Drawing.Point(501, 240);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // Penalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(704, 521);
            this.Controls.Add(this.cbShowArchive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPenalty);
            this.Controls.Add(this.dataPenalties);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 560);
            this.Name = "Penalties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Penalties";
            ((System.ComponentModel.ISupportInitialize)(this.dataPenalties)).EndInit();
            this.gbPenalty.ResumeLayout(false);
            this.gbPenalty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPenalty;
        private System.Windows.Forms.CheckedListBox clbLoanType;
        private System.Windows.Forms.ComboBox cbDeduction;
        private System.Windows.Forms.ComboBox cbDurationStatus;
        private System.Windows.Forms.ComboBox cbAmountStatus;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.NumericUpDown durationUD;
        private System.Windows.Forms.NumericUpDown gpUD;
        private System.Windows.Forms.Label lblPenaltyCharges;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chbStatus;
        public System.Windows.Forms.DataGridView dataPenalties;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        public System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.Label lblDuration;
        public System.Windows.Forms.Label lblBasis;
        public System.Windows.Forms.CheckBox cbGrace;
        public System.Windows.Forms.Label lblPenaltyName;
        public System.Windows.Forms.Label lblGracePeriod;
        public System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox cbShowArchive;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnSave;
    }
}