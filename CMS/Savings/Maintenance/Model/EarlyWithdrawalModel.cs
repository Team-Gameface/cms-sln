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
    class EarlyWithdrawalModel
    {
        public double InterestReduction { get; set; }
        public int TermElapsedFrom { get; set; }
        public int TermElapsedTo { get; set; }
        public int Status { get; set; }

        public EarlyWithdrawalModel()
        {
            this.InterestReduction = 0;
            this.TermElapsedFrom = 0;
            this.TermElapsedTo = 0;
            this.Status = 0;
        }

        public DataSet selectEarlyWithdrawal()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT EarlyWithdrawalId, CONCAT(TermsElapsedFrom, '%') AS 'Term Elapsed From', CONCAT(TermsElapsedTo, '%') AS 'Term Elapsed To', CONCAT(InterestReduction, '%') AS 'Interest Reduction', Status, DateCreated, DateModified FROM EARLY_WITHDRAWAL";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchEarlyWithdrawal(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT EarlyWithdrawalId, CONCAT(TermsElapsedFrom, '%') AS 'Term Elapsed From', CONCAT(TermsElapsedTo, '%') AS 'Term Elapsed To', CONCAT(InterestReduction, '%') AS 'Interest Reduction', Status, DateCreated, DateModified FROM EARLY_WITHDRAWAL WHERE InterestReduction LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertEarlyWithdrawal()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertEarlyWithdrawal @InterestReduction, @TermElapsedFrom, @TermElapsedTo, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@InterestReduction", this.InterestReduction);
            parameters.Add("@TermElapsedFrom", this.TermElapsedFrom);
            parameters.Add("@TermElapsedTo", this.TermElapsedTo);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int updateEarlyWithdrawal(int EarlyWithdrawalId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateEarlyWithdrawal @InterestReduction, @TermElapsedFrom, @TermElapsedTo, @Status, @EarlyWithdrawalId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@InterestReduction", this.InterestReduction);
            parameters.Add("@TermElapsedFrom", this.TermElapsedFrom);
            parameters.Add("@TermElapsedTo", this.TermElapsedTo);
            parameters.Add("@Status", this.Status);
            parameters.Add("@EarlyWithdrawalId", EarlyWithdrawalId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int checkOverlap(int From, int To)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM EARLY_WITHDRAWAL WHERE Status = 1 AND ((@From BETWEEN TermsElapsedFrom AND TermsElapsedTo) OR (@To BETWEEN TermsElapsedFrom AND TermsElapsedTo) OR (TermsElapsedFrom >= @From AND TermsElapsedTo <= @To))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@From", From);
            parameters.Add("@To", To);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkOverlap(int From, int To, int Id)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM EARLY_WITHDRAWAL WHERE EarlyWithdrawalId != @Id AND Status = 1 AND ((@From BETWEEN TermsElapsedFrom AND TermsElapsedTo) OR (@To BETWEEN TermsElapsedFrom AND TermsElapsedTo) OR (TermsElapsedFrom >= @From AND TermsElapsedTo <= @To))";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@From", From);
            parameters.Add("@To", To);
            parameters.Add("@Id", Id);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkReduction(double Reduction)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM EARLY_WITHDRAWAL WHERE InterestReduction = @Reduction AND Status = 1";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Reduction", Reduction);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public int checkReduction(double Reduction, int Id)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM EARLY_WITHDRAWAL WHERE EarlyWithdrawalId != @Id AND InterestReduction = @Reduction AND Status = 1";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Reduction", Reduction);
            parameters.Add("@Id", Id);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }
    }
}
