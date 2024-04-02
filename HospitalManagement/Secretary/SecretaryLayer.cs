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

namespace HospitalManagement.Secretary
{
    public partial class SecretaryLayer : Form
    {
        public SecretaryLayer(String loginType)
        {
            InitializeComponent();
            this.Text = loginType.ToUpper();
        }

        private void SecretaryLayer_Load(object sender, EventArgs e)
        {
            CenterToParent();
            panelVisibilityInitialize();
        }

        private void add_new_doctor_button_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.Show();
        }

        private void add_new_secretary_button_Click(object sender, EventArgs e)
        {
            AddSecretary addSecretary = new AddSecretary();
            addSecretary.Show();
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(patientButtonSubMenu);
        }

        private void panelVisibilityInitialize()
        {
            patientButtonSubMenu.Visible = false;
            secretaryButtonSubMenu.Visible = false;
            doctorButtonSubMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (patientButtonSubMenu.Visible == true) { patientButtonSubMenu.Visible=false; }
            if (secretaryButtonSubMenu.Visible == true) { secretaryButtonSubMenu.Visible=false; }
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
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(childForm);
            containerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void addNewSecretaryButton_Click(object sender, EventArgs e)
        {
            openChildForm(new AddSecretary());
        }

        private void addNewDoctorButton_Click(object sender, EventArgs e)
        {
            openChildForm(new AddDoctor());
        }
    }
}
