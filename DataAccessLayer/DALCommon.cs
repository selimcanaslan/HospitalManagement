using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALCommon : DbConnect
    {
        public DALCommon()
        {
            DbConnect dbConnect = new DbConnect();
        }

        public object Command(string query)
        {
            exception = null;
            object obj = null;
            com.Connection = con;
            com.CommandText = query;

            try
            {
                obj = com.ExecuteScalar();
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.GetType().Name + " - " + ex.Message);
            }
            return obj;
        }

        public DataTable Table(string query)
        {
            DataTable dt = new DataTable();
            com.Connection = con;
            com.CommandText = query;
            da.SelectCommand = com;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.GetType().Name + " - " + ex.Message);
            }
            return dt;
        }

        public SqlDataReader Sdr(string query)
        {
            com.Connection = con;
            com.CommandText = query;
            SqlDataReader dr = com.ExecuteReader();
            dr.Close();
            return dr;
        }

        public bool TryLogin(string username, string password)
        {
            String query = "SELECT * FROM user_login WHERE user_name=" + "'" + username + ", password=" + "'" + password + "'";
            DataTable dt = new DataTable();
            com.Connection = con;
            com.CommandText = query;
            da.SelectCommand = com;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.GetType().Name + " - " + ex.Message);
            }
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}