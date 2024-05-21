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
using HospitalManagement.Dialog;
using HospitalManagement.Secretary;
using HospitalManagement.Secretary.AccountLayer;
using HospitalManagement.Doctor.DocAccountLayer;
using HospitalManagement.Doctor.PrescriptionLayer;
using static System.Collections.Specialized.BitVector32;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp;
using System.Drawing.Imaging;
using Org.BouncyCastle.Asn1.Pkcs;

namespace HospitalManagement.Doctor
{
    public partial class DoctorLayer : Form
    {
        FTPHelper ftpHelper = new FTPHelper();
        private BlDoctor blDoctor;
        private DataTable appointments;
        public DoctorLayer(string loginType)
        {
            blDoctor = new BlDoctor();
            InitializeComponent();
            this.windowName.Text = "Hastane Yönetim Sistemi" + " / " + loginType.ToUpper() + " / " + LoginWindow._userEntity.Ad + " " + LoginWindow._userEntity.Soyad;
            CenterToParent();
            updateDgv();
        }
        private void updateDgv()
        {
            appointments = new DataTable();
            Console.WriteLine(LoginWindow._userEntity.Tcno);
            appointments = blDoctor.FetchAllAwaitingAppointmentsFilteredByDoctorTcNo(LoginWindow._userEntity.Tcno);
            if (appointments.Rows.Count > 0)
            {
                dgvAwaitingAppointments.DataSource = appointments;
                dgvAwaitingAppointments.Columns["patient_name"].HeaderText = "Hasta Ad";
                dgvAwaitingAppointments.Columns["patient_tc_no"].HeaderText = "Hasta T.C";
                dgvAwaitingAppointments.Columns["section"].HeaderText = "Bölüm";
                dgvAwaitingAppointments.Columns["examination_time"].HeaderText = "Muayene Tarihi";
                dgvAwaitingAppointments.Columns["examination_hour"].HeaderText = "Muayene Saati";
                noAppointmentLabel.Visible = false;
                refreshDgvButton.Visible = false;
            }
            else
            {
                noAppointmentLabel.Visible = true;
                refreshDgvButton.Visible = true;
            }
        }
        private void DoctorLayer_Load(object sender, EventArgs e)
        {
            LoadProfilePicture("profilePictures/Doctor/" + LoginWindow._userEntity.KullaniciAd + ".jpeg");

        }
        public void LoadProfilePicture(string fileName)
        {
            bool existence = ftpHelper.CheckFileExistence(fileName);
            if (existence)
            {
                profilePicture.LoadAsync($"http://sca.somee.com/{fileName}");
            }
        }
        private void refreshDgvButton_Click(object sender, EventArgs e)
        {
            updateDgv();
        }

        private void dgvAwaitingAppointments_Click(object sender, EventArgs e)
        {
            if (dgvAwaitingAppointments.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAwaitingAppointments.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dgvAwaitingAppointments.Rows[selectedrowindex];
                DataTable chosenAppointmentPatient = blDoctor.FetchPatientBytcNo(Convert.ToString(selectedRow.Cells["patient_tc_no"].Value));
                foreach (DataRow row in chosenAppointmentPatient.Rows)
                {
                    nameTextBox.Text = row["name"].ToString();
                    surnameTextBox.Text = row["surname"].ToString();
                    tcnoTextBox.Text = row["tc_no"].ToString();
                    mailTextBox.Text = row["mail"].ToString();
                    phoneTextBox.Text = row["phone_number"].ToString();
                    addressTextBox.Text = row["address"].ToString();
                }
                InfoMessage infoMessage = new InfoMessage("Hasta bilgileri Getirildi!", "Bilgi");
                infoMessage.ShowDialog();
            }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            DocAccount account = new DocAccount();
            account.ShowDialog();
        }

