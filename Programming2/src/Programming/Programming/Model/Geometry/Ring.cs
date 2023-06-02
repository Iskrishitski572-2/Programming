namespace Programming.Model.Geometry
{
    public class Ring
    {
        private double _outerRadius;
        private double _innerRadius;

        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }

        public Point2D Center { get; private set; }

        public double Area
        {
            get => Math.PI * _outerRadius * _outerRadius - Math.PI * _innerRadius * _innerRadius;
        }

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