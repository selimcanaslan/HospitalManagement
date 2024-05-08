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
using HospitalManagement.Dialog;

namespace HospitalManagement.Doctor.PrescriptionLayer
{
    public partial class Prescription : Form
    {
        private string title, patientName, doctorName, mailAddress, appointmentDateAndHour, section;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sendPrescriptionToMailAddress();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Prescription(string title, string patientName,
            string doctorName, string mailAddress, string appointmentDateAndHour,
            string section)
        {
            this.title = title;
            this.patientName = patientName;
            this.doctorName = doctorName;
            this.mailAddress = mailAddress; 
            this.appointmentDateAndHour = appointmentDateAndHour;
            this.section = section;
            InitializeComponent();
            FillTextBoxes();
        }
        private void FillTextBoxes()
        {
            patientNameTextBox.Text = patientName;
            doctorNameTextBox.Text = doctorName;
            mailAddressTextBox.Text = mailAddress;
            sectionTextBox.Text = section;
        }
        private void Prescription_Load(object sender, EventArgs e)
        {

        }

        private void sendPrescriptionToMailAddress()
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("selimcanaslan33@gmail.com", "awzc nxve hnwo sxkj"),
                    EnableSsl = true,
                };
                string body = bodyTextBox.Text;
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("selimcanaslan33@gmail.com"),
                    Subject = title,
                    Body = $"<h1>Randevu Özetiniz;</h1>" +
                    $"<h4>Hasta Adı : {patientName}</h4>" +
                    $"<h4>Doktor Adı : {doctorName}</h4>" +
                    $"<h4>Bölüm : {section}</h4>"+
                    $"<h4>Muayene Tarihi ve Saati: {appointmentDateAndHour}</h4>"+
                    $"<p>{body}</p>",
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(mailAddressTextBox.Text);
                if (!string.IsNullOrEmpty(body))
                {
                    if (mailAddressTextBox.Text.EndsWith("@outlook.com") ||
                        mailAddressTextBox.Text.EndsWith("@gmail.com") ||
                        mailAddressTextBox.Text.EndsWith("@hotmail.com") ||
                        mailAddressTextBox.Text.EndsWith("@icloud.com"))
                    {
                        smtpClient.SendMailAsync(mailMessage);
                        InfoMessage infoMessage = new InfoMessage($"Muayene Özeti {mailAddressTextBox.Text} Adresine Başarıyla Gönderildi!", "Bilgi");
                        infoMessage.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        InfoMessage infoMessage = new InfoMessage("Mail Adresiniz Aşağıdakilerden biriyle bitmelidir.\n" +
                            "1-@outlook.com  2-@gmail.com\n3-@hotmail.com  4-@icloud.com", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                }
                else
                {
                    InfoMessage infoMessage = new InfoMessage("Lütfen Mail İçeriğini Boş Bırakmayınız!", "Bilgi");
                    infoMessage.ShowDialog();
                }
                
            }
            catch (SmtpException e)
            {
                Console.WriteLine("Error: {0}", e.StatusCode);
            }

        }
    }
}
