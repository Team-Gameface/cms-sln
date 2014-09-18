namespace CMS.Savings.Transaction.View
{
    partial class MemberTermination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberTermination));
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.rbMemberName = new System.Windows.Forms.RadioButton();
            this.rbAccountNo = new System.Windows.Forms.RadioButton();
            this.txtSpecify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbROthers = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbFDormant = new System.Windows.Forms.RadioButton();
            this.rbFViolation = new System.Windows.Forms.RadioButton();
            this.rbRVoluntary = new System.Windows.Forms.RadioButton();
            this.rbRForced = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbVLeave = new System.Windows.Forms.RadioButton();
            this.rbVIncapable = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNetRefunds = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLoanBalance = new System.Windows.Forms.TextBox();
            this.txtSCapBalance = new System.Windows.Forms.TextBox();
            this.txtTimeDep = new System.Windows.Forms.TextBox();
            this.txtSavings = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSearch
            // 
            this.dataSearch.AllowUserToAddRows = false;
            this.dataSearch.AllowUserToDeleteRows = false;
            this.dataSearch.AllowUserToOrderColumns = true;
            this.dataSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSearch.BackgroundColor = System.Drawing.Color.Silver;
            this.dataSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearch.Location = new System.Drawing.Point(12, 158);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSearch.Size = new System.Drawing.Size(785, 155);
            this.dataSearch.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtAccountNo);
            this.groupBox4.Controls.Add(this.txtMemberName);
            this.groupBox4.Controls.Add(this.rbMemberName);
            this.groupBox4.Controls.Add(this.rbAccountNo);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox4.Location = new System.Drawing.Point(12, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(785, 93);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccountNo.Location = new System.Drawing.Point(269, 23);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(419, 29);
            this.txtAccountNo.TabIndex = 5;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberName.Location = new System.Drawing.Point(269, 58);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(419, 29);
            this.txtMemberName.TabIndex = 7;
            // 
            // rbMemberName
            // 
            this.rbMemberName.AutoSize = true;
            this.rbMemberName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMemberName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbMemberName.Location = new System.Drawing.Point(108, 59);
            this.rbMemberName.Name = "rbMemberName";
            this.rbMemberName.Size = new System.Drawing.Size(132, 25);
            this.rbMemberName.TabIndex = 6;
            this.rbMemberName.TabStop = true;
            this.rbMemberName.Text = "Member Name";
            this.rbMemberName.UseVisualStyleBackColor = true;
            this.rbMemberName.CheckedChanged += new System.EventHandler(this.rbMemberName_CheckedChanged_1);
            // 
            // rbAccountNo
            // 
            this.rbAccountNo.AutoSize = true;
            this.rbAccountNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAccountNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAccountNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAccountNo.Location = new System.Drawing.Point(108, 23);
            this.rbAccountNo.Name = "rbAccountNo";
            this.rbAccountNo.Size = new System.Drawing.Size(145, 25);
            this.rbAccountNo.TabIndex = 4;
            this.rbAccountNo.TabStop = true;
            this.rbAccountNo.Text = "Account Number";
            this.rbAccountNo.UseVisualStyleBackColor = true;
            this.rbAccountNo.CheckedChanged += new System.EventHandler(this.rbAccountNo_CheckedChanged_1);
            // 
            // txtSpecify
            // 
            this.txtSpecify.Enabled = false;
            this.txtSpecify.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSpecify.Location = new System.Drawing.Point(161, 213);
            this.txtSpecify.Name = "txtSpecify";
            this.txtSpecify.Size = new System.Drawing.Size(232, 29);
            this.txtSpecify.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(100, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Specify";
            // 
            // rbROthers
            // 
            this.rbROthers.AutoSize = true;
            this.rbROthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbROthers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbROthers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbROthers.Location = new System.Drawing.Point(17, 218);
            this.rbROthers.Name = "rbROthers";
            this.rbROthers.Size = new System.Drawing.Size(74, 25);
            this.rbROthers.TabIndex = 19;
            this.rbROthers.TabStop = true;
            this.rbROthers.Text = "Others";
            this.rbROthers.UseVisualStyleBackColor = true;
            this.rbROthers.CheckedChanged += new System.EventHandler(this.rbROthers_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtSpecify);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbRVoluntary);
            this.panel1.Controls.Add(this.rbRForced);
            this.panel1.Controls.Add(this.rbROthers);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panel1.Location = new System.Drawing.Point(12, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 262);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbFDormant);
            this.panel3.Controls.Add(this.rbFViolation);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panel3.Location = new System.Drawing.Point(41, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 60);
            this.panel3.TabIndex = 16;
            // 
            // rbFDormant
            // 
            this.rbFDormant.AutoSize = true;
            this.rbFDormant.Enabled = false;
            this.rbFDormant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbFDormant.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFDormant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbFDormant.Location = new System.Drawing.Point(3, 3);
            this.rbFDormant.Name = "rbFDormant";
            this.rbFDormant.Size = new System.Drawing.Size(189, 25);
            this.rbFDormant.TabIndex = 17;
            this.rbFDormant.TabStop = true;
            this.rbFDormant.Text = "Dormancy/Delinquency";
            this.rbFDormant.UseVisualStyleBackColor = true;
            this.rbFDormant.CheckedChanged += new System.EventHandler(this.rbFDormant_CheckedChanged);
            // 
            // rbFViolation
            // 
            this.rbFViolation.AutoSize = true;
            this.rbFViolation.Enabled = false;
            this.rbFViolation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbFViolation.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFViolation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbFViolation.Location = new System.Drawing.Point(3, 34);
            this.rbFViolation.Name = "rbFViolation";
            this.rbFViolation.Size = new System.Drawing.Size(163, 25);
            this.rbFViolation.TabIndex = 18;
            this.rbFViolation.TabStop = true;
            this.rbFViolation.Text = "Violation of by-Laws";
            this.rbFViolation.UseVisualStyleBackColor = true;
            this.rbFViolation.CheckedChanged += new System.EventHandler(this.rbFViolation_CheckedChanged);
            // 
            // rbRVoluntary
            // 
            this.rbRVoluntary.AutoSize = true;
            this.rbRVoluntary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRVoluntary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRVoluntary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbRVoluntary.Location = new System.Drawing.Point(17, 12);
            this.rbRVoluntary.Name = "rbRVoluntary";
            this.rbRVoluntary.Size = new System.Drawing.Size(179, 25);
            this.rbRVoluntary.TabIndex = 11;
            this.rbRVoluntary.TabStop = true;
            this.rbRVoluntary.Text = "Voluntary Withdrawal";
            this.rbRVoluntary.UseVisualStyleBackColor = true;
            this.rbRVoluntary.CheckedChanged += new System.EventHandler(this.rbRVoluntary_CheckedChanged);
            // 
            // rbRForced
            // 
            this.rbRForced.AutoSize = true;
            this.rbRForced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRForced.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRForced.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbRForced.Location = new System.Drawing.Point(17, 116);
            this.rbRForced.Name = "rbRForced";
            this.rbRForced.Size = new System.Drawing.Size(162, 25);
            this.rbRForced.TabIndex = 15;
            this.rbRForced.TabStop = true;
            this.rbRForced.Text = "Forced Termination";
            this.rbRForced.UseVisualStyleBackColor = true;
            this.rbRForced.CheckedChanged += new System.EventHandler(this.rbRForced_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbVLeave);
            this.panel2.Controls.Add(this.rbVIncapable);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panel2.Location = new System.Drawing.Point(41, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 67);
            this.panel2.TabIndex = 12;
            // 
            // rbVLeave
            // 
            this.rbVLeave.AutoSize = true;
            this.rbVLeave.Enabled = false;
            this.rbVLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbVLeave.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVLeave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbVLeave.Location = new System.Drawing.Point(3, 3);
            this.rbVLeave.Name = "rbVLeave";
            this.rbVLeave.Size = new System.Drawing.Size(157, 25);
            this.rbVLeave.TabIndex = 13;
            this.rbVLeave.TabStop = true;
            this.rbVLeave.Text = "Leaving the vicinity";
            this.rbVLeave.UseVisualStyleBackColor = true;
            this.rbVLeave.CheckedChanged += new System.EventHandler(this.rbVLeave_CheckedChanged);
            // 
            // rbVIncapable
            // 
            this.rbVIncapable.AutoSize = true;
            this.rbVIncapable.Enabled = false;
            this.rbVIncapable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbVIncapable.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVIncapable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbVIncapable.Location = new System.Drawing.Point(3, 34);
            this.rbVIncapable.Name = "rbVIncapable";
            this.rbVIncapable.Size = new System.Drawing.Size(168, 25);
            this.rbVIncapable.TabIndex = 14;
            this.rbVIncapable.TabStop = true;
            this.rbVIncapable.Text = "Incapable of funding";
            this.rbVIncapable.UseVisualStyleBackColor = true;
            this.rbVIncapable.CheckedChanged += new System.EventHandler(this.rbVIncapable_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtNetRefunds);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtLoanBalance);
            this.groupBox5.Controls.Add(this.txtSCapBalance);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox5.Location = new System.Drawing.Point(436, 389);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(361, 163);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Refunds Breakdown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(22, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Refundables";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(22, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 21);
            this.label13.TabIndex = 32;
            this.label13.Text = "Net Refunds";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(31, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "less: Loan Balance";
            // 
            // txtNetRefunds
            // 
            this.txtNetRefunds.Enabled = false;
            this.txtNetRefunds.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetRefunds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNetRefunds.Location = new System.Drawing.Point(194, 124);
            this.txtNetRefunds.Name = "txtNetRefunds";
            this.txtNetRefunds.ReadOnly = true;
            this.txtNetRefunds.Size = new System.Drawing.Size(161, 29);
            this.txtNetRefunds.TabIndex = 33;
            this.txtNetRefunds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(61, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Share Capital";
            // 
            // txtLoanBalance
            // 
            this.txtLoanBalance.Enabled = false;
            this.txtLoanBalance.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLoanBalance.Location = new System.Drawing.Point(194, 89);
            this.txtLoanBalance.Name = "txtLoanBalance";
            this.txtLoanBalance.ReadOnly = true;
            this.txtLoanBalance.Size = new System.Drawing.Size(161, 29);
            this.txtLoanBalance.TabIndex = 31;
            this.txtLoanBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSCapBalance
            // 
            this.txtSCapBalance.Enabled = false;
            this.txtSCapBalance.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCapBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSCapBalance.Location = new System.Drawing.Point(194, 54);
            this.txtSCapBalance.Name = "txtSCapBalance";
            this.txtSCapBalance.ReadOnly = true;
            this.txtSCapBalance.Size = new System.Drawing.Size(161, 29);
            this.txtSCapBalance.TabIndex = 29;
            this.txtSCapBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTimeDep
            // 
            this.txtTimeDep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimeDep.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeDep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimeDep.Location = new System.Drawing.Point(653, 354);
            this.txtTimeDep.Name = "txtTimeDep";
            this.txtTimeDep.ReadOnly = true;
            this.txtTimeDep.Size = new System.Drawing.Size(144, 29);
            this.txtTimeDep.TabIndex = 25;
            this.txtTimeDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSavings
            // 
            this.txtSavings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSavings.Enabled = false;
            this.txtSavings.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSavings.Location = new System.Drawing.Point(653, 319);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.ReadOnly = true;
            this.txtSavings.Size = new System.Drawing.Size(144, 29);
            this.txtSavings.TabIndex = 23;
            this.txtSavings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(432, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Number of Time Deposit/s";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(432, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Number of Savings Account/s";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(17, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reason for Termination";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 45);
            this.label5.TabIndex = 1;
            this.label5.Text = "Member Termination";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Firebrick;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CMS.Properties.Resources.Delete;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(540, 583);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 35);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "&Terminate";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CMS.Properties.Resources.Delete;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(681, 583);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // MemberTermination
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(809, 626);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimeDep);
            this.Controls.Add(this.txtSavings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(825, 665);
            this.Name = "MemberTermination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Termination";
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.RadioButton rbMemberName;
        private System.Windows.Forms.RadioButton rbAccountNo;
        private System.Windows.Forms.TextBox txtSpecify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbROthers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbFDormant;
        private System.Windows.Forms.RadioButton rbFViolation;
        private System.Windows.Forms.RadioButton rbRVoluntary;
        private System.Windows.Forms.RadioButton rbRForced;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbVLeave;
        private System.Windows.Forms.RadioButton rbVIncapable;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSavings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNetRefunds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLoanBalance;
        private System.Windows.Forms.TextBox txtSCapBalance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimeDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}