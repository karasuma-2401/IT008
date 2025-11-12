namespace Bai03
{
    partial class ChangeColor
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
            btnChangeColor = new Button();
            SuspendLayout();
            // 
            // btnChangeColor
            // 
            btnChangeColor.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnChangeColor.FlatStyle = FlatStyle.Flat;
            btnChangeColor.Location = new Point(313, 178);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new Size(158, 49);
            btnChangeColor.TabIndex = 0;
            btnChangeColor.Text = "Change Color";
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += button1_Click;
            // 
            // ChangeColor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChangeColor);
            Name = "ChangeColor";
            Text = "ChangeColor";
            ResumeLayout(false);
        }

        #endregion

        private Button btnChangeColor;
    }
}
