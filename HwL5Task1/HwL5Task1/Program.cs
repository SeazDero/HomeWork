using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwL5Task1
{
    class Program
    {
        // Задание 1
        // Создать программу, которая будет проверять корректность ввода логина. 
        // Корректным логином будет строка от 2 до 10 символов, 
        // содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        // а) без использования регулярных выражений;


        /// <summary>
        /// Метод, для проверки склонения слова "попытка".
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static string attempts(int a)
        {
            string x = "";
            if (a % 10 == 1 && a != 11) x += "  попытка";
            else
                if ((a >= 2 && a <= 4) || (a >= 22 && a <= 24) || (a >= 32 && a <= 34) || (a >= 41 && a <= 45)) x += " попытки";
            else
                if ((a == 11) || (a >= 5 && a <= 20) || (a >= 25 && a <= 30) || (a >= 35 && a < 41) || (a > 44 && a < 51)) x += " попыток";
            return x;
        }

        /// <summary>
        /// Метод, для проверки корректности логина(латинские символы).
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        static bool LatinLetter(char letter)
        {
            int num = letter;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Метод, проверки валидности логина(лимит символов).
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        static bool CheckLog(string login)
        {
            int length = login.Length;
            if (length >= 2 && length <= 10)
            {
                bool check = true;
                char letter = login[0];
                if (Char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = login[i];
                    if (!(Char.IsDigit(letter) || LatinLetter(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для проверки валидности логина.");
            int AmountOfTries = 3;
            do
            {
                Console.WriteLine("Введите логин: ");
                string login = Console.ReadLine();

                if (CheckLog(login))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    AmountOfTries--;
                    Console.WriteLine("Ввод логина неверен." +
                        "\nЛогин должен содержать только буквы латинского алфавита и цифры;" +
                        "\nЦифра не может быть первой;" +
                        "\nДлина логина должна быть от 2 до 10 символов." 
                        + Environment.NewLine + "У вас осталось" + AmountOfTries + attempts);

                        
                }
            } while (AmountOfTries > 0);
            Console.WriteLine("Логин валиден");
            Console.ReadKey();
        }
    }
}
