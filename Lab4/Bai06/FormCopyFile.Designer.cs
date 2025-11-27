namespace Bai04
{
    partial class FormCopyFile
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnCopy = new Button();
            btnBrowseDest = new Button();
            btnBrowseSource = new Button();
            txtDestination = new TextBox();
            txtSource = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            progressBarTotal = new ProgressBar();
            folderBrowserDialog1 = new FolderBrowserDialog();
            toolTip1 = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            tssl_Copying = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCopy);
            groupBox1.Controls.Add(btnBrowseDest);
            groupBox1.Controls.Add(btnBrowseSource);
            groupBox1.Controls.Add(txtDestination);
            groupBox1.Controls.Add(txtSource);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(35, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(727, 228);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sao chép tập tin";
            // 
            // btnCopy
            // 
            btnCopy.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btnCopy.FlatAppearance.BorderSize = 2;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.ForeColor = Color.Black;
            btnCopy.Location = new Point(327, 174);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(178, 38);
            btnCopy.TabIndex = 6;
            btnCopy.Text = "Sao Chép";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnBrowseDest
            // 
            btnBrowseDest.Location = new Point(659, 121);
            btnBrowseDest.Name = "btnBrowseDest";
            btnBrowseDest.Size = new Size(47, 29);
            btnBrowseDest.TabIndex = 5;
            btnBrowseDest.Text = "...";
            btnBrowseDest.UseVisualStyleBackColor = true;
            btnBrowseDest.Click += btnBrowseDest_Click;
            // 
            // btnBrowseSource
            // 
            btnBrowseSource.Location = new Point(659, 54);
            btnBrowseSource.Name = "btnBrowseSource";
            btnBrowseSource.Size = new Size(47, 29);
            btnBrowseSource.TabIndex = 4;
            btnBrowseSource.Text = "...";
            btnBrowseSource.UseVisualStyleBackColor = true;
            btnBrowseSource.Click += btnBrowseSource_Click;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(327, 121);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(319, 29);
            txtDestination.TabIndex = 3;
            // 
            // txtSource
            // 
            txtSource.Location = new Point(327, 50);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(319, 29);
            txtSource.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(69, 129);
            label2.Name = "label2";
            label2.Size = new Size(189, 21);
            label2.TabIndex = 1;
            label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(69, 58);
            label1.Name = "label1";
            label1.Size = new Size(206, 21);
            label1.TabIndex = 0;
            label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBarTotal);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(35, 310);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(727, 94);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBarTotal
            // 
            progressBarTotal.Location = new Point(57, 42);
            progressBarTotal.Name = "progressBarTotal";
            progressBarTotal.Size = new Size(632, 29);
            progressBarTotal.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssl_Copying });
            statusStrip1.Location = new Point(0, 423);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 27);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssl_Copying
            // 
            tssl_Copying.Name = "tssl_Copying";
            tssl_Copying.Size = new Size(115, 21);
            tssl_Copying.Text = "Đang sao chép:";
            // 
            // FormCopyFile
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormCopyFile";
            Text = "Sao chép tập tin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtDestination;
        private TextBox txtSource;
        private Label label2;
        private Label label1;
        private ProgressBar progressBarTotal;
        private Button btnBrowseDest;
        private Button btnBrowseSource;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolTip toolTip1;
        private Button btnCopy;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssl_Copying;
    }
}
