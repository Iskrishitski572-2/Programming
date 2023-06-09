using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Хранит значение высоты.
        /// </summary>
        private double _length;

        /// <summary>
        /// Хранит значение ширины.
        /// </summary>
        private double _width;

        /// <summary>
        /// Хранит значение количества созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Создает экземпляр класса Rectangle.
        /// </summary>
        /// <param name="length">Высота. Должна быть больше нуля.</param>
        /// <param name="width">Ширина. Должны быть больше нуля.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Координаты.</param>
        public Rectangle(double length, double width, string color, Point2D center)
        {
            Center = center;
            Length = length;
            Width = width;
            Color = color;
            _allRectanglesCount++;
            ID = _allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса Rectangle.
        /// </summary>
        public Rectangle() { }

        /// <summary>
        /// Возвращает и задает координаты прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Статическое свойство, которое возвращает количество созданных прямоугольников.
        /// </summary>
        public static int AllRectanglesCount => _allRectanglesCount;

        /// <summary>
        /// Возвращает и задает ID прямоугольника внутри класса.
        /// </summary>
        public int ID { get; private set; }

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает высоту прямоугольника. Должна быть больше нуля.
        /// </summary>
        public double Length
        {
            get { return _length; }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));

                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть больше нуля.
        /// </summary>
        public double Width
        {
            get { return _width; }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));

                _width = value;
            }
        }
    }
}
