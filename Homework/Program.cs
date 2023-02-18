using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static (string, string, byte , bool, byte, byte, string[], string[]) TellAboutYourself()
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите ваш возраст ");
            byte age = byte.Parse(Console.ReadLine());
            while (CorrectNumber(age) == false) 
            {
                age = byte.Parse(Console.ReadLine());
            }
            Console.Write("У вас есть питомцы: ");
            bool haveapet;
            string answer = Console.ReadLine();
            if ((answer == "Да") || (answer == "ДА") || (answer == "да"))
            {
                haveapet = true;
            }    
            else
            {
                haveapet = false;
            }
            byte howmanypets;
            if (haveapet == false)
            {
                howmanypets = 0;
            }
            else
            {
                Console.Write("Сколько у вас питомцев ");
                howmanypets = byte.Parse(Console.ReadLine());
                while (CorrectNumber(howmanypets) == false)
                {
                    howmanypets = byte.Parse(Console.ReadLine());
                }    
            }
            string[] pets = NamePets(howmanypets);
            Console.Write("Сколько у вас любимых цветов: ");
            byte howmanycolors = byte.Parse(Console.ReadLine());
            while (CorrectNumber(howmanycolors)== false)
            { 
                howmanycolors = byte.Parse(Console.ReadLine());
            }
            string[] colors = YourFavColors(howmanycolors);
            return (name, surname, age, haveapet, howmanypets, howmanycolors, pets, colors);

        }
        static string[] NamePets(byte howmany)
        {
            string[] namepets = new string[howmany];
            for(int i=0; i<howmany; i++)
            {
                Console.WriteLine("Как зовут вашего {0} питомца: ", i+1);
                namepets[i] = Console.ReadLine();
            }
            return namepets;
        }
        static string[] YourFavColors (byte howmanycolors)
        {
            string[] favcolors = new string[howmanycolors];
            
            for (int j=0; j<howmanycolors; j++)
            {
                Console.Write("Какой ваш любимый цвет {0}: ", j+1);
                favcolors[j] = Console.ReadLine();
            }
            return favcolors; 
        }
        static bool CorrectNumber (byte somenumber)
        {
            if (somenumber == 0)
            {
                Console.WriteLine("вы вввели неверное число, повторите ввод ");
                return false;
            }
            return true;
        }
        static void Answer((string, string, byte, bool, byte, byte, string[], string[]) user)
        {
            Console.Write("Ваше имя {0} ", user.Item1);
            Console.Write("Ваша фамилия {0} ", user.Item2);
            Console.WriteLine("Вам {0} лет", user.Item3);
            if (user.Item4 == false)
            {
                Console.WriteLine("У вас нет питомцев ");
            }
            else 
            {
                Console.Write("Ваших питомцев зовут: ");
                foreach (var e in user.Item7)
                {
                    Console.Write(e + ", ");
                }
            }
            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var e in user.Item8)
            {
                Console.Write(e + ", ");
            }
        }
        static void Main(string[] args)
        {
            Answer(TellAboutYourself());
            Console.ReadLine();
        }
    }
}
