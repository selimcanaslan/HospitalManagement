using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Dialog
{
    public partial class OptionDialog : Form
    {
        public static string response = "";
        public OptionDialog(string title, string msg, string option1Text, string option2Text)
        {
            InitializeComponent();
            titleLabel.Text = title;
            messageLabel.Text = msg;
            option1Button.Text = option1Text;
            option2Button.Text = option2Text;

        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            response = "edit";
            this.Close();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            response = "delete";
            this.Close();
        }
    }
}
