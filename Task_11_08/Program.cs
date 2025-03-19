namespace Task_11_08
{
    internal class Program
    {
    static void Main(string[] args)
        {
            // Вызов метода с переменным количеством аргументов
            int sum;
            int max;
            CalculateSumAndMax(out sum, out max, 2, 0, 8, 1, 9, 4);

            Console.WriteLine($"Сумма: {sum}, Максимальное значение: {max}");
        }

        static void CalculateSumAndMax(out int sum, out int max, params int[] numbers)
        {
            sum = 0;
            max = int.MinValue; // Инициализируем max минимально возможным значением

            foreach (var number in numbers)
            {
                sum += number; 
                if (number > max)
                {
                    max = number; // Находим максимальное значение
                }
            }
        }
    }
}
