using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace CMS.Loan_Management.Maintenance.Controller
{
    class LoanAmnestyActivationController
    {
        Maintenance.Model.LoanAmnestyActivationModel loanAmnestyModel;
        Maintenance.View.LoanAmnestyActivation loanAmnesty;

        Boolean isAdd = false;

        Dictionary<int, string> loanTypes = new Dictionary<int, string>();

        public LoanAmnestyActivationController(Maintenance.Model.LoanAmnestyActivationModel loanAmnestyModel, Maintenance.View.LoanAmnestyActivation loanAmnesty, Loan_Management.LoanManagementMenu loanMenu) 
        {
            this.loanAmnestyModel = loanAmnestyModel;
            this.loanAmnesty = loanAmnesty;
            this.loanAmnesty.MdiParent = loanMenu;
            this.loanAmnesty.setBtnAddEventHandler(this.btnAdd);
            this.loanAmnesty.setBtnCancelEventHandler(this.btnCancel);
            this.loanAmnesty.setBtnEditEventHandler(this.btnEdit);
            this.loanAmnesty.setBtnSaveEventHandler(this.btnSave);
            this.loanAmnesty.cbShowArchive_CheckStateChanged(this.checkArchived);
            isAdd = false;
            this.loanAmnesty.amnestyGrid(this.loanAmnestyModel.selectAmnesty());
            this.loanAmnesty.disableFunction();
            this.loanAmnesty.Show();
        }

        public void checkArchived(object sender, EventArgs e)
        {
            if (this.loanAmnesty.checkArchivedState())
            {
                this.loanAmnesty.amnestyGrid(this.loanAmnestyModel.selectAllAmnesty());
                DataGridViewRowCollection dr = this.loanAmnesty.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.loanAmnesty.setArchivedColor(i);
                    }
                    i++;
                }
                this.loanAmnesty.getSelectedData();
            }
            else
            {
               this.loanAmnesty.amnestyGrid(this.loanAmnestyModel.selectAmnesty());
            }
        }

        public void clbLoanTypes()
        {

            loanTypes.Clear();
            DataTable ds = this.loanAmnestyModel.selectLoanTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                loanTypes.Add(int.Parse(dr["Loan Type Id"].ToString()), dr["Loan Type Name"].ToString());

            }
            this.loanAmnesty.populateLoanTypes(loanTypes);
        }

        public void activeLoanTypes(int amnestyId)
        {

            ArrayList checkedTypes = new ArrayList();

            DataTable ds = this.loanAmnestyModel.selectActiveLoanTypes(amnestyId).Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                foreach (KeyValuePair<int, string> pair in loanTypes)
                {
                    if (int.Parse(dr[0].ToString()) == pair.Key)
                        checkedTypes.Add(pair.Value);
                }
            }
            this.loanAmnesty.toggleCheckedTypes(checkedTypes);

        }

        public void btnAdd(object args, EventArgs e) 
        {
            this.clbLoanTypes();
            this.loanAmnesty.enableFunction();
            isAdd = true;
        }

        public void btnEdit(object args, EventArgs e)
        {
            loanAmnesty.disableFunction();
            try
            {
                loanAmnesty.enableFunction();
                this.clbLoanTypes();
                try
                {
                    DataGridViewRow selectedData = this.loanAmnesty.getSelected();
                    isAdd = false;
                    int AmnestyId = int.Parse(selectedData.Cells["AmnestyId"].Value.ToString());
                    this.activeLoanTypes(AmnestyId);
                    String[] overdueDuration = selectedData.Cells["Loan Overdue Duration"].Value.ToString().Split(' ');
                    int duration = int.Parse(overdueDuration[0]);
                    String durationStatus = overdueDuration[1];
                    DateTime from = DateTime.Parse(selectedData.Cells["From"].Value.ToString());
                    String to = selectedData.Cells["To"].Value.ToString();

                    bool waivePenalty = bool.Parse(selectedData.Cells["Waive Penalty?"].Value.ToString());
                    if(waivePenalty)
                    {
                        this.loanAmnesty.setWaivePenalty();
                    }

                    bool waiveInterest = bool.Parse(selectedData.Cells["Waive Interest?"].Value.ToString());
                    if(waiveInterest)
                    {
                        this.loanAmnesty.setWaiveInterest();
                    }

                    bool Status = bool.Parse(selectedData.Cells["Status"].Value.ToString());
                    if (Status)
                    {
                        this.loanAmnesty.setStatus();
                    }

                    this.loanAmnesty.setStartDate(from);
                    if (to != "infinity")
                    {
                        this.loanAmnesty.setEndDate(DateTime.Parse(to));
                        this.loanAmnesty.setClbDateTo();
                    }
                    this.loanAmnesty.setOverdue(duration);
                    this.loanAmnesty.setDuration(durationStatus);
                    
                }
                catch (ArgumentException ex) { MessageBox.Show("No rows selected."+ex.Message, "Edit Loan Charge", MessageBoxButtons.OK, MessageBoxIcon.Error); loanAmnesty.disableFunction(); }
            }
            catch (Exception)
            {
                DataGridViewRow selectedData = this.loanAmnesty.getSelected();
                MessageBox.Show("No rows were selected.", "Edit Loan Charge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loanAmnesty.disableFunction();
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            int countError = 0;
            String errorMessage = String.Empty;
            this.loanAmnesty.setAllLabelsToBlack();

            String dateFrom = this.loanAmnesty.getStartDate();
            String dateTo;
            int duration = this.loanAmnesty.getOverdue();
            String durationStatus = ""; 
            Boolean status, waivePenalty, waiveInterest;

            if (this.loanAmnesty.getInfinityDate() == true)
            {
                dateTo = this.loanAmnesty.getEndDate();
            }
            else 
            {
                dateTo = "infinity";  
            }

            if (this.loanAmnesty.getInfinityDate() == true && (DateTime.Parse(dateTo) < DateTime.Parse(dateFrom)))
            {
                countError++; errorMessage += countError + ". Please check inclusive dates.\n"; this.loanAmnesty.lblFrom.ForeColor = System.Drawing.Color.Red; this.loanAmnesty.lblTo.ForeColor = System.Drawing.Color.Red;
            }

            if (duration == 0) 
            {
                countError++; errorMessage += countError + ". Please specify loan overdue.\n"; this.loanAmnesty.lblOverdue.ForeColor = System.Drawing.Color.Red; this.loanAmnesty.lblAndAbove.ForeColor = System.Drawing.Color.Red;
            }

            try
            {
                durationStatus = this.loanAmnesty.getDuration();
            }
            catch (Exception) 
            {
                countError++; errorMessage += countError + ". Please specify loan overdue duration.\n"; this.loanAmnesty.lblOverdue.ForeColor = System.Drawing.Color.Red;   
            }

            CheckedListBox.CheckedItemCollection loanTypeName = this.loanAmnesty.getCheckedTypes();
            ArrayList loanTypeId = new ArrayList();

            foreach (String s in loanTypeName)
            {
                foreach (KeyValuePair<int, string> pair in loanTypes)
                {
                    if (s.Equals(pair.Value))
                        loanTypeId.Add(pair.Key);
                }
            }

            if (this.loanAmnesty.getWaiveInterest())
            {
                waiveInterest = true;
            }
            else 
            {
                waiveInterest = false;
            }

            if (this.loanAmnesty.getWaivePenalty())
            {
                waivePenalty = true;
            }
            else 
            {
                waivePenalty = false;
            }

            if (waiveInterest == false && waivePenalty == false) 
            {
                countError++; errorMessage += countError + ". Please check 1 or more condonation.\n"; this.loanAmnesty.lblWaive.ForeColor = System.Drawing.Color.Red; 
            }

            if (this.loanAmnesty.getStatus())
            {
                status = true;
            }
            else
            {
                status = false;
            }

            if (loanTypeId.Count == 0) { countError++; errorMessage += countError + ". Please check one or more loan types.\n"; this.loanAmnesty.lblLoanType.ForeColor = System.Drawing.Color.Red; }

            if (isAdd)
            {
                if (countError == 0)
                {
                    this.loanAmnestyModel.insertAmnesty(loanTypeId, dateFrom, dateTo, duration, durationStatus, waiveInterest, waivePenalty, status);
                    MessageBox.Show("Add Success.", "Activate Loan Amnesty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAdd = false;
                    if (this.loanAmnesty.checkArchivedState())
                    {
                        this.loanAmnesty.amnestyGrid(this.loanAmnestyModel.selectAllAmnesty());
                        DataGridViewRowCollection dr = this.loanAmnesty.getAllRows();
                        int i = 0;
                        foreach (DataGridViewRow row in dr)
                        {
                            if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                            {
                                this.loanAmnesty.setArchivedColor(i);
                            }
                            i++;
                        }
                        this.loanAmnesty.getSelectedData();
                    }
                    else
                    {
                        this.loanAmnesty.amnestyGrid(this.loanAmnestyModel.selectAmnesty());
                    }
                    this.loanAmnesty.setAllLabelsToBlack();
                    this.loanAmnesty.disableFunction();
                }
                else 
                {
                    MessageBox.Show("Add Failed!\n\n" + errorMessage, "Activate Loan Amnesty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (countError == 0)
                {
                    this.loanAmnestyModel.insertAmnesty(loanTypeId, dateFrom, dateTo, duration, durationStatus, waiveInterest, waivePenalty, status);
                    MessageBox.Show("Update Success.", "Activate Loan Amnesty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAdd = false;
                    if (this.loanAmnesty.checkArchivedState())
                    {
                        this.loanAmnesty.amnestyGrid(this.loanAmnestyModel.selectAllAmnesty());
                        DataGridViewRowCollection dr = this.loanAmnesty.getAllRows();
                        int i = 0;
                        foreach (DataGridViewRow row in dr)
                        {
                            if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                            {
                                this.loanAmnesty.setArchivedColor(i);
                            }
                            i++;
                        }
                        this.loanAmnesty.getSelectedData();
                    }
                    else
                    {
                        this.loanAmnesty.amnestyGrid(this.loanAmnestyModel.selectAmnesty());
                    }
                    this.loanAmnesty.setAllLabelsToBlack();
                    this.loanAmnesty.disableFunction();
                }
                else 
                {
                    MessageBox.Show("Update Failed!\n\n" + errorMessage, "Update Loan Amnesty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.loanAmnesty.setAllLabelsToBlack();
            isAdd = false;
            this.loanAmnesty.disableFunction();
        }


    }
}
