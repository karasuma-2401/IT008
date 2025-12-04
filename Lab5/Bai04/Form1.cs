namespace Bai04
{
    public partial class FormTextEditor : Form
    {
        public FormTextEditor()
        {
            InitializeComponent();
        }
        private void FormTextEditor_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cbbFont.Items.Add(font.Name);
            }
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            foreach (int s in sizes)
            {
                cbbSize.Items.Add(s);
            }
            cbbFont.SelectedItem = "Tahoma";
            cbbSize.SelectedItem = 14;
            txtContent.Font = new Font("Tahoma", 14, FontStyle.Regular);
            btnColor.BackColor = Color.Black;
        }

        private void rbtnLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLeft.Checked)
            {
                txtContent.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void rbtnCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCenter.Checked)
            {
                txtContent.TextAlign = HorizontalAlignment.Center;
            }
            else
            {
                txtContent.TextAlign = HorizontalAlignment.Left;
            }

        }

        private void rbtnRight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRight.Checked)
            {
                txtContent.TextAlign = HorizontalAlignment.Right;
            }
            else
            {
                txtContent.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                txtContent.ForeColor = colorDialog.Color;
            }
        }

        private void Font_Changed(object sender, EventArgs e)
        {
            Font currentFont = txtContent.Font;
            if (cbbFont.SelectedItem == null || cbbSize.SelectedItem == null) return;
            string fontName = cbbFont.SelectedItem.ToString();
            float fontSize = float.Parse(cbbSize.SelectedItem.ToString());
            txtContent.Font = new Font(fontName, fontSize, currentFont.Style);
        }

        private void Size_changed(object sender, EventArgs e)
        {
            Font currentFont = txtContent.Font;
            if (cbbFont.SelectedItem == null || cbbSize.SelectedItem == null) return;
            string fontName = cbbFont.SelectedItem.ToString();
            float fontSize = float.Parse(cbbSize.SelectedItem.ToString());
            txtContent.Font = new Font(fontName, fontSize, currentFont.Style);
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
            if (txtContent.Font == null) return;
            Font currentFont = txtContent.Font;
            FontStyle newStyle;
            if (currentFont.Style.HasFlag(style))
                newStyle = currentFont.Style & ~style;
            else
                newStyle = currentFont.Style | style;
            txtContent.Font = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
        }
    }
}
