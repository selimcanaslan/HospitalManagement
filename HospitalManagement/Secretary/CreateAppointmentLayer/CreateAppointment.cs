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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HospitalManagement.Secretary.CreateAppointmentLayer
{
    public partial class CreateAppointment : Form
    {
        DataTable relatedDoctorsGlobal = null;
        DataTable appointmentHoursGlobal;
        BlSecretary blSecretary = new BlSecretary();
        public CreateAppointment()
        {
            InitializeComponent();
            FillComboboxFirstItem();
        }
        private void FillComboboxFirstItem()
        {
            sectionComboBox.Items.Insert(0, "Bölüm Seçiniz");
            doctorComboBox.Items.Insert(0, "Doktor Seçiniz");
            examinationTimeComboBox.Items.Insert(0, "Muayene Saati Seçiniz");
            sectionComboBox.StartIndex = 0;
            doctorComboBox.StartIndex = 0;
            examinationTimeComboBox.StartIndex = 0;
        }
        private void CreateAppointment_Load(object sender, EventArgs e)
        {
            FillSections();
            relatedDoctorsGlobal = new DataTable();
            appointmentHoursGlobal = new DataTable();
            appointmentHoursGlobal = blSecretary.fetchAppointmentHours();
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

        private void examinationDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTimePickerValue = examinationDateTimePicker.Value;
            DateTime today = DateTime.Now;
            if (dateTimePickerValue.Year <= today.Year &&
                dateTimePickerValue.DayOfYear < today.DayOfYear)
            {
                examinationDateTimePicker.Value = today;
                Toast toast = new Toast("Bugünden daha eski bir tarih seçemezsin!", Color.Red);
                toast.ShowDialog();
            }
        }
        private void sectionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            doctorComboBox.SelectedIndex = 0;
            FillDoctorComboBox(sectionComboBox.SelectedIndex);
        }
        private void FillDoctorComboBox(int sectionId)
        {
            try
            {
                if (sectionId != 0)
                {
                    if (doctorComboBox.Items.Count > 1)
                    {
                        for(int i = doctorComboBox.Items.Count - 1; i > 0; i--)
                        {
                            doctorComboBox.Items.RemoveAt(i);
                        }
                    }
                    DataTable relatedDoctors = blSecretary.FetchSectionIdRelatedDoctors(sectionId);
                    relatedDoctorsGlobal = relatedDoctors;
                    if (relatedDoctors.Rows.Count > 0)
                    {
                        foreach (DataRow row in relatedDoctors.Rows)
                        {
                            doctorComboBox.Items.Add(row["full_name"].ToString());
                        }
                    }
                    else
                    {
                        InfoMessage infoMessage = new InfoMessage("İlgili Bölüme Ait Uygun Doktor Bulunamadı", "Hata");
                        infoMessage.Show();
                    }
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (doctorComboBox.SelectedIndex != 0)
                {
                    string chosenDoctor = doctorComboBox.Text;
                    string selectedDoctorTcNo = string.Empty;
                    foreach (DataRow row in relatedDoctorsGlobal.Rows)
                    {
                        string fullName = row["full_name"].ToString();
                        if (fullName == chosenDoctor)
                        {
                            Console.WriteLine($"Eslesen doktor bulundu TcNosu= {row["tc_no"]}");
                            selectedDoctorTcNo = row["tc_no"].ToString();
                            break;
                        }
                    }
                    FillAppointmentHours(selectedDoctorTcNo);
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

        }
        private void FillAppointmentHours(string tcNo)
        {
            try
            {
                if (tcNo != string.Empty)
                {
                    DataTable doctorAppointments = new DataTable();
                    doctorAppointments = blSecretary.FetchDoctorAppointments(tcNo);
                    DateTime appointmentDate = new DateTime();

                    if (examinationTimeComboBox.Items.Count > 1)
                    {
                        for (int i = examinationTimeComboBox.Items.Count - 1; i > 0; i--)
                        {
                            examinationTimeComboBox.Items.RemoveAt(i);
                        }
                    }
                    foreach (DataRow _row in appointmentHoursGlobal.Rows)
                    {
                        string hour = _row["appointment_hour"].ToString();
                        if (hour != appointmentDate.ToString("HH:mm:ss"))
                        {
                            examinationTimeComboBox.Items.Add(hour);
                        }
                        
                        //if (tempDate.ToString("HH:mm:ss") != )
                        foreach (DataRow row in doctorAppointments.Rows)
                        {
                            appointmentDate = (DateTime)row["appointment_examination_time"];
                        }

                    }
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}
