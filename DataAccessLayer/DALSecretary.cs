using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public class DALSecretary : DbConnect
    {
        public DALSecretary()
        {
            DbConnect dbConnect = new DbConnect();

        }
        public bool AddSecretary(string name, string surname, string tcno, string mail, string phone_number, string address)
        {
            String query = "INSERT INTO Secretary VALUES ('" + name + "','" + surname + "','" + tcno + "','" + mail +
                "','" + phone_number + "','" + address + "')";
            exception = null;
            com.Connection = con;
            com.CommandText = query;
            try
            {
                int rows_affected = com.ExecuteNonQuery();
                if (rows_affected >= 1) { return true; }
                else { return false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); return false; }
        }

        public DataTable fetchAllSecretary()
        {
            DataTable dt = new DataTable();
            string query = "SELECT tc_no,name,surname,mail,phone_number,address FROM Secretary";
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
        public DataTable fetchSecretaryByGivenName(string name)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT tc_no,name,surname,mail,phone_number,address FROM Secretary WHERE name + ' ' + surname LIKE '{name}%'";
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
        public bool deleteSecretary(string phone_number)
        {
            String query = "DELETE FROM Secretary WHERE phone_number='" + phone_number + "'";
            exception = null;
            com.Connection = con;
            com.CommandText = query;
            try
            {
                int rows_affected = com.ExecuteNonQuery();
                if (rows_affected >= 1) { return true; }
                else { return false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); return false; }
            
        }
    }
}
