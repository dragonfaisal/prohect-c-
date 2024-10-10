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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            textBox1.Enabled = false;
            textBox1.Visible = false;
            label1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = false;
          //  button2.Title = "اختر صورة";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.bmp;*.gif|ALL Files|*.*";
          //  button2.Filter = "Image Files|*.jpg;*.png|ALL Files|*.*";// الواجب 
           // if (button2.ShowDialog() == DialogResult.OK)
            {
            //  //  string filename = button2.FileName;
            //    Bitmap mybitmap = new Bitmap(filename);
            //    pictureBox1.Image = mybitmap;
            //    textBox1.Text = filename;// لجعل المسار ينتج بعد عمليه اضافه اصوره واجب
            //}
            //else
            //{
            //    MessageBox.Show("ادخل الامتداد الصحيح للصور !!");
            //}
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    textBox1.Enabled = true;
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    Form4 form4 = new Form4();
        //    form4.ShowDialog();
        //}
    }
}
}
