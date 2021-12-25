using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
{
    public static class Circle
    {        
        public static double GetLength(double radius) => 2 * Math.PI * radius;
                
        public static double GetArea(double radius) => Math.PI * Math.Pow(radius, 2);
                
        public static bool IsPointInCircle(double x, double y, double radius) => Math.Sqrt(x * x + y * y) <= radius;

    }
}
