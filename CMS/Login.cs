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
        public Login()
        {
            InitializeComponent();
            checkCompanyProfile();
            setCompanyData();
        }

        public void checkCompanyProfile()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT * FROM COMPANY WHERE Status = 1";
            SqlDataReader reader = dal.executeReader(sql);
            while(reader.Read())
            {
                Main.CompanyData.CompanyName = reader[1].ToString();
                Main.CompanyData.AcreditationNo = reader[2].ToString();
                Main.CompanyData.CompanyAddress = reader[3].ToString();
                Main.CompanyData.CompanyLogo = (byte[])reader[4];
                Main.CompanyData.TelephoneNo = reader[6].ToString();
                Main.CompanyData.CellphoneNo = reader[7].ToString();
                Main.CompanyData.Email = reader[8].ToString();
            }
        }

        public void setCompanyData()
        {
            String companyName = Main.CompanyData.CompanyName;
            if (companyName != String.Empty)
            {
                lblCompanyName.Text = companyName;
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

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login Successful.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Main.UserData.userName = "Superuser";
                new Main.Controller.MainController(new Main.View.CMS());
                this.Dispose();
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                try
                {
                    conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                    conn.Open();

                    SqlCommand command = new SqlCommand();
                    command = conn.CreateCommand();
                    command.CommandText = @"SELECT * FROM EMPLOYEE WHERE EmployeeUsername = @username AND EmployeePassword = @password";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.HasRows)
                    {
                        MessageBox.Show("Login Successful.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        rd.Read();
                        Main.UserData.userName = rd.GetString(4).ToString() + ", " + rd.GetString(2).ToString() + " " + rd.GetString(3).ToString();
                        new Main.Controller.MainController(new Main.View.CMS());
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username/Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }
    }
}
