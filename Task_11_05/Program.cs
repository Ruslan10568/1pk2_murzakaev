namespace Task_11_05
{
    internal class Program
    {
       
    static void Main(string[] args)
        {
            int a = 4;
            int b = 7;

            GetSumAndProduct(ref a, ref b, out int sum, out int product);    // Вызов метода для получения суммы и произведения

            Console.WriteLine($"Сумма: {sum}, Произведение: {product}"); // Вывод результатов
        }

        static void GetSumAndProduct(ref int x, ref int y, out int sum, out int product)
        {
            sum = x + y;           // Рассчитываем сумму
            product = x * y;      // Рассчитываем произведение
        }
    }
}
