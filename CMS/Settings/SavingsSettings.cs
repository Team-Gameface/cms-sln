using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CMS.Settings
{
    public partial class SavingsSettings : UserControl
    {
        Main.Logger logger = new Main.Logger();
        CMS.Main.View.Settings settings;
        int MemberTypeNo = 0;
        int NoAllowed = 0;

        public SavingsSettings(CMS.Main.View.Settings settings)
        {
            this.settings = settings;
            InitializeComponent();
            dataMemberType.DataSource = selectSavingsSettings().Tables[0];
            dataMemberType.Columns[0].Visible = false;
            dataMemberType.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            numAllowed.Enabled = false;
        }

        public DataSet selectSavingsSettings()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT mt.MemberTypeNo, mt.Description AS 'Member Type', ISNULL(msas.NoSavingsAccount, 1) AS 'No of Allowed Savings Account' FROM MEMBER_TYPE mt LEFT OUTER JOIN MEMBER_SAVINGS_ACCOUNT_SETTINGS msas ON mt.MemberTypeNo = msas.MemberTypeNo WHERE mt.isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public int checkSavingsSettings(int TypeNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM MEMBER_SAVINGS_ACCOUNT_SETTINGS WHERE MemberTypeNo = @MemberTypeNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@MemberTypeNo", TypeNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            dal.Close();
            return i;
        }

        private void dataMemberType_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataMemberType.SelectedRows[0];
                MemberTypeNo = int.Parse(dr.Cells[0].Value.ToString());
                numAllowed.Value = int.Parse(dr.Cells[2].Value.ToString());
                dataMemberType.Columns[0].Visible = false;
                numAllowed.Enabled = true;
            }
            catch (Exception) { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MemberTypeNo == 0)
            {
                MessageBox.Show("Save Failed.", "Savings Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (numAllowed.Value > 0)
                {
                    NoAllowed = int.Parse(numAllowed.Value.ToString());
                    if (checkSavingsSettings(MemberTypeNo) > 0)
                    {
                        DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                        String sql = "EXEC updateMemberSavingsAccountSettings @MemberTypeNo, @NoAllowed";
                        Dictionary<String, Object> parameters = new Dictionary<string, object>();
                        parameters.Add("@MemberTypeNo", MemberTypeNo);
                        parameters.Add("@NoAllowed", NoAllowed);
                        int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
                        if (result == 1)
                        {
                            MessageBox.Show("Save Success.", "Savings Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dataMemberType.DataSource = selectSavingsSettings().Tables[0];
                            dataMemberType.Columns[0].Visible = false;
                            execLogger("Update");
                        }
                        dal.Close();
                    }
                    else
                    {
                        DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                        String sql = "EXEC insertMemberSavingsAccountSettings @MemberTypeNo, @NoAllowed";
                        Dictionary<String, Object> parameters = new Dictionary<string, object>();
                        parameters.Add("@MemberTypeNo", MemberTypeNo);
                        parameters.Add("@NoAllowed", NoAllowed);
                        int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
                        if (result == 1)
                        {
                            MessageBox.Show("Save Success.", "Savings Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataMemberType.DataSource = selectSavingsSettings().Tables[0];
                            dataMemberType.Columns[0].Visible = false;
                            execLogger("Update");
                        }
                        dal.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Save Failed.", "Savings Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Settings - Savings Account Settings";
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
