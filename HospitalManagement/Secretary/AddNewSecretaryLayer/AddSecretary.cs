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
    }
}
