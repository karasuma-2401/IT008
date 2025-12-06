namespace Bai11
{
    partial class FormPaintApp
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
            ptbLayout = new PictureBox();
            grbAll = new GroupBox();
            grbBrushes = new GroupBox();
            rbtnLinearGradientBrush = new RadioButton();
            rbtnHatchBrush = new RadioButton();
            rbtnTextureBrush = new RadioButton();
            rbtnSolidBrush = new RadioButton();
            grbPen = new GroupBox();
            btnColor = new Button();
            txtWidth = new TextBox();
            lbWidth = new Label();
            grbShapes = new GroupBox();
            rbtnEllipse = new RadioButton();
            rbtnRectangle = new RadioButton();
            rbtnLine = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)ptbLayout).BeginInit();
            grbAll.SuspendLayout();
            grbBrushes.SuspendLayout();
            grbPen.SuspendLayout();
            grbShapes.SuspendLayout();
            SuspendLayout();
            // 
            // ptbLayout
            // 
            ptbLayout.BorderStyle = BorderStyle.FixedSingle;
            ptbLayout.Dock = DockStyle.Fill;
            ptbLayout.Location = new Point(0, 0);
            ptbLayout.Name = "ptbLayout";
            ptbLayout.Size = new Size(800, 570);
            ptbLayout.TabIndex = 1;
            ptbLayout.TabStop = false;
            ptbLayout.Paint += ptbLayout_Paint;
            ptbLayout.MouseDown += ptbLayout_MouseDown;
            ptbLayout.MouseMove += ptbLayout_MouseMove;
            ptbLayout.MouseUp += ptbLayout_MouseUp;
            // 
            // grbAll
            // 
            grbAll.BackColor = Color.FromArgb(255, 192, 128);
            grbAll.Controls.Add(grbBrushes);
            grbAll.Controls.Add(grbPen);
            grbAll.Controls.Add(grbShapes);
            grbAll.Dock = DockStyle.Left;
            grbAll.Location = new Point(0, 0);
            grbAll.Name = "grbAll";
            grbAll.Size = new Size(298, 570);
            grbAll.TabIndex = 3;
            grbAll.TabStop = false;
            // 
            // grbBrushes
            // 
            grbBrushes.Controls.Add(rbtnLinearGradientBrush);
            grbBrushes.Controls.Add(rbtnHatchBrush);
            grbBrushes.Controls.Add(rbtnTextureBrush);
            grbBrushes.Controls.Add(rbtnSolidBrush);
            grbBrushes.ForeColor = Color.Blue;
            grbBrushes.Location = new Point(19, 337);
            grbBrushes.Name = "grbBrushes";
            grbBrushes.Size = new Size(250, 199);
            grbBrushes.TabIndex = 1;
            grbBrushes.TabStop = false;
            grbBrushes.Text = "Brushes";
            // 
            // rbtnLinearGradientBrush
            // 
            rbtnLinearGradientBrush.AutoSize = true;
            rbtnLinearGradientBrush.ForeColor = Color.Black;
            rbtnLinearGradientBrush.Location = new Point(20, 159);
            rbtnLinearGradientBrush.Name = "rbtnLinearGradientBrush";
            rbtnLinearGradientBrush.Size = new Size(174, 25);
            rbtnLinearGradientBrush.TabIndex = 7;
            rbtnLinearGradientBrush.TabStop = true;
            rbtnLinearGradientBrush.Text = "LinearGradientBrush";
            rbtnLinearGradientBrush.UseVisualStyleBackColor = true;
            // 
            // rbtnHatchBrush
            // 
            rbtnHatchBrush.AutoSize = true;
            rbtnHatchBrush.ForeColor = Color.Black;
            rbtnHatchBrush.Location = new Point(20, 73);
            rbtnHatchBrush.Name = "rbtnHatchBrush";
            rbtnHatchBrush.Size = new Size(111, 25);
            rbtnHatchBrush.TabIndex = 6;
            rbtnHatchBrush.TabStop = true;
            rbtnHatchBrush.Text = "HatchBrush";
            rbtnHatchBrush.UseVisualStyleBackColor = true;
            // 
            // rbtnTextureBrush
            // 
            rbtnTextureBrush.AutoSize = true;
            rbtnTextureBrush.ForeColor = Color.Black;
            rbtnTextureBrush.Location = new Point(20, 114);
            rbtnTextureBrush.Name = "rbtnTextureBrush";
            rbtnTextureBrush.Size = new Size(120, 25);
            rbtnTextureBrush.TabIndex = 5;
            rbtnTextureBrush.TabStop = true;
            rbtnTextureBrush.Text = "TextureBrush";
            rbtnTextureBrush.UseVisualStyleBackColor = true;
            // 
            // rbtnSolidBrush
            // 
            rbtnSolidBrush.AutoSize = true;
            rbtnSolidBrush.ForeColor = Color.Black;
            rbtnSolidBrush.Location = new Point(20, 28);
            rbtnSolidBrush.Name = "rbtnSolidBrush";
            rbtnSolidBrush.Size = new Size(106, 25);
            rbtnSolidBrush.TabIndex = 4;
            rbtnSolidBrush.TabStop = true;
            rbtnSolidBrush.Text = "SolidBrush";
            rbtnSolidBrush.UseVisualStyleBackColor = true;
            // 
            // grbPen
            // 
            grbPen.Controls.Add(btnColor);
            grbPen.Controls.Add(txtWidth);
            grbPen.Controls.Add(lbWidth);
            grbPen.ForeColor = Color.Blue;
            grbPen.Location = new Point(19, 183);
            grbPen.Name = "grbPen";
            grbPen.Size = new Size(250, 125);
            grbPen.TabIndex = 1;
            grbPen.TabStop = false;
            grbPen.Text = "Pen";
            // 
            // btnColor
            // 
            btnColor.ForeColor = Color.Black;
            btnColor.Location = new Point(67, 76);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(94, 29);
            btnColor.TabIndex = 1;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(93, 31);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 29);
            txtWidth.TabIndex = 1;
            // 
            // lbWidth
            // 
            lbWidth.AutoSize = true;
            lbWidth.ForeColor = Color.Black;
            lbWidth.Location = new Point(20, 39);
            lbWidth.Name = "lbWidth";
            lbWidth.Size = new Size(55, 21);
            lbWidth.TabIndex = 1;
            lbWidth.Text = "Width:";
            // 
            // grbShapes
            // 
            grbShapes.Controls.Add(rbtnEllipse);
            grbShapes.Controls.Add(rbtnRectangle);
            grbShapes.Controls.Add(rbtnLine);
            grbShapes.ForeColor = Color.Blue;
            grbShapes.Location = new Point(19, 28);
            grbShapes.Name = "grbShapes";
            grbShapes.Size = new Size(250, 125);
            grbShapes.TabIndex = 0;
            grbShapes.TabStop = false;
            grbShapes.Text = "Shapes";
            // 
            // rbtnEllipse
            // 
            rbtnEllipse.AutoSize = true;
            rbtnEllipse.ForeColor = Color.Black;
            rbtnEllipse.Location = new Point(20, 94);
            rbtnEllipse.Name = "rbtnEllipse";
            rbtnEllipse.Size = new Size(75, 25);
            rbtnEllipse.TabIndex = 3;
            rbtnEllipse.TabStop = true;
            rbtnEllipse.Text = "Ellipse";
            rbtnEllipse.UseVisualStyleBackColor = true;
            // 
            // rbtnRectangle
            // 
            rbtnRectangle.AutoSize = true;
            rbtnRectangle.ForeColor = Color.Black;
            rbtnRectangle.Location = new Point(20, 59);
            rbtnRectangle.Name = "rbtnRectangle";
            rbtnRectangle.Size = new Size(99, 25);
            rbtnRectangle.TabIndex = 2;
            rbtnRectangle.TabStop = true;
            rbtnRectangle.Text = "Rectangle";
            rbtnRectangle.UseVisualStyleBackColor = true;
            // 
            // rbtnLine
            // 
            rbtnLine.AutoSize = true;
            rbtnLine.ForeColor = Color.Black;
            rbtnLine.Location = new Point(20, 28);
            rbtnLine.Name = "rbtnLine";
            rbtnLine.Size = new Size(60, 25);
            rbtnLine.TabIndex = 1;
            rbtnLine.TabStop = true;
            rbtnLine.Text = "Line";
            rbtnLine.UseVisualStyleBackColor = true;
            // 
            // FormPaintApp
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 570);
            Controls.Add(grbAll);
            Controls.Add(ptbLayout);
            Name = "FormPaintApp";
            Text = "PaintApp";
            Load += FormPaintApp_Load;
            Resize += FormPaintApp_Resize;
            ((System.ComponentModel.ISupportInitialize)ptbLayout).EndInit();
            grbAll.ResumeLayout(false);
            grbBrushes.ResumeLayout(false);
            grbBrushes.PerformLayout();
            grbPen.ResumeLayout(false);
            grbPen.PerformLayout();
            grbShapes.ResumeLayout(false);
            grbShapes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox ptbLayout;
        private GroupBox grbAll;
        private GroupBox grbBrushes;
        private RadioButton rbtnLinearGradientBrush;
        private RadioButton rbtnHatchBrush;
        private RadioButton rbtnTextureBrush;
        private RadioButton rbtnSolidBrush;
        private GroupBox grbPen;
        private Button btnColor;
        private TextBox txtWidth;
        private Label lbWidth;
        private GroupBox grbShapes;
        private RadioButton rbtnEllipse;
        private RadioButton rbtnRectangle;
        private RadioButton rbtnLine;
    }
}
