namespace Task_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = 10;

            // Создание двух массивов 10x10
            int[,] array1 = new int[size, size];
            int[,] array2 = new int[size, size];
            int[,] resultArray = new int[size, size];

            Random random = new Random();

            // Заполнение первого массива случайными числами от 1 до 9
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array1[i, j] = random.Next(1, 10);
                }
            }

            // Заполнение второго массива случайными числами от 1 до 9
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array2[i, j] = random.Next(1, 10); 
                }
            }

            // Вычисление произведения двух массивов
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    resultArray[i, j] = array1[i, j] * array2[i, j];
                }
            }

            // Вывод результирующего массива
            Console.WriteLine("результирующий массив (произведение двух массивов):");
            PrintArray(resultArray);
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
    }
    
}
