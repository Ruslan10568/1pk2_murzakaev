namespace Task_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 20;
            int[] numbers = new int[size];

            // Заполнение массива случайными числами от 1 до 20
            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(1, 21); // Генерация случайных чисел от 1 до 20
            }

            // Вывод массива
            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            // Поиск уникальных элементов
            Console.WriteLine("Уникальные элементы в массиве:");
            for (int i = 0; i < size; i++)
            {
                bool isUnique = true; // Предполагаем, что элемент уникален

                // Проверяем, встречается ли элемент еще раз в массиве
                for (int j = 0; j < size; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        isUnique = false; // Если нашли совпадение, элемент не уникален
                        break; // Выходим из внутреннего цикла
                    }
                }

                // Если элемент уникален, выводим его
                if (isUnique)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}

