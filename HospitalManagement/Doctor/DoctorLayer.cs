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

namespace HospitalManagement.Doctor
{
    public partial class DoctorLayer : Form
    {
        private BlSecretary blSecretary;
        private DataTable appointments;
        public DoctorLayer()
        {
            blSecretary = new BlSecretary();
            InitializeComponent();
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

        }

        private void refreshDgvButton_Click(object sender, EventArgs e)
        {
            updateDgv();
        }
    }
}
