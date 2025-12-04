namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {

                lsvAllFont.Items.Add(font.Name);
                lsvAllFont.Items[lsvAllFont.Items.Count - 1].Font = new Font(font.Name, 12);
            }
        }
    }
}
