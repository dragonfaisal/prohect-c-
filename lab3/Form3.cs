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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // ضبط موقع وحجم النموذج عند تحميله
            this.Top = 0;
            this.Left = 0;
            this.Width += 100; // زيادة العرض
            this.Height += 100; // زيادة الارتفاع

        }

        private void Moveup_Click(object sender, EventArgs e)
        {
            if (player.Top <= 0)
            {
                MessageBox.Show("Cannot move up: reached the top limit!");
            }
            else
            {
                player.Top -= 5; // التحرك للأعلى
            }
        }

        private void move_down_Click(object sender, EventArgs e)
        {
            if (player.Top + player.Height >= this.Height)
            {
                MessageBox.Show("Cannot move down: reached the bottom limit!");
            }
            else
            {
                player.Top += 5; // التحرك للأسفل
            }
        }

        private void move_left_Click(object sender, EventArgs e)
        {
            if (player.Left <= 0)
            {
                MessageBox.Show("Cannot move left: reached the left limit!");
            }
            else
            {
                player.Left -= 5; // التحرك لليسار

            }
        }

        private void move_rigth_Click(object sender, EventArgs e)
        {
            if (player.Left + player.Width >= this.Width)
            {
                MessageBox.Show("Cannot move right: reached the right limit!");
            }
            else
            {
                player.Left += 5; // التحرك لليمين
            }
        }

        private void inc_higth_Click(object sender, EventArgs e)
        {
            player.Size = new Size(player.Width, player.Height + 5); // زيادة الارتفاع
        }

        private void dec_hight_Click(object sender, EventArgs e)
        {
            // التحقق من أن الارتفاع لا يصبح سالبًا
            if (player.Height > 5)
            {
                player.Size = new Size(player.Width, player.Height - 5); // تقليل الارتفاع
            }
            else
            {
                MessageBox.Show("Cannot decrease height further.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
