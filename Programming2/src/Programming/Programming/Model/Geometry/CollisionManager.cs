namespace Programming.Model.Geometry
{
    /// <summary>
    /// Реализует статическую проверку на пересечение геометрических фигур.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверка пересечения прямоугольников.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если условия пересечения верны.
        /// И false, если условия пересечения неверны.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            var width1 = rectangle1.Width;
            var width2 = rectangle2.Width;

            var length1 = rectangle1.Length;
            var length2 = rectangle2.Length;

            var dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            var dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            return dX < (width1 + width2) / 2 && dY < (length1 + length2) / 2;
        }

        /// <summary>
        /// Проверка пересечения колец.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если условия пересечения верны.
        /// И false, если условия пересечения неверны.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            var radius1 = ring1.OuterRadius;
            var radius2 = ring2.OuterRadius;

            var dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            var dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);

            var c = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            return c < radius1 + radius2;
        }
    }
}