namespace Bai01
{
    partial class FormCha
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
            lbProcessChildForm = new ListBox();
            CreateChildFormBtn = new Button();
            CloseBtn = new Button();
            SuspendLayout();
            // 
            // lbProcessChildForm
            // 
            lbProcessChildForm.FormattingEnabled = true;
            lbProcessChildForm.ItemHeight = 21;
            lbProcessChildForm.Location = new Point(32, 46);
            lbProcessChildForm.Name = "lbProcessChildForm";
            lbProcessChildForm.Size = new Size(362, 214);
            lbProcessChildForm.TabIndex = 0;
            // 
            // CreateChildFormBtn
            // 
            CreateChildFormBtn.FlatAppearance.BorderColor = Color.Blue;
            CreateChildFormBtn.FlatStyle = FlatStyle.Flat;
            CreateChildFormBtn.Location = new Point(416, 46);
            CreateChildFormBtn.Name = "CreateChildFormBtn";
            CreateChildFormBtn.Size = new Size(173, 39);
            CreateChildFormBtn.TabIndex = 1;
            CreateChildFormBtn.Text = "Open form con";
            CreateChildFormBtn.UseVisualStyleBackColor = true;
            CreateChildFormBtn.Click += CreateChildFormBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.FlatAppearance.BorderColor = Color.Blue;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Location = new Point(416, 118);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(173, 39);
            CloseBtn.TabIndex = 2;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // FormCha
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseBtn);
            Controls.Add(CreateChildFormBtn);
            Controls.Add(lbProcessChildForm);
            Name = "FormCha";
            Text = "FormCha";
            Activated += Form1_Activated;
            Deactivate += Form1_Deactivated;
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Shown += Form1_Shown;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbProcessChildForm;
        private Button CreateChildFormBtn;
        private Button CloseBtn;
    }
}
