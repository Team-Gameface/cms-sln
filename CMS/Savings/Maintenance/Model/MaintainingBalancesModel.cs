using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace CMS.Savings.Maintenance.Model
{
    class MaintainingBalancesModel
    {
        public int AccountTypeId { get; set; }
        public double MaintainingBalance { get; set; }
        public double ServiceCharge { get; set; }
        public String ServiceChargeStatus { get; set; }
        public double ServiceChargeDuration { get; set; }
        public String ServiceChargeDurationStatus { get; set; }

        public MaintainingBalancesModel()
        {
            this.AccountTypeId = 0;
            this.MaintainingBalance = 0;
            this.ServiceCharge = 0;
            this.ServiceChargeStatus = String.Empty;
            this.ServiceChargeDuration = 0;
            this.ServiceChargeDurationStatus = String.Empty;
        }

        public void clearAll()
        {
            this.AccountTypeId = 0;
            this.MaintainingBalance = 0;
            this.ServiceCharge = 0;
            this.ServiceChargeStatus = String.Empty;
            this.ServiceChargeDuration = 0;
            this.ServiceChargeDurationStatus = String.Empty;
        }
    }
}
