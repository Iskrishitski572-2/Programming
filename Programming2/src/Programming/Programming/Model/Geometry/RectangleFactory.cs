using System;
using Programming.Model.Enums;

namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        private static Random _random = new Random();
        
        public static Rectangle Randomize()
        {
            var width = _random.Next(30, 50);
            var length = _random.Next(30, 60);
            
            var x = _random.Next(1, 300) ;
            var y = _random.Next(1, 300);
            var coordinate = new Point2D(x, y);
            
            var colorValues = Enum.GetValues(typeof(Color));
            var color = colorValues.GetValue(_random.Next(0, 6)).ToString();

            return new Rectangle(length, width, color, coordinate);
        }
    }
}