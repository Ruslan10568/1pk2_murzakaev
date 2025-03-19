namespace Task_10_06
{
    internal class Program
    {
      
    static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите размер массива n:");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                ArrayGeneration(n);
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите положительное целое число.");
            }
        }

        static void ArrayGeneration(int n)
        {
            int[,] array = new int[n, n];

            // Генерация массива (например, заполним его числами от 1 до n*n)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = (i * n) + j + 1; // Заполняем числами последовательно
                }
            }

            // Вывод массива на консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
        }
    }
}

