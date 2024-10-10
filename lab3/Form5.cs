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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        bool f = true;

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (move.Left + move.Width >= this.Width)
                f = false;

            else if (move.Left <= 0)
                f = true;



            if (f)
                move.Left += 30;
            else

                move.Left -= 30;
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
