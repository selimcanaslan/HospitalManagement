using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Login
{
    public partial class ExitLogin : Form
    {
        public bool selection;
        public ExitLogin()
        {
            InitializeComponent();
        }

        private void ExitLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selection = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selection = false;
            this.Close();
        }
    }
}
