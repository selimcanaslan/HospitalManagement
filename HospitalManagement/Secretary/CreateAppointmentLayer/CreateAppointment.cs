using BusinessLayer;
using HospitalManagement.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
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
            tcNoToSearchTextBox.MaxLength = 11;
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
        private void tcNoToSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            ResetAllComboBoxAtOnce();
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
            examinationTimeComboBox.SelectedIndex = 0;
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
                DataTable doctorAppointments = new DataTable();
                doctorAppointments = blSecretary.FetchDoctorAppointments(tcNo, examinationDateTimePicker.Value.ToString("yyyy-MM-dd"));
                Console.WriteLine(doctorAppointments.Rows.Count);
                if (tcNo != string.Empty)
                {
                    if (examinationTimeComboBox.Items.Count > 1)
                    {
                        int itemCount = examinationTimeComboBox.Items.Count;
                        for (int i = itemCount - 1; i > 0; i--)
                        {
                            examinationTimeComboBox.Items.RemoveAt(i);
                            Console.WriteLine($"{i} is deleted duo resetting combobox");
                        }
                        examinationTimeComboBox.SelectedIndex = 0;
                    }
                    if (doctorAppointments.Rows.Count > 0)
                    {
                        List<string> hourList = new List<string>();
                        List<string> hoursToDelete = new List<string>();
                        foreach (DataRow row in appointmentHoursGlobal.Rows)
                        {
                            hourList.Add(row["appointment_hour"].ToString());
                        }
                        foreach(DataRow _row in doctorAppointments.Rows)
                        {
                            foreach(var item in hourList)
                            {
                                if (_row["examination_hour"].ToString() == item)
                                {
                                    hoursToDelete.Add(item.ToString());
                                }
                            }
                        }
                        foreach(DataRow dataRow in appointmentHoursGlobal.Rows)
                        {
                            examinationTimeComboBox.Items.Add(dataRow["appointment_hour"]);
                        }
                        for (int i = examinationTimeComboBox.Items.Count - 1; i>0; i--)
                        {
                            foreach(var item in hoursToDelete)
                            {
                                if (examinationTimeComboBox.Items[i].ToString() == item)
                                {
                                    examinationTimeComboBox.Items.RemoveAt(i);
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        foreach (DataRow dataRow in appointmentHoursGlobal.Rows)
                        {
                            examinationTimeComboBox.Items.Add(dataRow["appointment_hour"]);
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }
        private void ResetAllComboBoxAtOnce()
        {
            if (sectionComboBox.SelectedIndex != 0)
            {
                sectionComboBox.SelectedIndex = 0;
                doctorComboBox.SelectedIndex = 0;
                examinationTimeComboBox.SelectedIndex = 0;
            }
            else
            {
                return;
            }
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
                string examinationDate = examinationDateTimePicker.Value.ToString("yyyy-MM-dd");
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
                        DataTable sameAppointmentExistence = new DataTable();
                        sameAppointmentExistence = blSecretary.FetchAwaitingAppointmentsFilteredByDateAndTcNo(tcNo, examinationDateTimePicker.Value.ToString("yyyy-MM-dd"));
                        Console.WriteLine(sameAppointmentExistence.Rows.Count);
                        if (sameAppointmentExistence.Rows.Count > 0 && sameAppointmentExistence.Rows[0]["section"].ToString() == section)
                        {

                            totalResponse += $"Hasta adına bugün {section} bölümüne alınmış bir randevu zaten var!";
                        }
                        else
                        {
                            bool appointmentCreationResponse = blSecretary.CreateAppointment(tcNo, section, lastSelectedDoctorTcno, examinationDate, examinationTimeHour, 0, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            if (appointmentCreationResponse)
                            {
                                totalResponse += "Hasta Randevusu Başarıyla Oluşturuldu.\nRandevu Bilgileri Mail Yoluyla İletildi.";
                                sendAppointmentInfoToMailAddress(section, examinationDateTimePicker.Value.ToString("dd MMMM"), examinationTimeHour, doctor, mail);
                                sectionComboBox.SelectedIndex = 0;
                                doctorComboBox.SelectedIndex = 0;
                                examinationDateTimePicker.Value = DateTime.Now;
                            }
                            else
                            {
                                totalResponse += "Hasta Randevusu Oluşturulamadı.";
                            }
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
        private void sendAppointmentInfoToMailAddress(string section, string date, string time, string doctorName, string mailAddress)
        {
            try
            {
                var smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("selimcanaslan33@gmail.com", "awzc nxve hnwo sxkj"),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("selimcanaslan33@gmail.com"),
                    Subject = "Randevu Bilgileriniz",
                    Body = "<h1>Randevu Bilgileriniz Aşağıda Gösterilmektedir</h1>" +
                    "<p>Randevu Bölümü: " + section + "</p>" +
                    "<p>Randevu Tarihi: " + date + "</p>" +
                    "<p>Randevu Saati: " + time + "</p>" +
                    "<p>Doktor: " + doctorName + "</p>",
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(mailAddress);

                smtpClient.SendMailAsync(mailMessage);
            }
            catch (SmtpException e)
            {
                Console.WriteLine("Error: {0}", e.StatusCode);
            }

        }


    }
}
