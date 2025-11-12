namespace Bai04
{
    partial class BackgroundColor
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
            colorDialog1 = new ColorDialog();
            menuStrip1 = new MenuStrip();
            tsmifFormat = new ToolStripMenuItem();
            colorDialog2 = new ColorDialog();
            colorDialog3 = new ColorDialog();
            colorDialog4 = new ColorDialog();
            colorDialog5 = new ColorDialog();
            colorDialog6 = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmifFormat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmifFormat
            // 
            tsmifFormat.Name = "tsmifFormat";
            tsmifFormat.Size = new Size(74, 25);
            tsmifFormat.Text = "Format";
            tsmifFormat.Click += formatToolStripMenuItem_Click;
            // 
            // BackgroundColor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "BackgroundColor";
            Text = "BackgroundColor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmifFormat;
        private ColorDialog colorDialog2;
        private ColorDialog colorDialog3;
        private ColorDialog colorDialog4;
        private ColorDialog colorDialog5;
        private ColorDialog colorDialog6;
    }
}
