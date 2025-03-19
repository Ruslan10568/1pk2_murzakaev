namespace Task_11_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример вызова метода с массивом чисел
            double average = CalculateAverage(1, 2, 3, 4, 5);
            Console.WriteLine($"Среднее значение: {average}");

            // Можно также передавать массив чисел
            double[] numbersArray = { 10, 20, 30, 40, 50 };
            average = CalculateAverage(numbersArray);
            Console.WriteLine($"Среднее значение для массива: {average}");
        }

        // Метод для вычисления среднего значения, используя params
        static double CalculateAverage(params double[] numbers)
        {
            // Проверяем, есть ли числа для расчета
            if (numbers.Length == 0)
            {
                return 0; 
            }

            double sum = 0; // Инициализируем переменную для хранения суммы

            // Проходим по всем числам и накапливаем сумму
            foreach (double number in numbers)
            {
                sum += number; 
            }

            // Вычисляем среднее значение
            double average = sum / numbers.Length;
            return average;
        }
    }
}
