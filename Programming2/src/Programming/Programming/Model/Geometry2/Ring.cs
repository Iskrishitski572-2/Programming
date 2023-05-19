using System;

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
        
        public Point2D Center { get; set; }

        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                if (value < _innerRadius)
                {
                    throw new System.AggregateException("OuterRadius не может быть меньше InnerRadius");
                }
                else
                {
                    _outerRadius = value;
                }
            }
        }

        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                if (value > _outerRadius)
                {
                    throw new System.AggregateException("InnerRadius не может быть больше OuterRadius");
                }
                else
                {
                    _innerRadius = value;
                }
            }
        }

        public double Area
        {
            get => (Math.PI * Math.Pow(_outerRadius, 2)) - (Math.PI * Math.Pow(_innerRadius, 2));
        }
    }
}