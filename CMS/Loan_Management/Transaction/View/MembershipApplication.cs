using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Transaction.View
{
    public partial class MembershipApplication : Form
    {
        byte[] imgData = null;
        public byte[] acctHolderSign1 { get; set; }
        public byte[] acctHolderSign2 { get; set; }
        public byte[] acctHolderSign3 { get; set; }
        public byte[] guardianSign1 { get; set; }
        public byte[] guardianSign2 { get; set; }
        public byte[] guardianSign3 { get; set; }
        DataTable dt = new DataTable();
        int age = 0;

        public MembershipApplication()
        {
            InitializeComponent();
            dateBirth.MaxDate = new DateTime(DateTime.Today.Year, 12, 31);
            acctHolderSign1 = null;
            acctHolderSign2 = null;
            acctHolderSign3 = null;
            guardianSign1 = null;
            guardianSign2 = null;
            guardianSign3 = null;
            lblPicture.Visible = false;
            disableMinorFeatures();
        }

        private void radioResidenceOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioResidenceOthers.Checked)
            {
                this.txtResidenceOthers.Enabled = true;
            }
            else
            {
                this.txtResidenceOthers.Clear();
                this.txtResidenceOthers.Enabled = false;
            }
        }

        private void comboCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboCivil.SelectedIndex != 0)
            {
                this.txtSpouse.Enabled = true;
                this.numChildren.Enabled = true;
                this.numDependents.Enabled = true;
            }
            else
            {
                this.txtSpouse.Clear();
                this.numChildren.Value = 0;
                this.numDependents.Value = 0;

                this.txtSpouse.Enabled = false;
                this.numChildren.Enabled = false;
                this.numDependents.Enabled = false;
            }
        }

        public void comboMemberTypeSelectedIndexChanged(EventHandler e)
        {
            this.comboMemberType.SelectedIndexChanged += e;
        }

        public void resetAll()
        {
            this.txtLastName.Clear();
            this.txtMiddleName.Clear();
            this.txtFirstName.Clear();
            this.txtAddressNo.Clear();
            this.txtAddressStreet.Clear();
            this.txtAddressBarangay.Clear();
            this.txtAddressCity.Clear();
            this.txtAddressProvince.Clear();
            this.txtAddressZip.Clear();
            this.txtTelephone.Clear();
            this.txtCellphone.Clear();
            this.txtEmailAdd.Clear();
            this.numYear.Value = 0;
            this.numMonths.Value = 0;
            this.radioOwned.Checked = false;
            this.radioOwnedParents.Checked = false;
            this.radioRented.Checked = false;
            this.radioResidenceOthers.Checked = false;
            this.txtResidenceOthers.Clear();
            this.txtResidenceOthers.Enabled = false;
            this.dateBirth.Value = DateTime.Today;
            this.dateMembership.Value = DateTime.Today;
            this.txtBirthPlace.Clear();
            this.radioMale.Checked = false;
            this.radioFemale.Checked = false;
            this.comboCivil.SelectedIndex = -1;
            this.txtSpouse.Clear();
            this.txtSpouse.Enabled = false;
            this.numChildren.Value = 0;
            this.numChildren.Enabled = false;
            this.numDependents.Value = 0;
            this.numDependents.Enabled = false;
            this.picture.Image = null;
            this.radioNoneEduc.Checked = false;
            this.radioElementary.Checked = false;
            this.radioHighschool.Checked = false;
            this.radioCollege.Checked = false;
            this.txtCourse.Clear();
            this.txtCourse.Enabled = false;
            this.radioUnemployed.Checked = false;
            this.radioEmployed.Checked = false;
            this.numEmployedYears.Value = 0;
            this.numEmployedYears.Enabled = false;
            this.txtOccupation.Clear();
            this.txtOccupation.Enabled = false;
            this.radioRetired.Checked = false;
            this.radioSelfEmployed.Checked = false;
            this.numSelfEmployedYears.Value = 0;
            this.numSelfEmployedYears.Enabled = false;
            this.txtGross.Clear();
            this.txtGross.Enabled = false;
            this.txtEmployerName.Clear();
            this.txtEmployerName.Enabled = false;
            this.txtEmployerNature.Clear();
            this.txtEmployerNature.Enabled = false;
            this.txtEmployerAddress.Clear();
            this.txtEmployerAddress.Enabled = false;
            this.txtEmployerContact.Clear();
            this.txtEmployerContact.Enabled = false;
            this.checkOtherCoop.CheckState = CheckState.Unchecked;
            this.txtCoopName.Clear();
            this.txtCoopName.Enabled = false;
            this.txtCoopAddress.Clear();
            this.txtCoopAddress.Enabled = false;
            this.txtGuardianName.Clear();
            this.cbGuardianRelation.SelectedIndex = -1;
            this.cbGuardianRelation.Visible = false;
            this.txtSharePassbook.Clear();
            this.txtLoanPassbook.Clear();
            this.disableMinorFeatures();
            this.acctholder1.Image = null;
            this.acctholder2.Image = null;
            this.acctholder3.Image = null;
            this.guardian1.Image = null;
            this.guardian2.Image = null;
            this.guardian3.Image = null;
            this.disableMinorFeatures();
        }

        public void disableForUpdate() {

            gpGender.Enabled = false;
            lblGender.ForeColor = Color.Gray;
        
        }

        private void radioCollege_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioCollege.Checked)
            {
                this.txtCourse.Enabled = true;
            }
            else
            {
                this.txtCourse.Clear();
                this.txtCourse.Enabled = false;
            }
        }

        private void radioEmployed_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioEmployed.Checked)
            {
                this.numEmployedYears.Enabled = true;
                this.txtGross.Enabled = true;
                this.txtOccupation.Enabled = true;
                this.txtEmployerName.Enabled = true;
                this.txtEmployerNature.Enabled = true;
                this.txtEmployerAddress.Enabled = true;
                this.txtEmployerContact.Enabled = true;
            }
            else
            {
                this.numEmployedYears.Value = 0;
                this.txtGross.Enabled = false;
                this.txtGross.Clear();
                this.txtOccupation.Clear();
                this.txtEmployerName.Clear();
                this.txtEmployerNature.Clear();
                this.txtEmployerAddress.Clear();
                this.txtEmployerContact.Clear();
                this.numEmployedYears.Enabled = false;
                this.txtOccupation.Enabled = false;
                this.txtEmployerName.Enabled = false;
                this.txtEmployerNature.Enabled = false;
                this.txtEmployerAddress.Enabled = false;
                this.txtEmployerContact.Enabled = false;
            }
        }

        private void radioSelfEmployed_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioSelfEmployed.Checked)
            {
                this.numSelfEmployedYears.Enabled = true;
                this.txtGross.Enabled = true;
            }
            else
            {
                this.numSelfEmployedYears.Value = 0;
                this.txtGross.Clear();
                this.numSelfEmployedYears.Enabled = false;
                this.txtGross.Enabled = false;
            }
        }

        private void checkOtherCoop_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkOtherCoop.CheckState == CheckState.Checked)
            {
                this.txtCoopName.Enabled = true;
                this.txtCoopAddress.Enabled = true;
            }
            else
            {
                this.txtCoopName.Clear();
                this.txtCoopAddress.Clear();
                this.txtCoopName.Enabled = false;
                this.txtCoopAddress.Enabled = false;
            }
        }

        
        //getter setter

        public void setAccountNo(String s)
        {
            this.txtAccountNo.Text = s;
        }

        public String getAccountNo()
        {
            return this.txtAccountNo.Text;
        }

        public void setMemberType(String s)
        {
            this.comboMemberType.Text = s;
        }

        public int getMemberType()
        {
            try
            {
                return int.Parse(this.comboMemberType.SelectedValue.ToString());
            }
            catch (Exception) {
                return 0;
            }
        }

        public byte[] getPicture()
        {
            if (this.picture.Image == null)
            {
                return null;
            }
            else
            {
                return this.imgData;
            }
        }

        public void setPicture(Image img, byte[] imgData)
        {
            this.picture.Image = img;
            this.imgData = imgData;
        }

        public void setLastName(String s)
        {
            this.txtLastName.Text = s;
        }

        public String getLastName()
        {
            return this.txtLastName.Text.Trim();
        }

        public void setFirstName(String s)
        {
            this.txtFirstName.Text = s;
        }

        public String getFirstName()
        {
            return this.txtFirstName.Text.Trim();
        }

        public void setMiddleName(String s)
        {
            this.txtMiddleName.Text = s;
        }

        public String getMiddleName()
        {
            return this.txtMiddleName.Text.Trim();
        }

        public void setAddressNo(String s)
        {
            this.txtAddressNo.Text = s;
        }

        public String getAddressNo()
        {
            return this.txtAddressNo.Text.Trim();
        }

        public void setAddressStreet(String s)
        {
            this.txtAddressStreet.Text = s;
        }

        public String getAddressStreet()
        {
            return this.txtAddressStreet.Text.Trim();
        }

        public void setAddressBarangay(String s)
        {
            this.txtAddressBarangay.Text = s;
        }

        public String getAddressBarangay()
        {
            return this.txtAddressBarangay.Text.Trim();
        }

        public void setAddressCity(String s)
        {
            this.txtAddressCity.Text = s;
        }

        public String getAddressCity()
        {
            return this.txtAddressCity.Text.Trim();
        }

        public void setAddressProvince(String s)
        {
            this.txtAddressProvince.Text = s;
        }

        public String getAddressProvince()
        {
            return this.txtAddressProvince.Text.Trim();
        }

        public void setAddressZip(String s)
        {
            this.txtAddressZip.Text = s;
        }

        public String getAddressZip()
        {
            return this.txtAddressZip.Text.Trim();
        }

        public void setTelNo(String s)
        {
            this.txtTelephone.Text = s;
        }

        public String getTelNo()
        {
            return this.txtTelephone.Text.Trim();
        }

        public void setCelNo(String s)
        {
            this.txtCellphone.Text = s;
        }

        public String getCelNo()
        {
            return this.txtCellphone.Text.Trim();
        }

        public void setEmail(String s)
        {
            this.txtEmailAdd.Text = s;
        }

        public String getEmail()
        {
            return this.txtEmailAdd.Text.Trim();
        }

        public void setResidencyYear(int i)
        {
            this.numYear.Value = i;
        }

        public int getResidencyYear()
        {
            return int.Parse(this.numYear.Value.ToString());
        }

        public void setResidencyMonth(int i)
        {
            this.numMonths.Value = i;
        }

        public int getResidencyMonth()
        {
            return int.Parse(this.numMonths.Value.ToString());
        }

        public void setResidenceType(String s)
        {
            if (s == "Owned")
            {
                this.radioOwned.Checked = true;
            }
            else if (s == "Owned by Parents")
            {
                this.radioOwnedParents.Checked = true;
            }
            else if (s == "Rented")
            {
                this.radioRented.Checked = true;
            }
            else
            {
                this.radioResidenceOthers.Checked = true;
                this.txtResidenceOthers.Text = s;
            }
        }

        public String getResidenceType()
        {
            if (this.radioOwned.Checked)
            {
                return "Owned";
            }
            else if (this.radioOwnedParents.Checked)
            {
                return "Owned by Parents";
            }
            else if (this.radioRented.Checked)
            {
                return "Rented";
            }
            else
            {
                return this.txtResidenceOthers.Text.Trim();
            }
        }

        public void setBirthDate(String s)
        {
            this.dateBirth.Value = DateTime.Parse(s);
        }

        public String getBirthDate()
        {
            return this.dateBirth.Value.ToString("MM/dd/yyyy");
        }

        public void setMembershipDate(String s)
        {
            this.dateMembership.Value = DateTime.Parse(s);
        }

        public String getMembershipDate()
        {
            return this.dateMembership.Value.ToString("MM/dd/yyyy");
        }

        public int getAge() {

            age = DateTime.Today.Year - dateBirth.Value.Year;
            if (DateTime.Today < dateBirth.Value.AddYears(age))
                age--;

            return age;
        }

        public void setBirthPlace(String s)
        {
            this.txtBirthPlace.Text = s;
        }

        public String getBirthPlace()
        {
            return this.txtBirthPlace.Text.Trim();
        }

        public void setGender(String s)
        {
            if (s == "Male")
            {
                this.radioMale.Checked = true;
            }
            else if (s == "Female")
            {
                this.radioFemale.Checked = true;
            }
        }

        public String getGender()
        {
            if (this.radioMale.Checked)
            {
                return "Male";
            }
            else if (this.radioFemale.Checked)
            {
                return "Female";
            }
            else return String.Empty;
        }

        public void setCivilStatus(String s)
        {
            this.comboCivil.SelectedItem = s;
        }

        public String getCivilStatus()
        {
            try
            {
                return this.comboCivil.SelectedItem.ToString();
            }
            catch (NullReferenceException) {
                return String.Empty;
            }
        }

        public void setSpouse(String s)
        {
            this.txtSpouse.Text = s;
        }

        public String getSpouse()
        {
            return this.txtSpouse.Text.Trim();
        }

        public void setChildren(int i)
        {
            this.numChildren.Value = i;
        }

        public int getChildren()
        {
            return int.Parse(this.numChildren.Value.ToString());
        }

        public void setDependents(int i)
        {
            this.numDependents.Value = i;
        }

        public int getDependents()
        {
            return int.Parse(this.numDependents.Value.ToString());
        }

        public void setEducAttainment(String s)
        {
            if (s == "Elementary")
            {
                this.radioElementary.Checked = true;
            }
            else if (s == "High School")
            {
                this.radioHighschool.Checked = true;
            }
            else if (s == "College")
            {
                this.radioCollege.Checked = true;
            }
            else
            {
                this.radioNoneEduc.Checked = true;
            }
        }

        public String getEducAttainment()
        {
            if (this.radioElementary.Checked)
            {
                return "Elementary";
            }
            else if (this.radioHighschool.Checked)
            {
                return "High School";
            }
            else if (this.radioCollege.Checked)
            {
                return "College";
            }
            else if (this.radioNoneEduc.Checked)
            {
                return "None";
            }
            else return String.Empty;
        }

        public void setCourse(String s)
        {
            this.txtCourse.Text = s;
        }

        public String getCourse()
        {
            return this.txtCourse.Text.Trim();
        }

        public void setEmploymentStatus(String s)
        {
            if (s == "Unemployed")
            {
                this.radioUnemployed.Checked = true;
            }
            else if (s == "Employed")
            {
                this.radioEmployed.Checked = true;
            }
            else if (s == "Retired")
            {
                this.radioRetired.Checked = true;
            }
            else
            {
                this.radioSelfEmployed.Checked = true;
            }
        }

        public String getEmploymentStatus()
        {
            if (radioUnemployed.Checked)
            {
                return "Unemployed";
            }
            else if (radioEmployed.Checked)
            {
                return "Employed";
            }
            else if (radioRetired.Checked)
            {
                return "Retired";
            }
            else if (radioSelfEmployed.Checked)
            {
                return "Self-Employed";
            }
            else return String.Empty;
        }

        public void setEmployedYears(int i)
        {
            this.numEmployedYears.Value = i;
        }

        public int getEmployedYears()
        {
            return int.Parse(this.numEmployedYears.Value.ToString());
        }

        public void setSelfEmployedYears(int i)
        {
            this.numSelfEmployedYears.Value = i;
        }

        public int getSelfEmployedYears()
        {
            return int.Parse(this.numSelfEmployedYears.Value.ToString());
        }

        public void setOccupation(String s)
        {
            this.txtOccupation.Text = s;
        }

        public String getOccupation()
        {
            return this.txtOccupation.Text.Trim();
        }

        public void setGross(String s)
        {
            this.txtGross.Text = s;
        }

        public double getGross()
        {
            try
            {
                return double.Parse(this.txtGross.Text);
            }
            catch (Exception) { return 0.00; }
        }

        public void setEmployerName(String s)
        {
            this.txtEmployerName.Text = s;
        }

        public String getEmployerName()
        {
            return this.txtEmployerName.Text.Trim();
        }

        public void setEmployerNature(String s)
        {
            this.txtEmployerNature.Text = s;
        }

        public String getEmployerNature()
        {
            return this.txtEmployerNature.Text.Trim();
        }

        public void setEmployerAddress(String s)
        {
            this.txtEmployerAddress.Text = s;
        }

        public String getEmployerAddress()
        {
            return this.txtEmployerAddress.Text.Trim();
        }

        public void setEmployerContact(String s)
        {
            this.txtEmployerContact.Text = s;
        }

        public String getEmployerContact()
        {
            return this.txtEmployerContact.Text.Trim();
        }

        public void setOtherCoop()
        {
            this.checkOtherCoop.CheckState = CheckState.Checked;
        }

        public int getOtherCoop()
        {
            if (checkOtherCoop.CheckState == CheckState.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void setCoopName(String s)
        {
            this.txtCoopName.Text = s;
        }

        public String getCoopName()
        {
            return this.txtCoopName.Text.Trim();
        }

        public void setCoopAddress(String s)
        {
            this.txtCoopAddress.Text = s;
        }

        public String getCoopAddress()
        {
            return this.txtCoopAddress.Text.Trim();
        }

        public void setGuardianName(String s)
        {
            this.txtGuardianName.Text = s;
        }

        public String getGuardianName()
        {
            return this.txtGuardianName.Text.Trim();
        }

        public void setGuardianRelation(String s)
        {
            this.cbGuardianRelation.SelectedItem = s;
        }

        public String getGuardianRelation()
        {
            try
            {
                return this.cbGuardianRelation.SelectedItem.ToString();
            }
            catch (NullReferenceException) {
                return String.Empty;
            }
        }        


       public void setCapitalPassbook(String s)
        {
            this.txtSharePassbook.Text = s;
        }

        public String getCapitalPassbook()
        {
            return this.txtSharePassbook.Text.ToString();
        }

        public void setLoanPassbook(String s)
        {
            this.txtLoanPassbook.Text = s;
        }

        public String getLoanPassbook()
        {
            return this.txtLoanPassbook.Text.ToString();
        }

        public byte[] getAcctHolderSign1()
        {
            if (this.acctholder1.Image == null)
            {
                return null;
            }
            else
            {
                return this.acctHolderSign1;
            }
        }

        public void setAcctHolderSign1(Image img, byte[] imgData)
        {
            this.acctholder1.Image = img;
            this.acctHolderSign1 = imgData;
        }

        public byte[] getAcctHolderSign2()
        {
            if (this.acctholder2.Image == null)
            {
                return null;
            }
            else
            {
                return this.acctHolderSign2;
            }
        }

        public void setAcctHolderSign2(Image img, byte[] imgData)
        {
            this.acctholder2.Image = img;
            this.acctHolderSign2 = imgData;
        }

        public byte[] getAcctHolderSign3()
        {
            if (this.acctholder3.Image == null)
            {
                return null;
            }
            else
            {
                return this.acctHolderSign3;
            }
        }

        public void setAcctHolderSign3(Image img, byte[] imgData)
        {
            this.acctholder3.Image = img;
            this.acctHolderSign3 = imgData;
        }

        public byte[] getGuardianSign1()
        {
            if (this.guardian1.Image == null)
            {
                return null;
            }
            else
            {
                return this.guardianSign1;
            }
        }

        public void setGuardianSign1(Image img, byte[] imgData)
        {
            this.guardian1.Image = img;
            this.guardianSign1 = imgData;
        }

        public byte[] getGuardianSign2()
        {
            if (this.guardian2.Image == null)
            {
                return null;
            }
            else
            {
                return this.guardianSign2;
            }
        }

        public void setGuardianSign2(Image img, byte[] imgData)
        {
            this.guardian2.Image = img;
            this.guardianSign2 = imgData;
        }

        public byte[] getGuardianSign3()
        {
            if (this.guardian3.Image == null)
            {
                return null;
            }
            else
            {
                return this.guardianSign3;
            }
        }

        public void setGuardianSign3(Image img, byte[] imgData)
        {
            this.guardian3.Image = img;
            this.guardianSign3 = imgData;
        }

        public void btnGenerateCapitalEventHandler(EventHandler e)
        {
            this.btnShareGenerate.Click += e;
        }

        public void btnGenerateLoanEventHandler(EventHandler e)
        {
            this.btnLoanGenerate.Click += e;
        }

        public void btnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void initMemberType(DataSet ds)
        {
            this.comboMemberType.DisplayMember = "Description";
            this.comboMemberType.ValueMember = "MemberTypeNo";
            this.comboMemberType.DataSource = ds.Tables[0];
        }

        public void enableShareCapital()
        {
            this.btnShareGenerate.Enabled = true;
        }

        public bool checkShare() {

            return this.btnShareGenerate.Enabled;
        }

        public void enableLoan()
        {
            this.btnLoanGenerate.Enabled = true;
        }

        public bool checkLoan()
        {

            return this.btnLoanGenerate.Enabled;
        }

        public void disableGenerate(bool isNew)
        {
            this.btnLoanGenerate.Enabled = false;
            this.btnShareGenerate.Enabled = false;

            if (isNew)
            {
                this.txtLoanPassbook.Clear();
                this.txtSharePassbook.Clear();
            }
        }

       

        private void picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Choose Photo";
            openDialog.Filter = "Image Files (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                this.picture.Image = Image.FromFile(openDialog.FileName);
                String imgPath = openDialog.FileName;
                FileInfo fInfo = new FileInfo(imgPath);
                long numBytes = fInfo.Length;
                FileStream fStream = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                this.imgData = br.ReadBytes((int)numBytes);
            }
            openDialog.Dispose();
        }
        //page1

        public void errorMembershipDate() {
            lblDateMembership.ForeColor = Color.Red;
        
        }
        public void errorMemType()
        {
            lblMemType.ForeColor = Color.Red;
        }

        public void errorPicture() {

            lblPicture.Visible = true;
        
        }
        public void errorLastName()
        {
            lblLast.ForeColor = Color.Red;
            lblName.ForeColor = Color.Red;
        }

        public void errorFirstName()
        {
            lblFirst.ForeColor = Color.Red;
            lblName.ForeColor = Color.Red;
        }

        public void errorCity()
        {
            lblCity.ForeColor = Color.Red;
            lblAddress.ForeColor = Color.Red;
        }

        public void errorZip()
        {
            lblZip.ForeColor = Color.Red;
            lblAddress.ForeColor = Color.Red;
        }

        public void errorPdRes()
        {
            lblPdResi.ForeColor = Color.Red;
        }
        public void errorResType()
        {
            gpResType.ForeColor = Color.Red;
        }
        public void errorBDate()
        {
            lblBDate.ForeColor = Color.Red;
        }
        public void errorBPlace()
        {
            lblBPlace.ForeColor = Color.Red;
        }
        public void errorCivil()
        {
            lblCivil.ForeColor = Color.Red;
        }
        public void errorGender()
        {
            lblGender.ForeColor = Color.Red;
        }
        public void errorContact()
        {
            lblContact.ForeColor = Color.Red;
        }

        public void resetPage1Labels() {

            lblPicture.Visible = false;
            lblName.ForeColor = Color.Black;
            lblLast.ForeColor = Color.Black;
            lblFirst.ForeColor = Color.Black;
            lblCity.ForeColor = Color.Black;
            lblZip.ForeColor = Color.Black;
            lblPdResi.ForeColor = Color.Black;
            lblAddress.ForeColor = Color.Black;
            gpResType.ForeColor = Color.Black;
            lblContact.ForeColor = Color.Black;
            lblCivil.ForeColor = Color.Black;
            lblGender.ForeColor = Color.Black;
            lblBDate.ForeColor = Color.Black;
            lblBPlace.ForeColor = Color.Black;
        }

        //page2
        public void errorEduc()
        {
            gpEduc.ForeColor = Color.Red;
        }

        public void errorCourse()
        {
            lblCourse.ForeColor = Color.Red;
        }

        public void errorEmploymt()
        {
            gpEmploymt.ForeColor = Color.Red;
        }

        public void errorEmpYears()
        {
            lblEmpYears.ForeColor = Color.Red;
        }

        public void errorSEmpYears()
        {
            lblSEmpYears.ForeColor = Color.Red;
        }
        public void errorOccup()
        {
            lblOccup.ForeColor = Color.Red;
        }

        public void errorIncome()
        {
            lblIncome.ForeColor = Color.Red;
        }

        public void errorEmpName()
        {
            lblEmpName.ForeColor = Color.Red;
        }

        public void errorEmpAdd()
        {
            lblEmpAdd.ForeColor = Color.Red;
        }

        public void errorEmpContact()
        {
            lblEmpContact.ForeColor = Color.Red;
        }

        public void errorCoopName()
        {
            lblCoopName.ForeColor = Color.Red;
        }

        public void errorCoopAdd()
        {
            lblCoopAdd.ForeColor = Color.Red;
        }

        public void resetPage2Labels()
        {
            gpEduc.ForeColor = Color.Black;
            lblCourse.ForeColor = Color.Black;
            gpEmploymt.ForeColor = Color.Black;
            lblOccup.ForeColor = Color.Black;
            lblEmpYears.ForeColor = Color.Black;
            lblSEmpYears.ForeColor = Color.Black;
            lblIncome.ForeColor = Color.Black;
            lblEmpName.ForeColor = Color.Black;
            lblEmpAdd.ForeColor = Color.Black;
            lblEmpContact.ForeColor = Color.Black;
            lblCoopName.ForeColor = Color.Black;
            lblCoopAdd.ForeColor = Color.Black;
        }

        //page3
        

        public void errorAccts()
        {
            gpAccts.ForeColor = Color.Red;
        }

        public void errorGuardianName() 
        {
            lblGuardianName.ForeColor = Color.Red;
        }

        public void errorGuardianRelation() 
        {

            lblRelation.ForeColor = Color.Red;
        }

        public void resetPage3Labels() 
        {
            lblMemType.ForeColor = Color.Black;
            lblGuardianName.ForeColor = Color.Black;
            lblRelation.ForeColor = Color.Black;
            gpAccts.ForeColor = Color.Black;
        
        }

        //page4
        public void errorAcctSign()
        {
            lblAcctHolderSign.ForeColor = Color.Red;
        }

        public void errorGuardianSign()
        {
            lblGuardianSign.ForeColor = Color.Red;
        }

        public void resetPage4Labels() {

            lblAcctHolderSign.ForeColor = Color.Red;
            lblGuardianSign.ForeColor = Color.Red;
        
        }

        public void setPage1NextEventHandler(EventHandler e)
        {
            this.button1.Click += e;
        }

        public void setPage2NextEventHandler(EventHandler e)
        {
            this.button2.Click += e;
        }

        public void setPage2PrevEventHandler(EventHandler e)
        {
            this.button3.Click += e;
        }

        public void setPage3NextEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void setPage3PrevEventHandler(EventHandler e)
        {
            this.button4.Click += e;
        }

       public void page1Next()
        {
            tabApplication.SelectedTab = tabEduEmp;
        }

        public void page2Prev()
        {
            tabApplication.SelectedTab = tabPersonInfo;
        }

        public void page2Next()
        {
            tabApplication.SelectedTab = tabMembership;

        }

        public void page3Prev()
        {
            tabApplication.SelectedTab = tabEduEmp;
        }

        public void page4Prev()
        {
            tabApplication.SelectedTab = tabMembership;
        }

       private void acctholder1_Click(object sender, EventArgs e)
        {
            CaptureSignature cSignAcct1 = new CaptureSignature(this, this.acctholder1, this.acctHolderSign1);
        }

        private void acctholder2_Click(object sender, EventArgs e)
        {
            CaptureSignature cSignAcct2 = new CaptureSignature(this, this.acctholder2, this.acctHolderSign2);

        }

        private void acctholder3_Click(object sender, EventArgs e)
        {
            CaptureSignature cSignAcct3 = new CaptureSignature(this, this.acctholder3, this.acctHolderSign3);

        }

        private void guardian1_Click(object sender, EventArgs e)
        {
            CaptureSignature cSignGuardian1 = new CaptureSignature(this, this.guardian1, this.guardianSign1);

        }

        private void guardian2_Click(object sender, EventArgs e)
        {
            CaptureSignature cSignGuardian2 = new CaptureSignature(this, this.guardian1, this.guardianSign2);

        }

        private void guardian3_Click(object sender, EventArgs e)
        {
            CaptureSignature cSignGuardian3 = new CaptureSignature(this, this.guardian1, this.guardianSign3);
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCellphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtAddressZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public void enableMinorFeatures() {

            lblGuardianName.ForeColor = Color.Black;
            lblRelation.ForeColor = Color.Black;
            lblGuardianName.Visible = true;
            lblRelation.Visible = true;
            txtGuardianName.Visible = true;
            cbGuardianRelation.Visible = true;

            lblGuardianSign.ForeColor = Color.Black;
            lblAcctHolderSign.Visible = false;
            acctholder1.Visible = false;
            acctholder1.Image = null;
            acctholder2.Visible = false;
            acctholder2.Image = null;
            acctholder3.Visible = false;
            acctholder3.Image = null;

            lblGuardianSign.Visible = true;
            guardian1.Visible = true;
            guardian2.Visible = true;
            guardian3.Visible = true;
        
        }

        public void disableMinorFeatures() {

            lblGuardianName.Visible = false;
            lblRelation.Visible = false;
            txtGuardianName.Visible = false;
            txtGuardianName.Text = String.Empty;
            cbGuardianRelation.Visible = false;
            cbGuardianRelation.SelectedIndex = -1;

            lblAcctHolderSign.ForeColor = Color.Black;
            lblAcctHolderSign.Visible = true;
            acctholder1.Visible = true;
            acctholder2.Visible = true;
            acctholder3.Visible = true;

            lblGuardianSign.Visible = false;
            guardian1.Visible = false;
            guardian1.Image = null;
            guardian2.Visible = false;
            guardian2.Image = null; 
            guardian3.Visible = false;
            guardian3.Image = null;
        
        }

        public bool checkMinor() {

            return txtGuardianName.Visible;
        }

        public void counterLimitToAge(int age) {

            if (age > 0)
            {
                numEmployedYears.Maximum = age;
                numSelfEmployedYears.Maximum = age;
                numYear.Maximum = age;
            }
        
        }

       public void setDateBirthEventHandler(EventHandler e)
        {
            dateBirth.ValueChanged += e;
        }

       public void loadMemberTypes(EventHandler e) {
           comboMemberType.DropDown += e;
       }

       

        private void numYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void numMonths_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void numChildren_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtGross_KeyPress(object sender, KeyPressEventArgs e)
        {
            int length = this.txtGross.Text.Length;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\b' && txtGross.SelectionStart == this.txtGross.Text.Length - 2)
            {
                this.txtGross.SelectionStart = this.txtGross.Text.Length - 3;
            }

            //if (e.KeyChar == '\b' && length % 4 == 0) 
            //{
            //  MessageBox.Show("hi");
            //this.txtMaxWith.SelectionStart = this.txtMaxWith.Text.Length-2;
            //} 

            if (Char.IsDigit(e.KeyChar) && txtGross.Text.Length == 4)
            {
                this.txtGross.SelectionStart = this.txtGross.Text.Length - 3;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                this.txtGross.Text = this.getGross().ToString();
                this.txtGross.SelectionStart = this.txtGross.Text.Length - 2;
            }
           
        }

        private void txtGross_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split('.');
                if (parts.Length > 1 || tb.TextLength > 5)
                {
                    try
                    {

                            if (parts[0].Length > 6 || parts[1].Length > 2 || parts.Length > 2)
                            {
                                e.Handled = true;
                            }

                    }
                    catch (Exception) { tb.Text = "0"; }
                }
            }

        }

        private void txtExpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split('.');
                if (parts.Length > 1 || tb.TextLength > 5)
                {
                    try
                    {
                        if (parts[0].Length > 6 || parts[1].Length > 2 || parts.Length > 2)
                        {
                            e.Handled = true;
                        }
                    }
                    catch (Exception) { tb.Text = "0"; }
                }
            }

        }

        private void txtGross_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtGross.SelectionStart;
            this.txtGross.Text = this.getGross().ToString("N2", CultureInfo.InvariantCulture);
            if (selectionStart == txtGross.Text.Length - 2)
            {
                this.txtGross.SelectionStart = txtGross.Text.Length - 2;
            }
            else if (selectionStart == txtGross.Text.Length - 1)
            {
                this.txtGross.SelectionStart = txtGross.Text.Length - 1;
            }
            else this.txtGross.SelectionStart = txtGross.Text.Length - 3;
        }
    }
}
