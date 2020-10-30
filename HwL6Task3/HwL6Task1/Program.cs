using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HwL6Task1
{

    // Задание 1
    // Изменить программу вывода таблицы функции так, 
    // чтобы можно было передавать функции типа double (double, double). 
    // Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x)

    public delegate double Funcс(double a, double x);

    class Program
    {
        /// <summary>
        /// Метод принимающий делегат.
        /// </summary>
        /// <param name="F"></param>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <param name="b"></param>
        public static void Table(Funcс F, double a, double x, double b)
        {
            Console.WriteLine("-----A ------X -----Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000}", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("--------------------------");
        }


        /// <summary>
        /// Метод возвращения значения функции a*x^2.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double FuncD(double a, double x)
        {
            return a * x * x;
        }


        /// <summary>
        /// Метод возвращения значения функции a*sin(x).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Sinn(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            Console.WriteLine("Таблица функции a*x^2: ");
            Table(new Funcс(FuncD), -1.5, -2, 2);
            Console.WriteLine("Таблица функции a*sin(x): ");
            Table(new Funcс(FuncD), 3, -2, 2);

            Console.ReadKey();

        }
    }
}
