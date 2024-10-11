using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для работы с окружностью!\n\n ");
            try
            {
                Console.WriteLine("Доступные режимы: \n" +
                    "1. Определение длины окружности по радиусу\n" +
                    "2. Определение площади круга по радиусу\n" +
                    "3. Проверка принадлежности точки с заданными координатами кругу с радиусом r и координатами центра");
                Console.WriteLine("\nВведите номер выбранного режима:");
                int t = Convert.ToInt32(Console.ReadLine());
                double r;
                switch (t)
                {
                    case 1:
                        Console.WriteLine("Введите радиус окружности: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Длина окружности с радиусом {0} равна {1}", r, Circle.GetLenght(r));
                        break;
                    case 2:
                        Console.WriteLine("Введите радиус окружности: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Площадь круга с радиусом {0} равна {1}", r, Circle.GetSqureCircle(r));
                        break;
                    case 3:
                        Console.WriteLine("Введите радиус окружности: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату Х центра окружности: ");
                        double x0 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату Y центра окружности: ");
                        double y0 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату Х точки: ");
                        double x1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату Y точки: ");
                        double y1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Circle.HasPoint(r, x0, y0, x1, y1));
                        break;
                    default:
                        throw new Exception("Номер данного режима не определен!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
