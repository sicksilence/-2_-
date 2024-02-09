using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр2_сертификация
{
    internal class Program
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Raz(int x, int y)
        {
            return x - y;
        }

        public static int P(int x, int y)
        {
            return x * y;
        }
        public static double Del(int x, int y)
        {
            return x / y;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Простейший калькулятор");
            Console.WriteLine("Ведите 2 числа:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выбериде действие \n1-сумма \n2-разность \n3-произведение \n4-деление");
            int n = Convert.ToInt32(Console.ReadLine());
            bool a = true;
            while (a)
            {
                switch (n)
                {
                    case 1:
                        {
                            int s = Sum(x, y);
                            Console.WriteLine(Sum(x, y));
                            Console.WriteLine("Выбериде действие \n1-сумма \n2-разность \n3-произведение \n4-деление");
                            n = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(Raz(x, y));
                            Console.WriteLine("Выбериде действие \n1-сумма \n2-разность \n3-произведение \n4-деление");
                            n = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(P(x, y));
                            Console.WriteLine("Выбериде действие \n1-сумма \n2-разность \n3-произведение \n4-деление");
                            n = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(Del(x, y));
                            a = false;
                            break;

                        }
                }
            }
        }
    }
}