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
            RegisterBtn = new Button();
            Login_link = new Label();
            UsernameInput = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Login_txt = new Label();
            label5 = new Label();
            label6 = new Label();
            PasswordInput = new MaskedTextBox();
            PasswordConfirmInput = new MaskedTextBox();
            SuspendLayout();
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.FromArgb(42, 71, 94);
            RegisterBtn.BackgroundImageLayout = ImageLayout.Zoom;
            RegisterBtn.FlatAppearance.BorderSize = 0;
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBtn.ForeColor = Color.White;
            RegisterBtn.Location = new Point(425, 413);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(205, 40);
            RegisterBtn.TabIndex = 3;
            RegisterBtn.Text = "Create Account";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
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
            Login_link.TabIndex = 4;
            Login_link.Text = "already have an account?";
            Login_link.Click += Login_link_Click;
            // 
            // UsernameInput
            // 
            UsernameInput.BackColor = Color.FromArgb(42, 71, 94);
            UsernameInput.BorderStyle = BorderStyle.None;
            UsernameInput.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameInput.ForeColor = Color.FromArgb(199, 213, 224);
            UsernameInput.Location = new Point(425, 199);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(327, 29);
            UsernameInput.TabIndex = 0;
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
            // PasswordInput
            // 
            PasswordInput.BackColor = Color.FromArgb(42, 71, 94);
            PasswordInput.BorderStyle = BorderStyle.None;
            PasswordInput.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordInput.ForeColor = Color.FromArgb(199, 213, 224);
            PasswordInput.Location = new Point(425, 267);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(327, 29);
            PasswordInput.TabIndex = 1;
            // 
            // PasswordConfirmInput
            // 
            PasswordConfirmInput.BackColor = Color.FromArgb(42, 71, 94);
            PasswordConfirmInput.BorderStyle = BorderStyle.None;
            PasswordConfirmInput.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordConfirmInput.ForeColor = Color.FromArgb(199, 213, 224);
            PasswordConfirmInput.Location = new Point(425, 335);
            PasswordConfirmInput.Name = "PasswordConfirmInput";
            PasswordConfirmInput.PasswordChar = '*';
            PasswordConfirmInput.Size = new Size(327, 29);
            PasswordConfirmInput.TabIndex = 2;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 71, 94);
            BackgroundImage = Properties.Resources.Register_BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 561);
            Controls.Add(PasswordConfirmInput);
            Controls.Add(PasswordInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(RegisterBtn);
            Controls.Add(Login_link);
            Controls.Add(UsernameInput);
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

        private Button RegisterBtn;
        private Label Login_link;
        private TextBox UsernameInput;
        private Label label2;
        private Label label1;
        private Label Login_txt;
        private Label label5;
        private Label label6;
        private MaskedTextBox PasswordInput;
        private MaskedTextBox PasswordConfirmInput;
    }
}