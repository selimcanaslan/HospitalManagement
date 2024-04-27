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
        public bool AddSecretary(string tcno, string name, string surname, string mail, string phone_number, string address)
        {
            String query = "INSERT INTO Secretary VALUES ('" + tcno + "','" + name + "','" + surname + "','" + mail +
                "','" + phone_number + "','" + address + "')";
            exception = null;
            com.Connection = con;
            com.CommandText = query;
            try
            {
                int rows_affected = com.ExecuteNonQuery();
                if (rows_affected >= 1) { con.Close(); return true; }
                else { con.Close(); return false; }

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
            con.Close();
            return dt;
        }
        public DataTable fetchSecretaryByGivenName(string name)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT tc_no,name,surname,mail,phone_number,address FROM Secretary WHERE name + ' ' + surname LIKE '{name}%'";
            try
            {
                com.Connection = con;
                com.CommandText = query;
                da.SelectCommand = com;
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.GetType().Name + " - " + ex.Message);
            }
            con.Close();
            return dt;
        }
        public DataTable fetchSecretaryByGivenTcNo(string tcNo)
        {
            Console.WriteLine("gelinen tcno= " + tcNo);
            DataTable dt = new DataTable();
            string query = $"SELECT id,tc_no,name,surname,mail,phone_number,address FROM Secretary WHERE tc_no = '{tcNo}'";
            try
            {
                com.Connection = con;
                com.CommandText = query;
                da.SelectCommand = com;
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.GetType().Name + " - " + ex.Message);
            }
            con.Close();
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
                if (rows_affected >= 1) { con.Close(); return true; }
                else { con.Close(); return false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); return false; }

        }

        public string lowercasedAndTrimmedNameSurname(string tcNo)
        {
            string userName = "";
            String query = $"SELECT TRIM(LOWER((name + surname))) as user_name FROM Secretary Where tc_no = '{tcNo}'";
            DataTable dt = new DataTable();
            exception = null;
            com.Connection = con;
            com.CommandText = query;
            da.SelectCommand = com;
            try
            {
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    userName = row["user_name"].ToString();
                }
                con.Close();
                return userName.Replace(" ", "").ToLower();
            }
            catch (SqlException ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); return ex.GetType().Name + " - " + ex.Message; }

        }
        public bool updateSecretary(string name, string surname, string tcNo, string mail, string phoneNumber, string address, int id)
        {
            String query = $"UPDATE Secretary SET name= '{name}', surname='{surname}', tc_no = '{tcNo}', mail='{mail}'" +
                $", phone_number = '{phoneNumber}', address = '{address}' WHERE id = {id}";
            exception = null;
            com.Connection = con;
            com.CommandText = query;
            try
            {
                int rows_affected = com.ExecuteNonQuery();
                if (rows_affected >= 1) { con.Close(); return true; }
                else { con.Close(); return false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); return false; }

        }
        public bool AddDoctor(string tcno, string name, string surname, string mail, string phone_number, string address, string section)
        {
            String query = "INSERT INTO Doctor VALUES ('" + tcno + "','" + name + "','" + surname + "','" + section + "','" + mail +
                "','" + phone_number + "','" + address + "')";
            exception = null;
            com.Connection = con;
            com.CommandText = query;
            try
            {
                int rows_affected = com.ExecuteNonQuery();
                if (rows_affected >= 1) { con.Close(); return true; }
                else { con.Close(); return false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); return false; }
        }
        public DataTable fetchDoctorByGivenTcNo(string tcNo)
        {
            Console.WriteLine("gelinen tcno= " + tcNo);
            DataTable dt = new DataTable();
            string query = $"SELECT id,tc_no,name,surname,section,mail,phone_number,address FROM Doctor WHERE tc_no = '{tcNo}'";
            try
            {
                com.Connection = con;
                com.CommandText = query;
                da.SelectCommand = com;
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.GetType().Name + " - " + ex.Message);
            }
            con.Close();
            return dt;
        }
        public bool updateDoctor(string name, string surname, string tcNo, string section, string mail, string phoneNumber, string address, int id)
        {
            String query = $"UPDATE Doctor SET name= '{name}', surname='{surname}', section='{section}', tc_no = '{tcNo}', mail='{mail}'" +
                $", phone_number = '{phoneNumber}', address = '{address}' WHERE id = {id}";
            exception = null;
            com.Connection = con;
            com.CommandText = query;
            try
            {
                int rows_affected = com.ExecuteNonQuery();
                if (rows_affected >= 1) { con.Close(); return true; }
                else { con.Close(); return false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); return false; }

        }
    }
}
