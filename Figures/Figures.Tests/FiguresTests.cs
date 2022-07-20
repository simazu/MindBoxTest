using NUnit.Framework;
using Figures;
using Figures.FigureTypes;

namespace Figures.Tests
{
    [TestFixture]
    public class FiguresTests
    {
        #region Triangle test 
        /// <summary>
        /// Тестирует функции вычисления площади и проверки на прямоугольность треугольника
        /// </summary>
        /// <param name="a">Длина первой стороны</param>
        /// <param name="b">Длина второй стороны</param>
        /// <param name="c">Длина третьей стороны</param>
        /// <param name="expected">Ожидаемое значение площади</param>
        /// <param name="isRight">Ожидаемое значение проверки на прямоугольность</param>
        [TestCase(3, 4, 5, 6, true)]
        [TestCase(9.23, 7, 13.03345235234, 31.049245, false)]
        public void GetTriangleSquareTest(double a, double b, double c, double expected, bool isRight)
        {
            var triangle = new Triangle(a, b, c);
            Assert.That(triangle.Square, Is.EqualTo(expected).Within(0.000001));
            Assert.That(triangle.IsRightTriangle, Is.EqualTo(isRight));
        }

        /// <summary>
        /// Тестирует геометрически невозможные длины сторон треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        [TestCase(-6, 7, 8)]
        [TestCase(6, 0, 6)]
        [TestCase(23, 4, 5)]
        public void TriangleArgumentExceptionTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }
        #endregion

        #region Circle test
        /// <summary>
        /// Тестирует функцию вычисления площади круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <param name="expected">Ожидаемое значение площади</param>
        [TestCase(3, 28.274333)]
        [TestCase(9.23356, 267.847886)]
        public void GetCircleSquareTest(double radius, double expected)
        {
            var circle = new Circle(radius);
            Assert.That(circle.Radius, Is.EqualTo(radius));
            Assert.That(circle.Square, Is.EqualTo(expected).Within(0.000001));
        }

        /// <summary>
        /// Тестирует круг с неположительным радиусом
        /// </summary>
        /// <param name="radius"></param>
        [TestCase(0)]
        [TestCase(-7.13)]
        public void CircleArgumentExceptionTest(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
        #endregion
    }
}