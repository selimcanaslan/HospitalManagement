using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALDoktor : DALCommon
    {
        private string SQLConnectionString = @"Server = SCA\SQLEXPRESS;Database =HastaRandevuKayit; Trusted_Connection = True;";
        private SqlConnection con = new SqlConnection();
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand com = new SqlCommand();
        public SqlException exception = null;
        public DALDoktor()
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

        public void AddDoctor(string name, string surname, string section, string mail, string phone_number, string address)
        {
            String query = "INSERT INTO Doctor VALUES ('" + name + "','" + surname + "','" + section +
                "','" + mail + "','" + phone_number + "','" + address + "')";
            exception = null;
            com.Connection = con;
            com.CommandText = query;

            try
            {
                com.ExecuteScalar();
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.GetType().Name + " - " + ex.Message);
            }
        }
    }
}
