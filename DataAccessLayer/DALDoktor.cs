using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable FetchAllAwaitingAppointmentsFilteredByDoctorTcNo(string tcNo)
        {
            DataTable dt = new DataTable();
            string query = $"EXEC fetchAllAwaitingAppointmentsFilteredByDoctorTcNo '{tcNo}'";
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
        public DataTable FetchPatientBytcNo(string tcNo)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Patient WHERE tc_no ='{tcNo}'";
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
    }
}
