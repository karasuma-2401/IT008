namespace Bai06
{
    public partial class FormAllFonts : Form
    {
        public FormAllFonts()
        {
            InitializeComponent();
        }

        private void FormAllFonts_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {

                lsvAllFonts.Items.Add(font.Name);
                lsvAllFonts.Items[lsvAllFonts.Items.Count - 1].Font = new Font(font.Name, 12);
            }
        }
    }
}
