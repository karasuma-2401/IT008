using System.Drawing.Drawing2D;

namespace Bai11
{
    public partial class FormPaintApp : Form
    {
        Point Start, End;
        Bitmap bitmap;
        bool isDrawing = false;
        Graphics g;
        Color penColor = Color.Blue;
        public FormPaintApp()
        {
            InitializeComponent();

        }
        private void FormPaintApp_Load(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                bitmap = new Bitmap(ptbLayout.Width, ptbLayout.Height);
                g = Graphics.FromImage(bitmap);
                g.Clear(Color.White);
                ptbLayout.Image = bitmap;
            }
            txtWidth.Text = "1";
        }
        private void FormPaintApp_Resize(object sender, EventArgs e)
        {
            if (bitmap == null) return;
            Bitmap newBitmap = new Bitmap(ptbLayout.Width, ptbLayout.Height);

            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.Clear(Color.White);
                g.DrawImage(bitmap, 0, 0);
            }
            bitmap = newBitmap;
            ptbLayout.Image = bitmap;
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                penColor = colorDialog.Color;
                btnColor.BackColor = penColor;
            }
        }
        private void ptbLayout_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            Start = e.Location;

        }
        private void ptbLayout_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                End = e.Location;

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    DrawShape(g, Start, End);
                }
                ptbLayout.Refresh();
            }
        }

        private void ptbLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                End = e.Location;
                ptbLayout.Refresh();
            }
        }

        private void ptbLayout_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                DrawShape(e.Graphics, Start, End);
            }
        }
        private void DrawShape(Graphics g, Point start, Point end)
        {
            float widthPen = 1;
            if (float.TryParse(txtWidth.Text, out float w) && w > 0)
            {
                widthPen = w;
            }

            Pen pen = new Pen(penColor, widthPen);
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);
            Rectangle rect = new Rectangle(x, y, width, height);

            if (rbtnLine.Checked)
            {
                g.DrawLine(pen, start, end);
            }
            else
            {
                Brush currentBrush = null;
                if (rbtnSolidBrush.Checked)
                {
                    currentBrush = new SolidBrush(Color.Green);
                }
                else if (rbtnHatchBrush.Checked)
                {
                    currentBrush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
                }
                else if (rbtnTextureBrush.Checked)
                {
                    currentBrush = new TextureBrush(Properties.Resources.texture);
                }
                else if (rbtnLinearGradientBrush.Checked)
                {
                    if (width > 0 && height > 0)
                        currentBrush = new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
                    else
                        currentBrush = new SolidBrush(Color.Red);
                }
                if (rbtnRectangle.Checked)
                {
                    if (currentBrush != null)
                        g.FillRectangle(currentBrush, rect);
                    else
                        g.DrawRectangle(pen, rect);
                }
                else if (rbtnEllipse.Checked)
                {
                    if (currentBrush != null)
                        g.FillEllipse(currentBrush, rect);
                    else
                        g.DrawEllipse(pen, rect);
                }
            }
        }
    }
}