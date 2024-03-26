using HospitalManagement.Secretary.AddNewDoctorLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.Secretary.AddNewSecretaryLayer;

namespace HospitalManagement.Secretary
{
    public partial class SecretaryLayer : Form
    {
        public SecretaryLayer(String loginType)
        {
            InitializeComponent();
            this.Text = loginType.ToUpper();
        }

        private void SecretaryLayer_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void add_new_doctor_button_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.Show();
        }

        private void add_new_secretary_button_Click(object sender, EventArgs e)
        {
            AddSecretary addSecretary = new AddSecretary();
            addSecretary.Show();
        }
    }
}
