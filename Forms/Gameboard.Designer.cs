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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // NumOfOppsText
            // 
            this.NumOfOppsText.AutoSize = true;
            this.NumOfOppsText.Location = new System.Drawing.Point(706, 12);
            this.NumOfOppsText.Name = "NumOfOppsText";
            this.NumOfOppsText.Size = new System.Drawing.Size(22, 25);
            this.NumOfOppsText.TabIndex = 5;
            this.NumOfOppsText.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(858, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(869, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Gameboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1260, 740);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}