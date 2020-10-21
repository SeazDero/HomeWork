using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwL3Task1
{
    // Задание 1
    // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
    // Продемонстрировать работу структуры. 
    // б) Дописать класс Complex, добавив методы вычитания и произведения чисел.
    // Проверить работу класса. 

    struct Complex
    {
        public double a;
        public double b;

        public Complex GetComplexMinus(Complex z)
        {
            Complex x;
            x.a = a - z.a;
            x.b = b - z.b;
            return x;
        }

        public Complex GetComplexPlus(Complex z)
        {
            Complex x;
            x.a = a + z.a;
            x.b = b + z.b;
            return x;
        }

        public Complex GetComplex(Complex z)
        {
            Complex x;
            x.a = b * z.a + a * z.b;
            x.b = b * z.b - a * z.a;

        }

        public string ToString()
        {
            return b + "+" + a + "i";
        }

    }
    class Program
    {
  
        static void Main(string[] args)
        {
            Complex complex2;
            complex2.b = 1;
            complex2.a = 1;

            Complex complex1;
            complex1.b = 2;
            complex1.a = 2;

            Console.WriteLine("Результатом работы структуры: ");
            Complex result = complex2.GetComplexPlus(complex1);
            Console.WriteLine("Результат сложения чисел: " + complex2.ToString() + " и " + complex1.ToString() + " будет " + result.ToString());

            Complex result = complex2.GetComplex(complex1);
            Console.WriteLine("Результатом умножения чисел: " + complex2.ToString() + " и " + complex1.ToString() + " будет " + result.ToString());

            Complex result = complex2.GetComplexMinus(complex1);
            Console.WriteLine("Результатом вычитания чисел: " + complex2.ToString() + " и " + complex1.ToString() + " будет " + result.ToString());
            Console.WriteLine();

            Console.WriteLine("Результат работы класса: ");
            Complexx complexx2 = new Complexx(1, 1);
            Complexx complexx1 = new Complexx(2, 2);
            complex1.Im = 3;
            


            Complexx resultt = complexx2.GetComplexPlus(complexx1);
            Console.WriteLine("Результатом сложения чисел: " + complexx2.ToString() + " и " + complexx1.ToString() + " будет " + resultt.ToString());

            Complexx resultt = complexx2.GetComplex(complexx1);
            Console.WriteLine("Результатом умножения чисел: " + complexx2.ToString() + " и " + complexx1.ToString() + " будет " + resultt.ToString());

            Complexx resultt = complexx2.GetComplexMinus(complexx1);
            Console.WriteLine("Результатом вычитания чисел: " + complexx2.ToString() + " и " + complexx1.ToString() + " будет " + resultt.ToString());
            Console.ReadKey();

        }
    }
}
