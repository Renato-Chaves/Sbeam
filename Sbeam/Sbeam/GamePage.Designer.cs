namespace Sbeam
{
    partial class GamePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            SbeamTitle = new Label();
            Logo = new PictureBox();
            GameCover = new PictureBox();
            GameDescription = new TextBox();
            GameTitleText = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ReleaseDateTxt = new TextBox();
            DeveloperTxt = new TextBox();
            PublisherTxt = new TextBox();
            textBox8 = new TextBox();
            MainGameTitle = new Label();
            WishlistBtn = new Button();
            GamePrice = new TextBox();
            Game0Linux = new PictureBox();
            Game0Apple = new PictureBox();
            Game0Windows = new PictureBox();
            GameTags = new TextBox();
            BackBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GameCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Game0Linux).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Game0Apple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Game0Windows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackBtn).BeginInit();
            SuspendLayout();
            // 
            // SbeamTitle
            // 
            SbeamTitle.AutoSize = true;
            SbeamTitle.BackColor = Color.FromArgb(23, 26, 33);
            SbeamTitle.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SbeamTitle.ForeColor = Color.White;
            SbeamTitle.Location = new Point(165, 9);
            SbeamTitle.Name = "SbeamTitle";
            SbeamTitle.Size = new Size(92, 32);
            SbeamTitle.TabIndex = 4;
            SbeamTitle.Text = "Sbeam";
            // 
            // Logo
            // 
            Logo.BackColor = Color.FromArgb(23, 26, 33);
            Logo.BackgroundImage = Properties.Resources.SbeamLogo;
            Logo.Location = new Point(114, 7);
            Logo.Name = "Logo";
            Logo.Size = new Size(35, 37);
            Logo.TabIndex = 3;
            Logo.TabStop = false;
            // 
            // GameCover
            // 
            GameCover.BackColor = Color.FromArgb(31, 31, 31);
            GameCover.Location = new Point(86, 115);
            GameCover.Name = "GameCover";
            GameCover.Size = new Size(523, 299);
            GameCover.SizeMode = PictureBoxSizeMode.Zoom;
            GameCover.TabIndex = 5;
            GameCover.TabStop = false;
            // 
            // GameDescription
            // 
            GameDescription.BackColor = Color.FromArgb(23, 26, 33);
            GameDescription.BorderStyle = BorderStyle.None;
            GameDescription.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            GameDescription.ForeColor = Color.White;
            GameDescription.Location = new Point(636, 125);
            GameDescription.Multiline = true;
            GameDescription.Name = "GameDescription";
            GameDescription.ReadOnly = true;
            GameDescription.Size = new Size(299, 160);
            GameDescription.TabIndex = 6;
            GameDescription.Text = resources.GetString("GameDescription.Text");
            // 
            // GameTitleText
            // 
            GameTitleText.AutoSize = true;
            GameTitleText.BackColor = Color.Transparent;
            GameTitleText.FlatStyle = FlatStyle.Flat;
            GameTitleText.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            GameTitleText.ForeColor = Color.White;
            GameTitleText.Location = new Point(114, 456);
            GameTitleText.Name = "GameTitleText";
            GameTitleText.Size = new Size(139, 32);
            GameTitleText.TabIndex = 7;
            GameTitleText.Text = "Game Title";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(23, 26, 33);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.DimGray;
            textBox2.Location = new Point(636, 291);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 27);
            textBox2.TabIndex = 8;
            textBox2.Text = "Release Date:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(23, 26, 33);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.DimGray;
            textBox3.Location = new Point(636, 324);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 27);
            textBox3.TabIndex = 9;
            textBox3.Text = "Developer:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(23, 26, 33);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.DimGray;
            textBox4.Location = new Point(636, 357);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 27);
            textBox4.TabIndex = 10;
            textBox4.Text = "Publisher";
            // 
            // ReleaseDateTxt
            // 
            ReleaseDateTxt.BackColor = Color.FromArgb(23, 26, 33);
            ReleaseDateTxt.BorderStyle = BorderStyle.None;
            ReleaseDateTxt.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ReleaseDateTxt.ForeColor = Color.FromArgb(179, 179, 179);
            ReleaseDateTxt.Location = new Point(762, 291);
            ReleaseDateTxt.Multiline = true;
            ReleaseDateTxt.Name = "ReleaseDateTxt";
            ReleaseDateTxt.Size = new Size(123, 27);
            ReleaseDateTxt.TabIndex = 11;
            ReleaseDateTxt.Text = "dd/mm/yyyy";
            // 
            // DeveloperTxt
            // 
            DeveloperTxt.BackColor = Color.FromArgb(23, 26, 33);
            DeveloperTxt.BorderStyle = BorderStyle.None;
            DeveloperTxt.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeveloperTxt.ForeColor = Color.FromArgb(179, 179, 179);
            DeveloperTxt.Location = new Point(738, 324);
            DeveloperTxt.Multiline = true;
            DeveloperTxt.Name = "DeveloperTxt";
            DeveloperTxt.Size = new Size(203, 27);
            DeveloperTxt.TabIndex = 12;
            DeveloperTxt.Text = "Developer";
            // 
            // PublisherTxt
            // 
            PublisherTxt.BackColor = Color.FromArgb(23, 26, 33);
            PublisherTxt.BorderStyle = BorderStyle.None;
            PublisherTxt.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PublisherTxt.ForeColor = Color.FromArgb(179, 179, 179);
            PublisherTxt.Location = new Point(727, 357);
            PublisherTxt.Multiline = true;
            PublisherTxt.Name = "PublisherTxt";
            PublisherTxt.Size = new Size(208, 27);
            PublisherTxt.TabIndex = 13;
            PublisherTxt.Text = "Publisher";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(23, 26, 33);
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.ForeColor = Color.White;
            textBox8.Location = new Point(636, 92);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(159, 27);
            textBox8.TabIndex = 14;
            textBox8.Text = "Game Description";
            // 
            // MainGameTitle
            // 
            MainGameTitle.AutoSize = true;
            MainGameTitle.BackColor = Color.Transparent;
            MainGameTitle.FlatStyle = FlatStyle.Flat;
            MainGameTitle.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MainGameTitle.ForeColor = Color.White;
            MainGameTitle.Location = new Point(130, 74);
            MainGameTitle.Name = "MainGameTitle";
            MainGameTitle.Size = new Size(155, 32);
            MainGameTitle.TabIndex = 15;
            MainGameTitle.Text = "Game Name";
            // 
            // WishlistBtn
            // 
            WishlistBtn.BackColor = Color.FromArgb(0, 106, 43);
            WishlistBtn.FlatAppearance.BorderSize = 0;
            WishlistBtn.FlatStyle = FlatStyle.Flat;
            WishlistBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            WishlistBtn.ForeColor = Color.FromArgb(111, 245, 108);
            WishlistBtn.Location = new Point(673, 484);
            WishlistBtn.Name = "WishlistBtn";
            WishlistBtn.Size = new Size(145, 32);
            WishlistBtn.TabIndex = 16;
            WishlistBtn.Text = "Wishlist";
            WishlistBtn.UseVisualStyleBackColor = false;
            WishlistBtn.Click += WishlistBtn_Click;
            // 
            // GamePrice
            // 
            GamePrice.BackColor = Color.FromArgb(69, 69, 69);
            GamePrice.BorderStyle = BorderStyle.None;
            GamePrice.Font = new Font("Segoe UI Black", 17F, FontStyle.Bold, GraphicsUnit.Point);
            GamePrice.ForeColor = Color.White;
            GamePrice.Location = new Point(536, 484);
            GamePrice.Multiline = true;
            GamePrice.Name = "GamePrice";
            GamePrice.ReadOnly = true;
            GamePrice.RightToLeft = RightToLeft.No;
            GamePrice.Size = new Size(143, 32);
            GamePrice.TabIndex = 17;
            GamePrice.Text = "R$ 000,00";
            GamePrice.TextAlign = HorizontalAlignment.Right;
            GamePrice.WordWrap = false;
            // 
            // Game0Linux
            // 
            Game0Linux.BackColor = Color.FromArgb(112, 124, 139);
            Game0Linux.BackgroundImage = Properties.Resources.LinuxIcon;
            Game0Linux.BackgroundImageLayout = ImageLayout.Zoom;
            Game0Linux.Location = new Point(788, 456);
            Game0Linux.Name = "Game0Linux";
            Game0Linux.Size = new Size(20, 20);
            Game0Linux.TabIndex = 29;
            Game0Linux.TabStop = false;
            Game0Linux.Visible = false;
            // 
            // Game0Apple
            // 
            Game0Apple.BackColor = Color.FromArgb(112, 124, 139);
            Game0Apple.BackgroundImage = Properties.Resources.AppleIcon;
            Game0Apple.BackgroundImageLayout = ImageLayout.Zoom;
            Game0Apple.Location = new Point(762, 456);
            Game0Apple.Name = "Game0Apple";
            Game0Apple.Size = new Size(20, 20);
            Game0Apple.TabIndex = 28;
            Game0Apple.TabStop = false;
            Game0Apple.Visible = false;
            // 
            // Game0Windows
            // 
            Game0Windows.BackColor = Color.FromArgb(112, 124, 139);
            Game0Windows.BackgroundImage = Properties.Resources.WindowsIcon;
            Game0Windows.BackgroundImageLayout = ImageLayout.Zoom;
            Game0Windows.Location = new Point(736, 456);
            Game0Windows.Name = "Game0Windows";
            Game0Windows.Size = new Size(20, 20);
            Game0Windows.TabIndex = 27;
            Game0Windows.TabStop = false;
            Game0Windows.Visible = false;
            // 
            // GameTags
            // 
            GameTags.BackColor = Color.FromArgb(23, 26, 33);
            GameTags.BorderStyle = BorderStyle.None;
            GameTags.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GameTags.ForeColor = Color.FromArgb(102, 192, 244);
            GameTags.Location = new Point(632, 396);
            GameTags.Name = "GameTags";
            GameTags.ReadOnly = true;
            GameTags.Size = new Size(309, 18);
            GameTags.TabIndex = 30;
            GameTags.Text = "Tags";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(23, 26, 33);
            BackBtn.BackgroundImage = Properties.Resources.BackBtn;
            BackBtn.Location = new Point(95, 73);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(34, 34);
            BackBtn.TabIndex = 31;
            BackBtn.TabStop = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // GamePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GamePage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 561);
            Controls.Add(BackBtn);
            Controls.Add(GameTags);
            Controls.Add(Game0Linux);
            Controls.Add(Game0Apple);
            Controls.Add(Game0Windows);
            Controls.Add(GamePrice);
            Controls.Add(WishlistBtn);
            Controls.Add(MainGameTitle);
            Controls.Add(textBox8);
            Controls.Add(PublisherTxt);
            Controls.Add(DeveloperTxt);
            Controls.Add(ReleaseDateTxt);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(GameTitleText);
            Controls.Add(GameDescription);
            Controls.Add(GameCover);
            Controls.Add(SbeamTitle);
            Controls.Add(Logo);
            DoubleBuffered = true;
            Name = "GamePage";
            Text = "GamePage";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)GameCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)Game0Linux).EndInit();
            ((System.ComponentModel.ISupportInitialize)Game0Apple).EndInit();
            ((System.ComponentModel.ISupportInitialize)Game0Windows).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SbeamTitle;
        private PictureBox Logo;
        private PictureBox GameCover;
        private TextBox GameDescription;
        private Label GameTitleText;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox ReleaseDateTxt;
        private TextBox DeveloperTxt;
        private TextBox PublisherTxt;
        private TextBox textBox8;
        private Label MainGameTitle;
        private Button WishlistBtn;
        private TextBox GamePrice;
        private PictureBox Game0Linux;
        private PictureBox Game0Apple;
        private PictureBox Game0Windows;
        private TextBox GameTags;
        private PictureBox BackBtn;
    }
}