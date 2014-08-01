using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CMS.Loan_Management.Maintenance.Controller
{
    class ShareCapitalContributionController
    {
        Maintenance.Model.ShareCapitalContributionModel model;
        Maintenance.View.ShareCapitalContribution view;

        Boolean isAdd = false;
        int TypeId = 0;

        public ShareCapitalContributionController(Maintenance.Model.ShareCapitalContributionModel model, Maintenance.View.ShareCapitalContribution view, LoanManagementMenu loanMenu)
        {
            this.model = model;
            this.view = view;
            this.view.setBtnAddEventHandler(this.btnAdd);
            this.view.setBtnCancelEventHandler(this.btnCancel);
            this.view.setBtnEditEventHandler(this.btnEdit);
            this.view.setBtnSaveEventHandler(this.btnSave);
            this.view.capitalContributionGrid(this.model.SelectCapitalContribution());
            this.view.cbShowArchive_CheckStateChanged(this.checkArchived);
            this.view.disableFunction();
            this.view.MdiParent = loanMenu;
            this.view.Show();
        }

        public void checkArchived(object sender, EventArgs e)
        {
            if (this.view.checkArchivedState())
            {
                this.view.capitalContributionGrid(this.model.SelectAllCapitalContribution());
                DataGridViewRowCollection dr = this.view.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.view.setArchivedColor(i);
                    }
                    i++;
                }
                this.view.getSelectedData();
            }
            else
            {
                this.view.capitalContributionGrid(this.model.SelectCapitalContribution());
            }
        }

        public void btnAdd(object args, EventArgs e)
        {
            
            int i=this.view.initAccountType(this.model.SelectMemberType());

            if (i == 0)
            {
                isAdd = true;
                TypeId = 0;
                this.view.enableFunction();
                this.view.setStatus();
            }

            else
            {
                MessageBox.Show("There are no more available member types for adding share capital contribution.", "Add Share Capital Contribution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void btnCancel(object args, EventArgs e)
        {
            isAdd = false;
            TypeId = 0;
            this.view.setAllLabelsToBlack();
            this.view.disableFunction();
        }

        public void btnEdit(object args, EventArgs e)
        {
            isAdd = false;
            this.view.enableFunction();
            this.view.disableType();
            DataGridViewRow selectedData = this.view.getSelected();
            TypeId = int.Parse(selectedData.Cells["Minimum Capital Contribution ID"].Value.ToString());
            this.view.initAccountType(this.model.selectAllMemberTypes());
            this.view.setAccountType(selectedData.Cells["Member Type"].Value.ToString());
            this.view.setCapitalContrib(selectedData.Cells["Share Capital"].Value.ToString());
            this.view.setComboContrib(selectedData.Cells["Duration"].Value.ToString());

            if (bool.Parse(selectedData.Cells["Status"].Value.ToString()))
            {
                this.view.setStatus();
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            String errorMessage = String.Empty;
            int countError = 0;
            this.view.setAllLabelsToBlack();

            if (this.view.getStatus())
            {
                this.model.Status = 1;
            }

            try
            {
                this.model.comboAccountType = this.view.getAccountType();
            }
            catch (Exception) {

                countError++;
                errorMessage += countError + ". Please select a member type.\n";
                this.view.lblMemberType.ForeColor = System.Drawing.Color.Red;
            }

            try
            {
                this.model.txtContribution = this.view.getCapitalContrib();
                
                if (this.model.txtContribution == 0) {
                    countError++; errorMessage += countError + ". Please specify capital contribution.\n"; this.view.lblCapitalContrib.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {

                countError++;
                errorMessage += countError + ". Please specify capital contribution.\n";
                this.view.lblCapitalContrib.ForeColor = System.Drawing.Color.Red;

            }

            try
            {
                this.model.comboContribution = this.view.getComboContrib();
            }
            catch (Exception)
            {
                countError++;
                errorMessage += countError + ". Please specify duration.\n";
                this.view.lblDuration.ForeColor = System.Drawing.Color.Red;
            }


                if (isAdd)
                {
                    
                    if (countError==0 && this.model.InsertMinCapitalContrib() == 1)
                    {
                        MessageBox.Show("Add Success.", "Add Share Capital", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.view.checkArchivedState())
                        {
                            this.view.capitalContributionGrid(this.model.SelectAllCapitalContribution());
                            DataGridViewRowCollection dr = this.view.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.view.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.view.getSelectedData();
                        }
                        else 
                        {
                            this.view.capitalContributionGrid(this.model.SelectCapitalContribution());
                        }
                        this.view.disableFunction(); 
                        isAdd = false;
                        TypeId = 0;
                    }
                    else
                    {
                        MessageBox.Show("Add Failed!\n\n" + errorMessage, "Add Share Capital", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TypeId = 0;
                    }
                }
                else
                {
                    if (countError==0 && this.model.InsertMinCapitalContrib() == 1)
                    {
                        MessageBox.Show("Update Success.", "Update Share Capital", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.view.checkArchivedState())
                        {
                            this.view.capitalContributionGrid(this.model.SelectAllCapitalContribution());
                            DataGridViewRowCollection dr = this.view.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.view.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.view.getSelectedData();
                        }
                        else 
                        {
                            this.view.capitalContributionGrid(this.model.SelectCapitalContribution());
                        }
                        this.view.disableFunction();
                        isAdd = false;
                        TypeId = 0;
                    }
                    else
                    {
                        MessageBox.Show("Update Failed!\n\n" + errorMessage, "Update Share Capital", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
           
       
    }
}
