using System;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private string currentFilePath = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                ComboBoxFont.Items.Add(font.Name);
            }
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            foreach (int s in sizes)
            {
                ComboBoxSize.Items.Add(s);
            }
            ComboBoxFont.SelectedItem = "Tahoma";
            ComboBoxSize.SelectedItem = 14;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            ComboBoxFont.SelectedItem = "Tahoma";
            ComboBoxSize.SelectedItem = 14;
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            ComboBoxFont.SelectedItem = "Tahoma";
            ComboBoxSize.SelectedItem = 14;
            currentFilePath = null;
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "RTF file|*.rtf|TXT file|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName.EndsWith(".rft"))
                {
                    richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.PlainText);
                } 
                
            }
        }
        private void SaveFile ()
        {
            saveFileDialog1.Filter = "RTF file|*.rtf";
            if (currentFilePath == null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                if (saveFileDialog1.FileName.EndsWith(".rft"))
                {
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);
                }
                MessageBox.Show("Lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontdl = new FontDialog();
            if (richTextBox1.SelectionFont != null)
            {
                fontdl.Font = richTextBox1.SelectionFont;
            }
            else
            {
                fontdl.Font = richTextBox1.Font;
            }

            if (fontdl.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontdl.Font;
                ComboBoxFont.Text = fontdl.Font.Name;
                ComboBoxSize.Text = fontdl.Font.Size.ToString();
            }
        }
        private void Font_Changed(object sender, EventArgs e)
        {
            if (ComboBoxFont.SelectedItem == null || ComboBoxSize.SelectedItem == null) return;
            string fontName = ComboBoxFont.SelectedItem.ToString();
            float fontSize = float.Parse(ComboBoxSize.SelectedItem.ToString());
            richTextBox1.SelectionFont = new Font(fontName, fontSize);
        }

        private void Size_changed(object sender, EventArgs e)
        {
            if (ComboBoxFont.SelectedItem == null || ComboBoxSize.SelectedItem == null) return;
            string fontName = ComboBoxFont.SelectedItem.ToString();
            float fontSize = float.Parse(ComboBoxSize.SelectedItem.ToString());
            richTextBox1.SelectionFont = new Font(fontName, fontSize);
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ApplyFontStyle(FontStyle.Bold);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ApplyFontStyle(FontStyle.Italic);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ApplyFontStyle(FontStyle.Underline);
        }
        private void ApplyFontStyle(FontStyle style)
        {
            if (richTextBox1.SelectionFont == null) return;
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newStyle;
            if (currentFont.Style.HasFlag(style))
                newStyle = currentFont.Style & ~style;
            else
                newStyle = currentFont.Style | style;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
        }
    }
}
