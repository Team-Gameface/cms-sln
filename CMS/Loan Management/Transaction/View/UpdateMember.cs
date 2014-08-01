using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Transaction.View
{
    public partial class UpdateMember : Form
    {
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void radioAccountNo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioAccountNo.Checked)
            {
                txtAccountNo.Enabled = true;
            }
            else
            {
                txtAccountNo.Enabled = false;
                txtAccountNo.Clear();
            }
        }

        private void radioMemberName_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioMemberName.Checked)
            {
                txtMemberName.Enabled = true;
            }
            else
            {
                txtMemberName.Enabled = false;
                txtMemberName.Clear();
            }
        }

        public String getAccountNo()
        {
            return this.txtAccountNo.Text.ToString();
        }

        public String getMemberName()
        {
            return this.txtMemberName.Text.ToString();
        }

        public void setDataMembers(DataSet ds)
        {
            this.dataMember.DataSource = ds.Tables[0];
        }

        public DataGridViewRow getSelected()
        {

            return this.dataMember.SelectedRows[0];
        }

        public int searchBy()
        {
            if (radioAccountNo.Checked)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        
        public void setTxtAccountNoEventHandler(EventHandler e) {

            this.txtAccountNo.TextChanged += e;
        }

        public void setTxtMemberNameEventHandler(EventHandler e)
        {
            this.txtMemberName.TextChanged += e;
        }

        public void setBtnUpdateEventHandler(EventHandler e)
        {
            this.btnUpdate.Click += e;
        }

        public void setBtnAddEventHandler(EventHandler e) {

            this.btnAdd.Click += e;

        }
    }
}
