using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : IShape
    {
        public Color ShapeColor { get; set; } = Color.Empty;
        public Point LocationPoint { get; set; } = new Point(0, 0);

        private int _sideOne;
        private int _sideTwo;
        private int _sideThree;
        public Triangle(int sideOne, int sideTwo, int sideThree)
        {
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
        }
        public Triangle(int sideOne, int sideTwo, int sideThree, Point location)
        {
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
            LocationPoint = location;
        }
        public Triangle(int sideOne, int sideTwo, int sideThree, int x, int y)
        {
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
            LocationPoint = new Point(x, y);
        }
        public void Draw(Graphics formGraphics)
        {
            using (SolidBrush solidBrush = new SolidBrush(ShapeColor))
            {
                Point firstPoint = LocationPoint;
                Point secondPoint = new Point(LocationPoint.X, LocationPoint.Y + _sideOne);
                Point thirdPoint = new Point(LocationPoint.X+_sideThree, LocationPoint.Y);
                formGraphics.DrawPolygon(new Pen(solidBrush), new Point[] { firstPoint, secondPoint, thirdPoint });
            }
        }

        public double GetPerimeter()
        {
            return _sideOne + _sideTwo + _sideThree;
        }

        public double GetSquare()
        {
            //Поиск площади производим по формуле Герона
            double p = (_sideOne + _sideTwo + _sideThree) / 2;
            double s = Math.Sqrt(p * (p - _sideOne) * (p - _sideTwo) * (p - _sideThree));
            return s;
        }
    }
}
