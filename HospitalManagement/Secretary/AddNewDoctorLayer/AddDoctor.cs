using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.Secretary.AddNewDoctorLayer;
using DataAccessLayer;

namespace HospitalManagement.Secretary.AddNewDoctorLayer
{
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DALDoktor db = new DALDoktor();
                db.AddDoctor(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show("Başarıyla Kayıt Oldunuz");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
