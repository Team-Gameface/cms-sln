using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Win32.TaskScheduler;

namespace CMS.Settings
{
    public partial class BackupRestore : UserControl
    {
        Main.Logger logger = new Main.Logger();

        public BackupRestore()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["master"].ConnectionString);
            String sql = "BACKUP DATABASE CMS TO DISK = @path";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@path", @"C:\CMS\Backup\db-backup_" + DateTime.Now.ToString("dd-mm-yyyy_hh-mm-ss-tt") + ".bak");
            int result = dal.executeNonQuery(sql, parameters);
            if (result != 0)
            {
                MessageBox.Show("Backup Success.", "Backup and Restore Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                execLogger("Backup Database");
            }
            else
            {
                MessageBox.Show("Backup Failed.", "Backup and Restore Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dal.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Choose Backup File";
            openDialog.Filter = "Backup Files (*.bak) | *.bak";
            openDialog.InitialDirectory = @"C:\CMS\Backup\";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                String fileName = openDialog.FileName.ToString();
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["master"].ConnectionString);
                String setUserNone = "ALTER DATABASE [CMS] SET Single_User WITH Rollback Immediate";
                dal.executeNonQuery(setUserNone);
                String sql = "RESTORE DATABASE CMS FROM DISK = @path WITH REPLACE";
                Dictionary<String, Object> parameters = new Dictionary<string, object>();
                parameters.Add("@path", fileName);
                int result = dal.executeNonQuery(sql, parameters);
                String restoreUser = "ALTER DATABASE [CMS] SET Multi_User";
                dal.executeNonQuery(restoreUser);
                if (result != 0)
                {
                    MessageBox.Show("Restore Success.", "Backup and Restore Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Restore Database");
                }
                else
                {
                    MessageBox.Show("Restore Failed.", "Backup and Restore Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dal.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (TaskService ts = new TaskService())
            {
                String taskNameBackup = "CMS_DailyDBBackup";
                TaskDefinition tdBackup = ts.NewTask();
                tdBackup.RegistrationInfo.Description = "CMS Daily Database Backup";
                tdBackup.Principal.LogonType = TaskLogonType.InteractiveToken;
                DailyTrigger dtBackup = new DailyTrigger();
                dtBackup.DaysInterval = 1;
                dtBackup.StartBoundary = timeSchedule.Value;
                tdBackup.Actions.Add(new ExecAction(@"C:\CMS\Backup\performBackup.bat"));
                tdBackup.Triggers.Add(dtBackup);

                try
                {
                    //Delete Current Batch Process Schedules
                    foreach (RunningTask rt in ts.GetRunningTasks())
                    {
                        if (rt != null)
                        {
                            if (rt.Name == taskNameBackup)
                            {
                                ts.RootFolder.DeleteTask(taskNameBackup);
                            }
                        }
                    }
                    ts.RootFolder.RegisterTaskDefinition(taskNameBackup, tdBackup);
                    MessageBox.Show("Daily Database Backup Schedule Save Sucess.", "Batch Process Automation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Scheduled Backup Updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Backup and Restore Database";
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
