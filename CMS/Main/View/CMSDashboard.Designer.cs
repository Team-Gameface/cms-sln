namespace CMS.Main.View
{
    partial class CMSDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMSDashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSwitchboard = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLoanManagement = new System.Windows.Forms.Button();
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnUtilities = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.linkSignout = new System.Windows.Forms.LinkLabel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.autoCollapse = new System.Windows.Forms.CheckBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelCompany = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelSwitchboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.statusMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LimeGreen;
            this.panelMenu.Controls.Add(this.panelSwitchboard);
            this.panelMenu.Controls.Add(this.linkSignout);
            this.panelMenu.Controls.Add(this.lblUserRole);
            this.panelMenu.Controls.Add(this.lblUser);
            this.panelMenu.Controls.Add(this.btnShow);
            this.panelMenu.Controls.Add(this.autoCollapse);
            this.panelMenu.Controls.Add(this.pictureUser);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(611, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(173, 729);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.MouseEnter += new System.EventHandler(this.panelMenu_MouseEnter);
            // 
            // panelSwitchboard
            // 
            this.panelSwitchboard.Controls.Add(this.btnHome);
            this.panelSwitchboard.Controls.Add(this.btnLoanManagement);
            this.panelSwitchboard.Controls.Add(this.btnSavings);
            this.panelSwitchboard.Controls.Add(this.btnPayments);
            this.panelSwitchboard.Controls.Add(this.btnUtilities);
            this.panelSwitchboard.Controls.Add(this.btnSettings);
            this.panelSwitchboard.Location = new System.Drawing.Point(19, 198);
            this.panelSwitchboard.Name = "panelSwitchboard";
            this.panelSwitchboard.Size = new System.Drawing.Size(148, 469);
            this.panelSwitchboard.TabIndex = 11;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 70);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnLoanManagement
            // 
            this.btnLoanManagement.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLoanManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoanManagement.FlatAppearance.BorderSize = 0;
            this.btnLoanManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanManagement.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanManagement.ForeColor = System.Drawing.Color.White;
            this.btnLoanManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnLoanManagement.Image")));
            this.btnLoanManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoanManagement.Location = new System.Drawing.Point(3, 79);
            this.btnLoanManagement.Name = "btnLoanManagement";
            this.btnLoanManagement.Size = new System.Drawing.Size(142, 70);
            this.btnLoanManagement.TabIndex = 13;
            this.btnLoanManagement.Text = "Loan Management";
            this.btnLoanManagement.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLoanManagement.UseVisualStyleBackColor = false;
            // 
            // btnSavings
            // 
            this.btnSavings.BackColor = System.Drawing.Color.Firebrick;
            this.btnSavings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSavings.FlatAppearance.BorderSize = 0;
            this.btnSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavings.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavings.ForeColor = System.Drawing.Color.White;
            this.btnSavings.Image = ((System.Drawing.Image)(resources.GetObject("btnSavings.Image")));
            this.btnSavings.Location = new System.Drawing.Point(3, 155);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(142, 70);
            this.btnSavings.TabIndex = 14;
            this.btnSavings.Text = "Savings";
            this.btnSavings.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSavings.UseVisualStyleBackColor = false;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.IndianRed;
            this.btnPayments.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnPayments.Image")));
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPayments.Location = new System.Drawing.Point(3, 231);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(142, 70);
            this.btnPayments.TabIndex = 15;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPayments.UseVisualStyleBackColor = false;
            // 
            // btnUtilities
            // 
            this.btnUtilities.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUtilities.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUtilities.FlatAppearance.BorderSize = 0;
            this.btnUtilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilities.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilities.ForeColor = System.Drawing.Color.White;
            this.btnUtilities.Image = ((System.Drawing.Image)(resources.GetObject("btnUtilities.Image")));
            this.btnUtilities.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUtilities.Location = new System.Drawing.Point(3, 307);
            this.btnUtilities.Name = "btnUtilities";
            this.btnUtilities.Size = new System.Drawing.Size(142, 70);
            this.btnUtilities.TabIndex = 16;
            this.btnUtilities.Text = "Utilities";
            this.btnUtilities.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUtilities.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(3, 383);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(142, 70);
            this.btnSettings.TabIndex = 17;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // linkSignout
            // 
            this.linkSignout.AutoSize = true;
            this.linkSignout.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignout.ForeColor = System.Drawing.Color.White;
            this.linkSignout.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkSignout.Location = new System.Drawing.Point(112, 178);
            this.linkSignout.Name = "linkSignout";
            this.linkSignout.Size = new System.Drawing.Size(57, 17);
            this.linkSignout.TabIndex = 10;
            this.linkSignout.TabStop = true;
            this.linkSignout.Text = "Sign Out";
            // 
            // lblUserRole
            // 
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserRole.Location = new System.Drawing.Point(28, 148);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(142, 26);
            this.lblUserRole.TabIndex = 9;
            this.lblUserRole.Text = "User Type";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(9, 111);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(161, 37);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "USER NAME";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = global::CMS.Properties.Resources.Next;
            this.btnShow.Location = new System.Drawing.Point(0, 673);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(30, 30);
            this.btnShow.TabIndex = 18;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // autoCollapse
            // 
            this.autoCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoCollapse.AutoSize = true;
            this.autoCollapse.Checked = true;
            this.autoCollapse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoCollapse.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCollapse.ForeColor = System.Drawing.Color.White;
            this.autoCollapse.Location = new System.Drawing.Point(6, 709);
            this.autoCollapse.Name = "autoCollapse";
            this.autoCollapse.Size = new System.Drawing.Size(101, 19);
            this.autoCollapse.TabIndex = 19;
            this.autoCollapse.Text = "Auto-Collapse";
            this.autoCollapse.UseVisualStyleBackColor = true;
            this.autoCollapse.CheckStateChanged += new System.EventHandler(this.autoCollapse_CheckStateChanged);
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.SystemColors.Control;
            this.pictureUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureUser.Location = new System.Drawing.Point(71, 12);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(96, 96);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 18;
            this.pictureUser.TabStop = false;
            // 
            // statusMain
            // 
            this.statusMain.BackColor = System.Drawing.Color.ForestGreen;
            this.statusMain.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.lblDateTime});
            this.statusMain.Location = new System.Drawing.Point(0, 694);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(611, 35);
            this.statusMain.TabIndex = 3;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 29);
            // 
            // lblDateTime
            // 
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(494, 30);
            this.lblDateTime.Spring = true;
            this.lblDateTime.Text = "DateTime";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(138, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "(Savings and Loan Management)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(137, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cooperative Management System";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI Semibold", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(137, 3);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(453, 68);
            this.lblCompanyName.TabIndex = 11;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.ForestGreen;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelCompany);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelHome);
            this.splitContainer.Panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer.Size = new System.Drawing.Size(611, 694);
            this.splitContainer.SplitterDistance = 139;
            this.splitContainer.TabIndex = 17;
            // 
            // panelCompany
            // 
            this.panelCompany.BackColor = System.Drawing.Color.ForestGreen;
            this.panelCompany.Controls.Add(this.pictureLogo);
            this.panelCompany.Controls.Add(this.label3);
            this.panelCompany.Controls.Add(this.lblCompanyName);
            this.panelCompany.Controls.Add(this.label2);
            this.panelCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCompany.Location = new System.Drawing.Point(0, 0);
            this.panelCompany.Name = "panelCompany";
            this.panelCompany.Size = new System.Drawing.Size(611, 139);
            this.panelCompany.TabIndex = 1;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(128, 128);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 12;
            this.pictureLogo.TabStop = false;
            // 
            // panelHome
            // 
            this.panelHome.AutoScroll = true;
            this.panelHome.BackColor = System.Drawing.Color.Honeydew;
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(611, 551);
            this.panelHome.TabIndex = 0;
            // 
            // CMSDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 729);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 766);
            this.Name = "CMSDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cooperative Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelSwitchboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelCompany.ResumeLayout(false);
            this.panelCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLoanManagement;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox autoCollapse;
        private System.Windows.Forms.LinkLabel linkSignout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Panel panelCompany;
        private System.Windows.Forms.Button btnUtilities;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.FlowLayoutPanel panelSwitchboard;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;

    }
}