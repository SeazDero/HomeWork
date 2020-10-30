using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Task1
{
    class Program
    {
        // Задание 1
        // Дан  целочисленный  массив  из 20 элементов.  
        // Элементы  массива  могут принимать  целые  значения  
        // от –10 000 до 10 000 включительно. Заполнить случайными числами.  
        // Написать программу, позволяющую найти и вывести количество пар элементов массива, 
        // в которых только одно число делится на 3. 
        // В данной задаче под парой подразумевается два подряд идущих элемента массива.


        /// <summary>
        /// Метод подсчета количества пар элемента массива, в которых хотя бы одно число делится на 3.
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="length">Длинна массива</param>
        /// <returns></returns>
        static int GetNumPairsArray(int[] array, int length)
        {
            int amountOfPairs = 0;
            for (int i = 0; i < length-1; i++)
            {
                if (array[i] % 3 == 0 || array[i+1] % 3 == 0)
                {
                    amountOfPairs++;
                }
            }
            return amountOfPairs;
        }

        static void Main(string[] args)
        {
            const int arrayLength = 20;
            int[] array1 = new int[arrayLength];
            Random random = new Random();
            int result;

            Console.WriteLine("Эта программа расчитывает пары элементов, в которых хотя бы одно число делится на 3.\nВ этом массиве [");
            for (int i = 0; i < arrayLength; i++)
            {
                array1[i] = random.Next(-10000, 10001);
                Console.Write(array1[i] + ", ");
            }
            Console.WriteLine("\b\b ]\n");
            result = GetNumPairsArray(array1, arrayLength);
            Console.WriteLine("Количество пар: " + result);
            Console.ReadKey();
        }
    }
}
