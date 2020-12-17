namespace CrazyEights
{
    partial class Gameboard
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
            this.btnEndGame = new System.Windows.Forms.Button();
            this.lbl_numOfOpps = new System.Windows.Forms.Label();
            this.NumOfOppsText = new System.Windows.Forms.Label();
            this.lblTrumpSuit = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.suitDropDown = new System.Windows.Forms.ComboBox();
            this.lblSuitTitle = new System.Windows.Forms.Label();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEndGame
            // 
            this.btnEndGame.Location = new System.Drawing.Point(1125, 12);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(123, 56);
            this.btnEndGame.TabIndex = 1;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // lbl_numOfOpps
            // 
            this.lbl_numOfOpps.AutoSize = true;
            this.lbl_numOfOpps.Location = new System.Drawing.Point(495, 12);
            this.lbl_numOfOpps.Name = "lbl_numOfOpps";
            this.lbl_numOfOpps.Size = new System.Drawing.Size(205, 25);
            this.lbl_numOfOpps.TabIndex = 4;
            this.lbl_numOfOpps.Text = "Number of Opponents:";
            this.lbl_numOfOpps.Visible = false;
            // 
            // NumOfOppsText
            // 
            this.NumOfOppsText.AutoSize = true;
            this.NumOfOppsText.Location = new System.Drawing.Point(706, 12);
            this.NumOfOppsText.Name = "NumOfOppsText";
            this.NumOfOppsText.Size = new System.Drawing.Size(22, 25);
            this.NumOfOppsText.TabIndex = 5;
            this.NumOfOppsText.Text = "0";
            this.NumOfOppsText.Visible = false;
            // 
            // lblTrumpSuit
            // 
            this.lblTrumpSuit.AutoSize = true;
            this.lblTrumpSuit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrumpSuit.Location = new System.Drawing.Point(31, 12);
            this.lblTrumpSuit.Name = "lblTrumpSuit";
            this.lblTrumpSuit.Size = new System.Drawing.Size(27, 25);
            this.lblTrumpSuit.TabIndex = 7;
            this.lblTrumpSuit.Text = "H";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "Shuffle DrawPile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // suitDropDown
            // 
            this.suitDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suitDropDown.FormattingEnabled = true;
            this.suitDropDown.Location = new System.Drawing.Point(271, 4);
            this.suitDropDown.Name = "suitDropDown";
            this.suitDropDown.Size = new System.Drawing.Size(228, 33);
            this.suitDropDown.TabIndex = 6;
            this.suitDropDown.Visible = false;
            // 
            // lblSuitTitle
            // 
            this.lblSuitTitle.AutoSize = true;
            this.lblSuitTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuitTitle.Location = new System.Drawing.Point(37, 113);
            this.lblSuitTitle.Name = "lblSuitTitle";
            this.lblSuitTitle.Size = new System.Drawing.Size(52, 25);
            this.lblSuitTitle.TabIndex = 9;
            this.lblSuitTitle.Text = "Suit:";
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Location = new System.Drawing.Point(1125, 74);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(123, 56);
            this.btnHowToPlay.TabIndex = 10;
            this.btnHowToPlay.Text = "How to Play";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // Gameboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1260, 740);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.lblSuitTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTrumpSuit);
            this.Controls.Add(this.suitDropDown);
            this.Controls.Add(this.NumOfOppsText);
            this.Controls.Add(this.lbl_numOfOpps);
            this.Controls.Add(this.btnEndGame);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Gameboard";
            this.Text = "Gameboard";
            this.Load += new System.EventHandler(this.Gameboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Label lbl_numOfOpps;
        private System.Windows.Forms.Label NumOfOppsText;
        private System.Windows.Forms.Label lblTrumpSuit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox suitDropDown;
        private System.Windows.Forms.Label lblSuitTitle;
        private System.Windows.Forms.Button btnHowToPlay;
    }
}