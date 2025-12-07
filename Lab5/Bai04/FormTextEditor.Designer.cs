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
            label1 = new Label();
            cbbFont = new ComboBox();
            chkbBold = new CheckBox();
            pictureBox1 = new PictureBox();
            chkbItalic = new CheckBox();
            chkbUnderline = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            cbbSize = new ComboBox();
            groupBox1 = new GroupBox();
            rbtnRight = new RadioButton();
            rbtnCenter = new RadioButton();
            rbtnLeft = new RadioButton();
            txtContent = new TextBox();
            label3 = new Label();
            btnColor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 28);
            label1.TabIndex = 0;
            label1.Text = "Font";
            // 
            // cbbFont
            // 
            cbbFont.FormattingEnabled = true;
            cbbFont.Location = new Point(151, 39);
            cbbFont.Name = "cbbFont";
            cbbFont.Size = new Size(151, 29);
            cbbFont.TabIndex = 1;
            cbbFont.TextChanged += Font_Changed;
            // 
            // chkbBold
            // 
            chkbBold.AutoSize = true;
            chkbBold.Location = new Point(48, 114);
            chkbBold.Name = "chkbBold";
            chkbBold.Size = new Size(18, 17);
            chkbBold.TabIndex = 2;
            chkbBold.UseVisualStyleBackColor = true;
            chkbBold.CheckedChanged += tsbtnBold_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // chkbItalic
            // 
            chkbItalic.AutoSize = true;
            chkbItalic.Location = new Point(132, 114);
            chkbItalic.Name = "chkbItalic";
            chkbItalic.Size = new Size(18, 17);
            chkbItalic.TabIndex = 4;
            chkbItalic.UseVisualStyleBackColor = true;
            chkbItalic.CheckedChanged += tsbtnItalic_Click;
            // 
            // chkbUnderline
            // 
            chkbUnderline.AutoSize = true;
            chkbUnderline.Location = new Point(214, 114);
            chkbUnderline.Name = "chkbUnderline";
            chkbUnderline.Size = new Size(18, 17);
            chkbUnderline.TabIndex = 5;
            chkbUnderline.UseVisualStyleBackColor = true;
            chkbUnderline.CheckedChanged += tsbtnUnderline_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(156, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(238, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 47);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 8;
            label2.Text = "Size";
            // 
            // cbbSize
            // 
            cbbSize.FormattingEnabled = true;
            cbbSize.Location = new Point(488, 44);
            cbbSize.Name = "cbbSize";
            cbbSize.Size = new Size(151, 29);
            cbbSize.TabIndex = 1;
            cbbSize.TextChanged += Size_changed;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnRight);
            groupBox1.Controls.Add(rbtnCenter);
            groupBox1.Controls.Add(rbtnLeft);
            groupBox1.Location = new Point(48, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 161);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Align Text";
            // 
            // rbtnRight
            // 
            rbtnRight.AutoSize = true;
            rbtnRight.Location = new Point(15, 123);
            rbtnRight.Name = "rbtnRight";
            rbtnRight.Size = new Size(68, 25);
            rbtnRight.TabIndex = 11;
            rbtnRight.TabStop = true;
            rbtnRight.Text = "Right";
            rbtnRight.UseVisualStyleBackColor = true;
            rbtnRight.CheckedChanged += rbtnRight_CheckedChanged;
            // 
            // rbtnCenter
            // 
            rbtnCenter.AutoSize = true;
            rbtnCenter.Location = new Point(15, 78);
            rbtnCenter.Name = "rbtnCenter";
            rbtnCenter.Size = new Size(77, 25);
            rbtnCenter.TabIndex = 10;
            rbtnCenter.TabStop = true;
            rbtnCenter.Text = "Center";
            rbtnCenter.UseVisualStyleBackColor = true;
            rbtnCenter.CheckedChanged += rbtnCenter_CheckedChanged;
            // 
            // rbtnLeft
            // 
            rbtnLeft.AutoSize = true;
            rbtnLeft.Location = new Point(15, 35);
            rbtnLeft.Name = "rbtnLeft";
            rbtnLeft.Size = new Size(57, 25);
            rbtnLeft.TabIndex = 0;
            rbtnLeft.TabStop = true;
            rbtnLeft.Text = "Left";
            rbtnLeft.UseVisualStyleBackColor = true;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(427, 208);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(303, 82);
            txtContent.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(405, 110);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 11;
            label3.Text = "Color";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(488, 105);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(54, 33);
            btnColor.TabIndex = 12;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // FormTextEditor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 449);
            Controls.Add(btnColor);
            Controls.Add(label3);
            Controls.Add(txtContent);
            Controls.Add(groupBox1);
            Controls.Add(cbbSize);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(chkbUnderline);
            Controls.Add(chkbItalic);
            Controls.Add(pictureBox1);
            Controls.Add(chkbBold);
            Controls.Add(cbbFont);
            Controls.Add(label1);
            Name = "FormTextEditor";
            Text = "TextEditor";
            Load += FormTextEditor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbFont;
        private CheckBox chkbBold;
        private PictureBox pictureBox1;
        private CheckBox chkbItalic;
        private CheckBox chkbUnderline;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private ComboBox cbbSize;
        private GroupBox groupBox1;
        private RadioButton rbtnRight;
        private RadioButton rbtnCenter;
        private RadioButton rbtnLeft;
        private TextBox txtContent;
        private Label label3;
        private Button btnColor;
    }
}
