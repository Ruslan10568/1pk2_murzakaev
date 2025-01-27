namespace Task_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 10;
            int[] numbers = new int[size];

            // Заполнение массива случайными числами от -10 до 10
            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(-10, 11); // Генерация случайных чисел от -10 до 10
            }

            // Создаем массив из 10 элементов
            int[] array = new int[10];
            Random random = new Random();

            // Заполняем массив случайными числами в интервале [-10..10]
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 11);
            }

            Console.WriteLine("Исходный массив: " + string.Join(", ", array));

            // Реверс для первой половины массива
            for (int i = 0; i < 5 / 2; i++)
            {
                int temp = array[i];
                array[i] = array[4 - i];
                array[4 - i] = temp;
            }

            // Реверс для второй половины массива
            for (int i = 0; i < 5 / 2; i++)
            {
                int temp = array[5 + i];
                array[5 + i] = array[9 - i];
                array[9 - i] = temp;
            }

            Console.WriteLine("Результат: " + string.Join(", ", array));
        }
        
    }
}

