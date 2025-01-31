namespace Task_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрос размеров массива у пользователя
            Console.Write("Введите количество строк (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов (m): ");
            int m = int.Parse(Console.ReadLine());

            // Создание массива
            int[,] array = new int[n, m];
            Random random = new Random();

            // Заполнение массива случайными числами
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(-99, 100); 
                }
            }

            // Преобразование и вывод массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] < 0)
                    {
                        // Если элемент меньше нуля, отбрасываем знак и выделяем зеленым цветом
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Math.Abs(array[i, j]) + " ");
                    }
                    else if (array[i, j] == 0)
                    {
                        // Если элемент равен нулю, перезаписываем единицу и выделяем красным цветом
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(1 + " ");
                    }
                    else
                    { 
                        Console.Write(array[i, j] + " ");
                    }

                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
    
}
