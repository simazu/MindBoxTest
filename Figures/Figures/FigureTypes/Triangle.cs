using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.FigureTypes
{
    public class Triangle : Figure
    {
        private readonly double[] edges;

        /// <summary>
        /// Длина первой стороны
        /// </summary>
        public double FirstEdge => edges[0];

        /// <summary>
        /// Длина второй стороны
        /// </summary>
        public double SecondEdge => edges[1];

        /// <summary>
        /// Длина третьей стороны
        /// </summary>
        public double ThirdEdge => edges[2];

        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="firstEdge">Длина первой стороны</param>
        /// <param name="secondEdge">Длина второй стороны</param>
        /// <param name="thirdEdge">Длина третьей стороны</param>
        /// <exception cref="ArgumentException">Неположительная длина стороны или не выполняется правило сторон треугольника</exception>
        public Triangle(double firstEdge, double secondEdge, double thirdEdge)
        {
            edges = new[] { firstEdge, secondEdge, thirdEdge };

            if (edges.Any(e => e <= 0))
                throw new ArgumentException("Длины сторон должны быть положительными");

            if (2 * edges.Max() > edges.Sum())
                throw new ArgumentException("Длина стороны не может быть больше суммы длин других сторон");
        }

        /// <summary>
        /// Проверяет является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            return edges
                .OrderBy(e => e)
                .Take(2)
                .Aggregate((e, n) => e * e + n * n) 
                == edges.Max() * edges.Max();
        }

        /// <summary>
        /// Вычисляет площадь треугольника
        /// </summary>
        /// <returns></returns>
        protected override double GetSquare()
        {
            var halfPerimetr = edges.Sum() / 2;
            return Math.Sqrt(edges
                .Aggregate(halfPerimetr, (e, n) => (halfPerimetr - n) * e));
        }
    }
}
