namespace Bai06
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
            ColumnHeader columnAllFont;
            ListViewItem listViewItem1 = new ListViewItem("");
            lsvAllFont = new ListView();
            columnAllFont = new ColumnHeader();
            SuspendLayout();
            // 
            // columnAllFont
            // 
            columnAllFont.Text = "";
            columnAllFont.Width = 300;
            // 
            // lsvAllFont
            // 
            lsvAllFont.Columns.AddRange(new ColumnHeader[] { columnAllFont });
            lsvAllFont.Dock = DockStyle.Left;
            lsvAllFont.ForeColor = Color.Black;
            lsvAllFont.ImeMode = ImeMode.NoControl;
            lsvAllFont.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lsvAllFont.Location = new Point(0, 0);
            lsvAllFont.Name = "lsvAllFont";
            lsvAllFont.Size = new Size(694, 426);
            lsvAllFont.TabIndex = 1;
            lsvAllFont.UseCompatibleStateImageBehavior = false;
            lsvAllFont.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 426);
            Controls.Add(lsvAllFont);
            Name = "Form1";
            Text = "AllFont";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListView lsvAllFont;
    }
}
