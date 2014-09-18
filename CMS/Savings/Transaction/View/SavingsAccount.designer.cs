namespace CMS.Savings.Transaction.View
{
    partial class SavingsAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsAccount));
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.lblDepositor = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.groupWithdrawMode = new System.Windows.Forms.GroupBox();
            this.radioOr = new System.Windows.Forms.RadioButton();
            this.radioAnd = new System.Windows.Forms.RadioButton();
            this.txtPassbook = new System.Windows.Forms.TextBox();
            this.lblPassbook = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupSavingsAccount = new System.Windows.Forms.GroupBox();
            this.dataDepositor = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataMember = new System.Windows.Forms.DataGridView();
            this.dataSavingsAccount = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupWithdrawMode.SuspendLayout();
            this.groupSavingsAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepositor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSavingsAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // comboAccountType
            // 
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAccountType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(574, 63);
            this.comboAccountType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(140, 29);
            this.comboAccountType.TabIndex = 15;
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackward.ForeColor = System.Drawing.Color.White;
            this.btnBackward.Location = new System.Drawing.Point(426, 188);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(37, 36);
            this.btnBackward.TabIndex = 11;
            this.btnBackward.Text = "<";
            this.btnBackward.UseVisualStyleBackColor = false;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Location = new System.Drawing.Point(426, 142);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(37, 36);
            this.btnForward.TabIndex = 10;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = false;
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.ContextMenuStrip = this.contextMenuBlank;
            this.txtInitialDeposit.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialDeposit.Location = new System.Drawing.Point(710, 234);
            this.txtInitialDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInitialDeposit.MaxLength = 10;
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(172, 29);
            this.txtInitialDeposit.TabIndex = 21;
            this.txtInitialDeposit.Text = "0";
            this.txtInitialDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInitialDeposit.TextChanged += new System.EventHandler(this.txtInitialDeposit_TextChanged);
            this.txtInitialDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown_1);
            this.txtInitialDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress_1);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialDeposit.Location = new System.Drawing.Point(474, 237);
            this.lblInitialDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(143, 21);
            this.lblInitialDeposit.TabIndex = 20;
            this.lblInitialDeposit.Text = "Initial Deposit:  Php";
            // 
            // lblDepositor
            // 
            this.lblDepositor.AutoSize = true;
            this.lblDepositor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositor.Location = new System.Drawing.Point(467, 97);
            this.lblDepositor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepositor.Name = "lblDepositor";
            this.lblDepositor.Size = new System.Drawing.Size(150, 21);
            this.lblDepositor.TabIndex = 18;
            this.lblDepositor.Text = "Depositing Party/ies";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(467, 66);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(103, 21);
            this.lblAccountType.TabIndex = 14;
            this.lblAccountType.Text = "Account Type";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMember.Location = new System.Drawing.Point(8, 55);
            this.txtSearchMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(411, 29);
            this.txtSearchMember.TabIndex = 8;
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountHolder.Location = new System.Drawing.Point(763, 66);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(119, 21);
            this.lblAccountHolder.TabIndex = 17;
            this.lblAccountHolder.Text = "account holders";
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.Enabled = false;
            this.txtAccountHolder.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountHolder.Location = new System.Drawing.Point(721, 63);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.ReadOnly = true;
            this.txtAccountHolder.Size = new System.Drawing.Size(36, 29);
            this.txtAccountHolder.TabIndex = 16;
            this.txtAccountHolder.Text = "0";
            this.txtAccountHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupWithdrawMode
            // 
            this.groupWithdrawMode.Controls.Add(this.radioOr);
            this.groupWithdrawMode.Controls.Add(this.radioAnd);
            this.groupWithdrawMode.Enabled = false;
            this.groupWithdrawMode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupWithdrawMode.Location = new System.Drawing.Point(471, 308);
            this.groupWithdrawMode.Name = "groupWithdrawMode";
            this.groupWithdrawMode.Size = new System.Drawing.Size(286, 74);
            this.groupWithdrawMode.TabIndex = 24;
            this.groupWithdrawMode.TabStop = false;
            this.groupWithdrawMode.Text = "Mode of Withdrawal (for Joint Accounts):";
            // 
            // radioOr
            // 
            this.radioOr.AutoSize = true;
            this.radioOr.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOr.Location = new System.Drawing.Point(209, 43);
            this.radioOr.Name = "radioOr";
            this.radioOr.Size = new System.Drawing.Size(49, 25);
            this.radioOr.TabIndex = 26;
            this.radioOr.TabStop = true;
            this.radioOr.Text = "OR";
            this.radioOr.UseVisualStyleBackColor = true;
            // 
            // radioAnd
            // 
            this.radioAnd.AutoSize = true;
            this.radioAnd.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAnd.Location = new System.Drawing.Point(120, 43);
            this.radioAnd.Name = "radioAnd";
            this.radioAnd.Size = new System.Drawing.Size(61, 25);
            this.radioAnd.TabIndex = 25;
            this.radioAnd.TabStop = true;
            this.radioAnd.Text = "AND";
            this.radioAnd.UseVisualStyleBackColor = true;
            // 
            // txtPassbook
            // 
            this.txtPassbook.Enabled = false;
            this.txtPassbook.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassbook.Location = new System.Drawing.Point(710, 273);
            this.txtPassbook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassbook.Name = "txtPassbook";
            this.txtPassbook.ReadOnly = true;
            this.txtPassbook.Size = new System.Drawing.Size(172, 29);
            this.txtPassbook.TabIndex = 23;
            this.txtPassbook.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPassbook
            // 
            this.lblPassbook.AutoSize = true;
            this.lblPassbook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassbook.Location = new System.Drawing.Point(474, 276);
            this.lblPassbook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassbook.Name = "lblPassbook";
            this.lblPassbook.Size = new System.Drawing.Size(107, 21);
            this.lblPassbook.TabIndex = 22;
            this.lblPassbook.Text = "Passbook No.:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(640, 26);
            this.txtAccountNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.ReadOnly = true;
            this.txtAccountNo.Size = new System.Drawing.Size(242, 29);
            this.txtAccountNo.TabIndex = 13;
            this.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNo.Location = new System.Drawing.Point(467, 29);
            this.lblAccountNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(149, 21);
            this.lblAccountNo.TabIndex = 12;
            this.lblAccountNo.Text = "Savings Account No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search by Member Name";
            // 
            // groupSavingsAccount
            // 
            this.groupSavingsAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupSavingsAccount.Controls.Add(this.dataDepositor);
            this.groupSavingsAccount.Controls.Add(this.btnSave);
            this.groupSavingsAccount.Controls.Add(this.btnCancel);
            this.groupSavingsAccount.Controls.Add(this.label1);
            this.groupSavingsAccount.Controls.Add(this.lblAccountType);
            this.groupSavingsAccount.Controls.Add(this.lblDepositor);
            this.groupSavingsAccount.Controls.Add(this.lblInitialDeposit);
            this.groupSavingsAccount.Controls.Add(this.txtInitialDeposit);
            this.groupSavingsAccount.Controls.Add(this.txtSearchMember);
            this.groupSavingsAccount.Controls.Add(this.btnForward);
            this.groupSavingsAccount.Controls.Add(this.txtAccountNo);
            this.groupSavingsAccount.Controls.Add(this.btnBackward);
            this.groupSavingsAccount.Controls.Add(this.lblAccountNo);
            this.groupSavingsAccount.Controls.Add(this.txtPassbook);
            this.groupSavingsAccount.Controls.Add(this.comboAccountType);
            this.groupSavingsAccount.Controls.Add(this.lblPassbook);
            this.groupSavingsAccount.Controls.Add(this.lblAccountHolder);
            this.groupSavingsAccount.Controls.Add(this.groupWithdrawMode);
            this.groupSavingsAccount.Controls.Add(this.txtAccountHolder);
            this.groupSavingsAccount.Controls.Add(this.dataMember);
            this.groupSavingsAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSavingsAccount.Location = new System.Drawing.Point(13, 243);
            this.groupSavingsAccount.Name = "groupSavingsAccount";
            this.groupSavingsAccount.Size = new System.Drawing.Size(892, 389);
            this.groupSavingsAccount.TabIndex = 6;
            this.groupSavingsAccount.TabStop = false;
            this.groupSavingsAccount.Text = "Open Savings Account";
            // 
            // dataDepositor
            // 
            this.dataDepositor.AllowUserToAddRows = false;
            this.dataDepositor.AllowUserToDeleteRows = false;
            this.dataDepositor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDepositor.BackgroundColor = System.Drawing.Color.Silver;
            this.dataDepositor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDepositor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDepositor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDepositor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataDepositor.Location = new System.Drawing.Point(471, 121);
            this.dataDepositor.MultiSelect = false;
            this.dataDepositor.Name = "dataDepositor";
            this.dataDepositor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDepositor.Size = new System.Drawing.Size(411, 105);
            this.dataDepositor.TabIndex = 19;
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
            this.btnSave.Location = new System.Drawing.Point(783, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 27;
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
            this.btnCancel.Location = new System.Drawing.Point(783, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // dataMember
            // 
            this.dataMember.AllowUserToAddRows = false;
            this.dataMember.AllowUserToDeleteRows = false;
            this.dataMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMember.BackgroundColor = System.Drawing.Color.Silver;
            this.dataMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMember.Location = new System.Drawing.Point(8, 92);
            this.dataMember.MultiSelect = false;
            this.dataMember.Name = "dataMember";
            this.dataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMember.Size = new System.Drawing.Size(411, 291);
            this.dataMember.TabIndex = 9;
            // 
            // dataSavingsAccount
            // 
            this.dataSavingsAccount.AllowUserToAddRows = false;
            this.dataSavingsAccount.AllowUserToDeleteRows = false;
            this.dataSavingsAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataSavingsAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSavingsAccount.BackgroundColor = System.Drawing.Color.Silver;
            this.dataSavingsAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSavingsAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataSavingsAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSavingsAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataSavingsAccount.Location = new System.Drawing.Point(14, 57);
            this.dataSavingsAccount.MultiSelect = false;
            this.dataSavingsAccount.Name = "dataSavingsAccount";
            this.dataSavingsAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSavingsAccount.Size = new System.Drawing.Size(891, 143);
            this.dataSavingsAccount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Savings Account";
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchAccount.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccount.Location = new System.Drawing.Point(651, 20);
            this.txtSearchAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(254, 29);
            this.txtSearchAccount.TabIndex = 2;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTerminate.BackColor = System.Drawing.Color.Firebrick;
            this.btnTerminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnTerminate.ForeColor = System.Drawing.Color.White;
            this.btnTerminate.Image = global::CMS.Properties.Resources.Delete;
            this.btnTerminate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminate.Location = new System.Drawing.Point(760, 206);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(135, 35);
            this.btnTerminate.TabIndex = 5;
            this.btnTerminate.Text = "&Terminate";
            this.btnTerminate.UseVisualStyleBackColor = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpen.BackColor = System.Drawing.Color.Green;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Image = global::CMS.Properties.Resources.Add;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(619, 206);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(135, 35);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Savings Account";
            // 
            // SavingsAccount
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(919, 646);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.dataSavingsAccount);
            this.Controls.Add(this.groupSavingsAccount);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(935, 685);
            this.Name = "SavingsAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Account";
            this.groupWithdrawMode.ResumeLayout(false);
            this.groupWithdrawMode.PerformLayout();
            this.groupSavingsAccount.ResumeLayout(false);
            this.groupSavingsAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepositor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSavingsAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.TextBox txtInitialDeposit;
        private System.Windows.Forms.Label lblInitialDeposit;
        private System.Windows.Forms.Label lblDepositor;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.TextBox txtAccountHolder;
        private System.Windows.Forms.GroupBox groupWithdrawMode;
        private System.Windows.Forms.RadioButton radioOr;
        private System.Windows.Forms.RadioButton radioAnd;
        private System.Windows.Forms.TextBox txtPassbook;
        private System.Windows.Forms.Label lblPassbook;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupSavingsAccount;
        private System.Windows.Forms.DataGridView dataSavingsAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataMember;
        private System.Windows.Forms.DataGridView dataDepositor;
    }
}