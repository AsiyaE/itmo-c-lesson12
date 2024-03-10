using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12_task1
{
    static class Circle
    {
        static public double GetSquare(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        static public double GetCircumference(double r)
        {
            return 2 * Math.PI * r;
        }

        static public bool DoesPointBelongToCircle(double x0, double y0, double r, double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2));
            return distance <= r;
        }
    }
}
