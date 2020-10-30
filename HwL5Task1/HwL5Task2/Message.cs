using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwL5Task2
{
    static class Message
    {
        static public string text;

        static Message()
        {
            text = "Есть такая легенда - о птице, что поёт лишь один раз за всю жизнь, но зато прекраснее всех на свете..." +
                "\nОднажды она покидает свое гнездо и летит искать куст терновника и не успокоится, пока не найдёт..." +
            "Слова для частотного анализа: она, куст, гнездо, легенда";
        }

        /// <summary>Выводит слова сообщения, которые содержат не более n букв</summary>
        /// <param name="len">Длинна слова</param>
        static public void GetWordsByLength(int len)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= len)
                    Console.Write(word + " ");
            }
        }

        /// <summary>Метод, который удаляет из сообщения все слова, которые заканчиваются на заданный символ</summary>
        /// <param name="ch">Символ для поиска слов</param>
        static public void DeleteWordByEndChar(char ch)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == ch)
                {
                    Console.Write(word + " ");
                    text.Replace(word, "");
                }
            }

        }
        /// <summary>Метод, который ищет самое длинное слово сообщения</summary>
        /// <returns></returns>
        static public string FindMaxLengthWord()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            return maxWord;
        }

        /// <summary>Метод, для формирования строки StringBuilder из самых длинных слов сообщения</summary>
        /// <returns></returns>
        static public StringBuilder GetLongWordsString()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            StringBuilder result = new StringBuilder();
            int max = Message.FindMaxLengthWord().Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            return result;
        }

        /// <summary>Метод, частотного анализа текста</summary>
        /// <param name="words">Массив слов</param>
        /// <param name="text">Текст</param>
        static public void FrequencyAnalysis(string[] words, string text)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            string[] textWords = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string word in words)
            {
                foreach (string wordInText in textWords)
                {
                    if (word == "")
                        continue;
                    if (wordInText == word)
                    {
                        if (word == "")
                            continue;
                        if (wordFrequency.ContainsKey(word))
                            wordFrequency[word] += 1;
                        else
                            wordFrequency.Add(word, 1);
                    }
                }
            }
            ICollection<string> keys = wordFrequency.Keys;

            String result = String.Format("{0,-10} {1,-10}\n\n", "Слово", "Частота появления");

            foreach (string key in keys)
                result += String.Format("{0,-10} {1,-10:N0}\n",
                                   key, wordFrequency[key]);
            Console.WriteLine($"\n{result}");
        }


    }
}
