namespace Bai10
{
    partial class FormPenDemo
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
            groupBox1 = new GroupBox();
            cbbEndCap = new ComboBox();
            cbbStartCap = new ComboBox();
            cbbDashCap = new ComboBox();
            cbbLineJoin = new ComboBox();
            cbbWidth = new ComboBox();
            cbbDashStyle = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbLayout).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ptbLayout
            // 
            ptbLayout.BackColor = SystemColors.Control;
            ptbLayout.BorderStyle = BorderStyle.FixedSingle;
            ptbLayout.Dock = DockStyle.Fill;
            ptbLayout.Location = new Point(0, 0);
            ptbLayout.Name = "ptbLayout";
            ptbLayout.Size = new Size(800, 450);
            ptbLayout.TabIndex = 0;
            ptbLayout.TabStop = false;
            ptbLayout.Paint += ptbLayout_Paint;
            ptbLayout.MouseDown += ptbLayout_MouseDown;
            ptbLayout.MouseMove += ptbLayout_MouseMove;
            ptbLayout.MouseUp += ptbLayout_MouseUp;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(cbbEndCap);
            groupBox1.Controls.Add(cbbStartCap);
            groupBox1.Controls.Add(cbbDashCap);
            groupBox1.Controls.Add(cbbLineJoin);
            groupBox1.Controls.Add(cbbWidth);
            groupBox1.Controls.Add(cbbDashStyle);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 450);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // cbbEndCap
            // 
            cbbEndCap.FormattingEnabled = true;
            cbbEndCap.Items.AddRange(new object[] { "Flat", "Round", "Square", "Triangle ", "ArrowAnchor", "RoundAnchor", "SquareAnchor", "DiamondAnchor", "NoAnchor" });
            cbbEndCap.Location = new Point(133, 372);
            cbbEndCap.Name = "cbbEndCap";
            cbbEndCap.Size = new Size(151, 29);
            cbbEndCap.TabIndex = 11;
            // 
            // cbbStartCap
            // 
            cbbStartCap.FormattingEnabled = true;
            cbbStartCap.Items.AddRange(new object[] { "Flat", "Round", "Square", "Triangle ", "ArrowAnchor", "RoundAnchor", "SquareAnchor", "DiamondAnchor", "NoAnchor" });
            cbbStartCap.Location = new Point(133, 308);
            cbbStartCap.Name = "cbbStartCap";
            cbbStartCap.Size = new Size(151, 29);
            cbbStartCap.TabIndex = 10;
            // 
            // cbbDashCap
            // 
            cbbDashCap.FormattingEnabled = true;
            cbbDashCap.Items.AddRange(new object[] { "Flat", "Round", "Triangle" });
            cbbDashCap.Location = new Point(133, 235);
            cbbDashCap.Name = "cbbDashCap";
            cbbDashCap.Size = new Size(151, 29);
            cbbDashCap.TabIndex = 9;
            // 
            // cbbLineJoin
            // 
            cbbLineJoin.FormattingEnabled = true;
            cbbLineJoin.Items.AddRange(new object[] { "Round", "Miter", "Bevel" });
            cbbLineJoin.Location = new Point(133, 162);
            cbbLineJoin.Name = "cbbLineJoin";
            cbbLineJoin.Size = new Size(151, 29);
            cbbLineJoin.TabIndex = 8;
            // 
            // cbbWidth
            // 
            cbbWidth.FormattingEnabled = true;
            cbbWidth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cbbWidth.Location = new Point(133, 94);
            cbbWidth.Name = "cbbWidth";
            cbbWidth.Size = new Size(151, 29);
            cbbWidth.TabIndex = 7;
            // 
            // cbbDashStyle
            // 
            cbbDashStyle.FormattingEnabled = true;
            cbbDashStyle.Items.AddRange(new object[] { "Custom", "Dash", "DashDot", "DashDotDot", "Dot", "Solid" });
            cbbDashStyle.Location = new Point(133, 27);
            cbbDashStyle.Name = "cbbDashStyle";
            cbbDashStyle.Size = new Size(151, 29);
            cbbDashStyle.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 380);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 5;
            label6.Text = "End Cap:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 316);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 4;
            label5.Text = "Start Cap:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 243);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 3;
            label4.Text = "Dash Cap:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 170);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 2;
            label3.Text = "Line Join:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 102);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 1;
            label2.Text = "Width:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "Dash Style:";
            // 
            // FormPenDemo
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(ptbLayout);
            Name = "FormPenDemo";
            Text = "Pen Demo";
            Load += FormPenDemo_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLayout).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbLayout;
        private GroupBox groupBox1;
        private ComboBox cbbDashStyle;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbbEndCap;
        private ComboBox cbbStartCap;
        private ComboBox cbbDashCap;
        private ComboBox cbbLineJoin;
        private ComboBox cbbWidth;
    }
}
