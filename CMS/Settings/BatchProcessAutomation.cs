using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;

namespace CMS.Settings
{
    public partial class BatchProcessAutomation : UserControl
    {
        Main.Logger logger = new Main.Logger();
        Main.View.Settings settings;

        public BatchProcessAutomation(Main.View.Settings settings)
        {
            this.settings = settings;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (TaskService ts = new TaskService())
            {
                //for Dormant Scheduling
                String taskNameDormant = "CMS_CheckDormant";
                TaskDefinition tdDormant = ts.NewTask();
                tdDormant.RegistrationInfo.Description = "CMS Check Dormant Savings Accounts";
                tdDormant.Principal.LogonType = TaskLogonType.InteractiveToken;
                DailyTrigger dtDormant = new DailyTrigger();
                dtDormant.DaysInterval = 1;
                dtDormant.StartBoundary = timeDormant.Value;
                tdDormant.Actions.Add(new ExecAction(@"C:\Team-Gameface\COLOSIS\BatchProcess\checkDormant.bat"));
                tdDormant.Triggers.Add(dtDormant);

                //for Maintaining Balances Scheduling
                String taskNameMaintainingBalance = "CMS_CheckMaintainingBalance";
                TaskDefinition tdMainBal = ts.NewTask();
                tdMainBal.RegistrationInfo.Description = "CMS Check Savings Accounts Maintaining Balances";
                tdMainBal.Principal.LogonType = TaskLogonType.InteractiveToken;
                DailyTrigger dtMainBal = new DailyTrigger();
                dtMainBal.DaysInterval = 1;
                dtMainBal.StartBoundary = timeMainBal.Value;
                tdMainBal.Actions.Add(new ExecAction(@"C:\Team-Gameface\COLOSIS\BatchProcess\checkMaintainingBalance.bat"));
                tdMainBal.Triggers.Add(dtMainBal);

                //for Savings Interest Scheduling
                String taskNameSavingsInterest = "CMS_CheckSavingsInterest";
                TaskDefinition tdSavingsInterest = ts.NewTask();
                tdSavingsInterest.RegistrationInfo.Description = "CMS Check Savings Accounts Interests";
                tdSavingsInterest.Principal.LogonType = TaskLogonType.InteractiveToken;
                DailyTrigger dtSavingsInterest = new DailyTrigger();
                dtSavingsInterest.DaysInterval = 1;
                dtSavingsInterest.StartBoundary = timeInterest.Value;
                tdSavingsInterest.Actions.Add(new ExecAction(@"C:\Team-Gameface\COLOSIS\BatchProcess\checkSavingsInterest.bat"));
                tdSavingsInterest.Triggers.Add(dtSavingsInterest);

                try
                {
                    //Delete Current Batch Process Schedules
                    foreach (RunningTask rt in ts.GetRunningTasks())
                    {
                        if (rt != null)
                        {
                            if (rt.Name == taskNameDormant)
                            {
                                ts.RootFolder.DeleteTask(taskNameDormant);
                            }
                            if (rt.Name == taskNameMaintainingBalance)
                            {
                                ts.RootFolder.DeleteTask(taskNameMaintainingBalance);
                            }
                            if (rt.Name == taskNameSavingsInterest)
                            {
                                ts.RootFolder.DeleteTask(taskNameSavingsInterest);
                            }
                        }
                    }
                    ts.RootFolder.RegisterTaskDefinition(taskNameDormant, tdDormant);
                    ts.RootFolder.RegisterTaskDefinition(taskNameMaintainingBalance, tdMainBal);
                    ts.RootFolder.RegisterTaskDefinition(taskNameSavingsInterest, tdSavingsInterest);
                    MessageBox.Show("Batch Process Automation Schedule Save Sucess.", "Batch Process Automation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Update");
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
            logger.Module = "Settings - Batch Processing Automation";
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
