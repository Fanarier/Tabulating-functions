//Плотников Кирилл 22-ИСП-2/2 
//Вариант: 16
//Шаг: 0,2
//Функция: |x^2-4|+0,25*x-2
//Интервал: [0,1;2,7]
using System;
using System.Globalization;
using System.Text;

namespace ConsoleAppCSharp
{
 
    class Program
    {
        static double f(double x)
        {
            return Math.Abs(x*x-4)+0.25*x-2;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите xmin = ");
            Double xmin= double.Parse(Console.ReadLine());
            Console.Write("Введите xmax = ");
            Double xmax = double.Parse(Console.ReadLine());
            Console.Write("Введите dx = ");
            Double dx = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("x\ty");
            double x = xmin;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (x > xmax)
                    Console.WriteLine(xmax.ToString("#.##") + "\t" + f(xmax).ToString("#.###"));
                else
                    Console.WriteLine(x.ToString("#.##") + "\t" + f(x).ToString("#.###"));
                x += dx;
                Console.ForegroundColor = ConsoleColor.Green;
            } while (x <= xmax + dx);
            Console.ReadKey();
        }
    }
}
