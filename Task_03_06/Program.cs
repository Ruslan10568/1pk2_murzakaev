namespace Task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double startX = -4;
            double endX = 4;
            double step = 0.5;

            Console.WriteLine("x");
            

            for (double x = startX; x <= endX; x += step)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"{x}");
            }
        }
    }
}
