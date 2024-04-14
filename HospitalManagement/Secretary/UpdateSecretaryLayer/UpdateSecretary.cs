using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Secretary.UpdateSecretaryLayer
{
    public partial class UpdateSecretary : Form
    {
        public UpdateSecretary()
        {
            InitializeComponent();
            secretaryTcnoTextBox.MaxLength = 11;
        }

        private void secretaryTcnoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
