using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CMS.Utilities.View
{
    public partial class AccountSettings : UserControl
    {
        bool editDetails = false;
        bool editAccount = false;
        byte[] imgData = null;

        public AccountSettings()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            disableUserDetails();
            disableAccountDetails();
            checkPicture();
        }

        public void enableUserDetails()
        {
            txtLastName.Enabled = true;
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
        }

        public void disableUserDetails()
        {
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtMiddleName.Enabled = false;
        }

        public void enableAccountDetails()
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            checkShow.Enabled = true;
        }

        public void disableAccountDetails()
        {
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            checkShow.Enabled = false;
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.CheckState == CheckState.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void linkDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!editDetails)
            {
                editDetails = true;
                linkDetails.Text = "[Cancel]";
                btnSave.Enabled = true;
                enableUserDetails();
            }
            else
            {
                editDetails = false;
                linkDetails.Text = "[Edit]";
                if (!editAccount)
                {
                    btnSave.Enabled = false;
                }
                disableUserDetails();
            }
        }

        private void linkAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!editAccount)
            {
                editAccount = true;
                linkAccount.Text = "[Cancel]";
                btnSave.Enabled = true;
                enableAccountDetails();
            }
            else
            {
                editAccount = false;
                linkAccount.Text = "[Edit]";
                if (!editDetails)
                {
                    btnSave.Enabled = false;
                }
                disableAccountDetails();
            }
        }

        public void setUserDetails(String[] details)
        {
            txtLastName.Text = details[0].ToString();
            txtFirstName.Text = details[1].ToString();
            txtMiddleName.Text = details[2].ToString();
        }

        public String[] getUserDetails()
        {
            String[] details = new String[3];
            details[0] = txtLastName.Text.Trim();
            details[1] = txtFirstName.Text.Trim();
            details[2] = txtMiddleName.Text.Trim();
            return details;
        }

        public void setAccount(String[] account)
        {
            txtUsername.Text = account[0];
            txtPassword.Text = account[1];
        }

        public String[] getAccount()
        {
            String[] account = new String[2];
            account[0] = txtUsername.Text.Trim();
            account[1] = txtPassword.Text.Trim();
            return account;
        }

        public void setPicture(byte[] imgData)
        {
            if (imgData != null)
            {
                Image pictureData;
                using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                {
                    ms.Write(imgData, 0, imgData.Length);
                    pictureData = Image.FromStream(ms, true);
                }
                picture.Image = pictureData;
            }
        }

        public void checkPicture()
        {
            if (picture.Image == null)
            {
                lblPicture.Visible = true;
            }
            else
            {
                lblPicture.Visible = false;
            }
        }

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        private void picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Choose Photo";
            openDialog.Filter = "Image Files (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                this.picture.Image = Image.FromFile(openDialog.FileName);
                String imgPath = openDialog.FileName;
                FileInfo fInfo = new FileInfo(imgPath);
                long numBytes = fInfo.Length;
                FileStream fStream = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                this.imgData = br.ReadBytes((int)numBytes);
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
            openDialog.Dispose();
            checkPicture();
        }

        public byte[] getImgData()
        {
            return this.imgData;
        }

        public void reset()
        {
            btnSave.Enabled = false;
            disableAccountDetails();
            disableUserDetails();
            editDetails = false;
            editAccount = false;
            linkAccount.Text = "[Edit]";
            linkDetails.Text = "[Edit]";
        }
    }
}
