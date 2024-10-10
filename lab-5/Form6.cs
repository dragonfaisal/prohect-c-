using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int i = 0;

        private void Form6_Load(object sender, EventArgs e)
        {
           // BackgroundImage = Image.FromFile(@"Screenshot 2023-11-21 184249.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             i--;
            if (i < 1)
            {
                i = 9; // الحد الأقصى للصور
            }

            LoadImage();
        }
        private void LoadImage()
        {
            try
            {
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
                BackgroundImage = Image.FromFile(i.ToString() + ".png");
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i > 9)
            {
                i = 1; // العودة إلى الصورة الأولى
            }

            LoadImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
