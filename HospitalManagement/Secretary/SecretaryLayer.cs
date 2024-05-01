using HospitalManagement.Secretary.AddNewDoctorLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.Secretary.AddNewSecretaryLayer;
using Guna.UI2.WinForms;
using HospitalManagement.Secretary.CreateAppointmentLayer;
using HospitalManagement.Secretary.PatientFeaturesLayer;
using HospitalManagement.Secretary.PatientGraphsLayer;
using HospitalManagement.Secretary.DeleteSecretaryLayer;
using HospitalManagement.Secretary.UpdateSecretaryLayer;
using HospitalManagement.Secretary.DeleteDoctorLayer;
using HospitalManagement.Secretary.UpdateDoctorLayer;
using HospitalManagement.Secretary.AccountLayer;
using HospitalManagement.Login;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Net;
using HospitalManagement.Dialog;
using System.Runtime.CompilerServices;

namespace HospitalManagement.Secretary
{
    public partial class SecretaryLayer : Form
    {
        FTPHelper ftpHelper = new FTPHelper();
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, this.Bounds);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public SecretaryLayer(string loginType)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.windowName.Text = "Hastane Yönetim Sistemi" + " / " + loginType.ToUpper() + " / " + LoginWindow._userEntity.KullaniciAd;
        }

        private void SecretaryLayer_Load(object sender, EventArgs e)
        {
            CenterToParent();
            panelVisibilityInitialize();
            ShowSubMenu(patientButtonSubMenu);
            openChildForm(new Account());
            LoadProfilePicture("profilePictures/Secretary/" + LoginWindow._userEntity.KullaniciAd + ".jpeg");
        }
        public void LoadProfilePicture(string fileName)
        {
            bool existence = ftpHelper.CheckFileExistence(fileName);
            Console.WriteLine(existence);
            if (existence)
            {
                profilePicture.LoadAsync($"http://sca.somee.com/{fileName}");
            }
        }
        private void panelVisibilityInitialize()
        {
            patientButtonSubMenu.Visible = false;
            secretaryButtonSubMenu.Visible = false;
            doctorButtonSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (patientButtonSubMenu.Visible == true) { patientButtonSubMenu.Visible = false; }
            if (secretaryButtonSubMenu.Visible == true) { secretaryButtonSubMenu.Visible = false; }
            if (doctorButtonSubMenu.Visible == true) { doctorButtonSubMenu.Visible = false; }
        }
        private void ShowSubMenu(Guna2Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private void secretaryButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(secretaryButtonSubMenu);
        }

        private void doctorButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(doctorButtonSubMenu);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null && activeForm.GetType() == childForm.GetType())
            {
                return;
            }
            else if (activeForm == null)
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                containerPanel.Controls.Add(childForm);
                containerPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                containerPanel.Controls.Add(childForm);
                containerPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        private void addNewSecretaryButton_Click(object sender, EventArgs e)
        {
            openChildForm(new AddSecretary());
        }

        private void addNewDoctorButton_Click(object sender, EventArgs e)
        {
            openChildForm(new AddDoctor());
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(patientButtonSubMenu);
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            openChildForm(new CreateAppointment());
        }

        private void patientFeaturesButton_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientFeatures());
        }

        private void patientGraphsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientGraphs());
        }

        private void deleteSecretaryButton_Click(object sender, EventArgs e)
        {

            openChildForm(new DeleteSecretary());
        }

        private void updateSecretaryButton_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdateSecretary());
        }

        private void deleteDoctorButton_Click(object sender, EventArgs e)
        {
            openChildForm(new DeleteDoctor());
        }

        private void updateDoctorButton_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdateDoctor());
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Account());
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            openChildForm(new Account());
            
        }

        private void SecretaryLayer_Shown(object sender, EventArgs e)
        {
            Toast toast = new Toast(this, $"Hoşgeldiniz {LoginWindow._userEntity.Ad + " " + LoginWindow._userEntity.Soyad}");
            toast.Show();
        }
    }
}
