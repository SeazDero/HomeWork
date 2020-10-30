using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Task4
{
    class Program
    {
        // Задание 4
        // Решить задачу с логинами из урока 2, 
        // только логины и пароли считать из файла в массив. 
        // Создайте структуру Account, содержащую Login и Password.


       
        struct Account
        {

            public string login;
            public string password;

            /// <summary>
            /// Метод, для считывания логина и пароля из файла.
            /// </summary>
            /// <param name="file"></param>
            public void checkFile(string file)
            {
                file =  "..\\..\\" + file;
                StreamReader readfile = new StreamReader(file);

                login = readfile.ReadLine();
                password = readfile.ReadLine();
                readfile.Close();
            }
        }

        /// <summary>
        /// Метод, для проверки валидности логина  и пароля.
        /// </summary>
        /// <param name="check"></param>
        /// <returns></returns>
        static bool checkLogPass(Account check)
        {
            if (check.login == "user" && check.password == "qwerty")
                return true;
            else
                return false;
        }


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
                if(( a >= 2 && a <= 4) || (a >= 22 && a <= 24) || (a >= 32 && a <= 34) || (a >= 41 && a <= 45)) x += " попытки";
            else
                if ((a == 11) || (a >= 5 && a <= 20) || (a >= 25 && a <= 30) || (a >= 35 && a < 41) || (a > 44 && a < 51)) x += " попыток";
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа для проверки логина и пароля из файла.");
            int AmountTries = 3;

            string[] file = { "log.A.txt", "log.rt.txt", "log.Pro.txt" };
            Account account;
            account.login = "";
            account.password = "";
            int i = 0;

            do
            {
                Console.WriteLine("Файл загружается: " + file[i]);
                account.checkFile(file[i]);
                Console.WriteLine(" Идет авторизация: ");

                if (checkLogPass(account))
                {
                    break;
                }
                else
                {
                    AmountTries--;
                    Console.WriteLine("Неверный логин или пороль." + Environment.NewLine + "У вас осталось " + AmountTries + attempts(AmountTries));
                }
                i++;

            } while (AmountTries > 0);
            Console.WriteLine("Авторизация прошла успешно!");
            Console.ReadKey();
        }
    }
}
