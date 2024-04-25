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
            updateDgv();
            dgvSecretary.Columns["tc_no"].HeaderText = "T.C No";
            dgvSecretary.Columns["name"].HeaderText = "Ad";
            dgvSecretary.Columns["surname"].HeaderText = "Soyad";
            dgvSecretary.Columns["mail"].HeaderText = "Mail";
            dgvSecretary.Columns["phone_number"].HeaderText = "Telefon";
            dgvSecretary.Columns["address"].HeaderText = "Adres";
        }
        private void updateDgv()
        {
            dgvSecretary.DataSource = _blSecretary.fetchAllSecretary();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string name = secretaryNameTextBox.Text;
            if (name != "")
            {
                DataTable dt = new DataTable();
                dt = _blSecretary.fetchSecretaryByGivenName(name);
                if (dt.Rows.Count > 0)
                {
                    dgvSecretary.DataSource = dt;
                    MessageBox.Show("Eşleşen Kayıtlar Getirildi!");
                    secretaryNameTextBox.Focus();

                }
                else
                {
                    MessageBox.Show("Girdiğiniz İsimde Sekreter Bulunamadı!\nSekreter adını doğru yazdığınıza emin olun!\nAd, Soyad arasında boşluk bıraktığınıza emin olun!", "Kullanıcı Bulunamadı");
                    secretaryNameTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Aranacak İsmi Giriniz.");
                secretaryNameTextBox.Focus();
            }


        }

        private void dgvSecretary_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSecretary.SelectedCells.Count > 0)
            {
                try
                {
                    int selectedrowindex = dgvSecretary.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dgvSecretary.Rows[selectedrowindex];
                    string tam_ad = Convert.ToString(selectedRow.Cells["name"].Value) + " " +
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
                            MessageBox.Show("Kayıt Silinirken Bir Hata İle Karşılaşıldı", "Bilgi"); ;
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
    }
}
