using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Bai10
{
    public partial class FormPenDemo : Form
    {
        List<Point> ListPoints = new List<Point>();
        bool isDrawing = false;
        public FormPenDemo()
        {
            InitializeComponent();
        }
        private void FormPenDemo_Load(object sender, EventArgs e)
        {
            cbbWidth.SelectedIndex = 0;
            cbbDashStyle.SelectedIndex = 0;
            cbbStartCap.SelectedIndex = 0;
            cbbEndCap.SelectedIndex = 0;
            cbbDashCap.SelectedIndex = 0;
            cbbLineJoin.SelectedIndex = 0;
        }
        private void ptbLayout_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            ListPoints.Clear(); 
            ListPoints.Add(e.Location);
        }
        private void ptbLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                ListPoints.Add(e.Location);
                ptbLayout.Invalidate();
            }
        }
        private void ptbLayout_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            ptbLayout.Invalidate();
        }
        private void ptbLayout_Paint(object sender, PaintEventArgs e)
        {
            if (ListPoints.Count > 1)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (Pen pen = new Pen(Color.Blue))
                {
                    try
                    {
                        pen.Width = float.Parse(cbbWidth.Text);
                        pen.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), cbbDashStyle.Text);
                        pen.StartCap = (LineCap)Enum.Parse(typeof(LineCap), cbbStartCap.Text);
                        pen.EndCap = (LineCap)Enum.Parse(typeof(LineCap), cbbEndCap.Text);
                        pen.DashCap = (DashCap)Enum.Parse(typeof(DashCap), cbbDashCap.Text);
                        pen.LineJoin = (LineJoin)Enum.Parse(typeof(LineJoin), cbbLineJoin.Text);
                    }
                    catch
                    {
                        return;
                    }
                    e.Graphics.DrawLines(pen, ListPoints.ToArray());
                }
            }
        }
    }
}
