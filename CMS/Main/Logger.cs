using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CMS.Main
{
    class Logger
    {
        public String Activity { get; set; }
        public String Module { get; set; }

        public Logger()
        {
            this.Activity = String.Empty;
            this.Module = String.Empty;
        }

        public int insertLog()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertAuditLog @Activity, @Module, @UserId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Activity", this.Activity);
            parameters.Add("@Module", this.Module);
            parameters.Add("@UserId", Main.UserData.userId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}
