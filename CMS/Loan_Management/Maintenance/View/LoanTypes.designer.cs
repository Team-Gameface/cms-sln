namespace CMS.Loan_Management.Maintenance.View
{
    partial class LoanTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanTypes));
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cbShowArchive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFixed = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTimesOfShareCap = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clbMemberType = new System.Windows.Forms.CheckedListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.chbCollateral = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbMaximumPaymentDur = new System.Windows.Forms.CheckBox();
            this.cbMaximumStatus = new System.Windows.Forms.ComboBox();
            this.cbMinimumStatus = new System.Windows.Forms.ComboBox();
            this.maximumUD = new System.Windows.Forms.NumericUpDown();
            this.minimumUD = new System.Windows.Forms.NumericUpDown();
            this.lblMinimumPaymentDur = new System.Windows.Forms.Label();
            this.comakersUD = new System.Windows.Forms.NumericUpDown();
            this.gbAvailability = new System.Windows.Forms.Label();
            this.lblComaker = new System.Windows.Forms.Label();
            this.txtMaxAmt = new System.Windows.Forms.TextBox();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblMaxLoanableAmt = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comakersUD)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(12, 57);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(711, 172);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // cbShowArchive
            // 
            this.cbShowArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShowArchive.AutoSize = true;
            this.cbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.cbShowArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowArchive.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowArchive.Location = new System.Drawing.Point(22, 240);
            this.cbShowArchive.Name = "cbShowArchive";
            this.cbShowArchive.Size = new System.Drawing.Size(123, 25);
            this.cbShowArchive.TabIndex = 3;
            this.cbShowArchive.Text = "Show Archives";
            this.cbShowArchive.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFixed);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtTimesOfShareCap);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.clbMemberType);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnRetrieve);
            this.groupBox1.Controls.Add(this.chbStatus);
            this.groupBox1.Controls.Add(this.chbCollateral);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.comakersUD);
            this.groupBox1.Controls.Add(this.gbAvailability);
            this.groupBox1.Controls.Add(this.lblComaker);
            this.groupBox1.Controls.Add(this.txtMaxAmt);
            this.groupBox1.Controls.Add(this.lblOf);
            this.groupBox1.Controls.Add(this.lblMaxLoanableAmt);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 311);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Loan Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(204, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Php";
            // 
            // lblFixed
            // 
            this.lblFixed.AutoSize = true;
            this.lblFixed.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFixed.Location = new System.Drawing.Point(407, 221);
            this.lblFixed.Name = "lblFixed";
            this.lblFixed.Size = new System.Drawing.Size(56, 21);
            this.lblFixed.TabIndex = 23;
            this.lblFixed.Text = "(Fixed)";
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
            this.btnSave.Location = new System.Drawing.Point(499, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtTimesOfShareCap
            // 
            this.txtTimesOfShareCap.ContextMenuStrip = this.contextMenuBlank;
            this.txtTimesOfShareCap.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimesOfShareCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimesOfShareCap.Location = new System.Drawing.Point(469, 218);
            this.txtTimesOfShareCap.Name = "txtTimesOfShareCap";
            this.txtTimesOfShareCap.Size = new System.Drawing.Size(51, 29);
            this.txtTimesOfShareCap.TabIndex = 24;
            this.txtTimesOfShareCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimesOfShareCap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimesOfShareCap_KeyDown);
            this.txtTimesOfShareCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimesOfShareCap_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CMS.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(605, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // clbMemberType
            // 
            this.clbMemberType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMemberType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clbMemberType.FormattingEnabled = true;
            this.clbMemberType.Location = new System.Drawing.Point(413, 49);
            this.clbMemberType.Name = "clbMemberType";
            this.clbMemberType.Size = new System.Drawing.Size(285, 148);
            this.clbMemberType.TabIndex = 25;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(7, 277);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 21);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.ForeColor = System.Drawing.Color.White;
            this.btnRetrieve.Image = global::CMS.Properties.Resources.Retrieve;
            this.btnRetrieve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetrieve.Location = new System.Drawing.Point(146, 270);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(110, 35);
            this.btnRetrieve.TabIndex = 28;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbStatus.Location = new System.Drawing.Point(70, 276);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(67, 25);
            this.chbStatus.TabIndex = 27;
            this.chbStatus.Text = "Active";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // chbCollateral
            // 
            this.chbCollateral.AutoSize = true;
            this.chbCollateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbCollateral.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCollateral.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbCollateral.Location = new System.Drawing.Point(262, 74);
            this.chbCollateral.Name = "chbCollateral";
            this.chbCollateral.Size = new System.Drawing.Size(128, 25);
            this.chbCollateral.TabIndex = 12;
            this.chbCollateral.Text = "Has Collateral?";
            this.chbCollateral.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbMaximumPaymentDur);
            this.groupBox3.Controls.Add(this.cbMaximumStatus);
            this.groupBox3.Controls.Add(this.cbMinimumStatus);
            this.groupBox3.Controls.Add(this.maximumUD);
            this.groupBox3.Controls.Add(this.minimumUD);
            this.groupBox3.Controls.Add(this.lblMinimumPaymentDur);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox3.Location = new System.Drawing.Point(11, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 104);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Allowable Payment Durations";
            // 
            // chbMaximumPaymentDur
            // 
            this.chbMaximumPaymentDur.AutoSize = true;
            this.chbMaximumPaymentDur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbMaximumPaymentDur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMaximumPaymentDur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbMaximumPaymentDur.Location = new System.Drawing.Point(13, 65);
            this.chbMaximumPaymentDur.Name = "chbMaximumPaymentDur";
            this.chbMaximumPaymentDur.Size = new System.Drawing.Size(96, 25);
            this.chbMaximumPaymentDur.TabIndex = 17;
            this.chbMaximumPaymentDur.Text = "Maximum";
            this.chbMaximumPaymentDur.UseVisualStyleBackColor = true;
            this.chbMaximumPaymentDur.CheckedChanged += new System.EventHandler(this.chbMaximumPaymentDur_CheckedChanged);
            // 
            // cbMaximumStatus
            // 
            this.cbMaximumStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaximumStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMaximumStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaximumStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbMaximumStatus.FormattingEnabled = true;
            this.cbMaximumStatus.Items.AddRange(new object[] {
            "week/s",
            "month/s",
            "year/s"});
            this.cbMaximumStatus.Location = new System.Drawing.Point(184, 63);
            this.cbMaximumStatus.Name = "cbMaximumStatus";
            this.cbMaximumStatus.Size = new System.Drawing.Size(184, 29);
            this.cbMaximumStatus.TabIndex = 19;
            // 
            // cbMinimumStatus
            // 
            this.cbMinimumStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinimumStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMinimumStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinimumStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbMinimumStatus.FormattingEnabled = true;
            this.cbMinimumStatus.Items.AddRange(new object[] {
            "week/s",
            "month/s",
            "year/s"});
            this.cbMinimumStatus.Location = new System.Drawing.Point(184, 28);
            this.cbMinimumStatus.Name = "cbMinimumStatus";
            this.cbMinimumStatus.Size = new System.Drawing.Size(184, 29);
            this.cbMinimumStatus.TabIndex = 16;
            // 
            // maximumUD
            // 
            this.maximumUD.ContextMenuStrip = this.contextMenuBlank;
            this.maximumUD.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumUD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maximumUD.Location = new System.Drawing.Point(118, 63);
            this.maximumUD.Name = "maximumUD";
            this.maximumUD.Size = new System.Drawing.Size(60, 29);
            this.maximumUD.TabIndex = 18;
            this.maximumUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minimumUD
            // 
            this.minimumUD.ContextMenuStrip = this.contextMenuBlank;
            this.minimumUD.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumUD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimumUD.Location = new System.Drawing.Point(118, 28);
            this.minimumUD.Name = "minimumUD";
            this.minimumUD.Size = new System.Drawing.Size(60, 29);
            this.minimumUD.TabIndex = 15;
            this.minimumUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMinimumPaymentDur
            // 
            this.lblMinimumPaymentDur.AutoSize = true;
            this.lblMinimumPaymentDur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumPaymentDur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinimumPaymentDur.Location = new System.Drawing.Point(30, 31);
            this.lblMinimumPaymentDur.Name = "lblMinimumPaymentDur";
            this.lblMinimumPaymentDur.Size = new System.Drawing.Size(78, 21);
            this.lblMinimumPaymentDur.TabIndex = 14;
            this.lblMinimumPaymentDur.Text = "Minimum";
            // 
            // comakersUD
            // 
            this.comakersUD.ContextMenuStrip = this.contextMenuBlank;
            this.comakersUD.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comakersUD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comakersUD.Location = new System.Drawing.Point(155, 73);
            this.comakersUD.Name = "comakersUD";
            this.comakersUD.Size = new System.Drawing.Size(62, 29);
            this.comakersUD.TabIndex = 11;
            this.comakersUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbAvailability
            // 
            this.gbAvailability.AutoSize = true;
            this.gbAvailability.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvailability.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbAvailability.Location = new System.Drawing.Point(418, 25);
            this.gbAvailability.Name = "gbAvailability";
            this.gbAvailability.Size = new System.Drawing.Size(114, 21);
            this.gbAvailability.TabIndex = 24;
            this.gbAvailability.Text = "Applicable for";
            // 
            // lblComaker
            // 
            this.lblComaker.AutoSize = true;
            this.lblComaker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComaker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComaker.Location = new System.Drawing.Point(19, 75);
            this.lblComaker.Name = "lblComaker";
            this.lblComaker.Size = new System.Drawing.Size(86, 21);
            this.lblComaker.TabIndex = 10;
            this.lblComaker.Text = "Co-makers";
            // 
            // txtMaxAmt
            // 
            this.txtMaxAmt.ContextMenuStrip = this.contextMenuBlank;
            this.txtMaxAmt.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxAmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaxAmt.Location = new System.Drawing.Point(247, 218);
            this.txtMaxAmt.Name = "txtMaxAmt";
            this.txtMaxAmt.Size = new System.Drawing.Size(154, 29);
            this.txtMaxAmt.TabIndex = 22;
            this.txtMaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxAmt.TextChanged += new System.EventHandler(this.txtMaxAmt_TextChanged);
            this.txtMaxAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxAmt_KeyDown);
            this.txtMaxAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxAmt_KeyPress);
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOf.Location = new System.Drawing.Point(526, 221);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(172, 21);
            this.lblOf.TabIndex = 25;
            this.lblOf.Text = "(Times of Share Capital)";
            // 
            // lblMaxLoanableAmt
            // 
            this.lblMaxLoanableAmt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxLoanableAmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaxLoanableAmt.Location = new System.Drawing.Point(19, 221);
            this.lblMaxLoanableAmt.Name = "lblMaxLoanableAmt";
            this.lblMaxLoanableAmt.Size = new System.Drawing.Size(179, 26);
            this.lblMaxLoanableAmt.TabIndex = 20;
            this.lblMaxLoanableAmt.Text = "Max. Loanable Amount:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(155, 38);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 29);
            this.txtName.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(19, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 21);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Loan Type Name";
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
            this.label2.Size = new System.Drawing.Size(403, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maintenance - Loan Types";
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
            this.btnDelete.Location = new System.Drawing.Point(617, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 6;
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
            this.btnEdit.Location = new System.Drawing.Point(511, 235);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 5;
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
            this.btnAdd.Location = new System.Drawing.Point(405, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // LoanTypes
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(734, 601);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbShowArchive);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(750, 640);
            this.Name = "LoanTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Types";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comakersUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckBox cbShowArchive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.CheckedListBox clbMemberType;
        private System.Windows.Forms.CheckBox chbCollateral;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbMaximumStatus;
        private System.Windows.Forms.ComboBox cbMinimumStatus;
        private System.Windows.Forms.NumericUpDown maximumUD;
        private System.Windows.Forms.NumericUpDown minimumUD;
        public System.Windows.Forms.Label lblMinimumPaymentDur;
        private System.Windows.Forms.NumericUpDown comakersUD;
        public System.Windows.Forms.Label lblComaker;
        private System.Windows.Forms.TextBox txtMaxAmt;
        public System.Windows.Forms.Label lblOf;
        public System.Windows.Forms.Label lblMaxLoanableAmt;
        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label gbAvailability;
        public System.Windows.Forms.CheckBox chbMaximumPaymentDur;
        private System.Windows.Forms.TextBox txtTimesOfShareCap;
        public System.Windows.Forms.Label lblFixed;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

    }
}