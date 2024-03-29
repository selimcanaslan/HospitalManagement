using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALSecretary : DbConnect
    {
        public DALSecretary()
        {
            DbConnect dbConnect = new DbConnect();

        }
        public void AddSecretary(string name, string surname, string mail, string phone_number, string address)
        {
            String query = "INSERT INTO Secretary VALUES ('" + name + "','" + surname + "','" + mail +
                "','" + phone_number + "','" + address + "')";
            exception = null;
            com.Connection = con;
            com.CommandText = query;

            try { com.ExecuteScalar(); }
            catch (SqlException ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); }
        }
    }
}
