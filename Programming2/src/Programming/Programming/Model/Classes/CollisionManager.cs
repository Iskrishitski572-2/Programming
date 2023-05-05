using System;

namespace Programming.Model.Classes
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            var width1 = rectangle1.Width;
            var width2 = rectangle2.Width;

            var length1 = rectangle1.Length;
            var length2 = rectangle2.Length;
            
            var dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            var dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            
            return dX < width1 + width2 && dY < length1 + length2;
        }
        
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