namespace Task_21_02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Это пример текста. Почему бы и нет. Как бы вы себя не вели.";
            var wordCounts = CountWordOccurrences(text);

            // Выводим результат
            foreach (var kvp in wordCounts)
            {
                Console.WriteLine($"Слово: '{kvp.Key}', Количество вхождений: {kvp.Value}");
            }
        }

        static Dictionary<string, int> CountWordOccurrences(string text)
        {
            // Убираем знаки препинания и приводим текст к нижнему регистру
            char[] delimiters = { ' ', '.', ',', '!', '?', ';', ':', '-', '\n', '\r', '\t' };
            string[] words = text.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCountDictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCountDictionary.ContainsKey(word))
                {
                    wordCountDictionary[word]++;
                }
                else
                {
                    wordCountDictionary[word] = 1;
                }
            }

            return wordCountDictionary;
        }
    }
}
