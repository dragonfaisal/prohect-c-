namespace lab3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Moveup = new Button();
            inc_higth = new Button();
            move_left = new Button();
            dec_width = new Button();
            inc_width = new Button();
            move_rigth = new Button();
            dec_hight = new Button();
            move_down = new Button();
            player = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Moveup
            // 
            Moveup.BackColor = Color.Red;
            Moveup.FlatStyle = FlatStyle.Flat;
            Moveup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Moveup.ForeColor = Color.Gold;
            Moveup.Location = new Point(170, 137);
            Moveup.Name = "Moveup";
            Moveup.Size = new Size(41, 23);
            Moveup.TabIndex = 0;
            Moveup.Text = "^";
            Moveup.UseVisualStyleBackColor = false;
            Moveup.Click += Moveup_Click;
            // 
            // inc_higth
            // 
            inc_higth.BackColor = Color.Red;
            inc_higth.FlatStyle = FlatStyle.Flat;
            inc_higth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            inc_higth.ForeColor = Color.Gold;
            inc_higth.Location = new Point(170, 166);
            inc_higth.Name = "inc_higth";
            inc_higth.Size = new Size(41, 23);
            inc_higth.TabIndex = 1;
            inc_higth.Text = "+";
            inc_higth.UseVisualStyleBackColor = false;
            inc_higth.Click += inc_higth_Click;
            // 
            // move_left
            // 
            move_left.BackColor = Color.Red;
            move_left.FlatStyle = FlatStyle.Flat;
            move_left.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            move_left.ForeColor = Color.Gold;
            move_left.Location = new Point(74, 205);
            move_left.Name = "move_left";
            move_left.Size = new Size(41, 23);
            move_left.TabIndex = 2;
            move_left.Text = "<";
            move_left.UseVisualStyleBackColor = false;
            move_left.Click += move_left_Click;
            // 
            // dec_width
            // 
            dec_width.BackColor = Color.Red;
            dec_width.FlatStyle = FlatStyle.Flat;
            dec_width.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dec_width.ForeColor = Color.Gold;
            dec_width.Location = new Point(121, 205);
            dec_width.Name = "dec_width";
            dec_width.Size = new Size(41, 23);
            dec_width.TabIndex = 3;
            dec_width.Text = "-";
            dec_width.UseVisualStyleBackColor = false;
            // 
            // inc_width
            // 
            inc_width.BackColor = Color.Red;
            inc_width.FlatStyle = FlatStyle.Flat;
            inc_width.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            inc_width.ForeColor = Color.Gold;
            inc_width.Location = new Point(215, 205);
            inc_width.Name = "inc_width";
            inc_width.Size = new Size(41, 23);
            inc_width.TabIndex = 4;
            inc_width.Text = "+";
            inc_width.UseVisualStyleBackColor = false;
            // 
            // move_rigth
            // 
            move_rigth.BackColor = Color.Red;
            move_rigth.FlatStyle = FlatStyle.Flat;
            move_rigth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            move_rigth.ForeColor = Color.Gold;
            move_rigth.Location = new Point(262, 205);
            move_rigth.Name = "move_rigth";
            move_rigth.Size = new Size(41, 23);
            move_rigth.TabIndex = 5;
            move_rigth.Text = ">";
            move_rigth.UseVisualStyleBackColor = false;
            move_rigth.Click += move_rigth_Click;
            // 
            // dec_hight
            // 
            dec_hight.BackColor = Color.Red;
            dec_hight.FlatStyle = FlatStyle.Flat;
            dec_hight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dec_hight.ForeColor = Color.Gold;
            dec_hight.Location = new Point(170, 246);
            dec_hight.Name = "dec_hight";
            dec_hight.Size = new Size(41, 23);
            dec_hight.TabIndex = 6;
            dec_hight.Text = "-";
            dec_hight.UseVisualStyleBackColor = false;
            dec_hight.Click += dec_hight_Click;
            // 
            // move_down
            // 
            move_down.BackColor = Color.Red;
            move_down.FlatStyle = FlatStyle.Flat;
            move_down.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            move_down.ForeColor = Color.Gold;
            move_down.Location = new Point(170, 275);
            move_down.Name = "move_down";
            move_down.Size = new Size(41, 23);
            move_down.TabIndex = 7;
            move_down.Text = "v";
            move_down.UseVisualStyleBackColor = false;
            move_down.Click += move_down_Click;
            // 
            // player
            // 
            player.FlatStyle = FlatStyle.Popup;
            player.ForeColor = Color.FromArgb(0, 192, 0);
            player.Location = new Point(12, 39);
            player.Name = "player";
            player.Size = new Size(75, 23);
            player.TabIndex = 8;
            player.Text = "PLAYER";
            player.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Navy;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(145, 415);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(295, 345);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "NEXT_FORM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(434, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(player);
            Controls.Add(move_down);
            Controls.Add(dec_hight);
            Controls.Add(move_rigth);
            Controls.Add(inc_width);
            Controls.Add(dec_width);
            Controls.Add(move_left);
            Controls.Add(inc_higth);
            Controls.Add(Moveup);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Moveup;
        private Button inc_higth;
        private Button move_left;
        private Button dec_width;
        private Button inc_width;
        private Button move_rigth;
        private Button dec_hight;
        private Button move_down;
        private Button player;
        private TextBox textBox1;
        private Button button1;
    }
}