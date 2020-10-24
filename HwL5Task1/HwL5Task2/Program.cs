using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HwL5Task2
{
    class Program
    {
        // Задание 2
        // Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        // а) Вывести только те слова сообщения,  которые содержат не более n букв.
        // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        // в) Найти самое длинное слово сообщения.
        // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        // д) Создать метод, который производит частотный анализ текста.
        // В качестве параметра в него передается массив слов и текст, 
        // в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
        // Здесь требуется использовать класс Dictionary.

        static void Main(string[] args)
        {
            Console.WriteLine("Программа для демонстрации класса Message.");
            Console.WriteLine("\nТекст: \n" + Message.text);
            Console.WriteLine("\nВыведем слова текста, содержащие не больше 3 букв: ");
            Message.GetWordsByLength(3);
            Console.WriteLine();
            Console.WriteLine("\nУдаляемиз текста, слова заканчивающиеся на 'б': ");
            Message.DeleteWordByEndChar('б');
            Console.WriteLine();
            Console.WriteLine("\nСамое длинное слово в тексте: " + Message.FindMaxLengthWord());
            Console.WriteLine("Сформированна строка StringBuilder из самых длинных слов: \n" + Message.GetLongWordsString());
            Console.WriteLine("\nЧастотный анализ текста: ");
            string[] array = { "она", "куст", "гнездо", "легенда" };
            Message.FrequencyAnalysis(array, Message.text);
            Console.ReadKey();
        }
    }
}
