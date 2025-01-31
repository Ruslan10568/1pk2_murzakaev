namespace Task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Запрос размера массива у пользователя
                Console.Write("Введите размер массива n: ");
                int n = int.Parse(Console.ReadLine());

                // Создание массива
                int[,] array = new int[n, n];
                Random random = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = random.Next(10, 100); // Генерация числа от 10 до 99
                    }
                }

                Console.WriteLine("Исходный массив:");
                PrintArray(array);

                // Нахождение минимального элемента
                int minElement = FindMinElement(array);
                Console.WriteLine($"Минимальный элемент: {minElement}");

                // Умножение массива на минимальный элемент
                int[,] multipliedArray = MultiplyByMinElement(array, minElement);

                // Вывод обновленного массива с выделением пяти максимальных значений
                Console.WriteLine("Обновленный массив (умноженный на минимальный элемент):");
                PrintArrayWithMaxHighlight(multipliedArray);
            }

            // Вывод массива
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

            // Нахождение минимального элемента
            static int FindMinElement(int[,] array)
            {
                int min = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < min)
                        {
                            min = array[i, j];
                        }
                    }
                }
                return min;
            }

            //Умножение массива на минимальный элемент
            static int[,] MultiplyByMinElement(int[,] array, int minElement)
            {
                int[,] result = new int[array.GetLength(0), array.GetLength(1)];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        result[i, j] = array[i, j] * minElement;
                    }
                }
                return result;
            }

            //Вывод массива с выделением пяти максимальных значений
            static void PrintArrayWithMaxHighlight(int[,] array)
            {
                // Находим пять максимальных значений
                int[] maxValues = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    maxValues[i] = int.MinValue;
                }

                // Поиск максимальных значений
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        int currentValue = array[i, j];
                        for (int k = 0; k < maxValues.Length; k++)
                        {
                            if (currentValue > maxValues[k])
                            {
                                // Сдвиг значений
                                for (int l = maxValues.Length - 1; l > k; l--)
                                {
                                    maxValues[l] = maxValues[l - 1];
                                }
                                maxValues[k] = currentValue;
                                break;
                            }
                        }
                    }
                }

                // Вывод массива с выделением максимальных значений
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        bool isMaxValue = false;
                        for (int k = 0; k < maxValues.Length; k++)
                        {
                            if (array[i, j] == maxValues[k])
                            {
                                isMaxValue = true;
                                break;
                            }
                        }

                        if (isMaxValue)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow; // Выделяем цветом
                        }

                        Console.Write(array[i, j] + "\t"); 
                        Console.ResetColor(); 
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}



