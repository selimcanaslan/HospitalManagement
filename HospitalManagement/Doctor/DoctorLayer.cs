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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using HospitalManagement.Dialog;
using iText.Kernel.Pdf.Canvas.Parser.ClipperLib;
using HospitalManagement.Secretary;
using HospitalManagement.Secretary.AccountLayer;
using HospitalManagement.Doctor.DocAccountLayer;

namespace HospitalManagement.Doctor
{
    public partial class DoctorLayer : Form
    {
        FTPHelper ftpHelper = new FTPHelper();
        private BlSecretary blSecretary;
        private DataTable appointments;
        public DoctorLayer(string loginType)
        {
            blSecretary = new BlSecretary();
            InitializeComponent();
            this.windowName.Text = "Hastane Yönetim Sistemi" + " / " + loginType.ToUpper() + " / " + LoginWindow._userEntity.Ad + " " + LoginWindow._userEntity.Soyad;
            CenterToParent();
            updateDgv();
        }
        private void updateDgv()
        {
            appointments = new DataTable();
            Console.WriteLine(LoginWindow._userEntity.Tcno);
            appointments = blSecretary.FetchAllAwaitingAppointmentsFilteredByDoctorTcNo(LoginWindow._userEntity.Tcno);
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
                DataTable chosenAppointmentPatient = blSecretary.FetchPatientBytcNo(Convert.ToString(selectedRow.Cells["patient_tc_no"].Value));
                foreach(DataRow row in chosenAppointmentPatient.Rows)
                {
                    nameTextBox.Text = row["name"].ToString();
                    surnameTextBox.Text = row["surname"].ToString();
                    tcnoTextBox.Text = row["tc_no"].ToString();
                    mailTextBox.Text = row["mail"].ToString();
                    phoneTextBox.Text = row["phone_number"].ToString();
                    addressTextBox.Text = row["address"].ToString();
                }
            }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            DocAccount account = new DocAccount();
            account.ShowDialog();
        }
    }
}