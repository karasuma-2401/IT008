namespace Bai02
{
    public partial class RandomPosition : Form
    {
        Random rand = new Random();
        public RandomPosition()
        {
            InitializeComponent();
        }
        private void Form1_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = rand.Next(0, this.ClientSize.Width - 120);
            int y = rand.Next(0, this.ClientSize.Height - 40);

            Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(255));
            Brush brush = new SolidBrush(Color.Black);

            g.DrawString("Paint Event", new Font("Times New Roman", 14, FontStyle.Bold), brush, x, y);

            brush.Dispose();
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Invalidate();
        }

    }
}
