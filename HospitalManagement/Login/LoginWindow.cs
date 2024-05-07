using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.Secretary;
using HospitalManagement.Login;
using BusinessLayer;
using HospitalManagement.Doctor;
using EntityLayer;
using System.Data.SqlClient;
using HospitalManagement.Dialog;

namespace HospitalManagement
{
    public partial class LoginWindow : Form
    {
        private BlSecretary blSecretary;
        private BlUserLogin _blUserLogin;
        private string auth_type;
        public static UserLoginEntity _userEntity;
        public LoginWindow()
        {
            InitializeComponent();
            blSecretary = new BlSecretary();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            test_fill_info();
        }
        private void test_fill_info()
        {
            user_name_textBox.Text = "selimcanaslan";
            password_textBox.Text = "selimcanaslan";
            checkBox2.Checked = true;
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(user_name_textBox.Text) == true || String.IsNullOrWhiteSpace(password_textBox.Text) == true)
            {
                MessageBox.Show("Please make sure you fill all the fields", "Error");
                return;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Please check one of the checkbox", "Error");
                return;
            }

            else
            {
                try
                {
                    _blUserLogin = new BlUserLogin();
                    DataTable user_info = new DataTable();
                    if (auth_type == "Secretary")
                    {
                        
                        user_info = _blUserLogin.FetchSecretaryLoginInfo(user_name_textBox.Text, password_textBox.Text);
                        if (user_info.Rows.Count == 1)
                        {
                            _userEntity = new UserLoginEntity();
                            foreach (DataRow row in user_info.Rows)
                            {
                                _userEntity.AuthType = auth_type;
                                _userEntity.KullaniciAd = row["user_name"].ToString();
                                _userEntity.KullaniciSifre = row["password"].ToString();
                                _userEntity.Tcno = row["tc_no"].ToString();
                            }
                            DataTable LoggedInUser = blSecretary.fetchSecretaryByGivenTcNo(_userEntity.Tcno);
                            foreach (DataRow row in LoggedInUser.Rows)
                            {
                                _userEntity.Id = Int32.Parse(row["id"].ToString()); 
                                _userEntity.Ad = row["name"].ToString();
                                _userEntity.Soyad = row["surname"].ToString();
                                _userEntity.Mail = row["mail"].ToString();
                                _userEntity.PhoneNumber = row["phone_number"].ToString();
                                _userEntity.Address = row["address"].ToString();
                            }
                            this.Hide();
                            SecretaryLayer secretaryLayer = new SecretaryLayer("Sekreter");
                            secretaryLayer.Closed += (s, args) => this.Show(); // call the login window after secretary window closed
                            //secretaryLayer.Closed += (s, args) => this.Close(); // close whole app after secretary window closed
                            secretaryLayer.Show();
                        }
                        else
                        {
                            MessageBox.Show("1-Girdilerinizle Eşleşen Kayıt Bulunamadı!\n2-Kullanıcı Adı ve Şifrenizi Kontrol Edin!", "Hata");
                        }
                    }
                    else if (auth_type == "Doctor")
                    {
                        user_info = _blUserLogin.FetchDoctorLoginInfo(user_name_textBox.Text, password_textBox.Text);
                        if (user_info.Rows.Count == 1)
                        {
                            _userEntity = new UserLoginEntity();
                            foreach (DataRow row in user_info.Rows)
                            {
                                _userEntity.AuthType = auth_type;
                                _userEntity.KullaniciAd = row["user_name"].ToString();
                                _userEntity.KullaniciSifre = row["password"].ToString();
                                _userEntity.Tcno = row["tc_no"].ToString();
                            }
                            DataTable LoggedInUser = blSecretary.fetchDoctorByGivenTcNo(_userEntity.Tcno);
                            foreach (DataRow row in LoggedInUser.Rows)
                            {
                                _userEntity.Id = Int32.Parse(row["id"].ToString());
                                _userEntity.Ad = row["doctor_name"].ToString();
                                _userEntity.Soyad = row["doctor_surname"].ToString();
                                _userEntity.Mail = row["mail"].ToString();
                                _userEntity.PhoneNumber = row["phone_number"].ToString();
                                _userEntity.Address = row["address"].ToString();
                                _userEntity.SectionId = Int16.Parse(row["section_id"].ToString());
                            }
                            this.Hide();
                            DoctorLayer doctorLayer = new DoctorLayer("Doktor");
                            doctorLayer.Closed += (s, args) => this.Show(); // call the login window after secretary window closed
                            //doctorLayer.Closed += (s, args) => this.Close();
                            doctorLayer.Show();
                        }
                        else
                        {
                            MessageBox.Show("Girdilerinizle Eşleşen Kayıt Bulunamadı!", "Hata");
                        }
                    }
                }
                catch(SqlException ex) { MessageBox.Show($"Something Went Wrong {ex.Message}", "Internal DB Error"); }
                finally {  }
            }
        }

        private void DoctorLayer_Closed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                auth_type = "Doctor";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                auth_type = "Secretary";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Banane", "Error");
        }
    }
}
