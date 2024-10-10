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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int s = -1, m = 0, h = 0, y = 0;
        int day = 0;

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s > 9)
                label3.Text = s.ToString();
            else
                label3.Text = "0" + s.ToString();
            if (s >= 59)
            {

                s = 0;
                m += 1;
                timer1.Interval = 10;// عند الدخول هنا ازد السرعه
                if (m >= 9)
                    label2.Text = m.ToString();
                else
                    label2.Text = "0" + m.ToString();
            }
            if (m >= 59)
            {

                m = 0;
                h++;
                s = 0;
                if (h < 9)
                    label1.Text = "0" + h.ToString();
            }
            if (h >= 12)//حساب الايام
            {
                day++;
                h = 0;
                s = 0;
                m = 5;
                textBox1.Text = day.ToString();

            }
        }
    }
}
