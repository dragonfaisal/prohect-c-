namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // „ €Ì—«  · Ã„Ì⁄ «·ﬁÌ„ Ê«· Õﬁﬁ „‰  ›⁄Ì· √Ì checkbox
            int sum = 0;
            bool isChecked = false;

            //  ›—Ì€ „Õ ÊÏ «·‹ TextBox
            textBox1.Text = string.Empty;

            // «· Õﬁﬁ „‰ ﬂ· CheckBox ≈–«  „  ÕœÌœÂ
            if (checkBox1.Checked)
            {
                sum += Convert.ToInt32(checkBox1.Text);
                isChecked = true;
            }

            if (checkBox2.Checked)
            {
                sum += Convert.ToInt32(checkBox2.Text);
                isChecked = true;
            }

            if (checkBox3.Checked)
            {
                sum += 33;
                isChecked = true;
            }

            if (checkBox4.Checked)
            {
                sum += 6;
                isChecked = true;
            }

            // ≈–« ·„ Ì „  ÕœÌœ √Ì CheckBox
            if (!isChecked)
            {
                MessageBox.Show("Please check at least one option.");
            }
            else
            {
                // ⁄—÷ «·‰ ÌÃ… ›Ì TextBox
                textBox1.Text = sum.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  €ÌÌ— ·Ê‰ «·‰’ »‰«¡ ⁄·Ï «·—«œÌÊ «·„Œ «—
            if (radioButton1.Checked)
            {
                label3.ForeColor = Color.Red;
            }
            else if (radioButton2.Checked)
            {
                label3.ForeColor = Color.Yellow;
            }
            else if (radioButton3.Checked)
            {
                label3.ForeColor = Color.Green;
            }
            else if (radioButton4.Checked)
            {
                label3.ForeColor = Color.Black;
            }

            //  €ÌÌ— ·Ê‰ Œ·›Ì… «·‰’ »‰«¡ ⁄·Ï «·—«œÌÊ «·„Œ «—
            if (radioButton7.Checked)
            {
                label3.BackColor = Color.Red;
            }
            else if (radioButton8.Checked)
            {
                label3.BackColor = Color.Yellow;
            }
            else if (radioButton6.Checked)
            {
                label3.BackColor = Color.Green;
            }
            else if (radioButton5.Checked)
            {
                label3.BackColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // «·ﬂÊœ «·»œÌ· · €ÌÌ— ·Ê‰ Œ·›Ì… «·‰’  „ ‰ﬁ·Â ≈·Ï button1
        }

        private bool isPanelEnabled = false;

        private void button4_Click(object sender, EventArgs e)
        {
            // ⁄ﬂ” Õ«·…  ›⁄Ì· «·‹ Panel
            isPanelEnabled = !isPanelEnabled;
            panel2.Enabled = isPanelEnabled;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // ⁄ﬂ” Õ«·…  ›⁄Ì· «·‹ Panel
            isPanelEnabled = !isPanelEnabled;
            panel2.Enabled = isPanelEnabled;

        }
        //private bool isPanelEnabled = false;

        private void button2_Click_1(object sender, EventArgs e)
        {
            //  ⁄ÿÌ· «·‹ Panel
            panel2.Enabled = false;
        }
        private bool visiblePanel = false;

        private void button3_Click(object sender, EventArgs e)
        {
            // ⁄ﬂ” Õ«·… ŸÂÊ— «·‹ Panel
            visiblePanel = !visiblePanel;
            panel2.Visible = visiblePanel;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // ≈Œ›«¡ «·‹ Panel
            panel2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }



}

