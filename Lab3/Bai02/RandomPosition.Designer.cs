namespace Bai02
{
    partial class RandomPosition
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRandom = new Button();
            SuspendLayout();
            // 
            // btnRandom
            // 
            btnRandom.BackColor = Color.FromArgb(0, 192, 192);
            btnRandom.Location = new Point(4, 11);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(120, 40);
            btnRandom.TabIndex = 1;
            btnRandom.Text = "RANDOM";
            btnRandom.UseVisualStyleBackColor = false;
            btnRandom.Click += Button1_Click_1;
            // 
            // RandomPosition
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRandom);
            Name = "RandomPosition";
            Text = "RandomPosition";
            Paint += Form1_paint;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRandom;
    }
}
