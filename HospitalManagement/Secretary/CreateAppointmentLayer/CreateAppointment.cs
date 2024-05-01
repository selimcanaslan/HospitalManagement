using BusinessLayer;
using HospitalManagement.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Secretary.CreateAppointmentLayer
{
    public partial class CreateAppointment : Form
    {
        BlSecretary blSecretary = new BlSecretary();
        public CreateAppointment()
        {
            InitializeComponent();

        }
        private void CreateAppointment_Load(object sender, EventArgs e)
        {
            FillSections();
        }
        private void FillSections()
        {
            DataTable sections = blSecretary.FetchSections();
            foreach (DataRow row in sections.Rows)
            {
                sectionComboBox.Items.Add(row["name"].ToString());
            }
        }
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tcnoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private string validateFields()
        {
            string response = string.Empty;
            if (string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(surnameTextBox.Text) ||
                string.IsNullOrEmpty(tcnoTextBox.Text) ||
                string.IsNullOrEmpty(mailTextBox.Text) ||
                string.IsNullOrEmpty(phoneTextBox.Text) ||
                string.IsNullOrEmpty(addressTextBox.Text) ||
                string.IsNullOrEmpty(patientProblemTextBox.Text)) { response += "Lütfen Boş Alan Bırakmayınız!\n"; }


            if (string.IsNullOrEmpty(sectionComboBox.Text) || sectionComboBox.Text == "Bölüm Seçiniz") { response += "Bölüm Seçmediniz!\n"; }
            if (string.IsNullOrEmpty(doctorComboBox.Text) || doctorComboBox.Text == "Doktor Seçiniz") { response += "Doktor Seçmediniz!\n"; }
            if (string.IsNullOrEmpty(examinationTimeComboBox.Text) || examinationTimeComboBox.Text == "Muayene Saati Seçiniz") { response += "Muayene Saati Seçmediniz!\n"; }

            if (response != string.Empty) { return response; }
            else { return "OK"; }
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            string validation = validateFields();
            if (validation == "OK")
            {
                InfoMessage infoMessage = new InfoMessage("Bütün Fieldlar OK", "Bilgi");
                infoMessage.ShowDialog();
            }
            else
            {
                InfoMessage infoMessage = new InfoMessage(validation, "Hata");
                infoMessage.ShowDialog();
            }
        }

        private void sectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDoctorComboBox(sectionComboBox.SelectedIndex);
        }
        private void FillDoctorComboBox(int sectionId)
        {
            for (int i = 1; i <= doctorComboBox.Items.Count-1; i++)
            {
                if (i<= sectionComboBox.Items.Count-1)
                    doctorComboBox.Items.RemoveAt(i);
            }
            DataTable relatedDoctors = blSecretary.FetchSectionIdRelatedDoctors(sectionId);
            foreach (DataRow row in relatedDoctors.Rows) { doctorComboBox.Items.Add(row["full_name"].ToString()); }
        }
        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            guna2TextBox1.BorderColor = Color.FromArgb(46, 46, 46);
        }

        private void addressTextBox_Enter(object sender, EventArgs e)
        {
            guna2TextBox1.BorderColor = Color.Red;
        }
        private void patientProblemTextBox_Leave(object sender, EventArgs e)
        {
            guna2TextBox2.BorderColor = Color.FromArgb(46, 46, 46);
        }

        private void patientProblemTextBox_Enter(object sender, EventArgs e)
        {
            guna2TextBox2.BorderColor = Color.Red;
        }
    }
}
