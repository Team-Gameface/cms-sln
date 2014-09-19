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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penalties));
            this.dataPenalties = new System.Windows.Forms.DataGridView();
            this.gbPenalty = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPenaltyName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbGrace = new System.Windows.Forms.CheckBox();
            this.cbDeduction = new System.Windows.Forms.ComboBox();
            this.cbDurationStatus = new System.Windows.Forms.ComboBox();
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
            this.cbAmountStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbShowArchive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.dataPenalties.AllowUserToOrderColumns = true;
            this.dataPenalties.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataPenalties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPenalties.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPenalties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPenalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPenalties.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataPenalties.Location = new System.Drawing.Point(17, 98);
            this.dataPenalties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataPenalties.Name = "dataPenalties";
            this.dataPenalties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPenalties.Size = new System.Drawing.Size(726, 188);
            this.dataPenalties.TabIndex = 4;
            this.dataPenalties.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataPenalties_CellFormatting);
            // 
            // gbPenalty
            // 
            this.gbPenalty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPenalty.Controls.Add(this.lblStatus);
            this.gbPenalty.Controls.Add(this.chbStatus);
            this.gbPenalty.Controls.Add(this.txtName);
            this.gbPenalty.Controls.Add(this.btnRetrieve);
            this.gbPenalty.Controls.Add(this.btnSave);
            this.gbPenalty.Controls.Add(this.lblPenaltyName);
            this.gbPenalty.Controls.Add(this.btnCancel);
            this.gbPenalty.Controls.Add(this.cbGrace);
            this.gbPenalty.Controls.Add(this.cbDeduction);
            this.gbPenalty.Controls.Add(this.cbDurationStatus);
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
            this.gbPenalty.Controls.Add(this.cbAmountStatus);
            this.gbPenalty.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPenalty.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbPenalty.Location = new System.Drawing.Point(13, 337);
            this.gbPenalty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPenalty.Name = "gbPenalty";
            this.gbPenalty.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPenalty.Size = new System.Drawing.Size(730, 253);
            this.gbPenalty.TabIndex = 9;
            this.gbPenalty.TabStop = false;
            this.gbPenalty.Text = "Add/Edit Penalty";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(8, 217);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 21);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status";
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbStatus.Location = new System.Drawing.Point(68, 215);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(67, 25);
            this.chbStatus.TabIndex = 27;
            this.chbStatus.Text = "Active";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(141, 33);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 29);
            this.txtName.TabIndex = 11;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.ForeColor = System.Drawing.Color.White;
            this.btnRetrieve.Image = global::CMS.Properties.Resources.Retrieve;
            this.btnRetrieve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetrieve.Location = new System.Drawing.Point(144, 210);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(110, 35);
            this.btnRetrieve.TabIndex = 28;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CMS.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(517, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblPenaltyName
            // 
            this.lblPenaltyName.AutoSize = true;
            this.lblPenaltyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenaltyName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPenaltyName.Location = new System.Drawing.Point(15, 36);
            this.lblPenaltyName.Name = "lblPenaltyName";
            this.lblPenaltyName.Size = new System.Drawing.Size(107, 21);
            this.lblPenaltyName.TabIndex = 10;
            this.lblPenaltyName.Text = "Penalty Name";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CMS.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(623, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cbGrace
            // 
            this.cbGrace.AutoSize = true;
            this.cbGrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGrace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbGrace.Location = new System.Drawing.Point(19, 68);
            this.cbGrace.Name = "cbGrace";
            this.cbGrace.Size = new System.Drawing.Size(115, 25);
            this.cbGrace.TabIndex = 12;
            this.cbGrace.Text = "Grace Period";
            this.cbGrace.UseVisualStyleBackColor = true;
            this.cbGrace.CheckedChanged += new System.EventHandler(this.cbGrace_CheckedChanged);
            // 
            // cbDeduction
            // 
            this.cbDeduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDeduction.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeduction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbDeduction.FormattingEnabled = true;
            this.cbDeduction.Items.AddRange(new object[] {
            "monthly amortization",
            "remaining balance",
            "granted loan amount"});
            this.cbDeduction.Location = new System.Drawing.Point(305, 128);
            this.cbDeduction.Name = "cbDeduction";
            this.cbDeduction.Size = new System.Drawing.Size(149, 29);
            this.cbDeduction.TabIndex = 20;
            // 
            // cbDurationStatus
            // 
            this.cbDurationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurationStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDurationStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDurationStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbDurationStatus.FormattingEnabled = true;
            this.cbDurationStatus.Items.AddRange(new object[] {
            "day/s",
            "week/s",
            "month/s"});
            this.cbDurationStatus.Location = new System.Drawing.Point(305, 163);
            this.cbDurationStatus.Name = "cbDurationStatus";
            this.cbDurationStatus.Size = new System.Drawing.Size(149, 29);
            this.cbDurationStatus.TabIndex = 23;
            // 
            // txtAmount
            // 
            this.txtAmount.ContextMenuStrip = this.contextMenuBlank;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAmount.Location = new System.Drawing.Point(95, 127);
            this.txtAmount.MaxLength = 8;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(90, 29);
            this.txtAmount.TabIndex = 17;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.durationUD.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationUD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.durationUD.Location = new System.Drawing.Point(243, 162);
            this.durationUD.Name = "durationUD";
            this.durationUD.Size = new System.Drawing.Size(56, 29);
            this.durationUD.TabIndex = 22;
            this.durationUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.durationUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.durationUD_KeyDown_1);
            this.durationUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.durationUD_KeyPress_1);
            // 
            // gpUD
            // 
            this.gpUD.ContextMenuStrip = this.contextMenuBlank;
            this.gpUD.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpUD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpUD.Location = new System.Drawing.Point(141, 68);
            this.gpUD.Name = "gpUD";
            this.gpUD.Size = new System.Drawing.Size(61, 29);
            this.gpUD.TabIndex = 13;
            this.gpUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gpUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gpUD_KeyDown_1);
            this.gpUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gpUD_KeyPress_1);
            // 
            // lblGracePeriod
            // 
            this.lblGracePeriod.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGracePeriod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGracePeriod.Location = new System.Drawing.Point(208, 70);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.Size = new System.Drawing.Size(202, 23);
            this.lblGracePeriod.TabIndex = 14;
            this.lblGracePeriod.Text = "days after amortization due date";
            // 
            // lblBasis
            // 
            this.lblBasis.AutoSize = true;
            this.lblBasis.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBasis.Location = new System.Drawing.Point(275, 131);
            this.lblBasis.Name = "lblBasis";
            this.lblBasis.Size = new System.Drawing.Size(24, 21);
            this.lblBasis.TabIndex = 19;
            this.lblBasis.Text = "of";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDuration.Location = new System.Drawing.Point(93, 166);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(144, 21);
            this.lblDuration.TabIndex = 21;
            this.lblDuration.Text = "to be charged every";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAmount.Location = new System.Drawing.Point(20, 131);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 21);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "Amount";
            // 
            // lblPenaltyCharges
            // 
            this.lblPenaltyCharges.AutoSize = true;
            this.lblPenaltyCharges.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenaltyCharges.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPenaltyCharges.Location = new System.Drawing.Point(15, 103);
            this.lblPenaltyCharges.Name = "lblPenaltyCharges";
            this.lblPenaltyCharges.Size = new System.Drawing.Size(125, 21);
            this.lblPenaltyCharges.TabIndex = 15;
            this.lblPenaltyCharges.Text = "Penalty Charges";
            // 
            // clbLoanType
            // 
            this.clbLoanType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbLoanType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clbLoanType.FormattingEnabled = true;
            this.clbLoanType.Location = new System.Drawing.Point(461, 57);
            this.clbLoanType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbLoanType.Name = "clbLoanType";
            this.clbLoanType.Size = new System.Drawing.Size(256, 124);
            this.clbLoanType.TabIndex = 25;
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanType.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblLoanType.Location = new System.Drawing.Point(472, 31);
            this.lblLoanType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(114, 21);
            this.lblLoanType.TabIndex = 24;
            this.lblLoanType.Text = "Applicable for";
            // 
            // cbAmountStatus
            // 
            this.cbAmountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmountStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAmountStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmountStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbAmountStatus.FormattingEnabled = true;
            this.cbAmountStatus.Items.AddRange(new object[] {
            "%",
            "Php"});
            this.cbAmountStatus.Location = new System.Drawing.Point(191, 128);
            this.cbAmountStatus.Name = "cbAmountStatus";
            this.cbAmountStatus.Size = new System.Drawing.Size(78, 29);
            this.cbAmountStatus.TabIndex = 18;
            this.cbAmountStatus.SelectedIndexChanged += new System.EventHandler(this.cbAmountStatus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Search for penalties:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(193, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(543, 29);
            this.txtSearch.TabIndex = 3;
            // 
            // cbShowArchive
            // 
            this.cbShowArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShowArchive.AutoSize = true;
            this.cbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.cbShowArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowArchive.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowArchive.Location = new System.Drawing.Point(25, 299);
            this.cbShowArchive.Name = "cbShowArchive";
            this.cbShowArchive.Size = new System.Drawing.Size(123, 25);
            this.cbShowArchive.TabIndex = 5;
            this.cbShowArchive.Text = "Show Archives";
            this.cbShowArchive.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maintenance - Loan Penalties";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::CMS.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(636, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::CMS.Properties.Resources.Edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(530, 294);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::CMS.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(424, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // Penalties
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(754, 602);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbShowArchive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox cbShowArchive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}