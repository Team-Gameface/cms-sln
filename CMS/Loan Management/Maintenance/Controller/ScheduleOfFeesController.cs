using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CMS.Loan_Management.Maintenance.Controller
{
    class ScheduleOfFeesController
    {
        Maintenance.Model.ScheduleOfFeesModel feesModel;
        Maintenance.View.ScheduleOfFees fees;
        Main.Logger logger = new Main.Logger();
        int feeId = 0;
        Boolean isAdd = false;
        String oldName = String.Empty;
        String feeDesc = String.Empty;
        Dictionary<int, string> memberTypes = new Dictionary<int, string>();

        public ScheduleOfFeesController(Maintenance.Model.ScheduleOfFeesModel feesModel, Maintenance.View.ScheduleOfFees feesView, Loan_Management.LoanManagementMenu loanManagementMenu)
        {
            this.feesModel = feesModel;
            this.fees = feesView;
            this.fees.setBtnAddEventHandler(this.btnAdd);
            this.fees.setBtnCancelEventHandler(this.btnCancel);
            this.fees.setBtnDeleteEventHandler(this.btnDelete);
            this.fees.setBtnEditEventHandler(this.btnEdit);
            this.fees.setBtnSaveEventHandler(this.btnSave);
            this.fees.setBtnRetrieveEventHandler(this.btnRetrieve);
            this.fees.checkArchived_CheckStateChanged(this.checkArchived);
            this.fees.setTxtSearchEventHandler(this.btnSearch);
            this.fees.feeGrid(this.feesModel.selectFees());
            this.fees.disableFunction();
            this.fees.MdiParent = loanManagementMenu;
            this.fees.Show();
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Maintenance - Miscellaneous Fee Schedule";
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
            this.fees.feeGrid(this.feesModel.searchFees(this.fees.getSearch()));
        }

        public void clbMemberTypes()
        {
            memberTypes.Clear();
            DataTable ds = this.feesModel.selectMemberTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                memberTypes.Add(int.Parse(dr["Type No"].ToString()), dr["Type Name"].ToString());

            }
            this.fees.populateMemberTypes(memberTypes);
        }




        public void activeMemberTypes(int feeId)
        {

            ArrayList checkedTypes = new ArrayList();

            DataTable ds = this.feesModel.selectActiveMemberTypes(feeId).Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                foreach (KeyValuePair<int, string> pair in memberTypes)
                {
                    if (int.Parse(dr[0].ToString()) == pair.Key)
                        checkedTypes.Add(pair.Value);
                }
            }
            this.fees.toggleCheckedTypes(checkedTypes);

        }

        public void btnAdd(object args, EventArgs e)
        {
            this.fees.enableFunction();
            this.clbMemberTypes();
            isAdd = true;
            feeId = 0;
            this.fees.setStatus();
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.fees.disableFunction();
            isAdd = false;
            feeId = 0;
        }

        public void btnEdit(object args, EventArgs e)
        {
            try
            {
                fees.enableFunction();
                this.clbMemberTypes();
                DataGridViewRow selectedData = this.fees.getSelected();
                isAdd = false;
                feeId = int.Parse(selectedData.Cells["Fee No"].Value.ToString());
                this.activeMemberTypes(feeId);
                feeDesc = selectedData.Cells["Description"].Value.ToString();
                Double feeAmount = Double.Parse(selectedData.Cells["Amount"].Value.ToString());
                bool Status = bool.Parse(selectedData.Cells["Status"].Value.ToString());

                if (Status)
                {
                    this.fees.setStatus();
                }
                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    this.fees.showRetrieve();
                }
                else
                {
                    this.fees.hideRetrieve();
                }

                this.fees.setFeeName(feeDesc);
                oldName = feeDesc;
                this.fees.setFeeAmount(feeAmount);
            }
            catch (Exception)
            {
                MessageBox.Show("No rows were selected.", "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fees.disableFunction();
            }
        }
        public void btnDelete(object args, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedData = this.fees.getSelected();
                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    MessageBox.Show("Cannot Delete Archives.", "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String feeDesc = selectedData.Cells["Description"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete '" + feeDesc + "'?", "Miscellaneous Fee Schedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        feeId = int.Parse(selectedData.Cells["Fee No"].Value.ToString());
                        if (feesModel.deleteFee(feeId) == 1)
                        {
                            MessageBox.Show("Delete Success.", "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            execLogger("Delete '" + selectedData.Cells["Description"].Value.ToString() + "'");

                            if (this.fees.checkArchivedState())
                            {
                                this.fees.feeGrid(this.feesModel.selectAllFees());
                                DataGridViewRowCollection dr = this.fees.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.fees.setArchivedColor(i);
                                    }
                                    i++;
                                }
                                this.fees.disableFunction();
                            }
                            else
                            {
                                this.fees.feeGrid(this.feesModel.selectFees());
                                this.fees.disableFunction();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Delete Failed.", "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        feeId = 0;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No rows were selected.", "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            String feeDesc = fees.getFeeDesc();
            Double feeAmount = fees.getFeeAmount();
            String errorMessage = String.Empty;
            int Status = 0;
            CheckedListBox.CheckedItemCollection memberTypeName = fees.getCheckedTypes();
            ArrayList memberTypeNo = new ArrayList();

            if (isAdd)
                errorMessage += "Add Failed!" + Environment.NewLine + Environment.NewLine;
            else
                errorMessage += "Update Failed!" + Environment.NewLine + Environment.NewLine;

            foreach (String s in memberTypeName)
            {
                foreach (KeyValuePair<int, string> pair in memberTypes)
                {
                    if (s.Equals(pair.Value))
                        memberTypeNo.Add(pair.Key);
                }
            }

            if (fees.getStatus())
            {
                Status = 1;
            }

            this.fees.resetLabels();
            bool insertError = false;

            if (feeDesc == String.Empty)
            {
                insertError = true;
                fees.errorName();
                errorMessage += "Specify a fee description." + Environment.NewLine;

            }

            else
            {
                try
                {
                    SqlDataReader dr;
                    if (isAdd)
                        dr = feesModel.selectFeeNames(feeDesc);
                    else dr = feesModel.selectFeeNames(feeDesc, oldName);

                    while (dr.Read())
                    {
                        if (int.Parse(dr[0].ToString()) > 0)
                        {
                            insertError = true;
                            fees.errorName();
                            errorMessage += "'" + feeDesc + "' Already Exists." + Environment.NewLine;
                        }
                    }
                }
                catch (InvalidOperationException io)
                {
                    MessageBox.Show(io.Message);
                }
            }

            if (memberTypeNo.Count <= 0)
            {
                insertError = true;
                this.fees.errorApplied();
                errorMessage += "Check at least one member type." + Environment.NewLine;

            }

            if (feeAmount < 0)
            {
                insertError = true;
                this.fees.errorAmt();
                errorMessage += "Specify an amount." + Environment.NewLine;

            }

            if (isAdd)
            {
                if (!(insertError))
                {
                    if (this.feesModel.insertFee(feeDesc, feeAmount, memberTypeNo, Status) != 0)
                    {
                        MessageBox.Show("Add Success.", "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        execLogger("Add '" + feeDesc + "'");

                        if (this.fees.checkArchivedState())
                        {
                            this.fees.feeGrid(this.feesModel.selectAllFees());
                            DataGridViewRowCollection dr = this.fees.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.fees.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.fees.disableFunction();
                        }
                        else
                        {
                            this.fees.feeGrid(this.feesModel.selectFees());
                            this.fees.disableFunction();
                        }

                        feeId = 0;
                    }
                    else
                    {
                        MessageBox.Show("Add Failed.", "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show(errorMessage, "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!(insertError))
                {
                    if (this.feesModel.updateFee(feeId, feeDesc, feeAmount, memberTypeNo, Status) != 0)
                    {
                        MessageBox.Show("Update Success.", "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        execLogger("Update '" + feeDesc + "'");

                        if (this.fees.checkArchivedState())
                        {
                            this.fees.feeGrid(this.feesModel.selectAllFees());
                            DataGridViewRowCollection dr = this.fees.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.fees.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.fees.disableFunction();
                        }
                        else
                        {
                            this.fees.feeGrid(this.feesModel.selectFees());
                            this.fees.disableFunction();
                        }

                        feeId = 0;
                    }
                    else
                    {
                        MessageBox.Show("Update Failed.", "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show(errorMessage, "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        public void btnRetrieve(object sender, EventArgs e)
        {

            bool retrieveError = false;
            SqlDataReader sdr;
            sdr = feesModel.selectFeeNames(feeDesc);
            while (sdr.Read())
            {
                if (int.Parse(sdr[0].ToString()) > 0)
                {
                    retrieveError = true;
                    fees.errorName();
                    MessageBox.Show("'" + feeDesc + "' already exists. It cannot be retrieved at the moment.", "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            sdr = feesModel.checkExistingMemberTypes(feeId);
            while (sdr.Read())
            {
                if (int.Parse(sdr[0].ToString()) > 0)
                {
                    DialogResult dr = MessageBox.Show("'" + feeDesc + "' is available on member types which are already deleted from the system. Do you want to continue retrieving this?", "Miscellaneous Fee Schedule", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                        retrieveError = false;
                    else
                        retrieveError = true;
                }
            }

            if (!retrieveError)
            {
                this.feesModel.retrieveFee(feeId);
                MessageBox.Show("Retrieve Success.", "Miscellaneous Fee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                execLogger("Retrieve '" + feeDesc + "'");

                if (this.fees.checkArchivedState())
                {
                    this.fees.feeGrid(this.feesModel.selectAllFees());
                    DataGridViewRowCollection dr = this.fees.getAllRows();
                    int i = 0;
                    foreach (DataGridViewRow row in dr)
                    {
                        if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                        {
                            this.fees.setArchivedColor(i);
                        }
                        i++;
                    }
                    this.fees.disableFunction();
                }
                else
                {
                    this.fees.feeGrid(this.feesModel.selectFees());
                    this.fees.disableFunction();
                }
                isAdd = false;
                feeId = 0;
            }
        }

        public void checkArchived(object sender, EventArgs e) {

            if (this.fees.checkArchivedState())
            {
                this.fees.feeGrid(this.feesModel.selectAllFees());
                DataGridViewRowCollection dr = this.fees.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.fees.setArchivedColor(i);
                    }
                    i++;
                }
                this.fees.disableFunction();
            }
            else
            {
                this.fees.feeGrid(this.feesModel.selectFees());
                this.fees.disableFunction();
            }
        
        }
        
    }
}
