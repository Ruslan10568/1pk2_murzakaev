namespace Task_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 5];

            for (int i = 0; i < 10; i++)
            {
                array[i, 0] = 0; 
                array[i, 1] = i * 2; // 2 столбец содержит числа кратные 2
                array[i, 2] = i * 3; // 3 столбец содержит числа кратные 3
                array[i, 3] = i * 4; // 4 столбец содержит числа кратные 4
                array[i, 4] = i * 5; // 5 столбец содержит числа кратные 5
            }

            // Вывод исходного массива
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Переворот массива (транспонирование)
            int[,] transposedArray = TransposeArray(array);

            // Вывод обновленного массива
            Console.WriteLine("Обновленный массив:");
            PrintArray(transposedArray);
        }

        // Метод для вывода массива
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t"); 
                }
                Console.WriteLine();
            }
        }

        // Метод для транспонирования массива
        static int[,] TransposeArray(int[,] array)
        {
            int rows1 = array.GetLength(0);
            int rows2 = array.GetLength(1);
            int[,] transposed = new int[rows2, rows1]; // Создаем новый массив с перевернутыми размерами

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < rows2; j++)
                {
                    transposed[j, i] = array[i, j]; // Меняем местами строки и столбцы
                }
            }

            return transposed; // Возвращаем перевернутый массив
        }

    }
}
