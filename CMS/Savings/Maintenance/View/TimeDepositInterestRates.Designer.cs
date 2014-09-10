namespace CMS.Savings.Maintenance.View
{
    partial class TimeDepositInterestRates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeDepositInterestRates));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.txtMaxBal = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtMinBal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.CheckBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.dataInterestRates = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInterestRates)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numDays);
            this.groupBox1.Controls.Add(this.lblDays);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPercent);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.txtInterestRate);
            this.groupBox1.Controls.Add(this.lblInterestRate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Time Deposit Interest Rate";
            // 
            // numDays
            // 
            this.numDays.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDays.Location = new System.Drawing.Point(122, 55);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(92, 25);
            this.numDays.TabIndex = 22;
            this.numDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDays.Location = new System.Drawing.Point(14, 58);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(80, 19);
            this.lblDays.TabIndex = 8;
            this.lblDays.Text = "No of Days:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(468, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(374, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaximum);
            this.groupBox2.Controls.Add(this.lblMinimum);
            this.groupBox2.Controls.Add(this.txtMaxBal);
            this.groupBox2.Controls.Add(this.txtMinBal);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(252, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 99);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance Range";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaximum.Location = new System.Drawing.Point(34, 63);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(73, 19);
            this.lblMaximum.TabIndex = 16;
            this.lblMaximum.Text = "Maximum:";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMinimum.Location = new System.Drawing.Point(34, 30);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(71, 19);
            this.lblMinimum.TabIndex = 14;
            this.lblMinimum.Text = "Minimum:";
            // 
            // txtMaxBal
            // 
            this.txtMaxBal.ContextMenuStrip = this.contextMenuBlank;
            this.txtMaxBal.Enabled = false;
            this.txtMaxBal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaxBal.Location = new System.Drawing.Point(128, 60);
            this.txtMaxBal.MaxLength = 25;
            this.txtMaxBal.Name = "txtMaxBal";
            this.txtMaxBal.Size = new System.Drawing.Size(161, 25);
            this.txtMaxBal.TabIndex = 17;
            this.txtMaxBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxBal.TextChanged += new System.EventHandler(this.txtMaxBal_TextChanged);
            this.txtMaxBal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxBal_KeyDown);
            this.txtMaxBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxBal_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // txtMinBal
            // 
            this.txtMinBal.ContextMenuStrip = this.contextMenuBlank;
            this.txtMinBal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMinBal.Location = new System.Drawing.Point(128, 27);
            this.txtMinBal.MaxLength = 25;
            this.txtMinBal.Name = "txtMinBal";
            this.txtMinBal.Size = new System.Drawing.Size(161, 25);
            this.txtMinBal.TabIndex = 15;
            this.txtMinBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinBal.TextChanged += new System.EventHandler(this.txtMinBal_TextChanged);
            this.txtMinBal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinBal_KeyDown);
            this.txtMinBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinBal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(18, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Status:";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPercent.Location = new System.Drawing.Point(218, 89);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(20, 19);
            this.lblPercent.TabIndex = 12;
            this.lblPercent.Text = "%";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Status.Location = new System.Drawing.Point(85, 144);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(65, 23);
            this.Status.TabIndex = 19;
            this.Status.Text = "Active";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.ContextMenuStrip = this.contextMenuBlank;
            this.txtInterestRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInterestRate.Location = new System.Drawing.Point(122, 86);
            this.txtInterestRate.MaxLength = 7;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(92, 25);
            this.txtInterestRate.TabIndex = 11;
            this.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInterestRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInterestRate_KeyDown);
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestRate_KeyPress);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInterestRate.Location = new System.Drawing.Point(14, 89);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(90, 19);
            this.lblInterestRate.TabIndex = 10;
            this.lblInterestRate.Text = "Interest Rate:";
            // 
            // dataInterestRates
            // 
            this.dataInterestRates.AllowUserToAddRows = false;
            this.dataInterestRates.AllowUserToDeleteRows = false;
            this.dataInterestRates.AllowUserToResizeRows = false;
            this.dataInterestRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataInterestRates.BackgroundColor = System.Drawing.Color.Silver;
            this.dataInterestRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInterestRates.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataInterestRates.Location = new System.Drawing.Point(12, 71);
            this.dataInterestRates.MultiSelect = false;
            this.dataInterestRates.Name = "dataInterestRates";
            this.dataInterestRates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInterestRates.Size = new System.Drawing.Size(570, 171);
            this.dataInterestRates.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Maintenance - Time Deposit Terms and Rates";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(9, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(153, 19);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search by Interest Rate:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(226, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(356, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(382, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(480, 248);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // TimeDepositInterestRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(594, 471);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataInterestRates);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(610, 510);
            this.Name = "TimeDepositInterestRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Deposit Terms and Rates";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInterestRates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.DataGridView dataInterestRates;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.TextBox txtMaxBal;
        private System.Windows.Forms.TextBox txtMinBal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown numDays;
    }
}