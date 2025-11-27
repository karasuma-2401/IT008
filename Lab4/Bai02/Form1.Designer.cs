namespace Bai02
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            tạoVănBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            mởTậpTinToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            lưuNộiDungVănBảnToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            ComboBoxFont = new ToolStripComboBox();
            ComboBoxSize = new ToolStripComboBox();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoVănBảnMớiToolStripMenuItem, mởTậpTinToolStripMenuItem, toolStripSeparator1, lưuNộiDungVănBảnToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.ShortcutKeyDisplayString = "";
            hệThốngToolStripMenuItem.Size = new Size(88, 25);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            tạoVănBảnMớiToolStripMenuItem.Image = (Image)resources.GetObject("tạoVănBảnMớiToolStripMenuItem.Image");
            tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            tạoVănBảnMớiToolStripMenuItem.Size = new Size(300, 26);
            tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            tạoVănBảnMớiToolStripMenuItem.Click += tạoVănBảnMớiToolStripMenuItem_Click;
            // 
            // mởTậpTinToolStripMenuItem
            // 
            mởTậpTinToolStripMenuItem.Image = (Image)resources.GetObject("mởTậpTinToolStripMenuItem.Image");
            mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            mởTậpTinToolStripMenuItem.Size = new Size(300, 26);
            mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            mởTậpTinToolStripMenuItem.Click += mởTậpTinToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(297, 6);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            lưuNộiDungVănBảnToolStripMenuItem.Image = (Image)resources.GetObject("lưuNộiDungVănBảnToolStripMenuItem.Image");
            lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            lưuNộiDungVănBảnToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            lưuNộiDungVănBảnToolStripMenuItem.Size = new Size(300, 26);
            lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
            lưuNộiDungVănBảnToolStripMenuItem.Click += lưuNộiDungVănBảnToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(300, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(96, 25);
            địnhDạngToolStripMenuItem.Text = "Định dạng";
            địnhDạngToolStripMenuItem.Click += địnhDạngToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, ComboBoxFont, ComboBoxSize, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 29);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 26);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += tạoVănBảnMớiToolStripMenuItem_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 26);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += lưuNộiDungVănBảnToolStripMenuItem_Click;
            // 
            // ComboBoxFont
            // 
            ComboBoxFont.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBoxFont.Name = "ComboBoxFont";
            ComboBoxFont.Size = new Size(121, 29);
            ComboBoxFont.TextChanged += Font_Changed;
            // 
            // ComboBoxSize
            // 
            ComboBoxSize.Name = "ComboBoxSize";
            ComboBoxSize.Size = new Size(121, 29);
            ComboBoxSize.TextChanged += Size_changed;
            // 
            // toolStripButton3
            // 
            toolStripButton3.CheckOnClick = true;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 26);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.CheckOnClick = true;
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 26);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.CheckOnClick = true;
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 26);
            toolStripButton5.Text = "toolStripButton5";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 392);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripComboBox ComboBoxFont;
        private ToolStripComboBox ComboBoxSize;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
