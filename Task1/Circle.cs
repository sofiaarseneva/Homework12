using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal static class Circle
    {
        //длина окружности
        static public double GetLenght(double r)
        {
            return 2 * Math.PI * r;
        }
        //площадь окружности
        static public double GetSqureCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        //проверка на принадлежность точки к заданной окружности
        static public string HasPoint(double r, double x0, double y0, double x1, double y1)
        {
            double r2 = Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2);
            if (r2 > r * r)
            {
                return $"Точка лежит вне окружности, так как значение, полученное через уравнение данной окружности больше квадрата радиуса окружности: {r2} > {r * r}";
            }
            else if (r2 == r * r)
            {
                return $"Точка лежит на самой окружности, так как значение, полученное через уравнение данной окружности равно квадрату радиуса окружности: {r2} = {r * r}";
            }
            else
            {
                return $"Точка лежит внутри окружности, так как значение, полученное через уравнение данной окружности меньше квадрата радиуса окружности: {r2} < {r * r}";
            }
        }
    }
}
