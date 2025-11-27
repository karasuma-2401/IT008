using System;

namespace Bai04
{
    public partial class FormTextEditor : Form
    {
        private string currentFilePath = null;
        public FormTextEditor()
        {
            InitializeComponent();
        }
        private void FormTextEditor_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                tscbbFont.Items.Add(font.Name);
            }
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            foreach (int s in sizes)
            {
                tscbbSize.Items.Add(s);
            }
            tscbbFont.SelectedItem = "Tahoma";
            tscbbSize.SelectedItem = 14;
            rtxtContent.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }
        private void ResetTextEditor()
        {
            rtxtContent.Clear();
            tscbbFont.SelectedItem = "Tahoma";
            tscbbSize.SelectedItem = 14;
            rtxtContent.Font = new Font("Tahoma", 14, FontStyle.Regular);
            currentFilePath = null;
        }
        private void tsbtnAddNewText_Click(object sender, EventArgs e)
        {
            ResetTextEditor();
        }

        private void tsmiAddNewText_Click(object sender, EventArgs e)
        {
            ResetTextEditor();
        }
        private void tsmiOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "RTF file|*.rtf|TXT file|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName.EndsWith(".rft"))
                {
                    rtxtContent.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    rtxtContent.LoadFile(currentFilePath, RichTextBoxStreamType.PlainText);
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
                    rtxtContent.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                if (saveFileDialog1.FileName.EndsWith(".rft"))
                {
                    rtxtContent.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    rtxtContent.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);
                }
                MessageBox.Show("Lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void tsbtnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void tsmiSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tsmiFormat_Click(object sender, EventArgs e)
        {
            FontDialog fontdl = new FontDialog();
            if (rtxtContent.SelectionFont != null)
            {
                fontdl.Font = rtxtContent.SelectionFont;
            }
            else
            {
                fontdl.Font = rtxtContent.Font;
            }

            if (fontdl.ShowDialog() == DialogResult.OK)
            {
                rtxtContent.SelectionFont = fontdl.Font;
                tscbbFont.Text = fontdl.Font.Name;
                tscbbSize.Text = fontdl.Font.Size.ToString();
            }
        }
        private void Font_Changed(object sender, EventArgs e)
        {
            if (tscbbFont.SelectedItem == null || tscbbSize.SelectedItem == null) return;
            string fontName = tscbbFont.SelectedItem.ToString();
            float fontSize = float.Parse(tscbbSize.SelectedItem.ToString());
            rtxtContent.SelectionFont = new Font(fontName, fontSize);
        }

        private void Size_changed(object sender, EventArgs e)
        {
            if (tscbbFont.SelectedItem == null || tscbbSize.SelectedItem == null) return;
            string fontName = tscbbFont.SelectedItem.ToString();
            float fontSize = float.Parse(tscbbSize.SelectedItem.ToString());
            rtxtContent.SelectionFont = new Font(fontName, fontSize);
        }
        private void tsbtnBold_Click(object sender, EventArgs e)
        {
            ApplyFontStyle(FontStyle.Bold);
        }

        private void tsbtnItalic_Click(object sender, EventArgs e)
        {
            ApplyFontStyle(FontStyle.Italic);
        }

        private void tsbtnUnderline_Click(object sender, EventArgs e)
        {
            ApplyFontStyle(FontStyle.Underline);
        }
        private void ApplyFontStyle(FontStyle style)
        {
            if (rtxtContent.SelectionFont == null) return;
            Font currentFont = rtxtContent.SelectionFont;
            FontStyle newStyle;
            if (currentFont.Style.HasFlag(style))
                newStyle = currentFont.Style & ~style;
            else
                newStyle = currentFont.Style | style;
            rtxtContent.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
        }
    }
}
