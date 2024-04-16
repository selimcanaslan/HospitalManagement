using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            profilePicture.Load("http://sca.somee.com/5f36452270380e18884e218d.jpg");
            sendNewProfilePictureViaFtp();
        }

        private void sendNewProfilePictureViaFtp()
        {
            byte[] data;
            using (Image image = Image.FromFile(@"C:\Users\selim\source\repos\HospitalManagement\HospitalManagement\Assets\common\exlamation_mark.png"))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    data = m.ToArray();
                }
            }
            FTPHelper fTPHelper = new FTPHelper("\tftp://155.254.244.38/www.sca.somee.com", "sca33", "2XFfX2b6xQUTJ-U");
            string result = fTPHelper.Upload(new MemoryStream(data), "picture1.jpeg");
            MessageBox.Show(result);
        }

        private void uploadProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Image Files (JPG,PNG,GIF) | *.JPG;*.PNG;*.GIF";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                profilePicture.Image = Image.FromFile(ofd.FileName);
            }
            
        }
    }
}
