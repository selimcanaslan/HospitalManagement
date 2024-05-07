using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Secretary.PatientEditLayer
{
    public partial class PatientEdit : Form
    {
        public static bool confirmButtonResponse;
        private BlSecretary blSecretary = new BlSecretary();
        public PatientEdit(string tcNo)
        {
            InitializeComponent();
            fillFields(tcNo);
        }
        private void fillFields(string tcNo)
        {
            DataTable patientData = blSecretary.FetchPatientBytcNo(tcNo);
            tcnoTextBox.Text = patientData.Rows[0]["tc_no"].ToString();
            nameTextBox.Text = patientData.Rows[0]["name"].ToString();
            surnameTextBox.Text = patientData.Rows[0]["surname"].ToString();
            mailTextBox.Text = patientData.Rows[0]["mail"].ToString();
            phoneTextBox.Text = patientData.Rows[0]["phone_number"].ToString();
            addressTextBox.Text = patientData.Rows[0]["address"].ToString();
            tcnoTextBox.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string tcNo = tcnoTextBox.Text;
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string mail = mailTextBox.Text;
            string phone = phoneTextBox.Text;
            string address = addressTextBox.Text;
            confirmButtonResponse = blSecretary.UpdatePatient(tcNo, name, surname, mail, phone, address);
            this.Close();
        }
    }
}
