using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        int counter = 0;
        string j = "0";
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //counter++;

            //label1.Text = DateTime.Now.ToString("HH:mm:ss"); // هنا يقوم بستداء داله تقوم بايجاد ساعه النضام
            if (counter < 10)
            {
                label1.Text = "0" + counter.ToString(); // add number 0 befor the singel number.
                counter++;
            }
            else
            {

                label1.Text = counter.ToString();
                counter++;
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // counter = 0;
            label1.Text = counter.ToString();
            timer1.Enabled = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //counter++;

            //label1.Text = DateTime.Now.ToString("HH:mm:ss"); // هنا يقوم بستداء داله تقوم بايجاد ساعه النضام
            if (counter < 10)
            {
                label1.Text = "0" + counter.ToString(); // add number 0 befor the singel number.
                counter++;
            }
            else
            {

                label1.Text = counter.ToString();
                counter++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            new Form3().ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter = 0;
            label1.Text = counter.ToString();
        }
    }
}
