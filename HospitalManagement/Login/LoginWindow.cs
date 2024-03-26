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
using EntityLayer;
using HospitalManagement.Login;

namespace HospitalManagement
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
            string exit_button_hover_colot = "#18335e";

        }
        private void LoginWindow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(user_name_textBox.Text) == true || String.IsNullOrWhiteSpace(password_textBox.Text) == true)
            {
                MessageBox.Show("Please make sure you fill all the fields");
            }
            else
            {
                //Sql Connection from Data Access Layer and so on.
                //demo
                try
                {
                    
                    if (user_name_textBox.Text == "s" && password_textBox.Text == "s")
                    {
                        this.Hide();
                        SecretaryLayer secretaryLayer = new SecretaryLayer("secretary");
                        //secretaryLayer.Closed += (s, args) => this.Show(); // call the login window after secretary window closed
                        secretaryLayer.Closed += (s, args) => this.Close(); // close whole app after secretary window closed
                        secretaryLayer.Show();
                    }
                }
                catch { Console.WriteLine("Something Went Wrong"); }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Banane","Error");
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
    }
}
