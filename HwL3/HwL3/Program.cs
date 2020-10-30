using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HwL3
{
    class Program
    {
        // Задание 2
        // а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
        // Требуется подсчитать сумму всех нечётных положительных чисел. 
        // Сами числа и сумму вывести на экран, используя tryParse.

        /// <summary>
        /// Функция проверки ввода
        /// </summary>
        /// <returns></returns>
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int a))
                    Console.WriteLine("Требуется числовое значение.\nПопробуйте еще раз.");
                else return a;
        }
        static int CheckExeptionByInput()
        {
            int result = 0;
            bool exceptionCatch;
            do
            {
                exceptionCatch = false;
                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                { 
                exceptionCatch = true;
                string message = ex.Message;
                Console.WriteLine("Возникло исключение: " + message);
                Console.WriteLine("Попробуйте еще раз. Вводите числа, чтобы завершить нажмите 0: ");
                }

            } 
            while(exceptionCatch);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Вводите числа, чтобы зарешить нажмите 0: ");

            int OddNumbers = 0;
            while (true)
            {
                int numbers = CheckExeptionByInput();
                if (numbers == 0)
                {
                    break;
                }

                else if (numbers > 0 && numbers % 2 == 1)
                {
                    OddNumbers++;
                }
            }
            Console.WriteLine(Environment.NewLine + "Количество чисел:  " + OddNumbers);
            Console.ReadKey();
        }
        
    }
}
