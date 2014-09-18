using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Transaction.Controller
{
    class MembershipApplicationController
    {
        Transaction.Model.MembershipApplicationModel memberModel;
        Transaction.View.MembershipApplication membershipApplication;
        Transaction.Model.UpdateMemberModel updateMemberModel;
        Transaction.View.UpdateMember updateMember;
        Main.Logger logger = new Main.Logger();
        Dictionary<int, string> requirements = new Dictionary<int, string>();
        DataSet ds;
        int memberType = 0;
        int oldMemberType = 0;
        int oldSCap = 0;
        int oldLoan = 0;
        int minorAge = 18;
        bool isNew = false;
        public MembershipApplicationController(Transaction.Model.MembershipApplicationModel memberModel, Transaction.View.MembershipApplication membershipApplication, Transaction.Model.UpdateMemberModel updateMemberModel, Transaction.View.UpdateMember updateMember, Loan_Management.LoanManagementMenu loanManagementMenu)
        {
            this.memberModel = memberModel;
            this.membershipApplication = membershipApplication;
            this.updateMemberModel = updateMemberModel;
            this.updateMember = updateMember;
            this.membershipApplication.btnSaveEventHandler(this.btnSave);
            this.membershipApplication.btnGenerateCapitalEventHandler(this.btnGenerateCapital);
            this.membershipApplication.btnGenerateLoanEventHandler(this.btnGenerateLoan);
            this.membershipApplication.setDateBirthEventHandler(this.dateBirth_ValueChanged);
            this.membershipApplication.loadMemberTypes(this.loadMemberTypes);
            this.membershipApplication.comboMemberTypeSelectedIndexChanged(this.memberTypeIndexChanged);
            this.membershipApplication.setPage1NextEventHandler(this.button1_Click);
            this.membershipApplication.setPage2PrevEventHandler(this.button3_Click);
            this.membershipApplication.setPage2NextEventHandler(this.button2_Click);
            this.membershipApplication.setPage3PrevEventHandler(this.button4_Click);
            this.membershipApplication.setAccountNo("CP" +"-"+this.memberModel.generateAccountNo().ToString("D5"));
            //initReqChecklist
            this.membershipApplication.MdiParent = loanManagementMenu;
            this.membershipApplication.Show();
            isNew = true;
        }

        public MembershipApplicationController(Transaction.Model.MembershipApplicationModel memberModel, Transaction.View.MembershipApplication membershipApplication, String accountNo, Transaction.Model.UpdateMemberModel updateMemberModel, Transaction.View.UpdateMember updateMember, Loan_Management.LoanManagementMenu loanManagementMenu)
        {
            this.memberModel = memberModel;
            this.membershipApplication = membershipApplication;
            this.updateMemberModel = updateMemberModel;
            this.updateMember = updateMember;
            this.membershipApplication.btnSaveEventHandler(this.btnUpdate);
            this.membershipApplication.btnGenerateCapitalEventHandler(this.btnGenerateCapital);
            this.membershipApplication.btnGenerateLoanEventHandler(this.btnGenerateLoan);
     //       this.membershipApplication.setDateBirthEventHandler(this.dateBirth_ValueChanged);
            this.membershipApplication.loadMemberTypes(this.loadMemberTypes);
            this.membershipApplication.comboMemberTypeSelectedIndexChanged(this.memberTypeIndexChanged);
            this.membershipApplication.setPage1NextEventHandler(this.button1_Click);
            this.membershipApplication.setPage2PrevEventHandler(this.button3_Click);
            this.membershipApplication.setPage2NextEventHandler(this.button2_Click);
            this.membershipApplication.setPage3PrevEventHandler(this.button4_Click);
            this.membershipApplication.setAccountNo(accountNo);
            this.membershipApplication.Text = "Update Member Information - " + accountNo;
            this.setvaluesForUpdate(accountNo);
            //initReqChecklist
            this.membershipApplication.MdiParent = loanManagementMenu;
            this.membershipApplication.Show();
            isNew = false;
        }

        public void execLogger(String ModuleActivity)
        {
            logger.clear();
            logger.Module = "Transaction - Member Profile";
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


        public void loadMemberTypes(object args, EventArgs e)
        {
            this.membershipApplication.initMemberType(this.memberModel.selectMemberTypes(this.membershipApplication.getAge()));
        }

        public void setvaluesForUpdate(String accountNo) {

            SqlDataReader ds = this.memberModel.selectMember(accountNo);
            while (ds.Read()){
            memberType = int.Parse(ds["MemberTypeNo"].ToString());
            oldMemberType = memberType;
            this.membershipApplication.setMemberType(ds["Description"].ToString());
            //page1
            byte[] picData = (byte[])ds["Picture"];

            if(picData.Length > 0){
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    ms.Write(picData,0,picData.Length);
                    ms.Position = 0L;
                    this.membershipApplication.setPicture(new Bitmap(ms),picData);
            }
            try
            {
                this.membershipApplication.setMembershipDate(ds["MembershipDate"].ToString());
                this.membershipApplication.setLastName(ds["LastName"].ToString());
                this.membershipApplication.setFirstName(ds["FirstName"].ToString());
                this.membershipApplication.setMiddleName(ds["MiddleName"].ToString());
                this.membershipApplication.setAddressNo(ds["AddressNo"].ToString());
                this.membershipApplication.setAddressStreet(ds["AddressStreet"].ToString());
                this.membershipApplication.setAddressBarangay(ds["AddressBarangay"].ToString());
                this.membershipApplication.setAddressCity(ds["AddressCity"].ToString());
                this.membershipApplication.setAddressProvince(ds["AddressProvince"].ToString());
                this.membershipApplication.setAddressZip(ds["AddressZipCode"].ToString());
                this.membershipApplication.setTelNo(ds["TelephoneNo"].ToString());
                this.membershipApplication.setCelNo(ds["CellphoneNo"].ToString());
                this.membershipApplication.setEmail(ds["EmailAddress"].ToString());
                this.membershipApplication.setResidencyYear(int.Parse(ds["ResidenceYears"].ToString()));
                this.membershipApplication.setResidencyMonth(int.Parse(ds["ResidenceMonths"].ToString()));
                this.membershipApplication.setResidenceType(ds["ResidentialType"].ToString());
                this.membershipApplication.setBirthDate(ds["BirthDate"].ToString());
                this.membershipApplication.setBirthPlace(ds["BirthPlace"].ToString());
                this.membershipApplication.setGender(ds["Gender"].ToString());
                this.membershipApplication.setCivilStatus(ds["CivilStatus"].ToString());
                this.membershipApplication.setSpouse(ds["SpouseName"].ToString());
                this.membershipApplication.setChildren(int.Parse(ds["NoOfChildren"].ToString()));
                this.membershipApplication.setDependents(int.Parse(ds["NoOfDependents"].ToString()));

                //page2
                this.membershipApplication.setEducAttainment(ds["EducationalAttainment"].ToString());
                this.membershipApplication.setCourse(ds["Course"].ToString());
                this.membershipApplication.setEmploymentStatus(ds["EmploymentStatus"].ToString());
                this.membershipApplication.setEmployedYears(int.Parse(ds["EmploymentYears"].ToString()));
                this.membershipApplication.setOccupation(ds["EmploymentOccupation"].ToString());
                this.membershipApplication.setSelfEmployedYears(int.Parse(ds["SelfEmployedYears"].ToString()));
                this.membershipApplication.setGross(ds["GrossIncome"].ToString());
                this.membershipApplication.setEmployerName(ds["EmployerName"].ToString());
                this.membershipApplication.setEmployerAddress(ds["EmployerAddress"].ToString());
                this.membershipApplication.setEmployerNature(ds["EmployerNature"].ToString());
                this.membershipApplication.setEmployerContact(ds["EmployerContact"].ToString());
                if (bool.Parse(ds["OtherCoop"].ToString()))
                    this.membershipApplication.setOtherCoop();
                this.membershipApplication.setCoopName(ds["CoopName"].ToString());
                this.membershipApplication.setCoopAddress(ds["CoopAddress"].ToString());

                //page3
                if (ds["GuardianName"].ToString() != String.Empty)
                    this.membershipApplication.enableMinorFeatures();
                this.membershipApplication.setGuardianName(ds["GuardianName"].ToString());
                this.membershipApplication.setGuardianRelation(ds["GuardianRelation"].ToString());
                this.membershipApplication.setLoanPassbook(this.memberModel.getLoanPassbook(accountNo).ToString());
                oldLoan = this.memberModel.getLoanPassbook(accountNo);
                this.membershipApplication.setCapitalPassbook(this.memberModel.getCapitalPassbook(accountNo).ToString());
                oldSCap = this.memberModel.getCapitalPassbook(accountNo);
                this.refreshAccounts(false);
            }
            catch (NullReferenceException) { 
                
            }

            //page4
            byte[] acctHolderSign1 = (byte[]) ds["AcctHolderSign1"];
            if (acctHolderSign1.Length != 0)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ms.Write(acctHolderSign1, 0, acctHolderSign1.Length);
                ms.Position = 0L;
                this.membershipApplication.setAcctHolderSign1(new Bitmap(ms),acctHolderSign1);
            }

            byte[] acctHolderSign2Data = (byte[]) ds["AcctHolderSign2"];
            if (acctHolderSign2Data.Length != 0)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ms.Write(acctHolderSign2Data, 0, acctHolderSign2Data.Length);
                ms.Position = 0L;
                this.membershipApplication.setAcctHolderSign2(new Bitmap(ms),acctHolderSign2Data);
            }

            Object acctHolderSign3 = (Object)ds["AcctHolderSign3"];
            byte[] acctHolderSign3Data = (byte[])acctHolderSign3;

            if (acctHolderSign3Data.Length != 0)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ms.Write(acctHolderSign3Data, 0, acctHolderSign3Data.Length);
                ms.Position = 0L;
                this.membershipApplication.setAcctHolderSign3(new Bitmap(ms),acctHolderSign3Data);
            }

            Object guardianSign1 = (Object)ds["GuardianSign1"];
            byte[] guardianSign1Data = (byte[])guardianSign1;

            if (guardianSign1Data.Length != 0)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ms.Write(guardianSign1Data, 0, guardianSign1Data.Length);
                ms.Position = 0L;
                this.membershipApplication.setGuardianSign1(new Bitmap(ms),guardianSign1Data);
            }

            Object guardianSign2 = (Object)ds["GuardianSign2"];
            byte[] guardianSign2Data = (byte[])guardianSign2;

            if (guardianSign2Data.Length != 0)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ms.Write(guardianSign2Data, 0, guardianSign2Data.Length);
                ms.Position = 0L;
                this.membershipApplication.setGuardianSign2(new Bitmap(ms),guardianSign2Data);
            }

            Object guardianSign3 = (Object)ds["GuardianSign3"];
            byte[] guardianSign3Data = (byte[])guardianSign3;

            if (guardianSign3Data.Length != 0)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ms.Write(guardianSign3Data, 0, guardianSign3Data.Length);
                ms.Position = 0L;
                this.membershipApplication.setGuardianSign3(new Bitmap(ms),guardianSign3Data);
            } 
           }
        }

        

        public void refreshAccounts(bool isNew) {

            memberType = membershipApplication.getMemberType();
            this.ds = memberModel.selectMemberTypes(this.membershipApplication.getAge());
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if ((int)ds.Tables[0].Rows[i][0] == memberType)
                {
                                        if (bool.Parse(ds.Tables[0].Rows[i]["hasShareCapital"].ToString()))
                    {
                        this.membershipApplication.enableShareCapital();
                    }
                    if (bool.Parse(ds.Tables[0].Rows[i]["hasLoan"].ToString()))
                    {
                        this.membershipApplication.enableLoan();
                    }
                }
            }
                   
        }

        public void memberTypeIndexChanged(object args, EventArgs e)
        {
            if (oldMemberType != membershipApplication.getMemberType())
            {
                this.membershipApplication.disableGenerate(isNew);
                this.refreshAccounts(true);
            }
            else
                this.refreshAccounts(false);

        }


        private void dateBirth_ValueChanged(object sender, EventArgs e)
        {
            int age = this.membershipApplication.getAge();
            if (age < minorAge)
            {
                this.membershipApplication.enableMinorFeatures();
                
            }

            else
            {
                this.membershipApplication.disableMinorFeatures();

            }
            this.membershipApplication.initMemberType(this.memberModel.selectMemberTypes(age));
            this.membershipApplication.counterLimitToAge(age);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (checkPage1())
            this.membershipApplication.page1Next();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.membershipApplication.page2Prev();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkPage2())
                this.membershipApplication.page2Next();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.membershipApplication.page3Prev();
        }


        public bool checkPage1() {

            bool result = true;

            //page1
            this.memberModel.membershipDate = this.membershipApplication.getMembershipDate();
            this.memberModel.Picture = this.membershipApplication.getPicture();
            this.memberModel.LastName = this.membershipApplication.getLastName();
            this.memberModel.FirstName = this.membershipApplication.getFirstName();
            this.memberModel.MiddleName = this.membershipApplication.getMiddleName();
            this.memberModel.AddressNo = this.membershipApplication.getAddressNo();
            this.memberModel.AddressStreet = this.membershipApplication.getAddressStreet();
            this.memberModel.AddressBarangay = this.membershipApplication.getAddressBarangay();
            this.memberModel.AddressCity = this.membershipApplication.getAddressCity();
            this.memberModel.AddressProvince = this.membershipApplication.getAddressProvince();
            this.memberModel.AddressZip = this.membershipApplication.getAddressZip();
            this.memberModel.telNo = this.membershipApplication.getTelNo();
            this.memberModel.celNo = this.membershipApplication.getCelNo();
            this.memberModel.emailAdd = this.membershipApplication.getEmail();
            this.memberModel.ResidencyYears = this.membershipApplication.getResidencyYear();
            this.memberModel.ResidencyMonths = this.membershipApplication.getResidencyMonth();
            this.memberModel.ResidenceType = this.membershipApplication.getResidenceType();
            this.memberModel.BirthDate = DateTime.Parse(this.membershipApplication.getBirthDate());
            this.memberModel.BirthPlace = this.membershipApplication.getBirthPlace();
            this.memberModel.Gender = this.membershipApplication.getGender();
            this.memberModel.CivilStatus = this.membershipApplication.getCivilStatus();
            this.memberModel.Spouse = this.membershipApplication.getSpouse();
            this.memberModel.NoChildren = this.membershipApplication.getChildren();
            this.memberModel.NoDependency = this.membershipApplication.getDependents();

            this.membershipApplication.resetPage1Labels();

            if (this.memberModel.Picture == null) {
                result = false;
                this.membershipApplication.errorPicture();
            }

            if (this.memberModel.membershipDate == String.Empty)
            {
                result = false;
                this.membershipApplication.errorMembershipDate();
            }

            if (this.memberModel.LastName == String.Empty) {
                result = false;
                this.membershipApplication.errorLastName();
            }
            if (this.memberModel.FirstName == String.Empty) {
                result = false;
                this.membershipApplication.errorFirstName();
            }
            if (this.memberModel.AddressCity == String.Empty) {
                result = false;
                this.membershipApplication.errorCity();
            }

            if (this.memberModel.ResidencyMonths == 0 && this.memberModel.ResidencyYears == 0) 
            {
                result = false;
                this.membershipApplication.errorPdRes();
            }
            if (this.memberModel.ResidenceType == String.Empty)
            {
                result = false;
                this.membershipApplication.errorResType();
            }
            if (this.memberModel.BirthDate == DateTime.Today)
            {
                result = false;
                this.membershipApplication.errorBDate();
            }
            if (this.memberModel.BirthPlace == String.Empty)
            {
                result = false;
                this.membershipApplication.errorBPlace();
            }
            if (this.memberModel.CivilStatus == String.Empty)
            {
                result = false;
                this.membershipApplication.errorCivil();
            }
            if (this.memberModel.Gender == String.Empty)
            {
                result = false;
                this.membershipApplication.errorGender();
            }

            if (this.memberModel.telNo == String.Empty && this.memberModel.celNo == String.Empty && this.memberModel.emailAdd == String.Empty )
            {
                result = false;
                this.membershipApplication.errorContact();
            }            
            

            return result;
        }

        public bool checkPage2() {

            bool result = true;
            //page2
            this.memberModel.EducAttainment = this.membershipApplication.getEducAttainment();
            this.memberModel.Course = this.membershipApplication.getCourse();
            this.memberModel.EmploymentStatus = this.membershipApplication.getEmploymentStatus();
            this.memberModel.EmploymentYears = this.membershipApplication.getEmployedYears();
            this.memberModel.EmploymentOccupation = this.membershipApplication.getOccupation();
            this.memberModel.SelfEmployedYears = this.membershipApplication.getSelfEmployedYears();
            this.memberModel.Gross = this.membershipApplication.getGross();
            this.memberModel.EmployerName = this.membershipApplication.getEmployerName();
            this.memberModel.EmployerNature = this.membershipApplication.getEmployerNature();
            this.memberModel.EmployerAddress = this.membershipApplication.getEmployerAddress();
            this.memberModel.EmployerContact = this.membershipApplication.getEmployerContact();
            this.memberModel.OtherCoop = this.membershipApplication.getOtherCoop();
            this.memberModel.CoopName = this.membershipApplication.getCoopName();
            this.memberModel.CoopAddress = this.membershipApplication.getCoopAddress();

            this.membershipApplication.resetPage2Labels();

            if (this.memberModel.EducAttainment == String.Empty)
            {
                result = false;
                this.membershipApplication.errorEduc();
            }

            else if (this.memberModel.EducAttainment == "College" && this.memberModel.Course == String.Empty)
            {
                result = false;
                this.membershipApplication.errorCourse();
            }

            if (this.memberModel.EmploymentStatus == String.Empty)
            {
                result = false;
                this.membershipApplication.errorEmploymt();
            }

            else if (this.memberModel.EmploymentStatus == "Employed")
            {
                if (this.memberModel.EmploymentYears == 0)
                {
                    result = false;
                    this.membershipApplication.errorEmpYears();
                }

                if (this.memberModel.EmploymentOccupation == String.Empty)
                {
                    result = false;
                    this.membershipApplication.errorOccup();
                }
                if (this.memberModel.Gross == 0.00)
                {
                    result = false;
                    this.membershipApplication.errorIncome();
                }
                if (this.memberModel.EmployerAddress == String.Empty)
                {
                    result = false;
                    this.membershipApplication.errorEmpAdd();
                }
                if (this.memberModel.EmployerName == String.Empty)
                {
                    result = false;
                    this.membershipApplication.errorEmpName();                
                }
                if (this.memberModel.EmployerContact == String.Empty)
                {
                    result = false;
                    this.membershipApplication.errorEmpContact();
                }
            }

            else if (this.memberModel.EmploymentStatus == "Self-Employed")
            {
                if (this.memberModel.SelfEmployedYears == 0)
                {
                    result = false;
                    this.membershipApplication.errorSEmpYears();
                }

                if (this.memberModel.Gross == 0.00)
                {
                    result = false;
                    this.membershipApplication.errorIncome();
                }
            }
            if (this.memberModel.OtherCoop == 1) 
            {
                if (this.memberModel.CoopName == String.Empty)
                {
                    result = false;
                    this.membershipApplication.errorCoopName();
                }
                if (this.memberModel.CoopAddress == String.Empty)
                {
                    result = false;
                    this.membershipApplication.errorCoopAdd();
                }
            }
            return result;
        }

        public bool checkPage3() {

            bool result = true;
            //page3
            this.memberModel.AccountNo = this.membershipApplication.getAccountNo();
            this.memberModel.MemberType = this.membershipApplication.getMemberType();
            this.memberModel.guardianName = this.membershipApplication.getGuardianName();
            this.memberModel.guardianRelation = this.membershipApplication.getGuardianRelation();
            this.membershipApplication.resetPage3Labels();

            if (this.memberModel.MemberType == 0)
            { 
                result = false;
                this.membershipApplication.errorMemType();
            }

            if (this.membershipApplication.checkMinor() && this.memberModel.guardianName == String.Empty)
            {
                result = false;
                this.membershipApplication.errorGuardianName();
            }

            if (this.membershipApplication.checkMinor() && this.memberModel.guardianRelation == String.Empty)
            {
                result = false;
                this.membershipApplication.errorGuardianRelation();
            }

            if (this.membershipApplication.checkLoan() && this.membershipApplication.getLoanPassbook() == String.Empty)
            {
                result = false;
                this.membershipApplication.errorAccts();
            }

            if (this.membershipApplication.checkShare() && this.membershipApplication.getCapitalPassbook() == String.Empty)
            {
                result = false;
                this.membershipApplication.errorAccts();
            }

            this.memberModel.acctHolderSign1 = this.membershipApplication.getAcctHolderSign1();
            this.memberModel.acctHolderSign2 = this.membershipApplication.getAcctHolderSign2();
            this.memberModel.acctHolderSign3 = this.membershipApplication.getAcctHolderSign3();

            this.memberModel.guardianSign1 = this.membershipApplication.getGuardianSign1();
            this.memberModel.guardianSign2 = this.membershipApplication.getGuardianSign2();
            this.memberModel.guardianSign3 = this.membershipApplication.getGuardianSign3();

            if (!this.membershipApplication.checkMinor() && this.memberModel.acctHolderSign1 == null && this.memberModel.acctHolderSign2 == null && this.memberModel.acctHolderSign3 == null)
            {
                result = false;
                this.membershipApplication.errorAcctSign();
            }

            else if (this.membershipApplication.checkMinor() && this.memberModel.guardianSign1 == null && this.memberModel.guardianSign2 == null && this.memberModel.guardianSign3 == null)
            {
                result = false;
                this.membershipApplication.errorGuardianSign();
            }

            return result;
        }

        public void btnSave(object args, EventArgs e)
        {
            if (checkPage3() && checkPage1() && checkPage2())
            {
                int insertResult = this.memberModel.insertMember();
                if (insertResult == 1)
                {
                   if (this.membershipApplication.checkLoan() && this.membershipApplication.getLoanPassbook() != String.Empty)
                    {
                        int res = this.memberModel.activateStatus(this.membershipApplication.getAccountNo());
                        this.memberModel.LoanPassbook = int.Parse(this.membershipApplication.getLoanPassbook());
                        if (this.memberModel.insertLoanPassbook() == 1)
                        {
                            MessageBox.Show("Loan Passbook Generated", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            execLogger("Loan Passbook Generated");

                        }
                    }

                    if (this.membershipApplication.checkShare() && this.membershipApplication.getCapitalPassbook() != String.Empty)
                    {
                        this.memberModel.CapitalPassbook = int.Parse(this.membershipApplication.getCapitalPassbook());
                        if (this.memberModel.insertCapitalPassbook() == 1)
                        {
                            MessageBox.Show("Share Capital Passbook Generated", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            execLogger("Share Capital Passbook Generated");

                        }
                    }

                    MessageBox.Show("Save Success!", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Add member '" + this.memberModel.AccountNo + "'");
                    this.membershipApplication.resetAll();
                    this.updateMember.setDataMembers(this.updateMemberModel.selectMember());
                    this.membershipApplication.setAccountNo("CP" + "-" + this.memberModel.generateAccountNo().ToString("D5"));
                    this.membershipApplication.page2Prev();
                }
                else
                {
                    MessageBox.Show("Save Failed!", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                MessageBox.Show("Sorry, one or more fields report an error. Verify all encoded information and try again.", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnUpdate(object args, EventArgs e) {


            if (checkPage1() & checkPage2() & checkPage3())
            {
                int insertResult = this.memberModel.updateMember();
                if (insertResult == 1)
                {
                    
                    if (this.membershipApplication.getLoanPassbook() != String.Empty)
                    {
                        this.memberModel.LoanPassbook = int.Parse(this.membershipApplication.getLoanPassbook());
                        if (this.memberModel.LoanPassbook > oldLoan)
                        if (this.memberModel.insertLoanPassbook() == 1)
                        {
                            MessageBox.Show("Loan Passbook Generated", "Update Membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            execLogger("Loan Passbook Generated");

                        }
                    }

                    if (this.membershipApplication.getCapitalPassbook() != String.Empty)
                    {
                        this.memberModel.CapitalPassbook = int.Parse(this.membershipApplication.getCapitalPassbook());
                        if (this.memberModel.CapitalPassbook > oldSCap)
                        if (this.memberModel.insertCapitalPassbook() == 1)
                        {
                            MessageBox.Show("Share Capital Passbook Generated", "Update Membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            execLogger("Share Capital Passbook Generated");

                        }
                    }

                    MessageBox.Show("Save Success!", "Update Membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    execLogger("Update member '" + this.memberModel.AccountNo + "'");
                    this.updateMember.setDataMembers(this.updateMemberModel.selectMember());
                    this.membershipApplication.page2Prev();
                    this.updateMember.setDataMembers(this.updateMemberModel.selectMember());


                }
                else
                {
                    MessageBox.Show("Save Failed!", "Update Membership", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sorry, one or more fields report an error. Verify all encoded information and try again.", "Update Membership", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        public void btnGenerateCapital(object args, EventArgs e)
        {
            this.membershipApplication.setCapitalPassbook(this.memberModel.generateCapitalPassbook().ToString());
        }

        public void btnGenerateLoan(object args, EventArgs e)
        {
            this.membershipApplication.setLoanPassbook(this.memberModel.generateLoanPassbook().ToString());
        }
    }
}
