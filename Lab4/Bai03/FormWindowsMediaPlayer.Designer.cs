namespace Bai03
{
    partial class FormWindowsMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWindowsMediaPlayer));
            msMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            tsmiOpen = new ToolStripMenuItem();
            tsmiExit = new ToolStripMenuItem();
            statusStripMain = new StatusStrip();
            tsslDate = new ToolStripStatusLabel();
            timerMain = new System.Windows.Forms.Timer(components);
            axWMPMain = new AxWMPLib.AxWindowsMediaPlayer();
            msMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWMPMain).BeginInit();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(20, 20);
            msMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(719, 29);
            msMain.TabIndex = 0;
            msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiOpen, tsmiExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 25);
            fileToolStripMenuItem.Text = "File";
            // 
            // tsmiOpen
            // 
            tsmiOpen.Name = "tsmiOpen";
            tsmiOpen.Size = new Size(132, 26);
            tsmiOpen.Text = "Open";
            tsmiOpen.Click += tsmiOpen_Click;
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new Size(132, 26);
            tsmiExit.Text = "Exit";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.AutoSize = false;
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { tsslDate });
            statusStripMain.Location = new Point(0, 453);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(719, 29);
            statusStripMain.TabIndex = 2;
            statusStripMain.Text = "statusStrip1";
            // 
            // tsslDate
            // 
            tsslDate.Name = "tsslDate";
            tsslDate.Size = new Size(42, 23);
            tsslDate.Text = "Date";
            // 
            // axWMPMain
            // 
            axWMPMain.Dock = DockStyle.Fill;
            axWMPMain.Enabled = true;
            axWMPMain.Location = new Point(0, 29);
            axWMPMain.Name = "axWMPMain";
            axWMPMain.OcxState = (AxHost.State)resources.GetObject("axWMPMain.OcxState");
            axWMPMain.Size = new Size(719, 424);
            axWMPMain.TabIndex = 3;
            // 
            // FormWindowsMediaPlayer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 482);
            Controls.Add(axWMPMain);
            Controls.Add(statusStripMain);
            Controls.Add(msMain);
            MainMenuStrip = msMain;
            Name = "FormWindowsMediaPlayer";
            Text = "Chương Trình Windows Media";
            Load += FormWindowsMediaPlayer_Load;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWMPMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem tsmiOpen;
        private ToolStripMenuItem tsmiExit;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel tsslDate;
        private System.Windows.Forms.Timer timerMain;
        private AxWMPLib.AxWindowsMediaPlayer axWMPMain;
    }
}
