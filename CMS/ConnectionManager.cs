using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace CMS
{
    public partial class ConnectionManager : Form
    {
        public ConnectionManager()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder Con = new StringBuilder("Data Source=");
                Con.Append(txtServer.Text);
                Con.Append(";Initial Catalog=");
                Con.Append(txtDatabase.Text);
                Con.Append(";Integrated Security=True;");
                string strCon = Con.ToString();
                StringBuilder Con2 = new StringBuilder("Data Source=");
                Con2.Append(txtServer.Text);
                Con2.Append(";Initial Catalog=master");
                Con2.Append(";Integrated Security=True;");
                String masterCon = Con2.ToString();
                updateConfigFile(strCon, masterCon);
                ConfigurationManager.RefreshSection("connectionStrings");
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                dal.TestConnection();
                dal.Close();
            }
            catch(Exception)
            {
                MessageBox.Show(ConfigurationManager.ConnectionStrings["CMS"].ToString() + ".This is invalid connection", "Incorrect server/Database");
            }
        }

        public void updateConfigFile(string con, string masterCon)
        {
            //updating config file
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the coonection string
                    xElement.FirstChild.Attributes[1].Value = con;
                    xElement.LastChild.Attributes[1].Value = masterCon;
                }
            }
            //writing the connection string in config file
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Dispose();
        }

        private void ConnectionManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
