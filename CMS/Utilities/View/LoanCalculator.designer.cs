namespace CMS.Utilities.View
{
    partial class LoanCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanCalculator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateApproved = new System.Windows.Forms.DateTimePicker();
            this.lblDateApproval = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblStatePaymentDuration = new System.Windows.Forms.Label();
            this.cbTerms = new System.Windows.Forms.ComboBox();
            this.cbDurationStatus = new System.Windows.Forms.ComboBox();
            this.udPaymentDuration = new System.Windows.Forms.NumericUpDown();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.cbLoanType = new System.Windows.Forms.ComboBox();
            this.lblTerms = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaturityDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoOfAmortizations = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmortizationAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCharges = new System.Windows.Forms.TextBox();
            this.lblApprovedAmount = new System.Windows.Forms.Label();
            this.txtNetLoan = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanReceivable = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblNetLoan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCharges = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPaymentDuration)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dateApproved);
            this.groupBox1.Controls.Add(this.lblDateApproval);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Controls.Add(this.lblStatePaymentDuration);
            this.groupBox1.Controls.Add(this.cbTerms);
            this.groupBox1.Controls.Add(this.cbDurationStatus);
            this.groupBox1.Controls.Add(this.udPaymentDuration);
            this.groupBox1.Controls.Add(this.txtLoanAmount);
            this.groupBox1.Controls.Add(this.cbLoanType);
            this.groupBox1.Controls.Add(this.lblTerms);
            this.groupBox1.Controls.Add(this.lblDuration);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblLoanType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Details";
            // 
            // dateApproved
            // 
            this.dateApproved.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateApproved.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateApproved.Location = new System.Drawing.Point(102, 98);
            this.dateApproved.Name = "dateApproved";
            this.dateApproved.Size = new System.Drawing.Size(178, 29);
            this.dateApproved.TabIndex = 8;
            // 
            // lblDateApproval
            // 
            this.lblDateApproval.AutoSize = true;
            this.lblDateApproval.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateApproval.Location = new System.Drawing.Point(11, 104);
            this.lblDateApproval.Name = "lblDateApproval";
            this.lblDateApproval.Size = new System.Drawing.Size(45, 21);
            this.lblDateApproval.TabIndex = 7;
            this.lblDateApproval.Text = "Date:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::CMS.Properties.Resources.Cancel;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(442, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 35);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.Green;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Image = global::CMS.Properties.Resources.Compute;
            this.btnCompute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompute.Location = new System.Drawing.Point(321, 136);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(115, 35);
            this.btnCompute.TabIndex = 15;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            // 
            // lblStatePaymentDuration
            // 
            this.lblStatePaymentDuration.AutoSize = true;
            this.lblStatePaymentDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatePaymentDuration.ForeColor = System.Drawing.Color.Green;
            this.lblStatePaymentDuration.Location = new System.Drawing.Point(290, 69);
            this.lblStatePaymentDuration.Name = "lblStatePaymentDuration";
            this.lblStatePaymentDuration.Size = new System.Drawing.Size(43, 17);
            this.lblStatePaymentDuration.TabIndex = 12;
            this.lblStatePaymentDuration.Text = "label1";
            // 
            // cbTerms
            // 
            this.cbTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerms.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTerms.FormattingEnabled = true;
            this.cbTerms.Location = new System.Drawing.Point(368, 98);
            this.cbTerms.Name = "cbTerms";
            this.cbTerms.Size = new System.Drawing.Size(179, 29);
            this.cbTerms.TabIndex = 14;
            // 
            // cbDurationStatus
            // 
            this.cbDurationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurationStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDurationStatus.FormattingEnabled = true;
            this.cbDurationStatus.Items.AddRange(new object[] {
            "week/s",
            "month/s",
            "year/s"});
            this.cbDurationStatus.Location = new System.Drawing.Point(428, 28);
            this.cbDurationStatus.Name = "cbDurationStatus";
            this.cbDurationStatus.Size = new System.Drawing.Size(119, 29);
            this.cbDurationStatus.TabIndex = 11;
            this.cbDurationStatus.SelectedIndexChanged += new System.EventHandler(this.cbDurationStatus_SelectedIndexChanged);
            // 
            // udPaymentDuration
            // 
            this.udPaymentDuration.ContextMenuStrip = this.contextMenuBlank;
            this.udPaymentDuration.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udPaymentDuration.Location = new System.Drawing.Point(368, 28);
            this.udPaymentDuration.Name = "udPaymentDuration";
            this.udPaymentDuration.Size = new System.Drawing.Size(54, 29);
            this.udPaymentDuration.TabIndex = 10;
            this.udPaymentDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.udPaymentDuration_KeyDown);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.ContextMenuStrip = this.contextMenuBlank;
            this.txtLoanAmount.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanAmount.Location = new System.Drawing.Point(101, 63);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(179, 29);
            this.txtLoanAmount.TabIndex = 6;
            this.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLoanAmount.TextChanged += new System.EventHandler(this.txtLoanAmount_TextChanged);
            this.txtLoanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanAmount_KeyPress);
            // 
            // cbLoanType
            // 
            this.cbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoanType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoanType.FormattingEnabled = true;
            this.cbLoanType.Location = new System.Drawing.Point(101, 28);
            this.cbLoanType.Name = "cbLoanType";
            this.cbLoanType.Size = new System.Drawing.Size(179, 29);
            this.cbLoanType.TabIndex = 4;
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerms.Location = new System.Drawing.Point(289, 104);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(56, 21);
            this.lblTerms.TabIndex = 13;
            this.lblTerms.Text = "Terms:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(288, 31);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(74, 21);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "Duration:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(11, 66);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 21);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount:";
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanType.Location = new System.Drawing.Point(11, 31);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(84, 21);
            this.lblLoanType.TabIndex = 3;
            this.lblLoanType.Text = "Loan Type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.lblMaturityDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblNoOfAmortizations);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAmortizationAmount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCharges);
            this.groupBox2.Controls.Add(this.lblApprovedAmount);
            this.groupBox2.Controls.Add(this.txtNetLoan);
            this.groupBox2.Controls.Add(this.txtInterestRate);
            this.groupBox2.Controls.Add(this.txtLoanReceivable);
            this.groupBox2.Controls.Add(this.lblInterestRate);
            this.groupBox2.Controls.Add(this.lblNetLoan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblCharges);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 292);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan Proceeds Breakdown";
            // 
            // lblMaturityDate
            // 
            this.lblMaturityDate.AutoSize = true;
            this.lblMaturityDate.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaturityDate.Location = new System.Drawing.Point(319, 81);
            this.lblMaturityDate.Name = "lblMaturityDate";
            this.lblMaturityDate.Size = new System.Drawing.Size(51, 21);
            this.lblMaturityDate.TabIndex = 23;
            this.lblMaturityDate.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Maturity Date:";
            // 
            // lblNoOfAmortizations
            // 
            this.lblNoOfAmortizations.AutoSize = true;
            this.lblNoOfAmortizations.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfAmortizations.Location = new System.Drawing.Point(319, 25);
            this.lblNoOfAmortizations.Name = "lblNoOfAmortizations";
            this.lblNoOfAmortizations.Size = new System.Drawing.Size(51, 21);
            this.lblNoOfAmortizations.TabIndex = 19;
            this.lblNoOfAmortizations.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "No. of Amortizations:";
            // 
            // txtAmortizationAmount
            // 
            this.txtAmortizationAmount.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmortizationAmount.Location = new System.Drawing.Point(323, 49);
            this.txtAmortizationAmount.MaxLength = 20;
            this.txtAmortizationAmount.Name = "txtAmortizationAmount";
            this.txtAmortizationAmount.ReadOnly = true;
            this.txtAmortizationAmount.Size = new System.Drawing.Size(148, 29);
            this.txtAmortizationAmount.TabIndex = 21;
            this.txtAmortizationAmount.Text = "0.00";
            this.txtAmortizationAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Amortization Amount:";
            // 
            // txtCharges
            // 
            this.txtCharges.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharges.Location = new System.Drawing.Point(371, 165);
            this.txtCharges.Name = "txtCharges";
            this.txtCharges.ReadOnly = true;
            this.txtCharges.Size = new System.Drawing.Size(100, 25);
            this.txtCharges.TabIndex = 29;
            this.txtCharges.Text = "0.00";
            this.txtCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCharges.TextChanged += new System.EventHandler(this.txtLoanReceivable_TextChanged);
            // 
            // lblApprovedAmount
            // 
            this.lblApprovedAmount.AutoSize = true;
            this.lblApprovedAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovedAmount.Location = new System.Drawing.Point(41, 133);
            this.lblApprovedAmount.Name = "lblApprovedAmount";
            this.lblApprovedAmount.Size = new System.Drawing.Size(132, 21);
            this.lblApprovedAmount.TabIndex = 25;
            this.lblApprovedAmount.Text = "Loan Receivable:";
            // 
            // txtNetLoan
            // 
            this.txtNetLoan.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetLoan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNetLoan.Location = new System.Drawing.Point(323, 256);
            this.txtNetLoan.Name = "txtNetLoan";
            this.txtNetLoan.ReadOnly = true;
            this.txtNetLoan.Size = new System.Drawing.Size(148, 29);
            this.txtNetLoan.TabIndex = 35;
            this.txtNetLoan.Text = "0.00";
            this.txtNetLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(371, 196);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.ReadOnly = true;
            this.txtInterestRate.Size = new System.Drawing.Size(100, 25);
            this.txtInterestRate.TabIndex = 31;
            this.txtInterestRate.Text = "0.00";
            this.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInterestRate.TextChanged += new System.EventHandler(this.txtLoanReceivable_TextChanged);
            // 
            // txtLoanReceivable
            // 
            this.txtLoanReceivable.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanReceivable.Location = new System.Drawing.Point(323, 130);
            this.txtLoanReceivable.MaxLength = 20;
            this.txtLoanReceivable.Name = "txtLoanReceivable";
            this.txtLoanReceivable.ReadOnly = true;
            this.txtLoanReceivable.Size = new System.Drawing.Size(148, 29);
            this.txtLoanReceivable.TabIndex = 26;
            this.txtLoanReceivable.Text = "0.00";
            this.txtLoanReceivable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLoanReceivable.TextChanged += new System.EventHandler(this.txtLoanReceivable_TextChanged);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.Location = new System.Drawing.Point(118, 199);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(50, 17);
            this.lblInterestRate.TabIndex = 30;
            this.lblInterestRate.Text = "Interest:";
            // 
            // lblNetLoan
            // 
            this.lblNetLoan.AutoSize = true;
            this.lblNetLoan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetLoan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNetLoan.Location = new System.Drawing.Point(41, 259);
            this.lblNetLoan.Name = "lblNetLoan";
            this.lblNetLoan.Size = new System.Drawing.Size(152, 21);
            this.lblNetLoan.TabIndex = 34;
            this.lblNetLoan.Text = "Net Loan Proceeds:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 30.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(25, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(500, 55);
            this.label6.TabIndex = 32;
            this.label6.Text = "____________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "less:";
            // 
            // lblCharges
            // 
            this.lblCharges.AutoSize = true;
            this.lblCharges.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharges.Location = new System.Drawing.Point(118, 168);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(55, 17);
            this.lblCharges.TabIndex = 28;
            this.lblCharges.Text = "Charges:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 30.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(25, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(500, 55);
            this.label8.TabIndex = 24;
            this.label8.Text = "____________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 30.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 55);
            this.label4.TabIndex = 33;
            this.label4.Text = "____________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loan Calculator";
            // 
            // LoanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoanCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPaymentDuration)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.ComboBox cbLoanType;
        private System.Windows.Forms.ComboBox cbDurationStatus;
        private System.Windows.Forms.NumericUpDown udPaymentDuration;
        private System.Windows.Forms.ComboBox cbTerms;
        public System.Windows.Forms.Label lblStatePaymentDuration;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblApprovedAmount;
        private System.Windows.Forms.TextBox txtNetLoan;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtLoanReceivable;
        private System.Windows.Forms.Label lblInterestRate;
        public System.Windows.Forms.Label lblNetLoan;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCharges;
        private System.Windows.Forms.TextBox txtCharges;
        private System.Windows.Forms.TextBox txtAmortizationAmount;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        public System.Windows.Forms.Label lblTerms;
        public System.Windows.Forms.Label lblDuration;
        public System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.Label lblNoOfAmortizations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateApproved;
        private System.Windows.Forms.Label lblDateApproval;
        private System.Windows.Forms.Label lblMaturityDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}