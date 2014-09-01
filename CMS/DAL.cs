using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMS
{
    class DAL
    {
        /**
         * This class is used for all data access.
         * This class includes methods to execute sql statements
         * that does not return any values (INSERT, UPDATE),
         * and also to execute sql statements that return values
         * (SELECT, VIEW)
         * */
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        Object returnValue;
        SqlDataAdapter adapter;
        DataSet ds;

        /**
         * This constructor accepts a string parameter, which is the connection string to the database 
         * Upon construction of this class, the connection to the database is opened.
         * */
        
        public DAL(String connection)
        {
            try
            {
                conn = new SqlConnection(connection);
                conn.Open();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }//constructor

       

        /**
         *This method is used for executing sql statements
         * with conditions
         * e.g. INSERT INTO Table VALUES (@Value1, @Value2)
         */

        public int executeNonQuery(String sql, Dictionary<String, Object> parameters)
        {
            int rowsAffected = 0;
            try
            {
                cmd = new SqlCommand(sql, conn);
                foreach (KeyValuePair<String, Object> row in parameters)
                {
                    cmd.Parameters.AddWithValue(row.Key, row.Value);
                }
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return rowsAffected;
        }

        public int executeNonQuery(String sql)
        {
            int rowsAffected = 0;
            try
            {
                cmd = new SqlCommand(sql, conn);
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return rowsAffected;
        }

        /**
         * This method is used for executing select statements
         * and using SQLDataReader to read the data return.
         * Use this method only for select statements without conditions
         * e.g. SELECT * FROM Employees
         */

        public SqlDataReader executeReader(String sql)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return reader;
        }

        /**
       * This method is used for executing select statements
       * and using SQLDataReader to read the data return.
       * Use this method only for select statements with conditions
       * e.g. SELECT * FROM Employees WHERE EmployeeNumber = 'fdjlad'
       */

        public SqlDataReader executeReader(String sql, Dictionary<String, Object> parameters)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                foreach (KeyValuePair<String, Object> row in parameters)
                {
                    cmd.Parameters.AddWithValue(row.Key, row.Value);
                }
                reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return reader;
        }

     /**
      * This method is used for executing select statements
      * and using DataSet to read the data returned.
      * Use this method only for select statements without conditions
      * e.g. SELECT * FROM Employees
      */
        public DataSet executeDataSet(String sql)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                ds = new DataSet();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception e)
            {
               MessageBox.Show(e.Message);
            }
            return ds;
        }

        public object executeScalar(String sql)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                returnValue = cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return returnValue;
        }

        public object executeScalar(String sql, Dictionary<String, Object> parameters)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                foreach (KeyValuePair<String, Object> row in parameters)
                {
                    cmd.Parameters.AddWithValue(row.Key, row.Value);
                }
                returnValue = cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return returnValue;
        }
     
     /**
     * This method is used for executing select statements
     * and using DataSet to read the data returned.
     * Use this method only for select statements with conditions
     * e.g. SELECT * FROM Employees WHERE EmployeeNumber = 'fdjsa';
     */
        public DataSet executeDataSet(String sql, Dictionary<String, Object> parameters)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                foreach (KeyValuePair<String, Object> row in parameters)
                {
                    cmd.Parameters.AddWithValue(row.Key, row.Value);
                }
                ds = new DataSet();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }
        
        /**
         * The destructor closes the connection
         * upon garbage collection  
         * 
         */
        ~DAL()
        {
            try
            {

            }
            catch (Exception e)
            {
                
                MessageBox.Show(e.Message);
            }
        }//destructor

    }
}
