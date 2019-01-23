using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shapes;

namespace ShapeDraw
{
    public partial class Form1 : Form
    {
        IShape shape;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //shape = new Circle(100);
            //shape.ShapeColor = Color.Red;
            //shape.LocationPoint = new Point(50, 50);
            //Graphics graphics = CreateGraphics();
            //shape.Draw(graphics);

            //shape = new Shapes.Rectangle(100,300);
            //shape.ShapeColor = Color.Red;
            //shape.LocationPoint = new Point(50, 50);
            //Graphics graphics = CreateGraphics();
            //shape.Draw(graphics);

            shape = new Triangle(10, 10, 10);
            shape.ShapeColor = Color.Red;
            shape.LocationPoint = new Point(50, 50);
            Graphics graphics = CreateGraphics();
            shape.Draw(graphics);
        }
    }
}
