using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Maintenance.Controller
{
    class LoanChargesController
    {
        Maintenance.Model.LoanChargesModel loanChargeModel;
        Maintenance.View.LoanCharges loanCharge;

        String nameCopy = String.Empty;
        int chargeId = 0;
        Boolean isAdd = false;
        Dictionary<int, string> loanTypes = new Dictionary<int, string>();

        public LoanChargesController(Maintenance.Model.LoanChargesModel loanChargeModel, Maintenance.View.LoanCharges loanCharge, Loan_Management.LoanManagementMenu loanMenu)
        {
            this.loanChargeModel = loanChargeModel;
            this.loanCharge = loanCharge;
            this.loanCharge.setBtnAddEventHandler(this.btnAdd);
            this.loanCharge.setBtnCancelEventHandler(this.btnCancel);
            this.loanCharge.setBtnDeleteEventHandler(this.btnDelete);
            this.loanCharge.setBtnEditEventHandler(this.btnEdit);
            this.loanCharge.setBtnSaveEventHandler(this.btnSave);
            this.loanCharge.setBtnRetrieveEventHandler(this.btnRetrieve);
            this.loanCharge.txtSearch_TextChanged(this.btnSearch);
            this.loanCharge.cbShowArchive_CheckStateChanged(this.checkArchived);
            this.loanCharge.requirementGrid(this.loanChargeModel.selectloanCharge());
            this.loanCharge.disableFunction();
            this.loanCharge.MdiParent = loanMenu;
            this.loanCharge.Show();
        }

        public void btnSearch(object args, EventArgs e)
        {
            if (this.loanCharge.checkArchivedState())
            {
                this.loanCharge.requirementGrid(this.loanChargeModel.searchAllLoanCharge(this.loanCharge.getSearch()));
                DataGridViewRowCollection dr = this.loanCharge.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.loanCharge.setArchivedColor(i);
                    }
                    i++;
                }
            }
            else
            {
                this.loanCharge.requirementGrid(this.loanChargeModel.searchloanCharge(this.loanCharge.getSearch()));
            }
           
        }
        
        public void clbLoanTypes() {

            loanTypes.Clear();
            DataTable ds = this.loanChargeModel.selectLoanTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                loanTypes.Add(int.Parse(dr["Type No"].ToString()),dr["Type Name"].ToString());

            }
            this.loanCharge.populateLoanTypes(loanTypes);
        }

        public void activeLoanTypes(int chargeId)
        {

            ArrayList checkedTypes = new ArrayList();

            DataTable ds = this.loanChargeModel.selectActiveLoanTypes(chargeId).Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                foreach (KeyValuePair<int, string> pair in loanTypes)
                {
                    if (int.Parse(dr[0].ToString()) == pair.Key)
                        checkedTypes.Add(pair.Value);
                }
            }
            this.loanCharge.toggleCheckedTypes(checkedTypes);

        }

        public void btnAdd(object args, EventArgs e)
        {
            this.loanCharge.enableFunction();
            this.loanCharge.setStatus();
            this.clbLoanTypes();
            isAdd = true;
            chargeId = 0;
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.loanCharge.disableFunction();
            isAdd = false;
            chargeId = 0;
            this.loanCharge.setAllTextBlack();
        }

        public void btnDelete(object args, EventArgs e)
        {
       try{
            DataGridViewRow selectedData = this.loanCharge.getSelected();
            if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
            {
                MessageBox.Show("Archived data cannot be deleted.", "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Loan Charges", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string resu = result.ToString();


                if (resu == "Yes")
                {
                   
                        chargeId = int.Parse(selectedData.Cells["Charge Id"].Value.ToString());
                        if (loanChargeModel.deleteloanCharge(chargeId) == 1)
                        {

                            MessageBox.Show("Delete Success.", "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.loanCharge.checkArchivedState())
                            {
                                this.loanCharge.requirementGrid(this.loanChargeModel.selectAllLoanCharge());
                                DataGridViewRowCollection dr = this.loanCharge.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.loanCharge.setArchivedColor(i);
                                    }
                                    i++;
                                }
                                this.loanCharge.setAllTextBlack();
                                this.loanCharge.disableFunction();
                            }
                            else
                            {
                                this.loanCharge.requirementGrid(this.loanChargeModel.selectloanCharge());
                                this.loanCharge.setAllTextBlack();
                                this.loanCharge.disableFunction();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed.", "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        chargeId = 0;
                    }
                   
                }
            }
             catch (Exception)
             {
                 MessageBox.Show("No rows were selected.", "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 loanCharge.disableFunction();
             }
        }

        public void btnEdit(object args, EventArgs e)
        {
           try
            {
                loanCharge.enableFunction();
                this.clbLoanTypes();
                try
                {
                    DataGridViewRow selectedData = this.loanCharge.getSelected();
                    if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                    {
                        this.loanCharge.showRetrieve();
                    }
                    else
                    {
                        this.loanCharge.hideRetrieve();
                    }
                
                isAdd = false;
                chargeId = int.Parse(selectedData.Cells["Charge Id"].Value.ToString());
                this.activeLoanTypes(chargeId);
                String[] arrCharge = selectedData.Cells["Charge"].Value.ToString().Split(' ');
                double Amount = double.Parse(arrCharge[0]);
                String AmountStatus = String.Empty;
                    if(arrCharge[1]=="Php"){ AmountStatus = arrCharge[1];}
                    else if (arrCharge[3] == "loan") { AmountStatus = arrCharge[1] + " " + arrCharge[2] + " " + arrCharge[3] + " " + arrCharge[4]; }
                    else { AmountStatus = arrCharge[1] + " " + arrCharge[2] + " " + arrCharge[3]; }
                
                String ChargeName = selectedData.Cells["Charge Name"].Value.ToString();
                nameCopy = ChargeName;
                
                bool Status = bool.Parse(selectedData.Cells["Status"].Value.ToString());

                if (Status)
                {
                    this.loanCharge.setStatus();
                }

                this.loanCharge.setChargeName(ChargeName);
                this.loanCharge.setAmount(Amount);
                this.loanCharge.setOption(AmountStatus);
                }
                catch (ArgumentException) { MessageBox.Show("No rows selected.", "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Error); loanCharge.disableFunction(); }
            }
            catch (Exception) {
                MessageBox.Show("No rows were selected.", "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loanCharge.disableFunction();
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            String chargeName = loanCharge.getChargeName();
            double amount = 0;
            String amountStatus = String.Empty;
            int Status = 0;
            CheckedListBox.CheckedItemCollection loanTypeName = loanCharge.getCheckedTypes();
            ArrayList loanTypeNo = new ArrayList();

            String errorMessage = String.Empty;
            int countError = 0;
            int checkExist = 0;
            this.loanCharge.setAllTextBlack();

          

            foreach (String s in loanTypeName) 
            {
                foreach (KeyValuePair<int, string> pair in loanTypes) 
                {
                    if (s.Equals(pair.Value))
                        loanTypeNo.Add(pair.Key);
                }
            }

            if (loanCharge.getStatus())
            {
                Status = 1;
            }

     
            

            String instaName = Regex.Replace(chargeName, @"[^0-9a-zA-Z]+", String.Empty);

            for (int i = 0; i < this.loanCharge.dataLoanCharge.Rows.Count; i++)
            {
                String compareName = Regex.Replace(this.loanCharge.dataLoanCharge.Rows[i].Cells[1].Value.ToString(), @"[^0-9a-zA-Z]+", String.Empty);
                if (isAdd)
                {
                    if (!(bool.Parse(this.loanCharge.dataLoanCharge.Rows[i].Cells[4].Value.ToString())) && instaName.Equals(compareName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        checkExist = 1;
                    }
                }
                else {
                    if (!(bool.Parse(this.loanCharge.dataLoanCharge.Rows[i].Cells[4].Value.ToString())) && nameCopy != this.loanCharge.dataLoanCharge.Rows[i].Cells[1].Value.ToString() && instaName.Equals(compareName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        checkExist = 1;
                    }
                }
            }

            if (checkExist == 1) { countError++; errorMessage += countError + ". Loan Charge already exists.\n"; this.loanCharge.lblChargeName.ForeColor = System.Drawing.Color.Red; }
            if (chargeName == String.Empty) { countError++; errorMessage += countError + ". Please specify charge name.\n"; this.loanCharge.lblChargeName.ForeColor = System.Drawing.Color.Red; }
            try
            {
                amount = loanCharge.getAmount();
                if (amount == 0)
                {
                    countError++; errorMessage += countError + ". Please specify charge amount.\n"; this.loanCharge.lblAmount.ForeColor = System.Drawing.Color.Red;
                }
                if (amount > 100 && (amountStatus == "% of loan amount" || amountStatus == "% of amortization"))
                {
                    countError++; errorMessage += countError + ". Maximum charge percentage is 100%.\n"; this.loanCharge.lblAmount.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {
                countError++;
                errorMessage += countError + ". Please specify charge amount.\n";
                this.loanCharge.lblAmount.ForeColor = System.Drawing.Color.Red;

            }
            if (loanTypeNo.Count == 0) { countError++; errorMessage += countError + ". Please select one or more loan type.\n"; this.loanCharge.lblLoanType.ForeColor = System.Drawing.Color.Red; }
            
            try 
            {
                amountStatus = loanCharge.getOption();
            }
            catch (Exception) { countError++; errorMessage += countError + ". Please select charge amount mode.\n"; this.loanCharge.lblAmount.ForeColor = System.Drawing.Color.Red; }

            if (isAdd)
            {
                if (countError==0 && this.loanChargeModel.insertloanCharge(chargeName, amount, amountStatus, loanTypeNo, Status) == 1)
                {
                    MessageBox.Show("Add Success.", "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (this.loanCharge.checkArchivedState())
                    {
                        this.loanCharge.requirementGrid(this.loanChargeModel.selectAllLoanCharge());
                        DataGridViewRowCollection dr = this.loanCharge.getAllRows();
                        int i = 0;
                        foreach (DataGridViewRow row in dr)
                        {
                            if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                            {
                                this.loanCharge.setArchivedColor(i);
                            }
                            i++;
                        }
                        this.loanCharge.setAllTextBlack();
                        this.loanCharge.disableFunction();
                    }
                    else
                    {
                        this.loanCharge.requirementGrid(this.loanChargeModel.selectloanCharge());
                        this.loanCharge.setAllTextBlack();
                        this.loanCharge.disableFunction();
                    }
                    chargeId = 0;
                }
                else
                {
                    MessageBox.Show("Add Failed!\n\n" + errorMessage, "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chargeId = 0;
                }
            }
            else
            {
                if (countError==0 && this.loanChargeModel.updateloanCharge(chargeId, chargeName, amount, amountStatus, loanTypeNo, Status) != 0)
                {
                    MessageBox.Show("Update Success.", "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (this.loanCharge.checkArchivedState())
                    {
                        this.loanCharge.requirementGrid(this.loanChargeModel.selectAllLoanCharge());
                        DataGridViewRowCollection dr = this.loanCharge.getAllRows();
                        int i = 0;
                        foreach (DataGridViewRow row in dr)
                        {
                            if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                            {
                                this.loanCharge.setArchivedColor(i);
                            }
                            i++;
                        }
                        this.loanCharge.setAllTextBlack();
                        this.loanCharge.disableFunction();
                    }
                    else
                    {
                        this.loanCharge.requirementGrid(this.loanChargeModel.selectloanCharge());
                        this.loanCharge.setAllTextBlack();
                        this.loanCharge.disableFunction();
                    }
                    chargeId = 0;
                }
                else
                {
                    MessageBox.Show("Update Failed!\n\n" + errorMessage, "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        public void checkArchived(object sender, EventArgs e)
        {
            if (this.loanCharge.checkArchivedState())
            {
                this.loanCharge.requirementGrid(this.loanChargeModel.selectAllLoanCharge());
                DataGridViewRowCollection dr = this.loanCharge.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.loanCharge.setArchivedColor(i);
                    }
                    i++;
                }
            }
            else
            {
                this.loanCharge.requirementGrid(this.loanChargeModel.selectloanCharge());
            }
        }

        //retrieve
        public void btnRetrieve(object args, EventArgs e)
        {
            int checkExist = 0;


            String instaName = Regex.Replace(nameCopy, @"[^0-9a-zA-Z]+", String.Empty);
            for (int i = 0; i < this.loanCharge.dataLoanCharge.Rows.Count; i++)
            {
                String compareName = Regex.Replace(this.loanCharge.dataLoanCharge.Rows[i].Cells[1].Value.ToString(), @"[^0-9a-zA-Z]+", String.Empty);

                if (!(bool.Parse(this.loanCharge.dataLoanCharge.Rows[i].Cells[4].Value.ToString())) && instaName.Equals(compareName, StringComparison.InvariantCultureIgnoreCase))
                {
                    checkExist = 1;
                }

            }

            if (checkExist == 1)
            {
                MessageBox.Show("Name of archived loan penalty already exists.\nPlease edit loan penalty name, save and retrieve again.", "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool retrieveError = false;
                SqlDataReader sdr = loanChargeModel.checkExistingLoanTypes(chargeId);
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
                    this.loanChargeModel.retrieveLoanCharge(this.chargeId);
                    MessageBox.Show("Retrieve success!", "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Retrieve failed!", "Loan Charges", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    if (this.loanCharge.checkArchivedState())
                    {
                        this.loanCharge.requirementGrid(this.loanChargeModel.selectAllLoanCharge());
                        DataGridViewRowCollection dr = this.loanCharge.getAllRows();
                        int i = 0;
                        foreach (DataGridViewRow row in dr)
                        {
                            if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                            {
                                this.loanCharge.setArchivedColor(i);
                            }
                            i++;
                        }
                        this.loanCharge.setAllTextBlack();
                        this.loanCharge.disableFunction();
                    }
                    else
                    {
                        this.loanCharge.requirementGrid(this.loanChargeModel.selectloanCharge());
                        this.loanCharge.setAllTextBlack();
                        this.loanCharge.disableFunction();
                    }
                    isAdd = false;
                    chargeId = 0;

            }
        }
         
      
     }
}
