using HospitalManagement.Secretary;
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
    public partial class Toast : Form
    {
        int toastX, toastY;
        double seconds = 5.0;
        public Toast(SecretaryLayer ParentForm, string msg)
        {
            InitializeComponent();
            msgLabel.Text = msg;
            toastX = ParentForm.Location.X + ParentForm.Width - (this.Width);
            toastY = ParentForm.Location.Y + ParentForm.Height - (this.Height);   
        }

        private void Toast_Load(object sender, EventArgs e)
        {
            Position();
            timerToast.Stop();
            Timer timer = new Timer();

            timer.Interval = (1 * 1 * 125);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timerToast_Tick(object sender, EventArgs e)
        {
            this.Height -= 2;
            if (this.Height <= 0)
            {
                timerToast.Stop();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds -= 0.125;
            if (seconds == 0.375) { timerToast.Start(); }
            if (seconds == 0)
            {
                this.Close();
            }
        }

        private void Position()
        {
            this.Location = new Point(toastX, toastY);
        }
    }
}
