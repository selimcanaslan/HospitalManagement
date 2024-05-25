using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbConnect
    {
        private string SQLConnectionStringLocal = @"Server = SCA\SQLEXPRESS;Database =gp_hospital; Trusted_Connection = True;";
        private string SQLConnectionStringSomee = Properties.Resources.dbConSt;
        protected SqlConnection con = new SqlConnection();
        protected SqlDataAdapter da = new SqlDataAdapter();
        protected SqlCommand com = new SqlCommand();
        protected SqlException exception = null;
        

        public DbConnect()
        {
            exception = null;
            con = new SqlConnection(SQLConnectionStringSomee);
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.GetType().Name + " - " + ex.Message);
                }
            }
        }
    }
}
