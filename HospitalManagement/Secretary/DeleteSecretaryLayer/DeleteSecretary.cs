using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace HospitalManagement.Secretary.DeleteSecretaryLayer
{
    public partial class DeleteSecretary : Form
    {
        private BlSecretary _blSecretary;
        public DeleteSecretary()
        {
            InitializeComponent();
            _blSecretary = new BlSecretary();
            dgvSecretary.DataSource = _blSecretary.fetchAllSecretary();
            dgvSecretary.Columns["id"].HeaderText = "Kayıt numarası";
            dgvSecretary.Columns["name"].HeaderText = "Ad";
            dgvSecretary.Columns["surname"].HeaderText = "Soyad";
            dgvSecretary.Columns["mail"].HeaderText = "Mail";
            dgvSecretary.Columns["phone_number"].HeaderText = "Telefon";
            dgvSecretary.Columns["address"].HeaderText = "Adres";
        }
        private void dgvSecretary_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvSecretary.SelectedCells.Count > 0)
            {
                try
                {
                    int selectedrowindex = dgvSecretary.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dgvSecretary.Rows[selectedrowindex];
                    string tam_ad = Convert.ToString(selectedRow.Cells["name"].Value) +
                        Convert.ToString(selectedRow.Cells["surname"].Value);
                    string mail = Convert.ToString(selectedRow.Cells["mail"].Value);
                    string telefon = Convert.ToString(selectedRow.Cells["phone_number"].Value);

                    string infoOfPersonWhoWillBeDeleted = "Silmek İstediğiniz Kişinin Bilgileri Aşağıdadır.\n" +
                                                            "Ad: " + tam_ad + "\nMail: " + mail + "\nTelefon: " + telefon;
                    DialogResult dialogResult = MessageBox.Show(infoOfPersonWhoWillBeDeleted, "Silmek İstediğize Emin Misiniz?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool response = _blSecretary.deleteSecretary(telefon);
                        if (response) { MessageBox.Show("Kayıt Başarıyla Silindi", "Bilgi"); updateDgv(); }
                        else
                        {
                            MessageBox.Show("Kayıt Silinirken Bir Hata İle Karşılaşıldı", "Bilgi");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                catch
                {
                    return;
                }
            }
        }
        private void updateDgv()
        {
            dgvSecretary.DataSource = _blSecretary.fetchAllSecretary();

        }
    }
}
