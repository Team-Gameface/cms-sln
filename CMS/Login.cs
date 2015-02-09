using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace CMS
{
    public partial class Login : Form, IDisposable
    {
        Main.Logger logger = new Main.Logger();

        public Login()
        {
            if (checkConnection())
            {
                InitializeComponent();
                checkCompanyProfile();
                setCompanyData();
                lblInvalid.Visible = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Database Connection is Not Configured Correctly. Configure Now?" + Environment.NewLine + "Contact System Administrator for Configuration.", "Cooperative Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    new ConnectionManager().ShowDialog();
                }
                else
                {
                    this.Dispose();
                    Environment.Exit(0);
                }
            }
        }

        public Boolean checkConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                con.Open();
                if (ConfigurationManager.ConnectionStrings["CMS"].ConnectionString == String.Empty)
                {
                    return false;
                }
                else
                {
                    if (con.State != ConnectionState.Open)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void checkCompanyProfile()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT CompanyName, AccreditationNo, CompanyAddress, CompanyLogo, Telephone, Cellphone, Email FROM COMPANY WHERE Status = 1";
            SqlDataReader reader = dal.executeReader(sql);
            while(reader.Read())
            {
                Main.CompanyData.CompanyName = reader[0].ToString();
                Main.CompanyData.AcreditationNo = reader[1].ToString();
                Main.CompanyData.CompanyAddress = reader[2].ToString();
                try
                {
                    Main.CompanyData.CompanyLogo = (byte[])reader[3];
                }
                catch(Exception)
                {
                    Main.CompanyData.CompanyLogo = null;
                }
                Main.CompanyData.TelephoneNo = reader[4].ToString();
                Main.CompanyData.CellphoneNo = reader[5].ToString();
                Main.CompanyData.Email = reader[6].ToString();
            }
            reader.Close();
            dal.Close();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                conn.Open();

                SqlCommand command = new SqlCommand();
                command = conn.CreateCommand();
                command.CommandText = @"SELECT UserId, FirstName, MiddleName, LastName, Position, UserType, Username, Password, Picture FROM SYSTEM_USERS WHERE Username = @username AND Password = @password";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                SqlDataReader rd = command.ExecuteReader();
                if (rd.HasRows)
                {
                    lblInvalid.Visible = false;
                    MessageBox.Show("Login Success.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    rd.Read();
                    Main.UserData.userId = rd.GetString(0).ToString();
                    Main.UserData.userFirst = rd.GetString(1).ToString();
                    Main.UserData.userMiddle = rd.GetString(2).ToString();
                    Main.UserData.userLast = rd.GetString(3).ToString();
                    Main.UserData.userPosition = rd.GetString(4).ToString();
                    Main.UserData.userAccountType = rd.GetString(5).ToString();
                    Main.UserData.username = rd.GetString(6).ToString();
                    Main.UserData.password = rd.GetString(7).ToString();
                    if (rd[8].ToString() != String.Empty)
                    {
                        Main.UserData.picture = (byte[])rd[8];
                    }
                    execLogger("User Log In");
                    new Main.Controller.MainController(new Main.View.CMSDashboard());
                    this.Dispose();
                }
                else
                {
                    lblInvalid.Visible = true;
                }
                rd.Close();
                conn.Close();
            }
            catch (SqlException)
            {
                lblInvalid.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Login";
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
