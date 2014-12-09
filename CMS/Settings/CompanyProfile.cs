using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace CMS.Settings
{
    public partial class CompanyProfile : UserControl
    {
        Main.Logger logger = new Main.Logger();
        byte[] imgData = null;
        Main.View.CMSDashboard cms;
        Main.View.Settings settings;

        public CompanyProfile(Main.View.Settings settings, Main.View.CMSDashboard cms)
        {
            this.settings = settings;
            this.cms = cms;
            imgData = Main.CompanyData.CompanyLogo;
            InitializeComponent();
            setCompanyData();
            checkLogo();
        }

        public void setCompanyData()
        {
            if (Main.CompanyData.CompanyName != String.Empty)
            {
                txtCompanyName.Text = Main.CompanyData.CompanyName;
            }
            if (Main.CompanyData.AcreditationNo != String.Empty)
            {
                txtAccreditation.Text = Main.CompanyData.AcreditationNo;
            }
            if (Main.CompanyData.CompanyAddress != String.Empty)
            {
                txtCompanyAddress.Text = Main.CompanyData.CompanyAddress;
            }
            if (Main.CompanyData.TelephoneNo != String.Empty)
            {
                txtTelephone.Text = Main.CompanyData.TelephoneNo;
            }
            if (Main.CompanyData.CellphoneNo != String.Empty)
            {
                txtCellphone.Text = Main.CompanyData.CellphoneNo;
            }
            if (Main.CompanyData.Email != String.Empty)
            {
                txtEmail.Text = Main.CompanyData.Email;
            }
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

        public void checkLogo()
        {
            if (pictureLogo.Image == null)
            {
                lblPicture.Visible = true;
            }
            else
            {
                lblPicture.Visible = false;
            }
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Choose Photo";
            openDialog.Filter = "Image Files (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureLogo.Image = Image.FromFile(openDialog.FileName);
                String imgPath = openDialog.FileName;
                FileInfo fInfo = new FileInfo(imgPath);
                long numBytes = fInfo.Length;
                FileStream fStream = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                this.imgData = br.ReadBytes((int)numBytes);
            }
            openDialog.Dispose();
            checkLogo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean checkName = false;
            Boolean checkAddress = false;
            String errorMessage = "Update Failed!" + Environment.NewLine + Environment.NewLine;
            if (txtCompanyName.Text.Trim() == String.Empty)
            {
                checkName = false;
            }
            else
            {
                checkName = true;
            }
            if (txtCompanyAddress.Text.Trim() == String.Empty)
            {
                checkAddress = false;
            }
            else
            {
                checkAddress = true;
            }
            if (checkName && checkAddress)
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "UPDATE COMPANY SET Status = 0";
                int result = dal.executeNonQuery(sql);
                Dictionary<String, Object> parameters = new Dictionary<string, object>();
                if (imgData != null)
                {
                    sql = "EXEC insertCompany @CompanyName, @AccreditationNo, @CompanyAddress, @CompanyLogo, @Telephone, @Cellphone, @Email";
                    parameters.Add("@CompanyName", txtCompanyName.Text.Trim());
                    parameters.Add("@AccreditationNo", txtAccreditation.Text.Trim());
                    parameters.Add("@CompanyAddress", txtCompanyAddress.Text.Trim());
                    parameters.Add("@CompanyLogo", this.imgData);
                    parameters.Add("@Telephone", txtTelephone.Text.Trim());
                    parameters.Add("@Cellphone", txtCellphone.Text.Trim());
                    parameters.Add("@Email", txtEmail.Text.Trim());
                }
                else
                {
                    sql = "EXEC insertCompanyNoLogo @CompanyName, @AccreditationNo, @CompanyAddress, @Telephone, @Cellphone, @Email";
                    parameters.Add("@CompanyName", txtCompanyName.Text.Trim());
                    parameters.Add("@AccreditationNo", txtAccreditation.Text.Trim());
                    parameters.Add("@CompanyAddress", txtCompanyAddress.Text.Trim());
                    parameters.Add("@Telephone", txtTelephone.Text.Trim());
                    parameters.Add("@Cellphone", txtCellphone.Text.Trim());
                    parameters.Add("@Email", txtEmail.Text.Trim());
                }
                result = dal.executeNonQuery(sql, parameters);
                if (result != 0)
                {
                    MessageBox.Show("Company Profile Save Sucess.", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateCompanyData();
                    execLogger("Update");
                }
                else
                {
                    MessageBox.Show("Company Profile Save Failed.", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dal.Close();
            }
            else
            {
                MessageBox.Show(errorMessage, "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void updateCompanyData()
        {
            Main.CompanyData.CompanyName = txtCompanyName.Text.ToString();
            Main.CompanyData.AcreditationNo = txtAccreditation.Text.ToString();
            Main.CompanyData.CompanyAddress = txtCompanyAddress.Text.ToString();
            Main.CompanyData.CompanyLogo = imgData;
            Main.CompanyData.TelephoneNo = txtTelephone.Text.ToString();
            Main.CompanyData.CellphoneNo = txtCellphone.Text.ToString();
            Main.CompanyData.Email = txtEmail.Text.ToString();
            this.cms.setCompanyData();
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Settings - Company Profile";
            logger.Activity = ModuleActivity;
            if (logger.insertLog() > 0)
            {
                Console.WriteLine("Logged");
            }
            else
            {
                Console.WriteLine("Not Logged");
            }
        }
    }
}
