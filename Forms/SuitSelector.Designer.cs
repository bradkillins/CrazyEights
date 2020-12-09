namespace CrazyEights
{
    partial class SuitSelector
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
            this.cmb_Suit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Okay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Suit
            // 
            this.cmb_Suit.FormattingEnabled = true;
            this.cmb_Suit.Location = new System.Drawing.Point(197, 56);
            this.cmb_Suit.Margin = new System.Windows.Forms.Padding(6);
            this.cmb_Suit.Name = "cmb_Suit";
            this.cmb_Suit.Size = new System.Drawing.Size(218, 33);
            this.cmb_Suit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Suit:";
            // 
            // btn_Okay
            // 
            this.btn_Okay.Location = new System.Drawing.Point(324, 134);
            this.btn_Okay.Name = "btn_Okay";
            this.btn_Okay.Size = new System.Drawing.Size(91, 45);
            this.btn_Okay.TabIndex = 2;
            this.btn_Okay.Text = "Okay";
            this.btn_Okay.UseVisualStyleBackColor = true;
            // 
            // SuitSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 210);
            this.Controls.Add(this.btn_Okay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Suit);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SuitSelector";
            this.Text = "SuitSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Suit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Okay;
    }
}