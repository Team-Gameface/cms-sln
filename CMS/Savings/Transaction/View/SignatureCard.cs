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

namespace CMS.Savings.Transaction.View
{
    public partial class SignatureCard : Form
    {
        String AccountNo = String.Empty;

        public SignatureCard(String AccountNo)
        {
            this.AccountNo = AccountNo;
            InitializeComponent();
            txtAccountNo.Text = AccountNo;
            setData();
        }

        public void setData()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS 'Name', CONCAT(AddressNo, ' ', AddressStreet, ', ', AddressBarangay, ', ', AddressCity, ', ', AddressProvince, ', ', AddressZipCode) AS 'Address', BirthDate, Gender, TelephoneNo, CellphoneNo, EmailAddress, Picture, AcctHolderSign1, AcctHolderSign2, AcctHolderSign3, GuardianSign1, GuardianSign2, GuardianSign3 FROM MEMBER WHERE AccountNo = @AccountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", this.AccountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            while (read.Read())
            {
                txtName.Text = read[0].ToString();
                txtAddress.Text = read[1].ToString();
                dateBirth.Value = DateTime.Parse(read[2].ToString());
                txtGender.Text = read[3].ToString();
                String telephone = read[4].ToString();
                if (telephone != String.Empty)
                {
                    txtLandline.Text = telephone;
                }
                else
                {
                    txtLandline.Text = "None";
                }
                String cellphone = read[5].ToString();
                if (cellphone != String.Empty)
                {
                    txtMobile.Text = cellphone;
                }
                else
                {
                    txtMobile.Text = "None";
                }
                String email = read[6].ToString();
                if (email != String.Empty)
                {
                    txtEmail.Text = email;
                }
                else
                {
                    txtEmail.Text = "None";
                }
                try
                {
                    byte[] pictureData = (byte[])read[7];
                    if (pictureData != null)
                    {
                        Image picture;
                        using (MemoryStream ms = new MemoryStream(pictureData, 0, pictureData.Length))
                        {
                            ms.Write(pictureData, 0, pictureData.Length);
                            picture = Image.FromStream(ms, true);
                        }
                        imgPicture.Image = picture;
                    }
                    byte[] accountHolderData1 = (byte[])read[8];
                    if (accountHolderData1 != null)
                    {
                        Image picture;
                        using (MemoryStream ms = new MemoryStream(accountHolderData1, 0, accountHolderData1.Length))
                        {
                            ms.Write(accountHolderData1, 0, accountHolderData1.Length);
                            picture = Image.FromStream(ms, true);
                        }
                        imgSignature1.Image = picture;
                    }
                    byte[] accountHolderData2 = (byte[])read[9];
                    if (accountHolderData2 != null)
                    {
                        Image picture;
                        using (MemoryStream ms = new MemoryStream(accountHolderData2, 0, accountHolderData2.Length))
                        {
                            ms.Write(accountHolderData2, 0, accountHolderData2.Length);
                            picture = Image.FromStream(ms, true);
                        }
                        imgSignature2.Image = picture;
                    }
                    byte[] accountHolderData3 = (byte[])read[10];
                    if (accountHolderData3 != null)
                    {
                        Image picture;
                        using (MemoryStream ms = new MemoryStream(accountHolderData3, 0, accountHolderData3.Length))
                        {
                            ms.Write(accountHolderData3, 0, accountHolderData3.Length);
                            picture = Image.FromStream(ms, true);
                        }
                        imgSignature3.Image = picture;
                    }
                    byte[] guardianData1 = (byte[])read[11];
                    if (guardianData1 != null)
                    {
                        Image picture;
                        using (MemoryStream ms = new MemoryStream(guardianData1, 0, guardianData1.Length))
                        {
                            ms.Write(guardianData1, 0, guardianData1.Length);
                            picture = Image.FromStream(ms, true);
                        }
                        imgSignature1.Image = picture;
                    }
                    byte[] guardianData2 = (byte[])read[12];
                    if (guardianData2 != null)
                    {
                        Image picture;
                        using (MemoryStream ms = new MemoryStream(guardianData2, 0, guardianData2.Length))
                        {
                            ms.Write(guardianData2, 0, guardianData2.Length);
                            picture = Image.FromStream(ms, true);
                        }
                        imgSignature2.Image = picture;
                    }
                    byte[] guardianData3 = (byte[])read[13];
                    if (guardianData3 != null)
                    {
                        Image picture;
                        using (MemoryStream ms = new MemoryStream(guardianData3, 0, guardianData3.Length))
                        {
                            ms.Write(guardianData3, 0, guardianData3.Length);
                            picture = Image.FromStream(ms, true);
                        }
                        imgSignature3.Image = picture;
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
