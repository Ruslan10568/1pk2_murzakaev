namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.8; 
            double step = 0.5; 
            double maxTime = 10; 

            Console.WriteLine("  Время (с)\tСкорость (м/с)");
            Console.WriteLine("------------------------------");

            for (double t = 0; t <= maxTime; t += step)
            {
                double v = g * t;
                Console.WriteLine($"{t}\t\t{v}"); 
        }
    }
}
