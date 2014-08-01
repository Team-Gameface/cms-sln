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
    class MemberClassificationController
    {
        Maintenance.Model.MemberClassificationModel classificationModel;
        Maintenance.View.MemberClassification classification;

        int statusNo = 0;
        String oldName = String.Empty;
        String classificationName = String.Empty;
        Boolean isAdd = false;
        Dictionary<int, string> memberTypes = new Dictionary<int, string>();

        public MemberClassificationController(Maintenance.Model.MemberClassificationModel classificationModel, Maintenance.View.MemberClassification classificationView, Loan_Management.LoanManagementMenu loanManagementMenu)
        {
            this.classificationModel = classificationModel;
            this.classification = classificationView;
            this.classification.setBtnAddEventHandler(this.btnAdd);
            this.classification.setBtnCancelEventHandler(this.btnCancel);
            this.classification.setBtnDeleteEventHandler(this.btnDelete);
            this.classification.setBtnRetrieveEventHandler(this.btnRetrieve);
            this.classification.setBtnEditEventHandler(this.btnEdit);
            this.classification.setBtnSaveEventHandler(this.btnSave);
            this.classification.checkArchived_CheckStateChanged(this.checkArchived);
            this.classification.classGrid(this.classificationModel.selectClasses());
            this.classification.disableFunction();
            this.classification.MdiParent = loanManagementMenu;
            this.classification.Show();
        }


        
        public void clbMemberTypes() {

            memberTypes.Clear();
            DataTable ds = this.classificationModel.selectMemberTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {
                memberTypes.Add(int.Parse(dr["Type No"].ToString()),dr["Type Name"].ToString());
            }
            this.classification.populateMemberTypes(memberTypes);
        }

        public void activeMemberTypes(int statusNo)
        {

            ArrayList checkedTypes = new ArrayList();

            DataTable ds = this.classificationModel.selectActiveMemberTypes(statusNo).Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                foreach (KeyValuePair<int, string> pair in memberTypes)
                {
                    if (int.Parse(dr[0].ToString()) == pair.Key)
                        checkedTypes.Add(pair.Value);
                }
            }
            this.classification.toggleCheckedTypes(checkedTypes);

        }

        public void btnAdd(object args, EventArgs e)
        {
            this.classification.enableFunction();
            this.classification.setStatus();
            this.clbMemberTypes();
            isAdd = true;
            statusNo = 0;
            this.classification.setStatus();
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.classification.disableFunction();
            isAdd = false;
            statusNo = 0;
        }

        public void btnDelete(object args, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedData = this.classification.getSelected();
                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    MessageBox.Show("Cannot Delete Archives.", "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String className = selectedData.Cells["Classification"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete '" + className + "'?", "Delinquency Classification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        statusNo = int.Parse(selectedData.Cells["No"].Value.ToString());
                        if (classificationModel.deleteClass(statusNo) == 1)
                        {
                            MessageBox.Show("Delete Success.", "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.classification.checkArchivedState())
                            {
                                this.classification.classGrid(this.classificationModel.selectAllClasses());
                                DataGridViewRowCollection dr = this.classification.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.classification.setArchivedColor(i);
                                    }
                                    i++;
                                }
                                this.classification.disableFunction();
                            }
                            else
                            {
                                this.classification.classGrid(this.classificationModel.selectClasses());
                                this.classification.disableFunction();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed.", "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        statusNo = 0;
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("No rows were selected.", "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnRetrieve(object args, EventArgs e) {

            bool retrieveError = false;
            SqlDataReader sdr;
            sdr = classificationModel.selectClassNames(classificationName);
            while (sdr.Read())
            {
                if (sdr[1].ToString().ToLower() == sdr[0].ToString().ToLower())
                {
                    retrieveError = true;
                    classification.errorClassName();
                    MessageBox.Show("'" + classificationName + "' Already exists." + Environment.NewLine + "It Cannot be Retrieved at the Moment.", "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (!retrieveError)
            {
                this.classificationModel.retrieveClass(this.statusNo);
                MessageBox.Show("Retrieve Success.", "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.classification.checkArchivedState())
                {
                    this.classification.classGrid(this.classificationModel.selectAllClasses());
                    DataGridViewRowCollection dr = this.classification.getAllRows();
                    int i = 0;
                    foreach (DataGridViewRow row in dr)
                    {
                        if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                        {
                            this.classification.setArchivedColor(i);
                        }
                        i++;
                    }
                    this.classification.disableFunction();
                }
                else
                {
                    this.classification.classGrid(this.classificationModel.selectMemberTypes());
                    this.classification.disableFunction();
                }
                isAdd = false;
                statusNo = 0;
            }
        
        }

        public void btnEdit(object args, EventArgs e)
        {
            try
            {
                classification.enableFunction();
                this.clbMemberTypes();
                DataGridViewRow selectedData = this.classification.getSelected();
                isAdd = false;
                statusNo = int.Parse(selectedData.Cells["No"].Value.ToString());
                this.activeMemberTypes(statusNo);
                classificationName = selectedData.Cells["Classification"].Value.ToString();
                int delValue = int.Parse(selectedData.Cells["Delinquency"].Value.ToString());
                String delUnit = selectedData.Cells["Unit"].Value.ToString();

                String delBasis = selectedData.Cells["Basis"].Value.ToString();

                bool Status = bool.Parse(selectedData.Cells["Status"].Value.ToString());

                if (Status)
                {
                    this.classification.setStatus();
                }
                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    this.classification.showRetrieve();
                }
                else
                {
                    this.classification.hideRetrieve();
                }
                this.classification.setStatusDesc(classificationName);
                oldName = classificationName;
                this.classification.setDelinquency(delValue, delUnit, delBasis);

            }
            catch (Exception)
            {
                MessageBox.Show("No rows were selected.", "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                classification.disableFunction();
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            classificationName = classification.getStatusDesc();
            int delValue = 0;
            String delUnit = "";
            String delBasis = "";
            int Status = 0;
            String errorMessage = String.Empty;
            CheckedListBox.CheckedItemCollection memberTypeName = classification.getCheckedTypes();
            ArrayList memberTypeNo = new ArrayList();
            foreach (String s in memberTypeName) 
            {
                foreach (KeyValuePair<int, string> pair in memberTypes) 
                {
                    if (s.Equals(pair.Value))
                        memberTypeNo.Add(pair.Key);
                }
            }

            if (isAdd)
                errorMessage += "Add Failed!" + Environment.NewLine + Environment.NewLine;
            else
                errorMessage += "Update Failed!" + Environment.NewLine + Environment.NewLine;

            if (classification.getStatus())
            {
                Status = 1;
            }

            if (classification.getDelinquency()) 
            {
                delValue = classification.getDelValue();
                if (delValue > 0)
                {
                    delUnit = classification.getDelUnit();
                    delBasis = classification.getDelBasis();
                }
            }
            //
            this.classification.resetLabels();
            bool insertError = false;
            bool isDuplicate = false;
            try
            {

                SqlDataReader dr;
                if (isAdd)
                    dr = classificationModel.selectClassNames(classificationName);
                else dr = classificationModel.selectClassNames(classificationName, oldName);

                if (classificationName == String.Empty)
                {
                    insertError = true;
                    this.classification.errorClassName();
                    errorMessage += "Please Specify Classification Name." + Environment.NewLine;

                }
                else //check for duplicate names
                {
                    while (dr.Read())
                    {
                        if (dr[1].ToString().ToLower() == dr[0].ToString().ToLower())
                        {
                            insertError = true;
                            this.classification.errorClassName();
                            errorMessage += "'" + classificationName + "' Already Exists." + Environment.NewLine;
                        }
                    }
                }

                if (classification.getDelinquency())
                    if (delUnit == String.Empty || delBasis == String.Empty)
                    {
                        insertError = true;
                        this.classification.errorDeliqStatus();
                        errorMessage += "Specify the Delinquency Period." + Environment.NewLine;

                    }

                    {

                        int valueinDays = 0;

                        if (delUnit == "Days")
                            valueinDays = delValue * 1;
                        if (delUnit == "Months")
                            valueinDays = delValue * 30;
                        if (delUnit == "Years")
                            valueinDays = delValue * 365;
                        
                        if (isAdd)
                            dr = classificationModel.selectClassNames(classificationName);
                        else dr = classificationModel.selectClassNames(classificationName,oldName);

                        while (dr.Read()) {

                            int currValueInDays = 0;

                            if (dr[3].ToString() == "Days")
                                currValueInDays = Convert.ToInt32(dr[2]) * 1;
                            if (dr[3].ToString() == "Months")
                                currValueInDays = Convert.ToInt32(dr[2]) * 30;
                            if (dr[3].ToString() == "Years")
                                currValueInDays = Convert.ToInt32(dr[2]) * 360;
                            if (currValueInDays == valueinDays && delBasis == dr[4].ToString())
                            {
                                insertError = true;
                                isDuplicate = true;
                            }
                        
                        }
                        if (isDuplicate)
                        {
                            errorMessage += "Sorry, it seems that an equivalent value of what you are adding is already present in the system. Please verify your active classifications and try again." + Environment.NewLine;
                            this.classification.errorDeliqStatus();
                        }
                    }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

               if (memberTypeNo.Count <= 0) {
                        insertError = true;
                        this.classification.errorApplied();
                        errorMessage += "Check at least one member type." + Environment.NewLine;

            
            }

            if (isAdd)
            {
                if (!(insertError))
                {
                    if (this.classificationModel.insertClass(classificationName, delValue, delUnit, delBasis, memberTypeNo, Status) != 0)
                    {
                        MessageBox.Show("Add Success.", "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.classification.checkArchivedState())
                        {
                            this.classification.classGrid(this.classificationModel.selectAllClasses());
                            DataGridViewRowCollection dr = this.classification.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.classification.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.classification.disableFunction();
                        }
                        else
                        {
                            this.classification.classGrid(this.classificationModel.selectClasses());
                            this.classification.disableFunction();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Add Failed.", "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show(errorMessage, "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!(insertError))
                {
                    if (this.classificationModel.updateClass(statusNo, classificationName, delValue, delUnit, delBasis, memberTypeNo, Status) != 0)
                    {
                        MessageBox.Show("Update Success.", "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        statusNo = 0;
                        if (this.classification.checkArchivedState())
                        {
                            this.classification.classGrid(this.classificationModel.selectAllClasses());
                            DataGridViewRowCollection dr = this.classification.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.classification.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.classification.disableFunction();
                        }
                        else
                        {
                            this.classification.classGrid(this.classificationModel.selectClasses());
                            this.classification.disableFunction();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Update Failed.", "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show(errorMessage, "Delinquency Classification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

       public void checkArchived(object sender, EventArgs e) {

            if (this.classification.checkArchivedState())
            {
                this.classification.classGrid(this.classificationModel.selectAllClasses());
                DataGridViewRowCollection dr = this.classification.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.classification.setArchivedColor(i);
                    }
                    i++;
                }
            }
            else
            {
                this.classification.classGrid(this.classificationModel.selectClasses());
            }


        }
        
    }
}
