using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALDoktor : DbConnect
    {
        public DALDoktor()
        {
            
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
