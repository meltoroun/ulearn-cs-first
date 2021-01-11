using System;

namespace Rectangles
{
    public static class RectanglesTask
    {
        public static bool AreIntersected(Rectangle r1, Rectangle r2)
        {
            if (r1.Left <= r2.Left && r2.Left <= r1.Right && r1.Top <= r2.Top && r2.Top <= r1.Bottom) return true;
            if (r1.Left <= r2.Left && r2.Left <= r1.Right && r2.Top <= r1.Top && r1.Top <= r2.Bottom) return true;
            if (r2.Left <= r1.Left && r1.Left <= r2.Right && r2.Top <= r1.Top && r1.Top <= r2.Bottom) return true;
            if (r2.Left <= r1.Left && r1.Left <= r2.Right && r1.Top <= r2.Top && r2.Top <= r1.Bottom) return true;
            else return false;
        }

        public static int IntersectionSquare(Rectangle r1, Rectangle r2)
        {            
            int upperSegment = 0;
            int sideSegment = 0;

            if (AreIntersected(r1, r2))
            {                
                if (r1.Left <= r2.Left)
                    upperSegment = Math.Min(r1.Right, r2.Right) - r2.Left;
                else
                    upperSegment = Math.Min(r1.Right, r2.Right) - r1.Left;
                
                if (r1.Top <= r2.Top)
                    sideSegment = Math.Min(r1.Bottom, r2.Bottom) - r2.Top;
                else
                    sideSegment = Math.Min(r1.Bottom, r2.Bottom) - r1.Top;
            }
            return sideSegment * upperSegment;
        }

        public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            if (r1.Left <= r2.Left && r1.Top <= r2.Top) 
                if (r2.Right <= r1.Right && r2.Bottom <= r1.Bottom) return 1;
           
            if (r2.Left <= r1.Left && r2.Top <= r1.Top)
                if (r1.Right <= r2.Right && r1.Bottom <= r2.Bottom) return 0;
            
            return -1;
        }
    }
}
