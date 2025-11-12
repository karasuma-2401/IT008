namespace Bai04
{
    public partial class BackgroundColor : Form
    {
        public BackgroundColor()
        {
            InitializeComponent();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }

        }
    }
}
