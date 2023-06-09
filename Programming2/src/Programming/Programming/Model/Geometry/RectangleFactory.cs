
namespace Programming.Model.Geometry
{
    /// <summary>
    /// Реализуют статическую работу с прямоугольниками.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Экземпляр класса Random.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Создает объекта прямоугольник с заполненными случайными значениями. 
        /// </summary>
        /// <returns>Случайный прямоугольник.</returns>
        public static Rectangle Randomize()
        {
            var width = _random.Next(30, 50);
            var height = _random.Next(30, 60);

            var x = _random.Next(1, 300);
            var y = _random.Next(1, 300);
            var coordinate = new Point2D(x, y);

            var colorValues = Enum.GetValues(typeof(Colors));
            var color = colorValues.GetValue(_random.Next(0, 6)).ToString();

            return new Rectangle(height, width, color, coordinate);
        }
    }
}
