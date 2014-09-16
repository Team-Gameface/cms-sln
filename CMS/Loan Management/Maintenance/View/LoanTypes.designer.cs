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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanTypes));
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShowArchive = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbMemberType = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
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
            this.txtTimesOfShareCap = new System.Windows.Forms.TextBox();
            this.lblFixed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(13, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(678, 141);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maintenance - Loan Types";
            // 
            // cbShowArchive
            // 
            this.cbShowArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShowArchive.AutoSize = true;
            this.cbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.cbShowArchive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbShowArchive.Location = new System.Drawing.Point(13, 194);
            this.cbShowArchive.Name = "cbShowArchive";
            this.cbShowArchive.Size = new System.Drawing.Size(127, 24);
            this.cbShowArchive.TabIndex = 2;
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
            this.btnDelete.Location = new System.Drawing.Point(599, 188);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 32);
            this.btnDelete.TabIndex = 5;
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
            this.btnAdd.Location = new System.Drawing.Point(403, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 3;
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
            this.btnEdit.Location = new System.Drawing.Point(501, 188);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFixed);
            this.groupBox1.Controls.Add(this.txtTimesOfShareCap);
            this.groupBox1.Controls.Add(this.clbMemberType);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnRetrieve);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblStatus);
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(14, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 240);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Loan Type";
            // 
            // clbMemberType
            // 
            this.clbMemberType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.clbMemberType.FormattingEnabled = true;
            this.clbMemberType.Location = new System.Drawing.Point(389, 38);
            this.clbMemberType.Name = "clbMemberType";
            this.clbMemberType.Size = new System.Drawing.Size(274, 104);
            this.clbMemberType.TabIndex = 25;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(580, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRetrieve.Location = new System.Drawing.Point(144, 201);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(92, 32);
            this.btnRetrieve.TabIndex = 28;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(480, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStatus.Location = new System.Drawing.Point(16, 209);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status:";
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chbStatus.Location = new System.Drawing.Point(77, 208);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(61, 21);
            this.chbStatus.TabIndex = 27;
            this.chbStatus.Text = "Active";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // chbCollateral
            // 
            this.chbCollateral.AutoSize = true;
            this.chbCollateral.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chbCollateral.Location = new System.Drawing.Point(242, 61);
            this.chbCollateral.Name = "chbCollateral";
            this.chbCollateral.Size = new System.Drawing.Size(114, 21);
            this.chbCollateral.TabIndex = 11;
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
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(10, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 84);
            this.groupBox3.TabIndex = 85;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Allowable Payment Durations";
            // 
            // chbMaximumPaymentDur
            // 
            this.chbMaximumPaymentDur.AutoSize = true;
            this.chbMaximumPaymentDur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMaximumPaymentDur.Location = new System.Drawing.Point(9, 52);
            this.chbMaximumPaymentDur.Name = "chbMaximumPaymentDur";
            this.chbMaximumPaymentDur.Size = new System.Drawing.Size(84, 21);
            this.chbMaximumPaymentDur.TabIndex = 86;
            this.chbMaximumPaymentDur.Text = "Maximum";
            this.chbMaximumPaymentDur.UseVisualStyleBackColor = true;
            this.chbMaximumPaymentDur.CheckedChanged += new System.EventHandler(this.chbMaximumPaymentDur_CheckedChanged);
            // 
            // cbMaximumStatus
            // 
            this.cbMaximumStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaximumStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMaximumStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbMaximumStatus.FormattingEnabled = true;
            this.cbMaximumStatus.Items.AddRange(new object[] {
            "week/s",
            "month/s",
            "year/s"});
            this.cbMaximumStatus.Location = new System.Drawing.Point(162, 49);
            this.cbMaximumStatus.Name = "cbMaximumStatus";
            this.cbMaximumStatus.Size = new System.Drawing.Size(184, 25);
            this.cbMaximumStatus.TabIndex = 18;
            // 
            // cbMinimumStatus
            // 
            this.cbMinimumStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinimumStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMinimumStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbMinimumStatus.FormattingEnabled = true;
            this.cbMinimumStatus.Items.AddRange(new object[] {
            "week/s",
            "month/s",
            "year/s"});
            this.cbMinimumStatus.Location = new System.Drawing.Point(162, 21);
            this.cbMinimumStatus.Name = "cbMinimumStatus";
            this.cbMinimumStatus.Size = new System.Drawing.Size(184, 25);
            this.cbMinimumStatus.TabIndex = 15;
            // 
            // maximumUD
            // 
            this.maximumUD.ContextMenuStrip = this.contextMenuBlank;
            this.maximumUD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.maximumUD.Location = new System.Drawing.Point(96, 51);
            this.maximumUD.Name = "maximumUD";
            this.maximumUD.Size = new System.Drawing.Size(60, 25);
            this.maximumUD.TabIndex = 17;
            // 
            // minimumUD
            // 
            this.minimumUD.ContextMenuStrip = this.contextMenuBlank;
            this.minimumUD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.minimumUD.Location = new System.Drawing.Point(96, 23);
            this.minimumUD.Name = "minimumUD";
            this.minimumUD.Size = new System.Drawing.Size(60, 25);
            this.minimumUD.TabIndex = 14;
            // 
            // lblMinimumPaymentDur
            // 
            this.lblMinimumPaymentDur.AutoSize = true;
            this.lblMinimumPaymentDur.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMinimumPaymentDur.Location = new System.Drawing.Point(25, 25);
            this.lblMinimumPaymentDur.Name = "lblMinimumPaymentDur";
            this.lblMinimumPaymentDur.Size = new System.Drawing.Size(65, 17);
            this.lblMinimumPaymentDur.TabIndex = 13;
            this.lblMinimumPaymentDur.Text = "Minimum:";
            // 
            // comakersUD
            // 
            this.comakersUD.ContextMenuStrip = this.contextMenuBlank;
            this.comakersUD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comakersUD.Location = new System.Drawing.Point(126, 57);
            this.comakersUD.Name = "comakersUD";
            this.comakersUD.Size = new System.Drawing.Size(62, 25);
            this.comakersUD.TabIndex = 10;
            // 
            // gbAvailability
            // 
            this.gbAvailability.AutoSize = true;
            this.gbAvailability.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbAvailability.Location = new System.Drawing.Point(386, 18);
            this.gbAvailability.Name = "gbAvailability";
            this.gbAvailability.Size = new System.Drawing.Size(95, 17);
            this.gbAvailability.TabIndex = 24;
            this.gbAvailability.Text = "Applicable for:";
            // 
            // lblComaker
            // 
            this.lblComaker.AutoSize = true;
            this.lblComaker.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblComaker.Location = new System.Drawing.Point(10, 59);
            this.lblComaker.Name = "lblComaker";
            this.lblComaker.Size = new System.Drawing.Size(74, 17);
            this.lblComaker.TabIndex = 9;
            this.lblComaker.Text = "Co-makers:";
            // 
            // txtMaxAmt
            // 
            this.txtMaxAmt.ContextMenuStrip = this.contextMenuBlank;
            this.txtMaxAmt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaxAmt.Location = new System.Drawing.Point(201, 171);
            this.txtMaxAmt.Name = "txtMaxAmt";
            this.txtMaxAmt.Size = new System.Drawing.Size(154, 25);
            this.txtMaxAmt.TabIndex = 20;
            this.txtMaxAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxAmt_KeyDown);
            this.txtMaxAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxAmt_KeyPress);
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOf.Location = new System.Drawing.Point(465, 174);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(147, 17);
            this.lblOf.TabIndex = 22;
            this.lblOf.Text = "(Times of Share Capital)";
            // 
            // lblMaxLoanableAmt
            // 
            this.lblMaxLoanableAmt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMaxLoanableAmt.Location = new System.Drawing.Point(16, 174);
            this.lblMaxLoanableAmt.Name = "lblMaxLoanableAmt";
            this.lblMaxLoanableAmt.Size = new System.Drawing.Size(179, 26);
            this.lblMaxLoanableAmt.TabIndex = 19;
            this.lblMaxLoanableAmt.Text = "Max. Loanable Amount: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtName.Location = new System.Drawing.Point(126, 28);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 25);
            this.txtName.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblName.Location = new System.Drawing.Point(10, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 17);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Loan Type Name:";
            // 
            // txtTimesOfShareCap
            // 
            this.txtTimesOfShareCap.ContextMenuStrip = this.contextMenuBlank;
            this.txtTimesOfShareCap.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTimesOfShareCap.Location = new System.Drawing.Point(412, 171);
            this.txtTimesOfShareCap.Name = "txtTimesOfShareCap";
            this.txtTimesOfShareCap.Size = new System.Drawing.Size(47, 25);
            this.txtTimesOfShareCap.TabIndex = 86;
            this.txtTimesOfShareCap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimesOfShareCap_KeyDown);
            this.txtTimesOfShareCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimesOfShareCap_KeyPress);
            // 
            // lblFixed
            // 
            this.lblFixed.AutoSize = true;
            this.lblFixed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixed.Location = new System.Drawing.Point(361, 174);
            this.lblFixed.Name = "lblFixed";
            this.lblFixed.Size = new System.Drawing.Size(46, 17);
            this.lblFixed.TabIndex = 87;
            this.lblFixed.Text = "(Fixed)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(163, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 88;
            this.label1.Text = "Php";
            // 
            // LoanTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbShowArchive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbShowArchive;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label gbAvailability;
        public System.Windows.Forms.CheckBox chbMaximumPaymentDur;
        private System.Windows.Forms.TextBox txtTimesOfShareCap;
        public System.Windows.Forms.Label lblFixed;
        public System.Windows.Forms.Label label1;

    }
}