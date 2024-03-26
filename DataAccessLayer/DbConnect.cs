using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbConnect
    {
        private string SQLConnectionString = @"Server = SCA\SQLEXPRESS;Database =HastaRandevuKayit; Trusted_Connection = True;";
        protected SqlConnection con = new SqlConnection();
        protected SqlDataAdapter da = new SqlDataAdapter();
        protected SqlCommand com = new SqlCommand();
        public SqlException exception = null;

        public DbConnect()
        {
            exception = null;
            con = new SqlConnection(SQLConnectionString);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    Console.WriteLine("Db Baglanti Saglandi");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.GetType().Name + " - " + ex.Message);
                }
            }
        }
    }
}
