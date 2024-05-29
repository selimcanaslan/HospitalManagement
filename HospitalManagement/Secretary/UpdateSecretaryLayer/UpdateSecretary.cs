using BusinessLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using HospitalManagement.Dialog;

namespace HospitalManagement.Secretary.UpdateSecretaryLayer
{
    public partial class UpdateSecretary : Form
    {
        FTPHelper ftpHelper = new FTPHelper();
        DataTable secretaryToUpdate = new DataTable();
        string secretaryProfilePicture = "";
        public UpdateSecretary()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            secretaryTcnoTextBox.MaxLength = 11;
            secretaryToUpdate = null;
        }

        private void secretaryTcnoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            FTPHelper fTPHelper = new FTPHelper();
            string result = fTPHelper.Upload(new MemoryStream(data), $"profilePictures/Secretary/{userName}.jpeg");
            InfoMessage infoMessage = new InfoMessage(result, "Bilgi");
            infoMessage.ShowDialog();
        }

        private void uploadProfilePicture_Click(object sender, EventArgs e)
        {
            if (secretaryToUpdate == null)
            {
                InfoMessage infoMessage = new InfoMessage("Henüz Arama Yapmadınız!", "Hata");
                infoMessage.ShowDialog();
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.FileName = "Image Files (JPG,PNG,GIF) | *.JPG;*.PNG;*.GIF";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var size = new FileInfo(ofd.FileName).Length;
                    if (size < 120000)
                    {
                        profilePicture.Image = Image.FromFile(ofd.FileName);
                        secretaryProfilePicture = ofd.FileName;
                    }
                    else
                    {
                        InfoMessage infoMessage = new InfoMessage("Dosya Boyutu 120Kb'dan Fazla Olamaz!", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                }
            }
        }
        public void LoadProfilePicture(string fileName)
        {
            bool existence = ftpHelper.CheckFileExistence(fileName);
            if (existence)
            {
                profilePicture.LoadAsync($"http://sca.somee.com/{fileName}");
            }
            else
            {
                InfoMessage infoMessage = new InfoMessage("Sekreter Profil Fotoğrafı Eklenmemiş!\nEn kısa zamanda ekleyiniz!", "Hata");
                infoMessage.ShowDialog();
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secretaryTcnoTextBox.Text) == false)
            {
                if (secretaryTcnoTextBox.Text.Length == 11)
                {
                    BlSecretary blSecretary = new BlSecretary();
                    secretaryToUpdate = blSecretary.fetchSecretaryByGivenTcNo(secretaryTcnoTextBox.Text);
                    if(secretaryToUpdate.Rows.Count > 0)
                    {
                        fillFields(secretaryToUpdate);
                        string userName = blSecretary.lowercasedAndTrimmedNameSurname(secretaryTcnoTextBox.Text);
                        LoadProfilePicture("profilePictures/Secretary/" + userName + ".jpeg");
                        InfoMessage infoMessage = new InfoMessage("Bilgiler Başarıyla Getirildi!", "Bilgi");
                        infoMessage.ShowDialog();
                        uploadProfilePicture.Enabled = true;
                    }
                    else
                    {
                        InfoMessage infoMessage = new InfoMessage("Belirtilen T.C. No ile sekreter bulunamadı!", "Hata");
                        infoMessage.ShowDialog();
                    }
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

        private void fillFields(DataTable secretaryToUpdate)
        {
            foreach (DataRow dr in secretaryToUpdate.Rows)
            {
                nameTextBox.Text = dr["name"].ToString();
                surnameTextBox.Text = dr["surname"].ToString();
                tcnoTextBox.Text = dr["tc_no"].ToString();
                mailTextBox.Text = dr["mail"].ToString();
                phoneTextBox.Text = dr["phone_number"].ToString();
                addressTextBox.Text = dr["address"].ToString();
            }

        }

        private void updateInformations_Click(object sender, EventArgs e)
        {
            if (secretaryToUpdate != null)
            {
                string name = nameTextBox.Text;
                string surname = surnameTextBox.Text;
                string tcno = tcnoTextBox.Text;
                string mail = mailTextBox.Text;
                string phone = phoneTextBox.Text;
                string address = addressTextBox.Text;
                if (name != secretaryToUpdate.Rows[0]["name"].ToString() ||
                    surname != secretaryToUpdate.Rows[0]["surname"].ToString() ||
                    tcno != secretaryToUpdate.Rows[0]["tc_no"].ToString() ||
                    mail != secretaryToUpdate.Rows[0]["mail"].ToString() ||
                    phone != secretaryToUpdate.Rows[0]["phone_number"].ToString() ||
                    address != secretaryToUpdate.Rows[0]["address"].ToString() ||
                    secretaryProfilePicture != "")
                {
                    if (secretaryProfilePicture != "")
                    {
                        sendNewProfilePictureViaFtp(secretaryProfilePicture, (name + surname).ToLower().Replace(" ", ""));
                        secretaryProfilePicture = "";
                    }
                    if (name != secretaryToUpdate.Rows[0]["name"].ToString() ||
                            surname != secretaryToUpdate.Rows[0]["surname"].ToString())
                    {
                        FtpWebRequest ftpRequest = null;
                        FtpWebResponse ftpResponse = null;
                        try
                        {
                            string newFileName = $"{(nameTextBox.Text + surnameTextBox.Text).ToLower().Replace(" ", "")}.jpeg";
                            ftpRequest = (FtpWebRequest)WebRequest.Create($"\tftp://155.254.244.38/www.sca.somee.com/profilePictures/Secretary/{(secretaryToUpdate.Rows[0]["name"].ToString() + secretaryToUpdate.Rows[0]["surname"].ToString()).ToLower().Replace(" ", "")}.jpeg");
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
                    bool response = blSecretary.updateSecretary(name, surname, tcno, mail, phone, address, Convert.ToInt16(secretaryToUpdate.Rows[0]["id"]));
                    if (response)
                    {
                        secretaryToUpdate.Clear();
                        secretaryToUpdate = blSecretary.fetchSecretaryByGivenTcNo(secretaryTcnoTextBox.Text);
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
                    
                    InfoMessage infoMessage = new InfoMessage("Değişiklik Yapmadınız", "Bilgi");
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
