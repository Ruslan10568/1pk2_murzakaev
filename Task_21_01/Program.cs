namespace Task_21_01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Исходный список чисел
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Создаем новый список, содержащий только четные числа, умноженные на 10
            List<int> evenNumbersMultipliedByTen = numbers
                .Where(n => n % 2 == 0) // Фильтрация только четных чисел
                .Select(n => n * 10)    // Умножение четных чисел на 10
                .ToList();              // Преобразование в список

            // Выводим результат
            Console.WriteLine("Четные числа, умноженные на 10:");
            foreach (var number in evenNumbersMultipliedByTen)
            {
                Console.WriteLine(number);
            }
        }
    }
}
