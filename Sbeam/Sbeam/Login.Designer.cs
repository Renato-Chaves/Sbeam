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
            UsernameInput = new TextBox();
            Register_link = new Label();
            Login_btn = new Button();
            PasswordInput = new MaskedTextBox();
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
            // UsernameInput
            // 
            UsernameInput.BackColor = Color.FromArgb(42, 71, 94);
            UsernameInput.BorderStyle = BorderStyle.None;
            UsernameInput.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameInput.ForeColor = Color.FromArgb(199, 213, 224);
            UsernameInput.Location = new Point(415, 229);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(327, 29);
            UsernameInput.TabIndex = 0;
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
            Register_link.TabIndex = 3;
            Register_link.Text = "don't have an account?";
            Register_link.Click += Register_link_Click;
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.FromArgb(42, 71, 94);
            Login_btn.BackgroundImageLayout = ImageLayout.Zoom;
            Login_btn.FlatAppearance.BorderSize = 0;
            Login_btn.FlatStyle = FlatStyle.Flat;
            Login_btn.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Login_btn.ForeColor = Color.White;
            Login_btn.Location = new Point(415, 363);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(132, 40);
            Login_btn.TabIndex = 2;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // PasswordInput
            // 
            PasswordInput.BackColor = Color.FromArgb(42, 71, 94);
            PasswordInput.BorderStyle = BorderStyle.None;
            PasswordInput.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordInput.ForeColor = Color.FromArgb(199, 213, 224);
            PasswordInput.Location = new Point(415, 281);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(327, 29);
            PasswordInput.TabIndex = 1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 71, 94);
            BackgroundImage = Properties.Resources.Login_BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 561);
            Controls.Add(PasswordInput);
            Controls.Add(Login_btn);
            Controls.Add(Register_link);
            Controls.Add(UsernameInput);
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
        private TextBox UsernameInput;
        private Label Register_link;
        private Button Login_btn;
        private MaskedTextBox PasswordInput;
    }
}