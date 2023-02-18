using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program

    {
        /// <summary>
        /// Метод возвращающий кортеж
        /// </summary>
        /// <returns></returns>
        static (string, string, byte , bool, byte, byte, string[], string[]) TellAboutYourself()
        {
            Console.Write("Введите ваше имя: ");
            string name = HaveaNumber();
            Console.Write("Введите вашу фамилию: ");
            string surname = HaveaNumber();
            Console.Write("Введите ваш возраст ");
            byte age = CorrectNumber();
            Console.Write("У вас есть питомцы: ");
            bool haveapet;
            string answer = HaveaNumber();
            haveapet = (((answer == "Да") || (answer == "ДА") || (answer == "да"))==true) ? haveapet = true: haveapet = false; // тернарный оператор
            byte howmanypets;
            if (haveapet == false)
            {
                howmanypets = 0;
            }
            else
            {
                Console.Write("Сколько у вас питомцев ");
                howmanypets = CorrectNumber();
            }
            string[] pets = NamePets(howmanypets);
            Console.Write("Сколько у вас любимых цветов: ");
            byte howmanycolors = CorrectNumber();
            string[] colors = YourFavColors(howmanycolors);
            return (name, surname, age, haveapet, howmanypets, howmanycolors, pets, colors);

        }
        /// <summary>
        /// Клички питомцев
        /// </summary>
        /// <param name="howmany"></param>
        /// <returns></returns>
        static string[] NamePets(byte howmany)
        {
            string[] namepets = new string[howmany];
            for(int i=0; i<howmany; i++)
            {
                Console.Write("Как зовут вашего {0} питомца: ", i+1);
                namepets[i] = HaveaNumber();
            }
            return namepets;
        }
        /// <summary>
        /// Любиые цвета пользователя
        /// </summary>
        /// <param name="howmanycolors"></param>
        /// <returns></returns>
        static string[] YourFavColors (byte howmanycolors)
        {
            string[] favcolors = new string[howmanycolors];
            
            for (int j=0; j<howmanycolors; j++)
            {
                Console.Write("Какой ваш любимый цвет {0}: ", j+1);
                favcolors[j] = HaveaNumber();
            }
            return favcolors; 
        }
        /// <summary>
        /// Метод проверяющий является ли ответ числом
        /// </summary>
        /// <returns></returns>
        static byte CorrectNumber ()
        {
            bool iscorrect = false;
            byte number = 0;
            while (iscorrect == false)
            {
                iscorrect = byte.TryParse(Console.ReadLine(), out number);
                if (iscorrect == false || number == 0) Console.WriteLine("Введите пожалуйста число больше нуля");
            }
            return number;
        }
        /// <summary>
        /// Метод выводящий информацию о пользователе
        /// </summary>
        /// <param name="user"></param>
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
                Console.WriteLine();
            }
                Console.Write("Ваши любимые цвета: ");
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
        /// <summary>
        /// Дополнительный метод имеются ли цифры в имени
        /// </summary>
        /// <returns></returns>
        static string HaveaNumber()
        {
            string answer="";
            bool donthaveanumb = false;
            while (donthaveanumb == false || answer.Length == 0)
            {
                string Nums = "1234567890";
                answer = Console.ReadLine();
                donthaveanumb = true;
                for (int z = 0; z < answer.Length; z++)
                {
                    for (int z2 = 0; z2 < Nums.Length; z2++) 
                    {
                        if (answer[z] == Nums[z2])
                        {
                            donthaveanumb = false;
                            Console.WriteLine("В ответе содержатся цифры, пожалуйста не используете цифры в ответе");
                            break;
                        }
                    }
                    if (donthaveanumb == false) break;
                }
                if (answer.Length == 0) Console.WriteLine("Ответ пустой пожалуйста введите символы");
            }
            return answer;
        }
        
    }
}
