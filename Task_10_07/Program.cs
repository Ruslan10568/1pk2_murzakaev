namespace Task_10_07
{
    internal class Program
    {

            // Главный метод, откуда начинается выполнение программы
            static void Main(string[] args)
            {
                char[,] charArray = GenerateCharArray(5, 5);  // Генерируем массив размером 5x5 и сохраняем его в переменной

            PrintCharArray(charArray);  // Выводим сгенерированный массив на консоль
        }

            // Метод для генерации двумерного массива символов русского алфавита
            static char[,] GenerateCharArray(int rows, int columns)
            {
                char[,] array = new char[rows, columns];

                char startChar = 'а'; // Начальный символ
                int alphabetLength = 32; // Длина русского алфавита (32 буквы)

                // Заполняем массив символами русского алфавита
                for (int i = 0; i < rows; i++) // Проходим по строкам
                {
                    for (int j = 0; j < columns; j++) // Проходим по столбцам
                    {
                        // Заполняем массив символами русского алфавита циклично
                        array[i, j] = startChar; // Заполняем текущее место символом
                        startChar++; // Переходим к следующему символу

                        if (startChar > 'я')   // Если достигли конца алфавита, начинаем сначала
                    {
                            startChar = 'а'; // Возвращаемся к началу алфавита
                        }
                    }
                }

                return array; // Возвращаем заполненный массив
            }

            // Метод для вывода двумерного массива символов на консоль
            static void PrintCharArray(char[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++) // GetLength(0) возвращает количество строк
                {
                    for (int j = 0; j < array.GetLength(1); j++) // GetLength(1) возвращает количество столбцов
                    {
                        Console.Write(array[i, j] + " ");
                    }

                    Console.WriteLine();   // После каждой строки переходим на новую строку
            }
            }
        }
    }
