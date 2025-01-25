namespace Task_03_05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double startC = double.Parse(Console.ReadLine());

            double endC = double.Parse(Console.ReadLine());

            double step = double.Parse(Console.ReadLine());

            Console.WriteLine("Температура в Цельсии\tТемпература в Фаренгейте");
            Console.WriteLine("-------------------");

            for (double c = startC; c <= endC; c += step)
            {
                double f = c * 1.8 + 32;
                Console.WriteLine($"{c}\t\t\t{f}");
            }
        }
    }
}
