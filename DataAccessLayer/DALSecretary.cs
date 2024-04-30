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
            return dt;
        }
        public bool deleteSecretary(string tc_no)
        {
            bool response = false;
            Console.WriteLine("Gelinen tc_no= " + tc_no);
            string childQuery = $"DELETE FROM Secretary_Login_Info WHERE tc_no='{tc_no}'";
            string parentQuery = $"DELETE FROM Secretary WHERE tc_no='{tc_no}'";
            exception = null;
            com.Connection = con;
            com.CommandText = childQuery;
            try
            {
                int childRowsAffected = com.ExecuteNonQuery();
                com.CommandText = parentQuery;
                int parentRowsAffected = com.ExecuteNonQuery();
                if (childRowsAffected > 0 && parentRowsAffected > 0) { response = true; }
                else { response = false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.ToString() + " - " + ex.Message); }
            return response;
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
                if (rows_affected >= 1) { return true; }
                else { return false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); return false; }

        }
        public bool AddDoctor(string tcno, string name, string surname, int sectionId, string mail, string phone_number, string address)
        {
            String query = "INSERT INTO Doctor VALUES ('" + tcno + "','" + name + "','" + surname + "'," + sectionId + ",'" + mail +
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
        public DataTable fetchDoctorByGivenTcNo(string tcNo)
        {
            Console.WriteLine("gelinen tcno= " + tcNo);
            DataTable dt = new DataTable();
            string query = $"SELECT id,tc_no,doctor_name,doctor_surname,section_id,mail,phone_number,address FROM Doctor WHERE tc_no = '{tcNo}'";
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

            return dt;
        }
        public bool updateDoctor(string name, string surname, string tcNo, int section, string mail, string phoneNumber, string address, int id)
        {
            String query = $"UPDATE Doctor SET doctor_name= '{name}', doctor_surname='{surname}', section_id='{section}', tc_no = '{tcNo}', mail='{mail}'" +
                $", phone_number = '{phoneNumber}', address = '{address}' WHERE id = {id}";
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
        public DataTable fetchDoctorByGivenName(string name)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT tc_no,doctor_name,doctor_surname,Sections.name as \"section_name\",mail,phone_number,address\r\nFROM Doctor " +
                $"INNER JOIN Sections ON Doctor.section_id = Sections.Id \r\nWHERE doctor_name + ' ' + doctor_surname LIKE '{name}%'";
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
            return dt;
        }
        public DataTable fetchAllDoctor()
        {
            DataTable dt = new DataTable();
            string query = "EXEC FetchAllDoctor";
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
        public bool deleteDoctor(string tc_no)
        {
            bool response = false;
            Console.WriteLine("Gelinen tc_no= " + tc_no);
            string childQuery = $"DELETE FROM Doctor_Login_Info WHERE tc_no='{tc_no}'";
            string parentQuery = $"DELETE FROM Doctor WHERE tc_no='{tc_no}'";
            exception = null;
            com.Connection = con;
            com.CommandText = childQuery;
            try
            {
                int childRowsAffected = com.ExecuteNonQuery();
                com.CommandText = parentQuery;
                int parentRowsAffected = com.ExecuteNonQuery();
                if (childRowsAffected > 0 && parentRowsAffected > 0) { response = true; }
                else { response = false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.ToString() + " - " + ex.Message); }
            return response;
        }
        public DataTable FetchSections()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Sections";
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
        public DataTable FetchSectionIdRelatedDoctors(int sectionId)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT doctor_name + ' ' + doctor_surname as 'full_name' FROM Doctor WHERE section_id ={sectionId}";
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
