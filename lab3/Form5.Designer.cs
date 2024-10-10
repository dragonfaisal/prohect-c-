namespace lab3
{
    partial class Form5
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
            move = new Button();
            start = new Button();
            stop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // move
            // 
            move.BackColor = Color.Red;
            move.ForeColor = Color.FromArgb(0, 0, 192);
            move.Location = new Point(30, 80);
            move.Name = "move";
            move.Size = new Size(75, 23);
            move.TabIndex = 0;
            move.Text = "<<>>";
            move.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            start.BackColor = Color.Red;
            start.ForeColor = Color.FromArgb(0, 0, 192);
            start.Location = new Point(143, 230);
            start.Name = "start";
            start.Size = new Size(75, 23);
            start.TabIndex = 1;
            start.Text = "start";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // stop
            // 
            stop.BackColor = Color.Red;
            stop.ForeColor = Color.FromArgb(0, 0, 192);
            stop.Location = new Point(224, 230);
            stop.Name = "stop";
            stop.Size = new Size(75, 23);
            stop.TabIndex = 2;
            stop.Text = "stop";
            stop.UseVisualStyleBackColor = false;
            stop.Click += stop_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(428, 365);
            Controls.Add(stop);
            Controls.Add(start);
            Controls.Add(move);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button move;
        private Button start;
        private Button stop;
        private System.Windows.Forms.Timer timer1;
    }
}