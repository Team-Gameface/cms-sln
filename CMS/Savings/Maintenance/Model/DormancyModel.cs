using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace CMS.Savings.Maintenance.Model
{
    class DormancyModel
    {
        public int TypeId { get; set; }
        public double Penalty { get; set; }
        public String PenaltyStatus { get; set; }
        public int Dormancy { get; set; }
        public String DormancyStatus { get; set; }
        public int Charge { get; set; }
        public String ChargeStatus { get; set; }
        public int Status { get; set; }

        public DormancyModel()
        {
            this.TypeId = 0;
            this.Penalty = 0;
            this.PenaltyStatus = String.Empty;
            this.Dormancy = 0;
            this.DormancyStatus = String.Empty;
            this.Charge = 0;
            this.ChargeStatus = String.Empty;
        }

        public void clearAll()
        {
            this.TypeId = 0;
            this.Penalty = 0;
            this.PenaltyStatus = String.Empty;
            this.Dormancy = 0;
            this.DormancyStatus = String.Empty;
            this.Charge = 0;
            this.ChargeStatus = String.Empty;
        }
    }
}
