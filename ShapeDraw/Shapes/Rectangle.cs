using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IShape
    {
        public Color ShapeColor { get; set; } = Color.Empty;
        public Point LocationPoint { get; set; } = new Point(0, 0);

        private int _width;
        private int _height;
        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }
        public Rectangle(int width, int height, Point location)
        {
            _width = width;
            _height = height;
            LocationPoint = location;
        }
        public Rectangle(int width, int height, int x, int y)
        {
            _width = width;
            _height = height;
            LocationPoint = new Point(x,y);
        }
        public void Draw(Graphics formGraphics)
        {
            using (SolidBrush solidBrush = new SolidBrush(ShapeColor))
            {
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(LocationPoint, new Size(_width,_height));
                formGraphics.FillRectangle(solidBrush, rectangle);
            }
        }

        public double GetPerimeter()
        {
            return 2 * (_width + _height);
        }

        public double GetSquare()
        {
            return _width * _height;
        }
    }
}
