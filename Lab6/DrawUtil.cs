using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class DrawUtil
    {
        public static double cosine(Point p1, Point p2)
        {
            double d0 = p1.X * p2.X + p1.Y * p2.Y;
            double d1 = Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y);
            return d0 / d1;
        }

        public static Point compute(Point p1, double angle)
        {
            double d1 = Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y);
            double x = -20 * p1.X / d1;
            double y = -20 * p1.Y / d1;
            double nx = x * Math.Cos(angle) - y * Math.Sin(angle);
            double ny = x * Math.Sin(angle) + y * Math.Cos(angle);
            return new Point((int)nx, (int)ny);
        }
    }
}
