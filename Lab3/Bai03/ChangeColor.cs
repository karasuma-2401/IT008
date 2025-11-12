using System.Drawing.Drawing2D;

namespace Bai03
{
    public partial class ChangeColor : Form
    {
        Random rand = new Random();
        public ChangeColor()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            this.BackColor = randomColor;
        }

    }
}
