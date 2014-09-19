namespace CMS.Loan_Management.Maintenance.View
{
    partial class MemberClassification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberClassification));
            this.dataMemberClass = new System.Windows.Forms.DataGridView();
            this.groupDeliqStatus = new System.Windows.Forms.GroupBox();
            this.rbDelinquent = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.numDelValue = new System.Windows.Forms.NumericUpDown();
            this.ContextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbBasis = new System.Windows.Forms.ComboBox();
            this.cbDelUnits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblApplied = new System.Windows.Forms.Label();
            this.checkedMemberType = new System.Windows.Forms.CheckedListBox();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatusDesc = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.checkArchived = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMemberClass)).BeginInit();
            this.groupDeliqStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataMemberClass
            // 
            this.dataMemberClass.AllowUserToAddRows = false;
            this.dataMemberClass.AllowUserToDeleteRows = false;
            this.dataMemberClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataMemberClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMemberClass.BackgroundColor = System.Drawing.Color.Silver;
            this.dataMemberClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMemberClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMemberClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMemberClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMemberClass.Location = new System.Drawing.Point(12, 57);
            this.dataMemberClass.Name = "dataMemberClass";
            this.dataMemberClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMemberClass.Size = new System.Drawing.Size(742, 167);
            this.dataMemberClass.TabIndex = 2;
            this.dataMemberClass.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataMemberClass_CellFormatting);
            // 
            // groupDeliqStatus
            // 
            this.groupDeliqStatus.Controls.Add(this.rbDelinquent);
            this.groupDeliqStatus.Controls.Add(this.rbNone);
            this.groupDeliqStatus.Controls.Add(this.numDelValue);
            this.groupDeliqStatus.Controls.Add(this.cbBasis);
            this.groupDeliqStatus.Controls.Add(this.cbDelUnits);
            this.groupDeliqStatus.Controls.Add(this.label4);
            this.groupDeliqStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupDeliqStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDeliqStatus.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupDeliqStatus.Location = new System.Drawing.Point(19, 80);
            this.groupDeliqStatus.Name = "groupDeliqStatus";
            this.groupDeliqStatus.Size = new System.Drawing.Size(400, 137);
            this.groupDeliqStatus.TabIndex = 10;
            this.groupDeliqStatus.TabStop = false;
            this.groupDeliqStatus.Text = "Deliquency Status";
            // 
            // rbDelinquent
            // 
            this.rbDelinquent.AutoSize = true;
            this.rbDelinquent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDelinquent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDelinquent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbDelinquent.Location = new System.Drawing.Point(11, 60);
            this.rbDelinquent.Name = "rbDelinquent";
            this.rbDelinquent.Size = new System.Drawing.Size(130, 25);
            this.rbDelinquent.TabIndex = 12;
            this.rbDelinquent.TabStop = true;
            this.rbDelinquent.Text = "Deliquent after";
            this.rbDelinquent.UseVisualStyleBackColor = true;
            this.rbDelinquent.CheckedChanged += new System.EventHandler(this.rbDelinquent_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbNone.Location = new System.Drawing.Point(11, 28);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(160, 25);
            this.rbNone.TabIndex = 11;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None (Good Payer)";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // numDelValue
            // 
            this.numDelValue.ContextMenuStrip = this.ContextMenuBlank;
            this.numDelValue.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDelValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numDelValue.Location = new System.Drawing.Point(177, 59);
            this.numDelValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numDelValue.Name = "numDelValue";
            this.numDelValue.Size = new System.Drawing.Size(60, 29);
            this.numDelValue.TabIndex = 13;
            this.numDelValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDelValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopyPaste);
            this.numDelValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWholeNum);
            // 
            // ContextMenuBlank
            // 
            this.ContextMenuBlank.Name = "ContextMenuBlank";
            this.ContextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // cbBasis
            // 
            this.cbBasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBasis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBasis.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBasis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbBasis.FormattingEnabled = true;
            this.cbBasis.ItemHeight = 21;
            this.cbBasis.Items.AddRange(new object[] {
            "Amortization Due Date",
            "Loan Maturity Date"});
            this.cbBasis.Location = new System.Drawing.Point(127, 94);
            this.cbBasis.Name = "cbBasis";
            this.cbBasis.Size = new System.Drawing.Size(261, 29);
            this.cbBasis.TabIndex = 16;
            // 
            // cbDelUnits
            // 
            this.cbDelUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDelUnits.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDelUnits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbDelUnits.FormattingEnabled = true;
            this.cbDelUnits.ItemHeight = 21;
            this.cbDelUnits.Items.AddRange(new object[] {
            "Days",
            "Months",
            "Years"});
            this.cbDelUnits.Location = new System.Drawing.Point(243, 59);
            this.cbDelUnits.Name = "cbDelUnits";
            this.cbDelUnits.Size = new System.Drawing.Size(145, 29);
            this.cbDelUnits.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(97, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "of";
            // 
            // lblApplied
            // 
            this.lblApplied.AutoSize = true;
            this.lblApplied.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplied.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblApplied.Location = new System.Drawing.Point(444, 46);
            this.lblApplied.Name = "lblApplied";
            this.lblApplied.Size = new System.Drawing.Size(116, 21);
            this.lblApplied.TabIndex = 17;
            this.lblApplied.Text = "Applicable For";
            // 
            // checkedMemberType
            // 
            this.checkedMemberType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedMemberType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkedMemberType.FormattingEnabled = true;
            this.checkedMemberType.Location = new System.Drawing.Point(437, 70);
            this.checkedMemberType.Name = "checkedMemberType";
            this.checkedMemberType.Size = new System.Drawing.Size(299, 148);
            this.checkedMemberType.TabIndex = 18;
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkStatus.Location = new System.Drawing.Point(68, 228);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(67, 25);
            this.checkStatus.TabIndex = 20;
            this.checkStatus.Text = "Active";
            this.checkStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Status";
            // 
            // txtStatusDesc
            // 
            this.txtStatusDesc.Enabled = false;
            this.txtStatusDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStatusDesc.Location = new System.Drawing.Point(181, 44);
            this.txtStatusDesc.MaxLength = 50;
            this.txtStatusDesc.Name = "txtStatusDesc";
            this.txtStatusDesc.Size = new System.Drawing.Size(238, 29);
            this.txtStatusDesc.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(25, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(147, 21);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Classification Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.groupDeliqStatus);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblApplied);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtStatusDesc);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnRetrieve);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkStatus);
            this.groupBox1.Controls.Add(this.checkedMemberType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 268);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Classification";
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
            this.btnSave.Location = new System.Drawing.Point(530, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 22;
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
            this.btnCancel.Location = new System.Drawing.Point(636, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.ForeColor = System.Drawing.Color.White;
            this.btnRetrieve.Image = global::CMS.Properties.Resources.Retrieve;
            this.btnRetrieve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetrieve.Location = new System.Drawing.Point(141, 223);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(110, 35);
            this.btnRetrieve.TabIndex = 21;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            // 
            // checkArchived
            // 
            this.checkArchived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkArchived.AutoSize = true;
            this.checkArchived.BackColor = System.Drawing.Color.Yellow;
            this.checkArchived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkArchived.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkArchived.Location = new System.Drawing.Point(28, 235);
            this.checkArchived.Name = "checkArchived";
            this.checkArchived.Size = new System.Drawing.Size(123, 25);
            this.checkArchived.TabIndex = 3;
            this.checkArchived.Text = "Show Archives";
            this.checkArchived.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maintenance - Deliquency Classification";
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
            this.btnDelete.Location = new System.Drawing.Point(648, 230);
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
            this.btnEdit.Location = new System.Drawing.Point(542, 230);
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
            this.btnAdd.Location = new System.Drawing.Point(436, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // MemberClassification
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(769, 556);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkArchived);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataMemberClass);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(785, 595);
            this.Name = "MemberClassification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delinquency Classifications";
            ((System.ComponentModel.ISupportInitialize)(this.dataMemberClass)).EndInit();
            this.groupDeliqStatus.ResumeLayout(false);
            this.groupDeliqStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMemberClass;
        private System.Windows.Forms.ComboBox cbDelUnits;
        private System.Windows.Forms.NumericUpDown numDelValue;
        private System.Windows.Forms.CheckedListBox checkedMemberType;
        private System.Windows.Forms.CheckBox checkStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatusDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblApplied;
        private System.Windows.Forms.GroupBox groupDeliqStatus;
        private System.Windows.Forms.RadioButton rbDelinquent;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.ComboBox cbBasis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuBlank;
        private System.Windows.Forms.CheckBox checkArchived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}