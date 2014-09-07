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
    class InterestRatesModel
    {
        public int TypeId { get; set; }
        public double InterestRate { get; set; }
        public String Per { get; set; }
        public double MinRange { get; set; }
        public int Status { get; set; }

        public InterestRatesModel()
        {
            this.TypeId = 0;
            this.InterestRate = 0;
            this.Per = String.Empty;
            this.MinRange = 0;
            this.Status = 0;
        }
    }
}
