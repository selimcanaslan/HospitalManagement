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

namespace HospitalManagement
{
    public partial class LoginWindow : Form
    {
        private BlUserLogin _blUserLogin;
        private string auth_type = "";
        public LoginWindow()
        {
            InitializeComponent();
            _blUserLogin = new BlUserLogin();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Banane", "Error");
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(user_name_textBox.Text) == true || String.IsNullOrWhiteSpace(password_textBox.Text) == true)
            {
                string error = "Please make sure you fill all the fields";
                if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    error += " and check your auth type";
                }
                MessageBox.Show(error, "Hata");
            }
            else
            {
                try
                {
                    DataTable user_info = _blUserLogin.fetchUserLoginData(user_name_textBox.Text, password_textBox.Text, auth_type);
                    if (user_info.Rows.Count == 1)
                    {
                        foreach (DataRow row in user_info.Rows)
                        {
                            Console.WriteLine(row["user_name"].ToString());
                            Console.WriteLine(row["password"].ToString());
                            Console.WriteLine(row["auth_type"].ToString());
                        }

                        this.Hide();
                        SecretaryLayer secretaryLayer = new SecretaryLayer("secretary");
                        //secretaryLayer.Closed += (s, args) => this.Show(); // call the login window after secretary window closed
                        secretaryLayer.Closed += (s, args) => this.Close(); // close whole app after secretary window closed
                        secretaryLayer.Show();
                    }
                    else
                    {
                        MessageBox.Show("Girdilerinizle Eşleşen Kayıt Bulunamadı!", "Hata");
                    }
                }
                catch { Console.WriteLine("Something Went Wrong"); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExitLogin exitLogin = new ExitLogin();
            exitLogin.ShowDialog();
            bool selection = exitLogin.selection;
            if (selection)
            {
                this.Close();
            }
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
    }
}
