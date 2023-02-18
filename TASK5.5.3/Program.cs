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
            Console.WriteLine("Напишите что нибудь:");
            var something = Console.ReadLine();
            Console.WriteLine("Укажите количество повторений");
            var depth = int.Parse(Console.ReadLine()); 
            Echo(something, depth);
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
    }
}
