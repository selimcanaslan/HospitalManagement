using BusinessLayer;
using HospitalManagement.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Secretary.AppointmentsLayer
{
    public partial class Appointments : Form
    {
        private BlSecretary _blSecretary;
        public Appointments()
        {
            InitializeComponent();
            _blSecretary = new BlSecretary();
            dateTimePicker.Value = DateTime.Today;
            updateDgv();
            dgvAppointment.Columns["patient_name"].HeaderText = "Hasta Ad";
            dgvAppointment.Columns["patient_tc_no"].HeaderText = "Hasta T.C";
            dgvAppointment.Columns["section"].HeaderText = "Bölüm";
            dgvAppointment.Columns["doctor_name"].HeaderText = "Doktor Ad";
            dgvAppointment.Columns["examination_time"].HeaderText = "Muayene Tarihi";
            dgvAppointment.Columns["examination_hour"].HeaderText = "Muayene Saati";
            //dgvAppointment.Columns["is_examination_done"].HeaderText = "Gerçekleşti mi?";
            //dgvAppointment.Columns["appointment_created"].HeaderText = "Oluşturulma Tarihi";
        }
        private void updateDgv()
        {
            if (dgvAppointment.Rows.Count > 0)
            {
                dgvAppointment.Rows.Clear();
            }
            else
            {
                dgvAppointment.DataSource = _blSecretary.fetchAllAwaitingAppointments();
            }
        }

        private void fetchAppointments_Click(object sender, EventArgs e)
        {
            if (dateIncludeCheckBox.Checked == true)
            {
                if (tcNoTextBox.Text.Length == 11)
                {
                    DataTable source = new DataTable();
                    source = _blSecretary.FetchAwaitingAppointmentsFilteredByDateAndTcNo(tcNoTextBox.Text, dateTimePicker.Value.ToString("yyyy-MM-dd"));
                    if (source.Rows.Count > 0)
                    {
                        dgvAppointment.DataSource = source;
                        InfoMessage infoMessage = new InfoMessage($"'{dateTimePicker.Value.ToString("yyyy-MM-dd")}' Tarihli ve '{tcNoTextBox.Text}' TCNO'lu Randevular Getirildi!", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                    else
                    {
                        InfoMessage infoMessage = new InfoMessage($"'{dateTimePicker.Value.ToString("yyyy-MM-dd")}' Tarihli ve '{tcNoTextBox.Text}' TCNO'lu Randevu Bulunamadı!", "Bilgi");
                        infoMessage.ShowDialog();
                    }    
                }
                else if (string.IsNullOrEmpty(tcNoTextBox.Text))
                {
                    DataTable source = new DataTable();
                    source = _blSecretary.FetchAwaitingAppointmentsFilteredByDate(dateTimePicker.Value.ToString("yyyy-MM-dd"));
                    if (source.Rows.Count > 0)
                    {
                        dgvAppointment.DataSource = source;
                        InfoMessage infoMessage = new InfoMessage($"{dateTimePicker.Value.ToString("yyyy-MM-dd")} Tarihli Randevular Getirildi!", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                    else
                    {
                        InfoMessage infoMessage = new InfoMessage($"{dateTimePicker.Value.ToString("yyyy-MM-dd")} Tarihli Randevu Bulunamadı!", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                }
            }
            else
            {

            }
        }
    }
}
