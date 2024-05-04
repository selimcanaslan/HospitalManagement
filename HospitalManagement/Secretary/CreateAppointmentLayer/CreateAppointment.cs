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
using System.Xml.Linq;

namespace HospitalManagement.Secretary.CreateAppointmentLayer
{
    public partial class CreateAppointment : Form
    {
        DataTable relatedDoctorsGlobal = null;
        DataTable appointmentHoursGlobal;
        string lastSelectedDoctorTcno = string.Empty;
        BlSecretary blSecretary = new BlSecretary();
        public CreateAppointment()
        {
            InitializeComponent();
            FillComboboxFirstItem();
            tcnoTextBox.MaxLength = 11;
            phoneTextBox.MaxLength = 10;
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
            examinationDateTimePicker.Value = DateTime.Now;
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
                toast.Show();
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
                        for (int i = doctorComboBox.Items.Count - 1; i > 0; i--)
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
                        Toast toast = new Toast("İlgili Bölüme Ait Doktor Bulunamadı", Color.Red);
                        toast.Show();
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
                            selectedDoctorTcNo = row["tc_no"].ToString();
                            lastSelectedDoctorTcno = selectedDoctorTcNo;
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
                    DateTime examinationDate;

                    if (examinationTimeComboBox.Items.Count > 1)
                    {
                        for (int i = examinationTimeComboBox.Items.Count - 1; i > 0; i--)
                        {
                            examinationTimeComboBox.Items.RemoveAt(i);
                        }
                    }
                    if (doctorAppointments.Rows.Count > 0)
                    {
                        foreach (DataRow row in doctorAppointments.Rows)
                        {
                            examinationDate = (DateTime)row["examination_time"];

                            if (examinationDate.ToString() == examinationDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                            {
                                Console.WriteLine("Tarihler Eslesiyor");
                            }

                            string examinationHour = row["examination_hour"].ToString();
                            foreach (DataRow _row in appointmentHoursGlobal.Rows)
                            {
                                string hour = _row["appointment_hour"].ToString();
                                Console.WriteLine($"{examinationDate} and {examinationDateTimePicker.Value}");
                                if (examinationDate.ToString("yyyy-MM-dd") == examinationDateTimePicker.Value.ToString("yyyy-MM-dd"))
                                {
                                    if (hour != examinationHour)
                                    {
                                        if (!examinationTimeComboBox.Items.Contains(hour))
                                        {
                                            examinationTimeComboBox.Items.Add(hour);
                                        }
                                    }
                                    else
                                    {
                                        if (examinationTimeComboBox.Items.Contains(hour))
                                        {
                                            examinationTimeComboBox.Items.Remove(hour);
                                        }
                                    }
                                }
                                else
                                {
                                    if (!examinationTimeComboBox.Items.Contains(hour))
                                    {
                                        examinationTimeComboBox.Items.Add(hour);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (DataRow _row in appointmentHoursGlobal.Rows)
                        {
                            string hour = _row["appointment_hour"].ToString();
                            examinationTimeComboBox.Items.Add(hour);
                        }
                    }

                }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            string validation = validateFields();
            if (validation == "OK")
            {
                string totalResponse = string.Empty;
                string name = nameTextBox.Text;
                string surname = surnameTextBox.Text;
                string tcNo = tcnoTextBox.Text;
                string mail = mailTextBox.Text;
                string phone = phoneTextBox.Text;
                string address = addressTextBox.Text;
                string problem = patientProblemTextBox.Text;
                string section = sectionComboBox.Text;
                string doctor = doctorComboBox.Text;
                string examinationTimeHour = examinationTimeComboBox.Text;
                string examinationDate = examinationDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                Console.WriteLine(examinationDate);
                try
                {
                    bool isPatientExist = blSecretary.PatientExistenceCheck(tcNo);
                    if (!isPatientExist)
                    {
                        bool patientCreationResponse = blSecretary.CreatePatient(tcNo, name, surname, mail, phone, address, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        if (patientCreationResponse) { totalResponse += "Yeni Hasta Kaydı Yapıldı\n"; }
                        else { totalResponse += "Yeni Hasta Kaydı Yapılamadı\n"; }
                    }
                    bool isPatientExist2 = blSecretary.PatientExistenceCheck(tcNo);
                    if (isPatientExist2)
                    {

                        bool appointmentCreationResponse = blSecretary.CreateAppointment(tcNo, section, lastSelectedDoctorTcno, examinationDate, examinationTimeHour, 0, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        if (appointmentCreationResponse)
                        {
                            totalResponse += "Hasta Randevusu Başarıyla Oluşturuldu.\nRandevu Bilgileri Mail Yoluyla İletildi.";

                        }
                        else
                        {
                            totalResponse += "Hasta Randevusu Oluşturulamadı.";
                        }
                    }
                    InfoMessage infoMessage = new InfoMessage(totalResponse, "Bilgi");
                    infoMessage.ShowDialog();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

            }
            else
            {
                InfoMessage infoMessage = new InfoMessage(validation, "Hata");
                infoMessage.ShowDialog();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (tcNoToSearchTextBox.Text.Length != 11 || string.IsNullOrEmpty(tcNoToSearchTextBox.Text))
            {
                InfoMessage infoMessage = new InfoMessage("Lütfen 11 Haneli Bir TCNo Giriniz!", "Hata");
                infoMessage.ShowDialog();
            }
            else
            {
                string tcNoToSearch = tcNoToSearchTextBox.Text;
                DataTable patient = blSecretary.FetchPatientBytcNo(tcNoToSearch);
                if (patient != null)
                {
                    foreach (DataRow row in patient.Rows)
                    {
                        tcnoTextBox.Text = row["tc_no"].ToString();
                        nameTextBox.Text = row["name"].ToString();
                        surnameTextBox.Text = row["surname"].ToString();
                        mailTextBox.Text = row["mail"].ToString();
                        phoneTextBox.Text = row["phone_number"].ToString();
                        addressTextBox.Text = row["address"].ToString();
                    }
                    InfoMessage infoMessage = new InfoMessage("Hasta Bilgileri Getirildi!", "Bilgi");
                    infoMessage.ShowDialog();
                }
                else
                {
                    InfoMessage infoMessage = new InfoMessage("Girilen TCNo ile eşleşen hasta bulunamadı!", "Hata");
                    infoMessage.ShowDialog();
                }
            }
        }
    }
}
