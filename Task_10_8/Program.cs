namespace Task_10_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };  // Создаем и заполняем пример массива

            Console.WriteLine("Введите число для поиска:");  // Запрашиваем у пользователя число для поиска
            int searchNumber;

            if (int.TryParse(Console.ReadLine(), out searchNumber))             // Проверяем, правильно ли введено число
            {
                int index = FindIndex(numbers, searchNumber);                 // Вызываем метод для поиска и получаем индекс

                // Проверяем, найден ли элемент и выводим результат
                if (index != -1)
                {
                    Console.WriteLine($"Элемент {searchNumber} найден на индексе {index}.");
                }
                else
                {
                    Console.WriteLine($"Элемент {searchNumber} не найден в массиве.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        }

        // Метод для поиска индекса элемента в массиве
        static int FindIndex(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                // Если нашли искомый элемент, возвращаем его индекс
                if (array[i] == target)
                {
                    return i; // Возвращаем индекс найденного элемента
                }
            }

            // Если элемент не найден, возвращаем -1
            return -1;
        }
    }
}