using BusinessLayer;
using HospitalManagement.Dialog;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace HospitalManagement.Secretary.DeleteDoctorLayer
{
    public partial class DeleteDoctor : Form
    {
        private BlSecretary _blSecretary;
        public DeleteDoctor()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _blSecretary = new BlSecretary();
            updateDgv();
            dgvDoctor.Columns["tc_no"].HeaderText = "T.C No";
            dgvDoctor.Columns["doctor_name"].HeaderText = "Ad";
            dgvDoctor.Columns["doctor_surname"].HeaderText = "Soyad";
            dgvDoctor.Columns["section_name"].HeaderText = "Bölüm";
            dgvDoctor.Columns["mail"].HeaderText = "Mail";
            dgvDoctor.Columns["phone_number"].HeaderText = "Telefon";
            dgvDoctor.Columns["address"].HeaderText = "Adres";

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string name = doctorNameTextBox.Text;
            if (name != "")
            {
                DataTable dt = new DataTable();
                dt = _blSecretary.fetchDoctorByGivenName(name);
                if (dt.Rows.Count > 0)
                {
                    dgvDoctor.DataSource = dt;
                    InfoMessage infoMessage = new InfoMessage("Eşleşen Kayıtlar Getirildi!", "Bilgi");
                    infoMessage.ShowDialog();

                }
                else
                {
                    InfoMessage infoMessage = new InfoMessage("Girdiğiniz İsimde Doktor Bulunamadı!\nDoktor adını doğru yazdığınıza emin olun!\nAd, Soyad arasında boşluk bıraktığınıza emin olun!", "Kullanıcı Bulunamadı");
                    infoMessage.ShowDialog();
                    doctorNameTextBox.Focus();
                }
            }
            else
            {
                InfoMessage infoMessage = new InfoMessage("Lütfen Aranacak İsmi Giriniz!", "Uyarı");
                infoMessage.ShowDialog();
                doctorNameTextBox.Focus();
            }
        }
        private void updateDgv()
        {
            dgvDoctor.DataSource = _blSecretary.fetchAllDoctor();
        }
        private void dgvDoctor_Click(object sender, EventArgs e)
        {
            if (dgvDoctor.SelectedCells.Count > 0)
            {
                try
                {
                    int selectedrowindex = dgvDoctor.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dgvDoctor.Rows[selectedrowindex];
                    string tam_ad = Convert.ToString(selectedRow.Cells["doctor_name"].Value) + " " +
                    Convert.ToString(selectedRow.Cells["doctor_surname"].Value);
                    string mail = Convert.ToString(selectedRow.Cells["mail"].Value);
                    string telefon = Convert.ToString(selectedRow.Cells["phone_number"].Value);
                    string tc_no = Convert.ToString(selectedRow.Cells["tc_no"].Value);
                    Clipboard.SetText(Convert.ToString(selectedRow.Cells["tc_no"].Value));
                    string infoOfPersonWhoWillBeDeleted = "Silmek İstediğiniz Kişinin Bilgileri Aşağıdadır.\n" +
                                                            "Ad: " + tam_ad + "\nMail: " + mail + "\nTelefon: " + telefon;
                    DialogResult dialogResult = MessageBox.Show(infoOfPersonWhoWillBeDeleted, "Silmek İstediğize Emin Misiniz? (TCNO Kopyalandı!)", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool response = _blSecretary.deleteDoctor(tc_no);
                        if (response)
                        {
                            FtpWebRequest ftpRequest = null;
                            try
                            {
                                ftpRequest = (FtpWebRequest)WebRequest.Create($"\tftp://155.254.244.38/www.sca.somee.com/profilePictures/Doctor/{tam_ad.ToLower().Replace(" ", "")}.jpeg");
                                ftpRequest.Credentials = new NetworkCredential("sca33", "2XFfX2b6xQUTJ-U");
                                ftpRequest.Method = Ftp.DeleteFile;
                                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                                ftpResponse.Close();
                            }
                            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

                            InfoMessage infoMessage = new InfoMessage("Kayıt Başarıyla Silindi", "Bilgi");
                            infoMessage.ShowDialog(); updateDgv();
                        }
                        else
                        {
                            InfoMessage infoMessage = new InfoMessage("Kayıt Silinirken Bir Hata İle Karşılaşıldı", "Bilgi");
                            infoMessage.ShowDialog();
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void doctorNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void guna2HtmlToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
