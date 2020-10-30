using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwL2Task2
{
    class Program
    {
        // Задание 2
        // Написать метод подсчета количества цифр числа.
        static int AmountOfCharInNumber(string num)
        {
            return num.Length;
        }
            
        static string GetNumberString()
        {
            string num = "Значение должно быть числовым./nПопробуйте еще раз.";
            bool checkNotAnumber;
            do
            {
                checkNotAnumber = false;
                num = Console.ReadLine();
                for (int i = 0; i < num.Length; i++)
                {
                    if (!Char.IsNumber(num, i))
                    {
                        checkNotAnumber = true;
                        Console.WriteLine("");
                        break;
                    }
                }
            } while (checkNotAnumber);
            return num;
        }
        static void Main(string[] args)
            {
                Console.WriteLine("Для подсчета количества цифр введите число: ");
                string num = GetNumberString();

                Console.WriteLine(Environment.NewLine + "Количество цифр в числе7: " + AmountOfCharInNumber(num));
                Console.ReadKey();

        }
    }
}
