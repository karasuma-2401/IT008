namespace Bai09
{
    partial class FormComboBoxTest
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
            cbShape = new ComboBox();
            ptbLayout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbLayout).BeginInit();
            SuspendLayout();
            // 
            // cbShape
            // 
            cbShape.FormattingEnabled = true;
            cbShape.Items.AddRange(new object[] { "Circle", "Square", "Ellipse", "Pie", "Filled Circle", "Filled Square", "Filled Ellipse", "Filled Pie" });
            cbShape.Location = new Point(62, 25);
            cbShape.Name = "cbShape";
            cbShape.Size = new Size(151, 29);
            cbShape.TabIndex = 0;
            // 
            // ptbLayout
            // 
            ptbLayout.Dock = DockStyle.Fill;
            ptbLayout.Location = new Point(0, 0);
            ptbLayout.Name = "ptbLayout";
            ptbLayout.Size = new Size(800, 450);
            ptbLayout.TabIndex = 1;
            ptbLayout.TabStop = false;
            ptbLayout.Paint += ptbLayout_Paint;
            ptbLayout.MouseDown += ptbLayout_MouseDown;
            ptbLayout.MouseMove += ptbLayout_MouseMove;
            ptbLayout.MouseUp += ptbLayout_MouseUp;
            ptbLayout.Resize += ptbLayout_Resize;
            // 
            // FormComboBoxTest
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbShape);
            Controls.Add(ptbLayout);
            Name = "FormComboBoxTest";
            Text = "ComboBoxTest";
            Load += FormComboBoxTest_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLayout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbShape;
        private PictureBox ptbLayout;
    }
}
