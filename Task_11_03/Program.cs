namespace Task_11_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример строки для анализа
            string input = "Привет, мир! Как настроение?";

            // Переменные для хранения количества гласных и согласных
            int vowelsCount; // Для гласных
            int consonantsCount; // Для согласных

            // Вызываем метод, передавая строку и выходные параметры
            CountLetters(input, out vowelsCount, out consonantsCount);

            // Выводим результаты на консоль
            Console.WriteLine($"Количество гласных букв: {vowelsCount}");
            Console.WriteLine($"Количество согласных букв: {consonantsCount}");
        }

        // Метод для подсчета гласных и согласных букв
        static void CountLetters(string input, out int vowelsCount, out int consonantsCount)
        {
            vowelsCount = 0; // Инициализируем счетчик гласных
            consonantsCount = 0; // Инициализируем счетчик согласных

            // Определяем гласные буквы на русском языке
            char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я',
                          'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' };

            foreach (char ch in input)
            {
                if (char.IsLetter(ch)) // Проверяем, является ли символ буквой
                {
                    // Проверяем, является ли буква гласной
                    if (Array.Exists(vowels, element => element == ch))
                    {
                        vowelsCount++; 
                    }
                    else
                    {
                        consonantsCount++; 
                    }
                }
            }
        }
    }
}
    