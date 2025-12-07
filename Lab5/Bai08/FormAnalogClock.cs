using System.Drawing.Drawing2D;
using System.Media;

namespace Bai08
{
    public partial class FormAnalogClock : Form
    {
        Point[,] hands_coord = new Point[3, 2]
        {
            { new Point(0,0), new Point(0, 60) },  
            { new Point(0,0), new Point(0, 100) }, 
            { new Point(0,0), new Point(0, 120) }  
        };

        DateTime Current;
        DateTime Previous;
        bool Change;
        private SoundPlayer _tickSound;
        public FormAnalogClock()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            _tickSound = new SoundPlayer(Properties.Resources.click_Clock);
            _tickSound.LoadAsync();
        }

        private void RotatePoint(Point[] points, int iRotate, int iAngle)
        {
            Point point = new Point();
            for (int i = 0; i < iRotate; i++)
            {
                point.X = (int)(points[i].X * Math.Cos(2 * iAngle * Math.PI / 360) - points[i].Y * Math.Sin(2 * iAngle * Math.PI / 360));
                point.Y = (int)(points[i].X * Math.Sin(2 * iAngle * Math.PI / 360) + points[i].Y * Math.Cos(2 * iAngle * Math.PI / 360));
                points[i] = point;
            }
        }

        private void FormAnalogClock_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.TranslateTransform(this.Size.Width / 2, this.Size.Height / 2);
            e.Graphics.RotateTransform(180);
            DrawClock(e.Graphics);
            DrawHands(e.Graphics, Previous, true, Color.Black);
        }
        private void DrawClock(Graphics e)
        {
            e.SmoothingMode = SmoothingMode.AntiAlias;

            Point[] points = new Point[2];
            for (int iAngle = 0; iAngle < 360; iAngle += 6)
            {
                points[0].X = 0;
                points[0].Y = 150;

                RotatePoint(points, 1, iAngle);
                points[1].X = points[1].Y = (iAngle % 5 == 0 ? 10 : 5);

                points[0].X -= points[1].X / 2;
                points[0].Y -= points[1].Y / 2;
                Pen pen = new Pen(Color.Black);
                e.DrawEllipse(pen, points[0].X, points[0].Y, points[1].X, points[1].Y);
                e.FillEllipse(new SolidBrush(Color.Black), points[0].X, points[0].Y, points[1].X, points[1].Y);
            }
        }
        private void DrawHands(Graphics e, DateTime datetime, bool change, Color color)
        {
            Point[,] points = new Point[3, 2];
            int[] iAngle = new int[3];
            iAngle[0] = (int)((datetime.Hour * 30) % 360 + datetime.Minute / 2);
            iAngle[1] = (int)(datetime.Minute * 6);
            iAngle[2] = (int)(datetime.Second * 6);
            points = (Point[,])hands_coord.Clone();
            for (int i = change ? 0 : 2; i < 3; i++)
            {
                Point[] tt = { points[i, 0], points[i, 1] };
                RotatePoint(tt, 2, iAngle[i]);

                int thickness = (i == 0) ? 5 : (i == 1 ? 3 : 1);
                color = i == 2 ? Color.Red : Color.Black;

                Pen pen = new Pen(color, thickness);
                e.DrawLine(pen, tt[0], tt[1]);
            }
        }

        private void FormAnalogClock_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _tickSound.Play();
            Current = DateTime.Now;
            Change = Current.Hour != Previous.Hour || Current.Minute != Previous.Minute;
            DrawHands(this.CreateGraphics(), Current, Change, Color.White);
            DrawHands(this.CreateGraphics(), Current, true, Color.Black);
            Previous = Current;
            Invalidate();
        }
    }
}
