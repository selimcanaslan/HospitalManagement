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

        public DataTable DTable(string query)
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
            con.Close();
            return dt;
        }
    }
}