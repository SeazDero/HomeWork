using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwL2
{
    class Program
    {
        // Задание 5
        // a) Написать программу, которая запрашивает массу и рост человека, 
        // вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
        // набрать вес или всё в норме.

        static void Main(string[] args)
        {
            Console.Write("Введите Ваш вес в кг: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите Ваш рост в см: ");
            double h = double.Parse(Console.ReadLine());
            h /= 100;
            Console.Write(Environment.NewLine + "Индекс массы тела: ");
            double bmi = m / (h * h);
            Console.WriteLine("{0:0.##}", bmi);
            Console.WriteLine(norm(bmi, h));
            Console.ReadKey();

        }
        static string norm(double BMI, double h)
        {
            string result = "";
            if (BMI >= 16.79 && BMI <= 21.11)
            {
                result = "Ваш индекс массы тела в норме.";
            }
            else if(BMI < 16.79)
            {
                result = "Ваш индекс массы тела меньше нормы./nВам необходимо набрать вес.";
            }
            else if (BMI > 21.11)
                {
                result = "Ваш индекс массы тела больше нормы./nВам необходимо сбросить вес.";
            }

            return result;
        }
    }
}
