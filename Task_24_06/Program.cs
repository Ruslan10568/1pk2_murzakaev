namespace Task_24_06
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "путь_к_вашему_файлу.txt"; // Укажите путь к вашему файлу здесь
            try
            {
                int lineCount = CountLinesInFile(filePath);
                Console.WriteLine($"Количество строк в файле: {lineCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        static int CountLinesInFile(string filePath)
        {
            int lineCount = 0;

            // Используем StreamReader для чтения файла
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            return lineCount;
        }
    }
}
