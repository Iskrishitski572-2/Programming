namespace Programming.Model.Geometry
{
        public class Rectangle
        {
            private double _length;
            private double _width;
            private static int _allRectanglesCount = 0;

            public Rectangle(double length, double width, string color, Point2D center)
            {
                Length = length;
                Width = width;
                Color = color;
                Center = center;
                _allRectanglesCount++;
                Id = _allRectanglesCount;
            }

            public Rectangle()
            {
                _allRectanglesCount++;
                Id = _allRectanglesCount;
            }

            public double Length
            {
                get => _length;
                set
                {
                    Validator.AssertOnPositiveValue(value, nameof(Length));
                    _length = value;
                }
            }

            public double Width
            {
                get => _width;
                set
                {
                    Validator.AssertOnPositiveValue(value, nameof(Width));
                    _width = value;
                }
            }

            public string Color { get; set; }
            
            public Point2D Center { get; set; }
            
            public static int AllRectanglesCount => _allRectanglesCount;

            public int Id { get; private set; }
        }
}