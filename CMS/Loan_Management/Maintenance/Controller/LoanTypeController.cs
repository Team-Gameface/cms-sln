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
    class LoanAccountTypeController
    {
        Maintenance.Model.LoanTypeModel loanAccountTypeModel;
        Maintenance.View.LoanTypes loanType;

        Boolean isAdd = false;
        int TypeId = 0;
        String nameCopy = String.Empty;

        Dictionary<int, string> memberTypes = new Dictionary<int, string>();

        public LoanAccountTypeController(Maintenance.Model.LoanTypeModel loanAccountTypeModel, Maintenance.View.LoanTypes loanType, Loan_Management.LoanManagementMenu loanMenu)
        {
            this.loanAccountTypeModel = loanAccountTypeModel;
            this.loanType = loanType;
            this.loanType.btnAddEventHandler(this.btnAdd);
            this.loanType.btnEditEventHandler(this.btnEdit);
            this.loanType.btnDeleteEventHandler(this.btnDelete);
            this.loanType.btnSaveEventHandler(this.btnSave);
            this.loanType.btnCancelEventHandler(this.btnCancel);
            this.loanType.setBtnRetrieveEventHandler(this.btnRetrieve);
            this.loanType.cbShowArchive_CheckStateChanged(this.checkArchived);
            this.loanType.loanTypeGrid(this.loanAccountTypeModel.selectloanTypes());
            this.loanType.disableFunction();
            this.loanType.MdiParent = loanMenu;
            this.loanType.Show();
        }


        public void clbMemberTypes()
        {

            memberTypes.Clear();
            DataTable ds = this.loanAccountTypeModel.selectMemberTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                memberTypes.Add(int.Parse(dr["Type No"].ToString()), dr["Type Name"].ToString());

            }
            this.loanType.populateMemberTypes(memberTypes);
        }

        public void activeMemberTypes(int reqNo)
        {

            ArrayList checkedTypes = new ArrayList();

            DataTable ds = this.loanAccountTypeModel.selectActiveMemberTypes(reqNo).Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                foreach (KeyValuePair<int, string> pair in memberTypes)
                {
                    if (int.Parse(dr[0].ToString()) == pair.Key)
                        checkedTypes.Add(pair.Value);
                }
            }
            this.loanType.toggleCheckedTypes(checkedTypes);

        }


        public void btnAdd(object args, EventArgs e) {
            this.clbMemberTypes();
            this.loanType.enableFunction();
            this.loanType.setStatus();
            isAdd = true;
        }
        

        
        public void btnEdit(object args, EventArgs e) {

            try
            {
                loanType.enableFunction();
                this.clbMemberTypes();
               
                    DataGridViewRow selectedData = this.loanType.getSelected();
                    if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                    {
                        this.loanType.showRetrieve();
                    }
                    else
                    {
                        this.loanType.hideRetrieve();
                    }

                    isAdd = false;
                    TypeId = int.Parse(selectedData.Cells["Loan Type Id"].Value.ToString());
                    this.activeMemberTypes(TypeId);
                    String LoanTypeName = selectedData.Cells["Loan Type Name"].Value.ToString();
                    nameCopy = LoanTypeName;
                    String[] arrMinPD = (selectedData.Cells["Minimum Payment Duration"].Value.ToString()).Split(' ');
                    String[] arrMaxPD = (selectedData.Cells["Maximum Payment Duration"].Value.ToString()).Split(' ');
                    double maxLoanFixed = double.Parse(selectedData.Cells["Maximum Loan (Fixed)"].Value.ToString());
                    double maxLoanShareCap = double.Parse(selectedData.Cells["Maximum Loan (Share Capital)"].Value.ToString());
                    int coMaker = int.Parse(selectedData.Cells["CoMaker"].Value.ToString());

                    bool Collateral = bool.Parse(selectedData.Cells["isCollateral"].Value.ToString());
                    bool Status = bool.Parse(selectedData.Cells["Active"].Value.ToString());


                    if (Collateral)
                    {
                        this.loanType.setCollateral();
                    }


                    if (Status)
                    {
                        this.loanType.setStatus();
                    }

                   this.loanType.setTextName(LoanTypeName);
                   this.loanType.setMinimumPayment(int.Parse(arrMinPD[0]));
                   this.loanType.setMinimumStatus(arrMinPD[1]);
                   if (arrMaxPD[1] == "infinity") 
                   { 
                   
                   }
                   else
                   {
                       this.loanType.setMaximumPaymentDuration();
                       this.loanType.setMaximumPayment(int.Parse(arrMaxPD[0]));
                       this.loanType.setMaximumStatus(arrMaxPD[1]);
                   }
                   this.loanType.setMaximumAmount(maxLoanFixed);
                   this.loanType.setTimesOfShareCap(maxLoanShareCap);
                   this.loanType.setComakers(coMaker);
           
            }
            catch (Exception)
            {
                MessageBox.Show("No rows were selected.", "Loan Types", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loanType.disableFunction();
            }
        
        
        }

        public void btnDelete(object args, EventArgs e) {
            try
            {
                DataGridViewRow selectedData = this.loanType.getSelected();

                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    MessageBox.Show("Archived data cannot be deleted.", "Loan Types", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Loan Types", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        TypeId = int.Parse(selectedData.Cells["Loan Type Id"].Value.ToString());
                        if (this.loanAccountTypeModel.deleteLoanType(TypeId) > 0)
                        {
                            MessageBox.Show("Delete success!", "Loan Types", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.loanType.checkArchivedState())
                            {
                                this.loanType.loanTypeGrid(this.loanAccountTypeModel.selectAllLoanTypes());
                                DataGridViewRowCollection dr = this.loanType.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.loanType.setArchivedColor(i);
                                    }
                                    i++;
                                }
                                this.loanType.setAllLabelsToBlack();
                                this.loanType.disableFunction();
                            }
                            else
                            {
                                this.loanType.loanTypeGrid(this.loanAccountTypeModel.selectloanTypes());
                                this.loanType.setAllLabelsToBlack();
                                this.loanType.disableFunction();
                            }
                            isAdd = false;
                            TypeId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Delete failed!", "Loan Types", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isAdd = false;
                            TypeId = 0;
                        }
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("No rows were selected.", "Loan Types", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loanType.disableFunction();
            } 
        }
        public void btnSave(object args, EventArgs e) {
            int Status = 0, Collateral=0;
            this.loanType.setAllLabelsToBlack();

            String errorMessage = String.Empty;
            int countError = 0;
            int checkExist = 0;

            
            this.loanAccountTypeModel.MinValue = this.loanType.getMinimumPayment();
            this.loanAccountTypeModel.MaxValue = this.loanType.getMaximumPayment();
            this.loanAccountTypeModel.Comakers = this.loanType.getComakers();

            

           

            
            CheckedListBox.CheckedItemCollection memberTypeName = loanType.getCheckedTypes();
            ArrayList memberTypeNo = new ArrayList();
            
            foreach (String s in memberTypeName)
            {
                foreach (KeyValuePair<int, string> pair in memberTypes)
                {
                    if (s.Equals(pair.Value))
                        memberTypeNo.Add(pair.Key);
                }
            }


            if (loanType.getCollateral())
            {
                Collateral = 1;
            }

            
            if (loanType.getStatus())
            {
                Status = 1;
            }

            this.loanAccountTypeModel.Name = this.loanType.getTextName();
            String instaName = Regex.Replace(this.loanAccountTypeModel.Name, @"[^0-9a-zA-Z]+", String.Empty);
            
            
            //Check if may duplicate sa name
            for (int i = 0; i < this.loanType.dataGridView.Rows.Count; i++)
            {
                String compareName = Regex.Replace(this.loanType.dataGridView.Rows[i].Cells[1].Value.ToString(), @"[^0-9a-zA-Z]+", String.Empty);
                if (isAdd)
                {

                    if (!(bool.Parse(this.loanType.dataGridView.Rows[i].Cells[9].Value.ToString())) && instaName.Equals(compareName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        checkExist = 1;
                    }
                }
                else {
                    if (!(bool.Parse(this.loanType.dataGridView.Rows[i].Cells[9].Value.ToString())) && nameCopy != this.loanType.dataGridView.Rows[i].Cells[1].Value.ToString() && instaName.Equals(compareName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        checkExist = 1;
                    }
                
                }
            }

            if (checkExist == 1) { countError++; errorMessage += countError + ". Name of loan type already exists.\n"; this.loanType.lblName.ForeColor = System.Drawing.Color.Red; }
            if (this.loanAccountTypeModel.Name == String.Empty) { countError++; errorMessage += countError + ". Please specify name of loan type.\n"; this.loanType.lblName.ForeColor = System.Drawing.Color.Red; }
            if (memberTypeNo.Count == 0) { countError++; errorMessage += countError + ". Please check 1 or more member type.\n"; this.loanType.gbAvailability.ForeColor = System.Drawing.Color.Red; }
            if (this.loanAccountTypeModel.Comakers < 0) { countError++; errorMessage += countError + ". Minimum allowable payment duration must be >=0.\n"; this.loanType.lblComaker.ForeColor = System.Drawing.Color.Red; }
            if (this.loanAccountTypeModel.MinValue < 1) { countError++; errorMessage += countError + ". Please specify minimum allowable payment duration.\n"; this.loanType.lblMinimumPaymentDur.ForeColor = System.Drawing.Color.Red; }
            if (this.loanType.getMaximumPaymentDurationStatus() && this.loanAccountTypeModel.MaxValue < 1) { countError++; errorMessage += countError + ". Please specify maximum allowable payment duration.\n"; this.loanType.chbMaximumPaymentDur.ForeColor = System.Drawing.Color.Red; }

            if (!this.loanType.getMaximumPaymentDurationStatus()) 
            {
                this.loanAccountTypeModel.MaxStatus = "infinity";
                this.loanAccountTypeModel.MaxValue = 0;
            }

            try
            {
                this.loanAccountTypeModel.MinStatus = this.loanType.getMinimumStatus();
            }
            catch (Exception) { countError++; errorMessage += countError + ". Please specify minimum payment duration status.\n"; this.loanType.lblMinimumPaymentDur.ForeColor = System.Drawing.Color.Red; }

            if (this.loanType.getMaximumPaymentDurationStatus())
            {
                try
                {
                    this.loanAccountTypeModel.MaxStatus = this.loanType.getMaximumStatus();
                }
                catch (Exception) { countError++; errorMessage += countError + ". Please specify maximum payment duration status.\n"; this.loanType.chbMaximumPaymentDur.ForeColor = System.Drawing.Color.Red; }

            }            

            if (this.loanType.getMaximumPaymentDurationStatus())
            {
                if (this.loanAccountTypeModel.MinStatus == this.loanAccountTypeModel.MaxStatus)
                {
                    if (this.loanAccountTypeModel.MinValue > this.loanAccountTypeModel.MaxValue)
                    {
                        countError++; errorMessage += countError + ". Minimum allowable payment duration exceeds the maximum.\n";
                        this.loanType.lblMinimumPaymentDur.ForeColor = System.Drawing.Color.Red;
                        this.loanType.chbMaximumPaymentDur.ForeColor = System.Drawing.Color.Red;
                    }

                    else if (this.loanAccountTypeModel.MinValue == this.loanAccountTypeModel.MaxValue)
                    {
                        countError++; errorMessage += countError + ". Minimum allowable payment duration must be different from the maximum.\n";
                        this.loanType.lblMinimumPaymentDur.ForeColor = System.Drawing.Color.Red;
                        this.loanType.chbMaximumPaymentDur.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }

            else
            {
                if (this.loanType.getMaximumPaymentDurationStatus())
                {
                    if ((this.loanAccountTypeModel.MinStatus == "month/s" && this.loanAccountTypeModel.MaxStatus == "week/s") || (this.loanAccountTypeModel.MinStatus == "year/s" && this.loanAccountTypeModel.MaxStatus == "month/s") || (this.loanAccountTypeModel.MinStatus == "year/s" && this.loanAccountTypeModel.MaxStatus == "week/s"))
                    {
                        countError++; errorMessage += countError + ". Minimum allowable payment duration exceeds the maximum.\n";
                        this.loanType.lblMinimumPaymentDur.ForeColor = System.Drawing.Color.Red;
                        this.loanType.chbMaximumPaymentDur.ForeColor = System.Drawing.Color.Red;
                    }
                }

            }


                try
                {
                    this.loanAccountTypeModel.MaxAmtFixed = this.loanType.getMaximumAmount();

                    if (this.loanAccountTypeModel.MaxAmtFixed == 0)
                    {
                        countError++; errorMessage += countError + ". Please specify maximum loanable amount (fixed).\n"; this.loanType.lblMaxLoanableAmt.ForeColor = System.Drawing.Color.Red; this.loanType.lblFixed.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (FormatException) { countError++; errorMessage += countError + ". Please specify maximum loanable amount (fixed).\n"; this.loanType.lblMaxLoanableAmt.ForeColor = System.Drawing.Color.Red; this.loanType.lblFixed.ForeColor = System.Drawing.Color.Red; }

                try
                {
                    this.loanAccountTypeModel.MaxAmtShareCap = this.loanType.getTimesOfShareCap();

                    if (this.loanAccountTypeModel.MaxAmtShareCap == 0)
                    {
                        countError++; errorMessage += countError + ". Please specify maximum loanable amount (times of Share Capital).\n"; this.loanType.lblMaxLoanableAmt.ForeColor = System.Drawing.Color.Red; this.loanType.lblOf.ForeColor = System.Drawing.Color.Red;
                    }

                    if (this.loanAccountTypeModel.MaxAmtShareCap > 50) 
                    {
                        countError++; errorMessage += countError + ". Maximum loanable amount (times of Share Capital) must be <= 50.\n"; this.loanType.lblMaxLoanableAmt.ForeColor = System.Drawing.Color.Red; this.loanType.lblOf.ForeColor = System.Drawing.Color.Red;
                    }

                }
                catch (FormatException) { countError++; errorMessage += countError + ". Please specify maximum loanable amount (times Of Share Capital).\n"; this.loanType.lblMaxLoanableAmt.ForeColor = System.Drawing.Color.Red; this.loanType.lblOf.ForeColor = System.Drawing.Color.Red; }


                if (isAdd)
                {
                    if (countError==0 && this.loanAccountTypeModel.insertLoanType(memberTypeNo, Collateral, Status) == 1)
                    {
                        MessageBox.Show("Add success!", "Loan Types", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.loanType.checkArchivedState())
                        {
                            this.loanType.loanTypeGrid(this.loanAccountTypeModel.selectAllLoanTypes());
                            DataGridViewRowCollection dr = this.loanType.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.loanType.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.loanType.setAllLabelsToBlack();
                            this.loanType.disableFunction();
                        }
                        else
                        {
                            this.loanType.loanTypeGrid(this.loanAccountTypeModel.selectloanTypes());
                            this.loanType.setAllLabelsToBlack();
                            this.loanType.disableFunction();
                        }
                        isAdd = false;
                        TypeId = 0;
                    }
                    else
                    {
                        MessageBox.Show("Add failed!\n\n" + errorMessage, "Loan Types", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TypeId = 0;
                    }
                }
                else
                {
                    if (countError==0 && this.loanAccountTypeModel.updateLoanType(TypeId, memberTypeNo, Collateral, Status) == 1)
                    {
                        MessageBox.Show("Update Success.", "Loan Types", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.loanType.checkArchivedState())
                        {
                            this.loanType.loanTypeGrid(this.loanAccountTypeModel.selectAllLoanTypes());
                            DataGridViewRowCollection dr = this.loanType.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.loanType.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.loanType.setAllLabelsToBlack();
                            this.loanType.disableFunction();
                        }
                        else
                        {
                            this.loanType.loanTypeGrid(this.loanAccountTypeModel.selectloanTypes());
                            this.loanType.setAllLabelsToBlack();
                            this.loanType.disableFunction();
                        }
                        isAdd = false;
                        TypeId = 0;
                    }
                    else
                    {
                        MessageBox.Show("Update Failed!\n\n" + errorMessage, "Loan Types", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            

            
        
        }
        public void btnCancel(object args, EventArgs e) {
            this.loanType.setAllLabelsToBlack();
            this.loanType.disableFunction();  
        }

        public void checkArchived(object sender, EventArgs e)
        {
            if (this.loanType.checkArchivedState())
            {
                this.loanType.loanTypeGrid(this.loanAccountTypeModel.selectAllLoanTypes());
                DataGridViewRowCollection dr = this.loanType.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.loanType.setArchivedColor(i);
                    }
                    i++;
                }
            }
            else
            {
                this.loanType.loanTypeGrid(this.loanAccountTypeModel.selectloanTypes());
            }
        }

        //retrieve
        public void btnRetrieve(object args, EventArgs e)
        {
            int checkExist = 0;

        
            String instaName = Regex.Replace(nameCopy, @"[^0-9a-zA-Z]+", String.Empty);
            for (int i = 0; i < this.loanType.dataGridView.Rows.Count; i++)
            {
                String compareName = Regex.Replace(this.loanType.dataGridView.Rows[i].Cells[1].Value.ToString(), @"[^0-9a-zA-Z]+", String.Empty);

                if (!(bool.Parse(this.loanType.dataGridView.Rows[i].Cells[9].Value.ToString())) && instaName.Equals(compareName, StringComparison.InvariantCultureIgnoreCase))
                {
                    checkExist = 1;
                }

            }

            if (checkExist == 1)
            {
                MessageBox.Show("Name of archived loan type already exists.\nPlease edit loan type name, save and retrieve again.", "Loan Types", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.loanAccountTypeModel.retrieveLoanType(this.TypeId);
                MessageBox.Show("Retrieve Success.", "Loan Penalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.loanType.checkArchivedState())
                {
                    this.loanType.loanTypeGrid(this.loanAccountTypeModel.selectAllLoanTypes());
                    DataGridViewRowCollection dr = this.loanType.getAllRows();
                    int i = 0;
                    foreach (DataGridViewRow row in dr)
                    {
                        if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                        {
                            this.loanType.setArchivedColor(i);
                        }
                        i++;
                    }
                    this.loanType.setAllLabelsToBlack();
                    this.loanType.disableFunction();
                }
                else
                {
                    this.loanType.loanTypeGrid(this.loanAccountTypeModel.selectloanTypes());
                    this.loanType.setAllLabelsToBlack();
                    this.loanType.disableFunction();
                }
                isAdd = false;
                TypeId = 0;
            }
        }

    }
}
