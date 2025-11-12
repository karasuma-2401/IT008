namespace Bai05
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnPlus = new Button();
            btnMinus = new Button();
            btnTimes = new Button();
            btnDivision = new Button();
            label3 = new Label();
            txtAnswer = new TextBox();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(304, 127);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(219, 29);
            txtNumber1.TabIndex = 1;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(304, 186);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(219, 29);
            txtNumber2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 127);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 3;
            label1.Text = "Number1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 194);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 4;
            label2.Text = "Number2";
            // 
            // btnPlus
            // 
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(167, 268);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(74, 59);
            btnPlus.TabIndex = 5;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(274, 268);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(74, 59);
            btnMinus.TabIndex = 6;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnTimes
            // 
            btnTimes.FlatStyle = FlatStyle.Flat;
            btnTimes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimes.Location = new Point(379, 268);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(74, 59);
            btnTimes.TabIndex = 7;
            btnTimes.Text = "x";
            btnTimes.UseVisualStyleBackColor = true;
            btnTimes.Click += btnTimes_Click;
            // 
            // btnDivision
            // 
            btnDivision.FlatStyle = FlatStyle.Flat;
            btnDivision.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivision.Location = new Point(480, 268);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(74, 59);
            btnDivision.TabIndex = 8;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(182, 376);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 9;
            label3.Text = "Answer";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(262, 372);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(261, 29);
            txtAnswer.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 486);
            Controls.Add(txtAnswer);
            Controls.Add(label3);
            Controls.Add(btnDivision);
            Controls.Add(btnTimes);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label label1;
        private Label label2;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnTimes;
        private Button btnDivision;
        private Label label3;
        private TextBox txtAnswer;
    }
}
