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
        int toastX, toastY, x, y, w, h;
        double seconds = 3.0;

        private void msgLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Toast(string msg, Color color)
        {
            int x = SecretaryLayer.mainX;
            int y = SecretaryLayer.mainY;
            int w = SecretaryLayer.mainW;
            int h = SecretaryLayer.mainH;
            InitializeComponent();
            msgLabel.Text = msg;
            //panel1.BackColor = color;
            toastX = x + w - (this.Width);
            toastY = y + h - (this.Height);
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
        private void Position()
        {
            this.Location = new Point(toastX, toastY);
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
        
    }
}
