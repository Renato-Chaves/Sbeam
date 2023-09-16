namespace Sbeam
{
    partial class Login
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
            Login_txt = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Register_link = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Login_txt
            // 
            Login_txt.AutoSize = true;
            Login_txt.BackColor = Color.Transparent;
            Login_txt.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Login_txt.ForeColor = Color.FromArgb(199, 213, 224);
            Login_txt.Location = new Point(442, 140);
            Login_txt.Name = "Login_txt";
            Login_txt.Size = new Size(127, 51);
            Login_txt.TabIndex = 0;
            Login_txt.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(247, 223);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(247, 273);
            label2.Name = "label2";
            label2.Size = new Size(154, 37);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(42, 71, 94);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(199, 213, 224);
            textBox1.Location = new Point(415, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(42, 71, 94);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(199, 213, 224);
            textBox2.Location = new Point(415, 281);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 29);
            textBox2.TabIndex = 4;
            // 
            // Register_link
            // 
            Register_link.AutoSize = true;
            Register_link.BackColor = Color.Transparent;
            Register_link.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Register_link.ForeColor = Color.FromArgb(102, 192, 244);
            Register_link.Location = new Point(581, 388);
            Register_link.Name = "Register_link";
            Register_link.Size = new Size(145, 15);
            Register_link.TabIndex = 8;
            Register_link.Text = "don't have an account?";
            Register_link.Click += Register_link_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 71, 94);
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(415, 363);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 71, 94);
            BackgroundImage = Properties.Resources.Login_BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 561);
            Controls.Add(button1);
            Controls.Add(Register_link);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Login_txt);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login_txt;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Register_link;
        private Button button1;
    }
}