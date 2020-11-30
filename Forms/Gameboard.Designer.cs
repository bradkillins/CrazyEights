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
            this.lbl_gameboardTitle = new System.Windows.Forms.Label();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.lbl_numOfOpps = new System.Windows.Forms.Label();
            this.NumOfOppsText = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lbl_ContainsTest = new System.Windows.Forms.Label();
            this.TestHand = new System.Windows.Forms.Label();
            this.TestPile = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_gameboardTitle
            // 
            this.lbl_gameboardTitle.AutoSize = true;
            this.lbl_gameboardTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameboardTitle.Location = new System.Drawing.Point(480, 43);
            this.lbl_gameboardTitle.Name = "lbl_gameboardTitle";
            this.lbl_gameboardTitle.Size = new System.Drawing.Size(238, 50);
            this.lbl_gameboardTitle.TabIndex = 0;
            this.lbl_gameboardTitle.Text = "Gameboard!";
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
            this.lbl_numOfOpps.Location = new System.Drawing.Point(484, 113);
            this.lbl_numOfOpps.Name = "lbl_numOfOpps";
            this.lbl_numOfOpps.Size = new System.Drawing.Size(205, 25);
            this.lbl_numOfOpps.TabIndex = 4;
            this.lbl_numOfOpps.Text = "Number of Opponents:";
            // 
            // NumOfOppsText
            // 
            this.NumOfOppsText.AutoSize = true;
            this.NumOfOppsText.Location = new System.Drawing.Point(695, 113);
            this.NumOfOppsText.Name = "NumOfOppsText";
            this.NumOfOppsText.Size = new System.Drawing.Size(22, 25);
            this.NumOfOppsText.TabIndex = 5;
            this.NumOfOppsText.Text = "0";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(638, 138);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(42, 25);
            this.lblTest.TabIndex = 6;
            this.lblTest.Text = "No!";
            // 
            // lbl_ContainsTest
            // 
            this.lbl_ContainsTest.AutoSize = true;
            this.lbl_ContainsTest.Location = new System.Drawing.Point(514, 138);
            this.lbl_ContainsTest.Name = "lbl_ContainsTest";
            this.lbl_ContainsTest.Size = new System.Drawing.Size(118, 25);
            this.lbl_ContainsTest.TabIndex = 7;
            this.lbl_ContainsTest.Text = "Card in Pile?";
            // 
            // TestHand
            // 
            this.TestHand.AutoSize = true;
            this.TestHand.BackColor = System.Drawing.Color.LightGreen;
            this.TestHand.Location = new System.Drawing.Point(259, 613);
            this.TestHand.MaximumSize = new System.Drawing.Size(670, 170);
            this.TestHand.MinimumSize = new System.Drawing.Size(670, 170);
            this.TestHand.Name = "TestHand";
            this.TestHand.Size = new System.Drawing.Size(670, 170);
            this.TestHand.TabIndex = 9;
            this.TestHand.Text = "Player Hand";
            this.TestHand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestPile
            // 
            this.TestPile.AutoSize = true;
            this.TestPile.BackColor = System.Drawing.Color.LightBlue;
            this.TestPile.Location = new System.Drawing.Point(514, 309);
            this.TestPile.MaximumSize = new System.Drawing.Size(160, 180);
            this.TestPile.MinimumSize = new System.Drawing.Size(160, 180);
            this.TestPile.Name = "TestPile";
            this.TestPile.Size = new System.Drawing.Size(160, 180);
            this.TestPile.TabIndex = 10;
            this.TestPile.Text = "Discard Pile";
            this.TestPile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Draw Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gameboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1260, 810);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TestPile);
            this.Controls.Add(this.TestHand);
            this.Controls.Add(this.lbl_ContainsTest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.NumOfOppsText);
            this.Controls.Add(this.lbl_numOfOpps);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.lbl_gameboardTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Gameboard";
            this.Text = "Gameboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gameboardTitle;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Label lbl_numOfOpps;
        private System.Windows.Forms.Label NumOfOppsText;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lbl_ContainsTest;
        private System.Windows.Forms.Label TestHand;
        private System.Windows.Forms.Label TestPile;
        private System.Windows.Forms.Button button1;
    }
}