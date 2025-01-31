namespace Task_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрос размера массива у пользователя
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            // Создание массива
            int[,] matrix = new int[n, n];
            Random random = new Random();

            // Заполнение массива случайными числами от -15 до 915
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(-15, 16); // Генерация числа от -15 до 15
                }
            }

            // Вывод исходной матрицы
            Console.WriteLine("Исходная матрица:");
            PrintArray(matrix);

            // Проверка на Z-матрицу
            if (IsZMatrix(matrix))
            {
                Console.WriteLine("Данная матрица является Z-матрицей. Вывод с цветовой индикацией главной диагонали:");
                PrintArrayWithDiagonalHighlight(matrix);
            }
            else
            {
                Console.WriteLine("Данная матрица не является Z-матрицей.");
            }
        }

        // Проверка, является ли матрица Z-матрицей
        static bool IsZMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // Проверяем, что недиагональные элементы меньше нуля
                    if (i != j && matrix[i, j] >= 0)
                    {
                        return false; // Если найден элемент >= 0, не Z-матрица
                    }
                }
            }
            return true; 
        }

        // Метод для вывода массива с цветовой индикацией главной диагонали
        static void PrintArrayWithDiagonalHighlight(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; 
                    }
                    Console.Write(matrix[i, j] + "\t"); 
                    Console.ResetColor(); 
                }
                Console.WriteLine(); 
            }
        }

        // Метод для вывода массива
        static void PrintArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t"); 
                }
                Console.WriteLine();
            }
        }
    }
    
}
