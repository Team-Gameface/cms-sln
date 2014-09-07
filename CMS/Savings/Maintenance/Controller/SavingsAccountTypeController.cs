using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Maintenance.Controller
{
    class SavingsAccountTypeController
    {
        Maintenance.Model.SavingsAccountTypeModel savingsAccountTypeModel;
        Maintenance.View.SavingsAccountType savingsAccountType;
        Dictionary<int, string> memberTypes = new Dictionary<int, string>();
        Boolean isAdd = false;
        String errorMessage = String.Empty;
        int TypeId = 0;

        public SavingsAccountTypeController(Maintenance.Model.SavingsAccountTypeModel savingsAccountTypeModel, Maintenance.View.SavingsAccountType savingsAccountType, Savings.SavingsMenu savingsMenu)
        {
            this.savingsAccountTypeModel = savingsAccountTypeModel;
            this.savingsAccountType = savingsAccountType;
            this.savingsAccountType.btnAddEventHandler(this.btnAdd);
            this.savingsAccountType.btnEditEventHandler(this.btnEdit);
            this.savingsAccountType.btnDeleteEventHandler(this.btnDelete);
            this.savingsAccountType.btnSaveEventHandler(this.btnSave);
            this.savingsAccountType.btnCancelEventHandler(this.btnCancel);
            this.savingsAccountType.btnRetrieveEventHandler(this.btnRetrieve);
            this.savingsAccountType.checkArchived_CheckStateChanged(this.checkArchived);
            this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
            this.savingsAccountType.removeColumns();
            this.savingsAccountType.disableFunction();
            this.savingsAccountType.MdiParent = savingsMenu;
            this.savingsAccountType.Show();
        }

        public void clbMemberTypes()
        {
            memberTypes.Clear();
            DataTable ds = this.savingsAccountTypeModel.selectMemberTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {
                memberTypes.Add(int.Parse(dr["MemberTypeNo"].ToString()), dr["Description"].ToString());
            }
            this.savingsAccountType.populateMemberTypes(memberTypes);
        }

        public void activeMemberTypes(int statusNo)
        {

            ArrayList checkedTypes = new ArrayList();
            DataTable ds = this.savingsAccountTypeModel.selectMemberTypeSavings(statusNo).Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                foreach (KeyValuePair<int, string> pair in memberTypes)
                {
                    if (int.Parse(dr[0].ToString()) == pair.Key)
                        checkedTypes.Add(pair.Value);
                }
            }
            this.savingsAccountType.toggleCheckedTypes(checkedTypes);

        }

        public void btnAdd(object args, EventArgs e)
        {
            this.savingsAccountType.enableFunction();
            clbMemberTypes();
            this.savingsAccountTypeModel.memberSavingsChecklist.Clear();
            this.savingsAccountType.setStatus();
            isAdd = true;
            TypeId = 0;
        }

        public void btnEdit(object args, EventArgs e)
        {
            DataGridViewRow selectedData = this.savingsAccountType.getSelected();
            if (selectedData == null)
            {
                MessageBox.Show("No Row Selected.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                isAdd = false;
                this.savingsAccountType.enableFunction();
                this.clbMemberTypes();
                this.savingsAccountTypeModel.memberSavingsChecklist.Clear();
                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    this.savingsAccountType.showRetrieve();
                }
                else
                {
                    this.savingsAccountType.hideRetrieve();
                }
                TypeId = int.Parse(selectedData.Cells["Account Type Id"].Value.ToString());
                this.activeMemberTypes(TypeId);
                this.savingsAccountType.setTextName(selectedData.Cells["Savings Type Name"].Value.ToString());
                this.savingsAccountType.setTextInitDeposit(selectedData.Cells["Initial Deposit"].Value.ToString());
                this.savingsAccountType.setMaximumWithdrawal(selectedData.Cells["Maximum Withdrawal"].Value.ToString());
                this.savingsAccountType.setAccountHolder(int.Parse(selectedData.Cells["No of Account Holders"].Value.ToString()));
                if (bool.Parse(selectedData.Cells["Maintaining Balance"].Value.ToString()))
                {
                    this.savingsAccountType.setMaintainingBalance();
                    String[] details = this.savingsAccountTypeModel.selectMaintainingBalance(TypeId);
                    this.savingsAccountType.setMaintainingBalanceAmount(details[0]);
                    this.savingsAccountType.setMaintainingBalancePenaltyAmount(details[1]);
                    this.savingsAccountType.setComboMaintainingBalanceCharge(details[2]);
                    this.savingsAccountType.setNumMaintainingBalanceDuration(int.Parse(details[3]));
                    this.savingsAccountType.setComboMaintainingBalanceDuration(details[4]);
                }
                if (bool.Parse(selectedData.Cells["Interest Rate"].Value.ToString()))
                {
                    this.savingsAccountType.setInterestRates();
                    String[] details = this.savingsAccountTypeModel.selectInterestRate(TypeId);
                    this.savingsAccountType.setInterestRate(details[0]);
                    this.savingsAccountType.setComboInterest(details[1]);
                }
                if (bool.Parse(selectedData.Cells["Dormancy"].Value.ToString()))
                {
                    this.savingsAccountType.setDormancy();
                    String[] details = this.savingsAccountTypeModel.selectDormancy(TypeId);
                    this.savingsAccountType.setNumDormancy(int.Parse(details[2]));
                    this.savingsAccountType.setComboDormancy(details[3]);
                    this.savingsAccountType.setDormancyPenalty(details[0]);
                    this.savingsAccountType.setComboDormancyPenalty(details[1]);
                    this.savingsAccountType.setNumDormancyChargeDuration(int.Parse(details[4]));
                    this.savingsAccountType.setComboDormancyChargeDuration(details[5]);
                }
                if (bool.Parse(selectedData.Cells["Status"].Value.ToString()))
                {
                    this.savingsAccountType.setStatus();
                }
            }
        }

        public void btnDelete(object args, EventArgs e)
        {
            DataGridViewRow selectedData = this.savingsAccountType.getSelected();
            if (selectedData == null)
            {
                MessageBox.Show("No Row Selected.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    MessageBox.Show("Cannot Delete Archives.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String savingsType = selectedData.Cells["Savings Type Name"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete '" + savingsType + "'?", "Savings Account Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TypeId = int.Parse(selectedData.Cells["Account Type Id"].Value.ToString());
                        if (this.savingsAccountTypeModel.deleteSavingsAccount(TypeId) == 1)
                        {
                            MessageBox.Show("Delete Success.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.savingsAccountType.checkArchivedState())
                            {
                                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypesAll());
                                DataGridViewRowCollection dr = this.savingsAccountType.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.savingsAccountType.setArchivedColor(i);
                                    }
                                    i++;
                                }
                                this.savingsAccountType.removeColumns();
                                this.savingsAccountType.clearError();
                                this.savingsAccountType.disableFunction();
                            }
                            else
                            {
                                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
                                this.savingsAccountType.removeColumns();
                                this.savingsAccountType.clearError();
                                this.savingsAccountType.disableFunction();
                            }
                            isAdd = false;
                            TypeId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isAdd = false;
                            TypeId = 0;
                        }
                    }
                }
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            this.savingsAccountTypeModel.memberSavingsChecklist.Clear();
            this.savingsAccountTypeModel.dormancyModel.clearAll();
            this.savingsAccountTypeModel.maintainingBalanceModel.clearAll();
            this.errorMessage = String.Empty;
            this.savingsAccountType.clearError();
            Boolean checkName = false;
            Boolean checkInitDeposit = false;
            Boolean checkMaxWith = false;
            Boolean checkAccountHolder = false;
            Boolean checkMaintainingBalance = false;
            Boolean checkDormancy = false;
            Boolean checkInterest = false;
            if (isAdd)
            {
                this.errorMessage += "Add Failed!" + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                this.errorMessage += "Update Failed!" + Environment.NewLine + Environment.NewLine;
            }
            try
            {
                if (this.savingsAccountType.getTextName() != String.Empty)
                {
                    if (isAdd)
                    {
                        if (this.savingsAccountTypeModel.checkName(this.savingsAccountType.getTextName()) > 0)
                        {
                            this.errorMessage += "Savings Account Type Already Exists.";
                            this.savingsAccountType.setErrorName();
                            checkName = false;
                        }
                        else
                        {
                            this.savingsAccountTypeModel.Name = this.savingsAccountType.getTextName();
                            checkName = true;
                        }
                    }
                    else
                    {
                        this.savingsAccountTypeModel.Name = this.savingsAccountType.getTextName();
                        checkName = true;
                    }
                }
                else
                {
                    this.errorMessage += "Please Specify Name." + Environment.NewLine;
                    this.savingsAccountType.setErrorName();
                    checkName = false;
                }
                if (this.savingsAccountType.getTextInitDeposit() != 0)
                {
                    if (this.savingsAccountType.getTextInitDeposit() < 0)
                    {
                        this.errorMessage += "Initial Deposit cannot be less than 0." + Environment.NewLine;
                        this.savingsAccountType.setErrorInitDeposit();
                        checkInitDeposit = false;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.InitDeposit = this.savingsAccountType.getTextInitDeposit();
                        checkInitDeposit = true;
                    }
                }
                else
                {
                    this.errorMessage += "Please Specify Amount - Initial Deposit." + Environment.NewLine;
                    this.savingsAccountType.setErrorInitDeposit();
                    checkInitDeposit = false;
                }
                if (this.savingsAccountType.getAccountHolder() != 0)
                {
                    this.savingsAccountTypeModel.AccountHolders = this.savingsAccountType.getAccountHolder();
                    checkAccountHolder = true;
                }
                else
                {
                    this.errorMessage += "Please Specify No of Account Holders." + Environment.NewLine;
                    this.savingsAccountType.setErrorAccountHolder();
                    checkAccountHolder = false;
                }
                if (this.savingsAccountType.getMaximumWithdrawal() != 0)
                {
                    if (this.savingsAccountType.getMaximumWithdrawal() < 0)
                    {
                        this.errorMessage += "Maximum Withdrawal cannot be less than 0." + Environment.NewLine;
                        this.savingsAccountType.setErrorMaxWith();
                        checkMaxWith = false;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.MaxWith = this.savingsAccountType.getMaximumWithdrawal();
                        checkMaxWith = true;
                    }
                }                
                else
                {
                    this.errorMessage += "Please Specify - Maximum Withdrawal." + Environment.NewLine;
                    this.savingsAccountType.setErrorMaxWith();
                    checkMaxWith = false;
                }
                if (this.savingsAccountType.getMaintainingBalance())
                {
                    this.savingsAccountTypeModel.isMaintainingBalance = 1;
                    Boolean checkMaintainingBalanceAmount = false;
                    Boolean checkMainBalPenaltyAmount = false;
                    Boolean checkMainBalPenaltyCurrency = false;
                    Boolean checkMainBalDuration = false;
                    Boolean checkMainBalDurationStatus = false;
                    if (this.savingsAccountType.getMaintainingBalanceAmount() != 0)
                    {
                        if (this.savingsAccountType.getMaintainingBalanceAmount() < 0)
                        {
                            this.errorMessage += "Maintaining Balance cannot be less than 0." + Environment.NewLine;
                            this.savingsAccountType.setErrorMainBalAmount();
                            checkMaintainingBalanceAmount = false;
                        }
                        else
                        {
                            this.savingsAccountTypeModel.maintainingBalanceModel.MaintainingBalance = this.savingsAccountType.getMaintainingBalanceAmount();
                            checkMaintainingBalanceAmount = true;
                        }
                    }
                    else
                    {
                        this.errorMessage += "Please Specify - Maintaining Balance." + Environment.NewLine;
                        this.savingsAccountType.setErrorMainBalAmount();
                        checkMaintainingBalanceAmount = false;
                    }
                    if (this.savingsAccountType.getMaintainingBalancePenaltyAmount() != 0)
                    {
                        if (this.savingsAccountType.getMaintainingBalancePenaltyAmount() < 0)
                        {
                            this.errorMessage += "Maintaining Balance Penalty Amount cannot be less than 0." + Environment.NewLine;
                            this.savingsAccountType.setErrorPenaltyMainBal();
                            checkMainBalPenaltyAmount = false;
                        }
                        else
                        {
                            this.savingsAccountTypeModel.maintainingBalanceModel.ServiceCharge = this.savingsAccountType.getMaintainingBalancePenaltyAmount();
                            checkMainBalPenaltyAmount = true;
                        }
                    }
                    else
                    {
                        this.errorMessage += "Please Specify - Maintaining Balance Penalty Amount." + Environment.NewLine;
                        this.savingsAccountType.setErrorPenaltyMainBal();
                        checkMainBalPenaltyAmount = false;
                    }
                    if (this.savingsAccountType.getComboMaintainingBalancePenalty() == String.Empty)
                    {
                        this.errorMessage += "Please Specify - Maintaining Balance Penalty Amount Basis." + Environment.NewLine;
                        this.savingsAccountType.setErrorPenaltyMainBal();
                        checkMainBalPenaltyCurrency = false;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.maintainingBalanceModel.ServiceChargeStatus = this.savingsAccountType.getComboMaintainingBalancePenalty();
                        checkMainBalPenaltyCurrency = true;
                    }
                    if (this.savingsAccountType.getNumMaintainingBalanceDuration() != 0)
                    {
                        this.savingsAccountTypeModel.maintainingBalanceModel.ServiceChargeDuration = this.savingsAccountType.getNumMaintainingBalanceDuration();
                        checkMainBalDuration = true;
                    }
                    else
                    {
                        this.errorMessage += "Please Specify - Maintaining Balance Penalty Interval." + Environment.NewLine;
                        this.savingsAccountType.setErrorScheduleMainBal();
                        checkMainBalDuration = false;
                    }
                    if (this.savingsAccountType.getComboMaintainingBalanceDuration() == String.Empty)
                    {
                        this.errorMessage += "Please Specify - Maintaining Balance Penalty Interval." + Environment.NewLine;
                        this.savingsAccountType.setErrorScheduleMainBal();
                        checkMainBalDurationStatus = false;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.maintainingBalanceModel.ServiceChargeDurationStatus = this.savingsAccountType.getComboMaintainingBalanceDuration();
                        checkMainBalDurationStatus = true;
                    }
                    if (checkMaintainingBalanceAmount && checkMainBalPenaltyAmount && checkMainBalPenaltyCurrency && checkMainBalDuration && checkMainBalDurationStatus)
                    {
                        checkMaintainingBalance = true;
                    }
                    else
                    {
                        checkMaintainingBalance = false;
                    }
                }
                else
                {
                    this.savingsAccountTypeModel.isMaintainingBalance = 0;
                    checkMaintainingBalance = true;
                }
                if (this.savingsAccountType.getDormancy())
                {
                    this.savingsAccountTypeModel.isDormancy = 1;
                    Boolean checkDormancyDuration = false;
                    Boolean checkDormancyDurationStatus = false;
                    Boolean checkDormancyPenalty = false;
                    Boolean checkDormancyPenaltyBasis = false;
                    Boolean checkDormancyPenaltyInterval = false;
                    Boolean checkDormancyPenaltyIntervalBasis = false;
                    if (this.savingsAccountType.getNumDormancy() != 0)
                    {
                        this.savingsAccountTypeModel.dormancyModel.Dormancy = this.savingsAccountType.getNumDormancy();
                        checkDormancyDuration = true;
                    }
                    else
                    {
                        this.errorMessage += "Please Specify - Dormancy." + Environment.NewLine;
                        this.savingsAccountType.setErrorDormancy();
                        checkDormancyDuration = false;
                    }
                    if (this.savingsAccountType.getComboDormancy() == String.Empty)
                    {
                        this.errorMessage += "Pleace Specify - Dormancy Duration." + Environment.NewLine;
                        this.savingsAccountType.setErrorDormancy();
                        checkDormancyDurationStatus = false;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.dormancyModel.DormancyStatus = this.savingsAccountType.getComboDormancy();
                        checkDormancyDurationStatus = true;
                    }
                    if (this.savingsAccountType.getDormancyPenalty() != 0)
                    {
                        if (this.savingsAccountType.getDormancyPenalty() < 0)
                        {
                            this.errorMessage += "Dormancy Penalty cannot be less than 0." + Environment.NewLine;
                            this.savingsAccountType.setErrorPenaltyDormancy();
                            checkDormancyPenalty = false;
                        }
                        else
                        {
                            this.savingsAccountTypeModel.dormancyModel.Penalty = this.savingsAccountType.getDormancyPenalty();
                            checkDormancyPenalty = true;
                        }
                    }
                    else
                    {
                        this.errorMessage += "Please Specify - Dormancy Penalty." + Environment.NewLine;
                        this.savingsAccountType.setErrorPenaltyDormancy();
                        checkDormancyPenalty = false;
                    }
                    if (this.savingsAccountType.getComboDormancyPenalty() == String.Empty)
                    {
                        this.errorMessage += "Please Specify - Dormancy Penalty Basis." + Environment.NewLine;
                        this.savingsAccountType.setErrorPenaltyDormancy();
                        checkDormancyPenaltyBasis = false;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.dormancyModel.PenaltyStatus = this.savingsAccountType.getComboDormancyPenalty();
                        checkDormancyPenaltyBasis = true;
                    }
                    if (this.savingsAccountType.getNumDormancyChargeDuration() != 0)
                    {
                        this.savingsAccountTypeModel.dormancyModel.Charge = this.savingsAccountType.getNumDormancyChargeDuration();
                        checkDormancyPenaltyInterval = true;
                    }
                    else
                    {
                        this.errorMessage += "Dormancy Penalty Schedule cannot be less than 0." + Environment.NewLine;
                        this.savingsAccountType.setErrorScheduleDormancy();
                        checkDormancyPenaltyInterval = false;
                    }
                    if (this.savingsAccountType.getComboDormancyChargeDuration() == String.Empty)
                    {
                        this.errorMessage += "Please Specify - Dormancy Penalty Schedule." + Environment.NewLine;
                        this.savingsAccountType.setErrorScheduleDormancy();
                        checkDormancyPenaltyIntervalBasis = false;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.dormancyModel.ChargeStatus = this.savingsAccountType.getComboDormancyChargeDuration();
                        checkDormancyPenaltyIntervalBasis = true;
                    }
                    if (checkDormancyDuration && checkDormancyDurationStatus && checkDormancyPenalty && checkDormancyPenaltyBasis && checkDormancyPenaltyInterval && checkDormancyPenaltyIntervalBasis)
                    {
                        checkDormancy = true;
                    }
                    else
                    {
                        checkDormancy = false;
                    }
                }
                else
                {
                    this.savingsAccountTypeModel.isDormancy = 0;
                    checkDormancy = true;
                }
                if (this.savingsAccountType.getInterestRates())
                {
                    this.savingsAccountTypeModel.isInterestRates = 1;
                    Boolean checkInterestRate = false;
                    Boolean checkInterestPer = false;
                    if (this.savingsAccountType.getInterestRate() != 0)
                    {
                        if (this.savingsAccountType.getInterestRate() < 0)
                        {
                            this.errorMessage += "Please Specify - Interest Rate." + Environment.NewLine;
                            this.savingsAccountType.setErrorInterestRate();
                            checkInterestRate = false;
                        }
                        else
                        {
                            this.savingsAccountTypeModel.interestModel.InterestRate = this.savingsAccountType.getInterestRate();
                            checkInterestRate = true;
                        }
                    }
                    if (this.savingsAccountType.getComboInterest() == String.Empty)
                    {
                        this.errorMessage += "Please Specify - Interest Rate Per." + Environment.NewLine;
                        this.savingsAccountType.setErrorPer();
                        checkInterestPer = false;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.interestModel.Per = this.savingsAccountType.getComboInterest();
                        checkInterestPer = true;
                    }
                    if (this.savingsAccountType.getMaintainingBalance())
                    {
                        this.savingsAccountTypeModel.interestModel.MinRange = this.savingsAccountType.getMaintainingBalanceAmount();
                    }
                    else
                    {
                        this.savingsAccountTypeModel.interestModel.MinRange = 0;
                    }
                    if (checkInterestRate && checkInterestPer)
                    {
                        checkInterest = true;
                    }
                    else
                    {
                        checkInterest = false;
                    }
                }
                else
                {
                    this.savingsAccountTypeModel.isInterestRates = 0;
                    checkInterest = true;
                }
                if (this.savingsAccountType.getStatus())
                {
                    this.savingsAccountTypeModel.Status = 1;
                }
                else
                {
                    this.savingsAccountTypeModel.Status = 0;
                }
                CheckedListBox.CheckedItemCollection checkedMemberSavings = this.savingsAccountType.getCheckedTypes();
                foreach (String s in checkedMemberSavings)
                {
                    foreach (KeyValuePair<int, string> pair in memberTypes)
                    {
                        if (s.Equals(pair.Value))
                        {
                            Model.MemberSavingsTypeModel ms = new Model.MemberSavingsTypeModel();
                            ms.AccountTypeId = this.savingsAccountTypeModel.getInsertId() + 1;
                            ms.MemberTypeNo = pair.Key;
                            this.savingsAccountTypeModel.memberSavingsChecklist.Add(ms);
                        }
                    }
                }
                if (checkName && checkInitDeposit && checkMaxWith && checkAccountHolder && checkMaintainingBalance && checkDormancy && checkInterest)
                {
                    if (isAdd)
                    {
                        if (this.savingsAccountTypeModel.insertSavingsAccount() == 1)
                        {
                            if (this.savingsAccountTypeModel.isMaintainingBalance == 1)
                            {
                                this.savingsAccountTypeModel.maintainingBalanceModel.AccountTypeId = this.savingsAccountTypeModel.getInsertId();
                                this.savingsAccountTypeModel.insertMaintainingBalance();
                            }
                            if (this.savingsAccountTypeModel.isDormancy == 1)
                            {
                                this.savingsAccountTypeModel.dormancyModel.TypeId = this.savingsAccountTypeModel.getInsertId();
                                this.savingsAccountTypeModel.insertDormancy();
                            }
                            if (this.savingsAccountTypeModel.isInterestRates == 1)
                            {
                                this.savingsAccountTypeModel.interestModel.TypeId = this.savingsAccountTypeModel.getInsertId();
                                this.savingsAccountTypeModel.insertInterestRate();
                            }
                            if (this.savingsAccountType.checkArchivedState())
                            {
                                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypesAll());
                                DataGridViewRowCollection dr = this.savingsAccountType.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.savingsAccountType.setArchivedColor(i);
                                    }
                                    i++;
                                }
                                this.savingsAccountType.removeColumns();
                                this.savingsAccountType.clearError();
                                this.savingsAccountType.disableFunction();
                            }
                            else
                            {
                                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
                                this.savingsAccountType.removeColumns();
                                this.savingsAccountType.clearError();
                                this.savingsAccountType.disableFunction();
                            }
                            MessageBox.Show("Add Success.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isAdd = false;
                            TypeId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Add Failed.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (this.savingsAccountTypeModel.updateSavingsAccount(TypeId) == 1)
                        {
                            if (this.savingsAccountTypeModel.isMaintainingBalance == 1)
                            {
                                if (this.savingsAccountTypeModel.checkMainBal(TypeId) == 1)
                                {
                                    this.savingsAccountTypeModel.updateMaintainingBalance(TypeId);
                                }
                                else
                                {
                                    this.savingsAccountTypeModel.maintainingBalanceModel.AccountTypeId = TypeId;
                                    this.savingsAccountTypeModel.insertMaintainingBalance();
                                }
                            }
                            else
                            {
                                this.savingsAccountTypeModel.deleteMaintainingBalance(TypeId);
                            }
                            if (this.savingsAccountTypeModel.isDormancy == 1)
                            {
                                if (this.savingsAccountTypeModel.checkDormancy(TypeId) == 1)
                                {
                                    this.savingsAccountTypeModel.updateDormancy(TypeId);
                                }
                                else
                                {
                                    this.savingsAccountTypeModel.dormancyModel.TypeId = TypeId;
                                    this.savingsAccountTypeModel.insertDormancy();
                                }
                            }
                            else
                            {
                                this.savingsAccountTypeModel.deleteDormancy(TypeId);
                            }
                            if (this.savingsAccountTypeModel.isInterestRates == 1)
                            {
                                if (this.savingsAccountTypeModel.checkInterest(TypeId) == 1)
                                {
                                    this.savingsAccountTypeModel.updateInterestRate(TypeId);
                                }
                                else
                                {
                                    this.savingsAccountTypeModel.interestModel.TypeId = TypeId;
                                    this.savingsAccountTypeModel.insertInterestRate();
                                }
                            }
                            else
                            {
                                this.savingsAccountTypeModel.deleteInterestRate(TypeId);
                            }
                            if (this.savingsAccountType.checkArchivedState())
                            {
                                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypesAll());
                                DataGridViewRowCollection dr = this.savingsAccountType.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.savingsAccountType.setArchivedColor(i);
                                    }
                                    i++;
                                }
                                this.savingsAccountType.removeColumns();
                                this.savingsAccountType.clearError();
                                this.savingsAccountType.disableFunction();
                            }
                            else
                            {
                                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
                                this.savingsAccountType.removeColumns();
                                this.savingsAccountType.clearError();
                                this.savingsAccountType.disableFunction();
                            }
                            MessageBox.Show("Update Success.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isAdd = false;
                            TypeId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Update Failed.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage, "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                this.savingsAccountType.clearError();
                this.savingsAccountType.setErrorInitDeposit();
                this.savingsAccountType.setErrorAccountHolder();
                MessageBox.Show(this.errorMessage + "Invalid Input!" + Environment.NewLine + "Check Red Labels.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.savingsAccountType.disableFunction();
            this.savingsAccountType.clearError();
            isAdd = false;
            TypeId = 0;
        }

        public void checkArchived(object sender, EventArgs e)
        {
            if (this.savingsAccountType.checkArchivedState())
            {
                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypesAll());
                DataGridViewRowCollection dr = this.savingsAccountType.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if(bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.savingsAccountType.setArchivedColor(i);
                    }
                    i++;
                }
                this.savingsAccountType.removeColumns();
            }
            else
            {
                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
                this.savingsAccountType.removeColumns();
            }
        }

        public void btnRetrieve(object sender, EventArgs e)
        {
            if (this.savingsAccountType.getTextName() != String.Empty)
            {
                if (this.savingsAccountTypeModel.checkName(this.savingsAccountType.getTextName()) > 0)
                {
                    MessageBox.Show("Savings Account Type Already Exists." + Environment.NewLine + "Please Try A Different Name.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.savingsAccountType.setErrorName();
                }
                else
                {
                    this.savingsAccountTypeModel.retrieveSavingsAccount(this.TypeId);
                    MessageBox.Show("Retrieve Success.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (this.savingsAccountType.checkArchivedState())
                    {
                        this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypesAll());
                        DataGridViewRowCollection dr = this.savingsAccountType.getAllRows();
                        int i = 0;
                        foreach (DataGridViewRow row in dr)
                        {
                            if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                            {
                                this.savingsAccountType.setArchivedColor(i);
                            }
                            i++;
                        }
                        this.savingsAccountType.removeColumns();
                        this.savingsAccountType.clearError();
                        this.savingsAccountType.disableFunction();
                    }
                    else
                    {
                        this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
                        this.savingsAccountType.removeColumns();
                        this.savingsAccountType.clearError();
                        this.savingsAccountType.disableFunction();
                    }
                    isAdd = false;
                    TypeId = 0;
                }
            }
        }
    }
}
