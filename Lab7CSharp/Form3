using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form3 : Form
    {
        private List<Shape> shapes = new List<Shape>();
        private Random random = new Random();

        public Form3()
        {
            InitializeComponent();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            RefreshDrawing(); 
        }
        public enum ShapeType
        {
            Circle,
            Sector,
            FilledRectangle,
            Star
        }

        public abstract class Shape
        {
            protected int x;
            protected int y;
            protected Color color;

            public Shape(int x, int y, Color color)
            {
                this.x = x;
                this.y = y;
                this.color = color;
            }

            public abstract void Draw(Graphics g);
            public void MoveTo(int newX, int newY)
            {
                x = newX;
                y = newY;
            }
        }

        public class CircleShape : Shape
        {
            private readonly int diameter;

            public CircleShape(int x, int y, int diameter, Color color) : base(x, y, color)
            {
                this.diameter = diameter;
            }

            public override void Draw(Graphics g)
            {
                g.DrawEllipse(new Pen(color), x, y, diameter, diameter);
            }
        }

        public class SectorShape : Shape
        {
            private readonly int diameter;
            private readonly int startAngle;
            private readonly int sweepAngle;

            public SectorShape(int x, int y, int diameter, int startAngle, int sweepAngle, Color color) : base(x, y, color)
            {
                this.diameter = diameter;
                this.startAngle = startAngle;
                this.sweepAngle = sweepAngle;
            }

            public override void Draw(Graphics g)
            {
                g.DrawPie(new Pen(color), x, y, diameter, diameter, startAngle, sweepAngle);
            }
        }

        public class FilledRectangleShape : Shape
        {
            private readonly int width;
            private readonly int height;

            public FilledRectangleShape(int x, int y, int width, int height, Color color) : base(x, y, color)
            {
                this.width = width;
                this.height = height;
            }

            public override void Draw(Graphics g)
            {
                g.FillRectangle(new SolidBrush(color), x, y, width, height);
            }
        }

        public class StarShape : Shape
        {
            private readonly Point[] points;

            public StarShape(int x, int y, Point[] points, Color color) : base(x, y, color)
            {
                this.points = points;
            }

            public override void Draw(Graphics g)
            {
                g.DrawPolygon(new Pen(color), points);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            random = new Random();
            ShapeType shapeType = (ShapeType)random.Next(4);

            int x = random.Next(pictureBox1.Width);
            int y = random.Next(pictureBox1.Height);

            int param1 = random.Next(10, 100);
            int param2 = random.Next(10, 100);

            Color color = GetRandomColor();

            Shape shape;
            switch (shapeType)
            {
                case ShapeType.Circle:
                    shape = new CircleShape(x, y, param1, color);
                    break;
                case ShapeType.Sector:
                    shape = new SectorShape(x, y, param1, random.Next(360), random.Next(360), color);
                    break;
                case ShapeType.FilledRectangle:
                    shape = new FilledRectangleShape(x, y, param1, param2, color);
                    break;
                case ShapeType.Star:
                    shape = new StarShape(x, y, GenerateStarPoints(x, y, param1, 5), color);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            shapes.Add(shape);

            RefreshDrawing();
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private Point[] GenerateStarPoints(int x, int y, int size, int numPoints)
        {
            double angleIncrement = Math.PI / numPoints;
            Point[] points = new Point[numPoints * 2];
            for (int i = 0; i < numPoints * 2; i++)
            {
                double angle = i * angleIncrement;
                int radius = i % 2 == 0 ? size : size / 2;
                points[i] = new Point((int)(x + radius * Math.Cos(angle)), (int)(y + radius * Math.Sin(angle)));
            }
            return points;
        }

        private void RefreshDrawing()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                foreach (var shape in shapes)
                {
                    shape.Draw(g);
                }
            }

            pictureBox1.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            using (Graphics g = pictureBox1.CreateGraphics())
            {
                g.Clear(Color.White);
            }
        }
    }
}
