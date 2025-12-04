using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        Bitmap drawingSurface;
        Graphics graphicsContext;

        Color strokeColor = Color.Black;
        Color fillColor = Color.Blue;

        Pen drawingPen;
        int initialX, initialY, finalX, finalY;
        bool isDrawing = false;

        List<Point> currentPathPoints = new List<Point>();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (pictureBox1.Width > 0 && pictureBox1.Height > 0)
                drawingSurface = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            else
                drawingSurface = new Bitmap(800, 600);

            graphicsContext = Graphics.FromImage(drawingSurface);
            graphicsContext.SmoothingMode = SmoothingMode.AntiAlias;
            graphicsContext.Clear(Color.White);

            drawingPen = new Pen(strokeColor, 2);
            if (cbShape.Items.Count > 0) cbShape.SelectedIndex = 0;

            pictureBox1.Image = drawingSurface;

            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            initialX = e.X;
            initialY = e.Y;

            if (cbShape.Text == "Curve")
            {
                currentPathPoints.Clear();
                currentPathPoints.Add(new Point(e.X, e.Y));
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            if (cbShape.Text == "Curve")
            {
                graphicsContext.DrawLine(drawingPen, initialX, initialY, e.X, e.Y);
                initialX = e.X;
                initialY = e.Y;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            finalX = e.X;
            finalY = e.Y;

            Brush fillBrush = new SolidBrush(fillColor);
            Rectangle rect;

            switch (cbShape.Text)
            {
                // --- NHÓM 1: Đã thêm lệnh Fill vào 4 case này ---

                case "Square":
                    int sideSquare = Math.Min(Math.Abs(finalX - initialX), Math.Abs(finalY - initialY));
                    int sqX = (finalX < initialX) ? initialX - sideSquare : initialX;
                    int sqY = (finalY < initialY) ? initialY - sideSquare : initialY;
                    Rectangle square = new Rectangle(sqX, sqY, sideSquare, sideSquare);

                    graphicsContext.DrawRectangle(drawingPen, square);
                    break;

                case "Circle":
                    int diameter = Math.Min(Math.Abs(finalX - initialX), Math.Abs(finalY - initialY));
                    int circX = (finalX < initialX) ? initialX - diameter : initialX;
                    int circY = (finalY < initialY) ? initialY - diameter : initialY;
                    Rectangle circle = new Rectangle(circX, circY, diameter, diameter);

                    graphicsContext.DrawEllipse(drawingPen, circle);
                    break;

                case "Ellipse":
                    rect = CreateRectangleFromPoints(initialX, initialY, finalX, finalY);

                    graphicsContext.DrawEllipse(drawingPen, rect);
                    break;

                case "Pie":
                    rect = CreateRectangleFromPoints(initialX, initialY, finalX, finalY);

                    graphicsContext.DrawPie(drawingPen, rect, 0, 30);
                    graphicsContext.DrawPie(drawingPen, rect, 0, 10);
                    graphicsContext.DrawPie(drawingPen, rect, 0, 360);
                    graphicsContext.DrawPie(drawingPen, rect, 0, 270);
                    graphicsContext.DrawPie(drawingPen, rect, 0, 90);
                    break;

                case "Filled Square":
                    int side = Math.Min(Math.Abs(finalX - initialX), Math.Abs(finalY - initialY));
                    int FilledsqX = (finalX < initialX) ? initialX - side : initialX;
                    int FilledsqY = (finalY < initialY) ? initialY - side : initialY;
                    Rectangle Filledsquare = new Rectangle(FilledsqX, FilledsqY, side, side);

                    graphicsContext.FillRectangle(fillBrush, Filledsquare);
                    graphicsContext.DrawRectangle(drawingPen, Filledsquare);
                    break;

                case "Filled Circle":
                    int fillDia = Math.Min(Math.Abs(finalX - initialX), Math.Abs(finalY - initialY));
                    int fCircX = (finalX < initialX) ? initialX - fillDia : initialX;
                    int fCircY = (finalY < initialY) ? initialY - fillDia : initialY;
                    Rectangle fillCircle = new Rectangle(fCircX, fCircY, fillDia, fillDia);

                    graphicsContext.FillEllipse(fillBrush, fillCircle);
                    graphicsContext.DrawEllipse(drawingPen, fillCircle);
                    break;

                case "Filled Ellipse":
                    rect = CreateRectangleFromPoints(initialX, initialY, finalX, finalY);
                    graphicsContext.FillEllipse(fillBrush, rect);
                    graphicsContext.DrawEllipse(drawingPen, rect);
                    break;

                case "Filled Pie":
                    rect = CreateRectangleFromPoints(initialX, initialY, finalX, finalY);
                    graphicsContext.FillPie(fillBrush, rect, 0, 360);
                    graphicsContext.DrawPie(drawingPen, rect, 0, 30);
                    graphicsContext.DrawPie(drawingPen, rect, 0, 10);
                    graphicsContext.DrawPie(drawingPen, rect, 0, 360);
                    graphicsContext.DrawPie(drawingPen, rect, 0, 270);
                    graphicsContext.DrawPie(drawingPen, rect, 0, 90);
                    break;
            }

            pictureBox1.Refresh();
        }
        private Rectangle CreateRectangleFromPoints(int p1x, int p1y, int p2x, int p2y)
        {
            return new Rectangle(
                Math.Min(p1x, p2x),
                Math.Min(p1y, p2y),
                Math.Abs(p2x - p1x),
                Math.Abs(p2y - p1y));
        }
    }
}