namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем две 3x3 матрицы символов
            char[,] matrix1 = {
            { 'f', 'h', 'h' },
            { 'w', 'g', 'k' },
            { 'a', 'f', 'j' }
        };

            char[,] matrix2 = {
            { 'f', 'h', 'h' },
            { 'w', 'g', 'm' }, 
            { 'a', 'f', 'j' }
        };

            CompareMatrices(matrix1, matrix2); // Вызываем метод для сравнения матриц
        }

        // Сравнение двух матриц
        static void CompareMatrices(char[,] matrix1, char[,] matrix2)
        {
            bool matrix_equal = true; // Переменная для отслеживания равенства матриц

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        matrix_equal = false;
                    }
                }
            }

            // Проверяем значение переменной 
            if (matrix_equal)
            {
                Console.WriteLine("Матрицы равны");
            }
            else
            {
                Console.WriteLine("Матрицы не равны");
                DisplayMatrices(matrix1, matrix2); 
            }
        }

        // Отображение матриц с цветовой индикацией
        static void DisplayMatrices(char[,] matrix1, char[,] matrix2)
        {
            // Выводим первую матрицу с цветовой индикацией
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Если элементы равны, выводим их зелёным
                    if (matrix1[i, j] == matrix2[i, j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green; 
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; 
                    }

                    // Выводим элемент матрицы
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.ResetColor();  
                Console.WriteLine(); 
            }

            // Выводим вторую матрицу с цветовой индикацией
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Если элементы равны, выводим их зелёным
                    if (matrix1[i, j] == matrix2[i, j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green; 
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; 
                    }

                    // Выводим элемент матрицы
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.ResetColor();
                Console.WriteLine(); 
            }
        }
    }
}
