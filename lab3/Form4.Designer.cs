namespace lab3
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            move_front = new Button();
            move_down = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Location = new Point(12, 57);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Location = new Point(117, 162);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "stop";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // move_front
            // 
            move_front.BackColor = Color.Crimson;
            move_front.Location = new Point(30, 231);
            move_front.Name = "move_front";
            move_front.Size = new Size(117, 23);
            move_front.TabIndex = 3;
            move_front.Text = "التحرك الى الأمام";
            move_front.UseVisualStyleBackColor = false;
            move_front.Click += move_front_Click;
            // 
            // move_down
            // 
            move_down.BackColor = Color.Crimson;
            move_down.Location = new Point(205, 231);
            move_down.Name = "move_down";
            move_down.Size = new Size(120, 23);
            move_down.TabIndex = 4;
            move_down.Text = "التحرك الى الخلف";
            move_down.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Location = new Point(117, 98);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "star";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.Location = new Point(117, 302);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "nextform";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(371, 432);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(move_down);
            Controls.Add(move_front);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button move_front;
        private Button move_down;
        private System.Windows.Forms.Timer timer1;
        private Button button4;
        private Button button5;
    }
}