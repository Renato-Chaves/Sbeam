namespace Sbeam
{
    partial class AddGame
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
            Logo = new PictureBox();
            SbeamTitle = new Label();
            GameCover = new PictureBox();
            GameCoverInput = new TextBox();
            AddGame_title = new Label();
            label1 = new Label();
            GameTitleInput = new TextBox();
            label2 = new Label();
            DescriptionInput = new TextBox();
            label3 = new Label();
            PublishGameBtn = new Button();
            TagDropDown = new ComboBox();
            TagList = new CheckedListBox();
            AddTagBtn = new Button();
            label4 = new Label();
            WindowsCheckBox = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            AppleCheckBox = new CheckBox();
            pictureBox3 = new PictureBox();
            LinuxCheckBox = new CheckBox();
            DeveloperInput = new TextBox();
            PublisherInput = new TextBox();
            DateInput = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            PriceInput = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GameCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceInput).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackColor = Color.FromArgb(23, 26, 33);
            Logo.BackgroundImage = Properties.Resources.SbeamLogo;
            Logo.Location = new Point(99, 6);
            Logo.Name = "Logo";
            Logo.Size = new Size(35, 37);
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // SbeamTitle
            // 
            SbeamTitle.AutoSize = true;
            SbeamTitle.BackColor = Color.FromArgb(23, 26, 33);
            SbeamTitle.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SbeamTitle.ForeColor = Color.White;
            SbeamTitle.Location = new Point(150, 8);
            SbeamTitle.Name = "SbeamTitle";
            SbeamTitle.Size = new Size(92, 32);
            SbeamTitle.TabIndex = 2;
            SbeamTitle.Text = "Sbeam";
            // 
            // GameCover
            // 
            GameCover.BackColor = Color.FromArgb(31, 31, 31);
            GameCover.BackgroundImageLayout = ImageLayout.Zoom;
            GameCover.Location = new Point(161, 150);
            GameCover.Name = "GameCover";
            GameCover.Size = new Size(295, 118);
            GameCover.TabIndex = 3;
            GameCover.TabStop = false;
            // 
            // GameCoverInput
            // 
            GameCoverInput.Anchor = AnchorStyles.None;
            GameCoverInput.BackColor = Color.FromArgb(163, 163, 163);
            GameCoverInput.BorderStyle = BorderStyle.None;
            GameCoverInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GameCoverInput.Location = new Point(157, 275);
            GameCoverInput.Name = "GameCoverInput";
            GameCoverInput.PlaceholderText = "Add Cover Link";
            GameCoverInput.Size = new Size(305, 22);
            GameCoverInput.TabIndex = 4;
            GameCoverInput.TextAlign = HorizontalAlignment.Center;
            GameCoverInput.WordWrap = false;
            GameCoverInput.TextChanged += GameCoverInput_TextChanged;
            // 
            // AddGame_title
            // 
            AddGame_title.AutoSize = true;
            AddGame_title.BackColor = Color.FromArgb(23, 26, 33);
            AddGame_title.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            AddGame_title.ForeColor = Color.White;
            AddGame_title.Location = new Point(496, 69);
            AddGame_title.Name = "AddGame_title";
            AddGame_title.Size = new Size(117, 41);
            AddGame_title.TabIndex = 5;
            AddGame_title.Text = "Sbeam";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(42, 71, 94);
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(731, 150);
            label1.Name = "label1";
            label1.Size = new Size(66, 32);
            label1.TabIndex = 6;
            label1.Text = "Title";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameTitleInput
            // 
            GameTitleInput.Anchor = AnchorStyles.None;
            GameTitleInput.BackColor = Color.FromArgb(116, 130, 143);
            GameTitleInput.BorderStyle = BorderStyle.None;
            GameTitleInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            GameTitleInput.ForeColor = Color.White;
            GameTitleInput.Location = new Point(553, 184);
            GameTitleInput.Name = "GameTitleInput";
            GameTitleInput.PlaceholderText = "Add Game Title";
            GameTitleInput.Size = new Size(423, 25);
            GameTitleInput.TabIndex = 7;
            GameTitleInput.TextAlign = HorizontalAlignment.Center;
            GameTitleInput.WordWrap = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(42, 71, 94);
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(687, 210);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 8;
            label2.Text = "Description";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // DescriptionInput
            // 
            DescriptionInput.Anchor = AnchorStyles.None;
            DescriptionInput.BackColor = Color.FromArgb(116, 130, 143);
            DescriptionInput.BorderStyle = BorderStyle.None;
            DescriptionInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionInput.ForeColor = Color.White;
            DescriptionInput.Location = new Point(553, 251);
            DescriptionInput.Multiline = true;
            DescriptionInput.Name = "DescriptionInput";
            DescriptionInput.PlaceholderText = "Add Game Title";
            DescriptionInput.Size = new Size(423, 96);
            DescriptionInput.TabIndex = 9;
            DescriptionInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(42, 71, 94);
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(728, 348);
            label3.Name = "label3";
            label3.Size = new Size(69, 32);
            label3.TabIndex = 10;
            label3.Text = "Tags";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PublishGameBtn
            // 
            PublishGameBtn.Anchor = AnchorStyles.None;
            PublishGameBtn.AutoSize = true;
            PublishGameBtn.BackgroundImage = Properties.Resources.PublishGame_btn_BG;
            PublishGameBtn.BackgroundImageLayout = ImageLayout.Stretch;
            PublishGameBtn.FlatAppearance.BorderSize = 0;
            PublishGameBtn.FlatStyle = FlatStyle.Flat;
            PublishGameBtn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            PublishGameBtn.ForeColor = Color.FromArgb(3, 124, 169);
            PublishGameBtn.Location = new Point(600, 489);
            PublishGameBtn.Name = "PublishGameBtn";
            PublishGameBtn.Size = new Size(325, 35);
            PublishGameBtn.TabIndex = 11;
            PublishGameBtn.Text = "Publish Game";
            PublishGameBtn.UseVisualStyleBackColor = true;
            PublishGameBtn.Click += PublishGameBtn_Click;
            // 
            // TagDropDown
            // 
            TagDropDown.BackColor = Color.FromArgb(116, 130, 143);
            TagDropDown.ForeColor = Color.FromArgb(18, 18, 18);
            TagDropDown.FormattingEnabled = true;
            TagDropDown.Items.AddRange(new object[] { "Indie", "Action", "Adventure", "Casual", "RPG", "Simulation", "Strategy", "Singleplayer", "Early Access", "Free to Play", "2D", "3D", "Atmospheric", "Fantasy", "Story Rich", "Colorful", "Multiplayer", "Puzzle", "Pixel Graphics", "Massively Multiplayer", "Exploration", "Sports", "Cute", "Violent", "First-Person", "Combat", "Racing", "Anime", "Sexual Content", "Nudity", "Arcade", "Action-Adventure", "Funny", "Sci-fi", "Shooter", "Relaxing", "Gore", "Horror", "Retro", "Family Friendly", "Third Person", "Controller", "Female Protagonist", "Stylized", "Open World", "Platformer", "Co-op", "Survival", "PvP", "Top-Down", "Choices Matter", "Realistic", "Comedy", "PvE", "Visual Novel", "Dark", "Character Customization", "Physics", "Cartoony", "Mystery", "Linear", "FPS", "Old School", "2D Platformer", "Multiple Endings", "Online Co-Op", "Difficult", "VR", "Psychological Horror", "Magic", "Medieval", "Great Soundtrack", "Sandbox", "Tactical", "Action RPG", "Futuristic", "Minimalist", "Space", "Building", "Hand-drawn", "Point & Click", "Crafting", "Management", "Shoot 'Em Up", "Roguelike", "Drama", "Cartoon", "Local Multiplayer", "Design & Illustration", "Roguelite", "Side Scroller", "Resource Management", "Procedural Generation", "Dark Fantasy", "Logic", "3D Platformer", "Mature", "Survival Horror", "Choose Your Own Adventure", "Education", "Puzzle Platformer", "Romance", "Turn-Based Combat", "1980s", "Emotional", "Utilities", "Hack and Slash", "Turn-Based Strategy", "Immersive Sim", "War", "Interactive Fiction", "Turn-Based Tactics", "Tabletop", "Hentai", "Nature", "Post-apocalyptic", "Zombies", "Base Building", "Dating Sim", "Action Roguelike", "Hidden Object", "Surreal", "1990's", "JRPG", "Bullet Hell", "Local Co-Op", "Dungeon Crawler", "Historical", "Party-Based RPG", "Stealth", "Replay Value", "Narration", "Walking Simulator", "Score Attack", "Turn-Based", "NSFW", "Military", "Cinematic", "Text-Based", "Third-Person Shooter", "Conversation", "Top-Down Shooter", "LGBTQ+", "2.5D", "Aliens", "Cyberpunk", "Web Publishing", "Memes", "Investigation", "Isometric", "Robots", "Team-Based", "Dark Humor", "Nonlinear", "Card Game", "Inventory Management", "Lore-Rich", "Life Sim", "RTS", "Artificial Intelligence", "Tutorial", "Demons", "Strategy RPG", "Clicker", "Psychological", "Abstract", "Thriller", "Perma Death", "Arena Shooter", "Economy", "Real Time Tactics", "Detective", "Fast-Paced", "Supernatural", "Driving", "Board Game", "Modern", "Short", "Animation & Modeling", "Dystopian", "Precision Platformer", "Software", "Time Management", "Psychedelic", "4 Player Local", "Tower Defense", "Loot", "Tactical RPG", "Flight", "City Builder", "Classic", "Souls-like", "Comic Book", "Wargame", "Music", "Alternate History", "Beat 'em up", "Metroidvania", "Soundtrack", "RPGMaker", "Destruction", "Moddable", "Movie", "Mythology", "Level Editor", "Fighting", "Runner", "Collectathon", "Game Development", "Experimental", "Beautiful", "Grid-Based Movement", "Crime", "Parkour", "2D Fighter", "Idler", "Deckbuilding", "CRPG", "Video Production", "Audio Production", "Class-Based", "Competitive", "MMORPG", "Dark Comedy", "Philosophical", "Gun Customization", "Card Battler", "Twin Stick Shooter", "Science", "World War II", "Automobile Sim", "Cats", "Co-op Campaign", "Rhythm", "Vehicular Combat", "Swordplay", "Grand Strategy", "3D Fighter", "Space Sim", "Dragons", "Lovecraftian", "Battle Royale", "eSports", "6DOF", "Capitalism", "3D Vision", "America", "Automation", "Split Screen", "Noir", "Conspiracy", "Match 3", "Parody", "Software Training", "Creature Collector", "Blood", "Bullet Time", "Colony Sim", "Farming Sim", "Trading", "Quick-Time Events", "Satire", "Character Action Game", "Mystery Dungeon", "Hero Shooter", "Time Manipulation", "Dynamic Narration", "Looter Shooter", "Gothic", "Open World Survival Craft", "Underground", "Word Game", "Agriculture", "Cooking", "Political", "Voxel", "Addictive", "Steampunk", "Spectacle fighter", "Mining", "Martial Arts", "Mechs", "Time Travel", "Illuminati", "Combat Racing", "Hunting", "Otome", "Dog", "Solitaire", "Pirates", "MOBA", "Tanks", "Asynchronous Multiplayer", "God Game", "Vampire", "Ninja", "Auto Battler", "Hex Grid", "Hacking", "Fishing", "Immersive", "Photo Editing", "Trading Card Game", "Remake", "Mouse only", "FMV", "Politics", "Narrative", "Assassin", "Action RTS", "Real-Time", "Underwater", "Episodic", "4X", "Superhero", "Cold War", "Cult Classic", "Faith", "Epic", "Dinosaurs", "Programming", "Sokoban", "Political Sim", "Western", "Heist", "Party", "Party Game", "Diplomacy", "Transportation", "Naval", "Trains", "Archery", "Foreign", "Minigames", "Gambling", "Snow", "Real-Time with Pause", "Naval Combat", "Cozy", "Transhumanism", "Typing", "Wholesome", "Escape Room", "Sailing", "Dungeons & Dragons", "Villain Protagonist", "Roguelike Deckbuilder", "Sequel", "Sniper", "Kickstarter", "Nostalgia", "Music-Based Procedural Generation", "On-Rails Shooter", "Mod", "Traditional Roguelike", "Werewolves", "Mars", "Offroad", "Football (Soccer)", "Time Attack", "Experience", "Touch-Friendly", "Trivia", "World War I", "360 Video", "GameMaker", "Horses", "Farming", "Boxing", "Games Workshop", "Gaming", "Jet", "Chess", "Outbreak Sim", "Documentary", "Spaceships", "Silent Protagonist", "Unforgiving", "Motorbike", "Medical Sim", "Golf", "Spelling", "Asymmetric VR", "LEGO", "Rome", "Bikes", "Roguevania", "Electronic Music", "Submarine", "Crowdfunded", "Basketball", "Ambient", "Football (American)", "Pinball", "Social Deduction", "Instrumental Music", "Mini Golf", "TrackIR", "Warhammer 40K", "Skateboarding", "Wrestling", "Rock Music", "Vikings", "Pool", "Jump Scare", "Based On A Novel", "Baseball", "Cycling", "Skating", "Tennis", "Intentionally Awkward Controls", "Motocross", "Boss Rush", "Bowling", "8-bit Music", "Tile-Matching", "Lemmings", "Job Simulator", "Hockey", "Steam Machine", "Well-Written", "Benchmark", "Hardware", "BMX", "Snowboarding", "ATV", "Skiing", "Mahjong", "Electronic", "Voice Control", "Feature Film", "Musou", "Shop Keeper", "Birds", "Extraction Shooter", "Fox", "Rugby", "Volleyball", "Coding", "Reboot", "Hobby Sim", "Cricket", "Snooker" });
            TagDropDown.Location = new Point(600, 396);
            TagDropDown.Name = "TagDropDown";
            TagDropDown.RightToLeft = RightToLeft.No;
            TagDropDown.Size = new Size(150, 23);
            TagDropDown.TabIndex = 12;
            // 
            // TagList
            // 
            TagList.BackColor = Color.FromArgb(116, 130, 143);
            TagList.ForeColor = Color.FromArgb(18, 18, 18);
            TagList.FormattingEnabled = true;
            TagList.Location = new Point(774, 396);
            TagList.Name = "TagList";
            TagList.Size = new Size(151, 80);
            TagList.TabIndex = 13;
            TagList.ItemCheck += TagList_ItemCheck;
            TagList.SelectedIndexChanged += TagList_SelectedIndexChanged;
            // 
            // AddTagBtn
            // 
            AddTagBtn.BackColor = Color.FromArgb(137, 137, 137);
            AddTagBtn.BackgroundImageLayout = ImageLayout.None;
            AddTagBtn.FlatAppearance.BorderSize = 0;
            AddTagBtn.FlatStyle = FlatStyle.Flat;
            AddTagBtn.ForeColor = Color.White;
            AddTagBtn.Location = new Point(633, 439);
            AddTagBtn.Name = "AddTagBtn";
            AddTagBtn.Size = new Size(75, 23);
            AddTagBtn.TabIndex = 14;
            AddTagBtn.Text = "AddTag";
            AddTagBtn.UseVisualStyleBackColor = false;
            AddTagBtn.Click += AddTagBtn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(42, 71, 94);
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(245, 326);
            label4.Name = "label4";
            label4.Size = new Size(120, 30);
            label4.TabIndex = 15;
            label4.Text = "Platforms";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // WindowsCheckBox
            // 
            WindowsCheckBox.AutoSize = true;
            WindowsCheckBox.Location = new Point(200, 365);
            WindowsCheckBox.Name = "WindowsCheckBox";
            WindowsCheckBox.Size = new Size(15, 14);
            WindowsCheckBox.TabIndex = 16;
            WindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.WindowsIcon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(220, 362);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.AppleIcon;
            pictureBox2.Location = new Point(290, 362);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // AppleCheckBox
            // 
            AppleCheckBox.AutoSize = true;
            AppleCheckBox.Location = new Point(270, 365);
            AppleCheckBox.Name = "AppleCheckBox";
            AppleCheckBox.Size = new Size(15, 14);
            AppleCheckBox.TabIndex = 18;
            AppleCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.LinuxIcon;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(360, 362);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // LinuxCheckBox
            // 
            LinuxCheckBox.AutoSize = true;
            LinuxCheckBox.Location = new Point(340, 365);
            LinuxCheckBox.Name = "LinuxCheckBox";
            LinuxCheckBox.Size = new Size(15, 14);
            LinuxCheckBox.TabIndex = 20;
            LinuxCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeveloperInput
            // 
            DeveloperInput.Anchor = AnchorStyles.None;
            DeveloperInput.BackColor = Color.FromArgb(116, 130, 143);
            DeveloperInput.BorderStyle = BorderStyle.None;
            DeveloperInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DeveloperInput.ForeColor = Color.White;
            DeveloperInput.Location = new Point(150, 425);
            DeveloperInput.Name = "DeveloperInput";
            DeveloperInput.PlaceholderText = "Developer";
            DeveloperInput.Size = new Size(142, 25);
            DeveloperInput.TabIndex = 22;
            DeveloperInput.TextAlign = HorizontalAlignment.Center;
            DeveloperInput.WordWrap = false;
            // 
            // PublisherInput
            // 
            PublisherInput.Anchor = AnchorStyles.None;
            PublisherInput.BackColor = Color.FromArgb(116, 130, 143);
            PublisherInput.BorderStyle = BorderStyle.None;
            PublisherInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PublisherInput.ForeColor = Color.White;
            PublisherInput.Location = new Point(315, 425);
            PublisherInput.Name = "PublisherInput";
            PublisherInput.PlaceholderText = "Publisher";
            PublisherInput.Size = new Size(147, 25);
            PublisherInput.TabIndex = 23;
            PublisherInput.TextAlign = HorizontalAlignment.Center;
            PublisherInput.WordWrap = false;
            // 
            // DateInput
            // 
            DateInput.Location = new Point(150, 495);
            DateInput.Name = "DateInput";
            DateInput.Size = new Size(142, 24);
            DateInput.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(42, 71, 94);
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(166, 394);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 25;
            label5.Text = "Developer";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(42, 71, 94);
            label6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(340, 397);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 26;
            label6.Text = "Publisher";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(42, 71, 94);
            label7.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(155, 467);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 27;
            label7.Text = "Release Date";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(42, 71, 94);
            label8.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(360, 467);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 28;
            label8.Text = "Price";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // PriceInput
            // 
            PriceInput.DecimalPlaces = 2;
            PriceInput.Location = new Point(336, 495);
            PriceInput.Name = "PriceInput";
            PriceInput.Size = new Size(120, 24);
            PriceInput.TabIndex = 29;
            // 
            // AddGame
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 71, 94);
            BackgroundImage = Properties.Resources.AddGame_BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1152, 561);
            Controls.Add(PriceInput);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(DateInput);
            Controls.Add(PublisherInput);
            Controls.Add(DeveloperInput);
            Controls.Add(pictureBox3);
            Controls.Add(LinuxCheckBox);
            Controls.Add(pictureBox2);
            Controls.Add(AppleCheckBox);
            Controls.Add(pictureBox1);
            Controls.Add(WindowsCheckBox);
            Controls.Add(label4);
            Controls.Add(AddTagBtn);
            Controls.Add(TagList);
            Controls.Add(TagDropDown);
            Controls.Add(PublishGameBtn);
            Controls.Add(label3);
            Controls.Add(DescriptionInput);
            Controls.Add(label2);
            Controls.Add(GameTitleInput);
            Controls.Add(label1);
            Controls.Add(AddGame_title);
            Controls.Add(GameCoverInput);
            Controls.Add(GameCover);
            Controls.Add(SbeamTitle);
            Controls.Add(Logo);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "AddGame";
            Text = "AddGame";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)GameCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Logo;
        private Label SbeamTitle;
        private PictureBox GameCover;
        private TextBox GameCoverInput;
        private Label AddGame_title;
        private Label label1;
        private TextBox GameTitleInput;
        private Label label2;
        private TextBox DescriptionInput;
        private Label label3;
        private Button PublishGameBtn;
        private ComboBox TagDropDown;
        private CheckedListBox TagList;
        private Button AddTagBtn;
        private Label label4;
        private CheckBox WindowsCheckBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox AppleCheckBox;
        private PictureBox pictureBox3;
        private CheckBox LinuxCheckBox;
        private TextBox DeveloperInput;
        private TextBox PublisherInput;
        private DateTimePicker DateInput;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown PriceInput;
    }
}