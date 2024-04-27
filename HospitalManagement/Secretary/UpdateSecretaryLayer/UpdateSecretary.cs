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

namespace HospitalManagement.Secretary.UpdateSecretaryLayer
{
    public partial class UpdateSecretary : Form
    {
        DataTable secretaryToUpdate = new DataTable();
        string secretaryProfilePicture = "";
        public UpdateSecretary()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            secretaryTcnoTextBox.MaxLength = 11;
            secretaryToUpdate = null;
            uploadProfilePicture.Enabled = false;
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
                secretaryProfilePicture = ofd.FileName;
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
                    fillFields(secretaryToUpdate);
                    string userName = blSecretary.lowercasedAndTrimmedNameSurname(secretaryTcnoTextBox.Text);
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
                            ftpRequest = (FtpWebRequest)WebRequest.Create($"ftp://sca.somee.com/www.sca.somee.com/profilePictures/{(secretaryToUpdate.Rows[0]["name"].ToString() + secretaryToUpdate.Rows[0]["surname"].ToString()).ToLower().Replace(" ", "")}.jpeg");
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
