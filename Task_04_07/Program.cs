namespace Task_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 30; // Размер массива
            int[] heights = new int[size];

            // Заполнение массива случайными значениями ростов
            for (int i = 0; i < size; i++)
            {
                // Генерируем рост от 120 до 200 см для девочек (положительно)
                // и от -120 до -200 см для мальчиков (отрицательно)
                if (rnd.Next(0, 2) == 0) // Случайный выбор: 0 - девочка, 1 - мальчик
                {
                    heights[i] = rnd.Next(120, 201); // Рост девочек
                }
                else
                {
                    heights[i] = -rnd.Next(120, 201); // Рост мальчиков
                }
            }

            int boysCount = 0;
            int girlsCount = 0;
            int boysSum = 0;
            int girlsSum = 0;

            // Анализ массива
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] < 0)
                {
                    boysCount++;
                    boysSum += -heights[i]; // Убираем знак для подсчета
                }
                else
                {
                    girlsCount++;
                    girlsSum += heights[i];
                }
            }

            // Вычисление и вывод результатов
            double averageBoysHeight = boysCount > 0 ? (double)boysSum / boysCount : 0;
            double averageGirlsHeight = girlsCount > 0 ? (double)girlsSum / girlsCount : 0;

            Console.WriteLine($"Количество мальчиков: {boysCount}");
            Console.WriteLine($"Количество девочек: {girlsCount}");
            Console.WriteLine($"Средний рост мальчиков: {averageBoysHeight:F1} см");
            Console.WriteLine($"Средний рост девочек: {averageGirlsHeight:F1} см");
        }
    }
}
    

