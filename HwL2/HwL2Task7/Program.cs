using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwL2Task6
{
    class Program
    {
        // Задание 6
        // *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        // «Хорошим» называется число, которое делится на сумму своих цифр. 
        // Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int a))
                    Console.WriteLine("Требуется числовое значение./nПопробуйте еще раз.");
                else 
                    return a;
        }
        static bool GoodNum(int value)
        {
            string x = Convert.ToString(value);
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i] - '0';
            }
            if (value % sum == 0)
                return true;
            else
                return false;
         } 
        static void Main(string[] args)
        {
            int AmountOfGoodNum = 0;
            Console.WriteLine("Задайте диапозон от 1 до ");

            int end = GetInt();
            DateTime start = DateTime.Now;
            for (int i = 1; i < end; i++)
            {
                if(GoodNum(i))
                {
                    AmountOfGoodNum++;
                }
            }

            Console.WriteLine(DateTime.Now - start);
            Console.WriteLine(" В заданном диапозоне " + AmountOfGoodNum + " хороших чисел");
            Console.ReadKey();

        }
    }
}
