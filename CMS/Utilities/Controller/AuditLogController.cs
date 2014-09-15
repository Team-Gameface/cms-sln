using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS.Utilities.Controller
{
    class AuditLogController
    {
        View.AuditLog auditLog;
        Model.AuditLogModel auditModel;
        Main.View.Utilities utilities;

        public AuditLogController(View.AuditLog auditLog, Model.AuditLogModel auditModel, Main.View.Utilities utilities)
        {
            this.auditLog = auditLog;
            this.auditModel = auditModel;
            this.utilities = utilities;
            this.utilities.setUtilities(this.auditLog);
            this.auditLog.setData(this.auditModel.selectAuditLog());
            this.auditLog.setUserTextChanged(this.txtUser);
            this.auditLog.setComboTypeIndexChanged(this.comboType);
            this.auditLog.setCheckDateStateChanged(this.checkDate);
            this.auditLog.setDateFromValueChanged(this.dateFrom);
            this.auditLog.setDateToValueChanged(this.dateTo);
            this.auditLog.disableDate();
        }

        public void txtUser(object sender, EventArgs e)
        {
            if (auditLog.getType() != String.Empty)
            {
                if (auditLog.getType() == "All")
                {
                    if (auditLog.getCheckDateState())
                    {
                        this.auditLog.setData(this.auditModel.selectAuditLogDate(this.auditLog.getUser(), this.auditLog.getFrom(), this.auditLog.getTo()));
                    }
                    else
                    {
                        this.auditLog.setData(this.auditModel.selectAuditLog(this.auditLog.getUser()));
                    }
                }
                else
                {
                    if (auditLog.getCheckDateState())
                    {
                        this.auditLog.setData(this.auditModel.selectAuditLogTypeDate(this.auditLog.getUser(), this.auditLog.getType(), this.auditLog.getFrom(), this.auditLog.getTo()));
                    }
                    else
                    {
                        this.auditLog.setData(this.auditModel.selectAuditLogType(this.auditLog.getUser(), this.auditLog.getType()));
                    }
                }
            }
        }

        public void comboType(object sender, EventArgs e)
        {
            if (auditLog.getType() != String.Empty)
            {
                if (auditLog.getType() == "All")
                {
                    if (auditLog.getCheckDateState())
                    {
                        this.auditLog.setData(this.auditModel.selectAuditLogDate(this.auditLog.getUser(), this.auditLog.getFrom(), this.auditLog.getTo()));
                    }
                    else
                    {
                        this.auditLog.setData(this.auditModel.selectAuditLog(this.auditLog.getUser()));
                    }
                }
                else
                {
                    if (auditLog.getCheckDateState())
                    {
                        this.auditLog.setData(this.auditModel.selectAuditLogTypeDate(this.auditLog.getUser(), this.auditLog.getType(), this.auditLog.getFrom(), this.auditLog.getTo()));
                    }
                    else
                    {
                        this.auditLog.setData(this.auditModel.selectAuditLogType(this.auditLog.getUser(), this.auditLog.getType()));
                    }
                }
            }
        }

        public void checkDate(object sender, EventArgs e)
        {
            if (auditLog.getCheckDateState())
            {
                this.auditLog.enableDate();
            }
            else
            {
                this.auditLog.disableDate();
            }
        }

        public void dateFrom(object sender, EventArgs e)
        {
            if (auditLog.getType() != String.Empty)
            {
                if (auditLog.getType() == "All")
                {
                    this.auditLog.setData(this.auditModel.selectAuditLogDate(this.auditLog.getUser(), this.auditLog.getFrom(), this.auditLog.getTo()));
                }
                else
                {
                    this.auditLog.setData(this.auditModel.selectAuditLogTypeDate(this.auditLog.getUser(), this.auditLog.getType(), this.auditLog.getFrom(), this.auditLog.getTo()));
                }
            }
        }

        public void dateTo(object sender, EventArgs e)
        {
            if (auditLog.getType() != String.Empty)
            {
                if (auditLog.getType() == "All")
                {
                    this.auditLog.setData(this.auditModel.selectAuditLogDate(this.auditLog.getUser(), this.auditLog.getFrom(), this.auditLog.getTo()));
                }
                else
                {
                    this.auditLog.setData(this.auditModel.selectAuditLogTypeDate(this.auditLog.getUser(), this.auditLog.getType(), this.auditLog.getFrom(), this.auditLog.getTo()));
                }
            }
        }
    }
}
