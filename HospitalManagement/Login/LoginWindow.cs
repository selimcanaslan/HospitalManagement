﻿using System;
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

namespace HospitalManagement
{
    public partial class LoginWindow : Form
    {
        private BlUserLogin _blUserLogin;
        private string auth_type = "";
        public LoginWindow()
        {
            InitializeComponent();

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
                    DataTable user_info = _blUserLogin.fetchUserLoginData(user_name_textBox.Text, password_textBox.Text, auth_type);
                    if (user_info.Rows.Count == 1)
                    {
                        foreach (DataRow row in user_info.Rows)
                        {
                            auth_type = row["auth_type"].ToString();
                        }

                        this.Hide();
                        if (auth_type == "Secretary")
                        {
                            SecretaryLayer secretaryLayer = new SecretaryLayer("secretary");
                            //secretaryLayer.Closed += (s, args) => this.Show(); // call the login window after secretary window closed
                            secretaryLayer.Closed += (s, args) => this.Close(); // close whole app after secretary window closed
                            secretaryLayer.Show();
                        }
                        else if (auth_type == "Doctor")
                        {
                            DoctorLayer doctorLayer = new DoctorLayer();
                            doctorLayer.Closed += (s, args) => this.Close();
                            doctorLayer.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girdilerinizle Eşleşen Kayıt Bulunamadı!", "Hata");
                    }
                }
                catch { MessageBox.Show("Something Went Wrong", "Internal DB Error"); }
                finally { Console.WriteLine(auth_type); }
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
