using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TASK5._5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Напишите что нибудь:");
            //var something = Console.ReadLine();
            //Console.WriteLine("Укажите количество повторений");
            //var depth = int.Parse(Console.ReadLine()); 
            //Echo(something, depth);
            //Console.ReadLine();
            Console.WriteLine("Введите число");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень");
            var Pow = byte.Parse(Console.ReadLine());
            Console.WriteLine(PowerUp(number, Pow));
            Console.ReadLine();
        }

        static void Echo (string something, int depth)
        {
            Console.WriteLine("... "+something);
            if (depth > 0)
            {
                if (something.Length > 2)
                {
                    var modsomething = something.Remove(0, 2);
                    Console.BackgroundColor = (ConsoleColor)depth;                     
                    Echo(modsomething, depth - 1);
                }
            }
        }
        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        static int PowerUp (int number, byte Pow)
        {
            if (Pow == 0)
            {
                return 1;
            }
            else if (Pow == 1) 
            {
                return number;
            }
            else
            {
                return number * PowerUp(number, --Pow);
            }
        }
    }
}
