using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Utilities.Controller
{
    class AccountSettingsController
    {
        View.AccountSettings accountSettings;
        Main.View.Utilities utilities;
        Main.Controller.MainController main;

        public AccountSettingsController(View.AccountSettings accountSettings, Main.View.Utilities utilities, Main.Controller.MainController main)
        {
            this.accountSettings = accountSettings;
            this.utilities = utilities;
            this.main = main;
            this.utilities.setUtilities(accountSettings);
            this.accountSettings.setBtnSaveEventHandler(this.btnSave);
            setFields();
        }

        public void btnSave(object sender, EventArgs e)
        {
            String[] details = this.accountSettings.getUserDetails();
            String[] account = this.accountSettings.getAccount();
            String errorMessage = String.Empty;
            if ((details[0] != String.Empty) && (details[1] != String.Empty))
            {
                Main.UserData.userLast = details[0];
                Main.UserData.userFirst = details[1];
                Main.UserData.userMiddle = details[2];
            }
            else
            {
                errorMessage += "Please Specify - Last Name and First Name" + Environment.NewLine;
            }
            if ((account[0] != String.Empty) && (account[1] != String.Empty))
            {
                Main.UserData.username = account[0];
                Main.UserData.password = account[1];
            }
            else
            {
                errorMessage += "Please Specify - Username and Password" + Environment.NewLine;
            }
            if (this.accountSettings.getImgData() == null)
            {
                if (updateUserNoPicture() > 0)
                {
                    MessageBox.Show("Update Success.", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setFields();
                    main.setUser();
                    accountSettings.reset();
                }
                else
                {
                    MessageBox.Show("Update Failed." + Environment.NewLine + Environment.NewLine + errorMessage, "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Main.UserData.picture = this.accountSettings.getImgData();
                if (updateUser() > 0)
                {
                    MessageBox.Show("Update Success.", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setFields();
                    main.setUser();
                    accountSettings.reset();
                }
                else
                {
                    MessageBox.Show("Update Failed." + Environment.NewLine + Environment.NewLine + errorMessage, "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public int updateUser()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateUserDetails @Id, @Last, @First, @Middle, @Username, @Password, @Picture";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", Main.UserData.userId);
            parameters.Add("@Last", Main.UserData.userLast);
            parameters.Add("@First", Main.UserData.userFirst);
            parameters.Add("@Middle", Main.UserData.userMiddle);
            parameters.Add("@Username", Main.UserData.username);
            parameters.Add("@Password", Main.UserData.password);
            parameters.Add("@Picture", Main.UserData.picture);
            int i = dal.executeNonQuery(sql, parameters);
            return i;
        }

        public int updateUserNoPicture()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateUserDetailsNoPicture @Id, @Last, @First, @Middle, @Username, @Password";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", Main.UserData.userId);
            parameters.Add("@Last", Main.UserData.userLast);
            parameters.Add("@First", Main.UserData.userFirst);
            parameters.Add("@Middle", Main.UserData.userMiddle);
            parameters.Add("@Username", Main.UserData.username);
            parameters.Add("@Password", Main.UserData.password);
            int i = dal.executeNonQuery(sql, parameters);
            return i;
        }

        public void setFields()
        {
            String[] details = new String[3];
            details[0] = Main.UserData.userLast;
            details[1] = Main.UserData.userFirst;
            details[2] = Main.UserData.userMiddle;
            this.accountSettings.setUserDetails(details);
            String[] account = new String[2];
            account[0] = Main.UserData.username;
            account[1] = Main.UserData.password;
            this.accountSettings.setAccount(account);
            this.accountSettings.setPicture(Main.UserData.picture);
        }
    }
}
