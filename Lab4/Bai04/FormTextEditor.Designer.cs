namespace Bai04
{
    partial class FormTextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextEditor));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            tsmiAddNewText = new ToolStripMenuItem();
            tsmiOpenFile = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiSaveFile = new ToolStripMenuItem();
            tsmiExit = new ToolStripMenuItem();
            tsmiFormat = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAddNewText = new ToolStripButton();
            btnSave = new ToolStripButton();
            tscbbFont = new ToolStripComboBox();
            tscbbSize = new ToolStripComboBox();
            btnBold = new ToolStripButton();
            btnItalic = new ToolStripButton();
            btnUnderline = new ToolStripButton();
            rtxtContent = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, tsmiFormat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiAddNewText, tsmiOpenFile, toolStripSeparator1, tsmiSaveFile, tsmiExit });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.ShortcutKeyDisplayString = "";
            hệThốngToolStripMenuItem.Size = new Size(88, 25);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tsmiAddNewText
            // 
            tsmiAddNewText.Image = (Image)resources.GetObject("tsmiAddNewText.Image");
            tsmiAddNewText.Name = "tsmiAddNewText";
            tsmiAddNewText.ShortcutKeys = Keys.Control | Keys.N;
            tsmiAddNewText.Size = new Size(300, 26);
            tsmiAddNewText.Text = "Tạo văn bản mới";
            tsmiAddNewText.Click += tsmiAddNewText_Click;
            // 
            // tsmiOpenFile
            // 
            tsmiOpenFile.Image = (Image)resources.GetObject("tsmiOpenFile.Image");
            tsmiOpenFile.Name = "tsmiOpenFile";
            tsmiOpenFile.Size = new Size(300, 26);
            tsmiOpenFile.Text = "Mở tập tin";
            tsmiOpenFile.Click += tsmiOpenFile_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(297, 6);
            // 
            // tsmiSaveFile
            // 
            tsmiSaveFile.Image = (Image)resources.GetObject("tsmiSaveFile.Image");
            tsmiSaveFile.Name = "tsmiSaveFile";
            tsmiSaveFile.ShortcutKeys = Keys.Control | Keys.S;
            tsmiSaveFile.Size = new Size(300, 26);
            tsmiSaveFile.Text = "Lưu nội dung văn bản";
            tsmiSaveFile.Click += tsmiSaveFile_Click;
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new Size(300, 26);
            tsmiExit.Text = "Thoát";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // tsmiFormat
            // 
            tsmiFormat.Name = "tsmiFormat";
            tsmiFormat.Size = new Size(96, 25);
            tsmiFormat.Text = "Định dạng";
            tsmiFormat.Click += tsmiFormat_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddNewText, btnSave, tscbbFont, tscbbSize, btnBold, btnItalic, btnUnderline });
            toolStrip1.Location = new Point(0, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 29);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAddNewText
            // 
            btnAddNewText.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddNewText.Image = (Image)resources.GetObject("btnAddNewText.Image");
            btnAddNewText.ImageTransparentColor = Color.Magenta;
            btnAddNewText.Name = "btnAddNewText";
            btnAddNewText.Size = new Size(29, 26);
            btnAddNewText.Text = "toolStripButton1";
            btnAddNewText.Click += tsbtnAddNewText_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(29, 26);
            btnSave.Text = "toolStripButton2";
            btnSave.Click += tsbtnSaveFile_Click;
            // 
            // tscbbFont
            // 
            tscbbFont.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tscbbFont.Name = "tscbbFont";
            tscbbFont.Size = new Size(121, 29);
            tscbbFont.TextChanged += Font_Changed;
            // 
            // tscbbSize
            // 
            tscbbSize.Name = "tscbbSize";
            tscbbSize.Size = new Size(121, 29);
            tscbbSize.TextChanged += Size_changed;
            // 
            // btnBold
            // 
            btnBold.CheckOnClick = true;
            btnBold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBold.Image = (Image)resources.GetObject("btnBold.Image");
            btnBold.ImageTransparentColor = Color.Magenta;
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(29, 26);
            btnBold.Text = "toolStripButton3";
            btnBold.Click += tsbtnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.CheckOnClick = true;
            btnItalic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnItalic.Image = (Image)resources.GetObject("btnItalic.Image");
            btnItalic.ImageTransparentColor = Color.Magenta;
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(29, 26);
            btnItalic.Text = "toolStripButton4";
            btnItalic.Click += tsbtnItalic_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.CheckOnClick = true;
            btnUnderline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUnderline.Image = (Image)resources.GetObject("btnUnderline.Image");
            btnUnderline.ImageTransparentColor = Color.Magenta;
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(29, 26);
            btnUnderline.Text = "toolStripButton5";
            btnUnderline.Click += tsbtnUnderline_Click;
            // 
            // rtxtContent
            // 
            rtxtContent.Dock = DockStyle.Fill;
            rtxtContent.Location = new Point(0, 58);
            rtxtContent.Name = "rtxtContent";
            rtxtContent.Size = new Size(800, 392);
            rtxtContent.TabIndex = 2;
            rtxtContent.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormTextEditor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtxtContent);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormTextEditor";
            Text = "Soạn thảo văn bản";
            Load += FormTextEditor_Load;
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
        private ToolStripMenuItem tsmiFormat;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAddNewText;
        private ToolStripButton btnSave;
        private ToolStripComboBox tscbbFont;
        private ToolStripComboBox tscbbSize;
        private ToolStripButton btnBold;
        private ToolStripButton btnItalic;
        private ToolStripButton btnUnderline;
        private ToolStripMenuItem tsmiAddNewText;
        private ToolStripMenuItem tsmiOpenFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiSaveFile;
        private ToolStripMenuItem tsmiExit;
        private RichTextBox rtxtContent;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
