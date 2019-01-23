using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShape
    {
        public Color ShapeColor { get; set; } = Color.Empty;
        public Point LocationPoint { get; set; } = new Point(0, 0);
        private readonly int _radiant;
        public Circle(int radiant)
        {
            _radiant = radiant;
        }
        public Circle(int radiant, Point location)
        {
            _radiant = radiant;
            LocationPoint = location;
        }
        public Circle(int radiant, int x, int y)
        {
            _radiant = radiant;
            LocationPoint = new Point(x,y);
        }
        public void Draw(Graphics formGraphics)
        {
            using (SolidBrush solidBrush = new SolidBrush(ShapeColor))
            {
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(LocationPoint, new Size(_radiant, _radiant));
                formGraphics.FillEllipse(solidBrush, rectangle);
            }
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * _radiant;
        }
        public double GetSquare()
        {
            return Math.PI * Math.Pow(_radiant,2);
        }
    }
}
