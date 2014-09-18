using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CMS.Loan_Management.Maintenance.Controller
{
    class PenaltiesController
    {
        Maintenance.Model.PenaltiesModel penaltiesModel;
        Maintenance.View.Penalties penalties;
        Main.Logger logger = new Main.Logger();
        String nameCopy = String.Empty;
        int penaltyId = 0;
        Boolean isAdd = false;
        Dictionary<int, string> loanTypes = new Dictionary<int, string>();

        public PenaltiesController(Maintenance.Model.PenaltiesModel penaltiesModel, Maintenance.View.Penalties penalties, Loan_Management.LoanManagementMenu loanMenu)
        {
            this.penaltiesModel = penaltiesModel;
            this.penalties = penalties;
            this.penalties.setBtnAddEventHandler(this.btnAdd);
            this.penalties.setBtnCancelEventHandler(this.btnCancel);
            this.penalties.setBtnDeleteEventHandler(this.btnDelete);
            this.penalties.setBtnEditEventHandler(this.btnEdit);
            this.penalties.setBtnSaveEventHandler(this.btnSave);
            this.penalties.setBtnRetrieveEventHandler(this.btnRetrieve);
            this.penalties.txtSearch_TextChanged(this.btnSearch);
            this.penalties.cbShowArchive_CheckStateChanged(this.checkArchived);
            this.penalties.requirementGrid(this.penaltiesModel.selectPenalties());
            this.penalties.disableFunction();
            this.penalties.MdiParent = loanMenu;
            this.penalties.Show();
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Maintenance - Loan Penalties";
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

        public void btnSearch(object args, EventArgs e)
        {

            if (this.penalties.checkArchivedState())
            {
                this.penalties.requirementGrid(this.penaltiesModel.searchAllPenalties(this.penalties.getSearch()));
                DataGridViewRowCollection dr = this.penalties.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.penalties.setArchivedColor(i);
                    }
                    i++;
                }
            }
            else
            {
                this.penalties.requirementGrid(this.penaltiesModel.searchPenalties(this.penalties.getSearch()));
            }
            
        }
        
        public void clbLoanTypes() {

            loanTypes.Clear();
            DataTable ds = this.penaltiesModel.selectLoanTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                loanTypes.Add(int.Parse(dr["Type No"].ToString()),dr["Type Name"].ToString());

            }
            this.penalties.populateLoanTypes(loanTypes);
        }

        public void activeLoanTypes(int penaltyId)
        {

            ArrayList checkedTypes = new ArrayList();

            DataTable ds = this.penaltiesModel.selectActiveLoanTypes(penaltyId).Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                foreach (KeyValuePair<int, string> pair in loanTypes)
                {
                    if (int.Parse(dr[0].ToString()) == pair.Key)
                        checkedTypes.Add(pair.Value);
                }
            }
            this.penalties.toggleCheckedTypes(checkedTypes);

        }

        //retrieve

        public void checkArchived(object sender, EventArgs e)
        {
            if (this.penalties.checkArchivedState())
            {
                this.penalties.requirementGrid(this.penaltiesModel.selectAllPenalties());
                DataGridViewRowCollection dr = this.penalties.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.penalties.setArchivedColor(i);
                    }
                    i++;
                }
            }
            else
            {
                this.penalties.requirementGrid(this.penaltiesModel.selectPenalties());
            }
        }

        //retrieve
        public void btnRetrieve(object args, EventArgs e)
        {
            int checkExist = 0;


            String instaName = Regex.Replace(nameCopy, @"[^0-9a-zA-Z]+", String.Empty);
            for (int i = 0; i < this.penalties.dataPenalties.Rows.Count; i++)
            {
                String compareName = Regex.Replace(this.penalties.dataPenalties.Rows[i].Cells[1].Value.ToString(), @"[^0-9a-zA-Z]+", String.Empty);
                
                if (!(bool.Parse(this.penalties.dataPenalties.Rows[i].Cells[7].Value.ToString())) && instaName.Equals(compareName, StringComparison.InvariantCultureIgnoreCase))
                {
                    checkExist = 1;
                }

            }

            if (checkExist == 1)
            {
                MessageBox.Show("Name of archived loan penalty already exists.\nPlease edit loan penalty name, save and retrieve again.", "Loan Penalties", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool retrieveError = false;
                SqlDataReader sdr = penaltiesModel.checkExistingLoanTypes(penaltyId);
                while (sdr.Read())
                {
                    if (int.Parse(sdr[0].ToString()) > 0)
                    {
                        DialogResult dr = MessageBox.Show("'" + nameCopy + "' is available on loan types which are already deleted from the system. Do you want to continue retrieving this?", "Loan Charges", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                            retrieveError = true;
                        else
                            retrieveError = false;
                    }
                }
                if (retrieveError)
                {
                    this.penaltiesModel.retrievePenalty(this.penaltyId);
                    MessageBox.Show("Retrieve success!", "Loan Penalties", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Retrieve '" + nameCopy + "'");

                }
                else
                {
        
                    MessageBox.Show("Retrieve failed!", "Loan Penalties", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (this.penalties.checkArchivedState())
                {
                    this.penalties.requirementGrid(this.penaltiesModel.selectAllPenalties());
                    DataGridViewRowCollection dr = this.penalties.getAllRows();
                    int i = 0;
                    foreach (DataGridViewRow row in dr)
                    {
                        if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                        {
                            this.penalties.setArchivedColor(i);
                        }
                        i++;
                    }
                    this.penalties.setAllTextBlack();
                    this.penalties.disableFunction();
                }
                else
                {
                    this.penalties.requirementGrid(this.penaltiesModel.selectPenalties());
                    this.penalties.setAllTextBlack();
                    this.penalties.disableFunction();
                }
                isAdd = false;
                penaltyId = 0;
            }
        }

        public void btnAdd(object args, EventArgs e)
        {
            this.penalties.enableFunction();
            this.penalties.setStatus();
            this.clbLoanTypes();
            isAdd = true;
            penaltyId = 0;
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.penalties.disableFunction();
            isAdd = false;
            penaltyId = 0;
            this.penalties.setAllTextBlack();
        }

        public void btnDelete(object args, EventArgs e)
        {
            try
              {
                DataGridViewRow selectedData = this.penalties.getSelected();
            if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
            {
                MessageBox.Show("Archived data cannot be deleted.", "Loan Penalties", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Loan Penalties", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string resu = result.ToString();

                if (resu == "Yes")
                {
                    
                        penaltyId = int.Parse(selectedData.Cells["Penalty Id"].Value.ToString());

                        if (penaltiesModel.deletePenalties(penaltyId) == 1)
                        {
                            MessageBox.Show("Delete success!", "Loan Penalties", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            execLogger("Delete '" + selectedData.Cells["Penalty Name"].Value.ToString() + "'");

                            if (this.penalties.checkArchivedState())
                            {
                                this.penalties.requirementGrid(this.penaltiesModel.selectAllPenalties());
                                DataGridViewRowCollection dr = this.penalties.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.penalties.setArchivedColor(i);
                                    }
                                    i++;
                                }
                                this.penalties.setAllTextBlack();
                                this.penalties.disableFunction();
                            }
                            else
                            {
                                this.penalties.requirementGrid(this.penaltiesModel.selectPenalties());
                                this.penalties.setAllTextBlack();
                                this.penalties.disableFunction();
                            }


                        }
                        else
                        {
                            MessageBox.Show("Delete Failed.", "Delete Loan Penalty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        penaltyId = 0;
                    
                }
            }
            }catch (Exception)
                    {
                        MessageBox.Show("No rows were selected.", "Delete Loan Penalty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
        }

        public void btnEdit(object args, EventArgs e)
        {
         try{
                penalties.enableFunction();
                this.clbLoanTypes();
               // try
               // {
                    DataGridViewRow selectedData = this.penalties.getSelected();
                 //retrieve
                    if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                    {
                        this.penalties.showRetrieve();
                    }
                    else
                    {
                        this.penalties.hideRetrieve();
                    }
                
                isAdd = false;
                penaltyId = int.Parse(selectedData.Cells["Penalty Id"].Value.ToString());
                this.activeLoanTypes(penaltyId);
                int GracePeriod = int.Parse(selectedData.Cells["Grace Period"].Value.ToString());
                String[] arrPenalty = (selectedData.Cells["Penalty"].Value.ToString()).Split(' ');
                String[] arrDuration = (selectedData.Cells["Duration"].Value.ToString()).Split(' ');
                String deduction = selectedData.Cells["Deduction"].Value.ToString();
                String ChargeName = selectedData.Cells["Penalty Name"].Value.ToString();
                nameCopy = ChargeName;
                
                bool Status = bool.Parse(selectedData.Cells["Active"].Value.ToString());

                if (Status)
                {
                    this.penalties.setStatus();
                }

                if (GracePeriod != 0) { this.penalties.setGracePeriod(GracePeriod); this.penalties.setCheckBox(); }
                this.penalties.setChargeName(ChargeName);
               
                this.penalties.setDeduction(deduction);
                this.penalties.setAmount(double.Parse(arrPenalty[0]));
                this.penalties.setAmountStatus(arrPenalty[1]);
                this.penalties.setDuration(int.Parse(arrDuration[0]));
                this.penalties.setDurationStatus(arrDuration[1]);
               // }
               // catch (ArgumentException) { MessageBox.Show("No rows selected.", "Edit Loan Penalty", MessageBoxButtons.OK, MessageBoxIcon.Error); penalties.disableFunction(); }
        }catch (Exception) {
            MessageBox.Show("No rows were selected.", "Loan Penalties", MessageBoxButtons.OK, MessageBoxIcon.Error);
               penalties.disableFunction();
           }
        }

        public void btnSave(object args, EventArgs e)
        {
            String chargeName = penalties.getChargeName();
            int gracePeriod = penalties.getGracePeriod();
            double amount = 0;
            String amountStatus = "";
            String deduction = "";
            String durationStatus = "";
            int durationValue = penalties.getDuration();
            int Status = 0;

            String errorMessage = String.Empty;
            int countError = 0;
            int checkExist = 0;
            this.penalties.setAllTextBlack();

            

            try
            {
                amountStatus = penalties.getAmountStatus();
            }
            catch (Exception)
            {
                countError++;
                errorMessage += countError + ". Please specify amount mode.\n";
                this.penalties.lblAmount.ForeColor = System.Drawing.Color.Red;
            }

            try
            {
                amount = penalties.getAmount();
                if (amount == 0)
                {
                    countError++; errorMessage += countError + ". Please specify penalty amount.\n"; this.penalties.lblAmount.ForeColor = System.Drawing.Color.Red;
                }
                if (amount > 100 && (amountStatus == "%"))
                {
                    countError++; errorMessage += countError + ". Maximum penalty percentage is 100%.\n"; this.penalties.lblAmount.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {

                countError++;
                errorMessage += countError + ". Please specify penalty amount.\n";
                this.penalties.lblAmount.ForeColor = System.Drawing.Color.Red;

            }

            if (this.penalties.getDeductionStatus())
            {
                try
                {
                    deduction = penalties.getDeduction();

                }
                catch (Exception)
                {
                    countError++;
                    errorMessage += countError + ". Please specify deduction.\n";
                    this.penalties.lblBasis.ForeColor = System.Drawing.Color.Red;
                }
            }

            try
            {
               durationStatus= penalties.getDurationStatus();
            }
            catch (Exception)
            {
                countError++;
                errorMessage += countError + ". Please specify duration.\n";
                this.penalties.lblDuration.ForeColor = System.Drawing.Color.Red;
            }

            CheckedListBox.CheckedItemCollection loanTypeName = penalties.getCheckedTypes();
            ArrayList loanTypeNo = new ArrayList();
            foreach (String s in loanTypeName) 
            {
                foreach (KeyValuePair<int, string> pair in loanTypes) 
                {
                    if (s.Equals(pair.Value))
                        loanTypeNo.Add(pair.Key);
                }  
            }

            if (penalties.getStatus())
            {
                Status = 1;
            }

            String instaName = Regex.Replace(chargeName, @"[^0-9a-zA-Z]+", String.Empty);

          

            for (int i = 0; i < this.penalties.dataPenalties.Rows.Count; i++)
            {
                String compareName = Regex.Replace(this.penalties.dataPenalties.Rows[i].Cells[1].Value.ToString(), @"[^0-9a-zA-Z]+", String.Empty);
                if (isAdd)
                {
                    if (!(bool.Parse(this.penalties.dataPenalties.Rows[i].Cells[7].Value.ToString())) && instaName.Equals(compareName, StringComparison.InvariantCultureIgnoreCase))
                    { 
                        checkExist = 1;
                    }
                }
                else
                {
                    if (!(bool.Parse(this.penalties.dataPenalties.Rows[i].Cells[7].Value.ToString())) && nameCopy != this.penalties.dataPenalties.Rows[i].Cells[1].Value.ToString() && instaName.Equals(compareName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        checkExist = 1;
                    }
                }
            }

            if (checkExist == 1) { countError++; errorMessage += countError + ". Penalty name already exists.\n"; this.penalties.lblPenaltyName.ForeColor = System.Drawing.Color.Red; }
            if (chargeName == String.Empty) { countError++; errorMessage += countError + ". Please specify name of penalty.\n"; this.penalties.lblPenaltyName.ForeColor = System.Drawing.Color.Red; }
            if (loanTypeNo.Count == 0) { countError++; errorMessage += countError + ". Please check one or more loan types.\n"; this.penalties.lblLoanType.ForeColor = System.Drawing.Color.Red; }
            if (penalties.cbGrace.Checked) { if (gracePeriod == 0) { countError++; errorMessage += countError + ". Please specify grace period.\n"; this.penalties.lblGracePeriod.ForeColor = System.Drawing.Color.Red; } }
            if (durationValue == 0)
            {
                countError++; errorMessage += countError + ". Please specify no. of duration.\n"; this.penalties.lblDuration.ForeColor = System.Drawing.Color.Red;
            }

            if (isAdd)
            {
                if (countError==0 && this.penaltiesModel.insertPenalties(chargeName, gracePeriod, amount, amountStatus, deduction, durationStatus, durationValue, loanTypeNo, Status) != 0)
                {
                    MessageBox.Show("Add success!", "Loan Penalties", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Add '" + chargeName + "'");

                    if (this.penalties.checkArchivedState())
                    {
                        this.penalties.requirementGrid(this.penaltiesModel.selectAllPenalties());
                        DataGridViewRowCollection dr = this.penalties.getAllRows();
                        int i = 0;
                        foreach (DataGridViewRow row in dr)
                        {
                            if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                            {
                                this.penalties.setArchivedColor(i);
                            }
                            i++;
                        }
                        this.penalties.setAllTextBlack();
                        this.penalties.disableFunction();
                    }
                    else
                    {
                        this.penalties.requirementGrid(this.penaltiesModel.selectPenalties());
                        this.penalties.setAllTextBlack();
                        this.penalties.disableFunction();
                    }
                    penaltyId = 0;
                }
                else
                {
                    MessageBox.Show("Add failed!\n\n" + errorMessage, "Loan Penalties", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    penaltyId = 0;
                }
            }
            else
            {
                if (countError==0 && this.penaltiesModel.updatePenalties(penaltyId, chargeName, gracePeriod, amount, amountStatus, deduction, durationStatus, durationValue, loanTypeNo, Status) != 0)
                {
                    MessageBox.Show("Update success!", "Loan Penalties", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Update '" + chargeName + "'");

                    if (this.penalties.checkArchivedState())
                    {
                        this.penalties.requirementGrid(this.penaltiesModel.selectAllPenalties());
                        DataGridViewRowCollection dr = this.penalties.getAllRows();
                        int i = 0;
                        foreach (DataGridViewRow row in dr)
                        {
                            if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                            {
                                this.penalties.setArchivedColor(i);
                            }
                            i++;
                        }
                        this.penalties.setAllTextBlack();
                        this.penalties.disableFunction();
                    }
                    else
                    {
                        this.penalties.requirementGrid(this.penaltiesModel.selectPenalties());
                        this.penalties.setAllTextBlack();
                        this.penalties.disableFunction();
                    }
                    penaltyId = 0;
                }
                else
                {
                    MessageBox.Show("Update failed!\n\n" + errorMessage, "Loan Penalties", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
           
        
    }
}
