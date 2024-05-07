using BusinessLayer;
using HospitalManagement.Dialog;
using HospitalManagement.Secretary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Doctor.DocAccountLayer
{
    public partial class DocAccount : Form
    {
        private string chosenProfilePicture = string.Empty;
        public DocAccount()
        {
            InitializeComponent();
        }

        private void DocAccount_Load(object sender, EventArgs e)
        {
            LabelUpdate();
            // TextBox
            nameTextBox.Text = LoginWindow._userEntity.Ad;
            surnameTextBox.Text = LoginWindow._userEntity.Soyad;
            tcnoTextBox.Text = LoginWindow._userEntity.Tcno;
            mailTextBox.Text = LoginWindow._userEntity.Mail;
            phoneTextBox.Text = LoginWindow._userEntity.PhoneNumber;
            addressTextBox.Text = LoginWindow._userEntity.Address;
            //ProfilePicture
            profilePicture.LoadAsync($"http://sca.somee.com/profilePictures/Doctor/{LoginWindow._userEntity.KullaniciAd}.jpeg");

        }
        private void LabelUpdate()
        {
            nameSurnameLabel.Text = LoginWindow._userEntity.Ad + " " + LoginWindow._userEntity.Soyad;
            tcnoLabel.Text = LoginWindow._userEntity.Tcno;
            mailLabel.Text = LoginWindow._userEntity.Mail;
            phoneNumberLabel.Text = LoginWindow._userEntity.PhoneNumber;
        }
        private void uploadProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Image Files (JPG,PNG,GIF) | *.JPG;*.PNG;*.GIF";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var size = new FileInfo(ofd.FileName).Length;
                if (size < 120000)
                {
                    profilePicture.Image = Image.FromFile(ofd.FileName);
                    chosenProfilePicture = ofd.FileName;
                }
                else
                {
                    InfoMessage infoMessage = new InfoMessage("Dosya Boyutu 120Kb'dan Fazla Olamaz!", "Bilgi");
                    infoMessage.ShowDialog();
                }
            }
        }
        private string sendNewProfilePictureViaFtp(string imagePath)
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
            string result = fTPHelper.Upload(new MemoryStream(data), $"profilePictures/Doctor/{LoginWindow._userEntity.KullaniciAd}.jpeg");
            return result;
        }
        private bool FieldValidation()
        {
            bool response;
            if (nameTextBox.Text == LoginWindow._userEntity.Ad &&
                surnameTextBox.Text == LoginWindow._userEntity.Soyad &&
                tcnoTextBox.Text == LoginWindow._userEntity.Tcno &&
                mailTextBox.Text == LoginWindow._userEntity.Mail &&
                phoneTextBox.Text == LoginWindow._userEntity.PhoneNumber &&
                addressTextBox.Text == LoginWindow._userEntity.Address)
            {
                response = false;
            }
            else
            {
                response = true;
            }
            return response;
        }
        private string InformationUpdate()
        {
            string response = string.Empty;
            BlSecretary blSecretary = new BlSecretary();
            bool infoUpdateResponse = blSecretary.updateSecretary(nameTextBox.Text, surnameTextBox.Text, tcnoTextBox.Text
                , mailTextBox.Text, phoneTextBox.Text, addressTextBox.Text, LoginWindow._userEntity.Id);
            if (infoUpdateResponse) { response = "Bilgiler Başarıyla Güncellendi!"; }
            else { response = "Bilgiler Güncellenirken Hata İle Karşılaşıldı!"; }

            return response;
        }
        private void updateInformations_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            string imageUploadResult = string.Empty;
            string informationUpdateResult = string.Empty;
            if (chosenProfilePicture != string.Empty || FieldValidation() == true)
            {
                if (chosenProfilePicture != string.Empty)
                {
                    imageUploadResult = sendNewProfilePictureViaFtp(chosenProfilePicture);
                    chosenProfilePicture = string.Empty;
                }
                if (FieldValidation() == true)
                {
                    informationUpdateResult = InformationUpdate();
                    LoginWindow._userEntity.Ad = nameTextBox.Text;
                    LoginWindow._userEntity.Soyad = surnameTextBox.Text;
                    LoginWindow._userEntity.Tcno = tcnoTextBox.Text;
                    LoginWindow._userEntity.Mail = mailTextBox.Text;
                    LoginWindow._userEntity.PhoneNumber = phoneTextBox.Text;
                    LoginWindow._userEntity.Address = addressTextBox.Text;
                    LabelUpdate();
                }
                msg = (imageUploadResult + "\n" + informationUpdateResult).Trim();
            }
            else
            {
                msg = "Değişiklik Yapmadınız";
            }
            InfoMessage infoMessage = new InfoMessage(msg, "Bilgi");
            infoMessage.ShowDialog();
        }
        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            guna2TextBox1.BorderColor = Color.FromArgb(46, 46, 46);
        }

        private void addressTextBox_Enter(object sender, EventArgs e)
        {
            guna2TextBox1.BorderColor = Color.Red;
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
