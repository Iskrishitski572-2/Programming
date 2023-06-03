namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные координаты в 2D пространстве.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Хранит значение координаты x.
        /// </summary>
        private double _x;

        /// <summary>
        /// Хранит значение координаты y.
        /// </summary>
        private double _y;

        /// <summary>
        /// Создает экземпляр класса Point2D.
        /// </summary>
        /// <param name="x">Координата x. Должна быть больше нуля.</param>
        /// <param name="y">Координата y. Должна быть больше нуля.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает и задает координату x внутри класса.
        /// </summary>
        public double X
        {
            get { return _x; }

            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));

                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату y внутри класса.
        /// </summary>
        public double Y
        {
            get { return _y; }

            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));

                _y = value;
            }
        }
    }
}
