using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Программа проверяет принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0 ");
            Console.Write("Введите радиус окружности :");
            double r = int.Parse(Console.ReadLine());

            Console.Write("Введите координату точки по оси абсцисс:");
            double x = int.Parse(Console.ReadLine());

            Console.Write("Введите координату точки по оси ординат:");
            double y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Длинна окружности:{Circle.GetLength(r)}");
            Console.WriteLine($"Прощадь окружности:{Circle.GetArea(r)}");

            if (Circle.IsPointInCircle(x, y, r))
                Console.Write("Точка пренадлежит окружности");
            else
                Console.Write("Точка НЕ пренадлежит окружности");

            Console.ReadKey();
        }
    }
}
