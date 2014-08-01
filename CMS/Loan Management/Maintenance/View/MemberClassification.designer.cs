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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.checkArchived = new System.Windows.Forms.CheckBox();
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
            this.dataMemberClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMemberClass.BackgroundColor = System.Drawing.Color.Silver;
            this.dataMemberClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMemberClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMemberClass.Location = new System.Drawing.Point(13, 40);
            this.dataMemberClass.Name = "dataMemberClass";
            this.dataMemberClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMemberClass.Size = new System.Drawing.Size(678, 144);
            this.dataMemberClass.TabIndex = 1;
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
            this.groupDeliqStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupDeliqStatus.Location = new System.Drawing.Point(10, 63);
            this.groupDeliqStatus.Name = "groupDeliqStatus";
            this.groupDeliqStatus.Size = new System.Drawing.Size(371, 126);
            this.groupDeliqStatus.TabIndex = 9;
            this.groupDeliqStatus.TabStop = false;
            this.groupDeliqStatus.Text = "Deliquency Status";
            // 
            // rbDelinquent
            // 
            this.rbDelinquent.AutoSize = true;
            this.rbDelinquent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbDelinquent.Location = new System.Drawing.Point(6, 59);
            this.rbDelinquent.Name = "rbDelinquent";
            this.rbDelinquent.Size = new System.Drawing.Size(115, 21);
            this.rbDelinquent.TabIndex = 11;
            this.rbDelinquent.TabStop = true;
            this.rbDelinquent.Text = "Deliquent after:";
            this.rbDelinquent.UseVisualStyleBackColor = true;
            this.rbDelinquent.CheckedChanged += new System.EventHandler(this.rbDelinquent_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbNone.Location = new System.Drawing.Point(6, 28);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(139, 21);
            this.rbNone.TabIndex = 10;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None (Good Payer)";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // numDelValue
            // 
            this.numDelValue.ContextMenuStrip = this.ContextMenuBlank;
            this.numDelValue.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numDelValue.Location = new System.Drawing.Point(168, 57);
            this.numDelValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numDelValue.Name = "numDelValue";
            this.numDelValue.Size = new System.Drawing.Size(60, 25);
            this.numDelValue.TabIndex = 12;
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
            this.cbBasis.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbBasis.FormattingEnabled = true;
            this.cbBasis.ItemHeight = 17;
            this.cbBasis.Items.AddRange(new object[] {
            "Amortization Due Date",
            "Loan Maturity Date"});
            this.cbBasis.Location = new System.Drawing.Point(105, 92);
            this.cbBasis.Name = "cbBasis";
            this.cbBasis.Size = new System.Drawing.Size(261, 25);
            this.cbBasis.TabIndex = 15;
            // 
            // cbDelUnits
            // 
            this.cbDelUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDelUnits.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbDelUnits.FormattingEnabled = true;
            this.cbDelUnits.ItemHeight = 17;
            this.cbDelUnits.Items.AddRange(new object[] {
            "Days",
            "Months",
            "Years"});
            this.cbDelUnits.Location = new System.Drawing.Point(234, 57);
            this.cbDelUnits.Name = "cbDelUnits";
            this.cbDelUnits.Size = new System.Drawing.Size(132, 25);
            this.cbDelUnits.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(75, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "of";
            // 
            // lblApplied
            // 
            this.lblApplied.AutoSize = true;
            this.lblApplied.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblApplied.Location = new System.Drawing.Point(395, 34);
            this.lblApplied.Name = "lblApplied";
            this.lblApplied.Size = new System.Drawing.Size(98, 17);
            this.lblApplied.TabIndex = 16;
            this.lblApplied.Text = "Applicable For:";
            // 
            // checkedMemberType
            // 
            this.checkedMemberType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkedMemberType.FormattingEnabled = true;
            this.checkedMemberType.Location = new System.Drawing.Point(395, 56);
            this.checkedMemberType.Name = "checkedMemberType";
            this.checkedMemberType.Size = new System.Drawing.Size(273, 124);
            this.checkedMemberType.TabIndex = 17;
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkStatus.Location = new System.Drawing.Point(79, 202);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(61, 21);
            this.checkStatus.TabIndex = 19;
            this.checkStatus.Text = "Active";
            this.checkStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(13, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Status:";
            // 
            // txtStatusDesc
            // 
            this.txtStatusDesc.Enabled = false;
            this.txtStatusDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtStatusDesc.Location = new System.Drawing.Point(143, 31);
            this.txtStatusDesc.MaxLength = 50;
            this.txtStatusDesc.Name = "txtStatusDesc";
            this.txtStatusDesc.Size = new System.Drawing.Size(238, 25);
            this.txtStatusDesc.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblName.Location = new System.Drawing.Point(12, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 17);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Classification Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.groupDeliqStatus);
            this.groupBox1.Controls.Add(this.btnRetrieve);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblApplied);
            this.groupBox1.Controls.Add(this.txtStatusDesc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkStatus);
            this.groupBox1.Controls.Add(this.checkedMemberType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 230);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Classification";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(582, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRetrieve.Location = new System.Drawing.Point(146, 195);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(92, 32);
            this.btnRetrieve.TabIndex = 20;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(482, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Membership - Delinquency Classifications";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(599, 192);
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
            this.btnAdd.Location = new System.Drawing.Point(403, 192);
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
            this.btnEdit.Location = new System.Drawing.Point(501, 192);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // checkArchived
            // 
            this.checkArchived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkArchived.AutoSize = true;
            this.checkArchived.BackColor = System.Drawing.Color.Yellow;
            this.checkArchived.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkArchived.Location = new System.Drawing.Point(13, 190);
            this.checkArchived.Name = "checkArchived";
            this.checkArchived.Size = new System.Drawing.Size(127, 24);
            this.checkArchived.TabIndex = 2;
            this.checkArchived.Text = "Show Archives";
            this.checkArchived.UseVisualStyleBackColor = false;
            // 
            // MemberClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.checkArchived);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataMemberClass);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox checkArchived;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnSave;
    }
}