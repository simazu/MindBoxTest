using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.FigureTypes
{
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException">Неположительный радиус</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным");
            Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга
        /// </summary>
        /// <returns></returns>
        protected override double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
