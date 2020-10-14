using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwL2Task7a
{
    class Program
    {
        // Задание 7
        // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).

        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int a))
                    Console.WriteLine("Требуется числовое значение./nПопробуйте еще раз.");
                else return a;
        }

        static void Recursion(int start, int end)
        {
            if(start == end)
            {
                Console.WriteLine("\b\b");
                Console.WriteLine("");
                return;
            }
            else
            {
                Console.WriteLine(start + ", ");
                start++;
                Recursion(start, end);
            }
        }


            static void Main(string[] args)
        {
            Console.WriteLine("Введите число а: ");
            int a = GetInt();
            Console.WriteLine("Введите число b: ");
            int b = GetInt();

            Console.WriteLine("Числа входящие в промежуток: ");
            Recursion(a, b);
            Console.ReadKey();
        }
    }
}
