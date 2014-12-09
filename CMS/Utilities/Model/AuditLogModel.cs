using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace CMS.Utilities.Model
{
    class AuditLogModel
    {
        public AuditLogModel()
        {

        }

        public DataSet selectAuditLog()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LogTime AS 'Log Time', Activity, Module, CONCAT(s.LastName, ', ', s.FirstName, ' (', a.UserId , ')') AS ' User' FROM AUDIT_LOG a INNER JOIN SYSTEM_USERS s ON a.UserId = s.UserId";
            DataSet ds = dal.executeDataSet(sql);
            dal.Close();
            return ds;
        }

        public DataSet selectAuditLog(String user)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LogTime AS 'Log Time', Activity, Module, CONCAT(s.LastName, ', ', s.FirstName, ' (', a.UserId , ')') AS ' User' FROM AUDIT_LOG a INNER JOIN SYSTEM_USERS s ON a.UserId = s.UserId WHERE (s.FirstName LIKE (@Name) OR s.LastName LIKE(@Name) OR s.UserId LIKE(@Name))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            user = "%" + user + "%";
            parameters.Add("@Name", user);
            DataSet ds = dal.executeDataSet(sql, parameters);
            dal.Close();
            return ds;
        }

        public DataSet selectAuditLogDate(String user, String from, String to)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LogTime AS 'Log Time', Activity, Module, CONCAT(s.LastName, ', ', s.FirstName, ' (', a.UserId , ')') AS ' User' FROM AUDIT_LOG a INNER JOIN SYSTEM_USERS s ON a.UserId = s.UserId WHERE (s.FirstName LIKE (@Name) OR s.LastName LIKE(@Name) OR s.UserId LIKE(@Name)) AND LogTime >= @from AND LogTime <= @to";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            user = "%" + user + "%";
            parameters.Add("@Name", user);
            parameters.Add("@from", from);
            parameters.Add("@to", to);
            DataSet ds = dal.executeDataSet(sql, parameters);
            dal.Close();
            return ds;
        }

        public DataSet selectAuditLogType(String user, String type)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LogTime AS 'Log Time', Activity, Module, CONCAT(s.LastName, ', ', s.FirstName, ' (', a.UserId , ')') AS ' User' FROM AUDIT_LOG a INNER JOIN SYSTEM_USERS s ON a.UserId = s.UserId WHERE s.UserType = @Type AND (s.FirstName LIKE (@Name) OR s.LastName LIKE(@Name) OR s.UserId LIKE(@Name))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            user = "%" + user + "%";
            parameters.Add("@Name", user);
            parameters.Add("@Type", type);
            DataSet ds = dal.executeDataSet(sql, parameters);
            dal.Close();
            return ds;
        }

        public DataSet selectAuditLogTypeDate(String user, String type, String from, String to)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LogTime AS 'Log Time', Activity, Module, CONCAT(s.LastName, ', ', s.FirstName, ' (', a.UserId , ')') AS ' User' FROM AUDIT_LOG a INNER JOIN SYSTEM_USERS s ON a.UserId = s.UserId WHERE s.UserType = @Type AND (s.FirstName LIKE (@Name) OR s.LastName LIKE(@Name) OR s.UserId LIKE(@Name)) AND LogTime >= @from AND LogTime <= @to";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            user = "%" + user + "%";
            parameters.Add("@Name", user);
            parameters.Add("@Type", type);
            parameters.Add("@from", from);
            parameters.Add("@to", to);
            DataSet ds = dal.executeDataSet(sql, parameters);
            dal.Close();
            return ds;
        }
    }
}
