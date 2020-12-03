namespace CrazyEights
{
    public partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.hamburgerMenuButton = new CrazyEights.HamburgerMenuButton();
            this.HeaderTitleTxt = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Btn_Settings = new CrazyEights.FlatRoundButton();
            this.Btn_GameStats = new CrazyEights.FlatRoundButton();
            this.Btn_HighScore = new CrazyEights.FlatRoundButton();
            this.Btn_Friends = new CrazyEights.FlatRoundButton();
            this.Btn_NewGameScreen = new CrazyEights.FlatRoundButton();
            this.StartGamePnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NumOfOpponents = new System.Windows.Forms.Label();
            this.Cmb_NumOfOpp = new System.Windows.Forms.ComboBox();
            this.StartGameBtn = new CrazyEights.FlatRoundButton();
            this.StartGamePic = new System.Windows.Forms.PictureBox();
            this.Txt_PlayerName = new System.Windows.Forms.TextBox();
            this.lbl_PlayerName = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.StartGamePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartGamePic)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.HeaderPanel.Controls.Add(this.hamburgerMenuButton);
            this.HeaderPanel.Controls.Add(this.HeaderTitleTxt);
            this.HeaderPanel.Controls.Add(this.MinimizeBtn);
            this.HeaderPanel.Controls.Add(this.ExitBtn);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1260, 60);
            this.HeaderPanel.TabIndex = 0;
            // 
            // hamburgerMenuButton
            // 
            this.hamburgerMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.hamburgerMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hamburgerMenuButton.Location = new System.Drawing.Point(15, 11);
            this.hamburgerMenuButton.Margin = new System.Windows.Forms.Padding(37, 44, 37, 44);
            this.hamburgerMenuButton.Name = "hamburgerMenuButton";
            this.hamburgerMenuButton.Size = new System.Drawing.Size(50, 40);
            this.hamburgerMenuButton.TabIndex = 4;
            this.hamburgerMenuButton.Click += new System.EventHandler(this.hamburgerMenuButton_Click);
            // 
            // HeaderTitleTxt
            // 
            this.HeaderTitleTxt.AutoSize = true;
            this.HeaderTitleTxt.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderTitleTxt.ForeColor = System.Drawing.Color.White;
            this.HeaderTitleTxt.Location = new System.Drawing.Point(514, 14);
            this.HeaderTitleTxt.Name = "HeaderTitleTxt";
            this.HeaderTitleTxt.Size = new System.Drawing.Size(213, 32);
            this.HeaderTitleTxt.TabIndex = 3;
            this.HeaderTitleTxt.Text = "Crazy Eights!";
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackgroundImage = global::CrazyEights.Properties.Resources.min_button_transparent;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.Color.Black;
            this.MinimizeBtn.Location = new System.Drawing.Point(1168, 14);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(32, 32);
            this.MinimizeBtn.TabIndex = 2;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::CrazyEights.Properties.Resources.close_button_transparent;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(1209, 14);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(32, 32);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.MenuPanel.Controls.Add(this.Btn_Settings);
            this.MenuPanel.Controls.Add(this.Btn_GameStats);
            this.MenuPanel.Controls.Add(this.Btn_HighScore);
            this.MenuPanel.Controls.Add(this.Btn_Friends);
            this.MenuPanel.Controls.Add(this.Btn_NewGameScreen);
            this.MenuPanel.Location = new System.Drawing.Point(-300, 60);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(400, 740);
            this.MenuPanel.TabIndex = 1;
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Settings.BorderRadius = 35F;
            this.Btn_Settings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Settings.FlatAppearance.BorderSize = 3;
            this.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Settings.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Settings.Image = global::CrazyEights.Properties.Resources.settings;
            this.Btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Settings.Location = new System.Drawing.Point(75, 608);
            this.Btn_Settings.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.Padding = new System.Windows.Forms.Padding(8);
            this.Btn_Settings.Size = new System.Drawing.Size(250, 61);
            this.Btn_Settings.TabIndex = 4;
            this.Btn_Settings.Text = "Settings";
            this.Btn_Settings.UseVisualStyleBackColor = false;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // Btn_GameStats
            // 
            this.Btn_GameStats.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_GameStats.BorderRadius = 35F;
            this.Btn_GameStats.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_GameStats.FlatAppearance.BorderSize = 3;
            this.Btn_GameStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GameStats.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GameStats.Image = global::CrazyEights.Properties.Resources.bar_chart;
            this.Btn_GameStats.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_GameStats.Location = new System.Drawing.Point(75, 471);
            this.Btn_GameStats.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_GameStats.Name = "Btn_GameStats";
            this.Btn_GameStats.Padding = new System.Windows.Forms.Padding(8);
            this.Btn_GameStats.Size = new System.Drawing.Size(250, 61);
            this.Btn_GameStats.TabIndex = 3;
            this.Btn_GameStats.Text = "Game Statistics";
            this.Btn_GameStats.UseVisualStyleBackColor = false;
            this.Btn_GameStats.Click += new System.EventHandler(this.Btn_GameStatistics_Click);
            // 
            // Btn_HighScore
            // 
            this.Btn_HighScore.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_HighScore.BorderRadius = 35F;
            this.Btn_HighScore.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_HighScore.FlatAppearance.BorderSize = 3;
            this.Btn_HighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_HighScore.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_HighScore.Image = global::CrazyEights.Properties.Resources.trophy;
            this.Btn_HighScore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_HighScore.Location = new System.Drawing.Point(75, 342);
            this.Btn_HighScore.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_HighScore.Name = "Btn_HighScore";
            this.Btn_HighScore.Padding = new System.Windows.Forms.Padding(8);
            this.Btn_HighScore.Size = new System.Drawing.Size(250, 61);
            this.Btn_HighScore.TabIndex = 2;
            this.Btn_HighScore.Text = "High Scores";
            this.Btn_HighScore.UseVisualStyleBackColor = false;
            this.Btn_HighScore.Click += new System.EventHandler(this.Btn_HighScore_Click);
            // 
            // Btn_Friends
            // 
            this.Btn_Friends.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_Friends.BorderRadius = 35F;
            this.Btn_Friends.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Friends.FlatAppearance.BorderSize = 3;
            this.Btn_Friends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Friends.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Friends.Image = global::CrazyEights.Properties.Resources.people;
            this.Btn_Friends.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Friends.Location = new System.Drawing.Point(75, 212);
            this.Btn_Friends.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Friends.Name = "Btn_Friends";
            this.Btn_Friends.Padding = new System.Windows.Forms.Padding(8);
            this.Btn_Friends.Size = new System.Drawing.Size(250, 61);
            this.Btn_Friends.TabIndex = 1;
            this.Btn_Friends.Text = "Friends";
            this.Btn_Friends.UseVisualStyleBackColor = false;
            this.Btn_Friends.Click += new System.EventHandler(this.Btn_Friends_Click);
            // 
            // Btn_NewGameScreen
            // 
            this.Btn_NewGameScreen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_NewGameScreen.BorderRadius = 35F;
            this.Btn_NewGameScreen.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.Btn_NewGameScreen.FlatAppearance.BorderSize = 3;
            this.Btn_NewGameScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NewGameScreen.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NewGameScreen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Btn_NewGameScreen.Image = ((System.Drawing.Image)(resources.GetObject("Btn_NewGameScreen.Image")));
            this.Btn_NewGameScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_NewGameScreen.Location = new System.Drawing.Point(75, 84);
            this.Btn_NewGameScreen.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_NewGameScreen.Name = "Btn_NewGameScreen";
            this.Btn_NewGameScreen.Padding = new System.Windows.Forms.Padding(8);
            this.Btn_NewGameScreen.Size = new System.Drawing.Size(250, 61);
            this.Btn_NewGameScreen.TabIndex = 0;
            this.Btn_NewGameScreen.Text = "New Game";
            this.Btn_NewGameScreen.UseVisualStyleBackColor = false;
            // 
            // StartGamePnl
            // 
            this.StartGamePnl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.StartGamePnl.Controls.Add(this.lbl_PlayerName);
            this.StartGamePnl.Controls.Add(this.Txt_PlayerName);
            this.StartGamePnl.Controls.Add(this.label1);
            this.StartGamePnl.Controls.Add(this.lbl_NumOfOpponents);
            this.StartGamePnl.Controls.Add(this.Cmb_NumOfOpp);
            this.StartGamePnl.Controls.Add(this.StartGameBtn);
            this.StartGamePnl.Location = new System.Drawing.Point(0, 490);
            this.StartGamePnl.Name = "StartGamePnl";
            this.StartGamePnl.Size = new System.Drawing.Size(1260, 310);
            this.StartGamePnl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(502, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start a New Game!";
            // 
            // lbl_NumOfOpponents
            // 
            this.lbl_NumOfOpponents.AutoSize = true;
            this.lbl_NumOfOpponents.Location = new System.Drawing.Point(500, 142);
            this.lbl_NumOfOpponents.Name = "lbl_NumOfOpponents";
            this.lbl_NumOfOpponents.Size = new System.Drawing.Size(109, 25);
            this.lbl_NumOfOpponents.TabIndex = 3;
            this.lbl_NumOfOpponents.Text = "Opponents:";
            // 
            // Cmb_NumOfOpp
            // 
            this.Cmb_NumOfOpp.FormattingEnabled = true;
            this.Cmb_NumOfOpp.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
            this.Cmb_NumOfOpp.Location = new System.Drawing.Point(615, 139);
            this.Cmb_NumOfOpp.Name = "Cmb_NumOfOpp";
            this.Cmb_NumOfOpp.Size = new System.Drawing.Size(99, 33);
            this.Cmb_NumOfOpp.TabIndex = 2;
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.StartGameBtn.BorderRadius = 35F;
            this.StartGameBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.StartGameBtn.FlatAppearance.BorderSize = 2;
            this.StartGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGameBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameBtn.Location = new System.Drawing.Point(520, 201);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(227, 61);
            this.StartGameBtn.TabIndex = 0;
            this.StartGameBtn.Text = "Start Game!";
            this.StartGameBtn.UseVisualStyleBackColor = false;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // StartGamePic
            // 
            this.StartGamePic.Image = global::CrazyEights.Properties.Resources.poker_cards_big;
            this.StartGamePic.Location = new System.Drawing.Point(440, 89);
            this.StartGamePic.Name = "StartGamePic";
            this.StartGamePic.Size = new System.Drawing.Size(369, 360);
            this.StartGamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartGamePic.TabIndex = 2;
            this.StartGamePic.TabStop = false;
            // 
            // Txt_PlayerName
            // 
            this.Txt_PlayerName.Location = new System.Drawing.Point(615, 90);
            this.Txt_PlayerName.MaxLength = 50;
            this.Txt_PlayerName.Name = "Txt_PlayerName";
            this.Txt_PlayerName.Size = new System.Drawing.Size(179, 33);
            this.Txt_PlayerName.TabIndex = 5;
            // 
            // lbl_PlayerName
            // 
            this.lbl_PlayerName.AutoSize = true;
            this.lbl_PlayerName.Location = new System.Drawing.Point(451, 93);
            this.lbl_PlayerName.Name = "lbl_PlayerName";
            this.lbl_PlayerName.Size = new System.Drawing.Size(158, 25);
            this.lbl_PlayerName.TabIndex = 6;
            this.lbl_PlayerName.Text = "Enter Your Name:";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1260, 800);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.StartGamePnl);
            this.Controls.Add(this.StartGamePic);
            this.Controls.Add(this.HeaderPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crazy8s";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.StartGamePnl.ResumeLayout(false);
            this.StartGamePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartGamePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private FlatRoundButton Btn_NewGameScreen;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private FlatRoundButton Btn_Settings;
        private FlatRoundButton Btn_GameStats;
        private FlatRoundButton Btn_HighScore;
        private FlatRoundButton Btn_Friends;
        private System.Windows.Forms.Label HeaderTitleTxt;
        private System.Windows.Forms.PictureBox StartGamePic;
        private System.Windows.Forms.Panel StartGamePnl;
        private FlatRoundButton StartGameBtn;
        private System.Windows.Forms.ComboBox Cmb_NumOfOpp;
        private System.Windows.Forms.Label lbl_NumOfOpponents;
        private HamburgerMenuButton hamburgerMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PlayerName;
        private System.Windows.Forms.TextBox Txt_PlayerName;
    }
}

