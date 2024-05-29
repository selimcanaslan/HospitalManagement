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
using System.Windows.Forms;

namespace HospitalManagement.Login
{
    public partial class ForgotPassword : Form
    {
        private string userType;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                userType = "Doctor";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                userType = "Secretary";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked) 
            {
                if (string.IsNullOrEmpty(mailTextBox.Text))
                {
                    InfoMessage infoMessage = new InfoMessage("Lütfen Mail Adresinizi Boş Bırakmayınız!", "Bilgi");
                    infoMessage.ShowDialog();
                }
                else
                {
                    DataTable password = new DataTable();
                    BlUserLogin blUserLogin = new BlUserLogin();
                    password = blUserLogin.FetchUserPassword(mailTextBox.Text, userType);
                    if (password.Rows.Count > 0)
                    {
                        sendUserNamePasswordToMailAddress(password.Rows[0]["password"].ToString(), mailTextBox.Text);
                        InfoMessage infoMessage = new InfoMessage("Şifreniz Mail Adresinize Gönderildi!", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                    else
                    {
                        InfoMessage infoMessage = new InfoMessage("Girdiğiniz Kullanıcı Tipi ve Mail Adresi İle Kullanıcı Bulunamadı!", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                }
            }
            else
            {
                InfoMessage infoMessage = new InfoMessage("Lütfen Kullanıcı Tipi Seçiniz!", "Bilgi");
                infoMessage.ShowDialog();
            }
        }
        private void sendUserNamePasswordToMailAddress(string password, string mailAddress)
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
                    Subject = $"Hastane Yönetimi {userType} Şifreniz",
                    Body = $"<h1>Şifreniz : {password} </h1>",
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
