using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Height = 200;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.Red;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Image.FromFile(@"C:\Users\Owner\Desktop\mux use.png");
            pictureBox1.BackgroundImage = Image.FromFile(@"CCNA.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            //toolTip1.SetToolTip(pictureBox1, "pictureboxاداه ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null; // مسح الصورة من PictureBox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
