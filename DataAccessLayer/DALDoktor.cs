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
        public DataTable FetchRelatedExamination(int appointmentId)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Examination WHERE appointment_id='{appointmentId}'";
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
        public bool UpdateExaminationResult(int appointmentId, string result)
        {
            bool response = false;
            string query = $"UPDATE Examination SET result = '{result}' WHERE appointment_id = {appointmentId}";
            exception = null;
            com.Connection = con;
            com.CommandText = query;
            try
            {

                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected > 0) { response = true; }
                else { response = false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.ToString() + " - " + ex.Message); }
            return response;
        }
        public bool UpdateDoctor(string name, string surname, string tcNo, string mail, string phoneNumber, string address, int id)
        {
            bool response = false;
            string query = $"UPDATE Doctor SET tc_no='{tcNo}',doctor_name='{name}', doctor_surname='{surname}',mail='{mail}',phone_number='{phoneNumber}',address='{address}' WHERE id = {id}";
            exception = null;
            com.Connection = con;
            com.CommandText = query;
            try
            {

                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected > 0) { response = true; }
                else { response = false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.ToString() + " - " + ex.Message); }
            return response;
        }
        
    }
}
