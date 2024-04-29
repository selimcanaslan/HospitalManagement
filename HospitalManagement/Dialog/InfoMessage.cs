using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.Dialog;
using HospitalManagement.Secretary;

namespace HospitalManagement.Dialog
{
    public partial class InfoMessage : Form
    {
        int seconds = 3;

        public InfoMessage(string msg = "Mesaj", string ttl = "Title")
        {
            InitializeComponent();
            CenterToParent();
            this.DoubleBuffered = true;
            messageLabel.Text = msg;
            titleLabel.Text = ttl.ToUpper();
            okButton.Text = $"OK({seconds})";
        }
        private void InfoMessage_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();

            timer.Interval = (1 * 1 * 1000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds -= 1;
            okButton.Text = "OK(" + (seconds).ToString() + ")";
            if (okButton.Text == "OK(0)")
            {
                this.Close();
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
