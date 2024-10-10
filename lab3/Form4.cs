using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // للسماح باستخدام خيوط

namespace lab3
{
    public partial class Form4 : Form



    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            move_down.Enabled = move_front.Enabled = false; // تعطيل الأزرار عند البداية
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void move_front_Click(object sender, EventArgs e)
        {
            timer1.Start();
            threadgo = new Thread(go);
            threadgo.Start();
        }
        Thread threadgo;
        private void MoveButton()
        {
            for (int i = 0; i <= this.Width; i++)
            {
                Invoke((Action)(() =>
                {
                    button1.Left += 10; // تحريك button1 لليمين
                }));

                // التحقق إذا تجاوز button1 حدود النموذج
                if (button1.Left > this.Width - button1.Width - 50)
                {
                    break;
                }

                Thread.Sleep(100);
            }
        }

        private void btn_move_down4_Click(object sender, EventArgs e)
        {
            for (int i = button2.Top; i <= this.Height - button2.Height - 70; i++)
            {
                if (button2.Top > this.Height - button2.Height - 70)
                {
                    break;
                }
                button2.Top += 10; // تحريك button2 لأسفل
                Thread.Sleep(100);
            }
            timer1.Start(); // بدء المؤقت بعد الحركة
        }
        void go()
        {
            for (int i = 0; i <= this.Width; i++)
            {
                Invoke((Action)(() =>
                {
                    // عندما يكون شغل الاداه في داخل ثريد لا تستطيع الوصول  للادوات مباشره يجب ان نصل للادوات ونحن داخل داله الانفوك

                    button1.Left += 10;
                }));
                if (button1.Left > this.Width - button1.Width - 50)
                {
                    break;
                }

                System.Threading.Thread.Sleep(100);
                //Application.DoEvents();// لحدوث المقاطعه والعمل على النموذح باكثر من حدث

            }
        }
        bool f = true;
        bool f1 = true;

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (button1.Left + button1.Width >= this.Width)
                f = false;

            else if (button1.Left <= 0)
                f = true;

            if (button2.Top + button2.Height >= this.Height)
                f1 = false;
            else if (button2.Top <= 0)
                f1 = true;


            if (f)
            {
                button1.Left += 5;

            }
            else
            {
                button1.Left -= 5;

            }
            if (f1)
            {
                button2.Top += 5;
            }
            else
            {
                button2.Top -= 5;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog(); 
        }
    }
}
