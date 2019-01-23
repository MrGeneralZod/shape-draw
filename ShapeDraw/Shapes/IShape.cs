using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public interface IShape
    {
        /// <summary>
        /// Цвет заливки фигуры
        /// </summary>
        Color ShapeColor { get; set; }
        /// <summary>
        /// Положение фигуры на плоскости
        /// </summary>
        Point LocationPoint { get; set; }
        /// <summary>
        /// Нарисавать фигуру на форме
        /// </summary>
        /// <param name="formGraphics">форма рисования</param>
        void Draw(Graphics formGraphics);
        /// <summary>
        /// Получить периметр фигуры
        /// </summary>
        /// <returns></returns>
        double GetPerimeter();
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns></returns>
        double GetSquare();
    }
}
