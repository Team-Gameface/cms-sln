using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CMS.Utilities.Model
{
    class TimeDepositCalculatorModel
    {
        public double getInterest(int TimeElapsed, double Principal)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT InterestRate FROM TIME_DEPOSIT_INTEREST WHERE Status = 1 AND NoDays <= @TimeElapsed AND (@Principal >= MinimumRange AND @Principal <= MaximumRange)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TimeElapsed", TimeElapsed);
            parameters.Add("@Principal", Principal);
            SqlDataReader read = dal.executeReader(sql, parameters);
            double d = 0;
            while (read.Read())
            {
                d = double.Parse(read[0].ToString());
            }
            return d;
        }

        public int getDaysElapsed(int TimeElapsed, double Principal)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT NoDays FROM TIME_DEPOSIT_INTEREST WHERE Status = 1 AND NoDays <= @TimeElapsed AND (@Principal >= MinimumRange AND @Principal <= MaximumRange)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TimeElapsed", TimeElapsed);
            parameters.Add("@Principal", Principal);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            return i;
        }
    }
}
