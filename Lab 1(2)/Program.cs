using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 a = new Class2();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите коэффициент а:");
                a.A = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите коэффициент b:");
                a.B = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите коэффициент c:");
                a.C = Convert.ToDouble(Console.ReadLine());
                double d = Math.Pow(a.B, 2) - 4 * a.A * a.C;

                if (d < 0)
                {
                    Console.Write("Если коэффициенты уравнения ax^2+bx+c=0 равны a = " + a.A + ", b = " + a.B + ", c = " + a.C + ",то корней нет");
                }

                else if (d >= 0)
                {
                    double res2 = (-a.B + Math.Sqrt(d)) / 2 * a.A;
                    double res3 = (-a.B - Math.Sqrt(d)) / 2 * a.A;
                    Console.Write("Если коэффициенты уравнения ax^2+bx+c=0 равны a = " + a.A + ", b = " + a.B + ", c = " + a.C + "  то корня два! x1 = " + res2 + ", x2 = " + res3);
                }
            }
        }
    }
}
