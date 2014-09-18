using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CMS.Savings.Queries.View
{
    public partial class StatementOfAccount : Form
    {
        public StatementOfAccount()
        {
            InitializeComponent();
            txtAccountNo.Enabled = false;
            txtMemberName.Enabled = false;
        }

        public void setDataMember(DataSet ds)
        {
            this.dataMember.DataSource = ds.Tables[0];
            dataMember.Columns[1].Visible = false;
            dataMember.Columns[3].Visible = false;
            this.dataMember.Columns["Balance"].DefaultCellStyle.Format = "c";
            CultureInfo ph = new CultureInfo("en-PH");
            this.dataMember.Columns["Balance"].DefaultCellStyle.FormatProvider = ph;
        }

        public void setDataTransactions(DataSet ds)
        {
            this.dataTransactions.DataSource = ds.Tables[0];
            this.dataTransactions.Columns["Amount"].DefaultCellStyle.Format = "c";
            this.dataTransactions.Columns["Balance"].DefaultCellStyle.Format = "c";
            CultureInfo ph = new CultureInfo("en-PH");
            this.dataTransactions.Columns["Amount"].DefaultCellStyle.FormatProvider = ph;
            this.dataTransactions.Columns["Balance"].DefaultCellStyle.FormatProvider = ph;
        }

        public void dataMember_CellContentClick(DataGridViewCellEventHandler e)
        {
            this.dataMember.CellClick += e;
        }

        public void setTxtAccountNoEventHandler(EventHandler e)
        {
            this.txtAccountNo.TextChanged += e;
        }

        public void setTxtmemberNameEventHandler(EventHandler e)
        {
            this.txtMemberName.TextChanged += e;
        }

        public DataGridViewRow getSelectedMember()
        {
            try
            {
                return this.dataMember.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        public String getSearchMember()
        {
            try
            {
                return txtMemberName.Text;
            }
            catch (Exception) { return String.Empty; }
        }

        public String getSearchAccount()
        {
            try
            {
                return txtAccountNo.Text;
            }
            catch (Exception) { return String.Empty; }
        }

        private void rbAccountNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAccountNo.Checked)
                txtAccountNo.Enabled = true;
            else
            {
                txtAccountNo.Clear();
                txtAccountNo.Enabled = false;
            }
        }

        private void rbMemberName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMemberName.Checked)
                txtMemberName.Enabled = true;
            else
            {
                txtMemberName.Clear();
                txtMemberName.Enabled = false;
            }
        }

        public void setAccountNo(String s)
        {
            lblAccountNo.Text = s;        
        }

        public void setAccountType(String s)
        {
            lblAcctType.Text = s;
        }

        public void setBalance(String s)
        {
            double amount = 0;
            try
            {
                amount = double.Parse(s);
            }
            catch (Exception) { }
            CultureInfo ph = new CultureInfo("en-PH");
            lblBalance.Text = amount.ToString("c", ph);
        }

        public void setAccountHolders(String s)
        {
            lblAccountHolders.Text = s;
        }
    }
}
