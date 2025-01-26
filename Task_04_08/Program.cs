namespace Task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 50;
            int[] numbers = new int[size];

            // Заполнение массива случайными числами от 1 до 10
            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(1, 11); // Генерация случайных чисел от 1 до 10
            }

            // Вывод массива
            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            // Поиск количества пар равных элементов
            int pairCount = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        pairCount++;
                    }
                }
            }

            // Вывод результата
            Console.WriteLine($"Количество пар элементов, значения которых равны: {pairCount}");
        }
    }
}
