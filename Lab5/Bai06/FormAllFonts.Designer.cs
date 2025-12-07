namespace Bai06
{
    partial class FormAllFonts
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
            ListViewItem listViewItem2 = new ListViewItem("");
            lsvAllFonts = new ListView();
            columnAllFont = new ColumnHeader();
            SuspendLayout();
            // 
            // columnAllFont
            // 
            columnAllFont.Text = "";
            columnAllFont.Width = 300;
            // 
            // lsvAllFonts
            // 
            lsvAllFonts.Columns.AddRange(new ColumnHeader[] { columnAllFont });
            lsvAllFonts.Dock = DockStyle.Left;
            lsvAllFonts.ForeColor = Color.Black;
            lsvAllFonts.ImeMode = ImeMode.NoControl;
            lsvAllFonts.Items.AddRange(new ListViewItem[] { listViewItem2 });
            lsvAllFonts.Location = new Point(0, 0);
            lsvAllFonts.Name = "lsvAllFonts";
            lsvAllFonts.Size = new Size(694, 426);
            lsvAllFonts.TabIndex = 1;
            lsvAllFonts.UseCompatibleStateImageBehavior = false;
            lsvAllFonts.View = View.Details;
            // 
            // FormAllFonts
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 426);
            Controls.Add(lsvAllFonts);
            Name = "FormAllFonts";
            Text = "All Fonts";
            Load += FormAllFonts_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListView lsvAllFonts;
    }
}
