using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwL6Task3
{
    class Program
    {
        // Задание 3
        // Переделать программу Пример использования коллекций для решения следующих задач:
        // а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        // б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
        // в) отсортировать список по возрасту студента;
        // г) отсортировать список по курсу и возрасту студента;

        /// <summary>
        /// Метод, сравнения эксземпляров.
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int CompareAge(Students st1, Students st2)
        {
            return String.Compare(st1.age.ToString(), st2.age.ToString());
        }

        static int CompareAgeAndCourse(Students st1, Students st2)
        {
            if (st1.course > st2.course)
                return 1;
            if (st1.course < st2.course)
                return -1;
            if (st1.age > st2.age)
                return 1;
            if (st1.age < st2.age)
                return -1;
            return 0;
        }

        static void Main(string[] args)
        {
            int magistr1 = 0;
            int magistr2 = 0;
            List<Students> list = new List<Students>();
            DateTime dt = DateTime.Now;
            Dictionary<int, int> frequencyCourse = new Dictionary<int, int>();
            StreamReader sr = new StreamReader("..\\..\\students_6.txt");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Students(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]),  int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    if (int.Parse(s[6]) == 5) magistr1++; else if (int.Parse(s[6]) == 6) magistr2++;
                    if (int.Parse(s[5]) > 17 && int.Parse(s[5]) < 21)
                    {
                        if (frequencyCourse.ContainsKey(int.Parse(s[6])))
                            frequencyCourse[int.Parse(s[6])] += 1;
                        else
                            frequencyCourse.Add(int.Parse(s[6]), 1);
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Ошибка, нажммите Enter чтобы выйти из программы.");
                    if (Console.ReadKey().Key == ConsoleKey.Enter) return;
                }
            }

            sr.Close();
            Console.WriteLine("Всего студентов: " + list.Count);
            Console.WriteLine("Магистров 1-го курса:{0}", magistr1);
            Console.WriteLine("Магистров 2-го курса:{0}", magistr2);
            Console.WriteLine("\nСчитаем сколько студентов в возрасте от 18 до 20 лет учатся и на каких курсах. ");
            ICollection<int> keys = frequencyCourse.Keys;
            String result = String.Format("{0,-10} {1,-10}\n", "Курс", "Количество студентов");
            foreach (int key in keys)
                result += String.Format("{0,-10} {1,-10:N0}\n",
                                key,  frequencyCourse[key]);
            Console.WriteLine($"\n{result}");

            list.Sort(new Comparison<Students>(CompareAge));
            Console.WriteLine("Отсортировка студентов по возрасту: ");
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age}");

            list.Sort(new Comparison<Students>(CompareAgeAndCourse));
            Console.WriteLine("Отсортировка студентов по курсу и возрасту: ");
            foreach (var v in list) Console.WriteLine($"{v.firstName}, курс {v.course}, возраст {v.age}");

            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();

        }
    }
}
