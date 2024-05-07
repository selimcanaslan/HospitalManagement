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
        private DataTable awaitingAppointments;
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
            updateDgv();
            //dgvAppointment.Columns["is_examination_done"].HeaderText = "Gerçekleşti mi?";
            //dgvAppointment.Columns["appointment_created"].HeaderText = "Oluşturulma Tarihi";
        }
        private void updateDgv()
        {
            awaitingAppointments = new DataTable();
            awaitingAppointments = _blSecretary.fetchAllAwaitingAppointments();
            dgvAppointment.DataSource = awaitingAppointments;
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

        private void dgvAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointment.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAppointment.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dgvAppointment.Rows[selectedrowindex];
                string patientTc = Convert.ToString(selectedRow.Cells["patient_tc_no"].Value);
                string examinationTime = Convert.ToString(selectedRow.Cells["examination_time"].Value);
                string examinationHour = Convert.ToString(selectedRow.Cells["examination_hour"].Value);
                DialogResult dialogResult = MessageBox.Show("Muayene'yi tamamlandı olarak işaretlemek istediğine emin misin ?", "Onayla", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = -1;
                    bool response = false;
                    foreach (DataRow row in awaitingAppointments.Rows)
                    {
                        if (patientTc == row["patient_tc_no"].ToString() &&
                            examinationTime == row["examination_time"].ToString() &&
                            examinationHour == row["examination_hour"].ToString())
                        {
                            id = Int16.Parse(row["id"].ToString());
                        }
                    }
                    if (id != -1)
                    {
                        response = _blSecretary.updateAppointmentState(id);
                    }
                    if (response)
                    {
                        InfoMessage infoMessage = new InfoMessage("Muayene tamamlandı olarak işaretlendi!", "Bilgi");
                        infoMessage.ShowDialog(); updateDgv();
                    }
                    else
                    {
                        InfoMessage infoMessage = new InfoMessage("Hata!", "Bilgi");
                        infoMessage.ShowDialog(); updateDgv();

                    }
                }
            }
        }
    }
}
