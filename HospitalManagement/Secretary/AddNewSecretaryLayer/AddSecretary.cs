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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace HospitalManagement.Secretary.AddNewSecretaryLayer
{
    public partial class AddSecretary : Form
    {
        string err_message = "";
        string importedProfilePicture = "";
        string lowercasedAndTrimmedNameSurname = "";
        public AddSecretary()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            tcnoTextBox.MaxLength = 11;
            phoneTextBox.MaxLength = 10;
        }

        private void AddSecretary_Load(object sender, EventArgs e)
        {
            CenterToParent();
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

        private bool fieldValidation()
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(surnameTextBox.Text) || string.IsNullOrWhiteSpace(mailTextBox.Text)
                || string.IsNullOrWhiteSpace(phoneTextBox.Text) || string.IsNullOrWhiteSpace(addressTextBox.Text) || string.IsNullOrWhiteSpace(tcnoTextBox.Text))
            { err_message += "Lütfen hiçbir alanı boş bırakmayınız!\n"; }
            if (mailTextBox.Text.Length > 0 &&
                mailTextBox.Text.EndsWith("@gmail.com") == false &&
                mailTextBox.Text.EndsWith("@hotmail.com") == false &&
                mailTextBox.Text.EndsWith("@outlook.com") == false)
            {
                err_message += "Mail adresi hotmail, gmail ya da outlook olmalıdır.\n";
            }
            if (phoneTextBox.Text.Length != 10 && phoneTextBox.Text.Length > 0)
            { err_message += "Telefon Numaranız 10 Haneden Oluşmalıdır!\n"; }

            if (phoneTextBox.Text.StartsWith("0"))
            {
                err_message += "Lütfen Telefon numaranızı başında 0 olmadan giriniz.\n";
            }
            if (tcnoTextBox.Text.StartsWith("0"))
            {
                err_message += "TC.No Sıfır (0) ile başlayamaz.";
            }

            if (err_message != "")
            {
                return false;
            }
            else { return true; }
        }
        private void sendUserNamePasswordToMailAddress(string usernameAndPassword, string mailAddress)
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
                    Subject = "Giriş Bilgileriniz",
                    Body = "<h1>Bilgileriniz Aşağıda Gösterilmektedir</h1>" +
                    "<h2>Şifrenizi Uygulama Üzerinden Oturum Açarak Değiştirebilirsiniz</h2>" +
                    "<p>Kullanıcı Adı: " + usernameAndPassword + "</p>" +
                    "<p>Şifre :" + usernameAndPassword + "</p>",
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

        private void registerButton_Click(object sender, EventArgs e)
        {

            if (fieldValidation() == true)
            {
                lowercasedAndTrimmedNameSurname = nameTextBox.Text.ToLower().Trim() + surnameTextBox.Text.ToLower().Trim();
                BlSecretary blSecretary = new BlSecretary();
                bool response = blSecretary.AddSecretary(tcnoTextBox.Text, nameTextBox.Text, surnameTextBox.Text,
                    mailTextBox.Text, phoneTextBox.Text, addressTextBox.Text);
                if (response)
                {
                    string uploadResult = sendNewProfilePictureViaFtp(importedProfilePicture);
                    string name = nameTextBox.Text.ToString().Trim();
                    string userNameAndPassword = (name + surnameTextBox.Text).ToLower();
                    sendUserNamePasswordToMailAddress(userNameAndPassword, mailTextBox.Text);
                    MessageBox.Show("Sekreter Kaydı Başarıyla Oluşturuldu!\n" + uploadResult +
                        "\nGiriş Bilgileri Mail Adresine Gönderildi!");

                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız!\n" +
                    "Sistem Yöneticinize Ulaşın!");
                }
            }
            else
            {
                MessageBox.Show(err_message, "Hata!");
                err_message = string.Empty;
            }

        }
        private string sendNewProfilePictureViaFtp(string imagePath, string identifier = "")
        {

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
            string imageUploadresult = fTPHelper.Upload(new MemoryStream(data), $"profilePictures/{lowercasedAndTrimmedNameSurname}.jpeg");
            return imageUploadresult;
        }

        private void importPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Image Files (JPG,PNG,GIF) | *.JPG;*.PNG;*.GIF";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                profilePicture.Image = Image.FromFile(ofd.FileName);
                importedProfilePicture = ofd.FileName;
            }
        }
    }
}
