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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsAccount));
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.dataDepositor = new System.Windows.Forms.DataGridView();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.dataMember = new System.Windows.Forms.DataGridView();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupSavingsAccount = new System.Windows.Forms.GroupBox();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dataSavingsAccount = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepositor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            this.groupWithdrawMode.SuspendLayout();
            this.groupSavingsAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSavingsAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // comboAccountType
            // 
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAccountType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(463, 47);
            this.comboAccountType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(134, 25);
            this.comboAccountType.TabIndex = 15;
            // 
            // dataDepositor
            // 
            this.dataDepositor.AllowUserToAddRows = false;
            this.dataDepositor.AllowUserToDeleteRows = false;
            this.dataDepositor.AllowUserToResizeRows = false;
            this.dataDepositor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataDepositor.BackgroundColor = System.Drawing.Color.Silver;
            this.dataDepositor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDepositor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataDepositor.Location = new System.Drawing.Point(373, 99);
            this.dataDepositor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataDepositor.MultiSelect = false;
            this.dataDepositor.Name = "dataDepositor";
            this.dataDepositor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDepositor.Size = new System.Drawing.Size(369, 82);
            this.dataDepositor.TabIndex = 19;
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackward.ForeColor = System.Drawing.Color.White;
            this.btnBackward.Location = new System.Drawing.Point(328, 182);
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
            this.btnForward.Location = new System.Drawing.Point(328, 136);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(37, 36);
            this.btnForward.TabIndex = 10;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = false;
            // 
            // dataMember
            // 
            this.dataMember.AllowUserToAddRows = false;
            this.dataMember.AllowUserToDeleteRows = false;
            this.dataMember.AllowUserToResizeRows = false;
            this.dataMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMember.BackgroundColor = System.Drawing.Color.Silver;
            this.dataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMember.Location = new System.Drawing.Point(7, 93);
            this.dataMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataMember.MultiSelect = false;
            this.dataMember.Name = "dataMember";
            this.dataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMember.Size = new System.Drawing.Size(313, 220);
            this.dataMember.TabIndex = 9;
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.ContextMenuStrip = this.contextMenuBlank;
            this.txtInitialDeposit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtInitialDeposit.Location = new System.Drawing.Point(565, 183);
            this.txtInitialDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInitialDeposit.MaxLength = 10;
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(172, 25);
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
            this.lblInitialDeposit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblInitialDeposit.Location = new System.Drawing.Point(384, 186);
            this.lblInitialDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(120, 17);
            this.lblInitialDeposit.TabIndex = 20;
            this.lblInitialDeposit.Text = "Initial Deposit:  Php";
            // 
            // lblDepositor
            // 
            this.lblDepositor.AutoSize = true;
            this.lblDepositor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblDepositor.Location = new System.Drawing.Point(362, 77);
            this.lblDepositor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepositor.Name = "lblDepositor";
            this.lblDepositor.Size = new System.Drawing.Size(133, 17);
            this.lblDepositor.TabIndex = 18;
            this.lblDepositor.Text = "Depositing Party/ies:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblAccountType.Location = new System.Drawing.Point(362, 50);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(93, 17);
            this.lblAccountType.TabIndex = 14;
            this.lblAccountType.Text = "Account Type:";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearchMember.Location = new System.Drawing.Point(7, 52);
            this.txtSearchMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(312, 25);
            this.txtSearchMember.TabIndex = 8;
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblAccountHolder.Location = new System.Drawing.Point(647, 50);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(96, 17);
            this.lblAccountHolder.TabIndex = 17;
            this.lblAccountHolder.Text = "account holders";
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.Enabled = false;
            this.txtAccountHolder.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAccountHolder.Location = new System.Drawing.Point(604, 47);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.ReadOnly = true;
            this.txtAccountHolder.Size = new System.Drawing.Size(36, 25);
            this.txtAccountHolder.TabIndex = 16;
            this.txtAccountHolder.Text = "0";
            this.txtAccountHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupWithdrawMode
            // 
            this.groupWithdrawMode.Controls.Add(this.radioOr);
            this.groupWithdrawMode.Controls.Add(this.radioAnd);
            this.groupWithdrawMode.Enabled = false;
            this.groupWithdrawMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.groupWithdrawMode.Location = new System.Drawing.Point(378, 239);
            this.groupWithdrawMode.Name = "groupWithdrawMode";
            this.groupWithdrawMode.Size = new System.Drawing.Size(195, 74);
            this.groupWithdrawMode.TabIndex = 24;
            this.groupWithdrawMode.TabStop = false;
            this.groupWithdrawMode.Text = "Mode of Withdrawal (for Joint Accounts):";
            // 
            // radioOr
            // 
            this.radioOr.AutoSize = true;
            this.radioOr.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radioOr.Location = new System.Drawing.Point(109, 42);
            this.radioOr.Name = "radioOr";
            this.radioOr.Size = new System.Drawing.Size(44, 21);
            this.radioOr.TabIndex = 26;
            this.radioOr.TabStop = true;
            this.radioOr.Text = "OR";
            this.radioOr.UseVisualStyleBackColor = true;
            // 
            // radioAnd
            // 
            this.radioAnd.AutoSize = true;
            this.radioAnd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radioAnd.Location = new System.Drawing.Point(20, 42);
            this.radioAnd.Name = "radioAnd";
            this.radioAnd.Size = new System.Drawing.Size(53, 21);
            this.radioAnd.TabIndex = 25;
            this.radioAnd.TabStop = true;
            this.radioAnd.Text = "AND";
            this.radioAnd.UseVisualStyleBackColor = true;
            // 
            // txtPassbook
            // 
            this.txtPassbook.Enabled = false;
            this.txtPassbook.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPassbook.Location = new System.Drawing.Point(565, 210);
            this.txtPassbook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassbook.Name = "txtPassbook";
            this.txtPassbook.ReadOnly = true;
            this.txtPassbook.Size = new System.Drawing.Size(172, 25);
            this.txtPassbook.TabIndex = 23;
            this.txtPassbook.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPassbook
            // 
            this.lblPassbook.AutoSize = true;
            this.lblPassbook.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPassbook.Location = new System.Drawing.Point(384, 213);
            this.lblPassbook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassbook.Name = "lblPassbook";
            this.lblPassbook.Size = new System.Drawing.Size(92, 17);
            this.lblPassbook.TabIndex = 22;
            this.lblPassbook.Text = "Passbook No.:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAccountNo.Location = new System.Drawing.Point(500, 20);
            this.txtAccountNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.ReadOnly = true;
            this.txtAccountNo.Size = new System.Drawing.Size(242, 25);
            this.txtAccountNo.TabIndex = 13;
            this.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAccountNo.Location = new System.Drawing.Point(362, 23);
            this.lblAccountNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(130, 17);
            this.lblAccountNo.TabIndex = 12;
            this.lblAccountNo.Text = "Savings Account No.:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "SAVINGS ACCOUNT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search by Member Name:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(640, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 32);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(640, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 32);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupSavingsAccount
            // 
            this.groupSavingsAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupSavingsAccount.Controls.Add(this.label1);
            this.groupSavingsAccount.Controls.Add(this.lblAccountType);
            this.groupSavingsAccount.Controls.Add(this.btnSave);
            this.groupSavingsAccount.Controls.Add(this.lblDepositor);
            this.groupSavingsAccount.Controls.Add(this.btnCancel);
            this.groupSavingsAccount.Controls.Add(this.lblInitialDeposit);
            this.groupSavingsAccount.Controls.Add(this.txtInitialDeposit);
            this.groupSavingsAccount.Controls.Add(this.dataMember);
            this.groupSavingsAccount.Controls.Add(this.txtSearchMember);
            this.groupSavingsAccount.Controls.Add(this.btnForward);
            this.groupSavingsAccount.Controls.Add(this.txtAccountNo);
            this.groupSavingsAccount.Controls.Add(this.btnBackward);
            this.groupSavingsAccount.Controls.Add(this.lblAccountNo);
            this.groupSavingsAccount.Controls.Add(this.dataDepositor);
            this.groupSavingsAccount.Controls.Add(this.txtPassbook);
            this.groupSavingsAccount.Controls.Add(this.comboAccountType);
            this.groupSavingsAccount.Controls.Add(this.lblPassbook);
            this.groupSavingsAccount.Controls.Add(this.lblAccountHolder);
            this.groupSavingsAccount.Controls.Add(this.groupWithdrawMode);
            this.groupSavingsAccount.Controls.Add(this.txtAccountHolder);
            this.groupSavingsAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSavingsAccount.Location = new System.Drawing.Point(13, 231);
            this.groupSavingsAccount.Name = "groupSavingsAccount";
            this.groupSavingsAccount.Size = new System.Drawing.Size(749, 318);
            this.groupSavingsAccount.TabIndex = 6;
            this.groupSavingsAccount.TabStop = false;
            this.groupSavingsAccount.Text = "Open/Modify Savings Account";
            // 
            // btnTerminate
            // 
            this.btnTerminate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTerminate.BackColor = System.Drawing.Color.Firebrick;
            this.btnTerminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminate.ForeColor = System.Drawing.Color.White;
            this.btnTerminate.Location = new System.Drawing.Point(670, 193);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(92, 32);
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
            this.btnOpen.Location = new System.Drawing.Point(572, 193);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(92, 32);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            // 
            // dataSavingsAccount
            // 
            this.dataSavingsAccount.AllowUserToAddRows = false;
            this.dataSavingsAccount.AllowUserToDeleteRows = false;
            this.dataSavingsAccount.AllowUserToResizeRows = false;
            this.dataSavingsAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataSavingsAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataSavingsAccount.BackgroundColor = System.Drawing.Color.Silver;
            this.dataSavingsAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSavingsAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataSavingsAccount.Location = new System.Drawing.Point(13, 44);
            this.dataSavingsAccount.MultiSelect = false;
            this.dataSavingsAccount.Name = "dataSavingsAccount";
            this.dataSavingsAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSavingsAccount.Size = new System.Drawing.Size(749, 143);
            this.dataSavingsAccount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Savings Account:";
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccount.Location = new System.Drawing.Point(508, 7);
            this.txtSearchAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(254, 29);
            this.txtSearchAccount.TabIndex = 2;
            // 
            // SavingsAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(774, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.dataSavingsAccount);
            this.Controls.Add(this.groupSavingsAccount);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(790, 600);
            this.Name = "SavingsAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Account";
            ((System.ComponentModel.ISupportInitialize)(this.dataDepositor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            this.groupWithdrawMode.ResumeLayout(false);
            this.groupWithdrawMode.PerformLayout();
            this.groupSavingsAccount.ResumeLayout(false);
            this.groupSavingsAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSavingsAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.DataGridView dataDepositor;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.DataGridView dataMember;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupSavingsAccount;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridView dataSavingsAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchAccount;
    }
}