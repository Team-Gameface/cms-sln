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
    public partial class UserManagement : UserControl
    {
        Main.Logger logger = new Main.Logger();
        String userId = String.Empty;
        bool isAdd = false;
        
        public UserManagement()
        {
            InitializeComponent();
            setData(selectUsers());
            disableFunction();
        }

        public void enableFunction()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtPosition.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            comboType.SelectedIndex = -1;
            lblDetails.ResetText();

            txtLastName.Enabled = true;
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtPosition.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            comboType.Enabled = true;
            checkShow.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
        }

        public void disableFunction()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtPosition.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            comboType.SelectedIndex = -1;
            lblDetails.ResetText();

            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtMiddleName.Enabled = false;
            txtPosition.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            comboType.Enabled = false;
            checkShow.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enableFunction();
            isAdd = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            if ((row = dataUser.SelectedRows[0]) != null)
            {
                enableFunction();
                isAdd = false;
                userId = row.Cells[0].Value.ToString();
                String[] name = row.Cells[1].Value.ToString().Split(' ');
                txtLastName.Text = name[0].TrimEnd(',');
                txtFirstName.Text = name[1];
                txtMiddleName.Text = name[2];
                txtPosition.Text = row.Cells[2].Value.ToString();
                txtUsername.Text = row.Cells[3].Value.ToString();
                txtPassword.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString() == "Staff")
                {
                    comboType.SelectedIndex = 0;
                }
                else if (row.Cells[5].Value.ToString() == "Manager")
                {
                    comboType.SelectedIndex = 1;
                }
                else if (row.Cells[5].Value.ToString() == "Chairman - Credit Committee")
                {
                    comboType.SelectedIndex = 1;
                }
                else if (row.Cells[5].Value.ToString() == "Chairman - Audit Committee")
                {
                    comboType.SelectedIndex = 1;
                }
                else
                {
                    comboType.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("No Row Selected", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clearErrors();
            bool checkFirst = false;
            bool checkLast = false;
            bool checkPosition = false;
            bool checkUsername = false;
            bool checkPassword = false;
            bool checkType = false;
            String errorMessage = String.Empty;
            if (isAdd)
            {
                errorMessage += "Add Failed." + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                errorMessage += "Update Failed." + Environment.NewLine + Environment.NewLine;
            }
            if (txtFirstName.Text != String.Empty)
            {
                checkFirst = true;
            }
            else
            {
                checkFirst = false;
                lblFirst.ForeColor = Color.Red;
                errorMessage += "Please Specify - First Name" + Environment.NewLine;
            }
            if (txtLastName.Text != String.Empty)
            {
                checkLast = true;
            }
            else
            {
                checkLast = false;
                lblLast.ForeColor = Color.Red;
                errorMessage += "Please Specify - Last Name" + Environment.NewLine;
            }
            if (txtPosition.Text != String.Empty)
            {
                checkPosition = true;
            }
            else
            {
                checkPosition = false;
                lblPosition.ForeColor = Color.Red;
                errorMessage += "Please Specify - Position" + Environment.NewLine;
            }
            if (txtUsername.Text != String.Empty)
            {
                if (isAdd)
                {
                    if (checkExists(txtUsername.Text) > 0)
                    {
                        checkUsername = false;
                        lblUsername.ForeColor = Color.Red;
                        errorMessage += "Username Already Exists" + Environment.NewLine;
                    }
                    else
                    {
                        checkUsername = true;
                    }
                }
                else
                {
                    if (checkExists(txtUsername.Text, userId) > 0)
                    {
                        checkUsername = false;
                        lblUsername.ForeColor = Color.Red;
                        errorMessage += "Username Already Exists" + Environment.NewLine;
                    }
                    else
                    {
                        checkUsername = true;
                    }
                }
            }
            else
            {
                checkUsername = false;
                lblUsername.ForeColor = Color.Red;
                errorMessage += "Please Specify - Username" + Environment.NewLine;
            }
            if (txtPassword.Text != String.Empty)
            {
                checkPassword = true;
            }
            else
            {
                checkPassword = false;
                lblPassword.ForeColor = Color.Red;
                errorMessage += "Please Specify - Password" + Environment.NewLine;
            }
            if (comboType.SelectedIndex != -1)
            {
                checkType = true;
            }
            else
            {
                checkType = false;
                lblUserType.ForeColor = Color.Red;
                errorMessage += "Please Specify - User Type" + Environment.NewLine;
            }
            errorMessage += Environment.NewLine + "Please Check Red Label/s";
            if (checkFirst && checkLast && checkPosition && checkUsername && checkPassword && checkPosition && checkType)
            {
                if (isAdd)
                {
                    if (insertUser() == 1)
                    {
                        MessageBox.Show("Add Success", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disableFunction();
                        clearErrors();
                        isAdd = false;
                        userId = String.Empty;
                        setData(searchUsers(txtSearch.Text));
                        execLogger("Add");
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (updateUser() == 1)
                    {
                        MessageBox.Show("Update Success", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disableFunction();
                        clearErrors();
                        isAdd = false;
                        userId = String.Empty;
                        setData(searchUsers(txtSearch.Text));
                        execLogger("Update");
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearErrors()
        {
            lblFirst.ForeColor = SystemColors.ControlText;
            lblLast.ForeColor = SystemColors.ControlText;
            lblPosition.ForeColor = SystemColors.ControlText;
            lblUsername.ForeColor = SystemColors.ControlText;
            lblPassword.ForeColor = SystemColors.ControlText;
            lblUserType.ForeColor = SystemColors.ControlText;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isAdd = false;
            userId = String.Empty;
            disableFunction();
            clearErrors();
        }

        public void setData(DataSet ds)
        {
            dataUser.DataSource = ds.Tables[0];
            dataUser.Columns[0].Visible = false;
            dataUser.Columns[4].Visible = false;
        }

        public DataSet selectUsers()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT UserId, CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Name', Position, Username, Password, UserType AS 'User Type', DateCreated, DateModified FROM SYSTEM_USERS WHERE UserId NOT IN('SU-0000000', @Id)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", Main.UserData.userId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchUsers(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT UserId, CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Name', Position, Username, Password, UserType AS 'User Type', DateCreated, DateModified FROM SYSTEM_USERS WHERE UserId NOT IN('SU-0000000', @Id) AND (FirstName LIKE(@searchName) OR MiddleName LIKE(@searchName) OR LastName LIKE(@searchName))";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", Main.UserData.userId);
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int checkExists(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM SYSTEM_USERS WHERE Username = @searchName";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            return i;
        }

        public int checkExists(String searchName, String Id)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM SYSTEM_USERS WHERE Username = @searchName AND UserId != @Id";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            parameters.Add("@Id", Id);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            return i;
        }

        public int insertUser()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertSystemUser @Id, @First, @Middle, @Last, @Position, @Username, @Password, @Type";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", "SU-" + DateTime.Today.Year.ToString() +  selectInsertId().ToString("D3"));
            parameters.Add("@First", txtFirstName.Text.Trim());
            parameters.Add("@Middle", txtMiddleName.Text.Trim());
            parameters.Add("@Last", txtLastName.Text.Trim());
            parameters.Add("@Position", txtPosition.Text.Trim());
            parameters.Add("@Username", txtUsername.Text.Trim());
            parameters.Add("@Password", txtPassword.Text.Trim());
            if (comboType.SelectedIndex == 0)
            {
                parameters.Add("@Type", "Staff");
            }
            else if (comboType.SelectedIndex == 1)
            {
                parameters.Add("@Type", "Manager");
            }
            else if (comboType.SelectedIndex == 2)
            {
                parameters.Add("@Type", "Chairman - Credit Committee");
            }
            else if (comboType.SelectedIndex == 3)
            {
                parameters.Add("@Type", "Chairman - Audit Committee");
            }
            int result = dal.executeNonQuery(sql, parameters);
            return result;
        }

        public int updateUser()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateSystemUser @Id, @First, @Middle, @Last, @Position, @Username, @Password, @Type";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", userId);
            parameters.Add("@First", txtFirstName.Text.Trim());
            parameters.Add("@Middle", txtMiddleName.Text.Trim());
            parameters.Add("@Last", txtLastName.Text.Trim());
            parameters.Add("@Position", txtPosition.Text.Trim());
            parameters.Add("@Username", txtUsername.Text.Trim());
            parameters.Add("@Password", txtPassword.Text.Trim());
            if (comboType.SelectedIndex == 0)
            {
                parameters.Add("@Type", "Staff");
            }
            else if (comboType.SelectedIndex == 1)
            {
                parameters.Add("@Type", "Manager");
            }
            else if (comboType.SelectedIndex == 2)
            {
                parameters.Add("@Type", "Chairman - Credit Committee");
            }
            else if (comboType.SelectedIndex == 3)
            {
                parameters.Add("@Type", "Chairman - Audit Committee");
            }
            int result = dal.executeNonQuery(sql, parameters);
            return result;
        }

        public int selectInsertId()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 UserId FROM SYSTEM_USERS ORDER BY 1 DESC";
            SqlDataReader read = dal.executeReader(sql);
            int i = 0;
            while (read.Read())
            {
                String[] id = read[0].ToString().Split('-');
                i = int.Parse(id[1]);
            }
            return i + 1;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            setData(searchUsers(txtSearch.Text.ToString()));
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboType.SelectedIndex == 0)
            {
                lblDetails.Text = "Staff - can access Maintenance and Transaction Modules with Limited Control";
            }
            else if (comboType.SelectedIndex == 1)
            {
                lblDetails.Text = "Manager - can access Maintenance and Transaction Modules with Full Control";
            }
            else if (comboType.SelectedIndex == 2)
            {
                lblDetails.Text = "Chairman of Credit Committee - can access Maintenance and Transaction Modules with Full Control" + Environment.NewLine + "will be the Signatory for Reports";
            }
            else if (comboType.SelectedIndex == 3)
            {
                lblDetails.Text = "Chairman of Audit Committee - can access Maintenance and Transaction Modules with Full Control" + Environment.NewLine + "will be the Signatory for Reports";
            }
            else
            {
                lblDetails.ResetText();
            }
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Settings - User Management";
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
