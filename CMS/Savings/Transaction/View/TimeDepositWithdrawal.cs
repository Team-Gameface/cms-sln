using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.View
{
    public partial class TimeDepositWithdrawal : Form
    {
        public TimeDepositWithdrawal()
        {
            InitializeComponent();
            this.radioAccountNo.Checked = true;
        }

        private void radioAccountNo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioAccountNo.Checked)
            {
                this.txtAccountNo.Clear();
                this.txtMemberName.Clear();
                this.txtCertificateNo.Clear();
                this.txtAccountNo.Enabled = true;
                this.txtMemberName.Enabled = false;
                this.txtCertificateNo.Enabled = false;
            }
        }

        private void radioMemberName_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioMemberName.Checked)
            {
                this.txtAccountNo.Clear();
                this.txtMemberName.Clear();
                this.txtCertificateNo.Clear();
                this.txtAccountNo.Enabled = false;
                this.txtMemberName.Enabled = true;
                this.txtCertificateNo.Enabled = false;
            }
        }

        private void radioCertificateNo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioCertificateNo.Checked)
            {
                this.txtAccountNo.Clear();
                this.txtMemberName.Clear();
                this.txtCertificateNo.Clear();
                this.txtAccountNo.Enabled = false;
                this.txtMemberName.Enabled = false;
                this.txtCertificateNo.Enabled = true;
            }
        }

        public void setDataTimeDeposit(DataSet ds)
        {
            this.dataTimeDeposit.DataSource = ds.Tables[0];
            this.dataTimeDeposit.Columns[3].Visible = false;
        }

        public DataGridViewRow getSelected()
        {
            try
            {
                return this.dataTimeDeposit.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        public void setDate(String s)
        {
            this.txtDate.Text = s;
        }

        public void setDepositAmount(String s)
        {
            double amount = 0;
            try
            {
                amount = double.Parse(s);
            }
            catch (Exception) { }
            CultureInfo ph = new CultureInfo("en-PH");
            this.txtDeposit.Text = amount.ToString("c", ph);
            this.txtDepAmt.Text = amount.ToString("c", ph);
        }

        public double getDepositAmount()
        {
            return double.Parse(this.txtDeposit.Text.ToString());
        }

        public void setInterest(String s)
        {
            double amount = 0;
            try
            {
                amount = double.Parse(s);
            }
            catch (Exception) { }
            CultureInfo ph = new CultureInfo("en-PH");
            this.txtInterest.Text = amount.ToString("c", ph);
        }

        public double getInterest(String s)
        {
            return double.Parse(this.txtInterest.Text);
        }


        public void setGross(String s)
        {
            double amount = 0;
            try
            {
                amount = double.Parse(s);
            }
            catch (Exception) { }
            CultureInfo ph = new CultureInfo("en-PH");
            this.txtGross.Text = amount.ToString("c", ph);
        }

        public double getGross()
        {
            return double.Parse(this.txtGross.Text.ToString());
        }

        public void setPenalty(String s)
        {
            double amount = 0;
            try
            {
                amount = double.Parse(s);
            }
            catch (Exception) { }
            CultureInfo ph = new CultureInfo("en-PH");
            this.txtPenalty.Text = amount.ToString("c", ph);
        }

        public double getPenalty()
        {
            return double.Parse(this.txtPenalty.Text.ToString());
        }

        public void setTotal(String s)
        {
            double amount = 0;
            try
            {
                amount = double.Parse(s);
            }
            catch (Exception) { }
            CultureInfo ph = new CultureInfo("en-PH");
            this.txtTotal.Text = amount.ToString("c", ph);
        }

        public double getTotal()
        {
            return double.Parse(this.txtTotal.Text.ToString());
        }

        public void setMaturity(String s)
        {
            this.txtMaturityDate.Text = s;
        }

        public String getMaturity()
        {
            return this.txtMaturityDate.Text;
        }

        public void setStatus(String s)
        {
            this.lblMaturityStatus.Text = s;
        }

        public void dataTimeDeposit_CellContentClick(DataGridViewCellEventHandler e)
        {
            this.dataTimeDeposit.CellClick += e;
        }

        public String getAccountNo()
        {
            return this.txtAccountNo.Text;
        }

        public String getMemberName()
        {
            return this.txtMemberName.Text;
        }

        public String getCertificateNo()
        {
            return this.txtCertificateNo.Text;
        }

        public void setBtnClearEventHandler(EventHandler e)
        {
            this.btnClear.Click += e;
        }

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void txtAccountNo_TextChanged(EventHandler e)
        {
            this.txtAccountNo.TextChanged += e;
        }

        public void txtMemberName_TextChanged(EventHandler e)
        {
            this.txtMemberName.TextChanged += e;
        }

        public void txtCertificateNo_TextChanged(EventHandler e)
        {
            this.txtCertificateNo.TextChanged += e;
        }

        public void reset()
        {
            this.radioAccountNo.Checked = true;
            this.txtAccountNo.Clear();
            this.txtMemberName.Clear();
            this.txtCertificateNo.Clear();
            this.txtAccountNo.Enabled = true;
            this.txtMemberName.Enabled = false;
            this.txtCertificateNo.Enabled = false;
            this.txtDepAmt.Clear();
            this.txtDeposit.Clear();
            this.txtMaturityDate.Clear();
            this.lblMaturityStatus.Text = " ";
            this.txtInterest.Clear();
            this.txtGross.Clear();
            this.txtPenalty.Clear();
            this.txtTotal.Clear();
        }
    }
}
