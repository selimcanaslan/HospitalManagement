using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagement.Secretary.AddNewSecretaryLayer
{
    public partial class AddSecretary : Form
    {
        string err_message = "";
        public AddSecretary()
        {
            InitializeComponent();
        }

        private void AddSecretary_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //DALSecretary db = new DALSecretary();
                //db.AddSecretary(textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                //MessageBox.Show("Başarıyla Kayıt Oldunuz");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool fieldValidation()
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(surnameTextBox.Text) || string.IsNullOrWhiteSpace(mailTextBox.Text)
                || string.IsNullOrWhiteSpace(phoneTextBox.Text) || string.IsNullOrWhiteSpace(addressTextBox.Text))
            { err_message += "Lütfen hiçbir alanı boş bırakmayınız!\n"; }
            if (mailTextBox.Text.Length > 0 &&
                mailTextBox.Text.EndsWith("@gmail.com") == false &&
                mailTextBox.Text.EndsWith("@hotmail.com") == false &&
                mailTextBox.Text.EndsWith("@outlook.com") == false)
            {
                err_message += "Mail adresi hotmail, gmail ya da outlook olmalıdır.\n";
            }
            if (phoneTextBox.Text.Length != 10 && phoneTextBox.Text.Length > 0) { err_message += "Lütfen Telefon numaranızı başında 0 olmadan giriniz.\n"; }

            if (err_message != "")
            {
                return false;
            }
            else { return true; }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            if (fieldValidation() == true)
            {
                BlSecretary blSecretary = new BlSecretary();
                bool response = blSecretary.AddSecretary(nameTextBox.Text, surnameTextBox.Text,
                    mailTextBox.Text, phoneTextBox.Text, addressTextBox.Text);
                if (response) { MessageBox.Show("Registiration Successfull!"); }
                else { MessageBox.Show("Registiration Failed!"); }
            }
            else
            {
                MessageBox.Show(err_message);
                err_message = string.Empty;
            }

        }
    }
}
