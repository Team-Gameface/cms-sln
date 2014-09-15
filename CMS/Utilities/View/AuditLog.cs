using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Utilities.View
{
    public partial class AuditLog : UserControl
    {
        public AuditLog()
        {
            InitializeComponent();
            this.comboType.SelectedIndex = 0;
        }

        public void setData(DataSet ds)
        {
            this.dataLogs.DataSource = ds.Tables[0];
        }

        public void enableDate()
        {
            dateFrom.Enabled = true;
            dateTo.Enabled = true;
        }

        public void disableDate()
        {
            dateFrom.Enabled = false;
            dateTo.Enabled = false;
        }

        public void setCheckDateStateChanged(EventHandler e)
        {
            this.checkDate.CheckStateChanged += e;
        }

        public bool getCheckDateState()
        {
            if (checkDate.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String getFrom()
        {
            return dateFrom.Value.ToString();
        }

        public String getTo()
        {
            return dateTo.Value.ToString();
        }

        public String getUser()
        {
            return this.txtUser.Text;
        }

        public String getType()
        {
            if (this.comboType.SelectedIndex == 0)
            {
                return "All";
            }
            if (this.comboType.SelectedIndex == 1)
            {
                return "Staff";
            }
            else if (this.comboType.SelectedIndex == 2)
            {
                return "Manager";
            }
            else if (this.comboType.SelectedIndex == 3)
            {
                return "Chairman - Credit Committee";
            }
            else if (this.comboType.SelectedIndex == 4)
            {
                return "Chairman - Audit Committee";
            }
            else
            {
                return String.Empty;
            }
        }

        public void setUserTextChanged(EventHandler e)
        {
            this.txtUser.TextChanged += e;
        }

        public void setComboTypeIndexChanged(EventHandler e)
        {
            this.comboType.SelectedIndexChanged += e;
        }

        public void setDateFromValueChanged(EventHandler e)
        {
            this.dateFrom.ValueChanged += e;
        }

        public void setDateToValueChanged(EventHandler e)
        {
            this.dateTo.ValueChanged += e;
        }
    }
}