        private void sendAppointmentDetailsToPatientViaMail_Click(object sender, EventArgs e)
        {
            string patientName = $"{nameTextBox.Text + " " + surnameTextBox.Text}";
            string doctorName = LoginWindow._userEntity.Ad + " " + LoginWindow._userEntity.Soyad;
            string mailAddress = $"{mailTextBox.Text}";
            string appointmentDataAndHour = $"{appointments.Rows[0]["examination_time"]} - {appointments.Rows[0]["examination_hour"]}";
            string section = $"{appointments.Rows[0]["section"]}";
            string title = $"{appointments.Rows[0]["examination_time"]} Tarihli Muayene Özetiniz";
            Prescription prescription = new Prescription(title, patientName, doctorName, mailAddress, appointmentDataAndHour, section);
            prescription.ShowDialog();
        }

        private void exportPdfButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.FileName = $"{tcnoTextBox.Text}";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                CreatePDF(saveFileDialog.FileName);
            }
        }
        private void CreatePDF(string filePath)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            page.Size = PageSize.A4;
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XBrush brush = XBrushes.White;
            XFont font = new XFont("Arial", 16);

            CreateTopAndBackground(page, gfx);

            gfx.DrawString($"{appointments.Rows[0]["examination_time"]} - {appointments.Rows[0]["examination_hour"]} Tarihli Muayene Özetiniz".ToUpper(), new XFont("Arial", 20), brush, new XRect(10, page.Height / 10 + 10, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString($"Hasta Adı : {nameTextBox.Text + " " + surnameTextBox.Text}", font, brush, new XRect(20, page.Height / 10 + 40, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Hasta TCNO : {tcnoTextBox.Text}", font, brush, new XRect(20, page.Height / 10 + 60, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Hasta Mail : {mailTextBox.Text}", font, brush, new XRect(20, page.Height / 10 + 80, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Hasta Adres : {addressTextBox.Text}", font, brush, new XRect(20, page.Height / 10 + 100, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Doktor Adı : {LoginWindow._userEntity.Ad + " " + LoginWindow._userEntity.Soyad}", font, brush, new XRect(20, page.Height / 10 + 120, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Bölüm : {appointments.Rows[0]["section"]}", font, brush, new XRect(20, page.Height / 10 + 140, page.Width, page.Height), XStringFormats.TopLeft);

            //Footer
            gfx.DrawString("selim hastanesi since 1911 - www.seliminhastanesi.com - 444 0 444", new XFont("Arial", 12), brush, new XRect(100, page.Height / 10 + 730, page.Width, page.Height), XStringFormats.TopLeft);
            try
            {
                document.Save(filePath);
                InfoMessage infoMessage = new InfoMessage("Muayene Özeti PDF'i Başarıyla Oluşturuldu!","Bilgi");
                infoMessage.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }
        private void CreateTopAndBackground(PdfPage page, XGraphics gfx)
        {
            //BannerBG
            Bitmap imageFromResources = Properties.Resources.banner_bg;
            string tempImagePath = Path.GetTempFileName() + ".png";
            imageFromResources.Save(tempImagePath, ImageFormat.Png);
            XImage image = XImage.FromFile(tempImagePath);
            gfx.DrawImage(image, 0, 0, page.Width, page.Height / 10);
            //Background
            Bitmap imageFromResources2 = Properties.Resources.bg;
            string tempImagePath2 = Path.GetTempFileName() + ".png";
            imageFromResources2.Save(tempImagePath2, ImageFormat.Png);
            XImage image2 = XImage.FromFile(tempImagePath2);
            gfx.DrawImage(image2, 0, page.Height / 10, page.Width, page.Height * 0.9);
            //Medical-Team Picture
            Bitmap imageFromResources3 = Properties.Resources.medical_team;
            string tempImagePath3 = Path.GetTempFileName() + ".png";
            imageFromResources3.Save(tempImagePath3, ImageFormat.Png);
            XImage image3 = XImage.FromFile(tempImagePath3);
            gfx.DrawImage(image3, 10, 10, 66, 66);
            //OverBanner
            Bitmap imageFromResources4 = Properties.Resources.over_banner;
            string tempImagePath4 = Path.GetTempFileName() + ".png";
            imageFromResources4.Save(tempImagePath4, ImageFormat.Png);
            XImage image4 = XImage.FromFile(tempImagePath4);
            gfx.DrawImage(image4, 90, 0, 480, 80);
        }
    }
}