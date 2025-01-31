namespace Task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n = 4;
                int[,] matrix = {
            { 1, 0, 0, 0 },
            { 0, 2, 0, 0 },
            { 0, 0, 3, 0 },
            { 0, 0, 0, 4 },
        };

                // Проверяем, является ли матрица диагональной
                if (IsDiagonalMatrix(matrix, n))
                {
                    // Если диагональная, выводим ее с выделением главной диагонали
                    DisplayDiagonalMatrix(matrix, n);
                }
                else
                {
                    Console.WriteLine("Матрица не является диагональной.");
                }
            }

            // Метод для проверки, является ли матрица диагональной
            static bool IsDiagonalMatrix(int[,] matrix, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        // Проверяем элементы вне главной диагонали
                        if (i != j && matrix[i, j] != 0)
                        {
                            return false; // Если нашли ненулевой элемент, возвращаем false
                        }
                    }
                }
                return true; // Если все элементы вне диагонали нулевые, возвращаем true
            }

            // Отображения диагональной матрицы с выделением главной диагонали
            static void DisplayDiagonalMatrix(int[,] matrix, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        // Если элемент на главной диагонали, выводим его зелёным
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
    }
}
