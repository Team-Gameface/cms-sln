using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace CMS.Main.View
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            setUser();
            setMembers();
            setSavings();
            setLoans();
            setTimeDeposit();
        }

        public void setUser()
        {
            lblUser.Text = Main.UserData.userLast + ", " + Main.UserData.userFirst;
        }

        public void setMembers()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "SELECT COUNT(*) from MEMBER WHERE Status = 1";
            int total = Convert.ToInt32(dal.executeScalar(sqlSelect));
            lblMembers.Text = total.ToString("D4");
        }

        public void setSavings()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "SELECT COUNT(*) FROM SAVINGS_ACCOUNT WHERE Status = 1";
            int total = Convert.ToInt32(dal.executeScalar(sqlSelect));
            lblSavings.Text = total.ToString("D4");
        }

        public void setLoans()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "SELECT COUNT(*) FROM LOAN_INFORMATION WHERE isCleared = 0";
            int total = Convert.ToInt32(dal.executeScalar(sqlSelect));
            lblLoans.Text = total.ToString("D4");
        }

        public void setTimeDeposit()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sqlSelect = "SELECT COUNT(*) FROM TIME_DEPOSIT WHERE Status = 1";
            int total = Convert.ToInt32(dal.executeScalar(sqlSelect));
            lblTimeDeposit.Text = total.ToString("D4");
        }
    }
}
