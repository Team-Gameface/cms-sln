using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Main.View
{
    public partial class CMSDashboard : Form
    {
        Boolean isExpanded = true;
        Boolean isAutoCollapse = true;

        Main.View.PaymentForm paymentForm = new Main.View.PaymentForm();

        public CMSDashboard()
        {
            InitializeComponent();
            paymentForm = new Main.View.PaymentForm();
            paymentForm.Dock = DockStyle.Fill;
            splitContainer.Panel2.Controls.Add(paymentForm);
            paymentForm.Hide();
            setCompanyData();
            setAccess();
        }

        public void setAccess()
        {
            if (Main.UserData.userAccountType == "Staff")
            {
                this.panelSwitchboard.Controls.Remove(btnSettings);
            }
        }

        public void setCompanyData()
        {
            String companyName = Main.CompanyData.CompanyName;
            if (companyName != String.Empty)
            {
                lblCompanyName.Text = companyName;
            }
            else
            {
                lblCompanyName.Text = "Company Name";
            }
            byte[] imgData = Main.CompanyData.CompanyLogo;
            if (imgData != null)
            {
                Image picture;
                using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                {
                    ms.Write(imgData, 0, imgData.Length);
                    picture = Image.FromStream(ms, true);
                }
                pictureLogo.Image = picture;
            }
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToString("h:mm:ss tt"); 
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!isExpanded)
            {
                btnShow.Text = ">";
                panelMenu.Width = 173;
                isExpanded = true;
            }
            else
            {
                btnShow.Text = "<";
                panelMenu.Width = 25;
                isExpanded = false;
            }
        }

        private void autoCollapse_CheckStateChanged(object sender, EventArgs e)
        {
            if (autoCollapse.CheckState == CheckState.Checked)
            {
                isAutoCollapse = true;
            }
            if (autoCollapse.CheckState == CheckState.Unchecked)
            {
                isAutoCollapse = false;
            }
        }

        private void panelMenu_MouseEnter(object sender, EventArgs e)
        {
            if (isAutoCollapse)
            {
                btnShow.Text = ">";
                panelMenu.Width = 173;
                isExpanded = true;
            }
        }

        public void setUserName(String s)
        {
            this.lblUser.Text = s;            
        }

        public void setRole(String s) {
            this.lblUserRole.Text = s;
        }

        public void setPictureUser()
        {
            byte[] imgData = Main.UserData.picture;
            if (imgData != null)
            {
                Image picture;
                using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                {
                    ms.Write(imgData, 0, imgData.Length);
                    picture = Image.FromStream(ms, true);
                }
                pictureUser.Image = picture;
            }
        }

        public void setBtnHomeEventHandler(EventHandler e)
        {
            this.btnHome.Click += e;
        }

        public void setBtnPaymentsEventHandler(EventHandler e)
        {
            this.btnPayments.Click += e;
        }

        public void setBtnSavingsEventHandler(EventHandler e)
        {
            this.btnSavings.Click += e;
        }

        public void setBtnLoanManagementEventHandler(EventHandler e)
        {
            this.btnLoanManagement.Click += e;
        }

        public void setBtnUtitilitiesEventHandler(EventHandler e)
        {
            this.btnUtilities.Click += e;
        }

        public void setBtnSettingsEventHandler(EventHandler e)
        {
            this.btnSettings.Click += e;
        }

        public void setLinkSignOutEventHandler(EventHandler e)
        {
            this.linkSignout.Click += e;
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.paymentForm.Hide();
            this.panelHome.Show();
        }

        public void setPanel2(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            splitContainer.Panel2.Controls.Add(uc);
            panelHome.Hide();
            uc.Show();
        }

        public void CMS_FormClosing(FormClosingEventHandler e)
        {
            this.FormClosing += e;
        }
    }
}
