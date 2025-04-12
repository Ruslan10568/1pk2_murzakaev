namespace Task_24_07
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            // Укажите путь к файлу и слово для поиска
            string filePath = "path_to_your_file.txt"; // Путь к вашему текстовому файлу
            string searchWord = "ваше_слово"; // Слово, которое нужно искать

            try
            {
                List<string> matchingLines = FindLinesWithWord(filePath, searchWord);
                Console.WriteLine("Найденные строки:");
                foreach (string line in matchingLines)
                {
                    Console.WriteLine(line);
                }

                if (matchingLines.Count == 0)
                {
                    Console.WriteLine("Слово не найдено в файле.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        static List<string> FindLinesWithWord(string filePath, string word)
        {
            List<string> matchingLines = new List<string>();

            // Используем StreamReader для чтения файла
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Проверяем, содержит ли строка искомое слово (регистронезависимо)
                    if (line.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        matchingLines.Add(line);
                    }
                }
            }

            return matchingLines;
        }
    }
}
