namespace CMS.Loan_Management.Maintenance.View
{
    partial class LoanCharges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanCharges));
            this.dataLoanCharge = new System.Windows.Forms.DataGridView();
            this.gbCharge = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.cbOption = new System.Windows.Forms.ComboBox();
            this.clbLoanType = new System.Windows.Forms.CheckedListBox();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblChargeName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbShowArchive = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoanCharge)).BeginInit();
            this.gbCharge.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLoanCharge
            // 
            this.dataLoanCharge.AllowUserToAddRows = false;
            this.dataLoanCharge.AllowUserToDeleteRows = false;
            this.dataLoanCharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataLoanCharge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLoanCharge.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLoanCharge.BackgroundColor = System.Drawing.Color.Silver;
            this.dataLoanCharge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLoanCharge.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataLoanCharge.Location = new System.Drawing.Point(13, 74);
            this.dataLoanCharge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataLoanCharge.Name = "dataLoanCharge";
            this.dataLoanCharge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLoanCharge.Size = new System.Drawing.Size(678, 148);
            this.dataLoanCharge.TabIndex = 3;
            this.dataLoanCharge.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataLoanCharge_CellFormatting);
            // 
            // gbCharge
            // 
            this.gbCharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCharge.Controls.Add(this.btnCancel);
            this.gbCharge.Controls.Add(this.btnRetrieve);
            this.gbCharge.Controls.Add(this.btnSave);
            this.gbCharge.Controls.Add(this.lblStatus);
            this.gbCharge.Controls.Add(this.chbStatus);
            this.gbCharge.Controls.Add(this.cbOption);
            this.gbCharge.Controls.Add(this.clbLoanType);
            this.gbCharge.Controls.Add(this.lblLoanType);
            this.gbCharge.Controls.Add(this.txtAmount);
            this.gbCharge.Controls.Add(this.lblAmount);
            this.gbCharge.Controls.Add(this.txtName);
            this.gbCharge.Controls.Add(this.lblChargeName);
            this.gbCharge.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gbCharge.Location = new System.Drawing.Point(14, 270);
            this.gbCharge.Name = "gbCharge";
            this.gbCharge.Size = new System.Drawing.Size(678, 191);
            this.gbCharge.TabIndex = 9;
            this.gbCharge.TabStop = false;
            this.gbCharge.Text = "Add/Edit Charge";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(580, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRetrieve.Location = new System.Drawing.Point(166, 147);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(92, 32);
            this.btnRetrieve.TabIndex = 18;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(486, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStatus.Location = new System.Drawing.Point(30, 155);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chbStatus.Location = new System.Drawing.Point(87, 154);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(61, 21);
            this.chbStatus.TabIndex = 17;
            this.chbStatus.Text = "Active";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // cbOption
            // 
            this.cbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOption.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbOption.FormattingEnabled = true;
            this.cbOption.Items.AddRange(new object[] {
            "Php",
            "% of loan amount",
            "% of amortization"});
            this.cbOption.Location = new System.Drawing.Point(223, 73);
            this.cbOption.Name = "cbOption";
            this.cbOption.Size = new System.Drawing.Size(131, 25);
            this.cbOption.TabIndex = 13;
            // 
            // clbLoanType
            // 
            this.clbLoanType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.clbLoanType.FormattingEnabled = true;
            this.clbLoanType.Location = new System.Drawing.Point(374, 37);
            this.clbLoanType.Name = "clbLoanType";
            this.clbLoanType.Size = new System.Drawing.Size(298, 104);
            this.clbLoanType.TabIndex = 15;
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLoanType.Location = new System.Drawing.Point(370, 17);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(95, 17);
            this.lblLoanType.TabIndex = 14;
            this.lblLoanType.Text = "Applicable for:";
            // 
            // txtAmount
            // 
            this.txtAmount.ContextMenuStrip = this.contextMenuBlank;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAmount.Location = new System.Drawing.Point(116, 73);
            this.txtAmount.MaxLength = 11;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(101, 25);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown_1);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress_1);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAmount.Location = new System.Drawing.Point(10, 74);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Amount:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtName.Location = new System.Drawing.Point(116, 40);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 25);
            this.txtName.TabIndex = 10;
            // 
            // lblChargeName
            // 
            this.lblChargeName.AutoSize = true;
            this.lblChargeName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblChargeName.Location = new System.Drawing.Point(7, 43);
            this.lblChargeName.Name = "lblChargeName";
            this.lblChargeName.Size = new System.Drawing.Size(92, 17);
            this.lblChargeName.TabIndex = 9;
            this.lblChargeName.Text = "Charge Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(141, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(549, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // cbShowArchive
            // 
            this.cbShowArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShowArchive.AutoSize = true;
            this.cbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.cbShowArchive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbShowArchive.Location = new System.Drawing.Point(17, 236);
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
            this.btnDelete.Location = new System.Drawing.Point(599, 230);
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
            this.btnAdd.Location = new System.Drawing.Point(403, 230);
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
            this.btnEdit.Location = new System.Drawing.Point(501, 230);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(14, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search for charges:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance - Loan Charges";
            // 
            // LoanCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.cbShowArchive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCharge);
            this.Controls.Add(this.dataLoanCharge);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "LoanCharges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Charges";
            ((System.ComponentModel.ISupportInitialize)(this.dataLoanCharge)).EndInit();
            this.gbCharge.ResumeLayout(false);
            this.gbCharge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCharge;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.ComboBox cbOption;
        private System.Windows.Forms.CheckedListBox clbLoanType;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.DataGridView dataLoanCharge;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        public System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.Label lblChargeName;
        public System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox cbShowArchive;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;

    }
}