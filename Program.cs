using System;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Коваль Ангеліна");

            Console.WriteLine("КН21-1");

            double a, b, c;

            Console.WriteLine("Введіть число а");

            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число b");

            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число c");

            c = double.Parse(Console.ReadLine());

            if (a == 0 && b != 0 && c != 0)
            {
                double x;
                Console.WriteLine("Ваше рівняння" + b + "x + " + c + " = 0");
                x = -c / b;
                Console.WriteLine("Ваша відповідь х = " + x);
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine("Ваша відповідь c != 0");
            }
            else if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("Ваша відповідь 0 = 0");
            }
            else
            {
                Console.WriteLine("Ваше рівняння " + a + "x^2 + " + b + "x + " + c + " = 0");

                Console.WriteLine("Знайдемо дискримінант");

                double D;

                D = Math.Pow(b, 2) - (4 * a * c);

                Console.WriteLine("D = (b^2) - 4ac = " + D);

                if (D == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Дискримінант = 0, ваша відповідь х = " + x);
                }
                else if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("Дискримінант > 0, ваша відповідь х1 = " + x1 + ", x2 = " + x2);
                }
                else if (D < 0)
                {
                    Console.WriteLine("Перевірте коректність ваших даних");
                }
            }


        }
    }
}



