﻿using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace HospitalManagement.Secretary.UpdateDoctorLayer
{
    public partial class UpdateDoctor : Form
    {
        DataTable doctorToUpdate = new DataTable();
        string doctorProfilePicture = "";
        public UpdateDoctor()
        {
            InitializeComponent();
            doctorTcnoTextBox.MaxLength = 11;
            doctorToUpdate = null;
            uploadProfilePicture.Enabled = false;
            sectionComboBox.Items.Add("Dahiliye");
        }

        private void doctorTcnoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void sendNewProfilePictureViaFtp(string imagePath, string userName = "")
        {
            string loggedInUserName = LoginWindow._userEntity.kullaniciAd;
            byte[] data;
            using (Image image = Image.FromFile(imagePath))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    data = m.ToArray();
                }
            }
            FTPHelper fTPHelper = new FTPHelper("\tftp://155.254.244.38/www.sca.somee.com", "sca33", "2XFfX2b6xQUTJ-U");
            string result = fTPHelper.Upload(new MemoryStream(data), $"profilePictures/{userName}.jpeg");
            MessageBox.Show(result);
        }

        private void uploadProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Image Files (JPG,PNG,GIF) | *.JPG;*.PNG;*.GIF";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                profilePicture.Image = Image.FromFile(ofd.FileName);
                doctorProfilePicture = ofd.FileName;
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(doctorTcnoTextBox.Text) == false)
            {
                if (doctorTcnoTextBox.Text.Length == 11)
                {
                    BlSecretary blSecretary = new BlSecretary();
                    doctorToUpdate = blSecretary.fetchDoctorByGivenTcNo(doctorTcnoTextBox.Text);
                    fillFields(doctorToUpdate);
                    string userName = blSecretary.lowercasedAndTrimmedNameSurname(doctorTcnoTextBox.Text);
                    profilePicture.LoadAsync($"http://sca.somee.com/profilePictures/{userName}.jpeg");
                    MessageBox.Show("Bilgiler Başarıyla Getirildi");
                    uploadProfilePicture.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lütfen T.C No 11 Hane Giriniz!");
                }

            }
            else
            {
                MessageBox.Show("Lütfen T.C No Giriniz!\n");
            }
        }

        private void fillFields(DataTable doctorToUpdate)
        {
            foreach (DataRow dr in doctorToUpdate.Rows)
            {
                nameTextBox.Text = dr["name"].ToString();
                surnameTextBox.Text = dr["surname"].ToString();
                tcnoTextBox.Text = dr["tc_no"].ToString();
                sectionComboBox.Text = dr["section"].ToString();
                mailTextBox.Text = dr["mail"].ToString();
                phoneTextBox.Text = dr["phone_number"].ToString();
                addressTextBox.Text = dr["address"].ToString();
            }

        }

        private void updateInformations_Click(object sender, EventArgs e)
        {
            if (doctorToUpdate != null)
            {
                string name = nameTextBox.Text;
                string surname = surnameTextBox.Text;
                string tcno = tcnoTextBox.Text;
                string section = sectionComboBox.Text;
                string mail = mailTextBox.Text;
                string phone = phoneTextBox.Text;
                string address = addressTextBox.Text;
                if (name != doctorToUpdate.Rows[0]["name"].ToString() ||
                    surname != doctorToUpdate.Rows[0]["surname"].ToString() ||
                    tcno != doctorToUpdate.Rows[0]["tc_no"].ToString() ||
                    section != doctorToUpdate.Rows[0]["section"].ToString() ||
                    mail != doctorToUpdate.Rows[0]["mail"].ToString() ||
                    phone != doctorToUpdate.Rows[0]["phone_number"].ToString() ||
                    address != doctorToUpdate.Rows[0]["address"].ToString() ||
                    doctorProfilePicture != "")
                {
                    if (doctorProfilePicture != "")
                    {
                        sendNewProfilePictureViaFtp(doctorProfilePicture, (name + surname).ToLower().Replace(" ", ""));
                        doctorProfilePicture = "";
                    }
                    if (name != doctorToUpdate.Rows[0]["name"].ToString() ||
                            surname != doctorToUpdate.Rows[0]["surname"].ToString())
                    {
                        FtpWebRequest ftpRequest = null;
                        FtpWebResponse ftpResponse = null;
                        try
                        {
                            string newFileName = $"{(nameTextBox.Text + surnameTextBox.Text).ToLower().Replace(" ", "")}.jpeg";
                            ftpRequest = (FtpWebRequest)WebRequest.Create($"ftp://sca.somee.com/www.sca.somee.com/profilePictures/{(doctorToUpdate.Rows[0]["name"].ToString() + doctorToUpdate.Rows[0]["surname"].ToString()).ToLower().Replace(" ", "")}.jpeg");
                            ftpRequest.Credentials = new NetworkCredential("sca33", "2XFfX2b6xQUTJ-U");
                            ftpRequest.UseBinary = true;
                            ftpRequest.UsePassive = true;
                            ftpRequest.KeepAlive = true;
                            ftpRequest.Method = Ftp.Rename;
                            ftpRequest.RenameTo = newFileName;
                            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                            ftpResponse.Close();
                            ftpRequest = null;
                        }
                        catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                    }
                    BlSecretary blSecretary = new BlSecretary();
                    bool response = blSecretary.updateDoctor(name, surname, tcno, section, mail, phone, address, Convert.ToInt16(doctorToUpdate.Rows[0]["id"]));
                    if (response)
                    {
                        doctorToUpdate.Clear();
                        doctorToUpdate = blSecretary.fetchDoctorByGivenTcNo(doctorTcnoTextBox.Text);
                        MessageBox.Show("Bilgiler Başarıyla Güncellendi!");
                    }
                    else
                    {
                        MessageBox.Show("Hata");
                    }
                }
                else
                {
                    MessageBox.Show("Değişiklik Yapmadınız!");
                }
            }
            else
            {
                MessageBox.Show("Henüz Arama Yapmadınız!");
            }
        }
    }
}
