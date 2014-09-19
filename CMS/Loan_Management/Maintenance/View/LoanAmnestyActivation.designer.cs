namespace CMS.Loan_Management.Maintenance.View
{
    partial class LoanAmnestyActivation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanAmnestyActivation));
            this.dataAmnesty = new System.Windows.Forms.DataGridView();
            this.chbShowArchive = new System.Windows.Forms.CheckBox();
            this.gbAmnesty = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.clbLoanType = new System.Windows.Forms.CheckedListBox();
            this.udOverdue = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWaive = new System.Windows.Forms.Label();
            this.chbWaivePenalties = new System.Windows.Forms.CheckBox();
            this.chbWaiveInterest = new System.Windows.Forms.CheckBox();
            this.gbInclusiveDates = new System.Windows.Forms.GroupBox();
            this.clbDateTo = new System.Windows.Forms.CheckBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.lblAndAbove = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataAmnesty)).BeginInit();
            this.gbAmnesty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udOverdue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbInclusiveDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataAmnesty
            // 
            this.dataAmnesty.AllowUserToAddRows = false;
            this.dataAmnesty.AllowUserToDeleteRows = false;
            this.dataAmnesty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataAmnesty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAmnesty.BackgroundColor = System.Drawing.Color.Silver;
            this.dataAmnesty.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataAmnesty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataAmnesty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAmnesty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataAmnesty.Location = new System.Drawing.Point(13, 59);
            this.dataAmnesty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataAmnesty.Name = "dataAmnesty";
            this.dataAmnesty.ReadOnly = true;
            this.dataAmnesty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAmnesty.Size = new System.Drawing.Size(737, 127);
            this.dataAmnesty.TabIndex = 2;
            // 
            // chbShowArchive
            // 
            this.chbShowArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbShowArchive.AutoSize = true;
            this.chbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.chbShowArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbShowArchive.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbShowArchive.Location = new System.Drawing.Point(28, 200);
            this.chbShowArchive.Name = "chbShowArchive";
            this.chbShowArchive.Size = new System.Drawing.Size(123, 25);
            this.chbShowArchive.TabIndex = 3;
            this.chbShowArchive.Text = "Show Archives";
            this.chbShowArchive.UseVisualStyleBackColor = false;
            // 
            // gbAmnesty
            // 
            this.gbAmnesty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbAmnesty.Controls.Add(this.btnSave);
            this.gbAmnesty.Controls.Add(this.btnCancel);
            this.gbAmnesty.Controls.Add(this.cbDuration);
            this.gbAmnesty.Controls.Add(this.lblLoanType);
            this.gbAmnesty.Controls.Add(this.clbLoanType);
            this.gbAmnesty.Controls.Add(this.udOverdue);
            this.gbAmnesty.Controls.Add(this.lblStatus);
            this.gbAmnesty.Controls.Add(this.groupBox1);
            this.gbAmnesty.Controls.Add(this.gbInclusiveDates);
            this.gbAmnesty.Controls.Add(this.chbStatus);
            this.gbAmnesty.Controls.Add(this.lblOverdue);
            this.gbAmnesty.Controls.Add(this.lblAndAbove);
            this.gbAmnesty.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAmnesty.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbAmnesty.Location = new System.Drawing.Point(13, 237);
            this.gbAmnesty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAmnesty.Name = "gbAmnesty";
            this.gbAmnesty.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAmnesty.Size = new System.Drawing.Size(737, 272);
            this.gbAmnesty.TabIndex = 6;
            this.gbAmnesty.TabStop = false;
            this.gbAmnesty.Text = "Add/Edit Amnesty Activation";
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
            this.btnSave.Location = new System.Drawing.Point(524, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CMS.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(630, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cbDuration
            // 
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDuration.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Items.AddRange(new object[] {
            "month/s",
            "year/s"});
            this.cbDuration.Location = new System.Drawing.Point(226, 119);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(86, 29);
            this.cbDuration.TabIndex = 15;
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanType.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblLoanType.Location = new System.Drawing.Point(422, 34);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(114, 21);
            this.lblLoanType.TabIndex = 23;
            this.lblLoanType.Text = "Applicable for";
            // 
            // clbLoanType
            // 
            this.clbLoanType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbLoanType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clbLoanType.FormattingEnabled = true;
            this.clbLoanType.Location = new System.Drawing.Point(417, 58);
            this.clbLoanType.Name = "clbLoanType";
            this.clbLoanType.Size = new System.Drawing.Size(313, 148);
            this.clbLoanType.TabIndex = 24;
            // 
            // udOverdue
            // 
            this.udOverdue.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udOverdue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.udOverdue.Location = new System.Drawing.Point(158, 119);
            this.udOverdue.Name = "udOverdue";
            this.udOverdue.Size = new System.Drawing.Size(62, 29);
            this.udOverdue.TabIndex = 14;
            this.udOverdue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(8, 236);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 21);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWaive);
            this.groupBox1.Controls.Add(this.chbWaivePenalties);
            this.groupBox1.Controls.Add(this.chbWaiveInterest);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(14, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 70);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Penalty Condonation";
            // 
            // lblWaive
            // 
            this.lblWaive.AutoSize = true;
            this.lblWaive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWaive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWaive.Location = new System.Drawing.Point(19, 34);
            this.lblWaive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaive.Name = "lblWaive";
            this.lblWaive.Size = new System.Drawing.Size(53, 21);
            this.lblWaive.TabIndex = 18;
            this.lblWaive.Text = "Waive";
            // 
            // chbWaivePenalties
            // 
            this.chbWaivePenalties.AutoSize = true;
            this.chbWaivePenalties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbWaivePenalties.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbWaivePenalties.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbWaivePenalties.Location = new System.Drawing.Point(251, 30);
            this.chbWaivePenalties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbWaivePenalties.Name = "chbWaivePenalties";
            this.chbWaivePenalties.Size = new System.Drawing.Size(124, 25);
            this.chbWaivePenalties.TabIndex = 20;
            this.chbWaivePenalties.Text = "Loan Penalties";
            this.chbWaivePenalties.UseVisualStyleBackColor = true;
            // 
            // chbWaiveInterest
            // 
            this.chbWaiveInterest.AutoSize = true;
            this.chbWaiveInterest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbWaiveInterest.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbWaiveInterest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbWaiveInterest.Location = new System.Drawing.Point(144, 30);
            this.chbWaiveInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbWaiveInterest.Name = "chbWaiveInterest";
            this.chbWaiveInterest.Size = new System.Drawing.Size(84, 25);
            this.chbWaiveInterest.TabIndex = 19;
            this.chbWaiveInterest.Text = "Interests";
            this.chbWaiveInterest.UseVisualStyleBackColor = true;
            // 
            // gbInclusiveDates
            // 
            this.gbInclusiveDates.Controls.Add(this.clbDateTo);
            this.gbInclusiveDates.Controls.Add(this.startDate);
            this.gbInclusiveDates.Controls.Add(this.lblFrom);
            this.gbInclusiveDates.Controls.Add(this.endDate);
            this.gbInclusiveDates.Controls.Add(this.lblTo);
            this.gbInclusiveDates.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInclusiveDates.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbInclusiveDates.Location = new System.Drawing.Point(14, 34);
            this.gbInclusiveDates.Name = "gbInclusiveDates";
            this.gbInclusiveDates.Size = new System.Drawing.Size(393, 79);
            this.gbInclusiveDates.TabIndex = 7;
            this.gbInclusiveDates.TabStop = false;
            this.gbInclusiveDates.Text = "Inclusive Dates";
            // 
            // clbDateTo
            // 
            this.clbDateTo.AutoSize = true;
            this.clbDateTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clbDateTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbDateTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clbDateTo.Location = new System.Drawing.Point(229, 41);
            this.clbDateTo.Name = "clbDateTo";
            this.clbDateTo.Size = new System.Drawing.Size(12, 11);
            this.clbDateTo.TabIndex = 11;
            this.clbDateTo.UseVisualStyleBackColor = true;
            this.clbDateTo.CheckedChanged += new System.EventHandler(this.clbDateTo_CheckedChanged);
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(68, 30);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(122, 29);
            this.startDate.TabIndex = 9;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFrom.Location = new System.Drawing.Point(19, 36);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(44, 21);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "from";
            // 
            // endDate
            // 
            this.endDate.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(251, 30);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(122, 29);
            this.endDate.TabIndex = 12;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTo.Location = new System.Drawing.Point(198, 36);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 21);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "to";
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbStatus.Location = new System.Drawing.Point(72, 234);
            this.chbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(67, 25);
            this.chbStatus.TabIndex = 22;
            this.chbStatus.Text = "Active";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOverdue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOverdue.Location = new System.Drawing.Point(19, 122);
            this.lblOverdue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(129, 21);
            this.lblOverdue.TabIndex = 13;
            this.lblOverdue.Text = "Overdue loans of";
            // 
            // lblAndAbove
            // 
            this.lblAndAbove.AutoSize = true;
            this.lblAndAbove.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndAbove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAndAbove.Location = new System.Drawing.Point(319, 121);
            this.lblAndAbove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAndAbove.Name = "lblAndAbove";
            this.lblAndAbove.Size = new System.Drawing.Size(81, 21);
            this.lblAndAbove.TabIndex = 16;
            this.lblAndAbove.Text = "and above";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(603, 45);
            this.label5.TabIndex = 1;
            this.label5.Text = "Maintenance - Loan Amnesty Activation";
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
            this.btnEdit.Location = new System.Drawing.Point(643, 194);
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
            this.btnAdd.Location = new System.Drawing.Point(537, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // LoanAmnestyActivation
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(769, 521);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbAmnesty);
            this.Controls.Add(this.chbShowArchive);
            this.Controls.Add(this.dataAmnesty);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(785, 560);
            this.Name = "LoanAmnestyActivation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Amnesty Activation";
            ((System.ComponentModel.ISupportInitialize)(this.dataAmnesty)).EndInit();
            this.gbAmnesty.ResumeLayout(false);
            this.gbAmnesty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udOverdue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbInclusiveDates.ResumeLayout(false);
            this.gbInclusiveDates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataAmnesty;
        private System.Windows.Forms.CheckBox chbShowArchive;
        private System.Windows.Forms.GroupBox gbAmnesty;
        private System.Windows.Forms.ComboBox cbDuration;
        public System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.CheckedListBox clbLoanType;
        private System.Windows.Forms.NumericUpDown udOverdue;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblWaive;
        private System.Windows.Forms.CheckBox chbWaivePenalties;
        private System.Windows.Forms.CheckBox chbWaiveInterest;
        private System.Windows.Forms.GroupBox gbInclusiveDates;
        private System.Windows.Forms.CheckBox clbDateTo;
        private System.Windows.Forms.DateTimePicker startDate;
        public System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker endDate;
        public System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.CheckBox chbStatus;
        public System.Windows.Forms.Label lblOverdue;
        public System.Windows.Forms.Label lblAndAbove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}