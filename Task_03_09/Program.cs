namespace Task_03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первоначальную сумму вклада (x):");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите годовой процент (p):");
            double p = double.Parse(Console.ReadLine()) / 100; // Преобразуем в доли

            Console.WriteLine("Введите целевую сумму (y):");
            double y = double.Parse(Console.ReadLine());

            int years = 0;

            while (x < y)
            {
                x += x * p; // Увеличиваем вклад
                x = Math.Floor(x); // Отбрасываем дробную часть
                years++;
            }

            Console.WriteLine($"Вклад достигнет не менее {y} рублей через {years} лет.");
        }
    }
}
