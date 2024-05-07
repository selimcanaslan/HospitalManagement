using BusinessLayer;
using HospitalManagement.Dialog;
using HospitalManagement.Secretary.PatientEditLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Secretary.PatientFeaturesLayer
{
    public partial class PatientFeatures : Form
    {
        private BlSecretary blSecretary;
        public PatientFeatures()
        {
            InitializeComponent();
            blSecretary = new BlSecretary();
            updateDgv();
            dgvPatient.Columns["tc_no"].HeaderText = "T.C No";
            dgvPatient.Columns["full_name"].HeaderText = "Ad";
            dgvPatient.Columns["mail"].HeaderText = "Mail";
            dgvPatient.Columns["phone_number"].HeaderText = "Telefon";
            dgvPatient.Columns["address"].HeaderText = "Adres";
            dgvPatient.Columns["registiration_date"].HeaderText = "Kayıt Tarihi";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dgvPatient.DataSource = blSecretary.FetchPatientBytcNoForDeleteAndUpdate(patientTcNoTextBox.Text);
        }
        private void updateDgv()
        {
            dgvPatient.DataSource = blSecretary.FetchAllPatients();
        }

        private void dgvPatient_Click(object sender, EventArgs e)
        {
            if (dgvPatient.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPatient.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dgvPatient.Rows[selectedrowindex];
                OptionDialog optionDialog = new OptionDialog("Düzenle - Sil", "Hastayı düzenlemek mi silmek mi istersiniz?", "Düzenle", "Sil");
                optionDialog.ShowDialog();
                string response = OptionDialog.response;
                if (response == "edit")
                {
                    PatientEdit patientEdit = new PatientEdit(Convert.ToString(selectedRow.Cells["tc_no"].Value));
                    patientEdit.ShowDialog();
                    if (PatientEdit.confirmButtonResponse == "OK")
                    {
                        updateDgv();
                        InfoMessage infoMessage = new InfoMessage("Hasta Bilgileri Başarıyla Düzenlendi!", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                    else if (PatientEdit.confirmButtonResponse == "nonEdited")
                    {
                        return;
                    }
                    else
                    {
                        InfoMessage infoMessage = new InfoMessage("Hasta Düzenlenirken Hata!", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                }
                else if (response == "delete")
                {
                    bool deleteResponse = blSecretary.DeletePatientByTcNo(Convert.ToString(selectedRow.Cells["tc_no"].Value));
                    if (deleteResponse)
                    {
                        updateDgv();
                        InfoMessage infoMessage = new InfoMessage("Hasta Başarıyla Silindi!", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                    else
                    {
                        InfoMessage infoMessage = new InfoMessage("Hasta Silinirken Hata!", "Bilgi");
                        infoMessage.ShowDialog();
                    }
                }
            }
        }
    }
}
