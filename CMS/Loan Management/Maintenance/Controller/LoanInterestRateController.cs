using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Maintenance.Controller
{
    class LoanInterestRateController
    {
        Maintenance.Model.LoanInterestRateModel interestModel;
        Maintenance.View.LoanInterestRate interestRate;

        Boolean isAdd = false;
        int TypeId = 0;

        public LoanInterestRateController(Maintenance.Model.LoanInterestRateModel interestModel, Maintenance.View.LoanInterestRate interestRate, LoanManagementMenu loanMenu)
        {
            this.interestModel = interestModel;
            this.interestRate = interestRate;
            this.interestRate.setBtnAddEventHandler(this.btnAdd);
            this.interestRate.setBtnCancelEventHandler(this.btnCancel);
            //this.interestRate.setBtnDeletEventHandler(this.btnDelete);
            this.interestRate.setBtnEditEventHandler(this.btnEdit);
            this.interestRate.setBtnSaveEventHandler(this.btnSave);
            this.interestRate.loanGrid(this.interestModel.selectInterestRates());
            this.interestRate.cbShowArchive_CheckStateChanged(this.checkArchived);
            this.interestRate.disableFunction();
            this.interestRate.MdiParent = loanMenu;
            isAdd = false;
            this.interestRate.Show();
        }

        public void checkArchived(object sender, EventArgs e)
        {
            if (this.interestRate.checkArchivedState())
            {
                this.interestRate.loanGrid(this.interestModel.selectAllInterestRates());
                DataGridViewRowCollection dr = this.interestRate.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.interestRate.setArchivedColor(i);
                    }
                    i++;
                }
                this.interestRate.getSelectedData();
            }
            else
            {
                this.interestRate.loanGrid(this.interestModel.selectInterestRates());
            }
        }

        public void btnAdd(object args, EventArgs e)
        {
            
            int i=this.interestRate.initLoanType(this.interestModel.selectLoanTypes());

            if (i == 0)
            {
                this.interestRate.enableFunction();
               // this.interestRate.setStatus();
                isAdd = true;
                TypeId = 0;
            }

            else {
                MessageBox.Show("There are no more available loan types for adding interest rate.", "Loan Interest Rates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.interestRate.setAllLabelsToBlack();
            isAdd = false;
            TypeId = 0;
            this.interestRate.disableFunction();
        }


        /* public void btnDelete(object args, EventArgs e)
         {
             try
             {
                 DataGridViewRow selectedData = this.interestRate.getSelected();
                 TypeId = int.Parse(selectedData.Cells["Loan Type Id"].Value.ToString());
                 if (interestModel.deleteInterestRate(TypeId) == 1)
                 {
                     MessageBox.Show("Delete Success.", "Delete Loan Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     this.interestRate.loanGrid(this.interestModel.selectInterestRates());
                 }
                 else
                 {
                     MessageBox.Show("Delete Failed.", "Delete Loan Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 TypeId = 0;
             }
             catch (Exception)
             {
                 MessageBox.Show("No rows were selected.", "Delete Loan Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }*/


        public void btnEdit(object args, EventArgs e)
        {
            try
            {
                isAdd = false;
                this.interestRate.enableFunction();
                //this.interestRate.initLoanType(this.interestModel.selectLoanTypes());

                this.interestRate.disableType();
                DataGridViewRow selectedData = this.interestRate.getSelected();
                int i = this.interestRate.initLoanType(this.interestModel.selectAllLoanTypes());
                this.interestRate.setLoanType(selectedData.Cells["Loan Type Name"].Value.ToString());
                String[] arrInterest = selectedData.Cells["Interest Rate"].Value.ToString().Split(' ');
                this.interestRate.setInterestRateStatus(arrInterest[1]);
                this.interestRate.setInterestRate(double.Parse(arrInterest[0]));
                this.TypeId = int.Parse(selectedData.Cells["Loan Type Id"].Value.ToString());
                this.interestRate.setDuration(selectedData.Cells["Duration"].Value.ToString());
                this.interestRate.setStartDate(Convert.ToDateTime(selectedData.Cells["Activation Date"].Value));

                /*    if (bool.Parse(selectedData.Cells["Active"].Value.ToString()))
                    {
                        this.interestRate.setStatus();
                    }*/
            }
            catch (Exception) {
                MessageBox.Show("No rows were selected.", "Loan Interest Rates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                interestRate.disableFunction();
            }
             
        }

        public void btnSave(object args, EventArgs e)
        {
            int countError = 0;
            int checkExist=0;
            int pass = 0;

            String errorMessage = String.Empty;
            this.interestRate.setAllLabelsToBlack();
            this.interestModel.DateFrom = this.interestRate.getStartDate();

            try
            {
                this.interestModel.LoanTypeId = this.interestRate.getLoanType();
            }
            catch (Exception) { countError++; errorMessage += countError + ". Please select a loan type.\n"; this.interestRate.lblLoanType.ForeColor = System.Drawing.Color.Red; }

            

            try
            {
                this.interestModel.InterestRateStatus = this.interestRate.getInterestRateStatus();
            }
            catch (Exception) { countError++; errorMessage += countError + ". Please select mode of interest rate.\n"; this.interestRate.lblInterestRate.ForeColor = System.Drawing.Color.Red; }

            try
            {
                this.interestModel.InterestRate = this.interestRate.getInterestRate();

                if (this.interestModel.InterestRate == 0)
                {
                    countError++; errorMessage += countError + ". Please specify interest rate.\n"; this.interestRate.lblInterestRate.ForeColor = System.Drawing.Color.Red;
                }
                if (this.interestModel.InterestRate > 100 && this.interestModel.InterestRateStatus == "%")
                {
                    countError++; errorMessage += countError + ". Maximum interest percentage is 100%.\n"; this.interestRate.lblInterestRate.ForeColor = System.Drawing.Color.Red;
                }

            }
            catch (Exception) { countError++; errorMessage += countError + ". Please specify the interest rate.\n"; this.interestRate.lblInterestRate.ForeColor = System.Drawing.Color.Red; }

            try
            {
                this.interestModel.Per = this.interestRate.getDuration();
            }
            catch (Exception) { countError++; errorMessage += countError + ". Please select duration of interest rate.\n"; this.interestRate.lblPer.ForeColor = System.Drawing.Color.Red; }

          /*  if (this.interestRate.getStatus())
            {
                this.interestModel.Status = 1;
            }
            else {
                this.interestModel.Status = 0;
            }
            */


            if (isAdd)
            {
                
                if (countError==0)
                {
                    

                    for (int i = 0; i < this.interestRate.dataInterest.Rows.Count; i++)
                    {
                        String[] arrInterest = this.interestRate.dataInterest.Rows[i].Cells[2].Value.ToString().Split(' ');
                        if (this.interestModel.InterestRate == double.Parse(arrInterest[0]) && this.interestModel.InterestRateStatus == arrInterest[1])
                        {
                            checkExist = 1;
                        }
                    }

                    if (checkExist == 1) {

                        DialogResult dialogResult = MessageBox.Show("Interest rate already exists. Are you sure you want to add?", "Loan Interest Rates", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            pass = 1;
                        }
                        else {
                            pass = 2;
                        }
                    }

                    if (pass == 1 || pass==0)
                    {
                        this.interestModel.insertInterestRate();
                        MessageBox.Show("Add success.", "Loan Interest Rates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.interestRate.checkArchivedState())
                        {
                            this.interestRate.loanGrid(this.interestModel.selectAllInterestRates());
                            DataGridViewRowCollection dr = this.interestRate.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.interestRate.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.interestRate.getSelectedData();
                        }
                        else 
                        {
                            this.interestRate.loanGrid(this.interestModel.selectInterestRates());
                        }
                        this.interestRate.disableFunction();
                        this.interestRate.resetDate();
                        isAdd = false;
                        TypeId = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Add failed!.\n\n" + errorMessage, "Loan Interest Rates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TypeId = 0;
                }
            }
            else
            {
                
                if (countError==0)
                {
                    for (int i = 0; i < this.interestRate.dataInterest.Rows.Count; i++)
                    {
                        String[] arrInterest = this.interestRate.dataInterest.Rows[i].Cells[2].Value.ToString().Split(' ');
                        if (this.interestRate.dataInterest.Rows[i].Cells[1].Value.ToString() != this.interestRate.cbLoanType.Text.ToString() && this.interestModel.InterestRate == double.Parse(arrInterest[0]) && this.interestModel.InterestRateStatus == arrInterest[1])
                        {
                            checkExist = 1;
                        }
                    }

                    if (checkExist == 1)
                    {

                        DialogResult dialogResult = MessageBox.Show("Interest rate already exists. Are you sure you want to add?", "Loan Interest Rates", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            pass = 1;
                        }
                        else
                        {
                            pass = 2;
                        }
                    }

                    if (pass == 1 || pass == 0)
                    {
                        this.interestModel.insertInterestRate();
                        MessageBox.Show("Update success!", "Loan Interest Rates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.interestRate.checkArchivedState())
                        {
                            this.interestRate.loanGrid(this.interestModel.selectAllInterestRates());
                            DataGridViewRowCollection dr = this.interestRate.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.interestRate.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.interestRate.getSelectedData();
                        }
                        else 
                        {
                            this.interestRate.loanGrid(this.interestModel.selectInterestRates());
                        }
                        this.interestRate.disableFunction();
                        this.interestRate.resetDate();
                        isAdd = false;
                        TypeId = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Update failed!.\n\n" + errorMessage, "Loan Interest Rates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }
    }
}
