using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Хранит значение внешнего радиуса.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Хранит значение внутреннего радиуса.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Создает экземпляр класса Ring.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус. Должен быть больше внутреннего и быть положительным числом.</param>
        /// <param name="innerRadius">Внутренний радиус. Должен быть меньше внешнего и быть положительным числом.</param>
        /// <param name="center"></param>
        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }

        /// <summary>
        /// Возвращает и задает координаты кольца внутри класса.
        /// </summary>
        public Point2D Center { get; private set; }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get => Math.PI * _outerRadius * _outerRadius - Math.PI * _innerRadius * _innerRadius;
        }

        /// <summary>
        /// Возвращает и задает внешний радиус. Должен быть больше внутреннего и быть положительным числом.
        /// </summary>
        public double OuterRadius
        {
            get { return _outerRadius; }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));

                if (value < _innerRadius)
                {
                    throw new AggregateException("Внешний радиус не может быть меньше внутреннего радиуса");
                }

                else
                {
                    _outerRadius = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус. Должен быть меньше внешнего и быть положительным числом.
        /// </summary>
        /// <exception cref="AggregateException"></exception>
        public double InnerRadius
        {
            get { return _innerRadius; }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));

                if (value > _outerRadius)
                {
                    throw new AggregateException("Внутренний радиус не может быть больше внешнего радиуса");
                }

                else
                {
                    _innerRadius = value;
                }
            }
        }
    }
}