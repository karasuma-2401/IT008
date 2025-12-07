using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai09
{
    public partial class FormComboBoxTest : Form
    {
        Bitmap bitmap;
        Graphics graphicsContext;

        Color strokeColor = Color.Black;
        Color fillColor = Color.Blue;

        Pen drawingPen;
        Point Start, End;
        bool isDrawing = false;

        public FormComboBoxTest()
        {
            InitializeComponent();
        }

        private void FormComboBoxTest_Load(object sender, EventArgs e)
        {
            if (ptbLayout.Width > 0 && ptbLayout.Height > 0)
                bitmap = new Bitmap(ptbLayout.Width, ptbLayout.Height);
            else
                bitmap = new Bitmap(800, 600);

            graphicsContext = Graphics.FromImage(bitmap);
            graphicsContext.SmoothingMode = SmoothingMode.AntiAlias;
            graphicsContext.Clear(Color.White);

            drawingPen = new Pen(strokeColor, 2);

            if (cbShape.Items.Count > 0)
                cbShape.SelectedIndex = 0;
            ptbLayout.Image = bitmap;

        }
        private void ptbLayout_Resize(object sender, EventArgs e)
        {
            if (bitmap == null || ptbLayout.Width <= 0 || ptbLayout.Height <= 0) return;
            Bitmap newBitmap = new Bitmap(ptbLayout.Width, ptbLayout.Height);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.Clear(Color.White); 
                g.DrawImage(bitmap, 0, 0); 
            }
            bitmap = newBitmap;
            ptbLayout.Image = bitmap;
            if (graphicsContext != null) graphicsContext.Dispose();
            graphicsContext = Graphics.FromImage(bitmap);           
            graphicsContext.SmoothingMode = SmoothingMode.AntiAlias; 
        }
        private void ptbLayout_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            Start.X = e.X;
            Start.Y = e.Y;
            End.X = e.X;
            End.Y = e.Y;
        }

        private void ptbLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            End = e.Location;

            if (cbShape.Text == "Curve")
            {
                graphicsContext.DrawLine(drawingPen, Start, e.Location);
                Start = e.Location;
            }
            ptbLayout.Invalidate();
        }
        private void ptbLayout_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            End = e.Location;
            if (cbShape.Text != "Curve")
            {
                DrawShape(graphicsContext, cbShape.Text, Start, End);
            }
            ptbLayout.Invalidate();
        }

        private void ptbLayout_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing && cbShape.Text != "Curve")
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawShape(e.Graphics, cbShape.Text, Start, End);
            }
        }
        private Rectangle CreateRectangleFromPoints(int p1x, int p1y, int p2x, int p2y)
        {
            return new Rectangle(
                Math.Min(p1x, p2x),
                Math.Min(p1y, p2y),
                Math.Abs(p2x - p1x),
                Math.Abs(p2y - p1y));
        }
        private void DrawShape(Graphics g, string shapeType, Point start, Point end)
        {
            Brush fillBrush = new SolidBrush(fillColor);
            Rectangle rect;

            switch (shapeType)
            {
                case "Square":
                    int sideSq = Math.Min(Math.Abs(End.X - Start.X), Math.Abs(End.Y - Start.Y));
                    int sqX = (End.X < Start.X) ? Start.X - sideSq : Start.X;
                    int sqY = (End.Y < Start.Y) ? Start.Y - sideSq : Start.Y;
                    g.DrawRectangle(drawingPen, sqX, sqY, sideSq, sideSq);
                    break;

                case "Circle":
                    int dia = Math.Min(Math.Abs(End.X - Start.X), Math.Abs(End.Y - Start.Y));
                    int circX = (End.X < Start.X) ? Start.X - dia : Start.X;
                    int circY = (End.Y < Start.Y) ? Start.Y - dia : Start.Y;
                    g.DrawEllipse(drawingPen, circX, circY, dia, dia);
                    break;

                case "Ellipse":
                    rect = CreateRectangleFromPoints(Start.X, Start.Y, End.X, End.Y);
                    g.DrawEllipse(drawingPen, rect);
                    break;

                case "Pie":
                    rect = CreateRectangleFromPoints(Start.X, Start.Y, End.X, End.Y);
                    if (rect.Width <= 0 || rect.Height <= 0)
                        break;
                    g.DrawPie(drawingPen, rect, 0, 360);
                    g.DrawPie(drawingPen, rect, 0, 250);
                    g.DrawPie(drawingPen, rect, 0, 100);
                    break;

                case "Filled Square":
                    int sideF = Math.Min(Math.Abs(End.X - Start.X), Math.Abs(End.Y - Start.Y));
                    int fSqX = (End.X < Start.X) ? Start.X - sideF : Start.X;
                    int fSqY = (End.Y < Start.Y) ? Start.Y - sideF : Start.Y;
                    Rectangle fSquare = new Rectangle(fSqX, fSqY, sideF, sideF);
                    g.FillRectangle(fillBrush, fSquare);
                    g.DrawRectangle(drawingPen, fSquare);
                    break;

                case "Filled Circle":
                    int diaF = Math.Min(Math.Abs(End.X - Start.X), Math.Abs(End.Y - Start.Y));
                    int fCircX = (End.X < Start.X) ? Start.X - diaF : Start.X;
                    int fCircY = (End.Y < Start.Y) ? Start.Y - diaF : Start.Y;
                    Rectangle fCircle = new Rectangle(fCircX, fCircY, diaF, diaF);
                    g.FillEllipse(fillBrush, fCircle);
                    g.DrawEllipse(drawingPen, fCircle);
                    break;

                case "Filled Ellipse":
                    rect = CreateRectangleFromPoints(Start.X, Start.Y, End.X, End.Y);
                    g.FillEllipse(fillBrush, rect);
                    g.DrawEllipse(drawingPen, rect);
                    break;

                case "Filled Pie":
                    rect = CreateRectangleFromPoints(Start.X, Start.Y, End.X, End.Y);
                    if (rect.Width <= 0 || rect.Height <= 0)
                        break;
                    g.FillPie(fillBrush, rect, 0, 360);
                    g.DrawPie(drawingPen, rect, 0, 360);
                    g.DrawPie(drawingPen, rect, 0, 250);
                    g.DrawPie(drawingPen, rect, 0, 100);
                    break;
            }
        }
    }
}