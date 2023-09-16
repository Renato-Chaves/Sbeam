namespace Sbeam
{
    partial class Register
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
            button1 = new Button();
            Login_link = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Login_txt = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 71, 94);
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(425, 413);
            button1.Name = "button1";
            button1.Size = new Size(205, 40);
            button1.TabIndex = 16;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            // 
            // Login_link
            // 
            Login_link.AutoSize = true;
            Login_link.BackColor = Color.Transparent;
            Login_link.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Login_link.ForeColor = Color.FromArgb(102, 192, 244);
            Login_link.Location = new Point(646, 438);
            Login_link.Name = "Login_link";
            Login_link.Size = new Size(157, 15);
            Login_link.TabIndex = 15;
            Login_link.Text = "already have an account?";
            Login_link.Click += Login_link_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(42, 71, 94);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(199, 213, 224);
            textBox2.Location = new Point(425, 267);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 29);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(42, 71, 94);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(199, 213, 224);
            textBox1.Location = new Point(425, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 29);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(228, 259);
            label2.Name = "label2";
            label2.Size = new Size(154, 37);
            label2.TabIndex = 12;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(223, 193);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 11;
            label1.Text = "Username:";
            // 
            // Login_txt
            // 
            Login_txt.AutoSize = true;
            Login_txt.BackColor = Color.Transparent;
            Login_txt.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Login_txt.ForeColor = Color.FromArgb(199, 213, 224);
            Login_txt.Location = new Point(425, 96);
            Login_txt.Name = "Login_txt";
            Login_txt.Size = new Size(177, 51);
            Login_txt.TabIndex = 10;
            Login_txt.Text = "Register";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(229, 335);
            label5.Name = "label5";
            label5.Size = new Size(154, 37);
            label5.TabIndex = 18;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(239, 309);
            label6.Name = "label6";
            label6.Size = new Size(131, 37);
            label6.TabIndex = 19;
            label6.Text = "Re-enter";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(42, 71, 94);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(199, 213, 224);
            textBox3.Location = new Point(425, 335);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(327, 29);
            textBox3.TabIndex = 20;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Register_BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 561);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(Login_link);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Login_txt);
            DoubleBuffered = true;
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Login_link;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label Login_txt;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
    }
}