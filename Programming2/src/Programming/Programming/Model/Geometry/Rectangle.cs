namespace Programming.Model.Geometry
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private static int _allRectanglesCount = 0;

        public Rectangle(double length, double width, string color, Point2D center)
        {
            Center = center;
            Length = length;
            Width = width;
            Color = color;
            _allRectanglesCount++;
            ID = _allRectanglesCount;
        }

        public Rectangle() { }

        public Point2D Center { get; set; }

        public static int AllRectanglesCount => _allRectanglesCount;

        public int ID { get; private set; }

        public string Color { get; set; }

        public double Length
        {
            get { return _length; }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));

                _length = value;
            }
        }

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
