namespace Task_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 25; // Размер массива
            int[] numbers = new int[size];
            bool[] isUsed = new bool[size + 1]; // Массив для отслеживания использованных модулей

            for (int i = 0; i < size; i++)
            {
                int num;
                do
                {
                    num = rnd.Next(-size, size + 1); // Генерация числа в диапазоне от -size до size
                }
                while (num == 0 || isUsed[Math.Abs(num)]); // Проверка на уникальность по модулю

                numbers[i] = num;
                isUsed[Math.Abs(num)] = true; // Помечаем модуль как использованный
            }

            // Вывод сгенерированного массива
            Console.WriteLine("Сгенерированный массив:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Поиск наибольшего по модулю числа
            int maxAbsoluteValue = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i]) > Math.Abs(maxAbsoluteValue))
                {
                    maxAbsoluteValue = numbers[i];
                }
            }

            Console.WriteLine($"Наибольшее по модулю число: {maxAbsoluteValue}");
        }
    }
}
