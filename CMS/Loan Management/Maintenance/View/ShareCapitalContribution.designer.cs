namespace CMS.Loan_Management.Maintenance.View
{
    partial class ShareCapitalContribution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShareCapitalContribution));
            this.label5 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.CheckBox();
            this.comboContribution = new System.Windows.Forms.ComboBox();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMemberType = new System.Windows.Forms.Label();
            this.txtContribution = new System.Windows.Forms.TextBox();
            this.lblCapitalContrib = new System.Windows.Forms.Label();
            this.dataCapitalContribution = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShowArchive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCapitalContribution)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(18, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Status.Location = new System.Drawing.Point(74, 149);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(61, 21);
            this.Status.TabIndex = 13;
            this.Status.Text = "Active";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // comboContribution
            // 
            this.comboContribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboContribution.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboContribution.FormattingEnabled = true;
            this.comboContribution.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Yearly"});
            this.comboContribution.Location = new System.Drawing.Point(212, 99);
            this.comboContribution.Name = "comboContribution";
            this.comboContribution.Size = new System.Drawing.Size(217, 25);
            this.comboContribution.TabIndex = 11;
            // 
            // comboAccountType
            // 
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAccountType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(212, 36);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(217, 25);
            this.comboAccountType.TabIndex = 7;
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMemberType.Location = new System.Drawing.Point(33, 39);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(93, 17);
            this.lblMemberType.TabIndex = 6;
            this.lblMemberType.Text = "Member Type:";
            // 
            // txtContribution
            // 
            this.txtContribution.ContextMenuStrip = this.contextMenuBlank;
            this.txtContribution.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtContribution.Location = new System.Drawing.Point(292, 68);
            this.txtContribution.MaxLength = 11;
            this.txtContribution.Name = "txtContribution";
            this.txtContribution.Size = new System.Drawing.Size(137, 25);
            this.txtContribution.TabIndex = 9;
            this.txtContribution.TextChanged += new System.EventHandler(this.txtContribution_TextChanged);
            this.txtContribution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContribution_KeyDown);
            this.txtContribution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContribution_KeyPress);
            // 
            // lblCapitalContrib
            // 
            this.lblCapitalContrib.AutoSize = true;
            this.lblCapitalContrib.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCapitalContrib.Location = new System.Drawing.Point(33, 71);
            this.lblCapitalContrib.Name = "lblCapitalContrib";
            this.lblCapitalContrib.Size = new System.Drawing.Size(253, 17);
            this.lblCapitalContrib.TabIndex = 8;
            this.lblCapitalContrib.Text = "Minimum Initial Capital Contribution:   Php";
            // 
            // dataCapitalContribution
            // 
            this.dataCapitalContribution.AllowUserToAddRows = false;
            this.dataCapitalContribution.AllowUserToDeleteRows = false;
            this.dataCapitalContribution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataCapitalContribution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCapitalContribution.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataCapitalContribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCapitalContribution.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataCapitalContribution.Location = new System.Drawing.Point(12, 36);
            this.dataCapitalContribution.MultiSelect = false;
            this.dataCapitalContribution.Name = "dataCapitalContribution";
            this.dataCapitalContribution.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCapitalContribution.Size = new System.Drawing.Size(678, 141);
            this.dataCapitalContribution.TabIndex = 1;
            this.dataCapitalContribution.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCapitalContribution_CellClick);
            this.dataCapitalContribution.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataCapitalContribution_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblDuration);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblMemberType);
            this.groupBox1.Controls.Add(this.lblCapitalContrib);
            this.groupBox1.Controls.Add(this.txtContribution);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.comboContribution);
            this.groupBox1.Controls.Add(this.comboAccountType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Minimum Contribution";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(580, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(482, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDuration.Location = new System.Drawing.Point(33, 102);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(117, 17);
            this.lblDuration.TabIndex = 10;
            this.lblDuration.Text = "Terms of Duration:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maintenance - Minimum Share Capital Contribution";
            // 
            // cbShowArchive
            // 
            this.cbShowArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShowArchive.AutoSize = true;
            this.cbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.cbShowArchive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbShowArchive.Location = new System.Drawing.Point(12, 183);
            this.cbShowArchive.Name = "cbShowArchive";
            this.cbShowArchive.Size = new System.Drawing.Size(127, 24);
            this.cbShowArchive.TabIndex = 2;
            this.cbShowArchive.Text = "Show Archives";
            this.cbShowArchive.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(500, 183);
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
            this.btnEdit.Location = new System.Drawing.Point(598, 183);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // ShareCapitalContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(704, 421);
            this.Controls.Add(this.cbShowArchive);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataCapitalContribution);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 460);
            this.Name = "ShareCapitalContribution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimum Share Capital Contribution";
            ((System.ComponentModel.ISupportInitialize)(this.dataCapitalContribution)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.ComboBox comboContribution;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.TextBox txtContribution;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataCapitalContribution;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        public System.Windows.Forms.Label lblMemberType;
        public System.Windows.Forms.Label lblCapitalContrib;
        public System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbShowArchive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}