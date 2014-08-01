namespace CMS.Loan_Management.Maintenance.View
{
    partial class MemberTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberTypes));
            this.dataMemberType = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupAvailability = new System.Windows.Forms.GroupBox();
            this.checkShareCapital = new System.Windows.Forms.CheckBox();
            this.checkSavings = new System.Windows.Forms.CheckBox();
            this.checkLoan = new System.Windows.Forms.CheckBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupAge = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numMaxAge = new System.Windows.Forms.NumericUpDown();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.numMinAge = new System.Windows.Forms.NumericUpDown();
            this.checkMaxAge = new System.Windows.Forms.CheckBox();
            this.checkMinAge = new System.Windows.Forms.CheckBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.checkArchived = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMemberType)).BeginInit();
            this.groupAvailability.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAge)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMemberType
            // 
            this.dataMemberType.AllowUserToAddRows = false;
            this.dataMemberType.AllowUserToDeleteRows = false;
            this.dataMemberType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataMemberType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMemberType.BackgroundColor = System.Drawing.Color.Silver;
            this.dataMemberType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMemberType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMemberType.Location = new System.Drawing.Point(13, 40);
            this.dataMemberType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataMemberType.MultiSelect = false;
            this.dataMemberType.Name = "dataMemberType";
            this.dataMemberType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMemberType.Size = new System.Drawing.Size(678, 144);
            this.dataMemberType.TabIndex = 1;
            this.dataMemberType.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataMemberType_CellFormatting);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(581, 164);
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
            this.btnSave.Location = new System.Drawing.Point(481, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkStatus.Location = new System.Drawing.Point(78, 170);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(65, 23);
            this.checkStatus.TabIndex = 21;
            this.checkStatus.Text = "Active";
            this.checkStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(21, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Status:";
            // 
            // groupAvailability
            // 
            this.groupAvailability.Controls.Add(this.checkShareCapital);
            this.groupAvailability.Controls.Add(this.checkSavings);
            this.groupAvailability.Controls.Add(this.checkLoan);
            this.groupAvailability.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupAvailability.Location = new System.Drawing.Point(25, 66);
            this.groupAvailability.Name = "groupAvailability";
            this.groupAvailability.Size = new System.Drawing.Size(335, 65);
            this.groupAvailability.TabIndex = 9;
            this.groupAvailability.TabStop = false;
            this.groupAvailability.Text = "Services Available:";
            // 
            // checkShareCapital
            // 
            this.checkShareCapital.AutoSize = true;
            this.checkShareCapital.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkShareCapital.Location = new System.Drawing.Point(204, 28);
            this.checkShareCapital.Name = "checkShareCapital";
            this.checkShareCapital.Size = new System.Drawing.Size(104, 21);
            this.checkShareCapital.TabIndex = 12;
            this.checkShareCapital.Text = "Share Capital";
            this.checkShareCapital.UseVisualStyleBackColor = true;
            this.checkShareCapital.CheckedChanged += new System.EventHandler(this.checkShareCapital_CheckedChanged);
            // 
            // checkSavings
            // 
            this.checkSavings.AutoSize = true;
            this.checkSavings.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkSavings.Location = new System.Drawing.Point(105, 28);
            this.checkSavings.Name = "checkSavings";
            this.checkSavings.Size = new System.Drawing.Size(71, 21);
            this.checkSavings.TabIndex = 11;
            this.checkSavings.Text = "Savings";
            this.checkSavings.UseVisualStyleBackColor = true;
            this.checkSavings.CheckedChanged += new System.EventHandler(this.checkSavings_CheckedChanged);
            // 
            // checkLoan
            // 
            this.checkLoan.AutoSize = true;
            this.checkLoan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkLoan.Location = new System.Drawing.Point(22, 28);
            this.checkLoan.Name = "checkLoan";
            this.checkLoan.Size = new System.Drawing.Size(55, 21);
            this.checkLoan.TabIndex = 10;
            this.checkLoan.Text = "Loan";
            this.checkLoan.UseVisualStyleBackColor = true;
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTypeName.Location = new System.Drawing.Point(165, 29);
            this.txtTypeName.MaxLength = 20;
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(506, 25);
            this.txtTypeName.TabIndex = 8;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTypeName.Location = new System.Drawing.Point(21, 32);
            this.lblTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(137, 19);
            this.lblTypeName.TabIndex = 7;
            this.lblTypeName.Text = "Member Type Name:";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.groupAge);
            this.groupBox1.Controls.Add(this.lblTypeName);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtTypeName);
            this.groupBox1.Controls.Add(this.btnRetrieve);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.groupAvailability);
            this.groupBox1.Controls.Add(this.checkStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 207);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Member Type";
            // 
            // groupAge
            // 
            this.groupAge.Controls.Add(this.label1);
            this.groupAge.Controls.Add(this.label4);
            this.groupAge.Controls.Add(this.numMaxAge);
            this.groupAge.Controls.Add(this.numMinAge);
            this.groupAge.Controls.Add(this.checkMaxAge);
            this.groupAge.Controls.Add(this.checkMinAge);
            this.groupAge.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAge.Location = new System.Drawing.Point(382, 60);
            this.groupAge.Name = "groupAge";
            this.groupAge.Size = new System.Drawing.Size(289, 96);
            this.groupAge.TabIndex = 13;
            this.groupAge.TabStop = false;
            this.groupAge.Text = "Age Requirements:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "years old";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "years old";
            // 
            // numMaxAge
            // 
            this.numMaxAge.ContextMenuStrip = this.contextMenuBlank;
            this.numMaxAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxAge.Location = new System.Drawing.Point(140, 59);
            this.numMaxAge.Name = "numMaxAge";
            this.numMaxAge.Size = new System.Drawing.Size(60, 25);
            this.numMaxAge.TabIndex = 18;
            this.numMaxAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopyPaste);
            this.numMaxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWholeNum);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // numMinAge
            // 
            this.numMinAge.ContextMenuStrip = this.contextMenuBlank;
            this.numMinAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinAge.Location = new System.Drawing.Point(140, 27);
            this.numMinAge.Name = "numMinAge";
            this.numMinAge.Size = new System.Drawing.Size(60, 25);
            this.numMinAge.TabIndex = 15;
            this.numMinAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopyPaste);
            this.numMinAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWholeNum);
            // 
            // checkMaxAge
            // 
            this.checkMaxAge.AutoSize = true;
            this.checkMaxAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMaxAge.Location = new System.Drawing.Point(22, 60);
            this.checkMaxAge.Name = "checkMaxAge";
            this.checkMaxAge.Size = new System.Drawing.Size(114, 21);
            this.checkMaxAge.TabIndex = 17;
            this.checkMaxAge.Text = "Maximum Age:";
            this.checkMaxAge.UseVisualStyleBackColor = true;
            this.checkMaxAge.CheckedChanged += new System.EventHandler(this.checkMaxAge_CheckedChanged_1);
            // 
            // checkMinAge
            // 
            this.checkMinAge.AutoSize = true;
            this.checkMinAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMinAge.Location = new System.Drawing.Point(22, 28);
            this.checkMinAge.Name = "checkMinAge";
            this.checkMinAge.Size = new System.Drawing.Size(111, 21);
            this.checkMinAge.TabIndex = 14;
            this.checkMinAge.Text = "Minimum Age:";
            this.checkMinAge.UseVisualStyleBackColor = true;
            this.checkMinAge.CheckedChanged += new System.EventHandler(this.checkMinAge_CheckedChanged_1);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRetrieve.Location = new System.Drawing.Point(148, 164);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(92, 32);
            this.btnRetrieve.TabIndex = 22;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            // 
            // checkArchived
            // 
            this.checkArchived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkArchived.AutoSize = true;
            this.checkArchived.BackColor = System.Drawing.Color.Yellow;
            this.checkArchived.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkArchived.Location = new System.Drawing.Point(13, 198);
            this.checkArchived.Name = "checkArchived";
            this.checkArchived.Size = new System.Drawing.Size(127, 24);
            this.checkArchived.TabIndex = 2;
            this.checkArchived.Text = "Show Archives";
            this.checkArchived.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Membership - Member Types";
            // 
            // MemberTypes
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(704, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkArchived);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataMemberType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 490);
            this.Name = "MemberTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Types";
            ((System.ComponentModel.ISupportInitialize)(this.dataMemberType)).EndInit();
            this.groupAvailability.ResumeLayout(false);
            this.groupAvailability.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupAge.ResumeLayout(false);
            this.groupAge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMemberType;
        private System.Windows.Forms.GroupBox groupAvailability;
        private System.Windows.Forms.CheckBox checkShareCapital;
        private System.Windows.Forms.CheckBox checkSavings;
        private System.Windows.Forms.CheckBox checkLoan;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMaxAge;
        private System.Windows.Forms.NumericUpDown numMinAge;
        private System.Windows.Forms.CheckBox checkMaxAge;
        private System.Windows.Forms.CheckBox checkMinAge;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.CheckBox checkArchived;
        private System.Windows.Forms.Label label2;
    }
}