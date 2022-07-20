namespace Figures
{
    public abstract class Figure
    {
        private  readonly Lazy<double> square;

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Square => square.Value;
        protected Figure()
        {
            square = new Lazy<double>(GetSquare);
        }

        /// <summary>
        /// Вычисляет площадь фигуры
        /// </summary>
        /// <returns></returns>
        protected abstract double GetSquare();
    }
}