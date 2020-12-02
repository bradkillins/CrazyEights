﻿namespace CrazyEights
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
            this.SuspendLayout();
            // 
            // lbl_gameboardTitle
            // 
            this.lbl_gameboardTitle.AutoSize = true;
            this.lbl_gameboardTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameboardTitle.Location = new System.Drawing.Point(497, 43);
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
            this.lbl_numOfOpps.Location = new System.Drawing.Point(501, 113);
            this.lbl_numOfOpps.Name = "lbl_numOfOpps";
            this.lbl_numOfOpps.Size = new System.Drawing.Size(205, 25);
            this.lbl_numOfOpps.TabIndex = 4;
            this.lbl_numOfOpps.Text = "Number of Opponents:";
            // 
            // NumOfOppsText
            // 
            this.NumOfOppsText.AutoSize = true;
            this.NumOfOppsText.Location = new System.Drawing.Point(712, 113);
            this.NumOfOppsText.Name = "NumOfOppsText";
            this.NumOfOppsText.Size = new System.Drawing.Size(22, 25);
            this.NumOfOppsText.TabIndex = 5;
            this.NumOfOppsText.Text = "0";
            // 
            // Gameboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1260, 810);
            this.Controls.Add(this.NumOfOppsText);
            this.Controls.Add(this.lbl_numOfOpps);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.lbl_gameboardTitle);
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

        private System.Windows.Forms.Label lbl_gameboardTitle;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Label lbl_numOfOpps;
        private System.Windows.Forms.Label NumOfOppsText;
    }
}