using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты центра круга (x0,y0)");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите радиус круга");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки (x,y), \n пренадлежность кругу которой необходимо проверить ");

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Длина окружности = {0}, площать круга = {1}, принадлежит точка кругу - {2}", 
                Circle.GetCircumference(r),
                Circle.GetSquare(r),
                (Circle.DoesPointBelongToCircle(x0,y0,r,x,y))?"да":"нет");
            Console.ReadKey();
        }

    }
}
