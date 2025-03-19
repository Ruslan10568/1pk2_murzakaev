namespace Task_11_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализируем две переменные
            int a = 8;
            int b = 4;

            Console.WriteLine($"Перед заменой: a = {a}, b = {b}");   // Печатаем значения перед тем, как менять их местами

            Swap(ref a, ref b);  // Вызываем метод, передавая переменные по ссылке

            Console.WriteLine($"После замены: a = {a}, b = {b}"); // Печатаем значения после вызова метода
        }

        // Метод, который меняет местами два целых числа
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y; // Присваиваем значение y переменной x
            y = temp; // Присваиваем сохраненное значение temp переменной y
        }
    }
}

