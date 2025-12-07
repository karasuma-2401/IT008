namespace Bai08
{
    partial class FormAnalogClock
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
            components = new System.ComponentModel.Container();
            Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += timer1_Tick;
            // 
            // FormAnalogClock
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Name = "FormAnalogClock";
            Text = "Analog Clock";
            Paint += FormAnalogClock_Paint;
            Resize += FormAnalogClock_Resize;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
    }
}
