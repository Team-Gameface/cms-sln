using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Main.View
{
    public partial class CompanyProfile : Form
    {
        byte[] imgData = null;

        public CompanyProfile()
        {
            InitializeComponent();
            setCompanyData();
            checkLogo();
        }

        public void setCompanyData()
        {
            txtCompanyName.Text = Main.CompanyData.CompanyName;
            txtAccreditation.Text = Main.CompanyData.AcreditationNo;
            txtCompanyAddress.Text = Main.CompanyData.CompanyAddress;
            txtTelephone.Text = Main.CompanyData.TelephoneNo;
            txtCellphone.Text = Main.CompanyData.CellphoneNo;
            txtEmail.Text = Main.CompanyData.Email;
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
            if (txtCompanyName.Text == String.Empty)
            {
                MessageBox.Show("Please Specify Company Name.", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "UPDATE COMPANY SET Status = 0";
                int result = dal.executeNonQuery(sql);
                sql = "EXEC insertCompany @CompanyName, @AccreditationNo, @CompanyAddress, @CompanyLogo, @Telephone, @Cellphone, @Email";
                Dictionary<String, Object> parameters = new Dictionary<string, object>();
                parameters.Add("@CompanyName", txtCompanyName.Text);
                parameters.Add("@AccreditationNo", txtAccreditation.Text);
                parameters.Add("@CompanyAddress", txtCompanyAddress.Text);
                parameters.Add("@CompanyLogo", imgData);
                parameters.Add("@Telephone", txtTelephone.Text);
                parameters.Add("@Cellphone", txtCellphone.Text);
                parameters.Add("@Email", txtEmail.Text);
                result = dal.executeNonQuery(sql, parameters);
                if (result != 0)
                {
                    MessageBox.Show("Company Profile Save Sucess.", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Company Profile Save Failed.", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
