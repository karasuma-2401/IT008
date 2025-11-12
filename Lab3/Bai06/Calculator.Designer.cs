namespace Bai06
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            txtResult = new TextBox();
            btnC = new Button();
            btnCE = new Button();
            btnBackSpace = new Button();
            btnMC = new Button();
            btnMS = new Button();
            btnMPlus = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivision = new Button();
            btnSquare = new Button();
            btnPercentage = new Button();
            btnTimes = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnReciprocal = new Button();
            btnMinus = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnEqual = new Button();
            btnPlus = new Button();
            btnPoint = new Button();
            btnInversion = new Button();
            btn0 = new Button();
            btnMR = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(542, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, findToolStripMenuItem, replaceToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(50, 25);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(148, 26);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(148, 26);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(148, 26);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(148, 26);
            findToolStripMenuItem.Text = "Find";
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(148, 26);
            replaceToolStripMenuItem.Text = "Replace";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem, quitToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(58, 25);
            viewToolStripMenuItem.Text = "&View";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(135, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(135, 26);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(56, 25);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(136, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(12, 44);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(494, 42);
            txtResult.TabIndex = 1;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnC
            // 
            btnC.FlatStyle = FlatStyle.Popup;
            btnC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC.ForeColor = Color.Red;
            btnC.Location = new Point(379, 103);
            btnC.Margin = new Padding(3, 4, 3, 4);
            btnC.Name = "btnC";
            btnC.Size = new Size(127, 55);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            btnCE.FlatStyle = FlatStyle.Popup;
            btnCE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCE.ForeColor = Color.Red;
            btnCE.Location = new Point(250, 103);
            btnCE.Margin = new Padding(3, 4, 3, 4);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(123, 55);
            btnCE.TabIndex = 4;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnBackSpace
            // 
            btnBackSpace.FlatStyle = FlatStyle.Popup;
            btnBackSpace.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackSpace.ForeColor = Color.Red;
            btnBackSpace.Location = new Point(107, 103);
            btnBackSpace.Margin = new Padding(3, 4, 3, 4);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(135, 55);
            btnBackSpace.TabIndex = 5;
            btnBackSpace.Text = "Backspace";
            btnBackSpace.UseVisualStyleBackColor = true;
            // 
            // btnMC
            // 
            btnMC.FlatStyle = FlatStyle.Popup;
            btnMC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMC.ForeColor = Color.Red;
            btnMC.Location = new Point(12, 175);
            btnMC.Margin = new Padding(3, 4, 3, 4);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(75, 65);
            btnMC.TabIndex = 6;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = true;
            // 
            // btnMS
            // 
            btnMS.FlatStyle = FlatStyle.Popup;
            btnMS.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMS.ForeColor = Color.Red;
            btnMS.Location = new Point(12, 321);
            btnMS.Margin = new Padding(3, 4, 3, 4);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(75, 65);
            btnMS.TabIndex = 7;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = true;
            // 
            // btnMPlus
            // 
            btnMPlus.FlatStyle = FlatStyle.Popup;
            btnMPlus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMPlus.ForeColor = Color.Red;
            btnMPlus.Location = new Point(12, 394);
            btnMPlus.Margin = new Padding(3, 4, 3, 4);
            btnMPlus.Name = "btnMPlus";
            btnMPlus.Size = new Size(75, 65);
            btnMPlus.TabIndex = 8;
            btnMPlus.Text = "M+";
            btnMPlus.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.ForeColor = Color.Blue;
            btn7.Location = new Point(107, 175);
            btn7.Margin = new Padding(3, 4, 3, 4);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 65);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.ForeColor = Color.Blue;
            btn8.Location = new Point(188, 175);
            btn8.Margin = new Padding(3, 4, 3, 4);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 65);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.ForeColor = Color.Blue;
            btn9.Location = new Point(269, 175);
            btn9.Margin = new Padding(3, 4, 3, 4);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 65);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            btnDivision.FlatStyle = FlatStyle.Popup;
            btnDivision.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivision.ForeColor = Color.Red;
            btnDivision.Location = new Point(350, 175);
            btnDivision.Margin = new Padding(3, 4, 3, 4);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(75, 65);
            btnDivision.TabIndex = 12;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnSquare
            // 
            btnSquare.FlatStyle = FlatStyle.Popup;
            btnSquare.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSquare.ForeColor = Color.Blue;
            btnSquare.Location = new Point(431, 175);
            btnSquare.Margin = new Padding(3, 4, 3, 4);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(75, 65);
            btnSquare.TabIndex = 13;
            btnSquare.Text = "sqrt";
            btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnPercentage
            // 
            btnPercentage.FlatStyle = FlatStyle.Popup;
            btnPercentage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPercentage.ForeColor = Color.Blue;
            btnPercentage.Location = new Point(431, 248);
            btnPercentage.Margin = new Padding(3, 4, 3, 4);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(75, 65);
            btnPercentage.TabIndex = 18;
            btnPercentage.Text = "%";
            btnPercentage.UseVisualStyleBackColor = true;
            // 
            // btnTimes
            // 
            btnTimes.FlatStyle = FlatStyle.Popup;
            btnTimes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimes.ForeColor = Color.Red;
            btnTimes.Location = new Point(350, 248);
            btnTimes.Margin = new Padding(3, 4, 3, 4);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(75, 65);
            btnTimes.TabIndex = 17;
            btnTimes.Text = "*";
            btnTimes.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.ForeColor = Color.Blue;
            btn6.Location = new Point(269, 248);
            btn6.Margin = new Padding(3, 4, 3, 4);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 65);
            btn6.TabIndex = 16;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.ForeColor = Color.Blue;
            btn5.Location = new Point(188, 248);
            btn5.Margin = new Padding(3, 4, 3, 4);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 65);
            btn5.TabIndex = 15;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.ForeColor = Color.Blue;
            btn4.Location = new Point(107, 248);
            btn4.Margin = new Padding(3, 4, 3, 4);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 65);
            btn4.TabIndex = 14;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btnReciprocal
            // 
            btnReciprocal.FlatStyle = FlatStyle.Popup;
            btnReciprocal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReciprocal.ForeColor = Color.Blue;
            btnReciprocal.Location = new Point(431, 321);
            btnReciprocal.Margin = new Padding(3, 4, 3, 4);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(75, 65);
            btnReciprocal.TabIndex = 23;
            btnReciprocal.Text = "1/x";
            btnReciprocal.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.FlatStyle = FlatStyle.Popup;
            btnMinus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.ForeColor = Color.Red;
            btnMinus.Location = new Point(350, 321);
            btnMinus.Margin = new Padding(3, 4, 3, 4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(75, 65);
            btnMinus.TabIndex = 22;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.Blue;
            btn3.Location = new Point(269, 321);
            btn3.Margin = new Padding(3, 4, 3, 4);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 65);
            btn3.TabIndex = 21;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Blue;
            btn2.Location = new Point(188, 321);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 65);
            btn2.TabIndex = 20;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Blue;
            btn1.Location = new Point(107, 321);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 65);
            btn1.TabIndex = 19;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.FlatStyle = FlatStyle.Popup;
            btnEqual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.ForeColor = Color.Red;
            btnEqual.Location = new Point(431, 394);
            btnEqual.Margin = new Padding(3, 4, 3, 4);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(75, 65);
            btnEqual.TabIndex = 28;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.FlatStyle = FlatStyle.Popup;
            btnPlus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.ForeColor = Color.Red;
            btnPlus.Location = new Point(350, 394);
            btnPlus.Margin = new Padding(3, 4, 3, 4);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 65);
            btnPlus.TabIndex = 27;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnPoint
            // 
            btnPoint.FlatStyle = FlatStyle.Popup;
            btnPoint.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPoint.ForeColor = Color.Blue;
            btnPoint.Location = new Point(269, 394);
            btnPoint.Margin = new Padding(3, 4, 3, 4);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(75, 65);
            btnPoint.TabIndex = 26;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            // 
            // btnInversion
            // 
            btnInversion.FlatStyle = FlatStyle.Popup;
            btnInversion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInversion.ForeColor = Color.Blue;
            btnInversion.Location = new Point(188, 394);
            btnInversion.Margin = new Padding(3, 4, 3, 4);
            btnInversion.Name = "btnInversion";
            btnInversion.Size = new Size(75, 65);
            btnInversion.TabIndex = 25;
            btnInversion.Text = "+/-";
            btnInversion.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.ForeColor = Color.Blue;
            btn0.Location = new Point(107, 394);
            btn0.Margin = new Padding(3, 4, 3, 4);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 65);
            btn0.TabIndex = 24;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnMR
            // 
            btnMR.FlatStyle = FlatStyle.Popup;
            btnMR.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMR.ForeColor = Color.Red;
            btnMR.Location = new Point(12, 248);
            btnMR.Margin = new Padding(3, 4, 3, 4);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(75, 65);
            btnMR.TabIndex = 29;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 484);
            Controls.Add(btnMR);
            Controls.Add(btnEqual);
            Controls.Add(btnPlus);
            Controls.Add(btnPoint);
            Controls.Add(btnInversion);
            Controls.Add(btn0);
            Controls.Add(btnReciprocal);
            Controls.Add(btnMinus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnPercentage);
            Controls.Add(btnTimes);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnSquare);
            Controls.Add(btnDivision);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnMPlus);
            Controls.Add(btnMS);
            Controls.Add(btnMC);
            Controls.Add(btnBackSpace);
            Controls.Add(btnCE);
            Controls.Add(btnC);
            Controls.Add(txtResult);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Calculator";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnInversion;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMR;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}

