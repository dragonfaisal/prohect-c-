namespace lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" && textBox2.Text.Trim() == "")
            {
                MessageBox.Show("enter the path imeg!!");
                textBox1.Focus();
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@textBox1.Text.Trim());
                textBox2.Text = textBox1.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.BackColor = Color.Red;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          Form4 form = new Form4();
            form.ShowDialog();
        }
    }
}
