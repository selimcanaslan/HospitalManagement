using BusinessLayer;
using HospitalManagement.Dialog;
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
            this.DoubleBuffered = true;
            tcnoTextBox.MaxLength = 11;
            phoneTextBox.MaxLength = 10;
            doctorToUpdate = null;
            FillSectionComboBox();
        }
        private void FillSectionComboBox()
        {
            BlSecretary blSecretary = new BlSecretary();
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

        private void sendNewProfilePictureViaFtp(string imagePath, string userName = "")
        {
            string loggedInUserName = LoginWindow._userEntity.KullaniciAd;
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
            string result = fTPHelper.Upload(new MemoryStream(data), $"profilePictures/Doctor/{userName}.jpeg");
            InfoMessage infoMessage = new InfoMessage(result, "Bilgi");
            infoMessage.ShowDialog();

        }

        private void uploadProfilePicture_Click(object sender, EventArgs e)
        {
            if (doctorToUpdate != null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.FileName = "Image Files (JPG,PNG,GIF) | *.JPG;*.PNG;*.GIF";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    profilePicture.Image = Image.FromFile(ofd.FileName);
                    doctorProfilePicture = ofd.FileName;
                }
            }
            else
            {
                InfoMessage infoMessage = new InfoMessage("Henüz Arama Yapmadınız!", "Bilgi");
                infoMessage.ShowDialog();
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
                    string userName = (doctorToUpdate.Rows[0]["doctor_name"].ToString() + doctorToUpdate.Rows[0]["doctor_surname"].ToString()).Replace(" ","").ToLower();
                    profilePicture.LoadAsync($"http://sca.somee.com/profilePictures/Doctor/{userName}.jpeg");
                    InfoMessage infoMessage = new InfoMessage("Bilgiler Başarıyla Getirildi!", "Bilgi");
                    infoMessage.ShowDialog();
                    uploadProfilePicture.Enabled = true;
                }
                else
                {
                    InfoMessage infoMessage = new InfoMessage("Lütfen T.C No 11 Hane Giriniz!", "Hata");
                    infoMessage.ShowDialog();
                }

            }
            else
            {
                InfoMessage infoMessage = new InfoMessage("Lütfen T.C No Giriniz!", "Hata");
                infoMessage.ShowDialog();
            }
        }

        private void fillFields(DataTable doctorToUpdate)
        {
            foreach (DataRow dr in doctorToUpdate.Rows)
            {
                nameTextBox.Text = dr["doctor_name"].ToString();
                surnameTextBox.Text = dr["doctor_surname"].ToString();
                tcnoTextBox.Text = dr["tc_no"].ToString();
                sectionComboBox.SelectedIndex = Int16.Parse(dr["section_id"].ToString());
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
                int section = sectionComboBox.SelectedIndex;
                string mail = mailTextBox.Text;
                string phone = phoneTextBox.Text;
                string address = addressTextBox.Text;
                if (name != doctorToUpdate.Rows[0]["doctor_name"].ToString() ||
                    surname != doctorToUpdate.Rows[0]["doctor_surname"].ToString() ||
                    tcno != doctorToUpdate.Rows[0]["tc_no"].ToString() ||
                    section != Int16.Parse(doctorToUpdate.Rows[0]["section_id"].ToString()) ||
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
                    if (name != doctorToUpdate.Rows[0]["doctor_name"].ToString() ||
                            surname != doctorToUpdate.Rows[0]["doctor_surname"].ToString())
                    {
                        FtpWebRequest ftpRequest = null;
                        FtpWebResponse ftpResponse = null;
                        try
                        {
                            string newFileName = $"{(nameTextBox.Text + surnameTextBox.Text).ToLower().Replace(" ", "")}.jpeg";
                            ftpRequest = (FtpWebRequest)WebRequest.Create($"ftp://sca.somee.com/www.sca.somee.com/profilePictures/Doctor/{(doctorToUpdate.Rows[0]["name"].ToString() + doctorToUpdate.Rows[0]["surname"].ToString()).ToLower().Replace(" ", "")}.jpeg");
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
                        InfoMessage infoMessage = new InfoMessage("Bilgiler Başarıyla Güncellendi!", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                    else
                    {
                        InfoMessage infoMessage = new InfoMessage("Hata", "Hata");
                        infoMessage.ShowDialog();
                    }
                }
                else
                {
                    InfoMessage infoMessage = new InfoMessage("Değişiklik Yapmadınız!", "Bilgi");
                    infoMessage.ShowDialog();
                }
            }
            else
            {
                InfoMessage infoMessage = new InfoMessage("Henüz Arama Yapmadınız!", "Bilgi");
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
    }
}
