namespace Task_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] precipitation = new int[30];
            int totalPrecipitation = 0;

            // Заполнение массива случайными значениями
            for (int i = 0; i < precipitation.Length; i++)
            {
                precipitation[i] = rnd.Next(0, 301);
                totalPrecipitation += precipitation[i];
            }

            // Определение общих осадков за декады
            for (int i = 0; i < 3; i++)
            {
                int decadePrecipitation = 0;
                for (int j = 0; j < 10; j++)
                {
                    decadePrecipitation += precipitation[i * 10 + j];
                }
                Console.WriteLine($"Общее количество осадков за декаду {i + 1}: {decadePrecipitation} мм");
            }

            // Поиск дня с самыми сильными осадками
            int maxPrecipitation = precipitation[0];
            int dayWithMaxPrecipitation = 0;

            for (int i = 1; i < precipitation.Length; i++)
            {
                if (precipitation[i] > maxPrecipitation)
                {
                    maxPrecipitation = precipitation[i];
                    dayWithMaxPrecipitation = i;
                }
            }
            Console.WriteLine($"День с самыми сильными осадками: {dayWithMaxPrecipitation + 1} (осадки: {maxPrecipitation} мм)");

            // Вывод дней без осадков
            Console.WriteLine("Дни без осадков:");
            for (int i = 0; i < precipitation.Length; i++)
            {
                if (precipitation[i] == 0)
                {
                    Console.WriteLine($"День {i + 1}");
                }
            }
        }
    }
}
