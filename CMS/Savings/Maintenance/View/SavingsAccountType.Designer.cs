﻿namespace CMS.Savings.Maintenance.View
{
    partial class SavingsAccountType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsAccountType));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupInterest = new System.Windows.Forms.GroupBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboDormancyChargeDuration = new System.Windows.Forms.ComboBox();
            this.lblDormancy = new System.Windows.Forms.Label();
            this.lblEvery = new System.Windows.Forms.Label();
            this.txtDormancyPenalty = new System.Windows.Forms.TextBox();
            this.numDormancyChargeDuration = new System.Windows.Forms.NumericUpDown();
            this.comboDormancy = new System.Windows.Forms.ComboBox();
            this.comboDormancyPenalty = new System.Windows.Forms.ComboBox();
            this.numDormancy = new System.Windows.Forms.NumericUpDown();
            this.lblPenaltyDormancy = new System.Windows.Forms.Label();
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.numMBalChargeDuration = new System.Windows.Forms.NumericUpDown();
            this.comboMBalChargeDuration = new System.Windows.Forms.ComboBox();
            this.comboMBalCharge = new System.Windows.Forms.ComboBox();
            this.txtMBalCharge = new System.Windows.Forms.TextBox();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.txtMaintaningBalance = new System.Windows.Forms.TextBox();
            this.lblMaintainingBalance = new System.Windows.Forms.Label();
            this.txtMaxWith = new System.Windows.Forms.TextBox();
            this.lblMaxWith = new System.Windows.Forms.Label();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupAvailable = new System.Windows.Forms.GroupBox();
            this.checkedMemberTypes = new System.Windows.Forms.CheckedListBox();
            this.txtInitDeposit = new System.Windows.Forms.TextBox();
            this.lblInitDeposit = new System.Windows.Forms.Label();
            this.groupRequirements = new System.Windows.Forms.GroupBox();
            this.checkMaintainingBalance = new System.Windows.Forms.CheckBox();
            this.checkInterestRates = new System.Windows.Forms.CheckBox();
            this.checkDormancy = new System.Windows.Forms.CheckBox();
            this.numAccountHolder = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dataAccountType = new System.Windows.Forms.DataGridView();
            this.checkArchived = new System.Windows.Forms.CheckBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupInterest.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDormancyChargeDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDormancy)).BeginInit();
            this.groupMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMBalChargeDuration)).BeginInit();
            this.groupAvailable.SuspendLayout();
            this.groupRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.groupInterest);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.lblAccountHolder);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupMain);
            this.groupBox1.Controls.Add(this.txtMaxWith);
            this.groupBox1.Controls.Add(this.lblMaxWith);
            this.groupBox1.Controls.Add(this.btnRetrieve);
            this.groupBox1.Controls.Add(this.checkStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupAvailable);
            this.groupBox1.Controls.Add(this.txtInitDeposit);
            this.groupBox1.Controls.Add(this.lblInitDeposit);
            this.groupBox1.Controls.Add(this.groupRequirements);
            this.groupBox1.Controls.Add(this.numAccountHolder);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 354);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Savings Account Type";
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
            this.btnSave.Location = new System.Drawing.Point(778, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // groupInterest
            // 
            this.groupInterest.Controls.Add(this.lblRate);
            this.groupInterest.Controls.Add(this.lblPercent);
            this.groupInterest.Controls.Add(this.txtInterestRate);
            this.groupInterest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInterest.ForeColor = System.Drawing.Color.Firebrick;
            this.groupInterest.Location = new System.Drawing.Point(13, 238);
            this.groupInterest.Name = "groupInterest";
            this.groupInterest.Size = new System.Drawing.Size(417, 59);
            this.groupInterest.TabIndex = 19;
            this.groupInterest.TabStop = false;
            this.groupInterest.Text = "Interest Rate";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRate.Location = new System.Drawing.Point(10, 27);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(41, 21);
            this.lblRate.TabIndex = 20;
            this.lblRate.Text = "Rate";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPercent.Location = new System.Drawing.Point(235, 27);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(101, 21);
            this.lblPercent.TabIndex = 22;
            this.lblPercent.Text = "% per annum";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.ContextMenuStrip = this.contextMenuBlank;
            this.txtInterestRate.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInterestRate.Location = new System.Drawing.Point(133, 24);
            this.txtInterestRate.MaxLength = 7;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(96, 29);
            this.txtInterestRate.TabIndex = 21;
            this.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInterestRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInterestRate_KeyDown);
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestRate_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CMS.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(884, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountHolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccountHolder.Location = new System.Drawing.Point(13, 143);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(170, 21);
            this.lblAccountHolder.TabIndex = 13;
            this.lblAccountHolder.Text = "No. of Account Holders";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboDormancyChargeDuration);
            this.groupBox2.Controls.Add(this.lblDormancy);
            this.groupBox2.Controls.Add(this.lblEvery);
            this.groupBox2.Controls.Add(this.txtDormancyPenalty);
            this.groupBox2.Controls.Add(this.numDormancyChargeDuration);
            this.groupBox2.Controls.Add(this.comboDormancy);
            this.groupBox2.Controls.Add(this.comboDormancyPenalty);
            this.groupBox2.Controls.Add(this.numDormancy);
            this.groupBox2.Controls.Add(this.lblPenaltyDormancy);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(436, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 148);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dormancy";
            // 
            // comboDormancyChargeDuration
            // 
            this.comboDormancyChargeDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDormancyChargeDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDormancyChargeDuration.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDormancyChargeDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboDormancyChargeDuration.FormattingEnabled = true;
            this.comboDormancyChargeDuration.Items.AddRange(new object[] {
            "Day/s",
            "Month/s",
            "Year/s"});
            this.comboDormancyChargeDuration.Location = new System.Drawing.Point(195, 113);
            this.comboDormancyChargeDuration.Name = "comboDormancyChargeDuration";
            this.comboDormancyChargeDuration.Size = new System.Drawing.Size(109, 29);
            this.comboDormancyChargeDuration.TabIndex = 41;
            // 
            // lblDormancy
            // 
            this.lblDormancy.AutoSize = true;
            this.lblDormancy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDormancy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDormancy.Location = new System.Drawing.Point(23, 23);
            this.lblDormancy.Name = "lblDormancy";
            this.lblDormancy.Size = new System.Drawing.Size(71, 21);
            this.lblDormancy.TabIndex = 33;
            this.lblDormancy.Text = "Duration";
            // 
            // lblEvery
            // 
            this.lblEvery.AutoSize = true;
            this.lblEvery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEvery.Location = new System.Drawing.Point(23, 116);
            this.lblEvery.Name = "lblEvery";
            this.lblEvery.Size = new System.Drawing.Size(108, 21);
            this.lblEvery.TabIndex = 39;
            this.lblEvery.Text = "charged every";
            // 
            // txtDormancyPenalty
            // 
            this.txtDormancyPenalty.ContextMenuStrip = this.contextMenuBlank;
            this.txtDormancyPenalty.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDormancyPenalty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDormancyPenalty.Location = new System.Drawing.Point(27, 78);
            this.txtDormancyPenalty.MaxLength = 7;
            this.txtDormancyPenalty.Name = "txtDormancyPenalty";
            this.txtDormancyPenalty.Size = new System.Drawing.Size(100, 29);
            this.txtDormancyPenalty.TabIndex = 37;
            this.txtDormancyPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDormancyPenalty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInitDeposit_KeyDown);
            this.txtDormancyPenalty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInitDeposit_KeyPress);
            // 
            // numDormancyChargeDuration
            // 
            this.numDormancyChargeDuration.ContextMenuStrip = this.contextMenuBlank;
            this.numDormancyChargeDuration.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDormancyChargeDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numDormancyChargeDuration.Location = new System.Drawing.Point(137, 113);
            this.numDormancyChargeDuration.Name = "numDormancyChargeDuration";
            this.numDormancyChargeDuration.Size = new System.Drawing.Size(52, 29);
            this.numDormancyChargeDuration.TabIndex = 40;
            this.numDormancyChargeDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numAccountHolder_KeyDown);
            this.numDormancyChargeDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numAccountHolder_KeyPress);
            // 
            // comboDormancy
            // 
            this.comboDormancy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDormancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDormancy.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDormancy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboDormancy.FormattingEnabled = true;
            this.comboDormancy.Items.AddRange(new object[] {
            "Day/s",
            "Month/s",
            "Year/s"});
            this.comboDormancy.Location = new System.Drawing.Point(195, 20);
            this.comboDormancy.Name = "comboDormancy";
            this.comboDormancy.Size = new System.Drawing.Size(109, 29);
            this.comboDormancy.TabIndex = 35;
            // 
            // comboDormancyPenalty
            // 
            this.comboDormancyPenalty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDormancyPenalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDormancyPenalty.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDormancyPenalty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboDormancyPenalty.FormattingEnabled = true;
            this.comboDormancyPenalty.Items.AddRange(new object[] {
            "Php",
            "%"});
            this.comboDormancyPenalty.Location = new System.Drawing.Point(137, 78);
            this.comboDormancyPenalty.Name = "comboDormancyPenalty";
            this.comboDormancyPenalty.Size = new System.Drawing.Size(167, 29);
            this.comboDormancyPenalty.TabIndex = 38;
            // 
            // numDormancy
            // 
            this.numDormancy.ContextMenuStrip = this.contextMenuBlank;
            this.numDormancy.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDormancy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numDormancy.Location = new System.Drawing.Point(137, 21);
            this.numDormancy.Name = "numDormancy";
            this.numDormancy.Size = new System.Drawing.Size(52, 29);
            this.numDormancy.TabIndex = 34;
            this.numDormancy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numAccountHolder_KeyDown);
            this.numDormancy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numAccountHolder_KeyPress);
            // 
            // lblPenaltyDormancy
            // 
            this.lblPenaltyDormancy.AutoSize = true;
            this.lblPenaltyDormancy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenaltyDormancy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPenaltyDormancy.Location = new System.Drawing.Point(15, 54);
            this.lblPenaltyDormancy.Name = "lblPenaltyDormancy";
            this.lblPenaltyDormancy.Size = new System.Drawing.Size(121, 21);
            this.lblPenaltyDormancy.TabIndex = 36;
            this.lblPenaltyDormancy.Text = "Penalty Amount";
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.numMBalChargeDuration);
            this.groupMain.Controls.Add(this.comboMBalChargeDuration);
            this.groupMain.Controls.Add(this.comboMBalCharge);
            this.groupMain.Controls.Add(this.txtMBalCharge);
            this.groupMain.Controls.Add(this.lblCharge);
            this.groupMain.Controls.Add(this.lblPenalty);
            this.groupMain.Controls.Add(this.txtMaintaningBalance);
            this.groupMain.Controls.Add(this.lblMaintainingBalance);
            this.groupMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMain.ForeColor = System.Drawing.Color.Firebrick;
            this.groupMain.Location = new System.Drawing.Point(437, 30);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(316, 164);
            this.groupMain.TabIndex = 23;
            this.groupMain.TabStop = false;
            this.groupMain.Text = "Maintaining Balance";
            // 
            // numMBalChargeDuration
            // 
            this.numMBalChargeDuration.ContextMenuStrip = this.contextMenuBlank;
            this.numMBalChargeDuration.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMBalChargeDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numMBalChargeDuration.Location = new System.Drawing.Point(136, 119);
            this.numMBalChargeDuration.Name = "numMBalChargeDuration";
            this.numMBalChargeDuration.Size = new System.Drawing.Size(52, 29);
            this.numMBalChargeDuration.TabIndex = 30;
            this.numMBalChargeDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numAccountHolder_KeyDown);
            this.numMBalChargeDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numAccountHolder_KeyPress);
            // 
            // comboMBalChargeDuration
            // 
            this.comboMBalChargeDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMBalChargeDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMBalChargeDuration.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMBalChargeDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboMBalChargeDuration.FormattingEnabled = true;
            this.comboMBalChargeDuration.Items.AddRange(new object[] {
            "day/s",
            "week/s",
            "month/s",
            "year/s"});
            this.comboMBalChargeDuration.Location = new System.Drawing.Point(194, 119);
            this.comboMBalChargeDuration.Name = "comboMBalChargeDuration";
            this.comboMBalChargeDuration.Size = new System.Drawing.Size(109, 29);
            this.comboMBalChargeDuration.TabIndex = 31;
            // 
            // comboMBalCharge
            // 
            this.comboMBalCharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMBalCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMBalCharge.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMBalCharge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboMBalCharge.FormattingEnabled = true;
            this.comboMBalCharge.Items.AddRange(new object[] {
            "Pesos (Php)",
            "% of Current Balance"});
            this.comboMBalCharge.Location = new System.Drawing.Point(132, 84);
            this.comboMBalCharge.Name = "comboMBalCharge";
            this.comboMBalCharge.Size = new System.Drawing.Size(171, 29);
            this.comboMBalCharge.TabIndex = 28;
            // 
            // txtMBalCharge
            // 
            this.txtMBalCharge.ContextMenuStrip = this.contextMenuBlank;
            this.txtMBalCharge.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMBalCharge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMBalCharge.Location = new System.Drawing.Point(26, 84);
            this.txtMBalCharge.MaxLength = 7;
            this.txtMBalCharge.Name = "txtMBalCharge";
            this.txtMBalCharge.Size = new System.Drawing.Size(100, 29);
            this.txtMBalCharge.TabIndex = 27;
            this.txtMBalCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCharge.Location = new System.Drawing.Point(22, 122);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(108, 21);
            this.lblCharge.TabIndex = 29;
            this.lblCharge.Text = "charged every";
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenalty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPenalty.Location = new System.Drawing.Point(14, 60);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(121, 21);
            this.lblPenalty.TabIndex = 26;
            this.lblPenalty.Text = "Penalty Amount";
            // 
            // txtMaintaningBalance
            // 
            this.txtMaintaningBalance.ContextMenuStrip = this.contextMenuBlank;
            this.txtMaintaningBalance.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintaningBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaintaningBalance.Location = new System.Drawing.Point(111, 28);
            this.txtMaintaningBalance.MaxLength = 10;
            this.txtMaintaningBalance.Name = "txtMaintaningBalance";
            this.txtMaintaningBalance.Size = new System.Drawing.Size(192, 29);
            this.txtMaintaningBalance.TabIndex = 25;
            this.txtMaintaningBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaintaningBalance.TextChanged += new System.EventHandler(this.txtMaintaningBalance_TextChanged);
            this.txtMaintaningBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInitDeposit_KeyDown);
            this.txtMaintaningBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaintaningBalance_KeyPress);
            // 
            // lblMaintainingBalance
            // 
            this.lblMaintainingBalance.AutoSize = true;
            this.lblMaintainingBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintainingBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaintainingBalance.Location = new System.Drawing.Point(14, 31);
            this.lblMaintainingBalance.Name = "lblMaintainingBalance";
            this.lblMaintainingBalance.Size = new System.Drawing.Size(66, 21);
            this.lblMaintainingBalance.TabIndex = 24;
            this.lblMaintainingBalance.Text = "Amount";
            // 
            // txtMaxWith
            // 
            this.txtMaxWith.ContextMenuStrip = this.contextMenuBlank;
            this.txtMaxWith.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxWith.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaxWith.Location = new System.Drawing.Point(252, 104);
            this.txtMaxWith.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxWith.MaxLength = 15;
            this.txtMaxWith.Name = "txtMaxWith";
            this.txtMaxWith.Size = new System.Drawing.Size(178, 29);
            this.txtMaxWith.TabIndex = 12;
            this.txtMaxWith.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxWith.TextChanged += new System.EventHandler(this.txtMaxWith_TextChanged);
            this.txtMaxWith.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInitDeposit_KeyDown);
            this.txtMaxWith.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxWith_KeyPress);
            // 
            // lblMaxWith
            // 
            this.lblMaxWith.AutoSize = true;
            this.lblMaxWith.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxWith.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaxWith.Location = new System.Drawing.Point(13, 107);
            this.lblMaxWith.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxWith.Name = "lblMaxWith";
            this.lblMaxWith.Size = new System.Drawing.Size(224, 21);
            this.lblMaxWith.TabIndex = 11;
            this.lblMaxWith.Text = "Maximum Withdrawal Amount";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.ForeColor = System.Drawing.Color.White;
            this.btnRetrieve.Image = global::CMS.Properties.Resources.Retrieve;
            this.btnRetrieve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetrieve.Location = new System.Drawing.Point(146, 313);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(110, 35);
            this.btnRetrieve.TabIndex = 46;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkStatus.Location = new System.Drawing.Point(70, 317);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(67, 25);
            this.checkStatus.TabIndex = 45;
            this.checkStatus.Text = "Active";
            this.checkStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Status";
            // 
            // groupAvailable
            // 
            this.groupAvailable.Controls.Add(this.checkedMemberTypes);
            this.groupAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAvailable.ForeColor = System.Drawing.Color.Firebrick;
            this.groupAvailable.Location = new System.Drawing.Point(759, 30);
            this.groupAvailable.Name = "groupAvailable";
            this.groupAvailable.Size = new System.Drawing.Size(225, 277);
            this.groupAvailable.TabIndex = 42;
            this.groupAvailable.TabStop = false;
            this.groupAvailable.Text = "Applicable for";
            // 
            // checkedMemberTypes
            // 
            this.checkedMemberTypes.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedMemberTypes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkedMemberTypes.FormattingEnabled = true;
            this.checkedMemberTypes.Location = new System.Drawing.Point(6, 22);
            this.checkedMemberTypes.Name = "checkedMemberTypes";
            this.checkedMemberTypes.Size = new System.Drawing.Size(213, 244);
            this.checkedMemberTypes.TabIndex = 43;
            // 
            // txtInitDeposit
            // 
            this.txtInitDeposit.ContextMenuStrip = this.contextMenuBlank;
            this.txtInitDeposit.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitDeposit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInitDeposit.Location = new System.Drawing.Point(252, 67);
            this.txtInitDeposit.MaxLength = 15;
            this.txtInitDeposit.Name = "txtInitDeposit";
            this.txtInitDeposit.Size = new System.Drawing.Size(178, 29);
            this.txtInitDeposit.TabIndex = 10;
            this.txtInitDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInitDeposit.TextChanged += new System.EventHandler(this.txtInitDeposit_TextChanged);
            this.txtInitDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInitDeposit_KeyDown);
            this.txtInitDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInitDeposit_KeyPress);
            // 
            // lblInitDeposit
            // 
            this.lblInitDeposit.AutoSize = true;
            this.lblInitDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitDeposit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInitDeposit.Location = new System.Drawing.Point(13, 70);
            this.lblInitDeposit.Name = "lblInitDeposit";
            this.lblInitDeposit.Size = new System.Drawing.Size(165, 21);
            this.lblInitDeposit.TabIndex = 9;
            this.lblInitDeposit.Text = "Initial Deposit Amount";
            // 
            // groupRequirements
            // 
            this.groupRequirements.Controls.Add(this.checkMaintainingBalance);
            this.groupRequirements.Controls.Add(this.checkInterestRates);
            this.groupRequirements.Controls.Add(this.checkDormancy);
            this.groupRequirements.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRequirements.ForeColor = System.Drawing.Color.Firebrick;
            this.groupRequirements.Location = new System.Drawing.Point(13, 176);
            this.groupRequirements.Name = "groupRequirements";
            this.groupRequirements.Size = new System.Drawing.Size(417, 56);
            this.groupRequirements.TabIndex = 15;
            this.groupRequirements.TabStop = false;
            this.groupRequirements.Text = "Requirements";
            // 
            // checkMaintainingBalance
            // 
            this.checkMaintainingBalance.AutoSize = true;
            this.checkMaintainingBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkMaintainingBalance.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMaintainingBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkMaintainingBalance.Location = new System.Drawing.Point(133, 24);
            this.checkMaintainingBalance.Name = "checkMaintainingBalance";
            this.checkMaintainingBalance.Size = new System.Drawing.Size(166, 25);
            this.checkMaintainingBalance.TabIndex = 17;
            this.checkMaintainingBalance.Text = "Maintaining Balance";
            this.checkMaintainingBalance.UseVisualStyleBackColor = true;
            this.checkMaintainingBalance.CheckedChanged += new System.EventHandler(this.checkMaintainingBalance_CheckedChanged);
            // 
            // checkInterestRates
            // 
            this.checkInterestRates.AutoSize = true;
            this.checkInterestRates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkInterestRates.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInterestRates.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkInterestRates.Location = new System.Drawing.Point(6, 24);
            this.checkInterestRates.Name = "checkInterestRates";
            this.checkInterestRates.Size = new System.Drawing.Size(118, 25);
            this.checkInterestRates.TabIndex = 16;
            this.checkInterestRates.Text = "Interest Rates";
            this.checkInterestRates.UseVisualStyleBackColor = true;
            this.checkInterestRates.CheckedChanged += new System.EventHandler(this.checkInterestRates_CheckedChanged);
            // 
            // checkDormancy
            // 
            this.checkDormancy.AutoSize = true;
            this.checkDormancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkDormancy.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDormancy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkDormancy.Location = new System.Drawing.Point(308, 24);
            this.checkDormancy.Name = "checkDormancy";
            this.checkDormancy.Size = new System.Drawing.Size(95, 25);
            this.checkDormancy.TabIndex = 18;
            this.checkDormancy.Text = "Dormancy";
            this.checkDormancy.UseVisualStyleBackColor = true;
            this.checkDormancy.CheckedChanged += new System.EventHandler(this.checkDormancy_CheckedChanged);
            // 
            // numAccountHolder
            // 
            this.numAccountHolder.ContextMenuStrip = this.contextMenuBlank;
            this.numAccountHolder.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAccountHolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numAccountHolder.Location = new System.Drawing.Point(252, 141);
            this.numAccountHolder.Name = "numAccountHolder";
            this.numAccountHolder.Size = new System.Drawing.Size(53, 29);
            this.numAccountHolder.TabIndex = 14;
            this.numAccountHolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numAccountHolder_KeyDown);
            this.numAccountHolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numAccountHolder_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(252, 32);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 29);
            this.txtName.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(13, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 21);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Account Type Name";
            // 
            // dataAccountType
            // 
            this.dataAccountType.AllowUserToAddRows = false;
            this.dataAccountType.AllowUserToDeleteRows = false;
            this.dataAccountType.AllowUserToOrderColumns = true;
            this.dataAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataAccountType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAccountType.BackgroundColor = System.Drawing.Color.Silver;
            this.dataAccountType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataAccountType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataAccountType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccountType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataAccountType.Location = new System.Drawing.Point(12, 64);
            this.dataAccountType.MultiSelect = false;
            this.dataAccountType.Name = "dataAccountType";
            this.dataAccountType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAccountType.Size = new System.Drawing.Size(990, 143);
            this.dataAccountType.TabIndex = 1;
            this.dataAccountType.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataAccountType_CellFormatting);
            // 
            // checkArchived
            // 
            this.checkArchived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkArchived.AutoSize = true;
            this.checkArchived.BackColor = System.Drawing.Color.Yellow;
            this.checkArchived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkArchived.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkArchived.Location = new System.Drawing.Point(21, 219);
            this.checkArchived.Name = "checkArchived";
            this.checkArchived.Size = new System.Drawing.Size(123, 25);
            this.checkArchived.TabIndex = 2;
            this.checkArchived.Text = "Show Archives";
            this.checkArchived.UseVisualStyleBackColor = false;
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
            this.btnEdit.Location = new System.Drawing.Point(784, 213);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 4;
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
            this.btnAdd.Location = new System.Drawing.Point(678, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
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
            this.btnDelete.Location = new System.Drawing.Point(890, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(571, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Maintenance - Savings Account Types";
            // 
            // SavingsAccountType
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1014, 621);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.checkArchived);
            this.Controls.Add(this.dataAccountType);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1030, 660);
            this.Name = "SavingsAccountType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Account Types";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupInterest.ResumeLayout(false);
            this.groupInterest.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDormancyChargeDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDormancy)).EndInit();
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMBalChargeDuration)).EndInit();
            this.groupAvailable.ResumeLayout(false);
            this.groupRequirements.ResumeLayout(false);
            this.groupRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupRequirements;
        private System.Windows.Forms.CheckBox checkMaintainingBalance;
        private System.Windows.Forms.CheckBox checkInterestRates;
        private System.Windows.Forms.CheckBox checkDormancy;
        private System.Windows.Forms.NumericUpDown numAccountHolder;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtInitDeposit;
        private System.Windows.Forms.Label lblInitDeposit;
        private System.Windows.Forms.GroupBox groupAvailable;
        private System.Windows.Forms.CheckedListBox checkedMemberTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.DataGridView dataAccountType;
        private System.Windows.Forms.CheckBox checkArchived;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.CheckBox checkStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxWith;
        private System.Windows.Forms.Label lblMaxWith;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboDormancyChargeDuration;
        private System.Windows.Forms.Label lblDormancy;
        private System.Windows.Forms.Label lblEvery;
        private System.Windows.Forms.TextBox txtDormancyPenalty;
        private System.Windows.Forms.NumericUpDown numDormancyChargeDuration;
        private System.Windows.Forms.ComboBox comboDormancy;
        private System.Windows.Forms.ComboBox comboDormancyPenalty;
        private System.Windows.Forms.NumericUpDown numDormancy;
        private System.Windows.Forms.Label lblPenaltyDormancy;
        private System.Windows.Forms.GroupBox groupMain;
        private System.Windows.Forms.NumericUpDown numMBalChargeDuration;
        private System.Windows.Forms.ComboBox comboMBalChargeDuration;
        private System.Windows.Forms.ComboBox comboMBalCharge;
        private System.Windows.Forms.TextBox txtMBalCharge;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.TextBox txtMaintaningBalance;
        private System.Windows.Forms.Label lblMaintainingBalance;
        private System.Windows.Forms.GroupBox groupInterest;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;


    }
}